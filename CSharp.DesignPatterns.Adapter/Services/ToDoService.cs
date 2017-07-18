using CSharp.DesignPatterns.Adapter.Contracts;
using System.Collections.Generic;

namespace CSharp.DesignPatterns.Adapter.Services
{
	/// <summary>
	/// Service that manipulates a given entity.
	/// </summary>
	public class ToDoService
	{
		private ICache _cache;
		private IToDoRepository _repository;

		public ToDoService(ICache cache, IToDoRepository repositorio)
		{
			_cache = cache;
			_repository = repositorio;
		}

		/// <summary>
		/// Simulates a reading operation, trying to get some entities from cache and storing them if they aren't
		/// stored yet.
		/// </summary>
		/// <param name="category">A fictional parameter to identify a object by a given category.</param>
		/// <returns>Object listing.</returns>
		public IList<object> ListByCategory(string category)
		{
			var list = _cache.Get<IList<object>>(category);

			if (list == null)
			{
				list = _repository.ListByCategory(category);
				_cache.Store(category, list);
			}

			return list;
		}
	}
}
