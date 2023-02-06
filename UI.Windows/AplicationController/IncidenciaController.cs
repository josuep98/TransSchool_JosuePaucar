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
    public class IncidenciaController
    {
        private IncidenciaServices incidenciaServices = new IncidenciaServices();

        public bool Insertar(IncidenciaViewModel incidenciaViewModel)
        {
            Incidencia incidencia = new Incidencia();
            try
            {
                incidencia.Tipo = incidenciaViewModel.Tipo;
                incidencia.Titulo = incidenciaViewModel.Titulo;
                incidencia.Mensaje = incidenciaViewModel.Mensaje;
                incidencia.RutaId = incidenciaViewModel.RutaId;
                incidencia.Fecha = incidenciaViewModel.Fecha;
                incidenciaServices.InsertarIncidencia(incidencia);
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public bool Modificar(IncidenciaViewModel incidenciaViewModel)
        {
            Incidencia incidencia = new Incidencia();
            try
            {
                incidencia.IncidenciaId = incidenciaViewModel.IncidenciaId;
                incidencia.Tipo = incidenciaViewModel.Tipo;
                incidencia.Titulo = incidenciaViewModel.Titulo;
                incidencia.Mensaje = incidenciaViewModel.Mensaje;
                incidencia.RutaId = incidenciaViewModel.RutaId;
                incidencia.Fecha = incidenciaViewModel.Fecha;
                incidenciaServices.ModificarIncidencia(incidencia);
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public IEnumerable<IncidenciaViewModel> Listar()
        {
            var lista = incidenciaServices.ListarIncidencia();
            List<IncidenciaViewModel> listaVM = new List<IncidenciaViewModel>();
            foreach (var item in lista)
            {
                listaVM.Add(new IncidenciaViewModel
                {
                    IncidenciaId = item.IncidenciaId,
                    Tipo = item.Tipo,
                    Titulo = item.Titulo,
                    Mensaje = item.Mensaje,
                    RutaId = item.RutaId,
                    Fecha = item.Fecha
                });
            }
            return listaVM;
        }

        public bool Eliminar(int id)
        {
            try
            {
                incidenciaServices.EliminarIncidencia(id);
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

    }
}
