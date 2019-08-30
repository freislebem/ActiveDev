using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace DevTestes.Models
{
    public class Funcionario
    {
        
        public int Id { get; set; }

        [Display(Name ="Funcionário")]
        [Required(ErrorMessage ="Este campo é obrigatório!")]
        [Column("varchar(30)")]
        public string NomeFuncionario { get; set; }

        public int BugProblemaId { get; set; }
        public BugProblema BugProblema { get; set; }
                
    }
}
