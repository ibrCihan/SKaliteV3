using SKalite.Repositories;

namespace SKalite.Service.General
{
    public class LocationChiefManager:ILocationChiefService
    {
        private readonly IGenericRepository<LocationChief> _repository;
        public LocationChiefManager(IGenericRepository<LocationChief> repository)
        {
            _repository = repository;
        }
        public LocationChief Create(LocationChief LocationChief)
        {
            return _repository.Add(LocationChief);
        }

        public LocationChief Delete(int id)
        {
            var delete = _repository.GetById(id);
            return _repository.Delete(delete);
        }

        public LocationChief Update(LocationChief LocationChief, int id)
        {
            return _repository.UpdateById(LocationChief, id);
        }

        public List<LocationChief> GetAll()
        {
            return _repository.GetAll();
        }

        public LocationChief GetById(int id)
        {
            return _repository.GetById(id);
        }
    }
}
