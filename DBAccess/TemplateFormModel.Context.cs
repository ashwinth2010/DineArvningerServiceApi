﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DBAccess
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class dinearvningerEntities : DbContext
    {
        public dinearvningerEntities()
            : base("name=dinearvningerEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<CREDENTIALS_API> CREDENTIALS_API { get; set; }
        public virtual DbSet<SESSIONS_API> SESSIONS_API { get; set; }
        public virtual DbSet<Testamenta_form_API> Testamenta_form_API { get; set; }
        public virtual DbSet<Adresse> Adresse { get; set; }
        public virtual DbSet<VedgoerendeOrganisation> VedgoerendeOrganisation { get; set; }
        public virtual DbSet<TestamentaOpretter> TestamentaOpretter { get; set; }
        public virtual DbSet<OrganisationArvinger> OrganisationArvinger { get; set; }
        public virtual DbSet<Arvinger> Arvinger { get; set; }
        public virtual DbSet<Vaerge> Vaerge { get; set; }
        public virtual DbSet<Bobestyrer> Bobestyrer { get; set; }
        public virtual DbSet<Arvning> Arvning { get; set; }
        public virtual DbSet<OrganisationArvning> OrganisationArvning { get; set; }
        public virtual DbSet<Testamenta_form> Testamenta_form { get; set; }
        public virtual DbSet<TestamentOpretter> TestamentOpretter { get; set; }
    }
}
