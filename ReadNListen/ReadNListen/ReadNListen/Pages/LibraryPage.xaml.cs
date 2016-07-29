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
        public LibraryPage(List<Book> books)
        {
            InitializeComponent();
            foreach (Book book in books)
                booksLayout.Children.Add(book.Label);
        }
    }
}
