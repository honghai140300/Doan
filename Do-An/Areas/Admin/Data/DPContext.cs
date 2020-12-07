using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Do_An.Areas.Admin.Models;
namespace Do_An.Areas.Admin.Data
{
    public class DPContext:DbContext
    {
        public DPContext(DbContextOptions<DPContext> options) : base(options)
        { }
        public DbSet<LoaiUserModel> LoaiUser { get; set; }
        public DbSet<UserModel> User { get; set; }
        public DbSet<LoaiSanPhamModel> LoaiSanPham { get; set; }
        public DbSet<SanPhamModel> SanPham { get; set; }
        public DbSet<ChiTietHoaDonModel> ChiTietHoaDon { get; set; }
        public DbSet<HoaDonModel> HoaDon { get; set; }
    }
}
