using System;
using System.Collections.Generic;
using System.Text;

namespace SISTEMA_DE_VOTACIONES.Entidades
{
    public class Usuario
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Curso { get; set; }
        public string Seccion { get; set; }
        public string Matricula { get; set; }
        public string Rol { get; set; } // Votante o Administrador
        public string Clave { get; set; }
    }

}
