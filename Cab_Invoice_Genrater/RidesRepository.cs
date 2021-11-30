using System;
using System.Collections.Generic;
using System.Text;

namespace Cab_Invoice_Genrater
{
     public class RidesRepository
    {
        Dictionary<string, List<Rides>> ridesRepo;

        public RidesRepository()
        {
            this.ridesRepo =  new Dictionary<string, List<Rides>>();
        }
        public void add(List<Rides> rides, string userId)
        {
            if (ridesRepo.ContainsKey(userId))
            {
                ridesRepo[userId].AddRange(rides);
            }
            if (!ridesRepo.ContainsKey(userId))
            {
                ridesRepo.Add(userId, rides);
            }
        }
        public List<Rides> getRides(string userId)
        {
            if (ridesRepo.ContainsKey(userId))
            {
                return ridesRepo[userId];
            }

            if (!ridesRepo.ContainsKey(userId))
            {
                return new List<Rides>();
            }
            return new List<Rides>();
        }
    }
}
