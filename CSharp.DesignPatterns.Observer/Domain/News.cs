using System;

namespace CSharp.DesignPatterns.Observer.Domain
{
	public class News
	{
		/// <summary>
		/// News' title.
		/// </summary>
		public string Title { get; set; }

		/// <summary>
		/// Publish date.
		/// </summary>
		public DateTime PublishDate { get; set; }

		/// <summary>
		/// Date when the news was edited the last time.
		/// </summary>
		public DateTime? EditDate { get; set; }

		/// <summary>
		/// News' synthesis.
		/// </summary>
		public string Synthesis { get; set; }

		/// <summary>
		/// Person who published the news.
		/// </summary>
		public Editor Editor { get; set; }

		/// <summary>
		/// Person that edited the news the last time.
		/// </summary>
		public Editor UpdateEditor { get; set; }
	}
}
