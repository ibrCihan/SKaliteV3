using SKalite.Entity.General;
using System.Collections.Generic;

namespace SKalite
{
    public class LocationChief:BaseEntity
    {
        public ICollection<Location> Locations { get; set; }
        public User User { get; set; }
    }
}
