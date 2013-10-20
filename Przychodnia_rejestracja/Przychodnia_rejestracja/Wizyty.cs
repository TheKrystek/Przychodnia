//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Przychodnia_rejestracja
{
    using System;
    using System.Collections.Generic;
    
    public partial class Wizyty
    {
        public Wizyty()
        {
            this.Badania = new HashSet<Badania>();
            this.Diagnozy = new HashSet<Diagnozy>();
            this.Recepty = new HashSet<Recepty>();
        }
    
        public int ID_Wizyty { get; set; }
        public int ID_Lekarza { get; set; }
        public int ID_Pacjenta { get; set; }
        public Nullable<System.DateTime> data { get; set; }
        public Nullable<System.TimeSpan> czas { get; set; }
        public Nullable<bool> czy_odbyta { get; set; }
    
        public virtual ICollection<Badania> Badania { get; set; }
        public virtual ICollection<Diagnozy> Diagnozy { get; set; }
        public virtual Lekarze Lekarze { get; set; }
        public virtual Pacjenci Pacjenci { get; set; }
        public virtual ICollection<Recepty> Recepty { get; set; }
    }
}
