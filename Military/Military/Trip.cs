using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text;

namespace Military
{
    public static class Trip
    {
        public static int distanceGround { get; set; }
        public static int distanceWater { get; set; }
        public static decimal? lessConsumption { get; set; }
        public static Vehicle BestVehicle { get; set; }

        public static bool bestVehicle(decimal consumption)
        {
            var isBest = false;
            if (lessConsumption.HasValue)
            {
                if (lessConsumption.Value > consumption)
                {
                    lessConsumption = consumption;
                    isBest = true;
                }
            }
            else
            {
                lessConsumption = consumption;
                isBest = true;
            }
            return isBest;
        }
        public static int RandomNumber(int min, int max)
        {
            Random random = new Random();
            return random.Next(min, max);
        }
    }


}
