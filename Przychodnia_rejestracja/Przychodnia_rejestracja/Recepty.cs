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
    
    public partial class Recepty
    {
        public int ID_Recepty { get; set; }
        public int ID_Wizyty { get; set; }
        public int ID_Lekarstwa { get; set; }
        public string uwagi { get; set; }
    
        public virtual Lekarstwa Lekarstwa { get; set; }
        public virtual Wizyty Wizyty { get; set; }
        public virtual Lekarstwa Lekarstwa1 { get; set; }
    }
}
