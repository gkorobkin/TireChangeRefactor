using System.Collections.Generic;
using TireChangeRefactor.Model;

namespace TireChangeCS.Domain.Interfaces
{
    public interface ITireChangeable
    {
        IEnumerable<AircraftModel> ListDueToTireChange();
    }
}
