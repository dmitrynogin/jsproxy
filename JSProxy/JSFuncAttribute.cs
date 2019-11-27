using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text;

namespace JSProxy
{
    [AttributeUsage(AttributeTargets.Method)]
    public class JSFuncAttribute : Attribute
    {
        public JSFuncAttribute([CallerMemberName] string name = null) => Name = name;
        public string Name { get; }
    }
}
