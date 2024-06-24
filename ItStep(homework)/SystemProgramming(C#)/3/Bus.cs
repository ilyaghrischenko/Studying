// File: Bus.cs
using System;
using System.Threading;

public class Bus
{
    public BusStop BusStop { get; set; }
    public int Capacity { get; set; }
    public int Passengers { get; set; }

    public Bus(BusStop busStop, int capacity)
    {
        BusStop = busStop;
        Capacity = capacity;
    }

    public void Run()
    {
        while (true)
        {
            if (BusStop.HasPassengers())
            {
                int passengersToPickup = BusStop.RemovePassengers(Capacity - Passengers);
                Passengers += passengersToPickup;
                Console.WriteLine($"Bus picked up {passengersToPickup} passengers. Total passengers in bus: {Passengers}");

                if (Passengers == Capacity)
                {
                    Passengers = 0;
                    Console.WriteLine($"Bus full. Departing from the bus stop.");
                }
            }
            else
            {
                Console.WriteLine("Bus stop is empty. Waiting...");
            }
            Thread.Sleep(3000);
        }
    }
}
