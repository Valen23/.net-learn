using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace polimorfismoTest
{
    internal class E5:BMW
    {
        public E5(int potencia, string color)
        {
            this.Color = color;
            this.HP = potencia;
        }
        public sealed override string MostrarDetalles()
        {
            return string.Format("Potencia {0}, color {1}, marca BMW, modelo E5, titular {2}, patente {3}", HP, Color, miRegistro.Titular, miRegistro.Patente);
        }
    }
}
