﻿//------------------------------------------------------------------------------
// <auto-generated>
//     此代码已从模板生成。
//
//     手动更改此文件可能导致应用程序出现意外的行为。
//     如果重新生成代码，将覆盖对此文件的手动更改。
// </auto-generated>
//------------------------------------------------------------------------------

namespace hai
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class haiEntities : DbContext
    {
        public haiEntities()
            : base("name=haiEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<brokeragevalue> brokeragevalue { get; set; }
        public virtual DbSet<employees> employees { get; set; }
        public virtual DbSet<products> products { get; set; }
        public virtual DbSet<v_emp> v_emp { get; set; }
        public virtual DbSet<orderows> orderows { get; set; }
        public virtual DbSet<orders> orders { get; set; }
        public virtual DbSet<v_orders> v_orders { get; set; }
    }
}
