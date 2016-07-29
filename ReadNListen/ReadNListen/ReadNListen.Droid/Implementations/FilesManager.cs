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
        public void Create()
        {
            if(!Directory.Exists(GetDocsPath()))
                Directory.CreateDirectory(GetDocsPath());
        }

        public string[] Files()
        {
            return Directory.GetFiles(GetDocsPath());
        }

        // Private methods.
        string GetFilePath(string filename)
        {
            return Path.Combine(GetDocsPath(), filename);
        }
        string GetDocsPath()
        {
            return Path.Combine(Android.OS.Environment.ExternalStorageDirectory.AbsolutePath, "ReadNListen");
        }

    }
}