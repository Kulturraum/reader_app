using System;
using System.Collections.Generic;
using System.IO;
using Xamarin.Forms;
using ReadNListen.Interfaces;

[assembly: Dependency(typeof(ReadNListen.Droid.Implementations.FilesManager))]

namespace ReadNListen.Droid.Implementations
{
    class FilesManager : IFilesManager
    {
        public FilesManager()
        {
            if (!Directory.Exists(GetDocsPath()))
                Directory.CreateDirectory(GetDocsPath());
        }
        public bool Exists(string filename)
        {
            string filepath = GetFilePath(filename);
            return File.Exists(filepath);
        }

        public IEnumerable<string> Files()
        {
            return Directory.GetFiles(GetDocsPath());
        }
        
        public string GetFilePath(string filename)
        {
            return Path.Combine(GetDocsPath(), filename);
        }
        public string GetDocsPath()
        {
            return Path.Combine(Android.OS.Environment.ExternalStorageDirectory.AbsolutePath, "ReadNListen");
        }
    }
}