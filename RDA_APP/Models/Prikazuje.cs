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
    
    public partial class Prikazuje
    {
        public int Prikazuje_ID { get; set; }
        public int Kanali_ID { get; set; }
        public int Reklama_ID { get; set; }
        public Nullable<System.DateTime> Termin_prikaza_Od { get; set; }
        public Nullable<System.DateTime> Termin_prikaza_Do { get; set; }
        public Nullable<int> Broj_prikaza { get; set; }
    
        public virtual Kanali Kanali { get; set; }
        public virtual Reklama Reklama { get; set; }
    }
}
