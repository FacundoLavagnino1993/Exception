using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase24_5
{
    public class Documento
    {
        public static void imprimirStatic(Documento doc)
        { 
            //Lanzamos una excepcion 
            // Creamos un imprimirExcepcion
            
            ImprimirException miex = new ImprimirException("No se pudo imprimir", "No hay red para impresora", "Montoto");
            //Para lanzar la excepcion usamos throw miex.
            throw miex;
            //Lanzamos la excepcion
        }

        public void imprimirInstancia()
        {
            try
            {
                Documento.imprimirStatic(this);// como imprimirStatic recibe por parametro documento, le pasamos this ya que estamos en Documento.
            }
            catch (ImprimirException ex)
            {
                ImprimirException nueva = new ImprimirException("ImprimirProtafolio()", ex);
                throw nueva;
            }
            
        }
    }
}
