using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

namespace RykovaLab3RKIS.ModelEF
{
	public partial class Model1 : DbContext
	{
		public Model1()
			: base("name=Model1")
		{
		}

		public virtual DbSet<Role> Roles { get; set; }
		public virtual DbSet<User> Users { get; set; }

		protected override void OnModelCreating(DbModelBuilder modelBuilder)
		{
			modelBuilder.Entity<Role>()
				.HasMany(e => e.Users)
				.WithRequired(e => e.Role)
				.WillCascadeOnDelete(false);
		}
	}
}
