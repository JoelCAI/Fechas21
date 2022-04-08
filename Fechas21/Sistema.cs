using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fechas21
{
    public class Sistema
    {
        public void MenuPrincipal()
        {
 
            Validador.Bienvenida();

            Validador.FechaNow();

            Validador.Despedida();
        }

        public void Iniciar()
        {
            MenuPrincipal();
        }
    }
}
