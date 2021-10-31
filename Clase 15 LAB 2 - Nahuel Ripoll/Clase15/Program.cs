using System;

namespace Clase15
{
    class Program
    {
        static void Main(string[] args)
        {
            Lavadora myLavadora = new Lavadora();
            Television myTelevision = new Television();
            int opcion;
            Console.WriteLine("Por favor, elija un electrodomestico");
            Console.WriteLine("Televisior(1)");
            Console.WriteLine("Lavadora(2)");
            opcion = Convert.ToInt32(Console.ReadLine());
            switch (opcion)
            {
                case 1:
                    myTelevision.PrecioFinal();
                    break;
                case 2:
                    myLavadora.precioFinal();
                    break;
                default:
                    break;
            }
            


        }
    }
}
