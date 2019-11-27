using System;
using System.Threading.Tasks;

namespace JSProxy
{
    public class JSModule : IJSModule
    {
        public static T Load<T>() where T : IDisposable =>
            JSClient.Create<T>(path => new JSModule(path));

        JSModule(string path) => throw new NotImplementedException();
        public void Dispose() => throw new NotImplementedException();
        public string Execute(string call) => throw new NotImplementedException();
        public Task<string> ExecuteAsync(string call) => throw new NotImplementedException();
    }
}
