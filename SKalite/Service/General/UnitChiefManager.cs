using SKalite.Repositories;

namespace SKalite.Service.General
{
    public class UnitChiefManager:IUnitChiefService
    {
        private readonly IGenericRepository<UnitChief> _repository;
        public UnitChiefManager(IGenericRepository<UnitChief> repository)
        {
            _repository = repository;
        }
        public UnitChief Create(UnitChief UnitChief)
        {
            return _repository.Add(UnitChief);
        }

        public UnitChief Delete(int id)
        {
            var delete = _repository.GetById(id);
            return _repository.Delete(delete);
        }

        public UnitChief Update(UnitChief UnitChief, int id)
        {
            return _repository.UpdateById(UnitChief, id);
        }

        public List<UnitChief> GetAll()
        {
            return _repository.GetAll();
        }

        public UnitChief GetById(int id)
        {
            return _repository.GetById(id);
        }
    }
}
