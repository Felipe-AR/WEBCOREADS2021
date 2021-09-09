using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WEBCOREADS2021.Models.Dominio;

namespace WEBCOREADS2021.Models.Mapeamento
{
    public class AreaMap : IEntityTypeConfiguration<Area>
    {
        public void Configure(EntityTypeBuilder<Area> builder)
        {
            builder.HasKey(area => area.id);
            builder.Property(area => area.id).ValueGeneratedOnAdd();
            builder.Property(area => area.produtorID).IsRequired();
            builder.Property(area => area.hectares).HasColumnType("float").IsRequired();
            builder.Property(area => area.bairro).HasMaxLength(25).IsRequired();
            builder.Property(area => area.municipio).HasMaxLength(25).IsRequired();
            builder.Property(area => area.gps).HasColumnType("int");

            builder.HasOne(area => area.produtor).WithMany(agricultor => agricultor.areas).HasForeignKey(area => area.produtorID).OnDelete(DeleteBehavior.NoAction);
            builder.ToTable("Areas");
        }
    }
}
