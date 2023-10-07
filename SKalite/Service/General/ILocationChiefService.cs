namespace SKalite.Service.General
{
    public interface ILocationChiefService
    {
        LocationChief Create(LocationChief LocationChief);
        LocationChief Update(LocationChief LocationChief, int id);
        LocationChief Delete(int id);
        LocationChief GetById(int id);
        List<LocationChief> GetAll();
    }
}
