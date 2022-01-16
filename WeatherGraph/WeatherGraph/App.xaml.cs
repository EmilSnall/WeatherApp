using System;
using WeatherGraph.ViewModel;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

[assembly: XamlCompilation(XamlCompilationOptions.Compile)]
namespace WeatherGraph
{
    public partial class App : Application
    {
        public static WeatherViewModel WeatherViewModel { get; set; } = new WeatherViewModel();
        public App()
        {
            InitializeComponent();
            //App.WeatherViewModel.WebQuestion("");
            MainPage = new MainPage();
        }

        protected override void OnStart()
        {
            // Handle when your app starts
        }

        protected override void OnSleep()
        {
            // Handle when your app sleeps
        }

        protected override void OnResume()
        {
            // Handle when your app resumes
        }
    }
}
