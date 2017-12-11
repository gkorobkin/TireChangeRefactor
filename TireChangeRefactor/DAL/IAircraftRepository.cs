using System.Collections.Generic;
using TireChangeRefactor.Model;

namespace TireChangeRefactor.DAL
{
    public interface IAircraftRepository
    {
        IEnumerable<AircraftModel> GetAll();
    }
}