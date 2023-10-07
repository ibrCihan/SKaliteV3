namespace SKalite.Service.General
{
    public interface IUnitChiefService
    {
        UnitChief Create(UnitChief UnitChief);
        UnitChief Update(UnitChief UnitChief, int id);
        UnitChief Delete(int id);
        UnitChief GetById(int id);
        List<UnitChief> GetAll();
    }
}
