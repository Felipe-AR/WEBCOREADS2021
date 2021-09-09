using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WEBCOREADS2021.Models.Dominio;

namespace WEBCOREADS2021.Models.Mapeamento
{
    public class InsumoAreaMap : IEntityTypeConfiguration<InsumoArea>
    {
        public void Configure(EntityTypeBuilder<InsumoArea> builder)
        {
            builder.HasKey(insumoArea => insumoArea.id);
            builder.Property(insumoArea => insumoArea.id).ValueGeneratedOnAdd();
            builder.Property(insumoArea => insumoArea.areaID).IsRequired();
            builder.Property(insumoArea => insumoArea.insumoID).IsRequired();
            builder.Property(insumoArea => insumoArea.data).HasColumnType("Date").IsRequired();
            builder.Property(insumoArea => insumoArea.quantidade).HasColumnType("Float").IsRequired();
            builder.Property(InsumoArea => InsumoArea.valor).HasColumnType("float").IsRequired();

            builder.HasOne(insumoArea => insumoArea.area).WithMany(insumo => insumo.insumos).HasForeignKey(insumoArea => insumoArea.id).OnDelete(DeleteBehavior.NoAction);
            builder.HasOne(insumoArea => insumoArea.insumo).WithMany(area => area.areasinsumo).HasForeignKey(InsumoArea => InsumoArea.insumoID).OnDelete(DeleteBehavior.NoAction);
            builder.ToTable("InsumosArea");
        }
    }
}
