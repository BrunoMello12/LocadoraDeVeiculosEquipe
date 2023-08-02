using LocadoraDeVeiculos.Dominio.Compartilhado;
using LocadoraDeVeiculos.Dominio.ModuloFuncionario;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LocadoraDeVeiculos.Dominio.ModuloTaxasServicos
{
    public class TaxasServicos : EntidadeBase<TaxasServicos>
    {
        public string Nome { get; set; }
        public decimal Preco { get; set; }

        public TaxasServicos()
        {
        }

        public TaxasServicos(string nome, decimal preco)
        {
            Nome = nome;
            Preco = preco;
        }

        public override void Atualizar(TaxasServicos registro)
        {
            Nome = registro.Nome;
            Preco = registro.Preco;
        }
    }
}
