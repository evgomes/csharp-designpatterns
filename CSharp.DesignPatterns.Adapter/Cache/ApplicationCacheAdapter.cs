using CSharp.DesignPatterns.Adapter.Contracts;
using System;
using System.Runtime.Caching;

namespace CSharp.DesignPatterns.Adapter.Cache
{
	/// <summary>
	/// Adapter that uses application cache to store and retrieve data.
	/// </summary>
	public class ApplicationCacheAdapter : ICache
	{
		/// <summary>
		/// Internally uses memory cache to store and retrieve data.
		/// </summary>
		private ObjectCache _cache;

		public ApplicationCacheAdapter()
		{
			_cache = new MemoryCache("memory_cache");
		}

		/// <summary>
		/// Returns some data from cache.
		/// </summary>
		/// <typeparam name="T">Object type to return.</typeparam>
		/// <param name="key">Key that identifies the object.</param>
		/// <returns>Stored object.</returns>
		public T Get<T>(string key) => (T)_cache.Get(key);

		/// <summary>
		/// Removes some data from cache.
		/// </summary>
		/// <param name="key">Key that identifies the object.</param>
		public void Remove(string key)
		{
			_cache.Remove(key);
		}

		/// <summary>
		/// Stores some data in cache.
		/// </summary>
		/// <param name="key">Key to identify the object.</param>
		/// <param name="object">Object to store.</param>
		public void Store(string key, object @object)
		{
			_cache.Add(key, @object, new CacheItemPolicy { SlidingExpiration = TimeSpan.FromMinutes(30) });
		}
	}
}
