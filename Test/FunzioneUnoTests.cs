//using Microsoft.VisualStudio.TestTools.UnitTesting;
using Microsoft.VisualStudio.TestTools.UnitTesting;
//using NUnit.Framework;

namespace LavoroEducazioneCivica
{
	[TestClass]
	public class FunzioneUnoTests
	{

        [TestMethod]
        public void Zero()
        {
            Assert.AreEqual("ABCDEFGHIJKLMNOPQRSTUVWXYZ", Program.FunzioneUno("ABCDEFGHIJKLMNOPQRSTUVWXYZ", 0));
        }

        [TestMethod]
        public void One()
		{
            Assert.AreEqual("BCDEFGHIJKLMNOPQRSTUVWXYZA", Program.FunzioneUno("ABCDEFGHIJKLMNOPQRSTUVWXYZ", 1));
		}

        [TestMethod]
        public void Twentysix()
        {
            Assert.AreEqual("ABCDEFGHIJKLMNOPQRSTUVWXYZ", Program.FunzioneUno("ABCDEFGHIJKLMNOPQRSTUVWXYZ", 26));
        }

        [TestMethod]
        public void Twentyseven()
        {
            Assert.AreEqual("BCDEFGHIJKLMNOPQRSTUVWXYZA", Program.FunzioneUno("ABCDEFGHIJKLMNOPQRSTUVWXYZ", 27));
        }
    }
}