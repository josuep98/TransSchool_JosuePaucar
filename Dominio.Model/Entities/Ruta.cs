//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Dominio.Model.Entities
{
    using System;
    using System.Collections.Generic;
    
    public partial class Ruta
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Ruta()
        {
            this.Incidencia = new HashSet<Incidencia>();
            this.RutaTransporte = new HashSet<RutaTransporte>();
        }
    
        public int RutaId { get; set; }
        public Nullable<System.DateTime> FechaRuta { get; set; }
        public Nullable<System.TimeSpan> HoraInicio { get; set; }
        public string PuntoInicio { get; set; }
        public Nullable<System.TimeSpan> HoraFin { get; set; }
        public string PuntoFin { get; set; }
        public Nullable<int> EstudianteId { get; set; }
    
        public virtual Estudiante Estudiante { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Incidencia> Incidencia { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<RutaTransporte> RutaTransporte { get; set; }
    }
}
