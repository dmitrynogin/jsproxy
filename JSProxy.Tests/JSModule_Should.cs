using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using DescriptionAttribute = System.ComponentModel.DescriptionAttribute;

namespace JSProxy.Tests
{
    [TestClass]
    public class JSModule_Should
    {
        [TestMethod]
        public void Execute_NodeJS_Module_Code()
        {
            using (var tests = JSModule.Load<ITestCases>())
                Assert.AreEqual("Param0: Hey; Param1: 123", tests.Echo("Hey", 123));
        }
    }

    [Description("testCases")]
    public interface ITestCases : IDisposable
    {
        [Description("echoSimpleParameters")]
        string Echo(string param0, int param1);
    }
}
