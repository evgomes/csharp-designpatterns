using System.Data.Entity.ModelConfiguration;

namespace CSharp.DesignPatterns.TemplateMethod.Mapping.Base
{
	/// <summary>
	/// Mapping template. A inherited class has to implement all abstract methods to set how a determined class
	/// will be mapped to database.
	/// </summary>
	/// <typeparam name="T"></typeparam>
	public abstract class MappingTemplate<T> : EntityTypeConfiguration<T> where T : class
	{
		/// <summary>
		/// Calls the template method to execute mapping.
		/// </summary>
		public MappingTemplate()
		{
			MapTemplateMethod();
		}

		/// <summary>
		/// Template method that defines the sequence of methods called to configure an entity mapping.
		/// </summary>
		public void MapTemplateMethod()
		{
			CreateTable();
			CreateColumns();
			SetPrimaryKey();
			SetForeignKeys();
		}

		/// <summary>
		/// Creates the corresponding table.
		/// </summary>
		protected abstract void CreateTable();

		/// <summary>
		/// Creates all table columns.
		/// </summary>
		protected abstract void CreateColumns();

		/// <summary>
		/// Sets the primary key.
		/// </summary>
		protected abstract void SetPrimaryKey();

		/// <summary>
		/// Sets the foreign keys.
		/// </summary>
		protected abstract void SetForeignKeys();
	}
}
