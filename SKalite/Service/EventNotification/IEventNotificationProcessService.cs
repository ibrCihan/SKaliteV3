namespace SKalite.Service.EventNotification
{
    public interface IEventNotificationProcessService
    {
        EventNotificationProcess Create(EventNotificationProcess EventNotificationProcess);
        EventNotificationProcess Update(EventNotificationProcess EventNotificationProcess, int id);
        EventNotificationProcess Delete(int id);
        EventNotificationProcess GetById(int id);
        List<EventNotificationProcess> GetAll();
    }
}
