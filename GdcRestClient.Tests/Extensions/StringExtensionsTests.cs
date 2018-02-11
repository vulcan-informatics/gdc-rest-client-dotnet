using GdcRestClient.Extensions;
using Xunit;

namespace GdcRestClient.Tests.Extensions
{
	public class StringExtensionsTests
	{
		[Fact]
		public void InQuotes_SurroundsInputInQuotes()
		{
		    const string input = "test";
		    Assert.Equal("\"test\"", input.InQuotes());
		}
	}
}
