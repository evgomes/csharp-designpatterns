using CSharp.DesignPatterns.Decorator.Domain;
using System.Collections.Generic;

namespace CSharp.DesignPatterns.Decorator.Contracts
{
	/// <summary>
	/// Products repository.
	/// </summary>
	public interface IProductRepository
	{
		/// <summary>
		/// Lists all products from a data source.
		/// </summary>
		/// <returns>Products list.</returns>
		IEnumerable<Product> List();
	}
}