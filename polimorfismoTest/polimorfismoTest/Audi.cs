using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace polimorfismoTest
{
    internal class Audi:Auto
    {
        private string marca = "Audi";
        public string Modelo { get; set; }
        public Audi()
        {
            this.Color = "blanco";
            this.HP = 0;
            this.Modelo = "basic";
        }
        public Audi(int potencia, string color, string modelo)
        {
            this.HP = potencia;
            this.Color = color;
            this.Modelo = modelo;
        }
        public override string MostrarDetalles()
        {
            return string.Format("Potencia {0}, color {1}, marca {2}, modelo {3}", HP, Color, marca, Modelo);
        }
    }
}
