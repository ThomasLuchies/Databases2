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
    
    public partial class seizoenen
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public seizoenen()
        {
            this.afleveringen = new HashSet<afleveringen>();
        }
    
        public int seizoen_id { get; set; }
        public int serie_id { get; set; }
        public string naam { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<afleveringen> afleveringen { get; set; }
        public virtual series series { get; set; }
    }
}
