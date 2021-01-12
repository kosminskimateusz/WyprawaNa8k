using System;

namespace WyprawaNa8k
{
    public class TripWithGroup
    {
        public string Name { get; set; }
        public DateTime StartTime { get; set; }
        public DateTime EndTime { get; set; }
        public int Kilometers { get; set; }
        public TimeSpan Duration { get; set; }
        
        public TripWithGroup(DateTime startTime, DateTime endTime, int kilometers)
        {
            this.StartTime = startTime;
            this.EndTime = endTime;
            this.Kilometers = kilometers;
            Duration = endTime - startTime;
        }
    }
}