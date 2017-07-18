using CSharp.DesignPatterns.Strategy.Contracts;
using CSharp.DesignPatterns.Strategy.Domain;
using System.Collections.Generic;
using System.Linq;

namespace CSharp.DesignPatterns.Strategy.DiscountStrategies
{
	/// <summary>
	/// Discount strategy for a products list where we musn't apply a discount value.
	/// </summary>
	public class NoDiscountStrategy : IBasketDiscountStrategy
	{
		/// <summary>
		/// Calculates the total price for all products in a list.
		/// </summary>
		/// <param name="products">Products.</param>
		/// <returns>Total price.</returns>
		public decimal TotalPriceFor(IList<Product> products)
		{
			decimal price = 0;

			products.AsParallel().ForAll(p =>
			{
				price += p.Price;
			});

			return price;
		}
	}
}
