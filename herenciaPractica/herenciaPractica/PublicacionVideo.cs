using Herencia;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace herencia
{
    class PublicacionVideo:Publicacion
    {
        Timer reloj;
        public string UrlVideo { get; set; }
        public float Duracion { get; set; }
        protected float duracionActual = 0;
        protected bool seReproduce = false;
        public PublicacionVideo(string titulo, string autor, string urlVideo, bool esPublico, float duracion)
        {
            this.Titulo = titulo;
            this.Autor = autor;
            this.UrlVideo = urlVideo;
            this.EsPublico = esPublico;
            this.Duracion = duracion;
        }

        public override string ToString()
        {
            return String.Format("{0} - {1} - {2} - {3}", this.Titulo, this.Autor, this.UrlVideo, this.Duracion);
        }

        public void Play()
        {
            if (!seReproduce)
            {
                seReproduce = true;
                Console.WriteLine("Reproduciendo");
                reloj = new Timer(Reproduccion, null, 0, 1000);
            }
        }
        public void Stop()
        {
            Console.WriteLine("Se detuvo en {0}s", duracionActual);
            duracionActual = 0;
            seReproduce = false;
            reloj.Dispose();
        }

        public void Reproduccion(Object x)
        {
            if (duracionActual < Duracion)
            {
                duracionActual++;
                Console.WriteLine("Tiempo actual {0}s", duracionActual);
                GC.Collect();
            }
            else
            {
                Stop();
            }
        }
    }
}
