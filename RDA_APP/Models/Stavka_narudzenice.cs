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
    
    public partial class Stavka_narudzenice
    {
        public int Stavka_narudzenice_ID { get; set; }
        public int Reklama_ID { get; set; }
        public int Narudzbenica_ID { get; set; }
        public Nullable<int> Kolicina { get; set; }
    
        public virtual Narudzbenica Narudzbenica { get; set; }
        public virtual Reklama Reklama { get; set; }
    }
}
