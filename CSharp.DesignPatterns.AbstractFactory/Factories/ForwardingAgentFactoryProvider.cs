using CSharp.DesignPatterns.AbstractFactory.Entities;
using System;

namespace CSharp.DesignPatterns.AbstractFactory.Factories
{
	/// <summary>
	/// Creates a fowarding agent factory accourding to a determined address.
	/// </summary>
	public static class ForwardingAgentFactoryProvider
	{
		/// <summary>
		/// Verifica o código do país do endereço para criar a factory de despachantes de correio.
		/// Verifies the country code and returns the respective forwarding agend factory.
		/// </summary>
		/// <param name="address">Address.</param>
		/// <returns>Forwarding agent factory.</returns>
		public static ForwardingAgentFactory GetFactoryFor(Address address)
		{
			switch (address.CountryCode)
			{
				case ECountryCode.Brazil:
					return new BrazilForwardingAgentFactory();
				case ECountryCode.USA:
					return new USAForwardingAgentFactory();
				default:
					throw new NotImplementedException("There are not forwarding agents available for this country.");
			}
		}
	}
}
