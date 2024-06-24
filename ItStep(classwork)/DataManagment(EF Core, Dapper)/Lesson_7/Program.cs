using Dapper;
using System.Data.SqlClient;
using DB.Models;
using static System.Console;

string connectionString = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=FootballChampionship;Integrated Security=SSPI;";
using (SqlConnection connection = new(connectionString))
{
    try
    {
        #region task 1
        Write("Team name: ");
        var teamName = ReadLine();
        var findedTeam = connection.QueryFirst<Team>($"select * from Teams where Name = '{teamName}';");
        WriteLine($"Team: {findedTeam}");
        ReadKey();
        WriteLine();

        Write("City name: ");
        var cityName = ReadLine();
        var teams = connection.Query<string>($"select Teams.Name from Teams, Cities where Teams.CityId = Cities.Id and Cities.Name = '{cityName}';").ToList();
        WriteLine("Teams:");
        teams.ForEach(WriteLine);
        ReadKey();
        WriteLine();

        Write("Team name: ");
        teamName = ReadLine();
        Write("City name: ");
        cityName = ReadLine();
        var team = connection.QueryFirst<string>($"select Teams.Name from Teams, Cities where Teams.Name = '{teamName}' and Teams.CityId = Cities.Id and Cities.Name = '{cityName}';");
        WriteLine($"Team: {team}");
        ReadKey();
        WriteLine();
        #endregion

        #region task 2
        var teamF = connection.QueryFirst<Team>("select * from Teams where WinCount = (select max(WinCount) from Teams);");
        WriteLine($"Team: {teamF}");
        ReadKey();
        WriteLine();

        teamF = connection.QueryFirst<Team>("select * from Teams where DrawCount = (select max(DrawCount) from Teams);");
        WriteLine($"Team: {teamF}");
        ReadKey();
        WriteLine();

        teamF = connection.QueryFirst<Team>("select * from Teams where GoalsCount = (select max(GoalsCount) from Teams);");
        WriteLine($"Team: {team}");
        ReadKey();
        WriteLine();

        teamF = connection.QueryFirst<Team>("select * from Teams where GoalsConcededCount = (select max(GoalsConcededCount) from Teams);");
        WriteLine($"Team: {team}");
        ReadKey();
        WriteLine();
        #endregion

        #region task 3
        Write("Name: ");
        var name = ReadLine();
        Write("City id: ");
        var cityId = int.Parse(ReadLine());
        Write("Win count: ");
        var winCount = int.Parse(ReadLine());
        Write("Draw count: ");
        var drawCount = int.Parse(ReadLine());
        Write("Goals count: ");
        var goalsCount = int.Parse(ReadLine());
        Write("Goals conceded count: ");
        var goalsConcededCount = int.Parse(ReadLine());

        Team newTeam = new() { Name = name, CityId = cityId, WinCount = winCount, DrawCount = drawCount, GoalsCount = goalsCount, GoalsConcededCount = goalsConcededCount };
        var teamS = connection.Query<Team>("select * from Teams").ToList();
        if (teamS.FirstOrDefault(x => x.Equals(newTeam)) != null) throw new Exception("This team already exist");
        connection.Execute($"insert into Teams (Name,CityId,WinCount,DrawCount,GoalsCount,GoalsConcededCount) values ('{name}',{cityId},{winCount},{drawCount},{goalsCount},{goalsConcededCount});");
        WriteLine("New team added");
        ReadKey();
        WriteLine();

        Write("Enter team id: ");
        var teamId = int.Parse(ReadLine());
        var finTeam = connection.QueryFirst<Team>($"select * from Teams where Id = {teamId};");

        Write($"Enter new name for team ({finTeam.Name}): ");
        var newName = ReadLine();
        connection.Execute($"update Teams set Name = '{newName}' where Id = {finTeam.Id};");
        WriteLine("Team name changed");
        WriteLine($"New team data:\n{connection.QueryFirst<Team>($"select * from Teams where Id = {finTeam.Id}")}");
        ReadKey();
        WriteLine();

        Write("Team id: ");
        var id = int.Parse(ReadLine());
        var FindedTeam = connection.QueryFirst<Team>($"select * from Teams where Id = {id}");
        Write("Team found\nWant to remove? Y/N\n: ");
        var choice = ReadKey().Key;
        if (choice == ConsoleKey.Y)
        {
            connection.Execute($"delete from Teams where Id = {id}");
            WriteLine("\nDeleted");
        }
        #endregion
    }
    catch (Exception ex)
    {
        WriteLine(ex.Message);
    }
}