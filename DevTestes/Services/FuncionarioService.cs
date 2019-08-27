using DevTestes.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DevTestes.Services
{
    public class FuncionarioService
    {
        private readonly DevTestesContext _context;

        public FuncionarioService(DevTestesContext context)
        {
            _context = context;
        }

        public List<Funcionario> FindAll()
        {
            return _context.Funcionario.OrderBy(x => x.NomeFuncionario).ToList();
        }
    }
}
