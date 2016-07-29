using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using ReadNListen;

namespace ReadNListen.Pages.Elements
{
    class BookLabel : Label
    {
        public BookLabel(string path)
        {
            Path = path;
            Text = System.IO.Path.GetFileName(path);
        }

        public string Path { get; private set; }
    }
}
