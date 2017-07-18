using CSharp.DesignPatterns.Adapter.Contracts;

namespace CSharp.DesignPatterns.Adapter.Cache
{
	/// <summary>
	/// Null object pattern applied to cache adapter. It's used in situations we don't want to have cache.
	/// </summary>
	public class NullObjectCacheAdapter : ICache
	{
		/// <summary>
		/// Returns some data from cache.
		/// </summary>
		/// <typeparam name="T">Object type to return.</typeparam>
		/// <param name="key">Key that identifies the object.</param>
		/// <returns>Stored object.</returns>
		public T Get<T>(string key) => default(T);

		/// <summary>
		/// Removes some data from cache.
		/// </summary>
		/// <param name="key">Key that identifies the object.</param>
		public void Remove(string key) { }

		/// <summary>
		/// Stores some data in cache.
		/// </summary>
		/// <param name="key">Key to identify the object.</param>
		/// <param name="object">Object to store.</param>
		public void Store(string key, object @object) { }
	}
}
