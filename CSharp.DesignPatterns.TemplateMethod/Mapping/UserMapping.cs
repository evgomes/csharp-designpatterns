using CSharp.DesignPatterns.TemplateMethod.Mapping.Base;
using CSharp.DesignPatterns.TemplateMethod.Model;
using System.ComponentModel.DataAnnotations.Schema;

namespace CSharp.DesignPatterns.TemplateMethod.Mapping
{
	/// <summary>
	/// Maps the users table.
	/// </summary>
	public class UserMapping : MappingTemplate<User>
	{

		/// <summary>
		/// Creates the corresponding table.
		/// </summary>
		protected override void CreateTable()
		{
			ToTable("Users");
		}

		/// <summary>
		/// Creates all table columns.
		/// </summary>
		protected override void CreateColumns()
		{
			Property(p => p.Id).IsRequired().HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
			Property(p => p.Name).IsRequired().HasMaxLength(50);
		}

		/// <summary>
		/// Sets the primary key.
		/// </summary>
		protected override void SetPrimaryKey()
		{
			HasKey(p => p.Id);
		}

		/// <summary>
		/// Sets the foreign keys.
		/// </summary>
		protected override void SetForeignKeys()
		{
			// Empty, there aren't foreign keys.
		}
	}
}
