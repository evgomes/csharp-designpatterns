using CSharp.DesignPatterns.Strategy.Domain;
using System.Collections.Generic;

namespace CSharp.DesignPatterns.Strategy.Contracts
{
	/// <summary>
	/// Defines a discount strategy to be applied over a products list.
	/// </summary>
	public interface IBasketDiscountStrategy
	{
		/// <summary>
		/// Calculates the total price for all products in a list.
		/// </summary>
		/// <param name="products">Products.</param>
		/// <returns>Total price.</returns>
		decimal TotalPriceFor(IList<Product> products);
	}
}
