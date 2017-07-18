using System.Net;

namespace CSharp.DesignPatterns.Builder.Builders
{
	/// <summary>
	/// HTTP request builder for requests which need a proxy. 
	/// </summary>
	public class ProxyHttpWebRequestBuilder : HttpWebRequestBuilder
	{
		/// <summary>
		/// Proxy address.
		/// </summary>
		private string _proxy = null;

		/// <summary>
		/// Username for proxy authentication.
		/// </summary>
		private string _userName = null;

		/// <summary>
		/// Password for proxy authentication.
		/// </summary>
		private string _password = null;

		public ProxyHttpWebRequestBuilder(string proxy)
		{
			_proxy = proxy;
		}

		public ProxyHttpWebRequestBuilder(string proxy, string userName, string password) : this(proxy)
		{
			_userName = userName;
			_password = password;
		}

		/// <summary>
		/// Overrides "OnBuild" method to define the proxy on web request creation.
		/// </summary>
		/// <param name="httpWebRequest">Web request.</param>
		protected override void OnBuild(HttpWebRequest httpWebRequest)
		{
			httpWebRequest.Proxy = new WebProxy(_proxy);
			if (_userName != null)
			{
				httpWebRequest.Proxy.Credentials = new NetworkCredential
				{
					UserName = _userName,
					Password = _password
				};
			}
		}
	}
}
