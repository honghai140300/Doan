
using System.ComponentModel.DataAnnotations;

namespace Do_An.Areas.Admin.Models
{
    public class ChiTietHoaDonModel
    {
        [Key]
        public int IdCTHD { get; set; }
        public int IdHoaDon { get; set; }      
        public int idSanPham { get; set; }
        [Required]
        public int SoLuong { get; set; }
       
    }
}
