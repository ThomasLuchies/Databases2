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
    
    public partial class films_kwaliteiten
    {
        public int film_id { get; set; }
        public string kwaliteit { get; set; }
    
        public virtual films films { get; set; }
    }
}
