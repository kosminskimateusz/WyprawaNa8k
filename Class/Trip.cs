using System.Collections.Generic;

namespace WyprawaNa8k
{
    public class Trip
    {
        public string TripName { get; set; }
        public List<Card> TripMembers = new List<Card>();

        public Trip(string tripName, List<Card> members)
        {
            this.TripName = tripName;
            foreach (var member in members)
            {
                if (!TripMembers.Contains(member))
                {
                    TripMembers.Add(member);
                }
            }
        }

        public List<Card> ShowMembersOfTrip(Trip trip)
        {

            return TripMembers;
        }
    }
}