namespace Assignment.DTOs
{
#pragma warning disable CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider declaring as nullable.
    public class CreateUserDto
    {
        public int RoleGroupId { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }      
        public int Age { get; set; }
        public  ICollection<HobbyDto> Hobbies { get; set; }        
    }
#pragma warning restore CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider declaring as nullable.
}
