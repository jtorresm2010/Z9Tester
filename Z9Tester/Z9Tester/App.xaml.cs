using Matcha.BackgroundService;
using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using Z9Tester.Services;
using Z9Tester.ShellViews;
using Z9Tester.ViewModels;
using Z9Tester.Views;

namespace Z9Tester
{
    public partial class App : Application
    {

        public App()
        {

            BackgroundAggregatorService.Add(() => new PeriodicSevice(3));

            //Start the background service
            BackgroundAggregatorService.StartBackgroundService();

            InitializeComponent();

            MainViewModel.GetInstance().About = new AboutViewModel();
            MainViewModel.GetInstance().Search = new SearchViewModel();

            DependencyService.Register<MockDataStore>();
            //MainPage = new MainPage();
            MainPage = new ShellPage();
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
            BackgroundAggregatorService.StartBackgroundService();


            // Handle when your app resumes
        }
    }
}
