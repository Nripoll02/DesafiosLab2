using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesafioVolador
{
    class TorreDeControl
    {
        List<Volador> voladores = new List<Volador>();
        public void vuelenTodos()
        {
            foreach (Volador v in voladores)
            {
                v.volador();
            }
        }

        public void agregarVolador()
        {
            Pato pato = new Pato();
            voladores.Add(pato);

            Boing747 avion = new Boing747();
            voladores.Add(avion);

            Superman super = new Superman();
            voladores.Add(super);
        }
    }
}
