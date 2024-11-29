namespace ASMGD2.Models
{
    public class User
    {
        public Guid Id { get; set; }
        public string? UserName { get; set; }
        public string? Password { get; set; }
        public string? Email { get; set; }
        public GioHang? GioHang { get; set; }
         public List<HoaDon> hoaDons { get; set; }

    }
}
