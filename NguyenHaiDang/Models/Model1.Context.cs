﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace NguyenHaiDang.Models
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class WebBanVaLiEntities : DbContext
    {
        public WebBanVaLiEntities()
            : base("name=WebBanVaLiEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<sysdiagram> sysdiagrams { get; set; }
        public virtual DbSet<Table_1> Table_1 { get; set; }
        public virtual DbSet<tAnhSP> tAnhSPs { get; set; }
        public virtual DbSet<tChatLieu> tChatLieux { get; set; }
        public virtual DbSet<tDanhMucSP> tDanhMucSPs { get; set; }
        public virtual DbSet<tHangSX> tHangSXes { get; set; }
        public virtual DbSet<tKichThuoc> tKichThuocs { get; set; }
        public virtual DbSet<tLoaiDT> tLoaiDTs { get; set; }
        public virtual DbSet<tLoaiSP> tLoaiSPs { get; set; }
        public virtual DbSet<tQuocGia> tQuocGias { get; set; }
    }
}
