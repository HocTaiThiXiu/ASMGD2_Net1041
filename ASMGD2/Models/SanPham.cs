namespace ASMGD2.Models
{
    public class SanPham
    {
        public Guid Id { get; set; }
        public string? TenSP { get; set; }
        public decimal? Gia { get; set; }
        public string? MoTa { get; set; }
        public string? ImgUrl { get; set; }
        public List<GioHangChiTiet> gioHangChiTiets { get; set; }
        public List<HoaDonChiTiet> hoaDonChiTiets { get; set; }
    }
}
