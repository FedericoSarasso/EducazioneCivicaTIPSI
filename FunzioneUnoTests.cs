using NUnit.Framework;
using Program;

namespace LavoroEducazioneCivica
{
	[TestFixture]
	public class FunzioneUnoTests
	{

        [Test]
        public void Zero()
        {
            Assert.AreEqual("ABCDEFGHIJKLOPQRSTUVWXYZ", Program.FunzioneUno("ABCDEFGHIJKLOPQRSTUVWXYZ", 0);
        }

		[Test]
		public void One()
		{
			Assert.AreEqual("BCDEFGHIJKLOPQRSTUVWXYZA", Program.FunzioneUno("ABCDEFGHIJKLOPQRSTUVWXYZ", 1);
		}

        [Test]
        public void Twentysix()
        {
            Assert.AreEqual("ABCDEFGHIJKLOPQRSTUVWXYZ", Program.FunzioneUno("ABCDEFGHIJKLOPQRSTUVWXYZ", 26);
        }

        [Test]
        public void Twentyseven()
        {
            Assert.AreEqual("BCDEFGHIJKLOPQRSTUVWXYZA", Program.FunzioneUno("ABCDEFGHIJKLOPQRSTUVWXYZ", 27);
        }
    }
}
}


