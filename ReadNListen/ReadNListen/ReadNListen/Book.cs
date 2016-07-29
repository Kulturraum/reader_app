using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;

namespace ReadNListen
{
    public class Book
    {
        public Book(string path)
        {
            Path = path;
            Name = System.IO.Path.GetFileNameWithoutExtension(path);
            Label = new Label { Text = Name };
        }

        public Label Label { get; private set; }
        public string Path { get; private set; }
        public string Name { get; private set; }
    }
}
