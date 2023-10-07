namespace SKalite.Service.General
{
    public interface ILocationService
    {
        Location Create(Location Location);
        Location Update(Location Location, int id);
        Location Delete(int id);
        Location GetById(int id);
        List<Location> GetAll();
    }
}
