using System;
using RestSharp;

namespace GdcRestClient
{
	public class GenomicDataCommonsApi
	{
		private const string BaseUrl = "https://gdc-api.nci.nih.gov/";

		internal virtual T Execute<T>(IRestRequest request) where T : new()
		{
		    var client = new RestClient {BaseUrl = new Uri(BaseUrl)};
		    var response = client.Execute<T>(request);

			if (response.ErrorException != null)
			{
				throw new ApplicationException(
					"Error retrieving response. See inner exception for details.", 
					response.ErrorException);
			}

			return response.Data;
		}

		internal virtual string Execute(IRestRequest request)
		{
		    var client = new RestClient {BaseUrl = new Uri(BaseUrl)};
		    var response = client.Execute(request);

			if (response.ErrorException != null)
			{
				throw new ApplicationException(
					"Error retrieving response. See inner exception for details.",
					response.ErrorException);
			}

			return response.Content;
		}
	}
}
