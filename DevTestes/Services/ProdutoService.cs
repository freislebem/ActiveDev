using DevTestes.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DevTestes.Services
{
    public class ProdutoService
    {
        private readonly DevTestesContext _context;

        public ProdutoService(DevTestesContext context)
        {
            _context = context;
        }

        public List<Produto> FindAll()
        {
            return _context.Produtos.OrderBy(x => x.NomeProduto).ToList();
        }
    }
}
