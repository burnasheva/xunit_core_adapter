using Xunit;
using Prime.Services;

namespace Prime.UnitTests.Services
{
	public class PrimeService_IsPrimeShould
	{
		private readonly PrimeService _primeService;

		public PrimeService_IsPrimeShould()
		{
			_primeService = new PrimeService();
		}

		[Fact]
		public void ReturnFalseGivenValueOf1()
		{
			var result = _primeService.IsPrime(1);

			Assert.False(result, $"1 should not be prime");
		}

		[Theory]
		[InlineData(-1)]
		[InlineData(0)]
		[InlineData(1)]
		public void ReturnFalseGivenValuesLessThan2(int value)
		{
			var result = _primeService.IsPrime(value);

			Assert.False(result, $"{value} should not be prime");
		}

		[Theory]
                [InlineData(-1)]
                [InlineData(0)]
                [InlineData(2)]
                public void ShouldFailGivenValuesLessThan2(int value)
                {
                        var result = _primeService.IsPrime(value);

                        Assert.False(result, $"{value} should not be prime");
                }

		[Fact(Skip = "Takes too long")]
		public void TestSomething()
		{
			Assert.True(true);
		}
	}
}
