﻿//------------------------------------------------------------------------------
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
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class EntitiesPrzychodnia : DbContext
    {
        public EntitiesPrzychodnia()
            : base("name=PrzychodniaModel")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public DbSet<Badania> Badania { get; set; }
        public DbSet<Choroby> Choroby { get; set; }
        public DbSet<Diagnozy> Diagnozy { get; set; }
        public DbSet<Lekarstwa> Lekarstwa { get; set; }
        public DbSet<Lekarze> Lekarze { get; set; }
        public DbSet<LekarzSpecjalnosc> LekarzSpecjalnosc { get; set; }
        public DbSet<Pacjenci> Pacjenci { get; set; }
        public DbSet<Recepty> Recepty { get; set; }
        public DbSet<Specjalnosci> Specjalnosci { get; set; }
        public DbSet<Swiadczenia> Swiadczenia { get; set; }
        public DbSet<sysdiagrams> sysdiagrams { get; set; }
        public DbSet<Wizyty> Wizyty { get; set; }
    }
}
