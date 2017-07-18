namespace CSharp.DesignPatterns.Strategy.Domain
{
	/// <summary>
	/// Discount types to apply over products.
	/// </summary>
	public enum EDiscountType : byte
	{
		NoDiscount = 0,
		PercentageDiscount = 1,
		PerItemPercentageDiscount = 2
	}
}
