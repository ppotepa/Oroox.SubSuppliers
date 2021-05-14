using System;

namespace Oroox.SubSuppliers.Utilities
{
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
