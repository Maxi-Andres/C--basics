using System;
using System.Transactions;

class Operaciones
{
    static void operaciones(string[] args)
    {

        double x = 3;
        double y = 5;
        double a = Math.Pow(x, 2); // la base y el exponente
        double b = Math.Sqrt(x);
        double c = Math.Abs(x);
        double d = Math.Round(x);
        double e = Math.Ceiling(x);
        double f = Math.Floor(x);
        double g = Math.Max(x, y);
        double h = Math.Min(y, a);

        // pseudo random numbers

        Random random = new Random();

        int num = random.Next(1, 7); // de 1 a 6 excluye el ultimo
        double num2 = random.NextDouble(); // que genera un número aleatorio entre 0.0 (incluido) y 1.0 (excluido).



        Console.WriteLine("Enter side A:");
        double a1 = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("Enter side B:");
        double b1 = Convert.ToDouble(Console.ReadLine());

        double hypotenusa = Math.Sqrt((a*a) + (b*b));
        Console.WriteLine("The hypotenuse is : " + c);


        Console.ReadKey();
    }
}