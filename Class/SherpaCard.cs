using System;
using System.Collections.Generic;
using System.Text;

namespace WyprawaNa8k
{
    public class SherpaCard : Card
    {
        public static List<Card> cards {get;set;}
        public string SherpaId { get; set; }
        public List<TripWithGroup> ListOfTripsWithGroup = new List<TripWithGroup>();
        public SherpaCard(string owner, string sherpaId) : base(owner)
        {
            this.SherpaId = sherpaId;
            // cards.Add();
        }
        public void RegisterNewTripWithGroup(DateTime startTime, DateTime endTime, int kilometers)
        {
            TripWithGroup trip = new TripWithGroup(startTime, endTime, kilometers);
            ListOfTripsWithGroup.Add(trip);
        }

        public string Trips()
        {
            string text = "Oto lista wycieczek:\n";
            StringBuilder showTripsStringBuilder = new StringBuilder(text);

            foreach (var trip in ListOfTripsWithGroup)
            {
                showTripsStringBuilder.Append($"\n\tData rozpoczęcia:");
                showTripsStringBuilder.AppendLine($"\t{trip.StartTime.ToString("dd-MM-yyyy hh:mm:ss")}");

                showTripsStringBuilder.Append($"\tData zakończenia:");
                showTripsStringBuilder.AppendLine($"\t{trip.EndTime.ToString("dd-MM-yyyy hh:mm:ss")}");

                string output = trip.Duration.ToString(@"dd\ \d\n\i\ hh\:mm\:ss");
                showTripsStringBuilder.Append($"\tCzas trwania:\t\t");
                showTripsStringBuilder.AppendLine(output);

                showTripsStringBuilder.Append($"\tIlość kilometrów:");
                showTripsStringBuilder.AppendLine($"\t{trip.Kilometers} km.\n");
            }

            return showTripsStringBuilder.ToString();
        }
    }
}