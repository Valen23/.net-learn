using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace desafioHerencia
{
    class Jefe : Empleado
    {
        public string AutoDeEmpresa { get; set; }

        public void Dirigir()
        {
            Console.WriteLine("Soy el jefe!");
        }
    }
}
