namespace Assignment.DTOs
{
    public class GetAllUserDto
    {
        public string UserId { get; set; }
        public string UserNo { get; set; }
        public int RoleGroupId { get; set; }
        public string UserName { get; set; }      
        public int Age { get; set; }
        public ICollection<HobbyDto> Hobbies { get; set; }
    }
}
