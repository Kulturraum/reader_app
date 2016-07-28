using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using ReadNListen.Interfaces;

namespace ReadNListen.Pages
{
    public partial class LibraryPage : ContentPage
    {
        public LibraryPage()
        {
            InitializeComponent();
            foreach (string path in DependencyService.Get<IFilesManager>().GetFiles())
                booksLayout.Children.Add(new Label { Text = path });
        }
    }
}
