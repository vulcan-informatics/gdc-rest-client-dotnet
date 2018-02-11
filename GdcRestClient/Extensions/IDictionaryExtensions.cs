using System.Collections.Generic;
using System.Linq;

namespace GdcRestClient.Extensions
{
	public static class DictionaryExtensions
	{
		public static string ToQueryParameterString(this IDictionary<string, string> queryParameters)
		{
		    return queryParameters.Count < 1 ? 
                string.Empty : 
                $"?{string.Join("&", queryParameters.Select(kvp => $"{kvp.Key}={kvp.Value}"))}";
		}
	}
}
