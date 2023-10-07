

namespace SKalite
{
    public interface IUserService
    {
        User Create(User User);
        User Update(User User, int id);
        User Delete(int id);
        User GetById(int id);
        List<User> GetAll();

    }
}
