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
    
    public partial class tProdoct
    {
        public int IdProdotto { get; set; }
        public string Categoria { get; set; }
        public string NomeProdotto { get; set; }
        public string Descrizione { get; set; }
        public string UM { get; set; }
        public Nullable<double> PrezzoPerUnita { get; set; }
        public Nullable<int> IdDitta { get; set; }
    
        public virtual tDitte tDitte { get; set; }
    }
}
