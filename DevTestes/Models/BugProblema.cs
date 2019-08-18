using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace DevTestes.Models
{
    public class BugProblema
    {
        [Key]
        public int BugProblemaId { get; set; }

        [Column(TypeName = "varchar(30)")]
        [Required(ErrorMessage ="Este campo é obrigatório!")]
        public string Funcionario { get; set; }

        [Display(Name ="Data complemento")]
        [Required(ErrorMessage ="Este campo é obrigatório!")]
        public DateTime DtaComplemento { get; set; }

        [Column(TypeName ="varchar(6)")]
        [Required(ErrorMessage ="Este campo é obrigatório!")]
        public string Chamado { get; set; }

        [Column(TypeName = "varchar(20)")]
        [Required(ErrorMessage ="Este campo é obrigatório!")]
        public string Sprint { get; set; }

        [Column(TypeName = "varchar(20)")]
        public string Produto { get; set; }

        [Column(TypeName ="varchar(10)")]
        public string Impacto { get; set; }

        [Required(ErrorMessage ="Este campo é obrigatório!")]
        public string Descricao { get; set; }
    }
}
