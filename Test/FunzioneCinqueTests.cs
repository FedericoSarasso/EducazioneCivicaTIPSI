using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LavoroEducazioneCivica
{
    [TestClass]
    public class FunzioneCinqueTests
    {

        [TestMethod]
        public void Zero()
        {
            Assert.AreEqual(0, Program.FunzioneCinque("ABC", 0));
        }

        [TestMethod]
        public void One()
        {
            Assert.AreEqual(6, Program.FunzioneCinque("ABC", 1));
        }

        [TestMethod]
        public void Two()
        {
            Assert.AreEqual(12, Program.FunzioneCinque("ABC", 2));
        }

        [TestMethod]
        public void Three()
        {
            Assert.AreEqual(2, Program.FunzioneCinque("ABC", 3));
        }

        [TestMethod]
        public void Four()
        {
            Assert.AreEqual(24, Program.FunzioneCinque("ABC", 4));
        }
    }
}