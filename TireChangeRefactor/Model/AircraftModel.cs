using System;
using System.Collections.Generic;

namespace TireChangeRefactor.Model
{
    /// <summary>
    /// Class that describes an aircraft
    /// </summary>
    public class AircraftModel
    {
        public int Id { get; set; }
        public DateTime LastTireChange { get; set; }
        public int ManufacturerId { get; set; }
        public List<DateTime> Landings { get; set; }  
    }
}
