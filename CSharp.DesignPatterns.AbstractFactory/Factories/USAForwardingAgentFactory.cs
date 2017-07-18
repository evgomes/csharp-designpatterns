using CSharp.DesignPatterns.AbstractFactory.Contracts;
using CSharp.DesignPatterns.AbstractFactory.Entities;
using CSharp.DesignPatterns.AbstractFactory.ForwardingAgents;

namespace CSharp.DesignPatterns.AbstractFactory.Factories
{
	/// <summary>
	/// USA forwading agents' factory.
	/// </summary>
	public class USAForwardingAgentFactory : ForwardingAgentFactory
	{
		/// <summary>
		/// Creates a forwarding agent  according to an order.
		/// </summary>
		public override IForwardingAgent GetForwardingAgentFor(Order order)
		{
			if (order.Weight > 10 || order.TotalPrice > 1000)
				return new DHLForwardingAgent();
			return new FictionalCompanyForwardingAgent();
		}
	}
}
