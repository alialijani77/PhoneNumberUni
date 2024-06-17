using Microsoft.EntityFrameworkCore;
using PhoneNumber.Data.Entities.User;

namespace PhoneNumber.Data.Context
{
	public class MyDbContext : DbContext
	{

		protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
	=> optionsBuilder.UseSqlServer("Data Source = .; Initial Catalog = PhoneDb; Integrated Security = true; MultipleActiveResultSets=true; TrustServerCertificate=True");

		public DbSet<People> Peoples { get; set; }

		public DbSet<Role> Roles { get; set; }

		public DbSet<User> Users { get; set; }
	}
}
