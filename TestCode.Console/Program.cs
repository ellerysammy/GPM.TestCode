using System;
using TestCode.Console.Business;
using TestCode.Implementations;
using TestCode.Interfaces.Models;

namespace TestCode.Console
{
    class Program
    {
        static void Main(string[] args)
        {
            int x, y, z;
            System.Console.WriteLine(" *** Cube 1 *** ");
            System.Console.WriteLine("X:");
            _ = int.TryParse(System.Console.ReadLine(), out x);
            System.Console.WriteLine("Y:");
            _ = int.TryParse(System.Console.ReadLine(), out y);
            System.Console.WriteLine("Z:");
            _ = int.TryParse(System.Console.ReadLine(), out z);
            CubeService service = new CubeService();
            var cube1 = service.Create(new ThreeAxesOriginCoordinates { X = x, Y = y, Z = z });


            System.Console.WriteLine(" *** Cube 1 *** ");
            System.Console.WriteLine("X:");
            _ = int.TryParse(System.Console.ReadLine(), out x);
            System.Console.WriteLine("Y:");
            _ = int.TryParse(System.Console.ReadLine(), out y);
            System.Console.WriteLine("Z:");
            _ = int.TryParse(System.Console.ReadLine(), out z);
            var cube2 = service.Create(new ThreeAxesOriginCoordinates { X = x, Y = y, Z = z });

            System.Console.WriteLine($"Area Cube 1: {cube1.CalculateArea().ToString()}");
            System.Console.WriteLine($"Volume Cube 2: {cube2.CalculateVolume().ToString()}");
            System.Console.ReadKey();

        }
    }
}
