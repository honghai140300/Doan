using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Do_An.Areas.Admin.Models
{
    public class LoaiUserModel
    {
        [Key]
        public int idLoaiUser { get; set; }
        [Required][MaxLength(50)]
        public string TenLoai { get; set; }
        public virtual ICollection<UserModel> UserModels { get; set; }
    }
}
