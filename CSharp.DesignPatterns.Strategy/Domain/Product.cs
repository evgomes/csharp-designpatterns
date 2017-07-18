namespace CSharp.DesignPatterns.Strategy.Domain
{
	/// <summary>
	/// Product to sell.
	/// </summary>
	public class Product
	{
		/// <summary>
		/// Product's price.
		/// </summary>
		public decimal Price { get; private set; }

		/// <summary>
		/// Product's name.
		/// </summary>
		public string Name { get; private set; }

		public Product(string name, decimal value)
		{
			Name = name;
			Price = value;
		}
	}
}
