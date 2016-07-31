using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Xamarin.Forms;
using ReadNListen.Pages;
using ReadNListen.Interfaces;

namespace ReadNListen
{
    public partial class App : Application
    {
        StartPage startPage;
        
        public App()
        {
            InitializeComponent();
            startPage = new StartPage();
            OnStartPage();
        }

        public void OnStartPage()
        {
            startPage.Update();
            MainPage = startPage;
        }

        public bool InStartPage => MainPage == startPage;
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
