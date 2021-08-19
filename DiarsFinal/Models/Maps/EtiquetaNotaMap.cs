using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DiarsFinal.Models.Maps
{
    public class EtiquetaNotaMap : IEntityTypeConfiguration<EtiquetaNota>
    {
        public void Configure(EntityTypeBuilder<EtiquetaNota> builder)
        {
            builder.ToTable("EtiquetaNota");
            builder.HasKey(o => o.idEtiquetaNota);


            builder.HasOne(o => o.etiqueta).WithMany().HasForeignKey(o => o.idEtiqueta);
            builder.HasOne(o => o.nota).WithMany().HasForeignKey(o => o.idNota);

        }
    }
}
