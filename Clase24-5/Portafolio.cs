using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase24_5
{
    class Portafolio
    {
        public List<Documento> Listado;

        public Portafolio()
        {
            Listado = new List<Documento>();
        }

        public void imprimirPortafolio()
        {
            try
            {
                foreach (Documento itemDocumento in Listado)
                {
                    itemDocumento.imprimirInstancia();
                }
            }
            catch (ImprimirException ex)
            {
                MiExcepcion nueva = new MiExcepcion("ImprimirProtafolio()", ex);
                throw nueva;
            }

            finally
            {//Sirve para ejecutar codigo antes de que se pierda el hilo, se utiliza para liberar recursos (archivos abiertos, base de datos,etc) 
                Console.WriteLine("finally imprimirPortafolio");
            }
            
        }
    }
}
