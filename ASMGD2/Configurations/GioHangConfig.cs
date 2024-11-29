using ASMGD2.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace ASMGD2.Configurations
{
    public class GioHangConfig : IEntityTypeConfiguration<GioHang>
    {
        public void Configure(EntityTypeBuilder<GioHang> builder)
        {
            builder.HasKey(x => x.Id);
            builder.HasOne(x => x.User).WithOne(x => x.GioHang).HasForeignKey<GioHang>(x => x.Userid);
        }
    }
}
