using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace DisposingClasses
{
    public class CustomWriter : IDisposable
    {
        private string _filePath;
        private StreamWriter _writer;

        private bool _isDisposed = false;

        public CustomWriter(string filePath)
        {
            _filePath = filePath;
            _writer = new StreamWriter(filePath);
        }

        public void Write(string text)
        {
            if (text == "stop")
            {
                throw new Exception("We should not write to file...");
            }
            //we are simulating a scenario that we have some other our resource
            _writer.Write(text);
        }

        //Because we have a method in our class that keeps some resouce in use, we must have a Dispose method in our class 
        //we need to implement the iDisposable interface
        public void Dispose()
        {
            if (!_isDisposed)
            {
                _writer.Dispose();
                _isDisposed = true; //we use a flag to make sure we dont call Dispose multiplr times for one resource

            }
        }
    }
}

