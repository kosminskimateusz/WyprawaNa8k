using System;

namespace WyprawaNa8k
{
    class Program
    {
        static void Main(string[] args)
        {
            // Person person = new Person();
            // Person.SayHello();

            var card = new MemberCard("Mateusz", "Chodziki");
            Console.WriteLine($"Card {card.Number} was created for {card.Owner}.\n");

            card.RegisterNewTrace(13, "Świetna trasa po Caryńskiej.");
            card.RegisterNewTrace(22, "Piękne połoniny");
            card.RegisterNewTrace(16, "Wyprawa wzdłuż rzeki");
            card.RegisterNewTrace(31, "Zdobyty najwyższy szczyt");

            // Console.WriteLine("Zwykły string:\n\n" + card.GetAccountHistory());
            // Console.WriteLine("StringBuilder:\n\n" + card.GetAccountHistoryWithStringBuilder());

            var card1 = new MemberCard("Michał", "Chodziki");
            // Console.WriteLine($"Card {card1.Number} was created for {card1.Owner}.");

            var cardSherpa = new SherpaCard("Mateusz", "kosmen");
            var cardSherpa1 = new SherpaCard("Kamil", "kamien");
            GuideMember guideWojtek = new GuideMember("Wojciech Okejka", "okejGuide");

            int kilometers;

            DateTime startData = new DateTime(DateTime.Now.Year, DateTime.Now.Month, 13, 11, 23, 00);
            DateTime endData = DateTime.Now;
            kilometers = 32;
            cardSherpa.RegisterNewTripWithGroup(startData, endData, kilometers);
            cardSherpa1.RegisterNewTripWithGroup(startData, endData, kilometers);
            

            guideWojtek.RegisterNewTripWithMembers(0,cardSherpa);
            guideWojtek.RegisterNewTripWithMembers(0,cardSherpa1);

            
            startData = new DateTime(DateTime.Now.Year, DateTime.Now.Month, 10, 14, 32, 00);
            endData = DateTime.Now;
            kilometers = 18;
            cardSherpa.RegisterNewTripWithGroup(startData, endData, kilometers);
            
            guideWojtek.RegisterNewTripWithMembers(1, cardSherpa);

            startData = new DateTime(DateTime.Now.Year, DateTime.Now.Month, 6, 8, 23, 00);
            endData = DateTime.Now;
            kilometers = 114;
            cardSherpa.RegisterNewTripWithGroup(startData, endData, kilometers);
            
            guideWojtek.RegisterNewTripWithMembers(2, cardSherpa);

            // guideWojtek.ShowTripMembers(1);
            // Console.WriteLine(cardSherpa.ShowTrips());
        }
    }
}
