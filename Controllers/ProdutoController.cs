using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using ProvaCSharp.Data;

namespace ProvaCSharp.Controllers
{
    public class ProdutoController : Controller
    {
        private readonly ProvaDbContext _context;
        public ProdutoController(ProvaDbContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public async Task<IActionResult> Delete(long? id)
        {
            if (id == null)
                return NotFound();

            var produto = await _context.Produtos.FirstOrDefaultAsync(x => x.Id == id);

            if (produto == null)
                return NotFound();

            return View(produto);
        }

        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(long? id)
        {
            var produto = await _context.Produtos.FirstOrDefaultAsync(x => x.Id == id);
            _context.Produtos.Remove(produto);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }
    }
}
