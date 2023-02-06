using Aplication.ServicesEntity;
using Dominio.Model.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UI.Windows.ViewModel;

namespace UI.Windows.AplicationController
{
    public class RepresentanteController
    {
        private RepresentanteServices representanteServices = new RepresentanteServices();

        public bool InsertarRepresentante(RepresentanteViewModel representanteViewModel)
        {
            Representante representante = new Representante();
            try
            {
                representante.Nombres = representanteViewModel.Nombres;
                representante.Apellidos = representanteViewModel.Apellidos;
                representante.Identificacion = representanteViewModel.Identificacion;
                representante.Telefono = representanteViewModel.Telefono;
                representante.FechaNacimiento = representanteViewModel.FechaNacimiento;
                representante.Nacionalidad = representanteViewModel.Nacionalidad;
                representante.Sexo = representanteViewModel.Sexo;
                representante.EstadoCivil = representanteViewModel.EstadoCivil;
                representante.Dirección = representanteViewModel.Dirección;
                representanteServices.InsertarRepresentante(representante);
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public bool ModificarRepresentante(RepresentanteViewModel representanteViewModel)
        {
            Representante representante = new Representante();
            try
            {
                representante.RepresentanteId = representanteViewModel.RepresentanteId;
                representante.Nombres = representanteViewModel.Nombres;
                representante.Apellidos = representanteViewModel.Apellidos;
                representante.Identificacion = representanteViewModel.Identificacion;
                representante.Telefono = representanteViewModel.Telefono;
                representante.FechaNacimiento = representanteViewModel.FechaNacimiento;
                representante.Nacionalidad = representanteViewModel.Nacionalidad;
                representante.Sexo = representanteViewModel.Sexo;
                representante.EstadoCivil = representanteViewModel.EstadoCivil;
                representante.Dirección = representanteViewModel.Dirección;
                representanteServices.ModificarRepresentante(representante);
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public IEnumerable<RepresentanteViewModel> ListarRepresentante()
        {
            var listaRepresentante = representanteServices.ListarRepresentante();
            List<RepresentanteViewModel> listaProductoVM = new List<RepresentanteViewModel>();
            foreach (var item in listaRepresentante)
            {
                listaProductoVM.Add(new RepresentanteViewModel
                {
                    RepresentanteId = item.RepresentanteId,
                    Nombres = item.Nombres,
                    Apellidos = item.Apellidos,
                    Identificacion = item.Identificacion,
                    Telefono = item.Telefono,
                    FechaNacimiento = item.FechaNacimiento,
                    Nacionalidad = item.Nacionalidad,
                    Sexo = item.Sexo,
                    EstadoCivil = item.EstadoCivil,
                    Dirección = item.Dirección
                });
            }
            return listaProductoVM;
        }

        public bool Eliminar(int id)
        {
            try
            {
                representanteServices.EliminarRepresentante(id);
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

    }
}
