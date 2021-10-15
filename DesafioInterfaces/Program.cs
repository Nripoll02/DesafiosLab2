using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesafioInterfaces
{
    class Program
    {
        static void Main(string[] args)
        {
            Foto foto = new Foto();
            Documento documento = new Documento();
            Contrato contrato = new Contrato();
            Impresora impresora = new Impresora();
            impresora.AgregarImprimible();
            impresora.ImprimirTodo();
            Console.ReadKey();
            
            
        }
    }
}
