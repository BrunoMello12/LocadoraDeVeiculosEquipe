using LocadoraDeVeiculos.Dominio.Compartilhado;
using LocadoraDeVeiculos.Dominio.ModuloParceiro;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LocadoraDeVeiculos.Dominio.ModuloCupom
{
    public class Cupom : EntidadeBase<Cupom>
    {
        public string Nome { get; set; }

        public decimal Valor { get; set; }

        public DateTime DataValidade { get; set; }

        public Parceiro Parceiro { get; set; }

        public Cupom()
        {
            
        }

        public override void Atualizar(Cupom registro)
        {
            Nome = registro.Nome;
            Valor = registro.Valor;
            DataValidade = registro.DataValidade;
            Parceiro = registro.Parceiro;
        }
    }
}
