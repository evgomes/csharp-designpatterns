using CSharp.DesignPatterns.Builder.Contracts;
using System.Net;

namespace CSharp.DesignPatterns.Builder.Builders
{
	/// <summary>
	/// Base class for web request builders.
	/// </summary>
	public abstract class BaseWebRequestBuilder : IWebRequestBuilder
	{
		protected string _protocol;
		protected string _host;
		protected int _port;
		protected string _internalPath;
		protected string _queryString;
		protected int _timeout;

		/// <summary>
		/// Defines the request protocol (examples: HTTP, FTP, etc.).
		/// </summary>
		/// <param name="protocol">Request protocol.</param>
		/// <returns>Builder.</returns>
		public abstract IWebRequestBuilder Protocol(string protocol);

		/// <summary>
		/// Address to send the request.
		/// </summary>
		/// <param name="host">Address.</param>
		/// <returns>Builder.</returns>
		public abstract IWebRequestBuilder Host(string host);

		/// <summary>
		/// Request port (example: 80).
		/// </summary>
		/// <param name="port">Request port.</param>
		/// <returns>Builder.</returns>
		public abstract IWebRequestBuilder Port(int port);

		/// <summary>
		/// Defines the internal path in the address to send the request.
		/// </summary>
		/// <param name="internalPath">Internal path.</param>
		/// <returns>Builder.</returns>
		public abstract IWebRequestBuilder InternalPath(string internalPath);

		/// <summary>
		/// Defines the query string to send.
		/// </summary>
		/// <param name="queryString">Query string.</param>
		/// <returns>Builder.</returns>
		public abstract IWebRequestBuilder QueryString(string queryString);

		/// <summary>
		/// Defines the request timeout.
		/// </summary>
		/// <param name="timeout">Request timeout.</param>
		/// <returns>Builder.</returns>
		public abstract IWebRequestBuilder Timeout(int timeout);

		/// <summary>
		/// Creates the web request.
		/// </summary>
		/// <returns>WebRequest.</returns>
		public abstract WebRequest Build();
	}
}
