using SKalite.Entity.General;

namespace SKalite
{
    public class EventCategory:BaseEntity
    {
        public string EventCategoryName { get; set; }
        public int TopEventCategory { get; set; } = 0;
        public ICollection<EventNotification> EventNotifications { get; set; }
    }
}
