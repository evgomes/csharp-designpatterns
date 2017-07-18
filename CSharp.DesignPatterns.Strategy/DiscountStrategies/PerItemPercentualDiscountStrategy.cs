using CSharp.DesignPatterns.Strategy.Contracts;
using System.Collections.Generic;
using System.Linq;
using CSharp.DesignPatterns.Strategy.Domain;

namespace CSharp.DesignPatterns.Strategy.DiscountStrategies
{
	/// <summary>
	/// Discount strategy for a products list where we must apply a percentage discount over each product, and them sum the total price.
	/// </summary>
	public class PerItemPercentualDiscountStrategy : IBasketDiscountStrategy
	{
		/// <summary>
		/// In this example, the percentage is fixed in 2%.
		/// </summary>
		private const int discountPercent = 2;

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
				if (p.Price > 0)
				{
					var productPrice = p.Price - (p.Price * discountPercent) / 100;
					price += productPrice;
				}
			});

			return price;
		}
	}
}
