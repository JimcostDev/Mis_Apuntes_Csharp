using BaseDeDatos;
using System.Data.SqlClient;

try
{
    TeamDB teamDB = new TeamDB(@".\LOCAL", "Test", "jimcostdev", "123456");
    List<Team> teams = teamDB.GetAll();
    foreach (var team in teams)
    {
        Console.WriteLine(team.Name);
    }
}
catch (SqlException ex)
{
    Console.WriteLine($"No pudimos conectarnos: {ex}");
}

