using SKalite.Entity.General;

namespace SKalite
{
    public class EventNotificationResult:BaseEntity
    {
        public DateTime ResultDate { get; set; }
        public string Comment { get; set; }
        public ICollection<EventNotification> EventNotifications { get; set; }
        public User User { get; set; }

    }
}
