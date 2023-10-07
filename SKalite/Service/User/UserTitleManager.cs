using SKalite.Repositories;

namespace SKalite.Service.User
{
    public class UserTitleManager:IUserTitleService
    {
        private readonly IGenericRepository<UserTitle> _repository;
        public UserTitleManager(IGenericRepository<UserTitle> repository)
        {
            _repository = repository;
        }
        public UserTitle Create(UserTitle userTitle)
        {
            return _repository.Add(userTitle);
        }

        public UserTitle Delete(int id)
        {
            var delete = _repository.GetById(id);
            return _repository.Delete(delete);
        }

        public UserTitle Update(UserTitle userTitle, int id)
        {
            return _repository.UpdateById(userTitle, id);
        }

        public List<UserTitle> GetAll()
        {
            return _repository.GetAll();
        }

        public UserTitle GetById(int id)
        {
            return _repository.GetById(id);
        }
        
    }
}
