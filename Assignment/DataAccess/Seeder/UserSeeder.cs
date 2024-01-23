using Assignment.DataAccess.Models;
using Microsoft.EntityFrameworkCore;

namespace Assignment.DataAccess.Seeder
{
    public static class UserSeeder
    {
        public static void UserConfigure(ModelBuilder builder)
        {
            builder.Entity<User>().HasData(new User
            {
               UserId = Guid.Parse("B376EF40-DD88-4674-AF1B-D09550E42FCD"),
               RoleGroupId = 1,
               UserNo = 1,
               UserName = "Nikhil",
               Password = "Welcome@123",
               IsAdmin = true,
               Age = 23
            });
        }
    }
}
