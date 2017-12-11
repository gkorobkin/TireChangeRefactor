using System;
using System.Collections.Generic;
using System.Linq;
using TireChangeCS.Domain.Interfaces;
using TireChangeRefactor.DAL;
using TireChangeRefactor.Model;

namespace TireChangeCS.Domain
{
    public class TireChangeableAircrafts : ITireChangeable
    {
        private IAircraftRepository _repo;

        public TireChangeableAircrafts(IAircraftRepository repo) => 
            _repo = repo ?? throw new ArgumentNullException(nameof(repo));

        public IEnumerable<AircraftModel> ListDueToTireChange() => _repo.GetAll()
                .Where(am => IsTireChangeDue(am.model, am.LandingsToChange)).Select(a => a.model);

        private bool IsTireChangeDue(AircraftModel model, int LandingsToChange)
        {
            //  search into the SORTED list
            var idx = model.Landings.BinarySearch(model.LastTireChange);

            return model.Landings.Count - (idx < 0 ? ~idx : idx) >= LandingsToChange;
        }
    }
}
