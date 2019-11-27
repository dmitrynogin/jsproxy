using System;

namespace JSProxy
{
    public class JSClient
    {
        public static T Create<T>(Func<string, IJSModule> load) where T : IDisposable => 
            throw new NotImplementedException();
    }
}
