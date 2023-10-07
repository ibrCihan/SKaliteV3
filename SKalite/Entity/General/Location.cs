using SKalite.Entity.General;

namespace SKalite
{
    public class Location:BaseEntity
    {
        public string LocationName { get; set; }
        public ICollection<EventNotification> EventNotifications { get; set; }
        public ICollection<LocationChief> LocationChiefs { get; set; }
    }
}
