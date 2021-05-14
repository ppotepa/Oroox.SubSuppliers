
using Microsoft.Extensions.Logging;
using Serilog.Debugging;
using Serilog.Extensions.Logging;

namespace Oroox.SubSuppliers.Utilities.Factories
{
    public class SerilogLoggerFactory : Disposable, ILoggerFactory
    {
        private readonly SerilogLoggerProvider _provider;

        public SerilogLoggerFactory(Serilog.ILogger logger = null, bool dispose = false)
        {
            _provider = new SerilogLoggerProvider(logger, dispose);
        }

        public new void Dispose() => _provider.Dispose();

        public ILogger CreateLogger(string categoryName)
        {
            return _provider.CreateLogger(categoryName);
        }

        public void AddProvider(ILoggerProvider provider) => SelfLog.WriteLine("Ignoring added logger provider {0}", provider);
      
    }
}
