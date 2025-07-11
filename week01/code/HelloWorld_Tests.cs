using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace HelloWorldTests
{
    [TestClass]
    public class Tests
    {
        [TestMethod]
        public void HelloWorldTest()
        {
            Assert.AreEqual("Hello, World!", GetHelloWorld());
        }

        private string GetHelloWorld()
        {
            return "Hello, World!";
        }
    }
}