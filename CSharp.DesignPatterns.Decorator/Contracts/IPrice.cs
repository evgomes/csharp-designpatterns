namespace CSharp.DesignPatterns.Decorator.Contracts
{
	/// <summary>
	/// Defines a price for the system.
	/// </summary>
	public interface IPrice
	{
		/// <summary>
		/// Value.
		/// </summary>
		decimal Coast { get; set; }
	}
}