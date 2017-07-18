using CSharp.DesignPatterns.Composite.Abstractions;

namespace CSharp.DesignPatterns.Composite.Domain
{
	/// <summary>
	/// Represents a system file that has no files within it. Examples: .docx, .pdf, .jpg.
	/// </summary>
	public sealed class SystemFile : File
	{
		public SystemFile(string nome) : base(nome) { }

		/// <summary>
		/// Operação de adição de um arquivo a outro. 
		/// Add operation. A common file doesn't allow other files to be added within it, so this operation
		/// has no implementation.
		/// </summary>
		/// <param name="file"></param>
		public override void Add(File file) { }

		/// <summary>
		/// Show file's name.
		/// </summary>
		/// <returns>File's name.</returns>
		public override string ToString()
		{
			string saida = string.Format("{0}{1}\n", new string('-', Level), Name);
			Level = 0;
			return saida;
		}
	}
}
