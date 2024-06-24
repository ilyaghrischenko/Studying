using System;
using static System.Console;

public class BusStop
{
    public int Capacity { get; set; }
    public int PassengersCount { get; set; }

    public BusStop(int capacity)
    {
        Capacity = capacity;
    }

    public void AddPassengers(int count)
    {
        lock (this)
        {
            PassengersCount += count;
            WriteLine($"Added {count} passengers. Total passengers: {PassengersCount}");
        }
    }

    public int RemovePassengers(int count)
    {
        lock (this)
        {
            int removedPassengers = Math.Min(count, PassengersCount);
            PassengersCount -= removedPassengers;
            WriteLine($"Removed {removedPassengers} passengers. Total passengers: {PassengersCount}");
            return removedPassengers;
        }
    }

    public bool HasPassengers()
    {
        lock (this)
        {
            return PassengersCount > 0;
        }
    }

    public int GetPassengerCount()
    {
        lock (this)
        {
            return PassengersCount;
        }
    }
}
