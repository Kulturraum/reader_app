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
        public bool Exists(string filename)
        {
            string filepath = GetFilePath(filename);
            return File.Exists(filepath);
        }

        public IEnumerable<string> GetFiles()
        {
            return Directory.GetFiles(GetDocsPath());
        }
        public void Delete(string filename)
        {
            File.Delete(GetFilePath(filename));
        }

        // Private methods.
        string GetFilePath(string filename)
        {
            return Path.Combine(GetDocsPath(), filename);
        }
        string GetDocsPath()
        {
            return Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
        }
    }
}