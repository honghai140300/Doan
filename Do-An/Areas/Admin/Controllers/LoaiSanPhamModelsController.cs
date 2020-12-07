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
    public class LoaiSanPhamModelsController : Controller
    {
        private readonly DPContext _context;

        public LoaiSanPhamModelsController(DPContext context)
        {
            _context = context;
        }

        // GET: Admin/LoaiSanPhamModels
        public async Task<IActionResult> Index()
        {
            return View(await _context.LoaiSanPham.ToListAsync());
        }

        // GET: Admin/LoaiSanPhamModels/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var loaiSanPhamModel = await _context.LoaiSanPham
                .FirstOrDefaultAsync(m => m.IdLoaiSp == id);
            if (loaiSanPhamModel == null)
            {
                return NotFound();
            }

            return View(loaiSanPhamModel);
        }

        // GET: Admin/LoaiSanPhamModels/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Admin/LoaiSanPhamModels/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("IdLoaiSp,TenLoai")] LoaiSanPhamModel loaiSanPhamModel)
        {
            if (ModelState.IsValid)
            {
                _context.Add(loaiSanPhamModel);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(loaiSanPhamModel);
        }

        // GET: Admin/LoaiSanPhamModels/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var loaiSanPhamModel = await _context.LoaiSanPham.FindAsync(id);
            if (loaiSanPhamModel == null)
            {
                return NotFound();
            }
            return View(loaiSanPhamModel);
        }

        // POST: Admin/LoaiSanPhamModels/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("IdLoaiSp,TenLoai")] LoaiSanPhamModel loaiSanPhamModel)
        {
            if (id != loaiSanPhamModel.IdLoaiSp)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(loaiSanPhamModel);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!LoaiSanPhamModelExists(loaiSanPhamModel.IdLoaiSp))
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
            return View(loaiSanPhamModel);
        }

        // GET: Admin/LoaiSanPhamModels/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var loaiSanPhamModel = await _context.LoaiSanPham
                .FirstOrDefaultAsync(m => m.IdLoaiSp == id);
            if (loaiSanPhamModel == null)
            {
                return NotFound();
            }

            return View(loaiSanPhamModel);
        }

        // POST: Admin/LoaiSanPhamModels/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var loaiSanPhamModel = await _context.LoaiSanPham.FindAsync(id);
            _context.LoaiSanPham.Remove(loaiSanPhamModel);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool LoaiSanPhamModelExists(int id)
        {
            return _context.LoaiSanPham.Any(e => e.IdLoaiSp == id);
        }
    }
}
