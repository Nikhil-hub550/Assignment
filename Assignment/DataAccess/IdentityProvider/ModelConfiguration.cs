using Assignment.DataAccess.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;

namespace Assignment.DataAccess.IdentityProvider
{
    public class ModelConfiguration
    {
        public static void Configure(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<User>(entity =>
            {
                entity.ToTable(name: "Users", schema: "master");
                entity.Property(e => e.UserId);
                entity.HasIndex(e => e.UserId).IsUnique();
                entity.Property(e => e.Age).IsRequired(true);
                entity.Property(e => e.UserId).IsRequired(true);
                entity.Property(e => e.UserName).IsRequired(true);
                entity.Property(e => e.Password).IsRequired(true);
                entity.HasMany(e => e.Hobbies).WithOne(e => e.User).HasForeignKey(e => e.UserId).OnDelete(DeleteBehavior.Cascade);
                entity.HasOne(e => e.Role).WithMany().HasForeignKey(e => e.RoleGroupId).OnDelete(DeleteBehavior.Cascade);
              
            });          
        }
    }

}
