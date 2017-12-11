using TireChangeRefactor.Model;

namespace TireChangeRefactor
{
    public interface IMaintenanceService
    {
        AircraftModel[] GetAllAircraftsDueForTireChange();
    }
}
