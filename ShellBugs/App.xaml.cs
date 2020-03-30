using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using ShellBugs.Services;
using ShellBugs.Views;

namespace ShellBugs
{
    public partial class App : Application
    {

        public App()
        {
            InitializeComponent();
            
            DependencyService.Register<MockDataStore>();
            MainPage = new AppShell();
        }

        protected override async void OnStart()
        {
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }
    }
}
