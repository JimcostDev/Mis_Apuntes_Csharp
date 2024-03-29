﻿using BaseDeDatos;
using System.Data.SqlClient;

try
{
    TeamDB teamDB = new TeamDB(@".\LOCAL", "Test", "jimcostdev", "123456");
    bool again = true;
    int op = 0;

    do
    {
        ShowMenu();
        Console.WriteLine("Elige una opción: ");
        op = int.Parse(Console.ReadLine());

        switch (op)
        {
            case 1:
                Show(teamDB);
                break;
            case 2:
                Add(teamDB);
                break;
            case 3:
                Edit(teamDB);
                break;
            case 4:
                Delete(teamDB);
                break;
            case 5:
                again = false;
                break;
        }
    } while (again);

}
catch (SqlException)
{
    Console.WriteLine($"No pudimos conectarnos");
}
static void ShowMenu()
{
    Console.WriteLine("\n----------Menu----------");
    Console.WriteLine("1.- Mostrar");
    Console.WriteLine("2.- Agregar");
    Console.WriteLine("3.- Editar");
    Console.WriteLine("4.- Eliminar");
    Console.WriteLine("5.- Salir");
}

static void Show(TeamDB teamDB)
{
    Console.Clear();
    Console.WriteLine("Equipos de la base de datos");
    List<Team> teams = teamDB.GetAll();
    foreach (var team in teams)
    {
        Console.WriteLine($" ID: {team.ID} Nombre: {team.Name}");
    }
}
static void Add(TeamDB teamDB)
{
    Console.Clear();
    Console.WriteLine("Agregar nuevo equipo");
    Console.WriteLine("Escribe el nombre:");
    string name = Console.ReadLine();
    Console.WriteLine("Escribe el id de la liga:");
    int leagueID = int.Parse(Console.ReadLine());
    Team team = new Team(name, leagueID);
    teamDB.Add(team);
}
static void Edit(TeamDB teamDB)
{
    Console.Clear();
    Show(teamDB);
    Console.WriteLine("Editar Equipo");
    Console.WriteLine("Escribe el id de tu equipo a editar: ");
    int id = int.Parse(Console.ReadLine());

    Team team = teamDB.Get(id);
    if (team != null)
    {
        Console.WriteLine("Escribe el nombre: ");
        string name = Console.ReadLine();
        Console.WriteLine("Escribe el id de la liga:");
        int leagueID = int.Parse(Console.ReadLine());

        team.Name = name;
        team.LeagueID = leagueID;
        teamDB.Edit(team);
    }
    else
    {
        Console.WriteLine("El equipo no existe");
    }
}
static void Delete(TeamDB teamDB)
{
    Console.Clear();
    Show(teamDB);
    Console.WriteLine("Eliminar Equipo");
    Console.WriteLine("Escribe el id de tu equipo a eliminar: ");
    int id = int.Parse(Console.ReadLine());

    Team team = teamDB.Get(id);
    if (team != null)
    {
        teamDB.Delete(id);
    }
    else
    {
        Console.WriteLine("El equipo no existe");
    }
}
