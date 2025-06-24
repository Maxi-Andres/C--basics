using System;
using System.Collections.Generic;

class Persona2
{
    public string nombre;
    public int edad;

    public Persona2(string nombre, int edad)
    {
        this.nombre = nombre;
        this.edad = edad;
    }

    // Sobreescribir ToString() para personalizar lo que se imprime
    public override string ToString()
    {
        return $"Persona: {nombre}, Edad: {edad}";
    }
}

// “Cualquier clase que implemente esta interfaz debe proporcionar una versión pública de estos métodos.”
interface Prey
{
    void run();
    void escape();
}

class Rabbit : Prey
{
    public void run()
    {

    }
    public void escape()
    {

    }
}

interface IA { void MetodoA(); }
interface IB { void MetodoB(); }

class MiClase : IA, IB // se puede heredar de muchas interfaces
{
    public void MetodoA() { }
    public void MetodoB() { }
}

// NO se puede heredar de muchas super clases como Kotlin

// La diferencia entre un array y una lista es que la lista puede cambiar dinamicamente de tamaño

class Nose
{
    static void nosew()
    {
        // array
        String[] food = new string[3];

        food[0] = "pizza";
        food[1] = "empanada";
        food[2] = "hambuerguesa";

        //list
        List<int> numbers = new List<int>();

        numbers.Add(1321);
        numbers.Add(81);
        numbers.Add(51);
        numbers.Add(11);
        numbers.Add(15);
        numbers.Add(12);
        numbers.Add(43);

        // Eliminar elemento por valor
        numbers.Remove(81);

        // Insertar en posición específica
        numbers.Insert(2, 999); // Inserta el 999 en la posición 2

        // Ordenar la lista
        numbers.Sort();

        // Invertir el orden de la lista
        numbers.Reverse();

        // Buscar si un número está en la lista
        bool contiene11 = numbers.Contains(11);

        // Contar los elementos
        int elementos = numbers.Count;

        // Obtener un indice
        Console.WriteLine(numbers.IndexOf(11));

        // combierte a array
        int[] numbersArray = numbers.ToArray();

        // Borra todo lo que tenga
        numbers.Clear();

        Dictionary<int, string> mapa = new Dictionary<int, string> { { 1, "Uno" } };
        // existen los diccionarios
        /* Colecciones basicas
         array
         list
         diccionary
         */

    }
}
