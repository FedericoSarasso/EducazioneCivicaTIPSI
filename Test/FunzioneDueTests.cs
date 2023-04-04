using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LavoroEducazioneCivica
{
    [TestClass]
    public class FunzioneDueTests
    {

        [TestMethod]
        public void Zero()
        {
            Assert.AreEqual("ABCDEFGHIJKLMNOPQRSTUVWXYZ", Program.FunzioneDue("ABCDEFGHIJKLMNOPQRSTUVWXYZ", 0));
        }

        [TestMethod]
        public void One()
        {
            Assert.AreEqual("ZABCDEFGHIJKLMNOPQRSTUVWXY", Program.FunzioneDue("ABCDEFGHIJKLMNOPQRSTUVWXYZ", 1));
        }

        [TestMethod]
        public void Twentysix()
        {
            Assert.AreEqual("ABCDEFGHIJKLMNOPQRSTUVWXYZ", Program.FunzioneDue("ABCDEFGHIJKLMNOPQRSTUVWXYZ", 26));
        }

        [TestMethod]
        public void Twentyseven()
        {
            Assert.AreEqual("ZABCDEFGHIJKLMNOPQRSTUVWXY", Program.FunzioneDue("ABCDEFGHIJKLMNOPQRSTUVWXYZ", 27));
        }
    }
}