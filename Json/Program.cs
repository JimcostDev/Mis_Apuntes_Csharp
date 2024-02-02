using System.Text.Json;


Teams[] teams = new Teams[] {
    new Teams()
    {
        Name =  "Liverpool",
        Country = "Inglaterra"
    },
    new Teams()
    {
        Name =  "Arsenal",
        Country = "Inglaterra"
    }
};

// convertir en formato json
string json = JsonSerializer.Serialize(teams);
Console.WriteLine(json);

// proceso inverso - deserializar
Teams[] equipos = JsonSerializer.Deserialize<Teams[]>(json);

public class Teams
{
    public string Name { get; set; }
    public string Country { get; set; }
}
