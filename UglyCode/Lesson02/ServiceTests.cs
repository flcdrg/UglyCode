using System;

using NSubstitute;

using NUnit.Framework;

namespace UglyCode.Lesson02
{
    // http://tfs:8080/tfs/DefaultCollection/MatrixGroup%20BMX%20Shell/_versionControl#path=%24%2FMatrixGroup+BMX+Shell%2FStable%2FCore%2FMatrixGroup.Bmx%2FCore%2FInterfaces%2FIDateTimeProvider.cs&_a=contents
    public interface IDateTimeProvider
    {
        DateTime Now { get; }
    }

    public class Model
    {
        public DateTime Finish { get; set; }
    }

    public class MyService
    {
        private readonly IDateTimeProvider _dateTimeProvider;

        public MyService(IDateTimeProvider dateTimeProvider)
        {
            _dateTimeProvider = dateTimeProvider;
        }

        public bool Validation(Model model)
        {
            // finish time must be in the future
            return model.Finish > _dateTimeProvider.Now;
        }
    }

    [TestFixture]
    public class MyServiceTests
    {
        private IDateTimeProvider _dateTimeProvider;

        [SetUp]
        public void SetUp()
        {
            _dateTimeProvider = Substitute.For<IDateTimeProvider>();
            _dateTimeProvider.Now.Returns(DateTime.Now);
        }

        [Test]
        public void TestMethod()
        {
            // Arrange
            var sut = new MyService(_dateTimeProvider);
            var model = new Model();
            model.Finish = _dateTimeProvider.Now.AddMinutes(1);
            
            // Act
            var result = sut.Validation(model);

            // Assert
            Assert.IsTrue(result);
        }
    }
}