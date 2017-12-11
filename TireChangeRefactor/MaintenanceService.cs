using System;
using System.Linq;
using TireChangeCS.Domain.Interfaces;
using TireChangeRefactor.Model;

namespace TireChangeRefactor
{
    /// <summary>
    /// Service responsible for determining the maintenance that is required
    /// for aircrafts
    /// </summary>
    public class MaintenanceService : IMaintenanceService
    {
        private ITireChangeable _aircrafts;

        public MaintenanceService(ITireChangeable aircrafts) => 
            _aircrafts = aircrafts ?? throw new ArgumentNullException(nameof(aircrafts));

        /// <summary>
        /// Gets all the aircraft that are due for a tire change.
        /// </summary>
        /// <returns>An array of aircraft that require tire changes according to mfg specifications</returns>
        public AircraftModel[] GetAllAircraftsDueForTireChange()
        {
            return
                _aircrafts.ListDueToTireChange().ToArray();
        }
    }
}
