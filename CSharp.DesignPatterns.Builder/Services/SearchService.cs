using CSharp.DesignPatterns.Builder.Contracts;
using System.IO;
using System.Net;
using System.Threading.Tasks;

namespace CSharp.DesignPatterns.Builder.Services
{
	/// <summary>
	/// Search service that uses web requests to query data sources.
	/// </summary>
	public class SearchService
	{
		/// <summary>
		/// Builder to create web requests.
		/// </summary>
		public IWebRequestBuilder Builder { get; set; }

		public SearchService(IWebRequestBuilder builder)
		{
			Builder = builder;
		}

		/// <summary>
		/// Returns all results of a query executed with an HTTP request.
		/// </summary>
		/// <param name="address">Search address.</param>
		/// <param name="internalPath">Internal path to query.</param>
		/// <param name="queryString">Request query string.</param>
		/// <returns>Results from data source.</returns>
		public async Task<string> GetResultsAsync(string address, string internalPath, string queryString)
		{
			var request = Construct(address, internalPath, queryString);
			var response = await request.GetResponseAsync();

			using (var reader = new StreamReader(response.GetResponseStream()))
			{
				return await reader.ReadToEndAsync();
			}
		}

		/// <summary>
		/// Creates an HTTP web request using the builder.
		/// </summary>
		/// <param name="address">Request address.</param>
		/// <param name="caminhoIntero">Internal path.</param>
		/// <param name="queryString">Query string.</param>
		/// <returns>WebRequest.</returns>
		private WebRequest Construct(string address, string internalPath, string queryString)
		{
			return Builder.Protocol("http")
										 .Host(address)
										 .Port(80)
										 .InternalPath(internalPath)
										 .QueryString(queryString)
										 .Timeout(30)
										 .Build();
		}
	}
}
