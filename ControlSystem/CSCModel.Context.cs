﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ControlSystem
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class cscEntities : DbContext
    {
        public cscEntities()
            : base("name=cscEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<cliente> cliente { get; set; }
        public virtual DbSet<compra> compra { get; set; }
        public virtual DbSet<devolução> devolução { get; set; }
        public virtual DbSet<estoque> estoque { get; set; }
        public virtual DbSet<fornecedor> fornecedor { get; set; }
        public virtual DbSet<fornecedor_produto> fornecedor_produto { get; set; }
        public virtual DbSet<funcionário> funcionário { get; set; }
        public virtual DbSet<item_compra> item_compra { get; set; }
        public virtual DbSet<item_venda> item_venda { get; set; }
        public virtual DbSet<lote> lote { get; set; }
        public virtual DbSet<usuario> usuario { get; set; }
        public virtual DbSet<venda> venda { get; set; }
        public virtual DbSet<estados> estados { get; set; }
    }
}
