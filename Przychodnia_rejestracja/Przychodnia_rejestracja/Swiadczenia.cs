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
    
    public partial class Swiadczenia
    {
        public int ID_Swiadczenia { get; set; }
        public string nazwa { get; set; }
        public Nullable<double> koszt { get; set; }
    
        public virtual Badania Badania { get; set; }
    }
}
