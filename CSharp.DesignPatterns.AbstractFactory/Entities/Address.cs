namespace CSharp.DesignPatterns.AbstractFactory.Entities
{
	/// <summary>
	/// Represents an address.
	/// </summary>
	public class Address
	{
		/// <summary>
		/// Country code.
		/// </summary>
		public ECountryCode CountryCode { get; private set; }

		public Address(ECountryCode countryCode)
		{
			CountryCode = countryCode;
		}
	}

	/// <summary>
	/// Country code.
	/// </summary>
	public enum ECountryCode : short
	{
		Brazil = 1,
		USA = 2
	}
}
