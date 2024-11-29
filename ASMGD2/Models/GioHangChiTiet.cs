namespace ASMGD2.Models
{
    public class GioHangChiTiet
    {
        public Guid Id { get; set; }
        public Guid? SanPhamId { get; set; }
        public Guid? GioHangId { get; set; }
        public int? SoLuong {  get; set; }
        public GioHang? GioHang { get; set; }
        public SanPham? SanPham { get; set; }
    }
}
