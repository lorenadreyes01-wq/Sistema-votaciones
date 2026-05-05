using SISTEMA_DE_VOTACIONES.Conexion;
using SISTEMA_DE_VOTACIONES.Entidades;
using System;
using System.Collections.Generic;
using System.Text;

namespace SISTEMA_DE_VOTACIONES.Logica
{
    public class PartidoService
    {
        private readonly PartidoRepository _partidoRepo;

        public PartidoService(PartidoRepository partidoRepo)
        {
            _partidoRepo = partidoRepo;
        }

   
        public void RegistrarPartido(string nombre, string logo)
        {
            var partido = new Partido
            {
                Nombre = nombre,
                Logo = logo
            };

            _partidoRepo.Agregar(partido);
        }

 
        public List<Partido> ObtenerPartidos()
        {
            return _partidoRepo.Listar();
        }

        public Partido BuscarPartidoPorId(int id)
        {
            return _partidoRepo.BuscarPorId(id);
        }

        public void ActualizarPartido(int id, string nombre, string logo)
        {
            var partido = new Partido
            {
                Id = id,
                Nombre = nombre,
                Logo = logo
            };

            _partidoRepo.Actualizar(partido);
        }

        public void EliminarPartido(int id)
        {
            _partidoRepo.Eliminar(id);
        }
    }
}
