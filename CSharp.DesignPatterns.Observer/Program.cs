using CSharp.DesignPatterns.Observer.Domain;
using System;

namespace CSharp.DesignPatterns.Observer
{
	class Program
	{
		/// <summary>
		/// Observer Pattern example. In this example, we have a digital newspaper, which contains two sections:
		/// sports and politics. There are specific editors to every section, as well as readers interested in
		/// receiving notifications about new news items and changes on these news, according to sections they
		/// are interested.
		/// 
		/// The observer is applied to notify all readers about changes and new items registered to sections they
		/// are interested in.
		/// 
		/// In a real world application, you could apply this pattern to send e-mails for employees responsible
		/// for different areas of a company, when an item is sold, a costumer requests a product, etc.
		/// </summary>
		/// <param name="args"></param>
		static void Main(string[] args)
		{
			// Create all sections
			var sportsSection = new NewsSection("Sports Section");
			var politicsSection = new NewsSection("Politics Section");

			// Create the sections' readers.
			var sportsSectionReader = new Reader { Name = "Sports Reader" };
			var politicsSectionReader = new Reader { Name = "Politics Reader" };
			var bothSectionsReader = new Reader { Name = "Both Sections Reader" };

			// Create the editors.
			var sportsEditor = new Editor { Name = "Sports Editor" };
			var politicsEditor = new Editor { Name = "Politics Editor" };

			// Register all readers to the respective section.
			sportsSection.RegisterReader(sportsSectionReader);
			sportsSection.RegisterReader(bothSectionsReader);
			politicsSection.RegisterReader(politicsSectionReader);
			politicsSection.RegisterReader(bothSectionsReader);

			// Two diffente news are created, registered to a section, and one on them is changed, so the readers receive notifications about the actions performed.
			var sportNews = sportsEditor.RegisterNewsFor(sportsSection, "Fictional Player is the new reinforcement of Fictional Team.", "Fictional Team has bought all rights from Other Team last week to have Fictional Player for two years.");
			var politicsNews = politicsEditor.RegisterNewsFor(politicsSection, "City hall starts new building construction on fictional address.", "Fictional City's city hall has started the construction of a new building...");

			politicsNews.Synthesis = "Update: Fictional City's mayor will see the construction tomorrow, about 08:00 AM...";
			politicsEditor.UpdateNewsFor(politicsSection, politicsNews);

			// Remove the reader interested in both sections from sports section, and then change the sports news to verify how the notification is handled.
			sportsSection.RemoveReader(bothSectionsReader);
			sportNews.Title = "Fictional Player surprises supporters on accepting proposal from Fictional Team.";
			sportsEditor.UpdateNewsFor(sportsSection, sportNews);

			Console.ReadKey();
		}
	}
}
