using System.Collections.Generic;

namespace WyprawaNa8k
{
    public class Trip
    {
        public int TripNumber { get; set; }
        public List<Card> Members = new List<Card>();

        public Trip(int tripNumber, List<Card> members)
        {
            this.TripNumber = tripNumber;
            foreach (var member in members)
            {
                if (!Members.Contains(member))
                {
                    Members.Add(member);
                }
            }
        }
    }
}