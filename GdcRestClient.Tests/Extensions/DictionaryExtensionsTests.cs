using System.Collections.Generic;
using GdcRestClient.Extensions;
using Xunit;

namespace GdcRestClient.Tests.Extensions
{
    public class DictionaryExtensionsTests
    {
        [Fact]
        public void ToQueryParameterString_StartsWithQuestionMark_OneOrMoreQueryParameters()
        {
            var queryParameters = new Dictionary<string, string>
            {
                {"param1", "value1"}
            };

            Assert.StartsWith("?", queryParameters.ToQueryParameterString());
        }

        [Fact]
        public void ToQueryParameterString_IsEmpty_NoQueryParameters()
        {
            var queryParameters = new Dictionary<string, string>();

            Assert.Equal(string.Empty, queryParameters.ToQueryParameterString());
        }


        [Fact]
        public void ToQueryParameterString_JoinsParameterNameAndValueWithEqualSign_OneOrMoreQueryParameters()
        {
            var queryParameters = new Dictionary<string, string>
            {
                {"param1", "value1"}
            };

            Assert.Contains("param1=value1", queryParameters.ToQueryParameterString());
        }

        [Fact]
        public void ToQueryParameterString_JoinsParamsWithAmpersand_MoreThanOneQueryParameters()
        {
            var queryParameters = new Dictionary<string, string>
            {
                {"param1", "value1"},
                {"params2", "values2" }
            };

            Assert.Contains("value1&params2", queryParameters.ToQueryParameterString());
        }
    }
}
