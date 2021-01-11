using System;

namespace WyprawaNa8k
{
    class Program
    {
        static void Main(string[] args)
        {
            // Person person = new Person();
            // Person.SayHello();

            var card = new Card("Mateusz");
            Console.WriteLine($"Card {card.Number} was created for {card.Owner}.\n");

            card.RegisterNewTrace(13, "Świetna trasa po Caryńskiej.");
            card.RegisterNewTrace(22, "Piękne połoniny");
            card.RegisterNewTrace(16, "Wyprawa wzdłuż rzeki");
            card.RegisterNewTrace(31, "Zdobyty najwyższy szczyt");

            Console.WriteLine("Zwykły string:\n\n" + card.GetAccountHistory());
            Console.WriteLine("StringBuilder:\n\n" + card.GetAccountHistoryWithStringBuilder());

            var card1 = new Card("Michał");
            Console.WriteLine($"Card {card1.Number} was created for {card1.Owner}.");

            var cardSherpa = new SherpaCard("Mateusz", "kosmen");

            DateTime startData = new DateTime(DateTime.Now.Year, DateTime.Now.Month, 13, 11, 23, 00);
            DateTime endData = DateTime.Now;
            int kilometers = 32;

            cardSherpa.RegisterNewTripWithGroup(startData, endData, kilometers);

            
            startData = new DateTime(DateTime.Now.Year, DateTime.Now.Month, 10, 14, 32, 00);
            endData = DateTime.Now;
            kilometers = 18;

            cardSherpa.RegisterNewTripWithGroup(startData, endData, kilometers);

            
            startData = new DateTime(DateTime.Now.Year, DateTime.Now.Month, 6, 8, 23, 00);
            endData = DateTime.Now;
            kilometers = 25;

            cardSherpa.RegisterNewTripWithGroup(startData, endData, kilometers);

            Console.WriteLine(cardSherpa.ShowTrips());

            System.Console.WriteLine(DateTime.Now.Day);
        }

        static void Strings()
        {
            string name = "Mat";
            Console.WriteLine("Hello " + name);
            Console.WriteLine($"Cześć {name.PadLeft(15)}, ilość znaków: {name.Length}");
            string hello = "Witaj Ziom";
            Console.WriteLine(hello);
            hello = hello.Replace("Witaj", "Czołem");
            Console.WriteLine(hello);
            Console.WriteLine(hello.Contains("Ziom"));
            Console.WriteLine(hello.Contains("ziom"));
            string text = "Hej ekipa z kursu 8k.";
            Console.WriteLine(text.EndsWith("8k."));
        }

        static void TestLimits()
        {
            int max = int.MaxValue;
            int min = int.MinValue;

            Console.WriteLine($"Range of integer is from {min} to {max}.");

            max += 3;
            Console.WriteLine($"Overflow example: {max}");
        }

        static void WorkWithDoubles()
        {
            double dMin = double.MinValue;
            double dMax = double.MaxValue;

            Console.WriteLine($"Range of double is from {dMin} to {dMax}.");

            double a = 1;
            double b = 3;

            Console.WriteLine(a / b);
        }

        static void WorkWithDecimals()
        {
            decimal a = 1.0M;
            decimal b = 3.0M;

            Console.WriteLine(a / b);
        }
    }
}
