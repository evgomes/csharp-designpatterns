using CSharp.DesignPatterns.Decorator.Contracts;

namespace CSharp.DesignPatterns.Decorator.Decorators
{
	/// <summary>
	/// Represents a product price, applying an exchange rate accourding to a specific currency.
	/// Example: at the momement this project was coded, "US$ 1" was equivalent to approximately "R$ 3.30".
	/// </summary>
	public class ExchangeRatePriceDecorator : IPrice
	{
		/// <summary>
		/// Product's original price.
		/// </summary>
		private IPrice _price;

		/// <summary>
		/// Exchange rate applied over the original price.
		/// </summary>
		private decimal _exchangeRate;

		public ExchangeRatePriceDecorator(IPrice price, decimal exchangeRate)
		{
			_price = price;
			_exchangeRate = exchangeRate;
		}

		/// <summary>
		/// Coast accourding to an exchange rate.
		/// </summary>
		public decimal Coast
		{
			get { return _price.Coast * _exchangeRate; }
			set { _price.Coast = value; }
		}
	}
}