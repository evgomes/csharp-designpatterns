using CSharp.DesignPatterns.AbstractFactory.Entities;
using CSharp.DesignPatterns.AbstractFactory.Services;
using System;

namespace CSharp.DesignPatterns.AbstractFactory
{
	class Program
	{
		/// <summary>
		/// Abstract Factory pattern example. In this example, we have an ecommerce application that has products
		/// to be delivered in different countries. Accourding to the shipping address of an order, there are
		/// different forwarding agents available to that country which can delivery the requests. The agent is 
		/// determined at runtime by some criterias, as the order's weight and total price, and the country where
		/// the order must be delivered. Two abstract factories are used to determine these agents, one for Brazil 
		/// and one for USA. A factory provider, which applies the Factory Method pattern, determines the forwarding
		/// agent factory that will be used. To simplify the example, these fowarding agents only create a tracking
		/// id to every order, simulating a traceability requisite of the system.
		/// 
		/// The advantage to use this approach is to separete object creation responsability in a separeted class
		/// that is ready to expand if we need new forwarding agents. We don't need to spend lots of time changing
		/// the order service structure to add new countries and agents to the application.
		/// </summary>
		static void Main(string[] args)
		{
			var brazilAddress = new Address(ECountryCode.Brazil);
			var usaAddress = new Address(ECountryCode.USA);

			var brazilOrder1 = new Order(1100M, 12, brazilAddress);
			var brazilOrder2 = new Order(500M, 2, brazilAddress);
			var usaOrder1  = new Order(1100M, 12, usaAddress);
			var usaOrder2  = new Order(500M, 2, usaAddress);

			var orderService = new OrderService();
			orderService.Dispatch(brazilOrder1);
			orderService.Dispatch(brazilOrder2);
			orderService.Dispatch(usaOrder1);
			orderService.Dispatch(usaOrder2);

			Console.WriteLine("Brazil Order 1: " + brazilOrder1.TrackingId);
			Console.WriteLine("Brazil Order 2: " + brazilOrder2.TrackingId);
			Console.WriteLine("USA Order 1: " + usaOrder1.TrackingId);
			Console.WriteLine("USA Order 2: " + usaOrder2.TrackingId);

			Console.ReadKey();
		}
	}
}
