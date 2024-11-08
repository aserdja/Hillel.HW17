using HW17.Models;
using Microsoft.EntityFrameworkCore;

namespace HW17.Data
{
	public class AppDbContext : DbContext
	{
		public virtual DbSet<Car> Cars => Set<Car>();

		protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
		{
			optionsBuilder.UseSqlServer();
		}
	}	
}
