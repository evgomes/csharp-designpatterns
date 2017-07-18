namespace CSharp.DesignPatterns.Observer.Contracts
{
	/// <summary>
	/// Defines a contract that an news' event observer must have in the system. 
	/// This interface is implemented by the reader class, and asserts all readers will be notified every time a news is created 
	/// or when an existing one is edited. 
	/// </summary>
	public interface INewsObserver
	{
		/// <summary>
		/// Reader's name.
		/// </summary>
		string Name { get; set; }

		/// <summary>
		/// Dispatched notification when a news change or a new one is created.
		/// </summary>
		/// <param name="sender">Performed the action that resulted in the notification.</param>
		/// <param name="e">Event argument that constains the news item.</param>
		void Notify(object sender, NewsChangeEventArgs e);
	}
}
