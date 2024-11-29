using ASMGD2.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace ASMGD2.Configurations
{
    public class HoaDonConfig : IEntityTypeConfiguration<HoaDon>
    {
        public void Configure(EntityTypeBuilder<HoaDon> builder)
        {
            builder.HasKey(x => x.Id);
            builder.HasOne<User>(x=>x.User).WithMany(x=>x.hoaDons).HasForeignKey(x=>x.UserId);
        }
    }
}
