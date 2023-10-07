using SKalite.Repositories;

namespace SKalite.Service.General
{
    public class LocationManager:ILocationService
    {
        private readonly IGenericRepository<Location> _repository;
        public LocationManager(IGenericRepository<Location> repository)
        {
            _repository = repository;
        }
        public Location Create(Location Location)
        {
            return _repository.Add(Location);
        }

        public Location Delete(int id)
        {
            var delete = _repository.GetById(id);
            return _repository.Delete(delete);
        }

        public Location Update(Location Location, int id)
        {
            return _repository.UpdateById(Location, id);
        }

        public List<Location> GetAll()
        {
            return _repository.GetAll();
        }

        public Location GetById(int id)
        {
            return _repository.GetById(id);
        }
    }
}
