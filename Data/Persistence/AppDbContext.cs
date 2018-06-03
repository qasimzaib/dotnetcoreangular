using dotnetcoreangular.Data.Entities;
using Microsoft.EntityFrameworkCore;

namespace dotnetcoreangular.Data.Persistence {
	public class AppDbContext : DbContext {
		public AppDbContext (DbContextOptions<AppDbContext> options)
			: base (options) {}

		public DbSet<Manufacturer> Manufacturers { get; set; }
		public DbSet<Model> Models { get; set; }
	}
}