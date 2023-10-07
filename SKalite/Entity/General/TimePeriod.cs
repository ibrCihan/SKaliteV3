using SKalite.Entity.General;

namespace SKalite
{
    public class TimePeriod:BaseEntity
    {
        public string TimePeriodName { get; set; }
        public ICollection<EventNotification> EventNotifications { get; set; }
    }
}
