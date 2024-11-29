using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eventosDelegados
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Creamos un archivo
            Archivo archivo = new Archivo() { Nombre = "miArchivo.txt" };
            // Creamos un asistente que sirve como emisor
            AsistenteDescarga unAsistente = new AsistenteDescarga();
            // Creamos un asistente(s) que sirve como receptor
            ServicioDesempaquetar unServicioDesempaquetar = new ServicioDesempaquetar();
            ServicioNotificacion unServicioNotificacion = new ServicioNotificacion();
            // Enlazamos los métodos al evento de 'ArchivoDescargado'
            unAsistente.ArchivoDescargado += unServicioDesempaquetar.EnArchivoDescargado;
            unAsistente.ArchivoDescargado += unServicioNotificacion.EnArchivoDescargado;
            unAsistente.Descarga(archivo);
        }
    }
    public class ServicioNotificacion
    {
        public void EnArchivoDescargado(object fuente, EventArgs e)
        {
            Console.WriteLine("El archivo se ha desempaquetado correctamente!");
        }
    }
}
