using SKalite.Entity.General;

namespace SKalite
{
    public class User:BaseEntity
    {
        public string TCKNumber { get; set; }
        public string Password { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string? EMail { get; set; }
        public string? PhoneNumber { get; set; }
        public UserTitle UserTitle { get; set; }
        public Unit Unit { get; set; }
    }
}
