using CSharp.DesignPatterns.Observer.Contracts;
using System;

namespace CSharp.DesignPatterns.Observer.Domain
{
	/// <summary>
	/// This class represents a section of a journal. Examples: politics section, economics section.
	/// </summary>
	public class NewsSection
	{
		/// <summary>
		/// Section's name.
		/// </summary>
		public string Name { get; private set; }

		public NewsSection(string name)
		{
			Name = name;
		}

		/// <summary>
		/// News change event handler. Used to assign notify methods of section's readers.
		/// </summary>
		protected EventHandler<NewsChangeEventArgs> Change;

		/// <summary>
		/// Invokes all methods assigned to "Change" event handler, in order to notify all readers about updates.
		/// </summary>
		/// <param name="e">Update event.</param>
		protected virtual void OnChange(NewsChangeEventArgs e)
		{
			Change?.Invoke(this, e);
		}

		/// <summary>
		/// Registers a news reader as a section's reader.
		/// </summary>
		/// <param name="reader">News reader.</param>
		public void RegisterReader(INewsObserver reader)
		{
			Change += reader.Notify;
			Console.WriteLine($"{reader.Name} registered as a {Name} section's reader.\n");
		}

		/// <summary>
		/// Removes a news reader from section's reader list.
		/// </summary>
		/// <param name="reader">News reader.</param>
		public void RemoveReader(INewsObserver reader)
		{
			Change -= reader.Notify;
			Console.WriteLine($"{reader.Name} removed from {Name} section's reader list.\n");
		}

		/// <summary>
		/// Registers a news in this newspaper section and notify all readers about the update. 
		/// In a real application, it probably would perfom some database operations and only after that readers would be
		/// notified of the changes.
		/// </summary>
		/// <param name="news">News to register.</param>
		public void RegisterNews(News news)
		{
			OnChange(new NewsChangeEventArgs { News = news });
		}
	}
}
