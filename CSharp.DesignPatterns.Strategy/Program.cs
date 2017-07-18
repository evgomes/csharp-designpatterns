using CSharp.DesignPatterns.Strategy.Domain;
using System;

namespace CSharp.DesignPatterns.Strategy
{
	class Program
	{
		/// <summary>
		/// Strategy pattern example. In this exaple, we have a basket of a common ecommerce application, which contains a products list
		/// with different prices. The prices must be used to calculate the total price, but in three different situations:
		///		- The total price can be the sum of all products;
		///		- The total price can be the sum of all products, with a percentage discount of 15%;
		///		- The total price can be the sum of all products, with a percentage discount of 2% over each product.
		///		
		/// There is an enum used to determine de discount strategy to be applied over the producs lists on the basket. The definition
		/// of the desired strategy is responsability of the basket, that internally uses a factory that creates the strategy. A discount
		/// strategy interface assures all strategys have a method to calculate the total price for that situation, and the process is
		/// completely transparent because the only thing needed to pass to the basket, in addition to the products, is the desired
		/// discount type.
		/// 
		/// The advantage of this approach is that if you need to implement a new discount strategy (example: black friday discount
		/// strategy), you will only need to create a new implementation for the strategy interface, and change the factory and the
		/// enumerator to contemplate the changes.
		/// </summary>
		/// <param name="args"></param>
		static void Main(string[] args)
		{
			var soda = new Product("Soda", 5);
			var pizza = new Product("Pizza", 30);
			var pizza2 = new Product("Second Pizza", 35);

			var basket = new Basket(EDiscountType.NoDiscount);
			basket.AddProduct(soda);
			basket.AddProduct(pizza);
			basket.AddProduct(pizza2);

			Console.WriteLine("Total price with no discount: $ " + basket.TotalPrice());

			basket.SetDiscountType(EDiscountType.PercentageDiscount);
			Console.WriteLine("Total price with a percentage discount of 15%, applied over the total price: $ " + basket.TotalPrice());

			basket.SetDiscountType(EDiscountType.PerItemPercentageDiscount);
			Console.WriteLine("Total price with a percentage discount of 2%, applied over the price of each product $ " + basket.TotalPrice());

			Console.ReadKey();
		}
	}
}
