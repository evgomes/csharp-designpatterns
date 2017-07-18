using System;

namespace CSharp.DesignPatterns.Observer.Domain
{
	/// <summary>
	/// Person responsible for creating and editing news.
	/// </summary>
	public class Editor
	{
		/// <summary>
		/// Editor's name.
		/// </summary>
		public string Name { get; set; }

		/// <summary>
		/// This method creates a new news item and register it to a newspaper section.
		/// </summary>
		/// <param name="newsSection">Section where the news should be registered.</param>
		/// <param name="title>">News' title.</param>
		/// <param name="synthesis">News' synthesis.</param>
		/// <returns>Created news.</returns>
		public News RegisterNewsFor(NewsSection newsSection, string title, string synthesis)
		{
			var news = new News
			{
				Editor = this,
				PublishDate = DateTime.Now,
				Title = title,
				Synthesis = synthesis
			};

			newsSection.RegisterNews(news);
			return news;
		}

		/// <summary>
		/// Updates a news for a section.
		/// </summary>
		/// <param name="newsSection">Section where the news should be updated.</param>
		/// <param name="news">News that need to be updated.</param>
		public void UpdateNewsFor(NewsSection newsSection, News news)
		{
			news.EditDate = DateTime.Now;
			news.UpdateEditor = this;
			newsSection.RegisterNews(news);
		}
	}
}
