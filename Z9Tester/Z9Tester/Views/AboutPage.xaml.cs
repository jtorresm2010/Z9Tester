using System;
using System.ComponentModel;
using System.Diagnostics;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Z9Tester.Views
{
    // Learn more about making custom code visible in the Xamarin.Forms previewer
    // by visiting https://aka.ms/xamarinforms-previewer
    [DesignTimeVisible(false)]
    public partial class AboutPage : ContentPage
    {
        public AboutPage()
        {
            InitializeComponent();
        }
        int num = 0;
        private void Handle_TouchCompleted(VisualElement sender, TouchEffect.EventArgs.TouchCompletedEventArgs args)
        {
            Debug.WriteLine($"~(>'.')> Test de animacion {num}");
            //DisplayAlert("Thank you", ":)", "OK");
            num++;
        }
    }
}