using LocadoraDeVeiculos.Dominio.Compartilhado;

namespace LocadoraDeVeiculos.Dominio.ModuloCondutor
{
    public interface IRepositorioCondutor : IRepositorio<Condutor>
    {
        public Condutor SelecionarPorNome(string nome);
    }
}
