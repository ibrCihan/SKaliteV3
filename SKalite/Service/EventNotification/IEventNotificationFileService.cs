namespace SKalite.Service.EventNotification
{
    public interface IEventNotificationFileService
    {
        EventNotificationFile Create(EventNotificationFile EventNotificationFile);
        EventNotificationFile Update(EventNotificationFile EventNotificationFile, int id);
        EventNotificationFile Delete(int id);
        EventNotificationFile GetById(int id);
        List<EventNotificationFile> GetAll();
    }
}
