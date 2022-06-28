

// funciones = procesos de codigo que van a repertirse y tu quieras encapsular
Show();
Sum(4, 5);
Sum(7, 7);
int valor = Mul(2, 2);
Console.WriteLine("El resultado de la multiplicación es: "+ valor);


// void = me indica que no va a retornar información

// funcion sin parametros
static void Show()
{
    Console.WriteLine("Hola soy un texto que se imprime desde una función");
}

// funcion con parametros
static void Sum(int a, int b)
{
    int sum = a + b;
    Console.WriteLine(sum);
}

//funcion que retorna algo (tipo de dato)
static int Mul(int a, int b)
{
    int mul = a * b;
    return mul;
}