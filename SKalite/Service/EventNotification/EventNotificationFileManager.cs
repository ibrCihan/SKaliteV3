using SKalite.Repositories;

namespace SKalite.Service.EventNotification
{
    public class EventNotificationFileManager : IEventNotificationFileService
    {
        private readonly IGenericRepository<EventNotificationFile> _repository;
        public EventNotificationFileManager(IGenericRepository<EventNotificationFile> repository)
        {
            _repository = repository;
        }
        public EventNotificationFile Create(EventNotificationFile EventNotificationFile)
        {
            return _repository.Add(EventNotificationFile);
        }

        public EventNotificationFile Delete(int id)
        {
            var delete = _repository.GetById(id);
            return _repository.Delete(delete);
        }

        public EventNotificationFile Update(EventNotificationFile EventNotificationFile, int id)
        {
            return _repository.UpdateById(EventNotificationFile, id);
        }

        public List<EventNotificationFile> GetAll()
        {
            return _repository.GetAll();
        }

        public EventNotificationFile GetById(int id)
        {
            return _repository.GetById(id);
        }
    }
}
