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

        public Cliente(string nome, string email, string telefone, TipoClienteEnum tipoCliente, string cpf, string cnpj, string estado, string cidade, string bairro, string rua, int numeroCasa)
        {
            Nome = nome;
            Email = email;
            Telefone = telefone;
            TipoCliente = tipoCliente;
            Cpf = cpf;
            Cnpj = cnpj;
            Estado = estado;
            Cidade = cidade;
            Bairro = bairro;
            Rua = rua;
            NumeroCasa = numeroCasa;
        }

        public Cliente(string nome, string email, string telefone, TipoClienteEnum tipoCliente, string cpf, string estado, string cidade, string bairro, string rua, int numeroCasa)
        {
            Nome = nome;
            Email = email;
            Telefone = telefone;
            TipoCliente = tipoCliente;
            Cpf = cpf;
            Estado = estado;
            Cidade = cidade;
            Bairro = bairro;
            Rua = rua;
            NumeroCasa = numeroCasa;
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
    }
}
