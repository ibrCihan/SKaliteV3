using SKalite.Repositories;

namespace SKalite.Service.General
{
    public class UnitManager :IUnitService
    {
        private readonly IGenericRepository<Unit> _repository;
        public UnitManager(IGenericRepository<Unit> repository)
        {
            _repository = repository;
        }
        public Unit Create(Unit Unit)
        {
            return _repository.Add(Unit);
        }

        public Unit Delete(int id)
        {
            var delete = _repository.GetById(id);
            return _repository.Delete(delete);
        }

        public Unit Update(Unit Unit, int id)
        {
            return _repository.UpdateById(Unit, id);
        }

        public List<Unit> GetAll()
        {
            return _repository.GetAll();
        }

        public Unit GetById(int id)
        {
            return _repository.GetById(id);
        }
    }
}
