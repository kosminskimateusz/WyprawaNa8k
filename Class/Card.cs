using System;
using System.Collections.Generic;

public class Card
{
    private static int cardNumberSeed = 1234567890;
    public string Number { get; }
    public string Owner { get; }
    public List<Trace> allTraces = new List<Trace>();
    public decimal Distance
    {
        get
        {
            decimal distance = 0;
            foreach (var item in allTraces)
            {
                distance += item.Kilometers;
            }

            return distance;
        }
    }
    public Card(string owner)
    {
        this.Owner = owner;
        this.Number = cardNumberSeed.ToString();
        cardNumberSeed++;
    }

    public void RegisterNewTrace(decimal kilometers, string note)
    {
        var trace = new Trace(kilometers, note);
        allTraces.Add(trace);
        Console.WriteLine($"Dodano: {trace.Kilometers}km. \nData: {trace.date.Day}.{trace.date.Month}.{trace.date.Year}. \nNotatka: {trace.Note}");
    }
}