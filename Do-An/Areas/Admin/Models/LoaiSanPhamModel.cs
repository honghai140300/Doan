using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Do_An.Areas.Admin.Models
{
    public class LoaiSanPhamModel
    {
        [Key]
        public int IdLoaiSp { get; set; }
        [Required]
        public string TenLoai { get; set; }
        public ICollection<SanPhamModel> SanPhams { get; set; }
    }
}
