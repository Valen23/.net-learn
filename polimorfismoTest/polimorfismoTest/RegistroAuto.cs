using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace polimorfismoTest
{
    internal class RegistroAuto
    {
        public string Titular { get; set; } = "none";
        public string Patente { get; set; } = "-1";
        public string LeerDatos()
        {
            return string.Format("A nombre de {0}, con la patente {1}", Titular, Patente);
        }
    }
}
