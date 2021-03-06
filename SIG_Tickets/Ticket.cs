//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace SIG_Tickets
{
    using System;
    using System.Collections.Generic;
    
    public partial class Ticket
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Ticket()
        {
            this.DetallesTickets = new HashSet<DetallesTicket>();
        }
    
        public int tk_id_ticket { get; set; }
        public string tk_asunto { get; set; }
        public string tk_descripción { get; set; }
        public string tk_categoria { get; set; }
        public string tk_fecha_creacion { get; set; }
        public string tk_fecha_vencimiento { get; set; }
        public string tk_fecha_cierre { get; set; }
        public string tk_estado_ticket { get; set; }
        public Nullable<int> cli_id { get; set; }
        public Nullable<int> tec_id { get; set; }
        public Nullable<int> ent_id { get; set; }
    
        public virtual Cliente Cliente { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DetallesTicket> DetallesTickets { get; set; }
        public virtual Entidades_Externas Entidades_Externas { get; set; }
        public virtual Tecnico Tecnico { get; set; }
    }
}
