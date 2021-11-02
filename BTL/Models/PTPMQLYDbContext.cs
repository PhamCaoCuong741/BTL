using System.Data.Entity;

namespace BTL.Models
{
    public partial class PTPMQLYDbContext : DbContext
    {
        public PTPMQLYDbContext()
            : base("name=PTPMQLYDbContext")
        {
        }

        public virtual DbSet<TaiKhoan> TaiKhoans { get; set; }
        public virtual DbSet<Sanpham> Sanphams { get; set; }
        public virtual DbSet<Khachhang> Khachhangs { get; set; }
        public virtual DbSet<Donhang> Donhangs { get; set; }
        public virtual DbSet<Nhanvien> Nhanviens { get; set; }
        public virtual DbSet<Account> Accounts { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<TaiKhoan>()
                .Property(e => e.Tendangnhap)
                .IsFixedLength()
                .IsUnicode(false);
        }
    }
}