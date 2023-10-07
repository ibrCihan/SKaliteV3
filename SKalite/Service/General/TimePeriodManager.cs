using SKalite.Repositories;

namespace SKalite.Service.General
{
    public class TimePeriodManager:ITimePeriodService
    {
        private readonly IGenericRepository<TimePeriod> _repository;
        public TimePeriodManager(IGenericRepository<TimePeriod> repository)
        {
            _repository = repository;
        }
        public TimePeriod Create(TimePeriod TimePeriod)
        {
            return _repository.Add(TimePeriod);
        }

        public TimePeriod Delete(int id)
        {
            var delete = _repository.GetById(id);
            return _repository.Delete(delete);
        }

        public TimePeriod Update(TimePeriod TimePeriod, int id)
        {
            return _repository.UpdateById(TimePeriod, id);
        }

        public List<TimePeriod> GetAll()
        {
            return _repository.GetAll();
        }

        public TimePeriod GetById(int id)
        {
            return _repository.GetById(id);
        }
    }
}
