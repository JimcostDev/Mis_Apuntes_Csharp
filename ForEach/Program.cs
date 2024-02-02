// todo lo que herede de Ienumerable puede usar foreach 
var numbers = new List<int>()
{
    1,2,3, 4,5, 6, 7,
};


foreach (var number in numbers)
{
    Console.WriteLine(number);
}

var students = new List<People>()
{
    new People(){Name = "Ronaldo", Country = "Colombia"},
    new People(){Name = "Charlie", Country = "Mexico"},
    new People(){Name = "Pau", Country = "Argentina"}
};


// ejecutar metodo
Show(students);
//elimina elemento de la lista
students.RemoveAt(0);
Show(students);

static void Show(List<People> students)
{
    Console.WriteLine(" -- PERSONAS: --");
    foreach (var people in students)
    {
        Console.WriteLine($"Nombre: {people.Name}, País: {people.Country}");
    }
}
class People
{
    public string Name { get; set; }
    public string Country { get; set; }
}