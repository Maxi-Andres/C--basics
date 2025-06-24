using System;
using System.Transactions; // que es esto

class Methods
{
    static void metodhaso(string[] args) // imagina que es el main o lo que sea
    {
        happyBirthday("Pepe");

        printNames("Juan", "Pepe", "Laura");

    }

    static void happyBirthday(String name)
    {
        Console.WriteLine("Happy birtday!" + name);
    }

    // hay otro que no es static, 

    static void printNames(params string[] names) // params hace que el metodo admita numero variable de parametros
    {
        foreach (string name in names)
        {
            Console.WriteLine("Hola " + name);
        }
    }

    int a = 1;
    int b = 2;

    static int sumar(int a, int b) => a + b; // ahorras el return, es como kotlin


}