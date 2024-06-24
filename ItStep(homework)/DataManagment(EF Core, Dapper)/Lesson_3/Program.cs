using Lesson_3;
using Lesson_3.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.EntityFrameworkCore.SqlServer;
using static System.Console;

using (DataBaseContext context = new())
{
    try
    {
        #region classwork
        //context.Games
        //          .Include("Genre")
        //          .Include("Studio")
        //          .ToList()
        //          .ForEach(WriteLine);
        #endregion

        #region hw
        //task 1
        /*
        Write("Game name: ");
        var gameName = ReadLine();
        var game = context.Games
                      .SingleOrDefault(x => x.Name == gameName)
                      ?? throw new Exception("Game with this name does not exist");
        WriteLine($"game: {game}");

        Write("Game studio: ");
        var gameStudio = ReadLine();
        var games = context.Games
                      .Where(x => x.Studio.Name == gameStudio)
                      .ToList()
                      ?? throw new Exception("Games with this studio name does not exist");
        WriteLine("Games:");
        games.ForEach(WriteLine);

        Write("Game name: ");
        gameName = ReadLine();
        Write("Studio name: ");
        gameStudio = ReadLine();
        games = context.Games
                      .Where(x => x.Name == gameName && x.Studio.Name == gameStudio)
                      .ToList()
                      ?? throw new Exception("Games with this name and studio name does not exist");
        WriteLine("Games:");
        games.ForEach(WriteLine);

        Write("Game genre: ");
        var gameGenre = ReadLine();
        games = context.Games.Where(x => x.Genre.Name == gameGenre).ToList() ?? throw new Exception("Game with this genre name does not exist");
        WriteLine("Games:");
        games.ForEach(WriteLine);

        Write("Game release year: ");
        var releaseYear = int.Parse(ReadLine());
        games = context.Games.Where(x => x.ReleaseDate.Year == releaseYear).ToList() ?? throw new Exception("Game with this release year does not exist");
        WriteLine("Games:");
        games.ForEach(WriteLine);
        */

        //task 2
        /*
        WriteLine("Single player games:");
        var games = context.Games.Where(x => x.Mode == GameMode.SingleUser).ToList() ?? throw new Exception("Games with single player mode does not exist");
        games.ForEach(WriteLine);

        WriteLine("Multi player games:");
        games = context.Games.Where(x => x.Mode == GameMode.MultiUser).ToList() ?? throw new Exception("Games with multi player mode does not exist");
        games.ForEach(WriteLine);

        Write($"Game with max count sold: {context.Games.Max(x => x.CountSold)}");

        WriteLine("3 most unpopular games:");
        context.Games
                  .OrderByDescending(x => x.CountSold)
                  .Take(3)
                  .ToList()
                  .ForEach(WriteLine);
        */

        //task 3
        /*
        Write("Name: ");
        var name = ReadLine();

        Write("Studio name: ");
        var studioName = ReadLine();
        Write("Studio founding date: ");
        var studioDate = DateOnly.Parse(ReadLine());
        Studio studio = new() { Name = studioName, FoundingDate = studioDate };

        Write("Genre: ");
        Genre genre = new() { Name = ReadLine() };

        Write("Release date: ");
        var date = DateOnly.Parse(ReadLine());
        Write("Game mode: ");
        var mode = (GameMode)Enum.Parse(typeof(GameMode), ReadLine());
        Write("Count sold: ");
        var countCold = uint.Parse(ReadLine());

        Game game = new() { Name = name, Studio = studio, Genre = genre, ReleaseDate = date, Mode = mode, CountSold = countCold };
        if (context.Games.SingleOrDefault(x => x == game) != null) throw new Exception("This game already exist");
        WriteLine($"Game: {game}");
        context.SaveChanges();

        Write("Game id: ");
        var gameId = int.Parse(ReadLine());
        game = context.Games.SingleOrDefault(x => x.Id == gameId) ?? throw new Exception("Game with this id does not exist");
        Write("1 - Change name\n2 - Change studio\n3 - Change genre\n4 - Change release date\n5 - Change mode\n6 - Change count sold\n: ");
        switch (ReadLine())
        {
            case "1":
                Write("New name: ");
                game.Name = ReadLine();
                break;
            case "2":
                WriteLine("New studio:");
                Write("Name: ");
                studioName = ReadLine();
                Write("Founding date: ");
                studioDate = DateOnly.Parse(ReadLine());
                game.Studio = new() { Name = studioName, FoundingDate = studioDate };
                break;
            case "3":
                Write("New genre: ");
                game.Genre = new() { Name = ReadLine() };
                break;
            case "4":
                Write("New release date: ");
                game.ReleaseDate = DateOnly.Parse(ReadLine());
                break;
            case "5":
                Write("New mode: ");
                game.Mode = (GameMode)Enum.Parse(typeof(GameMode), ReadLine());
                break;
            case "6":
                Write("New count sold: ");
                game.CountSold = uint.Parse(ReadLine());
                break;
        }

        Write("Game id: ");
        gameId = int.Parse(ReadLine());
        game = context.Games.SingleOrDefault(x => x.Id == gameId) ?? throw new Exception("Game with this id does not exist");
        Write("Game found\nWant to remove? Y/N\n: ");
        if (ReadKey().Key == ConsoleKey.Y) context.Games.Remove(game);
        WriteLine("Bye");
        */
        #endregion
    }
    catch (Exception ex)
    {
        WriteLine(ex.Message);
    }
}