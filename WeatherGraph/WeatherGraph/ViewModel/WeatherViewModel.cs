using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Net.Http;
using System.Text;
using WeatherGraph.Model;
using Xamarin.Forms;

namespace WeatherGraph.ViewModel
{
    public class WeatherViewModel
    {
        public WeatherData.Main WeatherDatas= new WeatherData.Main();

        

        //public event PropertyChangedEventHandler PropertyChanged;

        public async void WebQuestion(string location)
        {
            try
            {
                
                string URL = "http://api.openweathermap.org/data/2.5/weather?q=" + location + "&APPID=66118e8ea1f62d5915c9b6126437259d&units=metric";
                HttpClient httpClient = new HttpClient();
                HttpResponseMessage response = await httpClient.GetAsync(new Uri(URL));


                if (response.IsSuccessStatusCode)
                {
                   
                    string content = await response.Content.ReadAsStringAsync();
                    var _weatherDatas = (JsonConvert.DeserializeObject<WeatherData.Rootobject>(content));
                    WeatherDatas =_weatherDatas.main;
                            
                }
                
            }
            catch (Exception ex)
            {
                await Application.Current.MainPage.DisplayAlert("Error", "There is an issue at the moment and the API could not be reached. (" + ex.Message + ")", "OK");
            }

        }

    }
}
