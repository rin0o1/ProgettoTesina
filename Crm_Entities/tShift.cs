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
    
    public partial class tShift
    {
        public int idShift { get; set; }
        public Nullable<System.DateTime> StartTimeShift { get; set; }
        public Nullable<System.DateTime> EndTimeShift { get; set; }
        public Nullable<int> IdStage { get; set; }
        public Nullable<int> IdUser { get; set; }
    
        public virtual tStage tStage { get; set; }
        public virtual tUser tUser { get; set; }
    }
}
