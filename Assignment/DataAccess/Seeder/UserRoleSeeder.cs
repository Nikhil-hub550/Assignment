using Assignment.DataAccess.Models;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using Assignment.Enum;

namespace Assignment.DataAccess.Seeder
{
    public static class UserRoleSeeder
    {
        public static void Conf(ModelBuilder builder)
        {
            builder.Entity<UserRole>().HasData(new UserRole
            {
                Id = 1,
                RoleName = "Administrator"
            },
            new UserRole
            {
                Id = 2,
                RoleName = "Client"
            });
        }
    }
}
