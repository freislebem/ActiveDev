﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace DevTestes.Models
{
    public class Sprint
    {
        [Key]
        public int Id { get; set; }

        [Display(Name ="Nome da sprint")]
        [Required(ErrorMessage ="Este campo é obrigatório!")]
        [Column("varchar(20)")]
        public string NomeSprint { get; set; }

        public int BugProblemaId { get; set; }
        public BugProblema BugProblema { get; set; }
    }
}
