using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using System;

namespace JSProxy.Tests
{
    [TestClass]
    public class JSClient_Should
    {
        [TestMethod]
        public void Call()
        {
            var module = new Mock<IJSModule>();
            module
                .Setup(m => m.Execute("hello('World')"))
                .Returns("Hello, World!");

            IJSModule load(string name) =>
                name == "greeter" ? module.Object : null;
           
            using (var greeter = JSClient.Create<IGreeter>(load))
                Assert.AreEqual("Hello, World!", greeter.Hello("World"));

            module.Verify(m => m.Dispose());
        }
    }

    [JSModule("greeter")]
    public interface IGreeter : IDisposable
    {
        [JSFunc("hello")]
        string Hello(string name);
    }
}
