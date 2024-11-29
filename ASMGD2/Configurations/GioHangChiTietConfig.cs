using ASMGD2.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace ASMGD2.Configurations
{
    public class GioHangChiTietConfig : IEntityTypeConfiguration<GioHangChiTiet>
    {
        public void Configure(EntityTypeBuilder<GioHangChiTiet> builder)
        {
            builder.HasKey(x => x.Id);
            builder.HasOne<GioHang>(x=>x.GioHang).WithMany(x=>x.gioHangChiTiets).HasForeignKey(x=>x.GioHangId);
            builder.HasOne<SanPham>(x => x.SanPham).WithMany(x => x.gioHangChiTiets).HasForeignKey(x => x.SanPhamId);
        }
    }
}
