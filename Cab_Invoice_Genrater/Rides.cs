using System;
using System.Collections.Generic;
using System.Text;

namespace Cab_Invoice_Genrater
{
     public class Rides
    {
        public int Distance;
        public int Time;
        public Rides(int distance, int time)
        {
            this.Distance = distance;
            this.Time = time;
        }
    }
}
