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
    
    public partial class series
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public series()
        {
            this.seizoenen = new HashSet<seizoenen>();
            this.series_genres = new HashSet<series_genres>();
            this.series_kijkwijzer_indicaties = new HashSet<series_kijkwijzer_indicaties>();
            this.kijklijst_items = new HashSet<kijklijst_items>();
        }
    
        public int serie_id { get; set; }
        public string naam { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<seizoenen> seizoenen { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<series_genres> series_genres { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<series_kijkwijzer_indicaties> series_kijkwijzer_indicaties { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<kijklijst_items> kijklijst_items { get; set; }
    }
}
