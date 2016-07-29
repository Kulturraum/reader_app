using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;

namespace ReadNListen
{
    class Books : Dictionary<string, Book>
    {
        public Books(string[] paths)
        {
            foreach (string path in paths)
                if(System.IO.Path.GetExtension(path) == ".pdf")
                    Add(System.IO.Path.GetFileName(path), new Book(path));
        }

        public List<Book> ToList()
        {
            return Values.ToList<Book>();
        }
    }
}
