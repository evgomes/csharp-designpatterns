using CSharp.DesignPatterns.Decorator.Domain;
using CSharp.DesignPatterns.Decorator.Repositories;
using CSharp.DesignPatterns.Decorator.Services;
using System;
using System.Linq;

namespace CSharp.DesignPatterns.Decorator
{
	class Program
	{
		/// <summary>
		/// Decorator pattern example. In this example, we have an ecommerce application that deals with costumers
		/// from different countries. Accourding to each country, a product's price is shown with a differente value,
		/// because of currency. To show the price accourding to a currency, a decorator is created to convert the
		/// original value, in US$, to a different rate.
		/// 
		/// There are a lot of approaches you can use in a situation like that, but this solution was chosen to show
		/// how a decorator can extends code functionality for existing classes avoiding to break encapsulation.
		/// It's a usefull approach when you need to extend an API functionality, but you don't have access to its
		/// code.
		/// </summary>
		/// <param name="args"></param>
		static void Main(string[] args)
		{
			var service = new ProductService(new ProductRepository());

			// First shows each product's price in US$.
			var products = service.ListByCurrency(ECurrency.Dolar);
			for (int index = 0; index < products.Count(); index++)
			{
				Console.WriteLine($"Product {index}: US$ {products.ElementAt(index).Price.Coast}");
			}

			Console.WriteLine();

			// Then shows each product's price in R$.
			products = service.ListByCurrency(ECurrency.Real);
			for (int index = 0; index < products.Count(); index++)
			{
				Console.WriteLine($"Product {index}: R$ {products.ElementAt(index).Price.Coast}");
			}

			Console.ReadKey();
		}
	}
}
