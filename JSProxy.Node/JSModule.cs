using System;
using System.Threading;
using System.Threading.Tasks;

namespace JSProxy
{
    public class JSModule : IJSModule
    {
        public static T Load<T>() where T : IDisposable =>
            JSClient.Create<T>(path => new JSModule(path));

        JSModule(string path) => throw new NotImplementedException();
        public void Dispose() => throw new NotImplementedException();
        
        public object Execute(string func, object[] args, CancellationToken cancellationToken) => 
            throw new NotImplementedException();
        public Task<object> ExecuteAsync(string func, object[] args, CancellationToken cancellationToken) => 
            throw new NotImplementedException();
    }
}
