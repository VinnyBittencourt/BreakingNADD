using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using NADD.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NADD.Mapeamento
{
    public class AreaMap : IEntityTypeConfiguration<Area>
    {

            public void Configure(EntityTypeBuilder<Area> builder)
            {
                //Atributos/Colunas da tabela
                builder.HasKey(d => d.AreaId);
                builder.Property(d => d.NomeArea).IsRequired();
                builder.HasIndex(d => d.NomeArea).IsUnique();

                //Relacionamento
            builder.HasMany(tc => tc.Curso).WithOne(tc => tc.Area).OnDelete(DeleteBehavior.Cascade);

                builder.ToTable("Area");
            }
        
    }
}
