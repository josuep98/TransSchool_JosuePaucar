using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UI.Windows.ViewModel
{
    public class IncidenciaViewModel
    {
        public int IncidenciaId { get; set; }
        public string Tipo { get; set; }
        public string Titulo { get; set; }
        public string Mensaje { get; set; }
        public Nullable<int> RutaId { get; set; }
        public Nullable<System.DateTime> Fecha { get; set; }
    }
}
