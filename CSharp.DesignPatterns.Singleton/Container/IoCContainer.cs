using System;
using System.Collections.Generic;

namespace CSharp.DesignPatterns.Singleton.Container
{
	/// <summary>
	/// Simple IoC container to show an example of Singleton pattern.
	/// </summary>
	public class IoCContainer
	{
		/// <summary>
		/// Container instance loaded only once on memory.
		/// </summary>
		private static IoCContainer _container;

		/// <summary>
		/// Dictionary that maps interface types to class types.
		/// </summary>
		private readonly IDictionary<Type, Type> _types = new Dictionary<Type, Type>();

		/// <summary>
		/// To use singleton pattern, the class constructor must have to be private.
		/// </summary>
		private IoCContainer() { }

		/// <summary>
		/// The container is accessed using a get property which creates the container the first time it's called
		/// and then return this instance every time the property is accessed.
		/// </summary>
		public static IoCContainer Instance
		{
			get
			{
				if (_container == null)
					_container = new IoCContainer();
				return _container;
			}
		}

		/// <summary>
		/// Map an interface type to a class type.
		/// </summary>
		/// <typeparam name="TInterface">Interface type.</typeparam>
		/// <typeparam name="TImplementation">Implementation type.</typeparam>
		public void Register<TInterface, TImplementation>()
		{
			_types[typeof(TInterface)] = typeof(TImplementation);
		}

		/// <summary>
		/// Returns an instance of a correspondig type.
		/// </summary>
		/// <typeparam name="TInterface">Interface.</typeparam>
		public TInterface Get<TInterface>()
		{
			return (TInterface)Get(typeof(TInterface));
		}

		/// <summary>
		/// Returns an instance of a correspondig type.
		/// </summary>
		/// <param name="type">Type we want to get the corresponding implementation.</param>
		public object Get(Type type)
		{
			var constructor = _types[type].GetConstructors()[0];
			var constructorParameters = constructor.GetParameters();

			if (constructorParameters.Length == 0)
				return Activator.CreateInstance(_types[type]);

			object[] parameters = new object[constructorParameters.Length];

			for (int index = 0; index < constructorParameters.Length; index++)
			{
				parameters[index] = Get(constructorParameters[index].ParameterType);
			}

			return constructor.Invoke(parameters);
		}
	}
}