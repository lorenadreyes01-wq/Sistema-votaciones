using SISTEMA_DE_VOTACIONES.Conexion;
using SISTEMA_DE_VOTACIONES.Entidades;
using System;
using System.Collections.Generic;
using System.Text;

namespace SISTEMA_DE_VOTACIONES.Logica
{

    public class PlanchaService
    {
            private readonly PlanchaRepository _planchaRepo;

            public PlanchaService(PlanchaRepository planchaRepo)
            {
                _planchaRepo = planchaRepo;
            }

        public void RegistrarPlancha(int partidoId, string presidente, string vicepresidente, string secretario, int creadorId)
        {
            var plancha = new Plancha
            {
                PartidoId = partidoId,
                Presidente = presidente,
                Vicepresidente = vicepresidente,
                Secretario = secretario,
                CreadorId = creadorId
            };

            _planchaRepo.Agregar(plancha);
        }

        public List<Plancha> ObtenerPlanchas()
            {
                return _planchaRepo.Listar();
            }

            public Plancha BuscarPlanchaPorId(int id)
            {
                return _planchaRepo.BuscarPorId(id);
            }

     

        // Eliminar plancha
        public void EliminarPlancha(int id)
            {
                _planchaRepo.Eliminar(id);
            }
        }
    }

