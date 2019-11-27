using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace JSProxy
{
    public interface IJSModule : IDisposable
    {
        string Execute(string call);
        Task<string> ExecuteAsync(string call);
    }
}
