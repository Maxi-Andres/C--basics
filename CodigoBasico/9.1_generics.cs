using System;

class Genereciss
{
    static void condition(string[] args)
    {
        // generic =  "not specific to a particular data type"
        //            add <T> to: classes, methods, fields, etc.
        //            allows for code reusability for different data types

        int[] intArray = { 1, 2, 3 };
        double[] doubleArray = { 1.0, 2.0, 3.0 };
        String[] stringArray = { "1", "2", "3" };

        displayElements(intArray);
        displayElements(doubleArray);
        displayElements(stringArray);

        Console.ReadKey();
    }
    // <generics> permite que la funcion permita distintos datatypes
    // <T> 
    public static void displayElements<Thing>(Thing[] array)
    {
        foreach (Thing item in array)
        {
            Console.Write(item + " ");
        }
        Console.WriteLine();
    }
    // where T : Animal Le dice al compilador que T debe ser la clase Animal o cualquier clase que herede de Animal.
    public static void HacerSonido<T>(T animal) where T : Animal 
    {
        animal.Sonido(); // Podemos usar métodos definidos en Animal
    }
}

class Animal
{
    public virtual void Sonido()
    {
        Console.WriteLine("Sonido genérico");
    }
}

class Perro : Animal
{
    public override void Sonido()
    {
        Console.WriteLine("Guau!");
    }
}
class Gato : Animal
{
    public override void Sonido()
    {
        Console.WriteLine("Miau!");
    }
}

//un namespace es como una carpeta virtual que agrupa clases, interfaces, structs, enums, etc.sirve para:
//    - organizar tu código en secciones lógicas.
//    - evitar que dos clases con el mismo nombre entren en conflicto.
namespace Vehiculos
{
    class Auto
    {
        public void Manejar()
        {
            Console.WriteLine("Conduciendo el auto...");
        }
    }
}

namespace Animales
{
    class Auto
    {
        public void Caminar()
        {
            Console.WriteLine("Soy un animal llamado Auto 😅");
        }
    }
}

// using Vehiculos;

class Programa
{
    static void Main(string[] args)
    {
        Vehiculos.Auto miAuto = new Vehiculos.Auto();

        //Auto miAuto = new Auto(); // Usa Vehiculos.Auto gracias al "using"
        miAuto.Manejar();
    }
}