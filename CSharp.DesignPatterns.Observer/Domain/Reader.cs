using CSharp.DesignPatterns.Observer.Contracts;
using System;

namespace CSharp.DesignPatterns.Observer.Domain
{
	public class Reader : INewsObserver
	{
		/// <summary>
		/// Reader's name.
		/// </summary>
		public string Name { get; set; }

		/// <summary>
		/// Notifies the reader when an editor register a new news item in a section or when an existing one is edited.
		/// In a real application, it could be an e-mail, in a web application, or a notification, in a mobile application.
		/// </summary>
		/// <param name="sender">Action performer.</param>
		/// <param name="e">Event argument.</param>
		public void Notify(object sender, NewsChangeEventArgs e)
		{
			if (e.News.EditDate != null)
				Console.WriteLine($"Hello \"{Name}\". The news \"{e.News.Title}\" was edited in {e.News.EditDate.Value.ToLongDateString()} by {e.News.UpdateEditor.Name}.\nSynthesis: {e.News.Synthesis}\n");
			else
				Console.WriteLine($"Hello \"{Name}\". New news item: \"{e.News.Title}\".\n Registered in {e.News.PublishDate.ToLongDateString()} by {e.News.Editor.Name}.\nSynthesis: {e.News.Synthesis}\n");
		}
	}
}
