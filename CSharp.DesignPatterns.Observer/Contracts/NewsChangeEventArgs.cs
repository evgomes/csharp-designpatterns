using CSharp.DesignPatterns.Observer.Domain;
using System;

namespace CSharp.DesignPatterns.Observer.Contracts
{
	/// <summary>
	/// Event argument used to pass information of a news being created or edited.
	/// </summary>
	public class NewsChangeEventArgs : EventArgs
	{
		/// <summary>
		/// News that was created or edited.
		/// </summary>
		public News News { get; set; }
	}
}
