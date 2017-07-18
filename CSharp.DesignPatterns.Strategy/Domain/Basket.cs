using CSharp.DesignPatterns.Strategy.Contracts;
using CSharp.DesignPatterns.Strategy.Factories;
using System.Collections.Generic;

namespace CSharp.DesignPatterns.Strategy.Domain
{
	/// <summary>
	/// Represents an ecommerce application basket.
	/// </summary>
	public class Basket
	{
		/// <summary>
		/// Producst lists that will be bought.
		/// </summary>
		private IList<Product> _products;

		/// <summary>
		/// Discount strategy used to determine the total price of all products according to a discount type.
		/// </summary>
		private IBasketDiscountStrategy _discountStrategy;

		public Basket(EDiscountType discountType)
		{
			_products = new List<Product>();

			// Here the discount strategy is defined, according to a desired kind of discount type.
			_discountStrategy = DiscountStrategyFactory.DiscountStrategyFor(discountType);
		}

		/// <summary>
		/// Defines a discount type to be applied over all products of basket.
		/// </summary>
		/// <param name="discountType">Discount type which will be applied over the products list.</param>
		public void SetDiscountType(EDiscountType discountType)
		{
			_discountStrategy = DiscountStrategyFactory.DiscountStrategyFor(discountType);
		}

		/// <summary>
		/// Add a product to basket.
		/// </summary>
		/// <param name="produto">Product to be added.</param>
		public void AddProduct(Product produto)
		{
			_products.Add(produto);
		}

		/// <summary>
		/// Calculates the total price of all items on basket.
		/// </summary>
		/// <returns>Total price.</returns>
		public decimal TotalPrice() => _discountStrategy.TotalPriceFor(_products);
	}
}
