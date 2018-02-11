using RestSharp;

namespace GdcRestClient
{
    public abstract class GdcRequest
    {
        internal abstract IRestRequest CreateRequest();

        public string Execute(GenomicDataCommonsApi gdcApi)
        {
            return gdcApi.Execute(CreateRequest());
        }
    }
}