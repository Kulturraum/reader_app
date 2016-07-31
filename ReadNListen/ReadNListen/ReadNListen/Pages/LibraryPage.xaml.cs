using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using Xamarin.Forms;
using ReadNListen.Interfaces;

namespace ReadNListen.Pages
{
    public partial class LibraryPage : ContentPage
    {
        public LibraryPage()
        {
            InitializeComponent();
            foreach(string file in Global.filesManager.Files())
            {
                if (Path.GetExtension(file) == ".pdf")
                {
                    Label bookLabel = new Label
                    {
                        Text = Path.GetFileNameWithoutExtension(file)
                    };
                    bookLabel.GestureRecognizers.Add(new TapGestureRecognizer()
                    {
                        Command = new Command(() =>
                        {
                            App.Current.MainPage = new WebViewPage(file);
                            App.Current.Properties["lastBook"] = Path.GetFileName(file);
                        })
                    });
                    booksLayout.Children.Add(bookLabel);
                }
            }
        }
    }
}
