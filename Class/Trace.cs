using System;

public class Trace
{
    public decimal Kilometers { get; }
    public DateTime date;
    public string Note { get; }

    public Trace(decimal kilometers, string note)
    {
        this.Kilometers = kilometers;
        this.Note = note;
        date = DateTime.Now;
    }
}