using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using API_TURISMO.Data;
using API_TURISMO.Models;

namespace API_TURISMO.Controllers
{
    public class P_TuristicosController : Controller
    {
        private readonly ApplicationDbContext _context;

        public P_TuristicosController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: P_Turisticos
        public async Task<IActionResult> Index(string Pesquisa = "")
        {
            var applicationDbContext = _context.P_Turistico.Include(p => p.Cidade).Include(p => p.Estado).AsQueryable();
            if (!string.IsNullOrEmpty(Pesquisa))
            {
                applicationDbContext = applicationDbContext.Where(c => ((c.Nome.Contains(Pesquisa)) || (c.Descrição.Contains(Pesquisa)))); 
            }
            applicationDbContext = applicationDbContext.OrderBy(c => c.Nome);

            return View(await applicationDbContext.ToListAsync());
        }

        // GET: P_Turisticos/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var p_Turistico = await _context.P_Turistico
                .Include(p => p.Cidade)
                .Include(p => p.Estado)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (p_Turistico == null)
            {
                return NotFound();
            }

            return View(p_Turistico);
        }

        // GET: P_Turisticos/Create
        public IActionResult Create()
        {
            ViewData["CidadeId"] = new SelectList(_context.Set<Cidade>(), "Cid", "name");
            ViewData["EstadoId"] = new SelectList(_context.Set<Estado>(), "Eid", "name");
            return View();
        }

        // POST: P_Turisticos/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Nome,Descrição,Endereço,EstadoId,CidadeId")] P_Turistico p_Turistico)
        {
            if (ModelState.IsValid)
            {
                _context.Add(p_Turistico);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["CidadeId"] = new SelectList(_context.Set<Cidade>(), "Cid", "name", p_Turistico.CidadeId);
            ViewData["EstadoId"] = new SelectList(_context.Set<Estado>(), "Eid", "name", p_Turistico.EstadoId);
            return View(p_Turistico);
        }

        // GET: P_Turisticos/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var p_Turistico = await _context.P_Turistico.FindAsync(id);
            if (p_Turistico == null)
            {
                return NotFound();
            }
            ViewData["CidadeId"] = new SelectList(_context.Set<Cidade>(), "Cid", "name", p_Turistico.CidadeId);
            ViewData["EstadoId"] = new SelectList(_context.Set<Estado>(), "Eid", "name", p_Turistico.EstadoId);
            return View(p_Turistico);
        }

        // POST: P_Turisticos/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Nome,Descrição,Endereço,EstadoId,CidadeId")] P_Turistico p_Turistico)
        {
            if (id != p_Turistico.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(p_Turistico);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!P_TuristicoExists(p_Turistico.Id))
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
            ViewData["CidadeId"] = new SelectList(_context.Set<Cidade>(), "Cid", "name", p_Turistico.CidadeId);
            ViewData["EstadoId"] = new SelectList(_context.Set<Estado>(), "Eid", "name", p_Turistico.EstadoId);
            return View(p_Turistico);
        }

        // GET: P_Turisticos/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var p_Turistico = await _context.P_Turistico
                .Include(p => p.Cidade)
                .Include(p => p.Estado)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (p_Turistico == null)
            {
                return NotFound();
            }

            return View(p_Turistico);
        }

        // POST: P_Turisticos/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var p_Turistico = await _context.P_Turistico.FindAsync(id);
            _context.P_Turistico.Remove(p_Turistico);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool P_TuristicoExists(int id)
        {
            return _context.P_Turistico.Any(e => e.Id == id);
        }
    }
}
