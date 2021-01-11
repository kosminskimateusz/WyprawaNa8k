using System;
using System.Collections.Generic;

namespace WyprawaNa8k
{
    public class GuideMember : Card
    {
        public int TripNumber { get; set; }
        public string GuideId { get; set; }
        List<Card> Members { get; set; }

        public GuideMember(string owner, string guideId) : base(owner)
        {
            this.GuideId = guideId;
            Members = new List<Card>();
        }
        public void RegisterNewTripWithMembers(int tripNumber, Card card)
        {
            Members.Add(card);
            this.TripNumber = tripNumber;
            Trip trip = new Trip(tripNumber, Members);

        }

        public void ShowTripMembers(int tripNumber)
        {
            this.TripNumber = tripNumber;
            foreach (var member in Members)
            {
                Console.WriteLine($"Numer wycieczki: {TripNumber}");
                Console.WriteLine("Members:");
                Console.WriteLine($"\t{member.Owner}");
            }
        }
    }
}