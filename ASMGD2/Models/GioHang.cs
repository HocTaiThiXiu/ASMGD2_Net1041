namespace ASMGD2.Models
{
    public class GioHang
    {
        public Guid Id { get; set; }
        public string? Username { get; set; }
        public Guid? Userid { get; set; }
        public User? User { get; set; } 
        public List<GioHangChiTiet> gioHangChiTiets { get; set; }

    }
}
