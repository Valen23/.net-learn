using herencia;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Herencia
{
    class Program
    {
        static void Main(string[] args)
        {
            Publicacion post1 = new Publicacion("Gracias por los saludos de compleaños", true, "Laura Garay");
            Console.WriteLine(post1.ToString());

            PublicacionImagen imagen1 = new PublicacionImagen("Mira la foto de mi perrito", "Laura Garay", "https://imagenes.com/perritos", true);
            Console.WriteLine(imagen1.ToString());

            PublicacionVideo video1 = new PublicacionVideo("Mi hijo aprende a caminar", "Jose Maria", " https://misvideos.com/hijo", true, 15);
            Console.WriteLine(video1.ToString());
            video1.Play();
            Console.WriteLine("Presione cualquier tecla para detener");
            Console.ReadKey();
            video1.Stop();
            
            Console.Read();
        }
    }

    //Crear clase PublicacionVideo
    //Propiedades UrlVideo y Duracion
    //Crear los constructores
    //Ajustar el método ToString()
    //Crea una instancia de PublicacionVideo
}
