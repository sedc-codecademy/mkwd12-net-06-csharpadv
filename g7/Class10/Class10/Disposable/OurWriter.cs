namespace Disposable
{
    public class OurWriter : IDisposable
    {
        private string path;
        private StreamWriter _sw;
        private bool disposedValue = false;
        
        public OurWriter(string filePath)
        {
            path = filePath;
            _sw = new StreamWriter(path, true);
        }

        public void Write(string text)
        {
            if (text == "break") throw new Exception("Something brok unexpectedly...");
            
            _sw.WriteLine(text);
        }

        // We implement this private methot that will remember when this class is disposed
        // That way, if the same class tries to get disposed again, all the Dispose() methods will not get called
        private void _dispose(bool disposing)
        {
            // This happens only when the class needs to be disposed the first time
            if(!disposedValue)
            {
                if(disposing)
                {
                    _sw.Dispose();
                }

                path = "";
                disposedValue = true;
            }
        }

        public void Dispose()
        {
            _dispose(true);
        }
    }
}
