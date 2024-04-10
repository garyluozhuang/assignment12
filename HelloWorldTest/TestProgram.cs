using Xunit;
using HelloWorld;

namespace HelloWorldTests
{
    public class TestProgram
    {
        [Fact]
        public void GetMessage_ReturnsExpectedMessage()
        {
            // Arrange
            var expected = "Hello, World!";

            // Act
            var actual = Program.GetMessage();

            // Assert
            Assert.Equal(expected, actual);
        }
    }
}