using System;
using System.Collections.Generic;
using System.Text;

namespace Cab_Invoice_Genrater
{
     public class InvoiceGenerator
    {
        public readonly int ratePerKm;
        public readonly int ratePerMin;
        public readonly int MinFare;


        RidesRepository ridesRepository;
        public InvoiceGenerator()
        {
            this.ratePerKm = 10;
            this.ratePerKm = 1;
            this.ratePerKm = 5;
            this.ridesRepository = new RidesRepository();

        }
        public int GetInvoice(int distance, int time)
        {
            var fare = (distance * ratePerKm) + (time * ratePerMin);

            if (fare < MinFare)
                return MinFare;
            return fare;
        }
        public void AddRides(int distance, int time, string userId)
        {
            List<Rides> rides = new List<Rides>();
            rides.Add(new Rides(distance, time));
            ridesRepository.add(rides, userId);
        }
        public CabInvoice TotalFares(string userId)
        {
            int totalfare = 0;
            var userRides = ridesRepository.getRides(userId);

            foreach(var rides in userRides)
            {
                totalfare += GetInvoice(rides.Distance, rides.Time);
            }
            int avg = totalfare / userRides.Count;
            return new CabInvoice(userRides.Count, totalfare, avg);
        }

    }
}
