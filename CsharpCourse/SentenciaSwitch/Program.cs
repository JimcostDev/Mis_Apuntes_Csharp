int value = 1;
switch (value)
{
    case 1:
        Console.WriteLine("Seleccionaste el 1");
        break;
    case 2:
        Console.WriteLine("Seleccionaste el 2");
        break;
    case < 0:
    case > 100:
        Console.WriteLine("Fuera de rango");
        break;
    case > 4 and < 10:
        Console.WriteLine("Seleccionaste una opción entre 5 y 9");
        break ;
    default:
        Console.WriteLine("Opción invalida");
        break;
}