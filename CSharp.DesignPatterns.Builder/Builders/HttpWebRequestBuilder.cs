using CSharp.DesignPatterns.Builder.Contracts;
using System.Net;

namespace CSharp.DesignPatterns.Builder.Builders
{
	/// <summary>
	/// HTTP web request builder.
	/// </summary>
	public class HttpWebRequestBuilder : BaseWebRequestBuilder
	{
		/// <summary>
		/// Defines the request protocol (examples: HTTP, FTP, etc.).
		/// </summary>
		/// <param name="protocol">Request protocol.</param>
		/// <returns>Builder.</returns>
		public override IWebRequestBuilder Protocol(string protocol)
		{
			_protocol = protocol;
			return this;
		}

		/// <summary>
		/// Address to send the request.
		/// </summary>
		/// <param name="host">Address.</param>
		/// <returns>Builder.</returns>
		public override IWebRequestBuilder Host(string host)
		{
			_host = host;
			return this;
		}

		/// <summary>
		/// Request port (example: 80).
		/// </summary>
		/// <param name="port">Request port.</param>
		/// <returns>Builder.</returns>
		public override IWebRequestBuilder Port(int port)
		{
			_port = port;
			return this;
		}

		/// <summary>
		/// Defines the internal path in the address to send the request.
		/// </summary>
		/// <param name="internalPath">Internal path.</param>
		/// <returns>Builder.</returns>
		public override IWebRequestBuilder InternalPath(string internalPath)
		{
			_internalPath = internalPath;
			return this;
		}

		/// <summary>
		/// Defines the query string to send.
		/// </summary>
		/// <param name="queryString">Query string.</param>
		/// <returns>Builder.</returns>
		public override IWebRequestBuilder QueryString(string queryString)
		{
			_queryString = queryString;
			return this;
		}

		/// <summary>
		/// Defines the request timeout.
		/// </summary>
		/// <param name="timeout">Request timeout.</param>
		/// <returns>Builder.</returns>
		public override IWebRequestBuilder Timeout(int timeout)
		{
			_timeout = timeout;
			return this;
		}

		/// <summary>
		/// Método a ser executado antes de retornar a instância da requisição web no método "Build".
		/// Method to execute while web request is created ("Build").
		/// </summary>
		/// <param name="httpWebRequest">Created web request.</param>
		protected virtual void OnBuild(HttpWebRequest httpWebRequest) { }

		/// <summary>
		/// Creates the web request.
		/// </summary>
		/// <returns>WebRequest.</returns>
		public override WebRequest Build()
		{
			var uri = $"{_protocol}://{_host}:{_port}/{_internalPath}?{_queryString}";
			var httpWebRequest = WebRequest.CreateHttp(uri);
			httpWebRequest.Timeout = _timeout;
			OnBuild(httpWebRequest);
			return httpWebRequest;
		}
	}
}
