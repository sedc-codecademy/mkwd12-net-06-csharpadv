namespace Disposable
{
    public class OurReader : IDisposable
    {
        private string path;
        private StreamReader _sr;
        private bool disposedValue = false;

        public OurReader(string filePath)
        {
            path = filePath;
            _sr = new StreamReader(filePath);
        }

        public string Read()
        {
            return _sr.ReadToEnd();
        }

        //We implement this private method that will remember when this class is disposed
        // That way, if the same class tries to get disposed again, all the Dispose() methods will not get called
        private void _dispose(bool disposing)
        {
            // This happens only when the class needs to be disposed the first time
            if (!disposedValue)
            {
                if (disposing)
                {
                    _sr.Dispose();
                }

                path = "";
                disposedValue = true;
            }
        }

        // We can implement this methodf alone and add the disposing here
        public void Dispose()
        {
            _dispose(true);
        }
    }
}
