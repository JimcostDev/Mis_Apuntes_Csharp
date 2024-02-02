static void Main(string[] args)
{
    // Código para iniciar tu aplicación aquí
    Console.WriteLine("¡Hola, mundo!");
}
public record Persona
{
    public string Nombre { get; }
    public string Apellido { get; }

    public Persona(string nom, string ape) => (Nombre, Apellido) = (nom, ape);

    
}
//var persona = new Persona("Jack", "Doe");
//persona.Nombre = "Rick";

/*
 * El código que has proporcionado en C# define una clase Persona usando el concepto de registros (record), introducido en la versión 9.0 de C#. Los registros son una estructura de datos inmutable que se utiliza para almacenar y manipular datos de manera eficiente y segura en C#.

En este caso, la clase Persona tiene dos propiedades públicas de solo lectura Nombre y Apellido, que se definen mediante la sintaxis de propiedades autoimplementadas, utilizando el modificador get para permitir solo la lectura de las propiedades, pero no la escritura.

El constructor de la clase Persona acepta dos parámetros de tipo string, nom y ape, que se utilizan para inicializar las propiedades Nombre y Apellido, respectivamente. El constructor usa la sintaxis de tupla (nom, ape) para asignar los valores de los parámetros a las propiedades correspondientes.

En el código comentado, se crea una nueva instancia de la clase Persona con los valores "Jack" y "Doe" para las propiedades Nombre y Apellido, respectivamente. Luego, se intenta cambiar el valor de la propiedad Nombre a "Rick", lo cual no es posible debido a que las propiedades son de solo lectura, por lo que la última línea generaría un error de compilación.

En resumen, el código define una clase Persona con dos propiedades de solo lectura y un constructor que inicializa esas propiedades con valores proporcionados en la creación de la instancia. El código también muestra que las propiedades de solo lectura no pueden modificarse después de la creación de la instancia.
 */