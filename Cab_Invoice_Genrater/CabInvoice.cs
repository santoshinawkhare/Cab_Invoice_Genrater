using System;

namespace Cab_Invoice_Genrater
{
    public class CabInvoice
    {
        public int NoOfRides;
        public int TotalFare;
        public int AvgFarePerRide;
        public CabInvoice(int noOfRides, int totalFare, int avgFarePerRide)
        {
            this.NoOfRides = noOfRides;
           this.TotalFare = totalFare;
           this.AvgFarePerRide = avgFarePerRide;
        }

    }
}