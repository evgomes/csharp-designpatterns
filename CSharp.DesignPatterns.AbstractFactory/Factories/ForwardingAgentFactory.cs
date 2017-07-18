using CSharp.DesignPatterns.AbstractFactory.Contracts;
using CSharp.DesignPatterns.AbstractFactory.Entities;

namespace CSharp.DesignPatterns.AbstractFactory.Factories
{
	/// <summary>
	/// Generates forwarding agents accourding to an order.
	/// </summary>
	public abstract class ForwardingAgentFactory
	{
		/// <summary>
		/// Creates a forwarding agent  according to an order.
		/// </summary>
		public abstract IForwardingAgent GetForwardingAgentFor(Order order);
	}
}
