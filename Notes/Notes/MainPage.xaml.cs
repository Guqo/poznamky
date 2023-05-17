using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Notes
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }
        private async void Btn_Clicked(object sender, EventArgs e)
        {
            string datum = date.Text;
            string poznamka = poznamkaEntry.Text;
        await DisplayAlert($"Tvá poznámka ze dne {datum}:", $"{poznamka}", "OK");
        }
    }
}
