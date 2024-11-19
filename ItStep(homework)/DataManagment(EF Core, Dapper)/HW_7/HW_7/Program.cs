using Dapper;
using DB;

//task 1
var _dbConnection = new DatabaseConnection("Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=HW_7;Integrated Security=True");
IEnumerable<dynamic> task1 = null;
using (var connection = _dbConnection.GetConnection())
{
    var query = @"
            SELECT Team1 AS Team, SUM(GoalsTeam1 - GoalsTeam2) AS GoalDifference
            FROM Matches
            GROUP BY Team1
            UNION
            SELECT Team2 AS Team, SUM(GoalsTeam2 - GoalsTeam1) AS GoalDifference
            FROM Matches
            GROUP BY Team2";
    task1 = await connection.QueryAsync(query);
}

Console.WriteLine("Task 1: ", task1);