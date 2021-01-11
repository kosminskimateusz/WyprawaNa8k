using System;
using System.Collections.Generic;
using System.Text;

namespace WyprawaNa8k
{
    public class SherpaCard : Card
    {
        public string SherpaId { get; set; }
        private List<TripWithGroup> ListOfTripsWithGroup = new List<TripWithGroup>();
        public SherpaCard(string owner, string sherpaId) : base(owner)
        {
            this.SherpaId = sherpaId;
        }
        public void RegisterNewTripWithGroup(DateTime startTime, DateTime endTime, int kilometers)
        {
            TripWithGroup trip = new TripWithGroup(DateTime.Now, DateTime.Now, kilometers);
            ListOfTripsWithGroup.Add(trip);
        }

        public string ShowTrips()
        {
            string text = "Oto lista wycieczek:\n\n\n\t";
            StringBuilder stringBuilder = new StringBuilder(text);
            foreach (var trip in ListOfTripsWithGroup)
            {
                stringBuilder.AppendLine($"Data rozpoczęcia: ");
                stringBuilder.AppendLine($"\t\t\t{trip.StartTime.Date}");
            }


            return stringBuilder.ToString();
        }
    }
}