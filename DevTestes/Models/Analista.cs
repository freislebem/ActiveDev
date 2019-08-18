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
        [Key]
        public int AnalistaId { get; set; }

        [Display(Name ="Funcionário")]
        [Required(ErrorMessage ="Este campo é obrigatório!")]
        [Column("varchar(30)")]
        public string NomeFuncionario { get; set; }
    }
}
