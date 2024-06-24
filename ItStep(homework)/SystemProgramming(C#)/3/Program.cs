using _3;

BusStop busStop = new(20);
Bus bus = new(busStop, 10);

Thread busThread = new(bus.Run);
busThread.Start();

Random rnd = new();

while (true)
{
    int newPassengers = rnd.Next(1, 11);
    busStop.AddPassengers(newPassengers);
    Thread.Sleep(2000);
}
