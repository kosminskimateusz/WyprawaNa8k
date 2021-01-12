using System;
using System.Linq;
using System.Collections.Generic;

namespace WyprawaNa8k
{
    public class GuideMember : Card
    {
        public int TripNumber { get; set; }
        public string GuideId { get; set; }
        List<Card> Members { get; set; }
        List<Trip> Trips = new List<Trip>();

        public GuideMember(string owner, string guideId) : base(owner)
        {
            this.GuideId = guideId;
            Members = new List<Card>();
        }
        
        public void RegisterNewTripWithMembers(string tripName)
        {
            Trip newTrip = new Trip(tripName, Members);
            Trips.Add(newTrip);
            Members.Clear();
        }

        public void RegisterNewMember(Card member)
        {
            Members.Add(member);
        }

        public void ShowTrips()
        {
            var tripsNames = Trips.Select(trip => trip.TripName);
            var tripsMembersLists = Trips.Select(trip => trip.TripMembers);
            var tripMembersList = tripsMembersLists.Select(list => list.Select(card => card)).ToList();

            for (int i = 0; i < Trips.Count; i++)
            {
                Console.WriteLine(tripsNames.ToList()[i] + '\n');

                foreach(var member in tripMembersList[i])
                {
                    Console.WriteLine($"Name: {member.Owner}\t\tCard nr: {member.Number}");
                }
                Console.WriteLine('\n');
            }
        }
    }
}