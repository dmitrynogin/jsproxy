using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace JSProxy
{
    public interface IJSModule : IDisposable
    {
        object Execute(string func, object[] args, CancellationToken cancellationToken);
        Task<object> ExecuteAsync(string func, object[] args, CancellationToken cancellationToken);
    }
}
