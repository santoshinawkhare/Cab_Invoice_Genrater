using Cab_Invoice_Genrater;
using NUnit.Framework;

namespace Cab_Invoice_test
{
    public class Tests
    {
        InvoiceGenerator cabInvoice;

        [SetUp]
        public void Setup()
        {
            cabInvoice = new InvoiceGenerator();
        }

        /// <summary>
        /// Passings the time 10 min and distance 10 km should return fare.
        /// </summary>
        [Test]
        public void PassingTimeAndDistanceShouldReturnFare()
        {
            int expectedResult = 110;
            var actual = cabInvoice.GetInvoice(10, 10);
            Assert.AreEqual(expectedResult, actual);
        }

        [Test]
        public void PassingTimeAsZeroAndDistanceAsZeroShouldReturnFareAsFive()
        {
            int expectedResult = 5;
            var actual = cabInvoice.GetInvoice(0, 0);
            Assert.AreEqual(expectedResult, actual);
        }

        [Test]
        public void AddMultipleRidesShouldReturnTotalNoOfRides()
        {
            int expectedResult = 200;
            cabInvoice.AddRides(10, 20, "C1010");
            cabInvoice.AddRides(5, 30, "C1010");
            var actual = cabInvoice.TotalFares("C1010");
            Assert.AreEqual(expectedResult, actual.TotalFare);
        }
        public void AddMultipleRidesShouldReturnAvgFarePerRide()
        {
            int expectedResult = 100;
            cabInvoice.AddRides(10, 20, "C3010");
            cabInvoice.AddRides(5, 30, "C3010");
            var actual = cabInvoice.TotalFares("C3010");
            Assert.AreEqual(expectedResult, actual.AvgFarePerRide);
        }
    }
}