using System.IO;
using SystemWrapper.IO;
using MbUnit.Framework;
using Rhino.Mocks;

namespace SystemWrapper.Tests.IO
{
    [TestFixture]
    [Author("Brad Irby", "Brad@BradIrby.com")]
    public class BinaryReaderWrapTests
    {
		private MockRepository _mockRepository;
		private FileStream _fileStream ;

		[FixtureSetUp]
		public void FixtureSetup()
		{
			//_fileStream = new FileStream("asdf", FileMode.Open);
		}

		[SetUp]
		public void Setup()
		{
			_mockRepository = new MockRepository();
		}

		//[Test]
		//public void Constructor_1_Sets_BinaryReaderInstance()
		//{
		//    var bReader = new BinaryReader(_fileStream);
		//    var instance = new BinaryReaderWrap(bReader);
		//    Assert.AreSame(bReader, instance.BinaryReaderInstance);
		//}

		//[Test]
		//public void Initialize_1_Sets_BinaryReaderInstance()
		//{
		//    var instance = new BinaryReaderWrap();
		//    var bReader = new BinaryReader(_fileStream);
		//    instance.Initialize(bReader);
		//    Assert.AreSame(bReader, instance.BinaryReaderInstance);
		//}

		//[Test]
		//public void Constructor_2_Sets_BinaryReaderInstance()
		//{
		//    var instance = new BinaryReaderWrap(_fileStream);
		//    Assert.IsNotNull(instance.BinaryReaderInstance);
		//}

		//[Test]
		//public void Initialize_2_Sets_BinaryReaderInstance()
		//{
		//    var instance = new BinaryReaderWrap();
		//    instance.Initialize(_fileStream);
		//    Assert.IsNotNull( instance.BinaryReaderInstance);
		//}


    }
}