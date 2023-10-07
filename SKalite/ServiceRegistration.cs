using Microsoft.EntityFrameworkCore;
using SKalite.Context;
using SKalite.Repositories;
using SKalite.Service.EventNotification;
using SKalite.Service.General;
using SKalite.Service.User;

namespace SKalite
{
    public static class ServiceRegistration
    {
        public static void AddPersistenceServices(this IServiceCollection services)
        {
            services.AddDbContext<SKaliteDbContext>(options => options.UseSqlServer("Server=localhost;Database=SKaliteDB;Trusted_Connection=True;TrustServerCertificate=True;"));
            services.AddScoped(typeof(IGenericRepository<>), typeof(EfRepository<>));
            services.AddScoped<IUserService, UserManager>();
            services.AddScoped<IUserTitleService, UserTitleManager>();
            services.AddScoped<ILocationChiefService, LocationChiefManager>();
            services.AddScoped<ILocationService, LocationManager>();
            services.AddScoped<ITimePeriodService, TimePeriodManager>();
            services.AddScoped<IUnitChiefService, UnitChiefManager>();
            services.AddScoped<IUnitService, UnitManager>();

            services.AddScoped<IEventCategoryService, EventCategoryManager>();
            services.AddScoped<IEventNotificationFileService, EventNotificationFileManager>();
            services.AddScoped<IEventNotificationService, EventNotificationManager>();
            services.AddScoped<IEventNotificationProcessService, EventNotificationProcessManager>();
            services.AddScoped<IEventNotificationResultService, EventNotificationResultManager>();











        }
    }
}
