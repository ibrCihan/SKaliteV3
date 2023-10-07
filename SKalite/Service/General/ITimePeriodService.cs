namespace SKalite.Service.General
{
    public interface ITimePeriodService
    {
        TimePeriod Create(TimePeriod TimePeriod);
        TimePeriod Update(TimePeriod TimePeriod, int id);
        TimePeriod Delete(int id);
        TimePeriod GetById(int id);
        List<TimePeriod> GetAll();
    }
}
