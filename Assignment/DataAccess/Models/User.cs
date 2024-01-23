using System.ComponentModel.DataAnnotations;

namespace Assignment.DataAccess.Models
{
    public class User 
    {
        
        public Guid UserId { get; set; }
        [Key]
        public int UserNo { get; set; }
        public int RoleGroupId { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
        public bool IsAdmin { get; set; } = false;
        public int Age { get; set; }
        public virtual ICollection<Hobby> Hobbies { get; set; }
        public virtual UserRole Role { get; set; }
    }
}
