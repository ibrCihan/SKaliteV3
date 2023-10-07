using SKalite.Entity.General;

namespace SKalite
{
    public class EventNotificationFile:BaseEntity
    {
        public string FilePath { get; set; }
        public EventNotification EventNotification { get; set; }
    }
}
