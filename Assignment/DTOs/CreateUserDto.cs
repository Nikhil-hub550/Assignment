namespace Assignment.DTOs
{
    public class CreateUserDto
    {
        public int RoleGroupId { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }      
        public int Age { get; set; }
        public  ICollection<HobbyDto> Hobbies { get; set; }        
    }
}
