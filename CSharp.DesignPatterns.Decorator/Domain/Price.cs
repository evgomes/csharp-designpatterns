using CSharp.DesignPatterns.Decorator.Contracts;

namespace CSharp.DesignPatterns.Decorator.Domain
{
	/// <summary>
	/// Represent a product price.
	/// </summary>
	public class Price : IPrice
	{
		private decimal _coast;

		/// <summary>
		/// Coast.
		/// </summary>
		public decimal Coast
		{
			get { return _coast; }
			set { _coast = value; }
		}
	}
}
