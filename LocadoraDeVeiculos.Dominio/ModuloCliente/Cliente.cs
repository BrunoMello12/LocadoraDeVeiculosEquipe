using LocadoraDeVeiculos.Dominio.Compartilhado;
using LocadoraDeVeiculos.Dominio.ModuloCondutor;

namespace LocadoraDeVeiculos.Dominio.ModuloCliente
{
    public class Cliente : EntidadeBase<Cliente>
    {
        public string Nome { get; set; }

        public string Email { get; set; }

        public string Telefone { get; set; }

        public TipoClienteEnum TipoCliente { get; set; }

        public string Cpf { get; set; }

        public string Cnpj { get; set; }

        public string Estado { get; set; }

        public string Cidade { get; set; }

        public string Bairro { get; set; }

        public string Rua { get; set; }

        public int NumeroCasa { get; set; }

        public List<Condutor> Condutores { get; set; }

        public Cliente()
        {
            
        }

        public override void Atualizar(Cliente registro)
        {
            Nome = registro.Nome;
            Email = registro.Email;
            Telefone = registro.Telefone;
            TipoCliente = registro.TipoCliente;
            Cpf = registro.Cpf;
            Estado = registro.Estado;
            Cidade = registro.Cidade;
            Bairro = registro.Bairro;
            Rua = registro.Rua;
            NumeroCasa = registro.NumeroCasa;   
        }

        public override string ToString()
        {
            return Nome;
        }
    }
}
