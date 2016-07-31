using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;

using Xamarin.Forms;
using Xamarin.Forms.Platform.Android;
using ReadNListen.Elements;
using System.Net;

[assembly: ExportRenderer(typeof(CustomWebView), typeof(ReadNListen.Droid.CustomWebViewRenderer))]
namespace ReadNListen.Droid
{
    public class CustomWebViewRenderer : WebViewRenderer
    {
        protected override void OnElementChanged(ElementChangedEventArgs<WebView> e)
        {
            base.OnElementChanged(e);

            if (e.NewElement != null)
            {
                var customWebView = Element as CustomWebView;
                Control.Settings.AllowUniversalAccessFromFileURLs = true;
                Control.LoadUrl("file:///android_asset/pdfjs/web/viewer.html?file=" + customWebView.Uri);

                //Doesn't open books with whitespaces
                //Control.LoadUrl("file:///android_asset/pdfjs/web/viewer.html?file=" + WebUtility.UrlEncode(customWebView.Uri));
            }
        }
    }
}