using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using ReadNListen.Elements;

namespace ReadNListen.Pages
{
    public class WebViewPage : ContentPage
    {
        public WebViewPage(string path)
        {
            Padding = new Thickness(0, 20, 0, 0);
            Content = new StackLayout
            {
                Children = {
                new CustomWebView {
                    Uri = path,
                    HorizontalOptions = LayoutOptions.FillAndExpand,
                    VerticalOptions = LayoutOptions.FillAndExpand
                }
            }
            };
        }
    }
}
