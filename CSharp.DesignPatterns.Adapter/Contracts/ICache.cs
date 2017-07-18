namespace CSharp.DesignPatterns.Adapter.Contracts
{
	/// <summary>
	/// Defines the methods a cache class must have to implement.
	/// </summary>
	public interface ICache
	{
		/// <summary>
		/// Removes some data from cache.
		/// </summary>
		/// <param name="key">Key that identifies the object.</param>
		void Remove(string key);

		/// <summary>
		/// Stores some data in cache.
		/// </summary>
		/// <param name="key">Key to identify the object.</param>
		/// <param name="object">Object to store.</param>
		void Store(string key, object @object);

		/// <summary>
		/// Returns some data from cache.
		/// </summary>
		/// <typeparam name="T">Object type to return.</typeparam>
		/// <param name="key">Key that identifies the object.</param>
		/// <returns>Stored object.</returns>
		T Get<T>(string key);
	}
}
