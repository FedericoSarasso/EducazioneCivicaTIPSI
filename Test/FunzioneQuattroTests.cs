using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LavoroEducazioneCivica
{
    [TestClass]
    public class FunzioneQuattroTests
    {

        [TestMethod]
        public void Zero()
        {
            Assert.AreEqual(double.PositiveInfinity, Program.FunzioneQuattro("ABC", 0));
        }

        [TestMethod]
        public void One()
        {
            Assert.AreEqual(6, Program.FunzioneQuattro("ABC", 1));
        }

        [TestMethod]
        public void Two()
        {
            Assert.AreEqual(3, Program.FunzioneQuattro("ABC", 2));
        }

        [TestMethod]
        public void Three()
        {
            Assert.AreEqual(2, Program.FunzioneQuattro("ABC", 3));
        }

        [TestMethod]
        public void Four()
        {
            Assert.AreEqual(2, Program.FunzioneQuattro("ABC", 4));
        }

        [TestMethod]
        public void Five()
        {
            Assert.AreEqual(1, Program.FunzioneQuattro("ABC", 5));
        }
    }
}