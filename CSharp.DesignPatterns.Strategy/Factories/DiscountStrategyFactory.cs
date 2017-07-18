using CSharp.DesignPatterns.Strategy.Contracts;
using CSharp.DesignPatterns.Strategy.DiscountStrategies;
using CSharp.DesignPatterns.Strategy.Domain;
using System;

namespace CSharp.DesignPatterns.Strategy.Factories
{
	/// <summary>
	/// Factory that creates discount strategies accourding to a desired discount type.
	/// </summary>
	public static class DiscountStrategyFactory
	{
		/// <summary>
		/// Returns a discount strategy acourding to a discount type.
		/// </summary>
		/// <param name="discountType">Discount type to be applied.</param>
		/// <returns>Discount strategy.</returns>
		public static IBasketDiscountStrategy DiscountStrategyFor(EDiscountType discountType)
		{
			switch (discountType)
			{
				case EDiscountType.NoDiscount:
					return new NoDiscountStrategy();
				case EDiscountType.PercentageDiscount:
					return new PercentageDiscountStrategy();
				case EDiscountType.PerItemPercentageDiscount:
					return new PerItemPercentualDiscountStrategy();
				default:
					throw new ArgumentException("There is no discount strategy defined to the specified discount type.");
			}
		}
	}
}
