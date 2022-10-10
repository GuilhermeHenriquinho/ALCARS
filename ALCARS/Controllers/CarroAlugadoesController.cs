using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using ALCARS.Models;

namespace ALCARS.Controllers
{
    public class CarroAlugadoesController : Controller
    {
        private readonly Contexto _context;

        public CarroAlugadoesController(Contexto context)
        {
            _context = context;
        }

        // GET: CarroAlugadoes
        public async Task<IActionResult> Index()
        {
              return View(await _context.CarroAlugado.ToListAsync());
        }

        // GET: CarroAlugadoes/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null || _context.CarroAlugado == null)
            {
                return NotFound();
            }

            var carroAlugado = await _context.CarroAlugado
                .FirstOrDefaultAsync(m => m.id == id);
            if (carroAlugado == null)
            {
                return NotFound();
            }

            return View(carroAlugado);
        }

        // GET: CarroAlugadoes/Create
        public IActionResult Create()
        {   
            new Carro().alugar();
            return View();
        }

        // POST: CarroAlugadoes/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("id,idCliente,idCarro")] CarroAlugado carroAlugado)
        {
            if (ModelState.IsValid)
            {
                _context.Add(carroAlugado);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(carroAlugado);
        }

        // GET: CarroAlugadoes/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null || _context.CarroAlugado == null)
            {
                return NotFound();
            }

            var carroAlugado = await _context.CarroAlugado.FindAsync(id);
            if (carroAlugado == null)
            {
                return NotFound();
            }
            return View(carroAlugado);
        }

        // POST: CarroAlugadoes/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("id,idCliente,idCarro")] CarroAlugado carroAlugado)
        {
            if (id != carroAlugado.id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(carroAlugado);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!CarroAlugadoExists(carroAlugado.id))
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
            return View(carroAlugado);
        }

        // GET: CarroAlugadoes/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null || _context.CarroAlugado == null)
            {
                return NotFound();
            }

            var carroAlugado = await _context.CarroAlugado
                .FirstOrDefaultAsync(m => m.id == id);
            if (carroAlugado == null)
            {
                return NotFound();
            }

            return View(carroAlugado);
        }

        // POST: CarroAlugadoes/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            if (_context.CarroAlugado == null)
            {
                return Problem("Entity set 'Contexto.CarroAlugado'  is null.");
            }
            var carroAlugado = await _context.CarroAlugado.FindAsync(id);
            if (carroAlugado != null)
            {
                _context.CarroAlugado.Remove(carroAlugado);
            }
            
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool CarroAlugadoExists(int id)
        {
          return _context.CarroAlugado.Any(e => e.id == id);
        }
    }
}
