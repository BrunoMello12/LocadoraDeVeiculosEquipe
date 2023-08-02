using LocadoraDeVeiculos.Dominio.ModuloPrecos;
using LocadoraDeVeiculos.Infra.Orm.Compartilhado;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LocadoraDeVeiculos.Infra.Orm.ModuloPrecos
{
    public class RepositorioPrecoEmOrm : RepositorioBaseEmOrm<Precos>, IRepositorioPrecos
    {
        public RepositorioPrecoEmOrm(LocadoraDeVeiculosDbContext dbContext) : base(dbContext)
        {
        }
    }
}
