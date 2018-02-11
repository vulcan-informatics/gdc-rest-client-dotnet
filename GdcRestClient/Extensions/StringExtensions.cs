namespace GdcRestClient.Extensions
{
	public static class StringExtensions
	{
		public static string InQuotes(this string s)
		{
			return $"\"{s}\"";
		}
	}
}
