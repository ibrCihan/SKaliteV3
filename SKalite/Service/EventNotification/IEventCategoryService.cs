namespace SKalite.Service.EventNotification
{
    public interface IEventCategoryService
    {
        EventCategory Create(EventCategory EventCategory);
        EventCategory Update(EventCategory EventCategory, int id);
        EventCategory Delete(int id);
        EventCategory GetById(int id);
        List<EventCategory> GetAll();
    }
}
