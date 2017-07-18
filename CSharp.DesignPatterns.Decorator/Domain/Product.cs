using CSharp.DesignPatterns.Decorator.Contracts;

namespace CSharp.DesignPatterns.Decorator.Domain
{
	/// <summary>
	/// Represents a product.
	/// </summary>
	public class Product
	{
		/// <summary>
		/// Product's price.
		/// </summary>
		public IPrice Price { get; set; }

		public Product(IPrice price)
		{
			Price = price;
		}
	}
}
