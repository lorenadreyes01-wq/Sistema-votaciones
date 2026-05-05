using System;
using System.Collections.Generic;
using System.Text;

namespace SISTEMA_DE_VOTACIONES.Entidades
{
    public class Plancha
    {
        public int Id { get; set; }
        public int PartidoId { get; set; }
        public string Presidente { get; set; }
        public string Vicepresidente { get; set; }
        public string Secretario { get; set; }
        public int CreadorId { get; set; }
    }
}
