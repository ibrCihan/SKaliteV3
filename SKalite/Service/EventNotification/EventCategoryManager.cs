using SKalite.Repositories;

namespace SKalite.Service.EventNotification
{
    public class EventCategoryManager : IEventCategoryService
    {
        private readonly IGenericRepository<EventCategory> _repository;
        public EventCategoryManager(IGenericRepository<EventCategory> repository)
        {
            _repository = repository;
        }
        public EventCategory Create(EventCategory EventCategory)
        {
            return _repository.Add(EventCategory);
        }

        public EventCategory Delete(int id)
        {
            var delete = _repository.GetById(id);
            return _repository.Delete(delete);
        }

        public EventCategory Update(EventCategory EventCategory, int id)
        {
            return _repository.UpdateById(EventCategory, id);
        }

        public List<EventCategory> GetAll()
        {
            return _repository.GetAll();
        }

        public EventCategory GetById(int id)
        {
            return _repository.GetById(id);
        }
    }
}
