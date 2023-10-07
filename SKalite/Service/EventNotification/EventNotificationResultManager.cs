using SKalite.Repositories;

namespace SKalite.Service.EventNotification
{
    public class EventNotificationResultManager : IEventNotificationResultService
    {
        private readonly IGenericRepository<EventNotificationResult> _repository;
        public EventNotificationResultManager(IGenericRepository<EventNotificationResult> repository)
        {
            _repository = repository;
        }
        public EventNotificationResult Create(EventNotificationResult EventNotificationResult)
        {
            return _repository.Add(EventNotificationResult);
        }

        public EventNotificationResult Delete(int id)
        {
            var delete = _repository.GetById(id);
            return _repository.Delete(delete);
        }

        public EventNotificationResult Update(EventNotificationResult EventNotificationResult, int id)
        {
            return _repository.UpdateById(EventNotificationResult, id);
        }

        public List<EventNotificationResult> GetAll()
        {
            return _repository.GetAll();
        }

        public EventNotificationResult GetById(int id)
        {
            return _repository.GetById(id);
        }
    }
}
