using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReadNListen.Interfaces
{
    public interface IFilesManager
    {
        bool Exists(string filename);
        IEnumerable<string> GetFiles();
        void Delete(string filename);
    }
}
