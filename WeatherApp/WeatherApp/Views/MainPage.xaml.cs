using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using WeatherApp.Models.Service;
using WeatherApp.ViewModel;
using Xamarin.Forms;

namespace WeatherApp
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();

            BindingContext = new WeatherViewModel(); ;  
        }

        protected async override void OnAppearing()
        {
            base.OnAppearing();

            var vm = BindingContext as WeatherViewModel;

            await vm.APIAsync();
        }

      
       
    }
}
