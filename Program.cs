using System;

namespace WyprawaNa8k
{
    class Program
    { 
        static void Main(string[] args)
        {
            Person.SayHello();
            Person person = new Person();
            
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

            double a =1;
            double b = 3;

            Console.WriteLine(a/b);
        }

        static void WorkWithDecimals()
        {
            decimal a = 1.0M;
            decimal b = 3.0M;

            Console.WriteLine(a/b);
        }
    }
}
