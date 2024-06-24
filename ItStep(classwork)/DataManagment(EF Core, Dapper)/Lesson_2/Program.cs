using static System.Console;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.EntityFrameworkCore.SqlServer;

namespace Lesson_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Lab
            /*
            try
            {
                CountriesContext db = new();

                //task 2
                WriteLine("\n1.");
                db.Countries
                    .Select(country => new
                    {
                        country.Name,
                        Capital = country.Cities.SingleOrDefault(city => city.IsCapital).Name,
                        country.Area,
                        country.WorldPart,
                        InhabitansCount = country.Cities.Sum(city => city.InhabitansCount)
                    })
                      .ToList()
                      .ForEach(WriteLine);
                ReadKey();

                WriteLine("\n2.");
                db.Cities
                       .Where(x => x.IsCapital)
                       .Select(x => x.Name)
                       .ToList()
                       .ForEach(WriteLine);
                ReadKey();

                WriteLine("\n3.");
                db.Countries
                        .Where(x => x.WorldPart == "Europe")
                        .Select(x => x.Name)
                        .ToList()
                        .ForEach(WriteLine);
                ReadKey();

                WriteLine("\n4.");
                db.Countries
                      .Where(x => x.Name.Contains("a") && x.Name.Contains("u"))
                      .Select(x => x.Name)
                      .ToList()
                      .ForEach(WriteLine);
                ReadKey();

                WriteLine("\n5.");
                db.Countries
                    .Select(country => new
                    {
                        country.Name,
                        Cities = country.Cities.Where(city => city.InhabitansCount>1000).Select(x=>x.Name).ToList(),
                        country.Area,
                        country.WorldPart,
                        InhabitansCount = country.Cities.Sum(city => city.InhabitansCount)
                    })
                      .ToList()
                      .ForEach(WriteLine);
                ReadKey();
            }
            catch (Exception ex)
            {
                WriteLine(ex.Message);
            }
            */

            //HW
            using (CountriesContext db = new())
            {
                try
                {
                    //task 1
                    /*
                    WriteLine("\n1.");
                    db.Countries
                        .Select(country => new
                        {
                            country.Name,
                            Capital = country.Cities.SingleOrDefault(city => city.IsCapital).Name,
                            country.Area,
                            country.WorldPart,
                            InhabitansCount = country.Cities.Sum(city => city.InhabitansCount)
                        })
                          .OrderBy(country => country.InhabitansCount)
                          .ToList()
                          .ForEach(WriteLine);
                    ReadKey();

                    WriteLine("\n2.");
                    var countryWithMaxInhabitants = db.Countries
                        .OrderByDescending(country => country.Cities.Sum(city => city.InhabitansCount))
                        .Select(country => new
                        {
                            country.Name,
                            InhabitansCount = country.Cities.Sum(city => city.InhabitansCount)
                        })
                        .FirstOrDefault();
                    WriteLine(countryWithMaxInhabitants);
                    ReadKey();

                    WriteLine("\n3.");
                    var country = db.Countries
                                       .Where(x => x.WorldPart == "Europe")
                                       .OrderByDescending(x => x.Area)
                                       .FirstOrDefault();
                    WriteLine(country);
                    ReadKey();

                    WriteLine("\n4.");
                    WriteLine(db.Countries.Count() + " countries");
                    ReadKey();

                    WriteLine("\n5.");
                    var maxCountrieWorldPart = db.Countries
                        .GroupBy(country => country.WorldPart)
                        .Select(group => new
                        {
                            WorldPart = group.Key,
                            CountryCount = group.Count()
                        })
                        .OrderByDescending(x => x.CountryCount)
                        .FirstOrDefault();
                    WriteLine(maxCountrieWorldPart);
                    ReadKey();

                    WriteLine("\n6.");
                    var listWorldPart = db.Countries
                        .GroupBy(country => country.WorldPart)
                        .Select(group => new
                        {
                            WorldPart = group.Key,
                            CountryCount = group.Count()
                        })
                        .ToList();
                    listWorldPart.ForEach(WriteLine);
                    ReadKey();

                    WriteLine("\n7.");
                    var inhabitantsWorldPart = db.Countries
                            .GroupBy(country => country.WorldPart)
                            .Select(group => new
                            {
                                WorldPart = group.Key,
                                TotalInhabitants = group.SelectMany(country => country.Cities).Sum(city => city.InhabitansCount)
                            })
                            .ToList();
                    inhabitantsWorldPart
                            .ForEach(WriteLine);
                    ReadKey();
                    */

                    //task 2
                    /*
                    Write("1. Add country\n2. Add city\n3. Del country\n4. Del city: ");
                    int choice = int.Parse(ReadLine());
                    switch (choice)
                    {
                        case 1:
                            Write("Name: ");
                            string name = ReadLine();
                            Write("Area: ");
                            double area = double.Parse(ReadLine());
                            Write("World part: ");
                            string worldPart = ReadLine();

                            db.Countries.Add(new Country { Name = name, Area = area, WorldPart = worldPart });
                            WriteLine("Added!");
                            db.SaveChanges();
                            break;
                        case 2:
                            Write("Name: ");
                            name = ReadLine();
                            Write("Is capital?: ");
                            bool isCapital = bool.Parse(ReadLine());
                            Write("Inhabitants count: ");
                            int inhCount = int.Parse(ReadLine());
                            Write("Country id: ");
                            int cntId = int.Parse(ReadLine());

                            if (db.Countries.SingleOrDefault(x => x.Id == cntId) != null) throw new Exception("Country with this id does not exist");
                            db.Cities.Add(new() { Name = name, IsCapital = isCapital, InhabitansCount = inhCount, Country = db.Countries.Single(x => x.Id == cntId), CountryId = cntId });
                            db.SaveChanges();
                            break;
                        case 3:
                            Write("Country id: ");
                            cntId = int.Parse(ReadLine());
                            var country = db.Countries.SingleOrDefault(x => x.Id == cntId) ?? throw new Exception("Country with this id does not exist");
                            db.Countries.Remove(country);
                            db.SaveChanges();
                            break;
                        case 4:
                            Write("City id: ");
                            var cityId= int.Parse(ReadLine());
                            var city = db.Cities.SingleOrDefault(x => x.Id == cityId) ?? throw new Exception("City with this id does not exist");
                            db.Cities.Remove(city);
                            db.SaveChanges();
                            break;
                        default:
                            throw new Exception("Invalid choice");
                    }
                    */
                }
                catch (Exception ex)
                {
                    WriteLine(ex.Message);
                }
            }
        }
    }
}
