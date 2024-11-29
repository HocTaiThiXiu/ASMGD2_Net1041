using Microsoft.EntityFrameworkCore;

namespace ASMGD2.Models
{
    public class ASMGD2DbContext : DbContext
    {
        public ASMGD2DbContext()
        {
                
        }

        public ASMGD2DbContext(DbContextOptions options) : base(options)
        {
        }
        public DbSet<User> Users { get; set; }  
        public DbSet<SanPham> SanPhams { get; set; }
        public DbSet<HoaDonChiTiet> HoaDonChiTiets { get; set; }
        public DbSet<HoaDon> HoaDons  { get; set; }
        public DbSet<GioHangChiTiet> GioHangChiTiets { get; set; }
        public DbSet<GioHang> GioHangs { get; set; }
    }
}
