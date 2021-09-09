using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WEBCOREADS2021.Models.Dominio;

namespace WEBCOREADS2021.Models.Mapeamento
{
    public class AgricultorMap : IEntityTypeConfiguration<Agricultor>
    {
        public void Configure(EntityTypeBuilder<Agricultor> builder)
        {
            builder.HasKey(agricultor => agricultor.id);
            builder.Property(agricultor => agricultor.id).ValueGeneratedOnAdd();
            builder.Property(agricultor => agricultor.proprietario).HasMaxLength(35).IsRequired();
            builder.Property(agricultor => agricultor.bairro).HasMaxLength(25).IsRequired();
            builder.Property(agricultor => agricultor.municipio).HasMaxLength(25).IsRequired();
            builder.Property(agricultor => agricultor.idade).HasColumnType("Int").IsRequired();
            builder.Property(agricultor => agricultor.email).HasMaxLength(35).IsRequired();
            builder.Property(agricultor => agricultor.cpf).HasMaxLength(14).IsRequired();
            builder.HasIndex(agricultor => agricultor.cpf).IsUnique();

            builder.HasMany(agricultor => agricultor.areas).WithOne(area => area.produtor).HasForeignKey(area => area.produtorID).OnDelete(DeleteBehavior.NoAction);
            builder.ToTable("Agricultores");
        }
    }
}
