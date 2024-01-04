using Microsoft.EntityFrameworkCore;

namespace VKStudio.Models
{
	public class StudioDBContext : DbContext
	{ 
		public StudioDBContext(DbContextOptions<StudioDBContext> options) : base(options)
		{

		}

		public DbSet<Image> Images { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                var builder = new ConfigurationBuilder();
                builder.SetBasePath(Directory.GetCurrentDirectory());
                builder.AddJsonFile("appsettings.json");
                var config = builder.Build();
                string connectionString = config.GetConnectionString("DefaultConnection");
                optionsBuilder.UseSqlServer(connectionString);
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
		{
			base.OnModelCreating(modelBuilder);

			modelBuilder.Entity<Image>().HasKey(e => e.ID);
			modelBuilder.Entity<Image>().Property(e => e.Name).IsRequired();
			modelBuilder.Entity<Image>().Property(e => e.URL).IsRequired();
			modelBuilder.Entity<Image>().Property(e => e.IsVisible).IsRequired();
		}
	}
}
