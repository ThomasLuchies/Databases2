//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Databases2
{
    using System;
    using System.Collections.Generic;
    
    public partial class gebruikers_abbonementen
    {
        public int gebruiker_id { get; set; }
        public int abbonement_id { get; set; }
        public System.DateTime verloopt_op { get; set; }
        public int korting_in_centen { get; set; }
    
        public virtual abbonementen abbonementen { get; set; }
        public virtual gebruikers gebruikers { get; set; }
    }
}
