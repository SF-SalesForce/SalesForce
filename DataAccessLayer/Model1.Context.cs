﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DataAccessLayer
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class SalesForceEntities : DbContext
    {
        public SalesForceEntities()
            : base("name=SalesForceEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<sysdiagrams> sysdiagrams { get; set; }
        public virtual DbSet<Tbl_Customers> Tbl_Customers { get; set; }
        public virtual DbSet<Tbl_Oppurtunity> Tbl_Oppurtunity { get; set; }
        public virtual DbSet<Tbl_OrderAssigment> Tbl_OrderAssigment { get; set; }
        public virtual DbSet<Tbl_OrderDetails> Tbl_OrderDetails { get; set; }
        public virtual DbSet<Tbl_Orders> Tbl_Orders { get; set; }
        public virtual DbSet<Tbl_Products> Tbl_Products { get; set; }
        public virtual DbSet<Tbl_Users> Tbl_Users { get; set; }
        public virtual DbSet<Tbl_WorkOrders> Tbl_WorkOrders { get; set; }
    }
}
