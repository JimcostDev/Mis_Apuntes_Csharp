

Doctor doctor = new Doctor("Tania Jimenez", 30, "Cirujana");
Console.WriteLine(doctor.GetData());
Console.WriteLine(doctor.GetInfo());

Dev dev = new Dev("Ronaldo Jimenez", 22, "Python");
Console.WriteLine(dev.GetData());
Console.WriteLine(dev.GetInfo());

class People
{
    //atributos
    private string _name;
    private int _age;

    //propiedades
    public string Name { get { return _name; } }
    public int Age { get { return _age;} }

    public People(string name, int age)
    {
        _name = name;
        _age = age;
    }

    public string GetInfo()
    {
        return _name + " " + _age;
    }


}

class Doctor : People
{
    private string _speciality;
    public Doctor(string name, int age, string speciality) : base(name, age) //base, lo utilizamos para devolverle los atributos a la clase padre
    {
        _speciality = speciality;
    }

    public string GetData()
    {
        return GetInfo() + " " + _speciality;
    }
}

class Dev : People
{
    private string _language;
    public Dev(string name, int age, string language) : base(name, age) //base, lo utilizamos para devolverle los atributos a la clase padre
    {
        _language = language;
    }

    public string GetData()
    {
        return GetInfo() + " " + _language;
    }
}
