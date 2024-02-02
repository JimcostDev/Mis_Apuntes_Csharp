
try
{
    string content = File.ReadAllText(@"C:\Users\JIMCOSTDEV\Desktop\hola.txt");
    Console.WriteLine(content);

    //string content2 = File.ReadAllText(@"C:\Users\JIMCOSTDEV\Desktop\hola2.txt");
    //Console.WriteLine(content2);

    throw new Exception("Ocurrio algo raro");
}
catch (FileNotFoundException ex)
{
    Console.WriteLine($"El archivo no existe");
}
catch (Exception ex)
{
    Console.WriteLine(ex.Message);
}
finally
{
    Console.WriteLine("Aquí me he ejecutado, pase lo que pase, exista o no expeción");
}

Console.WriteLine("Aqui se sigue ejecutando");
