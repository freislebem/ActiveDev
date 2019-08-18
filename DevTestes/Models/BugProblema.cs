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

        [Column("varchar(30)")]
        public string Funcionario { get; set; }

        [Display(Name ="Data complemento")]
        public DateTime DtaComplemento { get; set; }
        [Column("varchar(6)")]
        public string Chamado { get; set; }
        [Column("varchar(20)")]
        public string Sprint { get; set; }
        [Column("varchar(20)")]
        public string Produto { get; set; }
        public string Impacto { get; set; }
        public string Descricao { get; set; }
    }
}
