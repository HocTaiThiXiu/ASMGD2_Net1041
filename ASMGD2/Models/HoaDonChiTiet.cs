namespace ASMGD2.Models
{
    public class HoaDonChiTiet
    {
        public Guid Id { get; set; }
        public Guid? SanPhamID { get; set; }
        public Guid? HoaDonId { get; set; }
        public decimal? TongTien { get; set; }
        public HoaDon? HoaDon { get; set; }
        public SanPham? SanPham { get; set; }
    }
}
