using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjemploDepuracionCodigoCSharp
{
    class FuncionesFibonacci:Funciones
    {
        public List<int> rellenar()
        {
            int indice = 0;
            List<int> fibonacci = new List<int>();
            while (indice < this.getNumero())
            {
                indice++;
                fibonacci.Add(indice);
            }
            return fibonacci;
        }
    }
}
