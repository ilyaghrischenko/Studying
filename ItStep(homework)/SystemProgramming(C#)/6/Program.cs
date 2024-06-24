using System.Text.Json;
using static System.Console;

#region task 1
//File.WriteAllText("task1.json", "35");
//var uniqueCount = await CountUniqueValuesAsync("task1.json");
//WriteLine($"Count: {uniqueCount}");

//async Task<int> CountUniqueValuesAsync(string filePath)
//{
//    var numbers = (await File.ReadAllTextAsync(filePath)).ToList();
//    return numbers
//              .AsParallel()
//              .Distinct()
//              .Count();
//}
#endregion

#region task 2
//Random random = new();
//List<int> list = new();
//for (int i = 0; i < 15; ++i) { list.Add(random.Next(1, 9)); }
//await File.WriteAllTextAsync("task2.json", JsonSerializer.Serialize(list));

//WriteLine("List:");
//list.ForEach(x => Write($"{x} "));
//WriteLine();

//WriteLine($"Max increasing sequence: {await MaxIncreasingSequenceLengthAsync("task2.json")}");

//async Task<int> MaxIncreasingSequenceLengthAsync(string filePath)
//{
//    var numbers = await JsonSerializer.DeserializeAsync<List<int>>(File.OpenRead(filePath));
//    return numbers
//              .AsParallel()
//              .Select((n, i) => numbers.Skip(i).TakeWhile((m, index) => index == 0 || numbers[i + index - 1] < numbers[i + index]).Count())
//              .Max();
//}
#endregion

#region task 3
//Random random = new();
//List<int> list = new();
//for (int i = 0; i < 15; ++i) { list.Add(random.Next(-10, 10)); }
//await File.WriteAllTextAsync("task3.json", JsonSerializer.Serialize(list));

//WriteLine("List:");
//list.ForEach(x => Write($"{x} "));
//WriteLine();

//WriteLine($"Max positive sequence: {await MaxPositiveSequenceLengthAsync("task3.json")}");

//async Task<int> MaxPositiveSequenceLengthAsync(string filePath)
//{
//    var numbers = await JsonSerializer.DeserializeAsync<List<int>>(File.OpenRead(filePath));
//    return numbers
//              .AsParallel()
//              .Select((n, i) => numbers.Skip(i).TakeWhile(m => m > 0).Count())
//              .Max();
//}
#endregion