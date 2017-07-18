using System.Collections.Generic;

namespace CSharp.DesignPatterns.Adapter.Contracts
{
	/// <summary>
	/// Fictional entity repository.
	/// </summary>
	public interface IToDoRepository
	{
		/// <summary>
		/// Returns a ToDo objects list given by a fictional category name.
		/// </summary>
		/// <param name="category">Category name.</param>
		/// <returns>Object list.</returns>
		IList<object> ListByCategory(string category);
	}
}
