using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

namespace MihHiu.Model
{
    public partial class QLKS : DbContext
    {
        public QLKS()
            : base("name=QLKS")
        {
        }

        public virtual DbSet<DICHVU> DICHVUs { get; set; }
        public virtual DbSet<HOADON> HOADONs { get; set; }
        public virtual DbSet<KHACHHANG> KHACHHANGs { get; set; }
        public virtual DbSet<LOAIPHONG> LOAIPHONGs { get; set; }
        public virtual DbSet<PHIEUDATPHONG> PHIEUDATPHONGs { get; set; }
        public virtual DbSet<PHONG> PHONGs { get; set; }
        public virtual DbSet<CTHD> CTHDs { get; set; }
        public virtual DbSet<CTPD> CTPDs { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<HOADON>()
                .HasMany(e => e.CTHDs)
                .WithRequired(e => e.HOADON)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<KHACHHANG>()
                .HasMany(e => e.PHIEUDATPHONGs)
                .WithRequired(e => e.KHACHHANG)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<LOAIPHONG>()
                .HasMany(e => e.PHONGs)
                .WithRequired(e => e.LOAIPHONG)
                .HasForeignKey(e => e.MALOAIPHONG)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<PHIEUDATPHONG>()
                .HasMany(e => e.CTHDs)
                .WithRequired(e => e.PHIEUDATPHONG)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<PHIEUDATPHONG>()
                .HasMany(e => e.CTPDs)
                .WithRequired(e => e.PHIEUDATPHONG)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<PHONG>()
                .HasMany(e => e.CTHDs)
                .WithRequired(e => e.PHONG)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<PHONG>()
                .HasMany(e => e.CTPDs)
                .WithRequired(e => e.PHONG)
                .WillCascadeOnDelete(false);
        }
    }
}
