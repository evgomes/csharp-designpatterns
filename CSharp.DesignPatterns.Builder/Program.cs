using CSharp.DesignPatterns.Builder.Builders;
using CSharp.DesignPatterns.Builder.Services;
using System;
using System.Threading.Tasks;

namespace CSharp.DesignPatterns.Builder
{
	class Program
	{
		/// Builder pattern example. In this example, we need to create web requests to get content from diffent
		/// APIs. A builder interface was created to define how web requests will be created, allowing developers
		/// to use methods to set parameters that will be used by the request. This interface has two implementations:
		///		- HttpWebRequestBuilder: creates a web request that uses the HTTP protocol to query data sources;
		///		- ProxyHttpWebRequest: same as above, but lets the developer define a proxy for the connection.
		///		
		/// The advantage of this approach is to give developers a simple API to create objects that have many
		/// arguments to define. Defining these arguments in the constructor would make code hard to read and
		/// hard to maintain in case of need to use new parameters.
		/// </summary>
		/// <param name="args"></param>
		static void Main(string[] args)
		{
			Task.Run(async () =>
			{
				var searchService = new SearchService(new HttpWebRequestBuilder());
				var results = await searchService.GetResultsAsync("ajax.googleapis.com", 
																														 "ajax/services/search/web", 
																														 "v=1.0&q=evgomes");

				searchService.Builder = new ProxyHttpWebRequestBuilder("http://proxy.proxyaddress.com", "SomeUserName", "SomePassword");
				var proxyResults = await searchService.GetResultsAsync("ajax.googleapis.com", 
																																		 "ajax/services/search/web", 
																																		 "v=1.0&q=evgomes");

				Console.WriteLine($"Results from first request: {results}\n\n");
				Console.WriteLine($"Results from second request: {proxyResults}\n\n");
			});

			Console.ReadKey();
		}
	}
}
