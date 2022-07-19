// sobrecarga = te permite tener varios metodos con el mismo nombre pero con diferentes de argumentos (ya sea en tipo o en cantidad).
Math math = new Math();
Console.WriteLine(math.Sum(3,5));
Console.WriteLine(math.Sum("3", "4"));

int[] numbers = new int[] { 1, 2, 3, 4, 5, 6 };
Console.WriteLine(math.Sum(numbers));
public class Math
{
    public int Sum (int a, int b)
    {
        return a + b;
    }

    public int Sum(string a, string b)
    {
        return int.Parse(a) + int.Parse(b);
    }

    public int Sum(int[] numbers)
    {
        int resultado = 0;
        //for (int i = 0; i < numbers.Length; i++)
        //{
        //    resultado = resultado + numbers[i];
        //}

        foreach (int number in numbers)
        {
            resultado = resultado + number;
        }
        return resultado;
    }
}