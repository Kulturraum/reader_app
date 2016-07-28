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
        public StartPage()
        {
            InitializeComponent();
        }

        public event EventHandler LibraryButtonClicked;

        public void OnLibraryButtonClicked(object sender, EventArgs args)
        {
            LibraryButtonClicked.Invoke(null, EventArgs.Empty);
        }
    }
}
