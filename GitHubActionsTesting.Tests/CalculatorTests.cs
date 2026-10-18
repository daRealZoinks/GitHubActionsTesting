namespace GitHubActionsTesting.Tests
{
    public class CalculatorTests
    {
        [Theory]
        [InlineData(1, 1, 2)]
        [InlineData(2, 4, 6)]
        [InlineData(6, 4, 10)]
        [InlineData(2, -4, -2)]
        public void Add_WhenTwoNumbers_ReturnNumber(int a, int b, int c)
        {
            var result = Calculator.Add(a, b);

            Assert.Equal(c, result);
        }

        [Theory]
        [InlineData(1, 1, 0)]
        [InlineData(2, 4, -2)]
        [InlineData(6, 4, 2)]
        [InlineData(2, -4, 6)]
        public void Subtract_WhenTwoNumbers_ReturnNumber(int a, int b, int c)
        {
            var result = Calculator.Subtract(a, b);

            Assert.Equal(c, result);
        }
    }
}
