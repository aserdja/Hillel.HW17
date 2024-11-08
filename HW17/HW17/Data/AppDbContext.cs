using HW17.Models;
using Microsoft.EntityFrameworkCore;

namespace HW17.Data
{
	public class AppDbContext : DbContext
	{
		public virtual DbSet<Car> Cars => Set<Car>();

		protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
		{
			optionsBuilder.UseSqlServer("Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=HW17Db;Integrated Security=True;Connect Timeout=30;Encrypt=False;Trust Server Certificate=False;Application Intent=ReadWrite;Multi Subnet Failover=False");
		}
	}	
}
