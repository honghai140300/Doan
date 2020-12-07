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
    public class ChiTietHoaDonModelsController : Controller
    {
        private readonly DPContext _context;

        public ChiTietHoaDonModelsController(DPContext context)
        {
            _context = context;
        }

        // GET: Admin/ChiTietHoaDonModels
        public async Task<IActionResult> Index()
        {
            return View(await _context.ChiTietHoaDon.ToListAsync());
        }

        // GET: Admin/ChiTietHoaDonModels/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var chiTietHoaDonModel = await _context.ChiTietHoaDon
                .FirstOrDefaultAsync(m => m.IdCTHD == id);
            if (chiTietHoaDonModel == null)
            {
                return NotFound();
            }

            return View(chiTietHoaDonModel);
        }

        // GET: Admin/ChiTietHoaDonModels/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Admin/ChiTietHoaDonModels/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("IdCTHD,IdHoaDon,idSanPham,SoLuong")] ChiTietHoaDonModel chiTietHoaDonModel)
        {
            if (ModelState.IsValid)
            {
                _context.Add(chiTietHoaDonModel);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(chiTietHoaDonModel);
        }

        // GET: Admin/ChiTietHoaDonModels/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var chiTietHoaDonModel = await _context.ChiTietHoaDon.FindAsync(id);
            if (chiTietHoaDonModel == null)
            {
                return NotFound();
            }
            return View(chiTietHoaDonModel);
        }

        // POST: Admin/ChiTietHoaDonModels/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("IdCTHD,IdHoaDon,idSanPham,SoLuong")] ChiTietHoaDonModel chiTietHoaDonModel)
        {
            if (id != chiTietHoaDonModel.IdCTHD)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(chiTietHoaDonModel);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!ChiTietHoaDonModelExists(chiTietHoaDonModel.IdCTHD))
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
            return View(chiTietHoaDonModel);
        }

        // GET: Admin/ChiTietHoaDonModels/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var chiTietHoaDonModel = await _context.ChiTietHoaDon
                .FirstOrDefaultAsync(m => m.IdCTHD == id);
            if (chiTietHoaDonModel == null)
            {
                return NotFound();
            }

            return View(chiTietHoaDonModel);
        }

        // POST: Admin/ChiTietHoaDonModels/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var chiTietHoaDonModel = await _context.ChiTietHoaDon.FindAsync(id);
            _context.ChiTietHoaDon.Remove(chiTietHoaDonModel);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool ChiTietHoaDonModelExists(int id)
        {
            return _context.ChiTietHoaDon.Any(e => e.IdCTHD == id);
        }
    }
}
