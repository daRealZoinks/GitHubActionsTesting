namespace GitHubActionsTesting.Tests
{
    public class CalculatorTests
    {
        private readonly Calculator _sut;

        public CalculatorTests()
        {
            _sut = new Calculator();
        }

        [Theory]
        [InlineData(1, 1, 2)]
        [InlineData(2, 4, 6)]
        [InlineData(6, 4, 10)]
        [InlineData(2, -4, -2)]
        public void Add_WhenTwoNumbers_ReturnNumber(int a, int b, int c)
        {
            var result = _sut.Add(a, b);

            Assert.Equal(c, result);
        }

        [Theory]
        [InlineData(1, 1, 0)]
        [InlineData(2, 4, -2)]
        [InlineData(6, 4, 2)]
        [InlineData(2, -4, 6)]
        public void Subtract_WhenTwoNumbers_ReturnNumber(int a, int b, int c)
        {
            var result = _sut.Subtract(a, b);

            Assert.Equal(c, result);
        }
    }
}
