using DiarsFinal.Models.Maps;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DiarsFinal.Models
{
    public class DiarsContext:DbContext
    {
        public DiarsContext(DbContextOptions<DiarsContext> options):base(options)
        {
                
        }

        public DbSet<Nota> Notas { get; set; }
        public DbSet<Etiqueta> Etiquetas { get; set; }
        public DbSet<EtiquetaNota> EtiquetaNotas { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.ApplyConfiguration(new NotaMap());
            modelBuilder.ApplyConfiguration(new EtiquetaMap());
            modelBuilder.ApplyConfiguration(new EtiquetaNotaMap());
        }
    }
}
