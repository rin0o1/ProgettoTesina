//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Crm_Entities
{
    using System;
    using System.Collections.Generic;
    
    public partial class tStage
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public tStage()
        {
            this.tShift = new HashSet<tShift>();
        }
    
        public int idStage { get; set; }
        public Nullable<System.DateTime> StartStage { get; set; }
        public Nullable<System.DateTime> EndStage { get; set; }
        public Nullable<int> NumberNiceProductValue { get; set; }
        public Nullable<int> NumberBadProductValue { get; set; }
        public Nullable<int> Machine { get; set; }
        public Nullable<int> Product { get; set; }
        public Nullable<bool> IsProducing { get; set; }
    
        public virtual tMachine tMachine { get; set; }
        public virtual tProduct tProduct { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tShift> tShift { get; set; }
    }
}
