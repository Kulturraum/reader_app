using ReadNListen.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;

namespace ReadNListen.Pages
{
    public partial class StartPage : ContentPage
    {
        Button lastBookButton;
        public StartPage()
        {
            InitializeComponent();
        }

        public void Update()
        {
            if (App.Current.Properties.ContainsKey("lastBook"))
            {
                string filename = (string)App.Current.Properties["lastBook"];

                if (lastBookButton == null && Global.filesManager.Exists(filename))
                {
                    lastBookButton = new Button { Text = "Last Book" };

                    lastBookButton.Clicked += delegate
                    {
                        App.Current.MainPage = new WebViewPage(Global.filesManager.GetFilePath(filename));
                    };
                    StartPageLayout.Children.Add(lastBookButton);
                }
                else if(lastBookButton != null && !Global.filesManager.Exists(filename))
                {
                    StartPageLayout.Children.Remove(lastBookButton);
                    lastBookButton = null;
                }
            }
        }

        public void OnLibraryButtonClicked(object sender, EventArgs args)
        {
            App.Current.MainPage = new LibraryPage();
        }
    }
}
