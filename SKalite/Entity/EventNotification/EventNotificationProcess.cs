using SKalite.Entity.General;

namespace SKalite
{
    public class EventNotificationProcess:BaseEntity
    {
        public int AssignUserId { get; set; } // Atama Yapan
        public int AssignedByUserId { get; set; } //Atanan
        public EventNotification EventNotification { get; set; }
        
    }
}
