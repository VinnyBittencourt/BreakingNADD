using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using NADD.Models;

namespace NADD.Controllers
{
    public class QuestoesController : Controller
    {
        private readonly Contexto _context;

        public QuestoesController(Contexto context)
        {
            _context = context;
        }

        // GET: Questoes
        public async Task<IActionResult> Index()
        {
            var contexto = _context.Questoes.Include(q => q.Avaliacao);
            return View(await contexto.ToListAsync());
        }

        // GET: Questoes/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var questoes = await _context.Questoes
                .Include(q => q.Avaliacao)
                .FirstOrDefaultAsync(m => m.QuestoesId == id);
            if (questoes == null)
            {
                return NotFound();
            }

            return View(questoes);
        }

        //// GET: Questoes/Create
        //public IActionResult Create()
        //{
        //    ViewData["AvaliacaoId"] = new SelectList(_context.Avaliacao, "AvaliacaoId", "Email");
        //    return View();
        //}

        //// POST: Questoes/Create
        //// To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        //// more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        //[HttpPost]
        //[ValidateAntiForgeryToken]
        //public async Task<IActionResult> Create([Bind("QuestoesId,Valor,Tipo,Observacao,AvaliacaoId")] Questoes questoes)
        //{
        //    if (ModelState.IsValid)
        //    {
        //        _context.Add(questoes);
        //        await _context.SaveChangesAsync();
        //        return RedirectToAction(nameof(Index));
        //    }
        //    ViewData["AvaliacaoId"] = new SelectList(_context.Avaliacao, "AvaliacaoId", "PeriodoAno", questoes.AvaliacaoId);
        //    return View(questoes);
        //}

        // GET: Questoes/Create
        public IActionResult Create()
        {
            ViewData["AvaliacaoId"] = new SelectList(_context.Avaliacao, "AvaliacaoId", "PeriodoAno");
            return View();
        }

        // POST: Questoes/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("QuestoesId,NumeroQuestao,Valor,Tipo,Observacao,AvaliacaoId")] Questoes questoes)
        {
            if (ModelState.IsValid)
            {
                _context.Add(questoes);
                await _context.SaveChangesAsync();
                //return RedirectToAction(nameof(listaQuestoes));
                return Redirect("/Questoes/ListaQuestoes/" + questoes.AvaliacaoId);
            }
            ViewData["AvaliacaoId"] = new SelectList(_context.Avaliacao, "AvaliacaoId", "PeriodoAno", questoes.AvaliacaoId);
            return View(questoes);
        }

        //// GET: Questoes/Edit/5
        //public async Task<IActionResult> Edit(int? id)
        //{
        //    if (id == null)
        //    {
        //        return NotFound();
        //    }

        //    var questoes = await _context.Questoes.FindAsync(id);
        //    if (questoes == null)
        //    {
        //        return NotFound();
        //    }
        //    ViewData["AvaliacaoId"] = new SelectList(_context.Avaliacao, "AvaliacaoId", "Email", questoes.AvaliacaoId);
        //    return View(questoes);
        //}

        //// POST: Questoes/Edit/5
        //// To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        //// more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        //[HttpPost]
        //[ValidateAntiForgeryToken]
        //public async Task<IActionResult> Edit(int id, [Bind("QuestoesId,Valor,Tipo,Observacao,AvaliacaoId")] Questoes questoes)
        //{
        //    if (id != questoes.QuestoesId)
        //    {
        //        return NotFound();
        //    }

        //    if (ModelState.IsValid)
        //    {
        //        try
        //        {
        //            _context.Update(questoes);
        //            await _context.SaveChangesAsync();
        //        }
        //        catch (DbUpdateConcurrencyException)
        //        {
        //            if (!QuestoesExists(questoes.QuestoesId))
        //            {
        //                return NotFound();
        //            }
        //            else
        //            {
        //                throw;
        //            }
        //        }
        //        return RedirectToAction(nameof(Index));
        //    }
        //    ViewData["AvaliacaoId"] = new SelectList(_context.Avaliacao, "AvaliacaoId", "Email", questoes.AvaliacaoId);
        //    return View(questoes);
        //}


        // GET: Questoes/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var questoes = await _context.Questoes.FindAsync(id);
            if (questoes == null)
            {
                return NotFound();
            }
            ViewData["AvaliacaoId"] = new SelectList(_context.Avaliacao, "AvaliacaoId", "PeriodoAno", questoes.AvaliacaoId);
            return View(questoes);
        }

        // POST: Questoes/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("QuestoesId,NumeroQuestao,Valor,Tipo,Observacao,AvaliacaoId")] Questoes questoes)
        {
            if (id != questoes.QuestoesId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(questoes);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!QuestoesExists(questoes.QuestoesId))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                //return RedirectToAction(nameof(Index));
                return Redirect("/Questoes/ListaQuestoes/" + questoes.AvaliacaoId);
            }
            ViewData["AvaliacaoId"] = new SelectList(_context.Avaliacao, "AvaliacaoId", "PeriodoAno", questoes.AvaliacaoId);
            return View(questoes);
        }

        // GET: Questoes/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var questoes = await _context.Questoes
                .Include(q => q.Avaliacao)
                .FirstOrDefaultAsync(m => m.QuestoesId == id);
            if (questoes == null)
            {
                return NotFound();
            }

            return View(questoes);
        }

        // POST: Questoes/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var questoes = await _context.Questoes.FindAsync(id);
            _context.Questoes.Remove(questoes);
            await _context.SaveChangesAsync();
            //return RedirectToAction(nameof(Index));
            return Redirect("/Questoes/ListaQuestoes/" + questoes.AvaliacaoId);
        }

        private bool QuestoesExists(int id)
        {
            return _context.Questoes.Any(e => e.QuestoesId == id);
        }

        // GET: Questoes/Verifica/5
        public async Task<IActionResult> Verifica(long? id)
        {
            if (id != null)
            {
                var questoes = _context.Questoes.Where(a => a.AvaliacaoId == id).FirstOrDefault();

                if (questoes == null)
                {
                    return RedirectToAction(nameof(Create));
                }
                else
                {
                    return Redirect("/Questoes/ListaQuestoes/" + id);
                }
            }
            else
            {
                return View(id);
            }
        }

        [ActionName("listaQuestoes")]
        // GET: Questoes/listaQuestoes/5
        public async Task<IActionResult> listaQuestoes(long? id)
        {
            /*var contexto = _context.Questoes.Include(a => a.Avaliacao);
            return View(await contexto.ToListAsync());*/
            var questoes = _context.Questoes.Where(a => a.AvaliacaoId == id).ToList();

            ViewData["AvaliacaoId"] = new SelectList(_context.Avaliacao, "AvaliacaoId", "PeriodoAno");

            return View(questoes);
        }
    }
}
