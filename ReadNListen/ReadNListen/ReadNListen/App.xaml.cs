using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Xamarin.Forms;
using ReadNListen.Pages;

namespace ReadNListen
{
    public partial class App : Application
    {
        StartPage startPage = new StartPage();
        public App()
        {
            InitializeComponent();
            MainPage = startPage;
            startPage.LibraryButtonClicked += delegate { MainPage = new LibraryPage(); };
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
