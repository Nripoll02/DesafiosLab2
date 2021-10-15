using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesafioInterfaces
{
    class Impresora
    {
        List<Imprimible> ColaDeImpresiones = new List<Imprimible>();



        public void ImprimirTodo()
        {
            foreach (Imprimible c in ColaDeImpresiones)
                c.Imprimir();
        }
        public void AgregarImprimible()
        {
            Documento documento = new Documento();
            ColaDeImpresiones.Add(documento);

            Foto foto = new Foto();
            ColaDeImpresiones.Add(foto);

            Contrato contrato = new Contrato();
            ColaDeImpresiones.Add(contrato);
        }

    }
}
