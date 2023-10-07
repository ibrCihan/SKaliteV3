using SKalite.Entity.General;
using System.ComponentModel.DataAnnotations.Schema;

namespace SKalite
{
    public class EventNotification:BaseEntity
    {
        //public int UserId { get; set; }
        //public int EventCategoryId { get; set; }
        //public int LocationId { get; set; }
        //public int TimePeriodId { get; set; }
        public int IsSecret { get; set; }
        public int IsEventFinished { get; set; }
        public int? UserById { get; set; }
        public string? EffectedByUserId { get; set; }

        [ForeignKey(nameof(User))]
        public int UserId { get; set; }
        public DateTime EventDate { get; set; }
        public string? Comment { get; set; }
        //public User User { get; set; }
        public EventCategory EventCategory { get; set; }
        public Location Location { get; set; }
        public TimePeriod TimePeriod { get; set; }
        public ICollection<EventNotificationFile> EventNotificationFiles { get; set; }
        public ICollection<EventNotificationProcess> EventNotificationProcesses { get; set; }
        public EventNotificationResult EventNotificationResults { get; set; }

    }
}
