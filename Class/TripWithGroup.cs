using System;

namespace WyprawaNa8k
{
    public class TripWithGroup
    {
        public DateTime StartTime { get; set; }
        public DateTime EndTime { get; set; }
        public int Kilometers { get; set; }
        public TripWithGroup(DateTime startTime, DateTime endTime, int kilometers)
        {
            
        }
    }
}