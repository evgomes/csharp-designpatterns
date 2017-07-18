using CSharp.DesignPatterns.TemplateMethod.Mapping;
using CSharp.DesignPatterns.TemplateMethod.Model;
using System.Data.Entity;

namespace CSharp.DesignPatterns.TemplateMethod.Context
{
	/// <summary>
	/// Template method pattern example. In this example, we have an application where we need to map model
	/// entities to database tables, because we want to use code first approach to develop the database.
	/// We have an user class and we need to define that a user has two properties:
	///		- Id, which will identify the user. It needs to be an identity column;
	///		- Name, which will be required and will have a maxlength of 50 characters.
	///		
	/// To map these classes, a mapping base class was created, and a template method is called at runtime
	/// when the mapping class is created. This template method calls all other mapping methods of each derived
	/// class in order to map a model class to a database table.
	/// 
	/// The goal of template method is to control code flow when we need to call specific methods in sequence, but
	/// we want to distinguish these methods for each derived class.
	/// </summary>
	public class ExampleDbContext : DbContext
	{
		/// <summary>
		/// Users set.
		/// </summary>
		public DbSet<User> User { get; set; }

		/// <summary>
		/// Overrides the default constructor to set the connection string.
		/// </summary>
		public ExampleDbContext() : base("name=ExampleDbContext") { }

		/// <summary>
		/// Overrides this method to add mappings.
		/// </summary>
		/// <param name="modelBuilder">Model builder.</param>
		protected override void OnModelCreating(DbModelBuilder modelBuilder)
		{
			// Adds user mapping. When you run a migration, the User class will be mapped as specified on 
			// UserMapping class, and any other mapping class specified here will be considered for new migrations.
			modelBuilder.Configurations.Add(new UserMapping()); 
			base.OnModelCreating(modelBuilder);
		}
	}
}
