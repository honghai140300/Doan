using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Do_An.Areas.Admin.Models
{
    public class SanPhamModel
    {
        [Key]
        public int IdSanPham { get; set; }
        [ForeignKey("IdLoaiSp")]
        public int IDLoaiSp { get; set; }
        [Required]
        public string TenSanPham { get; set; }
        [Required]
        public int SoLuong { get; set; }
        [Required]
        public float GiaNhap { get; set; }
        [Required]
        public float GiaBan { get; set; }
        [Required]
        [StringLength(100,ErrorMessage ="quá 100 kí tự rồi")]
        public string Mota { get; set; }
        [Required]
        public string HinhAnh { get; set; }
        public int TrangThai { get; set; }
        public virtual LoaiSanPhamModel LoaiSanPham { get; set; }
    }
}