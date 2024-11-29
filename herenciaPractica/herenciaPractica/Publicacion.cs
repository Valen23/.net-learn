﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Herencia
{
    class Publicacion
    {
        private static int publicacionID = 0;

        //Propiedades
        protected int ID { get; set; }
        protected string Titulo { get; set; }
        protected string Autor { get; set; }
        protected bool EsPublico { get; set; }

        //Constructor por defecto
        public Publicacion()
        {
            ID = 0;
            Titulo = "Mi primera publicación";
            EsPublico = true;
            Autor = "Juan Perez";
        }

        //Constructor parametrizado
        public Publicacion (string titulo, bool esPublico, string autor)
        {
            this.ID = CrearID();
            this.Titulo = titulo;
            this.EsPublico = esPublico;
            this.Autor = autor;
        }

        //M'etodo para crear ID
        protected int CrearID()
        {
            return ++publicacionID;
        }

        //M'etodo para editar publicacionn
        public void Editar(string titulo, bool esPublico)
        {
            this.Titulo = titulo;
            this.EsPublico = esPublico;
        }

        public override string ToString()
        {
            return String.Format(" {0} - {1} - Creado por {2}", this.ID, this.Titulo, this.Autor);
        }

    }
}
