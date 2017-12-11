using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TireChangeCS.Domain;

namespace TireChangeRefactor.Tests
{
    //  TODO: Add unit-tests for AircraftRepository and TireChangeableAircrafts classes.

    [TestClass]
    public class MaintenanceServiceTests
    {
        [TestMethod]
        public void MaintenanceService_GetAllAircraftDueForTireChange()
        {
            var repo = new DAL.AircraftRepository();
            var aircrafts = new TireChangeableAircrafts(repo);

            // Arrange
            IMaintenanceService mtxSvc = new MaintenanceService(aircrafts);
            int[] expected = {1, 3, 5};

            // Act
            var actual = mtxSvc.GetAllAircraftsDueForTireChange().Select(x => x.Id).ToArray();

            // Assert
            CollectionAssert.AreEqual(expected, actual);
        }
    }
}
