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
    
    public partial class Pacjenci
    {
        public Pacjenci()
        {
            this.Wizyty = new HashSet<Wizyty>();
        }
    
        public int ID_Pacjenta { get; set; }
        public string nazwisko { get; set; }
        public string imie { get; set; }
        public string PESEL { get; set; }
        public string miejsce_urodzenia { get; set; }
        public string miejsce_zamieszkania { get; set; }
        public string ulica { get; set; }
        public string kod_pocztowy { get; set; }
        public string plec { get; set; }
        public Nullable<System.DateTime> data_urodzenia { get; set; }
    
        public virtual ICollection<Wizyty> Wizyty { get; set; }
    }
}
