using CSharp.DesignPatterns.Singleton.Container;
using CSharp.DesignPatterns.Singleton.Contracts;
using CSharp.DesignPatterns.Singleton.Repositories;
using System;

namespace CSharp.DesignPatterns.Singleton
{
	class Program
	{
		/// <summary>
		/// Singleton pattern example. In this example, we have a simple inversion of control container created for mapping
		/// interfaces to its implementations. As we want the container to be configured only once when the application
		/// starts, we implement the singleton pattern to assert only one instance will be created and the mapping process
		/// will be done just at creation time. This is achieved making the container's constructor private and creating
		/// a get property that will check wheter the cotainer was created before. If the instance wasn't created yet, 
		/// the property creates the instance and asserts every time it's accessed the created instance will be used.
		/// 
		/// Note: in a real world application, it isn't recommended to use a so simple container, because it doesn't handle
		/// object creation when interfaces are not mapped and because scopes aren't configured. Not necessarily a container
		/// will use singleton, I made this one this way just to show an example of pattern.
		/// </summary>
		static void Main(string[] args)
		{
			// The container is accessed every time using the get property.
			IoCContainer.Instance.Register<IToDoRepository, ToDoRepositoryADO>();
			//IoCContainer.Instance.Register<IToDoRepository, ToDoRepositoryEntity>();

			var repository = IoCContainer.Instance.Get<IToDoRepository>();

			Console.WriteLine($"Mapped type: {repository.GetType().ToString()}");
			Console.ReadKey();
		}
	}
}
