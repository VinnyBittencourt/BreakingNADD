using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using NADD.Models;
using Rotativa.AspNetCore;

namespace NADD.Controllers
{
    public class AvaliacaosController : Controller
    {
        private readonly Contexto _context;

        public AvaliacaosController(Contexto context)
        {
            _context = context;
        }

        // GET: Avaliacaos
        public async Task<IActionResult> Index()
        {
            var contexto = _context.Avaliacao.Include(a => a.Disciplinas);
            return View(await contexto.ToListAsync());
        }

        // GET: Avaliacaos/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var avaliacao = await _context.Avaliacao
                .Include(a => a.Disciplinas)
                .FirstOrDefaultAsync(m => m.AvaliacaoId == id);
            if (avaliacao == null)
            {
                return NotFound();
            }

            return View(avaliacao);
        }

        public IActionResult VisualizarPDF()
        {
            return new ViewAsPdf("PDF", _context.Avaliacao.ToList()) { FileName = "relatorio.pdf"}  ;
        }

        // GET: Avaliacaos/Create
        public IActionResult Create()
        {
            //Disciplina
            ViewData["DisciplinaId"] = new SelectList(_context.Disciplina, "DisciplinaId", "NomeDisciplina");

            //Professores
            ViewBag.prof = _context.Professor.ToList();
            ViewData["ProfessorId"] = new SelectList(ViewBag.prof, "ProfessorId", "NomeProfessor");

            //Cursos
            //IEnumerable<object> curs = ViewBag.curso;
            ViewBag.curso = _context.Curso.ToList();            
            ViewData["CursoId"] = new SelectList(ViewBag.curso, "CursoId", "NomeCurso");

            
            return View();
        }

        // POST: Avaliacaos/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("AvaliacaoId,NomeAvaliador,ProfessorId,PeriodoAno,ValorProvaExp,ValorQuestExp,RefBibliograficas,PQuestMultdisc,Eqdistvquest,Ppquestcontext,Observacao,QtyQuestoes,Media,TotValor,DisciplinaId")] Avaliacao avaliacao)
        {
            if (ModelState.IsValid)
            {
                _context.Add(avaliacao);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }

            ViewData["ProfessorId"] = new SelectList(ViewBag.prof, "ProfessorId", "NomeProfessor", avaliacao.ProfessorId);

            ViewData["DisciplinaId"] = new SelectList(_context.Disciplina, "DisciplinaId", "NomeDisciplina", avaliacao.DisciplinaId);
            return View(avaliacao);
        }

        public JsonResult GetMembers(int id)
        {
            return Json(new SelectList(_context.Disciplina.Where(empt => (empt.CursoId == id)), "DisciplinaId", "NomeDisciplina"));
        }

        // GET: Avaliacaos/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var avaliacao = await _context.Avaliacao.FindAsync(id);
            if (avaliacao == null)
            {
                return NotFound();
            }
            ViewBag.curso = _context.Curso.ToList();
            ViewData["CursoId"] = new SelectList(ViewBag.curso, "CursoId", "NomeCurso");
            ViewBag.prof = _context.Professor.ToList();
            ViewData["ProfessorId"] = new SelectList(ViewBag.prof, "ProfessorId", "NomeProfessor", avaliacao.ProfessorId);
            ViewData["DisciplinaId"] = new SelectList(_context.Disciplina, "DisciplinaId", "NomeDisciplina", avaliacao.DisciplinaId);
            return View(avaliacao);
        }

        // POST: Avaliacaos/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("AvaliacaoId,NomeAvaliador,ProfessorId,PeriodoAno,ValorProvaExp,ValorQuestExp,RefBibliograficas,PQuestMultdisc,Eqdistvquest,Ppquestcontext,Observacao,QtyQuestoes,Media,TotValor,DisciplinaId")] Avaliacao avaliacao)
        {
            
            if (id != avaliacao.AvaliacaoId)
            {
                return NotFound();
            }
            
            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(avaliacao);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!AvaliacaoExists(avaliacao.AvaliacaoId))
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
            //ViewData["CursoId"] = new SelectList(ViewBag.curso, "CursoId", "NomeCurso");
            ViewData["ProfessorId"] = new SelectList(ViewBag.prof, "ProfessorId", "NomeProfessor", avaliacao.ProfessorId);
            ViewData["DisciplinaId"] = new SelectList(_context.Disciplina, "DisciplinaId", "NomeDisciplina", avaliacao.DisciplinaId);
            return View(avaliacao);
        }

        // GET: Avaliacaos/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var avaliacao = await _context.Avaliacao
                .Include(a => a.Disciplinas)
                .FirstOrDefaultAsync(m => m.AvaliacaoId == id);
            if (avaliacao == null)
            {
                return NotFound();
            }

            return View(avaliacao);
        }

        // POST: Avaliacaos/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var avaliacao = await _context.Avaliacao.FindAsync(id);
            _context.Avaliacao.Remove(avaliacao);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool AvaliacaoExists(int id)
        {
            return _context.Avaliacao.Any(e => e.AvaliacaoId == id);
        }
    }
}
