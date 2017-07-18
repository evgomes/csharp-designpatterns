using CSharp.DesignPatterns.Decorator.Contracts;
using CSharp.DesignPatterns.Decorator.Domain;
using CSharp.DesignPatterns.Decorator.Extensions;
using System.Collections.Generic;

namespace CSharp.DesignPatterns.Decorator.Services
{
	/// <summary>
	/// Service that manages products.
	/// </summary>
	public class ProductService
	{
		private IProductRepository _repositorio;

		public ProductService(IProductRepository repositorio)
		{
			_repositorio = repositorio;
		}

		/// <summary>
		/// Returns a products list, where all producs have a price accourding to a currency.
		/// </summary>
		/// <param name="currency">Currency that determines each product price.</param>
		/// <returns>Products.</returns>
		public IEnumerable<Product> ListByCurrency(ECurrency currency)
		{
			var products = _repositorio.List();
			if (currency == ECurrency.Real)
				products.ApplyExchangeRate(3.30M);
			return products;
		}
	}
}
