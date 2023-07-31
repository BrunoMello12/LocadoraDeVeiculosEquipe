using LocadoraDeVeiculos.Dominio.ModuloAutomovel;
using LocadoraDeVeiculos.Dominio.ModuloFuncionario;
using LocadoraDeVeiculos.Infra.Orm.Compartilhado;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LocadoraDeVeiculos.Infra.Orm.ModuloAutomovel
{
    public class RepositorioAutomovelEmOrm : RepositorioBaseEmOrm<Automovel>, IRepositorioAutomovel
    {
        public RepositorioAutomovelEmOrm(LocadoraDeVeiculosDbContext dbContext) : base(dbContext)
        {
        }

        public Automovel SelecionarPorId(int id, bool incluirGrupoDoAutomovel = false)
        {
            if (incluirGrupoDoAutomovel)
                return registros
                    .Include(x => x.GrupoDoAutomovel)
                    .FirstOrDefault(x => x.Id == id);

            return registros.Find(id);
        }
    }
}
