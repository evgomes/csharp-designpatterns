using CSharp.DesignPatterns.Strategy.Contracts;
using CSharp.DesignPatterns.Strategy.Domain;
using System.Collections.Generic;
using System.Linq;

namespace CSharp.DesignPatterns.Strategy.DiscountStrategies
{
	/// <summary>
	/// Discount strategy for a products list that we must apply a percentage discount over the total price.
	/// </summary>
	public class PercentageDiscountStrategy : IBasketDiscountStrategy
	{
		/// <summary>
		/// In this example, the percentage is fixed in 15%.
		/// </summary>
		private const int discountPercent = 15;

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

			if (price > 0)
				price -= (price * discountPercent) / 100;

			return price;
		}
	}
}
