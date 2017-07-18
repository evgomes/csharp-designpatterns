namespace CSharp.DesignPatterns.AbstractFactory.Entities
{
	/// <summary>
	/// Represents an order requested to delivery.
	/// </summary>
	public class Order
	{
		/// <summary>
		/// Tracking Id generated to identify and to track the order.
		/// </summary>
		public string TrackingId { get; set; }

		/// <summary>
		/// Order's total price.
		/// </summary>
		public decimal TotalPrice { get; private set; }

		/// <summary>
		/// Order's weight. It's used to determine the forwarding agent which will delivery the order.
		/// </summary>
		public double Weight { get; private set; }

		/// <summary>
		/// Order's shipping address.
		/// </summary>
		public Address ShippingAddress { get; private set; }


		public Order(decimal totalPrice, double weight, Address shippingAddress)
		{
			TotalPrice = totalPrice;
			Weight = weight;
			ShippingAddress = shippingAddress;
		}
	}
}
