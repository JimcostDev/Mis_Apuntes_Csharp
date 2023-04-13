public record Persona
{
    public string Nombre { get; }
    public string Apellido { get; }

    public Persona(string nom, string ape) => (Nombre, Apellido) = (nom, ape);

    
}
//var persona = new Persona("Jack", "Doe");
//persona.Nombre = "Rick";