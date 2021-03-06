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
    
    public partial class tCliente
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public tCliente()
        {
            this.tPreventiveDetails = new HashSet<tPreventiveDetails>();
        }
    
        public int Id { get; set; }
        public string RagioneSociale { get; set; }
        public string CodiceUniclima { get; set; }
        public string Categoria { get; set; }
        public Nullable<int> Classe { get; set; }
        public string Indirizzo { get; set; }
        public Nullable<int> CAP { get; set; }
        public string Citta { get; set; }
        public string Provincia { get; set; }
        public string P_Iva { get; set; }
        public string Banca { get; set; }
        public string CIN { get; set; }
        public string ABI { get; set; }
        public string CAB { get; set; }
        public string ContoCorrente { get; set; }
        public string IBAN { get; set; }
        public string TelefonoUfficio { get; set; }
        public string Telefax { get; set; }
        public string Conttato1 { get; set; }
        public string Cellulare1 { get; set; }
        public string Conttato2 { get; set; }
        public string Cellulare2 { get; set; }
        public string Contatto3 { get; set; }
        public string Cellulare3 { get; set; }
        public string Referente1 { get; set; }
        public string Referente2 { get; set; }
        public string Note1 { get; set; }
        public string Note2 { get; set; }
        public string Note3 { get; set; }
        public string Note4 { get; set; }
        public string Fornitori { get; set; }
        public string Titolari { get; set; }
        public string Soci { get; set; }
        public string Segretari { get; set; }
        public string Amministrativi { get; set; }
        public string UfficioTecnico { get; set; }
        public string IndirizzoEmail { get; set; }
        public string SitoInternet { get; set; }
        public string ConsensoDati { get; set; }
        public Nullable<System.DateTime> Data_ { get; set; }
        public Nullable<double> FatturatoGlobale { get; set; }
        public string s_GUID { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tPreventiveDetails> tPreventiveDetails { get; set; }
    }
}
