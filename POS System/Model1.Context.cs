﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace POS_System
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class PoSDatabaseEntities : DbContext
    {
        public PoSDatabaseEntities()
            : base("name=PoSDatabaseEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<Product> Products { get; set; }
        public virtual DbSet<sales_tracker> sales_tracker { get; set; }
        public virtual DbSet<Order> Orders { get; set; }
    }
}