using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using ReadNListen.Interfaces;

namespace ReadNListen
{
    public static class Global
    {
        public static IFilesManager filesManager = DependencyService.Get<IFilesManager>();
    }
}
