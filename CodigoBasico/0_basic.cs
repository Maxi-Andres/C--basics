using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Hey!"); // no pone enter
        Console.WriteLine("Hello");

        int cosa;
        int edad = 25; // declaration & initialization
        double altura = 1.75;
        string nombre = "Juan"; // string: cuando declarás variables, por convención.
        String name = "Maxi"; // String: cuando usás métodos estáticos (como String.IsNullOrEmpty, String.Format, etc.).
        bool esEstudiante = true;
        char inicial = 'J';

        // Uso de constantes (const) no cambia
        const int y = 30;

        // type casting, cambiar un data type a otro

        double a = 3.14;
        int b = Convert.ToInt32(a);
        String c = Convert.ToString(b); // hay toBoolean() etc...

        Console.WriteLine(a.GetType());
        Console.WriteLine(b);


        Console.Write("Cual es tu nombre: ");
        String nombreUsuario = Console.ReadLine();
        Console.WriteLine("Hola " + nombreUsuario);

        int numero2 = 5;
        numero2 += 2; // esto existe
        numero2 *= 2; // esto tambien
        numero2++; // esto tambien y el resto -- -= /= etc





        Console.ReadKey(); // espera key, es como getchar en c
        Console.Beep();

    }
}
