using SKalite.Entity.General;

namespace SKalite
{
    public class Unit:BaseEntity
    {
        public string UnitName { get; set; }
        public int TopUnitId { get; set; }
        public ICollection<UnitChief> UnitChiefs { get; set; }
        public ICollection<User> Users { get; set; }
    }
}
