using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using GameLibrary;
namespace GameUnitTests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void Test_FieldExistence()
        {
            Class1 Field = new Class1();
            Assert.IsNotNull(Field);
        }
    }
}
