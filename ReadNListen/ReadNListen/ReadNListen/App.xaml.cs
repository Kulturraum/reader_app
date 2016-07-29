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
        StartPage startPage = new StartPage();
        IFilesManager filesManager = DependencyService.Get<IFilesManager>();
        Books books;
        public App()
        {
            InitializeComponent();
            filesManager.Create();
            books = new Books(filesManager.Files());
            MainPage = startPage;
            startPage.LibraryButtonClicked += delegate { MainPage = new LibraryPage(books.ToList()); };
        }

        public void OnStartPage()
        {
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
