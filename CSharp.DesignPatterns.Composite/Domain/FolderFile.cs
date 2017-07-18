namespace CSharp.DesignPatterns.Composite.Domain
{
	/// <summary>
	/// Represents a folder.
	/// </summary>
	public sealed class FolderFile : FileComposite
	{
		public FolderFile(string name) : base(name) { }
	}
}
