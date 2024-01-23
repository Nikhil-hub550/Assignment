using Microsoft.EntityFrameworkCore;

namespace Assignment.DataAccess.Seeder
{
    public class MainSeeder
    {
        protected MainSeeder()
        {

        }
        public static void SeedData(ModelBuilder modelBuilder)
        {
            UserRoleSeeder.Conf(modelBuilder);
            UserSeeder.UserConfigure(modelBuilder);
        }
    }
}
