using System;
using System.Collections.Generic;
using System.Text;

namespace SISTEMA_DE_VOTACIONES.Entidades
{
    public class Votacion
    {
        public int Id { get; set; }
        public int UsuarioId { get; set; }
        public int? PlanchaId { get; set; } // null si es voto nulo
        public DateTime Fecha { get; set; }
    }

}
