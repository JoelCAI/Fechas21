using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fechas21
{
    public class Validador
    {
       

        public static void Despedida()
        {

            Console.WriteLine("\n Gracias por usar nuestro Sistema presione cualquier teclar para finalizar");
            Console.ReadKey();
        }

        public static void FechaNow()
        {

            DateTime fecha = DateTime.Now;
            Console.WriteLine(" \n La fecha de hoy es: " + fecha);

        }


        public static void Bienvenida()
        {
            Console.WriteLine("\n Bienvenido al Programa");
        }
    }
}
