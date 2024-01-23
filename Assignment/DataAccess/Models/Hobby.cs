namespace Assignment.DataAccess.Models
{
    public class Hobby 
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public string Name { get; set; }
        public virtual User User { get; set; }
    }
}
