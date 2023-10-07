
using SKalite.Repositories;

namespace SKalite
{
    public class UserManager : IUserService
    {
        private readonly IGenericRepository<User> _repository;
        public UserManager(IGenericRepository<User> repository)
        {
            _repository = repository;
        }
        public User Create(User User)
        {
            return _repository.Add(User);
        }

        public User Delete(int id)
        {
            var delete = _repository.GetById(id);
            return _repository.Delete(delete);
        }

        public User Update(User User, int id)
        {
            return _repository.UpdateById(User, id);
        }

        public List<User> GetAll()
        {
            return _repository.GetAll();
        }

        public User GetById(int id)
        {
            return _repository.GetById(id);
        }
    }
}
