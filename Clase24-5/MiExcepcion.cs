using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase24_5
{
    class MiExcepcion:Exception
    {
        public string mensaje;

        public MiExcepcion(string mensaje, Exception ex)
            :base(mensaje,ex)
        {
            this.mensaje = mensaje;
        }
    }
}
