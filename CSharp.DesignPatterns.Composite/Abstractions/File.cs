namespace CSharp.DesignPatterns.Composite.Abstractions
{
	/// <summary>
	/// Represents a file on disk.
	/// </summary>
	public abstract class File
	{
		/// <summary>
		/// File's name.
		/// </summary>
		public string Name { get; private set; }

		/// <summary>
		/// File level on folders tree.
		/// </summary>
		public int Level { get; set; }

		public File(string name)
		{
			Name = name;
		}

		/// <summary>
		/// Inserts a file inside other. This is used by folders and compressed files.
		/// </summary>
		/// <param name="file">File to add inside this one.</param>
		public abstract void Add(File file);
	}
}
