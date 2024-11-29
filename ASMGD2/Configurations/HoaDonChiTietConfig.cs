using ASMGD2.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace ASMGD2.Configurations
{
    public class HoaDonChiTietConfig : IEntityTypeConfiguration<HoaDonChiTiet>
    {
        public void Configure(EntityTypeBuilder<HoaDonChiTiet> builder)
        {
            builder.HasKey(x => x.Id);
            builder.HasOne<HoaDon>(x=>x.HoaDon).WithMany(x=>x.hoaDonChiTiets).HasForeignKey(x=>x.HoaDonId);
            builder.HasOne<SanPham>(x => x.SanPham).WithMany(x => x.hoaDonChiTiets).HasForeignKey(x => x.SanPhamID);
        }
    }
}
