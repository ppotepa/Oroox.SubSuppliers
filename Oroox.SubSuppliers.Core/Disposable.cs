using System;

namespace Oroox.SubSuppliers.Utilities
{
    /// <summary>
    /// Disposable class to satisfy Disposable Pattern.
    /// <br><b>If you want your class to be Disposable friendly simply devire from this class.</b></br>
    /// </summary>
    public class Disposable : IDisposable
    {
        private bool _disposed = false;
        ~Disposable() => Dispose(false);
      
        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }
       
        protected virtual void Dispose(bool disposing)
        {
            if (_disposed)
            {
                return;
            }

            if (disposing)
            {
                // TODO: dispose managed state (managed objects).
            }
            _disposed = true;
        }
    }
}
