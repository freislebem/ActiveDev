using DevTestes.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DevTestes.Services
{
    public class BugProblemaService
    {
        private readonly DevTestesContext _context;

        public BugProblemaService(DevTestesContext context)
        {
            _context = context;
        }

        public List<BugProblema> FindAll()
        {
            return _context.BugProblemas.ToList();
        }
    }
}
