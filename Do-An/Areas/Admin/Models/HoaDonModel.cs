using ServiceStack.DataAnnotations;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Do_An.Areas.Admin.Models
{
    public class HoaDonModel
    {
        [Key]
        public int IdHoaDon { get; set; }
        public int idUser { get; set; }
        [DataType(DataType.Date)]
        public DataType NgayLap { get; set; }
        public float TongTien { get; set; }

    }
}
