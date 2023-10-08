using Microsoft.EntityFrameworkCore;
using SKalite.Entity.Document;
using System.Reflection.Metadata;

namespace SKalite.Context
{
    public class SKaliteDbContext:DbContext
    {
        public SKaliteDbContext(DbContextOptions options) : base(options)
        {

        }
        public DbSet<EventCategory> EventCategories { get; set; }
        public DbSet<EventNotification> EventNotifications { get; set; }
        public DbSet<EventNotificationFile> EventNotificationFiles { get; set; }
        public DbSet<EventNotificationProcess> EventNotificationProcesses { get; set; }
        public DbSet<EventNotificationResult> EventNotificationResults { get; set; }
        public DbSet<Location> Locations { get; set; }
        public DbSet<LocationChief> locationChiefs { get; set; }
        public DbSet<TimePeriod> TimePeriods { get; set; }
        public DbSet<Unit> Units { get; set; }
        public DbSet<UnitChief> UnitChiefs { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<UserTitle> UserTitles { get; set; }

        public DbSet<Entity.Document.Document> Documents { get; set; }
        public DbSet<DocumentCategory> DocumentCategories { get; set; }
        public DbSet<DocumentFiles> DocumentFiles { get; set; }
        public DbSet<DocumentProcess> DocumentProcesses { get; set; }
        public DbSet<DocumentType> DocumentTypes { get; set; }



    }
}
