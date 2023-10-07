namespace SKalite.Service.EventNotification
{
    public interface IEventNotificationResultService
    {
        EventNotificationResult Create(EventNotificationResult EventNotificationResult);
        EventNotificationResult Update(EventNotificationResult EventNotificationResult, int id);
        EventNotificationResult Delete(int id);
        EventNotificationResult GetById(int id);
        List<EventNotificationResult> GetAll();
    }
}
