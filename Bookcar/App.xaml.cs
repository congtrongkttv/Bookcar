﻿using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using Bookcar.Services;
using Bookcar.Views;

namespace Bookcar
{
    public partial class App : Application
    {

        public App()
        {
            InitializeComponent();

            DependencyService.Register<MockDataStore>();
            DependencyService.Register<MockDataStoreVehicles>();
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
