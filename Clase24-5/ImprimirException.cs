using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase24_5
{// Creamos una clase llamada imprimirexcepcion que hereda de exception
    // Podemos agregarle metodos, propiedades, pero siempr tiene que tener lo basico.
    class ImprimirException:Exception
    {
        public string Usuario;
        public string descripcion;
        public string mensaje;
        // Contructor estandar de la clase imprimirExcepcion, en caso de no desear utilizarlo lo pasamos a private
        private ImprimirException(string mensaje)
            : base(mensaje)
        {
            this.mensaje = mensaje;
        }

        public ImprimirException(string mensaje, Exception inner)
            : this(mensaje)
        {
            this.mensaje = mensaje;      
        }
        
        public ImprimirException(string mensaje,string desc, string user)
            : this(mensaje) // con base vemos los constructores que tiene la clase excepcion.
        {
            this.descripcion = desc;
            this.Usuario = user;
            this.mensaje = mensaje;
        
        }
    }
}
