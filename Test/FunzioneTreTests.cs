using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LavoroEducazioneCivica
{
    [TestClass]
    public class FunzioneTreTests
    {

        [TestMethod]
        public void Zero()
        {
            Assert.AreEqual(0, Program.FunzioneTre("ABC", 0));
        }

        [TestMethod]
        public void One()
        {
            Assert.AreEqual(6, Program.FunzioneTre("ABC", 1));
        }

        [TestMethod]
        public void Two()
        {
            Assert.AreEqual(12, Program.FunzioneTre("ABC", 2));
        }

        [TestMethod]
        public void Three()
        {
            Assert.AreEqual(18, Program.FunzioneTre("ABC", 3));
        }
    }
}