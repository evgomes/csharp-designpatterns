using CSharp.DesignPatterns.Adapter.Contracts;
using System.Collections.Generic;

namespace CSharp.DesignPatterns.Adapter.Repositories
{
	/// <summary>
	/// Fictional entity repository.
	/// </summary>
	public class ToDoRepository : IToDoRepository
	{
		/// <summary>
		/// Returns a ToDo objects list given by a fictional category name.
		/// </summary>
		/// <param name="category">Category name.</param>
		/// <returns>Object list.</returns>
		public IList<object> ListByCategory(string categoria)
		{
			return new List<object> { "Object" };
		}
	}
}
