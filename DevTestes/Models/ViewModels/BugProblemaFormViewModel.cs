using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DevTestes.Models.ViewModels
{
    public class BugProblemaFormViewModel
    {
        public BugProblema BugProblema { get; set; }
        public ICollection<Funcionario> Funcionarios { get; set; }
        public ICollection<Sprint> Sprints { get; set; }
        public ICollection<Produto> Produtos { get; set; }
    }
}
