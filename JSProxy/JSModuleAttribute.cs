using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text;

namespace JSProxy
{
    [AttributeUsage(AttributeTargets.Interface)]
    public class JSModuleAttribute : Attribute
    {
        public JSModuleAttribute([CallerMemberName] string path = null) => Path = path;
        public string Path { get; }
    }
}
