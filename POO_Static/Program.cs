//Todos aquellos atributos o métodos a los cuales se le antepone la palabra 'static' hacen que
//ese atributo o método se conviertan en atributos o métodos de clase. Es decir, que no se necesita
//instanciar un objeto para poder acceder a ese atributo o método.



Math x = new Math();
Math y = new Math();

//accedemos a los metodos y propiedades desde la clase, no desde sus objetos
int r = Math.Sum(3, 4);
Console.WriteLine(r);
Console.WriteLine($"The value of PI is =  { Math.PI}");

string text = Math.GetCount();
Console.WriteLine(text);

public class Math
{
    public static float PI = 3.1416f;
    public static int Count = 0;
    public Math()
    {
        Count++;
    }
    public static int Sum(int a, int b)
    {
        return a + b;
    }

    public static string GetCount()
    {
        return $"This class has used {Count} times";
    }
}

// tambien puede ser a nivel de clase 
public static class Some
{
    public static void GetSome()
    {
        Console.WriteLine("Something");
    }
}