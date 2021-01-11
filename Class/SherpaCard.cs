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
            TripWithGroup trip = new TripWithGroup(startTime, endTime, kilometers);
            ListOfTripsWithGroup.Add(trip);
        }

        public string ShowTrips()
        {
            string text = "Oto lista wycieczek:\n\n\n";
            StringBuilder stringBuilder = new StringBuilder(text);
            foreach (var trip in ListOfTripsWithGroup)
            {
                stringBuilder.Append($"\n\tData rozpoczęcia:");
                stringBuilder.AppendLine($"\t{trip.StartTime.ToString("dd-MM-yyyy hh:mm:ss")}");

                stringBuilder.Append($"\tData zakończenia:");
                stringBuilder.AppendLine($"\t{trip.EndTime.ToString("dd-MM-yyyy hh:mm:ss")}");

                string output = trip.Duration.ToString(@"dd\ \d\n\i\ hh\:mm\:ss");
                stringBuilder.Append($"\tCzas trwania:\t\t");
                stringBuilder.AppendLine(output);

                stringBuilder.Append($"\tIlość kilometrów:");
                stringBuilder.AppendLine($"\t{trip.Kilometers} km.\n");
            }

            return stringBuilder.ToString();
        }
    }
}