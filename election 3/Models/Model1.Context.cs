﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace election_3.Models
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class electionEntities2 : DbContext
    {
        public electionEntities2()
            : base("name=electionEntities2")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<Debates> Debates { get; set; }
        public virtual DbSet<LocalList> LocalList { get; set; }
        public virtual DbSet<LocalListCandidates> LocalListCandidates { get; set; }
    }
}