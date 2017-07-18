using CSharp.DesignPatterns.AbstractFactory.Contracts;
using CSharp.DesignPatterns.AbstractFactory.Entities;
using CSharp.DesignPatterns.AbstractFactory.Factories;

namespace CSharp.DesignPatterns.AbstractFactory.Services
{
	/// <summary>
	/// Service that manipulates orders to dispatch them.
	/// </summary>
	public class OrderService
	{
		/// <summary>
	 /// Dispatches an order.
	 /// </summary>
	 /// <param name="order">Order to dispatch.</param>
		public void Dispatch(Order order)
		{
			ForwardingAgentFactory factory = ForwardingAgentFactoryProvider.GetFactoryFor(order.ShippingAddress);
			IForwardingAgent forwardingAgent = factory.GetForwardingAgentFor(order);
			forwardingAgent.SetTrackingIdTo(order);
			// Remaining code flow.
		}
	}
}
