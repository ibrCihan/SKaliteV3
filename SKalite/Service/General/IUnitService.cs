namespace SKalite.Service.General
{
    public interface IUnitService
    {
        Unit Create(Unit Unit);
        Unit Update(Unit Unit, int id);
        Unit Delete(int id);
        Unit GetById(int id);
        List<Unit> GetAll();
    }
}
