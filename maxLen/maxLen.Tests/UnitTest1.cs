using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.IO;
using System.Text;

namespace maxLen.Tests
{
    [TestClass]
    public class MaxLenTests
    {
        [TestMethod]
        public void CorrectnessTest1()
        {
             int len = Program.GetMaxLength(GetMemoryStream("101011100"));
            Assert.AreEqual(3, len);
        }
        [TestMethod]
        public void CorrectnessTest2()
        {
            int len = Program.GetMaxLength(GetMemoryStream("111111111"));
            Assert.AreEqual(9, len);
        }
        [TestMethod]
        public void CorrectnessTest3()
        {
            int len = Program.GetMaxLength(GetMemoryStream("000000000"));
            Assert.AreEqual(0, len);
        }
        [TestMethod]
        public void ErrorTest4()
        {
            try
            {
                Program.GetMaxLength(GetMemoryStream("1101-104"));
                Assert.Fail("We should not get here");
            }
            catch (ArgumentException ex)
            {
                Assert.AreEqual("bad input",
                    ex.Message);
            }
        }
        private MemoryStream GetMemoryStream(string input)
        {
            byte[] bytes = Encoding.ASCII.GetBytes(input);
            var stream = new MemoryStream(bytes);
            return stream;
        }
    }
}
