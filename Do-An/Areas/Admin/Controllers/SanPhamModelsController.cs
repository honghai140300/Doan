using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Do_An.Areas.Admin.Data;
using Do_An.Areas.Admin.Models;

namespace Do_An.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class SanPhamModelsController : Controller
    {
        private readonly DPContext _context;

        public SanPhamModelsController(DPContext context)
        {
            _context = context;
        }

        // GET: Admin/SanPhamModels
        public async Task<IActionResult> Index()
        {
            return View(await _context.SanPham.ToListAsync());
        }

        // GET: Admin/SanPhamModels/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var sanPhamModel = await _context.SanPham
                .FirstOrDefaultAsync(m => m.IdSanPham == id);
            if (sanPhamModel == null)
            {
                return NotFound();
            }

            return View(sanPhamModel);
        }

        // GET: Admin/SanPhamModels/Create
        public IActionResult Create()
        {
            ViewBag.LoaiSanPham = _context.LoaiSanPham.ToList();
            return View();
        }

        // POST: Admin/SanPhamModels/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("IdSanPham,IDLoaiSp,TenSanPham,SoLuong,GiaNhap,GiaBan,Mota,HinhAnh,TrangThai")] SanPhamModel sanPhamModel)
        {
            if (ModelState.IsValid)
            {
                _context.Add(sanPhamModel);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(sanPhamModel);
        }

        // GET: Admin/SanPhamModels/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var sanPhamModel = await _context.SanPham.FindAsync(id);
            if (sanPhamModel == null)
            {
                return NotFound();
            }
            return View(sanPhamModel);
        }

        // POST: Admin/SanPhamModels/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("IdSanPham,IDLoaiSp,TenSanPham,SoLuong,GiaNhap,GiaBan,Mota,HinhAnh,TrangThai")] SanPhamModel sanPhamModel)
        {
            if (id != sanPhamModel.IdSanPham)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(sanPhamModel);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!SanPhamModelExists(sanPhamModel.IdSanPham))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(Index));
            }
            return View(sanPhamModel);
        }

        // GET: Admin/SanPhamModels/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var sanPhamModel = await _context.SanPham
                .FirstOrDefaultAsync(m => m.IdSanPham == id);
            if (sanPhamModel == null)
            {
                return NotFound();
            }

            return View(sanPhamModel);
        }

        // POST: Admin/SanPhamModels/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var sanPhamModel = await _context.SanPham.FindAsync(id);
            _context.SanPham.Remove(sanPhamModel);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool SanPhamModelExists(int id)
        {
            return _context.SanPham.Any(e => e.IdSanPham == id);
        }
    }
}
