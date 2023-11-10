using System;
using Tarea1._4.Services;
using Tarea1._4.Views;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Tarea1._4
{
    public partial class App : Application
    {

        public App()
        {
            InitializeComponent();

            DependencyService.Register<MockDataStore>();
            MainPage = new AppShell();
        }

        protected override void OnStart()
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
