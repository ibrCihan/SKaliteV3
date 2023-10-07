namespace SKalite.Service.User
{
    public interface IUserTitleService
    {
        UserTitle Create(UserTitle userTitle);
        UserTitle Update(UserTitle userTitle,int id);
        UserTitle Delete(int id);
        UserTitle GetById(int id);
        List<UserTitle> GetAll();
    }
}
