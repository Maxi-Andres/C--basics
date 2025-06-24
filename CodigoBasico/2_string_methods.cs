using System;
using System.Transactions;

class StringsMethods
{
    static void strings(string[] args)
    {

        String fullName = "Maxi Andres";

        /*
         .toUpper();
         .toLower();
         .Replace("-","/"); // cambia los caracteres de la izquierda con los de la derecha
         
         .Insert(0,"@"); agrega en el indice el string
         */

        Console.WriteLine(fullName.Length); // propiedad, devuelve el largo...

        Console.WriteLine(fullName.Substring(0,2));

        // array
        String[] cars = {"BMW", "Mustang", "Corvette"}; // fixed size

        String[] cars2 = new string[3];
        cars2[0] = "Toyota";

        foreach (String car in cars) { 
            Console.WriteLine($"El auto es {car}"); // se pone el $ al principio del String
        }

        Console.ReadKey();
    }
}