using System;

class EjemplosClases
{
    static void condition(string[] args)
    {
        //NombreClase nombreObjeto = new NombreClase();
        Messages mensajes = new Messages(); // as asi se crean los objetos

    }

    static EjemplosClases()
    {
    // Crear un array de objetos de tipo Persona
    Persona[] personas = new Persona[3];
    personas[0] = new Persona("Juan", 25);
    personas[1] = new Persona("Ana", 30);
    personas[2] = new Persona("Luis"); // Usa el constructor sobrecargado

    }

    void EjemplosClas()
    {
        // Crear un array de objetos de tipo Persona
        Persona[] personas = { new Persona("Juan", 25), new Persona("Pepe", 12) };
        // estás creando objetos sin guardar sus referencias por separado, pero sí están nombrados indirectamente al estar en el array. Esto no se llama técnicamente “nameless objects”,
    }/*
      Los objetos tienen una referencia, pero no tienen un nombre explícito como:
        Persona p = new Persona("Juan", 25);
    Esto es un “nameless object”:  
    new Persona("Juan", 25).Saludar(); // Se crea, se usa, y se descarta
    Este objeto:
    - Se crea.
    - Se usa inmediatamente (por ejemplo, para llamar un método).
    - Después se pierde porque no hay ninguna variable que lo referencie.
    - Es candidato inmediato para recolección de basura (garbage collector).
      */

}

// Clase con métodos estáticos (no requiere crear objeto)
class Messages
{
    public static void Hello()
    {
        Console.WriteLine("Hola");
    }

    public static void bye()
    {
        Console.WriteLine("Chau");
    }
}

class Persona
{
    public string nombre;
    public int edad;

    // Constructor, tiene que tener el nombre de la clase
    public Persona(string nombre, int edad)
    {
        this.nombre = nombre; // `this` se refiere al atributo de la clase
        this.edad = edad;
    }
    public Persona(string nombre) // constructor overload, la firma cambia signature = name + parameters
    {
        this.nombre = nombre; // `this` se refiere al atributo de la clase
        this.edad = 0; // Edad por defecto si no se pasa
    }

    // Método de instancia
    public void Saludar()
    {
        Console.WriteLine($"Hola, soy {nombre} y tengo {edad} años.");
    }
}

// Clase derivada de Persona, Herencia
class PersonaConPlata : Persona
{
    public PersonaConPlata(string nombre, int edad) : base(nombre, edad)
    {
        // Usa el constructor base de Persona
    }
}

// clase abstracta
// Clase abstracta no puede instanciarse directamente
abstract class Vehiculo
{
    public int ruedas;
    public int kmRecorridos;

    public abstract void MostrarInfo(); // Se usa solo en clases abstractas.
    //Obliga a las clases hijas a sobrescribir el método.
}

// Auto hereda de Vehiculo
class Auto : Vehiculo
{
    public Auto()
    {
        ruedas = 4;
        kmRecorridos = 0;
    }

    public override void MostrarInfo()
    {
        Console.WriteLine($"Soy un auto con {ruedas} ruedas y he recorrido {kmRecorridos} km.");
    }
}

// Moto hereda de Vehiculo
class Moto : Vehiculo
{
    public Moto()
    {
        ruedas = 2;
        kmRecorridos = 0;
    }

    public override void MostrarInfo()
    {
        Console.WriteLine($"Soy una moto con {ruedas} ruedas y he recorrido {kmRecorridos} km.");
    }
}


class ElCuentoDeLaAbuelaPepa
{

    static void qcy()
    {
        // enums = special "class" that contains a set of named integer constants.
        //         Use enums when you have values that you know will not change,
        //         To get the integer value from an item, you must explicitly convert to an int

        //         name = integer

        //Console.WriteLine(Planets.Mercury + " is planet #" + (int)Planets.Mercury);
        //Console.WriteLine(Planets.Pluto + " is planet #" + (int)Planets.Pluto);

        String name = PlanetRadius.Earth.ToString();
        int radius = (int)PlanetRadius.Earth;
        double volume = Volume(PlanetRadius.Earth);

        Console.WriteLine("planet: " + name);
        Console.WriteLine("radius: " + radius + "km");
        Console.WriteLine("volume: " + volume + "km^3");

        Console.ReadKey();
    }
    public static double Volume(PlanetRadius radius)
    {
        double volume = (4.0 / 3.0) * Math.PI * Math.Pow((int)radius, 3);
        return volume;
    }
}

    enum Planets
{
    Mercury = 1,
    Venus = 2,
    Earth = 3,
    Mars = 4,
    Jupiter = 5,
    Saturn = 6,
    Uranus = 7,
    Neptune = 8,
    Pluto = 9
}

enum PlanetRadius
{
    Mercury = 2439,
    Venus = 6051,
    Earth = 6371,
    Mars = 3389,
    Jupiter = 69911,
    Saturn = 58232,
    Uranus = 25362,
    Neptune = 24622,
    Pluto = 1188
}