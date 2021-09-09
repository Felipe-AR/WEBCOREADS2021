using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WEBCOREADS2021.Models.Dominio;

namespace WEBCOREADS2021.Models.Mapeamento
{
    public class InsumoMap : IEntityTypeConfiguration<Insumo>
    {
        public void Configure(EntityTypeBuilder<Insumo> builder)
        {
            builder.HasKey(insumo => insumo.id);
            builder.Property(insumo => insumo.id).ValueGeneratedOnAdd();
            builder.Property(insumo => insumo.descricao).HasMaxLength(35).IsRequired();
            builder.Property(insumo => insumo.tipoInsumo).IsRequired();
            builder.Property(insumo => insumo.quantidade).HasColumnType("float").IsRequired();
            builder.Property(insumo => insumo.valor).HasColumnType("float").IsRequired();

            builder.HasMany(insumo => insumo.areasinsumo).WithOne(insumoArea => insumoArea.insumo).HasForeignKey(insumoArea => insumoArea.insumoID).OnDelete(DeleteBehavior.NoAction);
            builder.ToTable("Insumos");
        }
    }
}
