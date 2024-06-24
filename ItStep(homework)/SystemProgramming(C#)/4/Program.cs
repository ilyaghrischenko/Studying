using static System.Console;

#region task 1
//using (Semaphore semaphore = new Semaphore(3, 3, "MyApplicationName"))
//{
//    try
//    {
//        if (!semaphore.WaitOne(TimeSpan.Zero, true))
//        {
//            WriteLine("Three copies are working. Closing...");
//            ReadKey();
//            return;
//        }

//        WriteLine("Application opened.");
//        ReadLine();

//        semaphore.Release();
//    }
//    catch (Exception ex)
//    {
//        WriteLine(ex.Message);
//    }
//}
#endregion

#region task 2
//string file1 = "file1.txt";
//string file2 = "file2.txt";
//string file3 = "file3.txt";
//string reportFile = "report.txt";

//using (Mutex mutex = new())
//{
//    try
//    {
//        Thread thread1 = new Thread(() =>
//        {
//            var random = new Random();
//            var numbers = Enumerable.Range(0, 100).Select(_ => random.Next(100));

//            File.WriteAllLines(file1, numbers.Select(n => n.ToString()));
//        });

//        Thread thread2 = new Thread(() =>
//        {
//            thread1.Join();

//            var numbers = File.ReadAllLines(file1).Select(int.Parse);
//            var primes = numbers.Where(IsPrime);

//            File.WriteAllLines(file2, primes.Select(n => n.ToString()));
//        });

//        Thread thread3 = new Thread(() =>
//        {
//            thread2.Join();

//            var numbers = File.ReadAllLines(file2).Select(int.Parse);
//            var primesEndingIn7 = numbers.Where(n => n % 10 == 7);

//            File.WriteAllLines(file3, primesEndingIn7.Select(n => n.ToString()));
//        });

//        Thread thread4 = new Thread(() =>
//        {
//            thread3.Join();

//            File.WriteAllText(reportFile, $"File {file1}:\n" +
//            $"Number of numbers: {File.ReadAllLines(file1).Length}\n" +
//            $"Size: {new FileInfo(file1).Length} bytes\n" +
//            $"Content: {File.ReadAllText(file1)}\n\n" +
//            $"File {file2}:\n" +
//            $"Number of numbers: {File.ReadAllLines(file2).Length}\n" +
//            $"Size: {new FileInfo(file2).Length} bytes\n" +
//            $"Content: {File.ReadAllText(file2)}\n\n" +
//            $"File {file3}:\n" +
//            $"Number of numbers: {File.ReadAllLines(file3).Length}\n" +
//            $"Size: {new FileInfo(file3).Length} bytes\n" +
//            $"Content: {File.ReadAllText(file3)}");
//        });

//        thread1.Start();
//        thread2.Start();
//        thread3.Start();
//        thread4.Start();

//        thread4.Join();
//    }
//    catch (Exception ex)
//    {
//        WriteLine(ex.Message);
//    }
//}

//static bool IsPrime(int number)
//{
//    if (number < 2) return false;

//    for (int i = 2; i * i <= number; i++)
//    {
//        if (number % i == 0) return false;
//    }

//    return true;
//}
#endregion