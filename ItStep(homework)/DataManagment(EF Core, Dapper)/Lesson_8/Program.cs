using Dapper;
using Z.Dapper.Plus;
using Lesson_8.Models;
using static System.Console;
using System.Data.SqlClient;

string connectionString = "Data Source=(localdb)\\MSSQLLocalDB;" +
    "Initial Catalog=CityCountryContinent;" +
    "Integrated Security=True";
//DapperPlusManager.Entity<City>().Table("Cities");
//DapperPlusManager.Entity<Country>().Table("Countries");
//DapperPlusManager.Entity<Continent>().Table("Continents");

using (SqlConnection con = new(connectionString))
{
    try
    {
        #region task1
        //ShowAll();
        #endregion
        #region task2
        //List<Continent> continentsL = new();
        //for (int i = 0; i < 3; ++i)
        //{
        //    WriteLine($"{i + 1}.");

        //    Write("Name: ");
        //    var name = ReadLine();
        //    continentsL.Add(new(name));
        //}
        //con.BulkInsert(continentsL);
        //WriteLine();

        //List<Country> countriesL = new();
        //for (int i = 0; i < 3; ++i)
        //{
        //    WriteLine($"{i + 1}.");

        //    Write("Name: ");
        //    var name = ReadLine();

        //    Write("Continent name: ");
        //    var continentName = ReadLine();

        //    var continents = con.Query<Continent>("select * from Continents").ToList();
        //    var continentId = continents.FirstOrDefault(x => x.Name == continentName).Id;
        //    countriesL.Add(new(name, continentId));
        //}
        //con.BulkInsert(countriesL);
        //WriteLine();

        //List<City> cities = new();
        //for (int i = 0; i < 3; ++i)
        //{
        //    WriteLine($"{i + 1}.");

        //    Write("Name: ");
        //    var name = ReadLine();

        //    Write("Country name: ");
        //    var countryName = ReadLine();

        //    var countries = con.Query<Country>("select * from Countries").ToList();
        //    var countryId = countries.FirstOrDefault(x => x.Name == countryName).Id;
        //    cities.Add(new(name, countryId));
        //}
        //con.BulkInsert(cities);
        //WriteLine();
        #endregion
        #region task3
        //var citiesToUpdate = con.Query<City>("select * from Cities").ToList();
        //citiesToUpdate.ForEach(x => x.Name += " NEW");
        //con.BulkUpdate(citiesToUpdate);

        //var countriesToUpdate = con.Query<Country>("select * from Countries").ToList();
        //countriesToUpdate.ForEach(x => x.Name += " NEW");
        //con.BulkUpdate(countriesToUpdate);

        //var continentsToUpdate = con.Query<Continent>("select * from Continents").ToList();
        //continentsToUpdate.ForEach(x => x.Name += " NEW");
        //con.BulkUpdate(continentsToUpdate);

        ShowAll();
        #endregion
        #region task4
        //Write("Continent name: ");
        //var continentName = ReadLine();
        //var continent = con.Query<Continent>("select * from Continents").FirstOrDefault(x => x.Name == continentName);
        //CascadeContinent(continent);

        //Write("Country name: ");
        //var countryName = ReadLine();
        //var country = con.Query<Country>("select * from Countries").FirstOrDefault(x => x.Name == countryName);
        //CascadeCountry(country);

        //Write("City name:");
        //var cityName = ReadLine();
        //var city = con.Query<City>("select * from Cities").FirstOrDefault(x => x.Name == cityName);
        //con.BulkDelete(city);
        #endregion
    }
    catch (Exception ex)
    {
        WriteLine(ex.Message);
    }
}

void ShowAll()
{
    using (SqlConnection con = new(connectionString))
    {
        try
        {
            var cities = con.Query<City>("select * from Cities").ToList();
            var countries = con.Query<Country>("select * from Countries").ToList();
            var continents = con.Query<Continent>("select * from Continents").ToList();

            WriteLine("Cities:");
            cities.ForEach(WriteLine);
            WriteLine("Countries:");
            countries.ForEach(WriteLine);
            WriteLine("Continents:");
            continents.ForEach(WriteLine);
        }
        catch (Exception ex)
        {
            WriteLine(ex.Message);
        }
    }
}
void CascadeContinent(Continent continent)
{
    using (SqlConnection con = new(connectionString))
    {
        try
        {
            var countries = con.Query<Country>("select * from Countries").Where(x => x.ContinentId == continent.Id).ToList();
            if (countries != null)
            {
                countries.ForEach(CascadeCountry);
            }
            con.BulkDelete(continent);
        }
        catch (Exception ex)
        {
            WriteLine(ex.Message);
        }
    }
}
void CascadeCountry(Country country)
{
    using (SqlConnection con = new(connectionString))
    {
        try
        {
            var cities = con.Query<City>("select * from Cities").Where(x => x.CountryId == country.Id).ToList();
            if (cities != null)
            {
                cities.ForEach(x => con.BulkDelete(x));
            }
            con.BulkDelete(country);
        }
        catch (Exception ex)
        {
            WriteLine(ex.Message);
        }
    }
}