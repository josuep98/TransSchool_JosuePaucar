using Dominio.Model.Abstractions;
using Dominio.Model.Entities;
using Infra.DataAccess.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aplication.ServicesEntity
{
    public class IncidenciaServices
    {
        private readonly IIncidenciaRepository incidenciaRepository;
        public IncidenciaServices()
        {
            incidenciaRepository = new IncidenciaRepository();
        }
        public void InsertarIncidencia(Incidencia representante)
        {
            incidenciaRepository.Add(representante);
        }

        public void ModificarIncidencia(Incidencia representante)
        {
            incidenciaRepository.Update(representante);
        }

        public void EliminarIncidencia(int id)
        {
            incidenciaRepository.Delete(id);
        }

        public IEnumerable<Incidencia> ListarIncidencia()
        {
            return incidenciaRepository.GetAll();
        }
    }
}
