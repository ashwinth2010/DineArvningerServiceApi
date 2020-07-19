//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DBAccess
{
    using System;
    using System.Collections.Generic;
    
    public partial class TestamentOpretter
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public TestamentOpretter()
        {
            this.Vaerge = new HashSet<Vaerge>();
        }
    
        public int Id { get; set; }
        public Nullable<int> Testament_Form_Id { get; set; }
        public string Type { get; set; }
        public string Fornavn { get; set; }
        public string Efternavn { get; set; }
        public string Fulde_navn { get; set; }
        public Nullable<int> AdresseId { get; set; }
        public Nullable<bool> Har_du_tidligere_opretettet_testamenta { get; set; }
        public Nullable<bool> har_du_saereje { get; set; }
        public string Saereje_type { get; set; }
        public Nullable<bool> Er_saereje_tidsbegraenset { get; set; }
        public string Saereje_tidsbegraensnings_dato { get; set; }
        public string Saerejet_daekker { get; set; }
        public string Saerejeform { get; set; }
        public Nullable<bool> MaaSaerejetAendres { get; set; }
        public string Aendringsbetingelser { get; set; }
        public Nullable<bool> Fortrinsret { get; set; }
        public string Genstande { get; set; }
        public Nullable<bool> Sidder_du_i_uskiftet_bo { get; set; }
        public string Dit_Afdoede_aegtefaelles_navn { get; set; }
        public Nullable<decimal> FordelingiPct { get; set; }
        public string Ejendele { get; set; }
        public Nullable<bool> Vil_du_indsaette_en_vaerge_for_boernene_hvis_du_gaar_bort { get; set; }
        public Nullable<int> VaergeId { get; set; }
        public string Relation_til_vaergen { get; set; }
        public string Begrundelse_for_valg_af_vaerge { get; set; }
        public Nullable<System.DateTime> CreatedDateTime { get; set; }
        public Nullable<System.DateTime> ModificationDateTime { get; set; }
    
        public virtual Testamenta_form Testamenta_form { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Vaerge> Vaerge { get; set; }
    }
}