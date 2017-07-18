using CSharp.DesignPatterns.Adapter.Cache;
using CSharp.DesignPatterns.Adapter.Contracts;
using CSharp.DesignPatterns.Adapter.Repositories;
using CSharp.DesignPatterns.Adapter.Services;
using System.Collections.Generic;
using static System.Console;

namespace CSharp.DesignPatterns.Adapter
{
	class Program
	{
		/// Adapter pattern example. In this example, a cache functionality is simulated to store and to retrieve
		/// data for a ToDo entity listing. There are times the application have to use cache, there are times not.
		/// To do this, a cache interface is defined with its own cach methods. To adapt the interface to a .NET
		/// caching class, we create an adapter which goal is to match interface methods to .NET native methods.
		/// Using this approach you avoid coupling your code to specific API implementations.
		/// </summary>
		/// <param name="args"></param>
		static void Main(string[] args)
		{
			ICache cache = new ApplicationCacheAdapter();
			IToDoRepository repository = new ToDoRepository();

			// First, the application cache is used to stores some data.
			var servico = new ToDoService(cache, repository);
			var lista = servico.ListByCategory("test");
			WriteLine("Listing: {0}", lista[0]);
			WriteLine("Cached items quantity: {0}", cache.Get<IList<object>>("test").Count);

			// Then, we simulate a situation where we don't want to use cache.
			cache = new NullObjectCacheAdapter();
			servico = new ToDoService(cache, repository);
			lista = servico.ListByCategory("testt");
			WriteLine("Listing: {0}", lista[0]);
			WriteLine("Cached items quantity: {0}", cache.Get<IList<object>>("test") == null ? "0" : "1");

			ReadKey();
		}
	}
}
