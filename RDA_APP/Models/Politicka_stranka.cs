//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace RDA_APP.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class Politicka_stranka
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Politicka_stranka()
        {
            this.Odbor = new HashSet<Odbor>();
        }
    
        public int Politicka_stranka_ID { get; set; }
        public string Naziv { get; set; }
        public string Mesto { get; set; }
        public string Opstina { get; set; }
        public string Adresa { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Odbor> Odbor { get; set; }
    }
}
