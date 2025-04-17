using ModernSoftwareApp;
using Xunit;

namespace xUnit_Test
{
    public class CalculatorTests
    {
        [Fact]
        public void Add_ShouldReturnCorrectSum()
        {
            var calc = new ModernSoftwareApp.Calculator();
            Assert.Equal(5, calc.Add(2, 3));
        }

    }
}