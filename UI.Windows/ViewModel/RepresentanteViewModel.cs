using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UI.Windows.ViewModel
{
    public class RepresentanteViewModel
    {
        public int RepresentanteId { get; set; }
        public string Nombres { get; set; }
        public string Apellidos { get; set; }
        public string Identificacion { get; set; }
        public string Telefono { get; set; }
        public Nullable<System.DateTime> FechaNacimiento { get; set; }
        public string Nacionalidad { get; set; }
        public string Sexo { get; set; }
        public string EstadoCivil { get; set; }
        public string Dirección { get; set; }
    }
}
