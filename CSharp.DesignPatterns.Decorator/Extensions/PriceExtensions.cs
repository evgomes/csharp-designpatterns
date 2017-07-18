using CSharp.DesignPatterns.Decorator.Decorators;
using CSharp.DesignPatterns.Decorator.Domain;
using System.Collections.Generic;

namespace CSharp.DesignPatterns.Decorator.Extensions
{
	/// <summary>
	/// Price extensions.
	/// </summary>
	public static class PriceExtensions
	{
		/// <summary>
		/// Applies an exchange rate over the price of a products enumeration.
		/// </summary>
		/// <param name="products">Products enumeration.</param>
		/// <param name="exchangeRate">Exchange rate to apply over all prices.</param>
		public static void ApplyExchangeRate(this IEnumerable<Product> products, decimal exchangeRate)
		{
			foreach (var product in products)
			{
				var originalPrice = product.Price;
				product.Price = new ExchangeRatePriceDecorator(originalPrice, exchangeRate);
			}
		}
	}
}
