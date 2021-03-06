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
    
    public partial class Reklama
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Reklama()
        {
            this.Prikazuje = new HashSet<Prikazuje>();
            this.Stavka_narudzenice = new HashSet<Stavka_narudzenice>();
        }
    
        public int Reklama_ID { get; set; }
        public Nullable<int> Odbor_ID { get; set; }
        public int Tip_reklame_ID { get; set; }
        public Nullable<int> Priv_grana_ID { get; set; }
        public int Agencija_ID { get; set; }
        public int Cenovnik_ID { get; set; }
        public string Naziv { get; set; }
        public string Sifra { get; set; }
        public Nullable<int> Duzina_trajanja { get; set; }
    
        public virtual Agencija Agencija { get; set; }
        public virtual Cenovnik Cenovnik { get; set; }
        public virtual Odbor Odbor { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Prikazuje> Prikazuje { get; set; }
        public virtual Privredna_grana Privredna_grana { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Stavka_narudzenice> Stavka_narudzenice { get; set; }
        public virtual Tip_reklame Tip_reklame { get; set; }
    }
}
