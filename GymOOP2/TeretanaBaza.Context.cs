//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace GymOOP2
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class TeretanaEntities : DbContext
    {
        public TeretanaEntities()
            : base("name=TeretanaEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<cenovnik> cenovniks { get; set; }
        public virtual DbSet<clan> clans { get; set; }
        public virtual DbSet<korisnik> korisniks { get; set; }
        public virtual DbSet<Oprema> Opremas { get; set; }
        public virtual DbSet<Prisustvo> Prisustvoes { get; set; }
        public virtual DbSet<Termin> Termins { get; set; }
    }
}
