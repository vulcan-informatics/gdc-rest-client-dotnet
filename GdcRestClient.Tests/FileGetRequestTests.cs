using RestSharp;
using Xunit;

namespace GdcRestClient.Tests
{
    public class FileGetRequestTests
    {

        [Fact]
        public void CreateRequest_UsesGetMethod_WhenRequestCreated()
        {
            var request = new FileGetRequest()
                .CreateRequest();

            Assert.Equal(Method.GET, request.Method);
        }

        [Fact]
        public void CreateRequest_AcceptsJson_WhenRequestCreated()
        {
            var request = new FileGetRequest()
                .CreateRequest();

            Assert.Collection(
                request.Parameters,
                p => Assert.Equal("Accept=application/json", p.ToString()));
        }

        [Fact]
        public void CreateRequest_UsesFilesResource_WhenRequestCreated()
        {
            var resource = new FileGetRequest()
                .CreateRequest()
                .Resource;

            Assert.StartsWith("files/", resource);
        }

        [Fact]
        public void WithCancerType_AddsCancerTypeToQueryString_WhenRequestCreated()
        {
            var resource = new FileGetRequest()
                .WithCancerType("cancerType1")
                .CreateRequest()
                .Resource;

            Assert.Contains("?cancerType=\"cancerType1\"", resource);
        }

        [Fact]
        public void WithExperimentalStrategy_AddsExperimentalStrategyToQueryString_WhenRequestCreated()
        {
            var resource = new FileGetRequest()
                .WithExperimentalStrategy("strategy1")
                .CreateRequest()
                .Resource;

            Assert.Contains("?experimentalStrategy=\"strategy1\"", resource);
        }

        [Fact]
        public void WithLimit_AddsLimitToQueryString_WhenRequestCreated()
        {
            var resource = new FileGetRequest()
                .WithLimit("10")
                .CreateRequest()
                .Resource;

            Assert.Contains("?limit=10", resource);
        }
    }
}
