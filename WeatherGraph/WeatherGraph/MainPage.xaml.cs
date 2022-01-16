using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using WeatherGraph.Model;
using Xamarin.Forms;

namespace WeatherGraph
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
            
        }
       
        private void OnGetWeatherButtonClicked(object sender, EventArgs e)
        {
           
            App.WeatherViewModel.WebQuestion(_cityEntry.Text);
            BindingContext = App.WeatherViewModel.WeatherDatas;
           


        }

       
    }
   
}
