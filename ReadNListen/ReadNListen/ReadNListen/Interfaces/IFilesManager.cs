using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReadNListen.Interfaces
{
    public interface IFilesManager
    {
        void Create();
        string[] Files();
    }
}
