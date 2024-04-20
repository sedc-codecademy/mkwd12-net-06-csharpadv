using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class10_Demo
{
    public class CustomWrtiter : IDisposable
    {
        private string _path;
        private StreamWriter _sw;
        private bool _disposed = false;

        public CustomWrtiter(string path)
        {
            _path = path;
            _sw = new StreamWriter(path, true);
        }

        public void WriteLine(string line, int number)
        {
            _sw.WriteLine($"{number}. {line}");
            _sw.Flush();
        }

        protected virtual void Dispose(bool disposing)
        {
            if (_disposed)
                return;

            if(disposing)
            {
                //frees up managed objects
            }

            //frees up unmanaged objects
            _sw.Dispose();
            _path = null;
            _disposed = true;
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }

        ~CustomWrtiter()
        {
            Dispose(false);
        }
    }
}
