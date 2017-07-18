using System.Net;

namespace CSharp.DesignPatterns.Builder.Contracts
{
	/// <summary>
	/// Defines the contract of a builder that creates web requests.
	/// </summary>
	public interface IWebRequestBuilder
	{
		/// <summary>
		/// Defines the request protocol (examples: HTTP, FTP, etc.).
		/// </summary>
		/// <param name="protocol">Request protocol.</param>
		/// <returns>Builder.</returns>
		IWebRequestBuilder Protocol(string protocol);

		/// <summary>
		/// Address to send the request.
		/// </summary>
		/// <param name="host">Address.</param>
		/// <returns>Builder.</returns>
		IWebRequestBuilder Host(string host);

		/// <summary>
		/// Request port (example: 80).
		/// </summary>
		/// <param name="port">Request port.</param>
		/// <returns>Builder.</returns>
		IWebRequestBuilder Port(int port);

		/// <summary>
		/// Defines the internal path in the address to send the request.
		/// </summary>
		/// <param name="internalPath">Internal path.</param>
		/// <returns>Builder.</returns>
		IWebRequestBuilder InternalPath(string internalPath);

		/// <summary>
		/// Defines the query string to send.
		/// </summary>
		/// <param name="queryString">Query string.</param>
		/// <returns>Builder.</returns>
		IWebRequestBuilder QueryString(string queryString);

		/// <summary>
		/// Defines the request timeout.
		/// </summary>
		/// <param name="timeout">Request timeout.</param>
		/// <returns>Builder.</returns>
		IWebRequestBuilder Timeout(int timeout);

		/// <summary>
		/// Creates the web request.
		/// </summary>
		/// <returns>WebRequest.</returns>
		WebRequest Build();
	}
}
