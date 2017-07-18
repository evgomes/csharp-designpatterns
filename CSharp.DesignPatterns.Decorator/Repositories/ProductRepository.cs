using CSharp.DesignPatterns.Decorator.Contracts;
using CSharp.DesignPatterns.Decorator.Domain;
using System.Collections.Generic;

namespace CSharp.DesignPatterns.Decorator.Repositories
{
	public class ProductRepository : IProductRepository
	{
		/// <summary>
		/// Products repository.
		/// </summary>
		/// <returns>Products.</returns>
		public IEnumerable<Product> List()
		{
			var products = new List<Product>();
			for (int index = 0; index <= 10; index++)
			{
				var price = new Price();
				price.Coast = index;
				products.Add(new Product(price));
			}
			return products;
		}
	}
}
