using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase24_5
{
    class Program
    {
        static void Main(string[] args)
        {   //Excepciones. 
            try
            {
                int numeroUno = 0;
                int numeroDos = 10;
                // float resultado = numeroDos / numeroUno;
                //string dato = Console.ReadLine();
                //numeroDos = int.Parse(dato);
                //Documento.imprimirStatic();
                Portafolio unPorta = new Portafolio();
                Documento unDoc = new Documento();
                unPorta.Listado.Add(unDoc);
                Exception nuevo = new Exception();
                unPorta.imprimirPortafolio();

            }
            catch (FormatException ex)
            {
                //Formato de parseo incorrecto
                Console.WriteLine(ex.Message);
            }
            catch (DivideByZeroException ex)
            {
                //El seguno no se puede dividir por cero
                Console.WriteLine(ex.Message);
            }
            catch (ImprimirException ex)
            {
                Console.WriteLine(ex.Message + ex.Usuario);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }


           
        }
    }
}
