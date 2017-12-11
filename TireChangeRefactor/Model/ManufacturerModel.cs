namespace TireChangeRefactor.Model
{
    /// <summary>
    /// Class that describes an aircraft tire manufacturer
    /// </summary>
    public class ManufacturerModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        //  number of landings to change the tires
        public int LandingsToChange { get; set; }
    }
}
