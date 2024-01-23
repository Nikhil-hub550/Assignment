namespace Assignment.DataAccess.Models
{
#pragma warning disable CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider declaring as nullable.
    public class Hobby 
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public string Name { get; set; }
        public virtual User User { get; set; }
    }
#pragma warning restore CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider declaring as nullable.
}
