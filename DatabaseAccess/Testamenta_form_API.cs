//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DatabaseAccess
{
    using System;
    using System.Collections.Generic;
    
    public partial class Testamenta_form_API
    {
        public int formId { get; set; }
        public int session_id { get; set; }
        public string hvordan_vil_du_oprette_testamentet { get; set; }
        public string hvilket_testamente_onskes { get; set; }
        public string civilstand { get; set; }
        public string dit_navn { get; set; }
        public string dit_aegtefaelles_navn { get; set; }
        public Nullable<bool> har_du_tidligere_opretettet_testamente_selv { get; set; }
        public Nullable<bool> har_du_tidligere_opretettet_testamente_aegtefaelle { get; set; }
        public Nullable<bool> har_du_saereje_selv { get; set; }
        public Nullable<bool> har_du_saereje_aegtefaelle { get; set; }
        public Nullable<System.DateTime> createdDateTime { get; set; }
        public Nullable<System.DateTime> modificationDateTime { get; set; }
    
        public virtual SESSIONS_API SESSIONS_API { get; set; }
    }
}
