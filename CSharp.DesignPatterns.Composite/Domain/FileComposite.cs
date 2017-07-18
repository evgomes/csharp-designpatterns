using CSharp.DesignPatterns.Composite.Abstractions;
using System.Collections.Generic;

namespace CSharp.DesignPatterns.Composite.Domain
{ 
	/// <summary>
	/// Represents a file that allows other files to be placed within it. Examples: folder, compressed files.
	/// </summary>
	public abstract class FileComposite : File
	{
		/// <summary>
		/// Internal files list. Represents all files inside the folder or compressed file.
		/// </summary>
		private IList<File> _files;

		public FileComposite(string nome) : base(nome)
		{
			_files = new List<File>();
		}

		/// <summary>
		/// Add a file to folder or compressed folder.
		/// </summary>
		/// <param name="file">File to add.</param>
		public override void Add(File file)
		{
			_files.Add(file);
		}

		/// <summary>
		/// Shows the folder or compressed file name and all files contained within it.
		/// </summary>
		/// <returns>File listing.</returns>
		public override string ToString()
		{
			// Uses the level of each file to show in what level they are accourding to its respective folder.
			string output = string.Format("{0}{1}\n", new string('-', Level), Name);

			foreach (var file in _files)
			{
				file.Level += Level + 2;
				output = string.Concat(output, file.ToString());
			}

			Level = 0;
			return output;
		}
	}
}
