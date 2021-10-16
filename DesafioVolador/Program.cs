using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesafioVolador
{
    class Program
    {
        static void Main(string[] args)
        {
            TorreDeControl torreControl = new TorreDeControl();
            int exit;
            int exp = 0;
            int horas = 0;
            int energia = 100;

            do
            {
                torreControl.agregarVolador();
                torreControl.vuelenTodos();
                horas = horas + 13;
                Console.WriteLine("Total de horas de vuelo: " + horas);
                energia = energia - 5;
                Console.WriteLine("La energia del pato es de: " + energia);
                exp = exp + 3;
                Console.WriteLine("La experiencia es de: " + exp);
                Console.WriteLine("Salir[3]");
                exit = Console.Read();

            } while (exit != 3);

        }
    }
}
