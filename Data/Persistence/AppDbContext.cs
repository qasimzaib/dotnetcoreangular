using Microsoft.EntityFrameworkCore;

namespace dotnetcoreangular.Data.Persistence {
	public class AppDbContext : DbContext {
		public AppDbContext (DbContextOptions<AppDbContext> options) : base (options) {
			
		}
	}
}