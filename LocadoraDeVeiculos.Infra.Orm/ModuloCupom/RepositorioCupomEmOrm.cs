using LocadoraDeVeiculos.Dominio.ModuloCupom;
using LocadoraDeVeiculos.Infra.Orm.Compartilhado;

namespace LocadoraDeVeiculos.Infra.Orm.ModuloCupom
{
    public class RepositorioCupomEmOrm : RepositorioBaseEmOrm<Cupom>
    {
        public RepositorioCupomEmOrm(LocadoraDeVeiculosDbContext dbContext) : base(dbContext)
        {
        }

        public Cupom SelecionarPorNome(string nome)
        {
            return registros.FirstOrDefault(x => x.Nome == nome);
        }
    }
}
