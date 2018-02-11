using System.Collections.Generic;
using GdcRestClient.Extensions;
using RestSharp;

namespace GdcRestClient
{
    public class FileGetRequest : GdcRequest
    {
        private readonly IDictionary<string, string> _queryParameters 
            = new Dictionary<string, string>();

        public FileGetRequest WithCancerType(string cancerType)
        {
            _queryParameters["cancerType"] = cancerType.InQuotes();
            return this;
        }

        public FileGetRequest WithExperimentalStrategy(string experimentalStrategy)
        {
            _queryParameters["experimentalStrategy"] = experimentalStrategy.InQuotes();
            return this;
        }

        public FileGetRequest WithLimit(string limit)
        {
            _queryParameters["limit"] = limit;
            return this;
        }

        internal override IRestRequest CreateRequest()
        {
            var request = new RestRequest(
                $"files/{_queryParameters.ToQueryParameterString()}",
                Method.GET);

            request.AddHeader("Accept", "application/json");

            return request;
        }
    }
}
