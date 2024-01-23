using Assignment.DataAccess.IdentityProvider;
using Assignment.DataAccess.Models;
using Assignment.DataAccess.Seeder;
using Microsoft.EntityFrameworkCore;

namespace Assignment.DataAccess.Data
{
    public class BaxtureDbContext : DbContext
    {
        private readonly IConfiguration _configuration;
        public DbSet<User> Users { get; set; }
        public DbSet<UserRole> UserRoles { get; set; }
        public DbSet<Hobby> Hobbies { get; set; }
        
        public BaxtureDbContext()
        {

        }
        public BaxtureDbContext(IConfiguration configuration, DbContextOptions<BaxtureDbContext> options) : base(options)
        {
            _configuration = configuration;
        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
            optionsBuilder.UseSqlServer(_configuration.GetConnectionString("MyConnection"));
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            ModelConfiguration.Configure(modelBuilder);
            MainSeeder.SeedData(modelBuilder);
        }
    }
}
