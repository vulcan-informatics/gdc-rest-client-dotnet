using System;
using RestSharp;

namespace GdcRestClient
{
	public class GenomicDataCommonsApi
	{
		private const string BaseUrl = "https://gdc-api.nci.nih.gov/";

		public T Execute<T>(RestRequest request) where T : new()
		{
			var client = new RestClient();
			client.BaseUrl = new Uri(BaseUrl);
			var response = client.Execute<T>(request);

			if (response.ErrorException != null)
			{
				throw new ApplicationException(
					"Error retrieving response. See inner exception for details.", 
					response.ErrorException);
			}

			return response.Data;
		}

	}
}
