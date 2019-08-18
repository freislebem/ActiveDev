using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DevTestes.Models
{
    public class DevTestesContext: DbContext
    {
        public DevTestesContext(DbContextOptions<DevTestesContext> options) : base(options)
        {

        }

        public DbSet<BugProblema> BugProblemas { get; set; }
        public DbSet<Produto> Produtos { get; set; }
        public DbSet<Sprint> Sprints { get; set; }
    }
}
