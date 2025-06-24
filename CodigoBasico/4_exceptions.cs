using System;

class Exceptions
{
    static void expexct(string[] args)
    {

        double x, y, result;

        try
        {
            Console.Write("Enter number 1: ");
            x = Convert.ToDouble(Console.ReadLine());

            Console.Write("Enter number 2: ");
            y = Convert.ToDouble(Console.ReadLine());

            result = x / y;

            Console.WriteLine("Result: " + result);
        }
        catch (FormatException e)
        {
            Console.WriteLine("Enter ONLY numbers PLEASE!");
        }
        catch (DivideByZeroException e)
        {
            Console.WriteLine("You can't divide by zero!");
        }
        catch (Exception e) // agarras todas
        {
            Console.WriteLine("Something went wrong!");
        }
        finally { 
            // esto se ejecuta si o si, se suele usar para cerrar archivos, resetear, etc...
        }

    }
}