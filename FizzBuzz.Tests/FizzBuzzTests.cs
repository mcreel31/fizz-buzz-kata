using FizzBuzz.Library;
using Xunit;

namespace FizzBuzz.Tests
{
    public class FizzBuzzTests
    {
        private FizzBuzzService fizzBuzz;

        public FizzBuzzTests()
        {
            fizzBuzz = new FizzBuzzService();
        }

        [Fact]

        public void ShouldReturnNumber()
        {
            Assert.Equal("1", fizzBuzz.Print(1));
        }
    }
}