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
    
    public partial class Odbor
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Odbor()
        {
            this.Reklama = new HashSet<Reklama>();
        }
    
        public int Odbor_ID { get; set; }
        public int Grad_ID { get; set; }
        public int Politicka_stranka_ID { get; set; }
        public string Naziv { get; set; }
        public string Oznaka { get; set; }
    
        public virtual Grad Grad { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Reklama> Reklama { get; set; }
        public virtual Politicka_stranka Politicka_stranka { get; set; }
    }
}
