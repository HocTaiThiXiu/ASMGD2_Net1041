namespace ASMGD2.Models
{
    public class HoaDon
    {
        public Guid Id { get; set; }
        public DateTime? NgayXuat { get; set; }
        public decimal? TongTien { get; set; }
        public string? TrangThai {  get; set; }
        public Guid? UserId { get; set; }
        public User? User { get; set; }
        public List<HoaDonChiTiet> hoaDonChiTiets { get; set; }
    }
}
