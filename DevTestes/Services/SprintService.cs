using DevTestes.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DevTestes.Services
{
    public class SprintService
    {
        private readonly DevTestesContext _context;

        public SprintService(DevTestesContext context)
        {
            _context = context;
        }

        public List<Sprint> FindAll()
        {
            return _context.Sprints.OrderBy(x => x.NomeSprint).ToList();
        }
    }
}
