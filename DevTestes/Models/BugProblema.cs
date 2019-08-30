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
        
        public int Id { get; set; }

        public int FuncionarioId { get; set; }
        public Funcionario Funcionario { get; set; }
                                
        [Display(Name = "Data complemento")]
        [Required(ErrorMessage = "Este campo é obrigatório!")]
        [DataType(DataType.Date)]
        public DateTime DtaComplemento { get; set; }

        [Column(TypeName = "varchar(6)")]
        [Required(ErrorMessage = "Este campo é obrigatório!")]
        [Range(1, 99999)]
        [DataType(DataType.Currency)]
        public string Chamado { get; set; }

        //[Column(TypeName = "varchar(20)")]
        //[Required(ErrorMessage ="Este campo é obrigatório!")]
        public int SprintId { get; set; }
        public Sprint Sprint { get; set; }

        public int ProdutoId { get; set; }
        public Produto Produto { get; set; }
        
        [Column(TypeName ="varchar(10)")]
        public string Impacto { get; set; }

        [Required(ErrorMessage ="Este campo é obrigatório!")]
        public string Descricao { get; set; }

        
    }
}
