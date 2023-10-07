namespace SKalite
{
    public interface IEventNotificationService
    {
        EventNotification Create(EventNotification EventNotification);
        EventNotification Update(EventNotification EventNotification, int id);
        EventNotification Delete(int id);
        EventNotification GetById(int id);
        List<EventNotification> GetAll();
    }
}
