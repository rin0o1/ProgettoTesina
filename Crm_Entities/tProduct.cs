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
    
    public partial class tProduct
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public tProduct()
        {
            this.tStage = new HashSet<tStage>();
        }
    
        public int idProduct { get; set; }
        public Nullable<int> ProductCategory { get; set; }
        public string ProductName { get; set; }
        public string ProductDescription { get; set; }
        public string ProductUM { get; set; }
        public Nullable<double> ProductPrice { get; set; }
    
        public virtual tProductCategory tProductCategory { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tStage> tStage { get; set; }
    }
}