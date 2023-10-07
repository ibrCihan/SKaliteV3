using SKalite.Repositories;

namespace SKalite.Service.EventNotification
{
    public class EventNotificationProcessManager : IEventNotificationProcessService
    {
        private readonly IGenericRepository<EventNotificationProcess> _repository;
        public EventNotificationProcessManager(IGenericRepository<EventNotificationProcess> repository)
        {
            _repository = repository;
        }
        public EventNotificationProcess Create(EventNotificationProcess EventNotificationProcess)
        {
            return _repository.Add(EventNotificationProcess);
        }

        public EventNotificationProcess Delete(int id)
        {
            var delete = _repository.GetById(id);
            return _repository.Delete(delete);
        }

        public EventNotificationProcess Update(EventNotificationProcess EventNotificationProcess, int id)
        {
            return _repository.UpdateById(EventNotificationProcess, id);
        }

        public List<EventNotificationProcess> GetAll()
        {
            return _repository.GetAll();
        }

        public EventNotificationProcess GetById(int id)
        {
            return _repository.GetById(id);
        }
    }
}
