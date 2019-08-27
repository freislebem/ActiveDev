using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using DevTestes.Models.ViewModels;
using DevTestes.Models;
using DevTestes.Services;

namespace DevTestes.Controllers
{
    public class BugProblemaController : Controller
    {
        private readonly DevTestesContext _context;
        private readonly BugProblemaService _bugProblemaService;
        private readonly FuncionarioService _funcionarioService;
        private readonly SprintService _sprintService;
        private readonly ProdutoService _produtoService;
                
        public BugProblemaController(DevTestesContext context, FuncionarioService funcionarioService, SprintService sprintService, ProdutoService produtoService)
        {
            _context = context;
            _funcionarioService = funcionarioService;
            _sprintService = sprintService;
            _produtoService = produtoService;
        }

        // GET: BugProblema
        public async Task<IActionResult> Index()
        {
            return View(await _context.BugProblemas.ToListAsync());
        }

        // GET: BugProblema/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var bugProblema = await _context.BugProblemas
                .FirstOrDefaultAsync(m => m.BugProblemaId == id);
            if (bugProblema == null)
            {
                return NotFound();
            }

            return View(bugProblema);
        }

        // GET: BugProblema/Create
        public IActionResult Create()
        {
            var funcionarios = _funcionarioService.FindAll();
            var sprints = _sprintService.FindAll();
            var produtos = _produtoService.FindAll();

            var viewModel = new BugProblemaFormViewModel { Funcionarios = funcionarios, Sprints = sprints, Produtos = produtos};
            
            return View(viewModel);
        }

        // POST: BugProblema/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("BugProblemaId,Funcionario,DtaComplemento,Chamado,Sprint,Produto,Impacto,Descricao")] BugProblema bugProblema)
        {
            if (ModelState.IsValid)
            {
                _context.Add(bugProblema);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(bugProblema);
        }

        // GET: BugProblema/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var bugProblema = await _context.BugProblemas.FindAsync(id);
            if (bugProblema == null)
            {
                return NotFound();
            }
            return View(bugProblema);
        }

        // POST: BugProblema/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("BugProblemaId,Funcionario,DtaComplemento,Chamado,Sprint,Produto,Impacto,Descricao")] BugProblema bugProblema)
        {
            if (id != bugProblema.BugProblemaId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(bugProblema);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!BugProblemaExists(bugProblema.BugProblemaId))
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
            return View(bugProblema);
        }

        // GET: BugProblema/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var bugProblema = await _context.BugProblemas
                .FirstOrDefaultAsync(m => m.BugProblemaId == id);
            if (bugProblema == null)
            {
                return NotFound();
            }

            return View(bugProblema);
        }

        // POST: BugProblema/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var bugProblema = await _context.BugProblemas.FindAsync(id);
            _context.BugProblemas.Remove(bugProblema);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool BugProblemaExists(int id)
        {
            return _context.BugProblemas.Any(e => e.BugProblemaId == id);
        }
    }
}
