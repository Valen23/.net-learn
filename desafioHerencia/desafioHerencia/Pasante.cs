using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace desafioHerencia
{
    class Pasante:Empleado
    {
        public int HorasDeTrabajo { get; set; }
        public int HorasDeEscuela { get; set; }

        public void Aprender()
        {
            Console.WriteLine("Estoy aprendiendo durante {0} cantidad de horas", HorasDeEscuela);
        }
        public override void Trabajar()
        {
            Console.WriteLine(HorasDeTrabajo);
        }
    }
}
