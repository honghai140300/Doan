using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Do_An.Areas.Admin.Models
{
    public class UserModel
    {
        [Key]
        public int IdUser { get; set; }
        [Required]
        public string UserName { get; set; }
        [Required]
        [StringLength(12)][MinLength(6)]
        public string PassWord { get; set; }
        [Required]
        public string AnhDaiDien { get; set; }
        [MaxLength(50)]
        public string MoTa { get; set; }
        [DataType(DataType.Date)]
        public DataType NgayLap { get; set; }
        [ForeignKey("IdLoaiUSer")]
        public int IdLoaiUser { get; set; }
        public virtual LoaiUserModel LoaiUser { get; set; }
    }
}