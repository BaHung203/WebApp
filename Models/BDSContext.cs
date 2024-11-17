using Microsoft.EntityFrameworkCore;

namespace WebApp.Models;
public class BDSContext : DbContext
{
    public BDSContext(DbContextOptions options):base(options){}
    public DbSet<Member> Members { get; set; }
    public DbSet<Login> Logins { get; set; }
    public DbSet<KhachHang> KhachHangs { get; set; }
    public DbSet<NhanVienChamSocKhachHang> NhanVienChamSocKhachHangs { get; set; }
    public DbSet<YeuCauDinhGia> YeuCauDinhGias { get; set; }
    public DbSet<QuanTriVien> QuanTriViens { get; set; }
    public DbSet<TaiSan> TaiSans { get; set; }
    public DbSet<BaoCaoDinhGia> BaoCaoDinhGias { get; set; }
    protected override void OnModelCreating(ModelBuilder modelBuilder)
{
    modelBuilder.Entity<KhachHang>().ToTable("KhachHang");
    base.OnModelCreating(modelBuilder);
}
}