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
    
    public partial class films
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public films()
        {
            this.films_genres = new HashSet<films_genres>();
            this.films_kijkwijzer_indicaties = new HashSet<films_kijkwijzer_indicaties>();
            this.films_kwaliteiten = new HashSet<films_kwaliteiten>();
            this.films_ondertitelingen = new HashSet<films_ondertitelingen>();
            this.kijk_histories = new HashSet<kijk_histories>();
            this.kijklijst_items = new HashSet<kijklijst_items>();
        }
    
        public int film_id { get; set; }
        public string naam { get; set; }
        public int tijdsduur_in_seconden { get; set; }
        public int aftiteling_tijdstip_in_seconden { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<films_genres> films_genres { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<films_kijkwijzer_indicaties> films_kijkwijzer_indicaties { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<films_kwaliteiten> films_kwaliteiten { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<films_ondertitelingen> films_ondertitelingen { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<kijk_histories> kijk_histories { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<kijklijst_items> kijklijst_items { get; set; }
    }
}