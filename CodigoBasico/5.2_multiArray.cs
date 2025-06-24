using System;

class MultiArray
{
    static void multiArray(string[] args)
    {
        /*
        String[] ford = { "Mustang", "F-150", "Explorer" };
        String[] chevy = { "Corvette", "Camaro", "Silverado" };
        String[] toyota = { "Corolla", "Camry", "Rav4" };
        */

        String[,] parkingLot = {
            { "Mustang", "F-150", "Explorer" },
            { "Corvette", "Camaro", "Silverado" },
            { "Corolla", "Camry", "Rav4" }
        };

        parkingLot[0, 2] = "Fusion"; // Reemplaza "Explorer" por "Fusion"

        foreach (String car in parkingLot)
        {
            Console.WriteLine(car);
        }




    }
}