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
    public class RepresentanteServices
    {
        private readonly IRepresentanteRepository representanteRepository;
        public RepresentanteServices()
        {
            representanteRepository = new RepresentanteRepository();
        }

        public void InsertarRepresentante(Representante representante)
        {
            representanteRepository.Add(representante);
        }

        public void ModificarRepresentante(Representante representante)
        {
            representanteRepository.Update(representante);
        }

        public void EliminarRepresentante(int id)
        {
            representanteRepository.Delete(id);
        }

        public IEnumerable<Representante> ListarRepresentante()
        {
            return representanteRepository.GetAll();
        }

    }
}
