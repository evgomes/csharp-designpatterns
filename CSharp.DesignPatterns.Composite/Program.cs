using CSharp.DesignPatterns.Composite.Domain;
using System;

namespace CSharp.DesignPatterns.Composite
{
	/// <summary>
	/// The composite pattern is applied here to satisfy these requisites, allowing folders and compressed files
	/// to have other files inside it and allowing the recursive operation of showing all files to work.
	/// 
	/// The goal of composite pattern is exactly it, to work with items in tree structures in a way encapsulation
	/// and inheritance aren't broken. Of course there are different approaches that could have been used here,
	/// but this was done this way to exemplify the pattern.
	/// </summary>
	class Program
	{
		static void Main(string[] args)
		{
			var arquivoXls = new SystemFile("graph.xls");
			var arquivoDoc = new SystemFile("document.doc");
			var arquivoPdf = new SystemFile("pdfdocument.pdf");
			var arquivoPpt = new SystemFile("lecture.ppt");
			var arquivoPng = new SystemFile("image.png");

			var pastaNivel3 = new FolderFile("Level 2 Folder");
			pastaNivel3.Add(arquivoXls);
			pastaNivel3.Add(arquivoDoc);
			pastaNivel3.Add(arquivoPdf);

			var pastaNivel2 = new FolderFile("Level 1 Folder");
			pastaNivel2.Add(arquivoPpt);
			pastaNivel2.Add(pastaNivel3);

			var pastaRaiz = new FolderFile("Root Folder");
			pastaRaiz.Add(arquivoPng);
			pastaRaiz.Add(pastaNivel2);

			Console.WriteLine("------Files structure from root folder------\n\n");
			Console.WriteLine(pastaRaiz.ToString());

			Console.WriteLine("\n\n------Files structure from foler level 1-----\n\n");
			Console.WriteLine(pastaNivel2.ToString());

			Console.WriteLine("\n\n------Files structure from folder level 2------\n\n");
			Console.WriteLine(pastaNivel3.ToString());

			Console.ReadKey();
		}
	}
}
