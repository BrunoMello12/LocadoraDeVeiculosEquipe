using LocadoraDeVeiculos.Dominio.Compartilhado;
using LocadoraDeVeiculos.Dominio.ModuloCondutor;

namespace LocadoraDeVeiculos.Dominio.ModuloCupom
{
    public interface IRepositorioCupom : IRepositorio<Cupom>
    {
        public Cupom SelecionarPorNome(string nome);
    }
}
