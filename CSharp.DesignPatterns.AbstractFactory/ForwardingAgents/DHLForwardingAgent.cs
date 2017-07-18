using CSharp.DesignPatterns.AbstractFactory.Contracts;
using CSharp.DesignPatterns.AbstractFactory.Entities;

namespace CSharp.DesignPatterns.AbstractFactory.ForwardingAgents
{
	/// <summary>
	/// DHL's forwarding agent provider.
	/// </summary>
	public class DHLForwardingAgent : IForwardingAgent
	{
		/// <summary>
		/// Generates a tracking id to an order.
		/// </summary>
		/// <param name="order">Order that needs a tracking id.</param>
		public void SetTrackingIdTo(Order order)
		{
			// Hard-coded to simplify the example.
			order.TrackingId = "DHL-XXXX-XXXX-XXXX-XXXX";
		}
	}
}
