using CSharp.DesignPatterns.AbstractFactory.Contracts;
using CSharp.DesignPatterns.AbstractFactory.Entities;

namespace CSharp.DesignPatterns.AbstractFactory.ForwardingAgents
{
	/// <summary>
	/// Sedex' forwading agent service.
	/// </summary>
	public class SedexForwardingAgent : IForwardingAgent
	{
		/// <summary>
		/// Generates a tracking id to an order.
		/// </summary>
		/// <param name="order">Order that needs a tracking id.</param>
		public void SetTrackingIdTo(Order order)
		{
			// Hard-coded to simplify the example.
			order.TrackingId = "SEDEX-XXXX-XXXX-XXXX-XXXX";
		}
	}
}
