using SKalite.Repositories;

namespace SKalite
{
    public class EventNotificationManager : IEventNotificationService
    {
        private readonly IGenericRepository<EventNotification> _repository;
        public EventNotificationManager(IGenericRepository<EventNotification> repository)
        {
            _repository = repository;
        }
        public EventNotification Create(EventNotification EventNotification)
        {
            return _repository.Add(EventNotification);
        }

        public EventNotification Delete(int id)
        {
            var delete = _repository.GetById(id);
            return _repository.Delete(delete);
        }

        public EventNotification Update(EventNotification EventNotification, int id)
        {
            return _repository.UpdateById(EventNotification, id);
        }

        public List<EventNotification> GetAll()
        {
            return _repository.GetAll();
        }

        public EventNotification GetById(int id)
        {
            return _repository.GetById(id);
        }
    }
}
