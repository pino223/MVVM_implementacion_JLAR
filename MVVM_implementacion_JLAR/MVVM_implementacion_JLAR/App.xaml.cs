﻿using MVVM_implementacion_JLAR.Vista;
using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace MVVM_implementacion_JLAR
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new Pagina1();
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
