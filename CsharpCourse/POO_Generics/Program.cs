//Los Generics nos ayudan a reutlizar codigo

//lista de numeros
MyList<int> numbers = new MyList<int>(10);
numbers.Add(1);
numbers.Add(2);

//lista de string
MyList<String> teams = new MyList<String>(10);
teams.Add("Liverpool");
teams.Add("Arsenal");

//lista de personas
MyList<People> people = new MyList<People>(5);
people.Add(new People() { Name = "Ronaldo Jimenez", Age = 23 });
people.Add(new People() { Name = "Tania Jimenez", Age = 22 });

Console.WriteLine(numbers.GetElemets(11));
Console.WriteLine(teams.GetElemets(0));
Console.WriteLine(people.GetString());

//Esto es Generics <T>; es decir la T representa la posibilidad de que la clase reciba un tipo de dato
public class MyList<T> 
{
    private T[] _elements{ get; set; }
    private int _index = 0;

    public MyList(int n)
    {
        _elements = new T[n];
    }

    // metodo para agregar elementos
    public void Add(T e)
    {
        if (_index < _elements.Length)
        {
            _elements[_index] = e;
            _index++;
        }
    }

    // metodo para obtener elementos por idx
    public T GetElemets(int i)
    {
        if(i<= _index && i >= 0)
        {
            return _elements[i];
        }
        return default(T);
    }

    //metodo para obtener los elementos como una cadena de strings
    public string GetString()
    {
        int i = 0;
        string result= "";
        while (i < _index)
        {
            result += _elements[i].ToString() + " | ";
            i++;
        } 
        return result;
    }
}

public class People
{
    public String Name { get; set; }
    public int Age { get; set; }

    // sobreescritura
    public override string ToString()
    {
        return $"Nombre: {Name}, Edad: {Age}";
    }
}