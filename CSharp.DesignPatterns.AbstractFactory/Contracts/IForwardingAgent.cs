using CSharp.DesignPatterns.AbstractFactory.Entities;

namespace CSharp.DesignPatterns.AbstractFactory.Contracts
{
	/// <summary>
	/// Defines the contract of a forwarding agent.
	/// </summary>
	public interface IForwardingAgent
	{
		/// <summary>
		/// Generates a tracking id to an order.
		/// </summary>
		/// <param name="order">Order that needs a tracking id.</param>
		void SetTrackingIdTo(Order order);
	}
}
