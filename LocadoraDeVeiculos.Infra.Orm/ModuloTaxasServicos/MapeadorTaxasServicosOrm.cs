using LocadoraDeVeiculos.Dominio.ModuloFuncionario;
using LocadoraDeVeiculos.Dominio.ModuloTaxasServicos;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LocadoraDeVeiculos.Infra.Orm.ModuloTaxasServicos
{
    public class MapeadorTaxasServicosOrm : IEntityTypeConfiguration<TaxasServicos>
    {
        public void Configure(EntityTypeBuilder<TaxasServicos> builder)
        {
            builder.ToTable("TBFuncionario");

            builder.Property(x => x.Id).IsRequired().ValueGeneratedOnAdd();

            builder.Property(x => x.Nome).HasColumnType("varchar(MAX)").IsRequired();

            builder.Property(x => x.Preco).IsRequired();
        }
    }
}
