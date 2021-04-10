using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using CsharpBasicforJenkins;

namespace HelloTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void createMessageEqualTest()
        {
            Assert.AreEqual("Hello Message", Program.createMessage());
        }
    }
}
