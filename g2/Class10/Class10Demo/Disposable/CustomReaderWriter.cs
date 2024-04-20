namespace Disposable
{
    public class OurWriter : IDisposable
    {
        private string _path;
        private StreamWriter _sw;
        private bool _disposed = false;

        public OurWriter(string filePath)
        {
            _path = filePath;
            _sw = new StreamWriter(filePath, true);
        }

        public void Write(string text)
        {
            _sw.WriteLine(text);
        }

        protected virtual void Dispose(bool disposing)
        {
            if (!_disposed)
            {
                if (disposing)
                {
                    _sw.Dispose();
                }
                _path = string.Empty;
                _disposed = true;
            }
        }

        public void Dispose()
        {
            Dispose(true);
        }
    }

    public class OurReader : IDisposable
    {
        private string _path;
        private StreamReader _sr;
        private bool _disposed = false;

        public OurReader(string filePath)
        {
            _path = filePath;
            _sr = new StreamReader(filePath);
        }

        public string Read()
        {
            return _sr.ReadToEnd();
        }

        protected virtual void Dispose(bool disposing)
        {
            if (!_disposed)
            {
                if (disposing)
                {
                    _sr.Dispose();
                }
                _path = string.Empty;
                _disposed = true;
            }
        }

        public void Dispose()
        {
            Dispose(true);
        }
    }
}
