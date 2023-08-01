using LocadoraDeVeiculos.Dominio.Compartilhado;
using LocadoraDeVeiculos.Dominio.ModuloAutomovel;
using LocadoraDeVeiculos.Dominio.ModuloCliente;
using LocadoraDeVeiculos.Dominio.ModuloCobranca;
using LocadoraDeVeiculos.Dominio.ModuloCondutor;
using LocadoraDeVeiculos.Dominio.ModuloCupom;
using LocadoraDeVeiculos.Dominio.ModuloFuncionario;
using LocadoraDeVeiculos.Dominio.ModuloGrupoAutomoveis;
using LocadoraDeVeiculos.Dominio.ModuloTaxasServicos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace LocadoraDeVeiculos.Dominio.ModuloAluguel
{
    public class Aluguel : EntidadeBase<Aluguel>
    {
        public Funcionario Funcionario { get; set; }
        public Cliente Cliente { get; set; }
        public GrupoAutomoveis GrupoAutomoveis { get; set; }
        public Cobranca Cobranca { get; set; }
        public Condutor Condutor { get; set; }
        public Automovel Automovel { get; set; }
        public decimal KmAutomovel { get; set; }
        public DateTime DataLocacao { get; set; }
        public DateTime DevolucaoPrevista { get; set; }
        public Cupom Cupom { get; set; }
        public decimal ValorTotalPrevisto { get; set; }
        public List<TaxasServicos> listaTaxasSelecionadas { get; set; }

        public Aluguel()
        {
        }

        public Aluguel(Funcionario funcionario, Cliente cliente, GrupoAutomoveis grupoAutomoveis, Cobranca cobranca, Condutor condutor, Automovel automovel, decimal kmAutomovel, DateTime dataLocacao, DateTime devolucaoPrevista, Cupom cupom, decimal valorTotalPrevisto)
        {
            Funcionario = funcionario;
            Cliente = cliente;
            GrupoAutomoveis = grupoAutomoveis;
            Cobranca = cobranca;
            Condutor = condutor;
            Automovel = automovel;
            KmAutomovel = kmAutomovel;
            DataLocacao = dataLocacao;
            DevolucaoPrevista = devolucaoPrevista;
            Cupom = cupom;
            ValorTotalPrevisto = valorTotalPrevisto;
        }

        public override void Atualizar(Aluguel registro)
        {
            Funcionario = registro.Funcionario;
            Cliente = registro.Cliente;
            GrupoAutomoveis = registro.GrupoAutomoveis;
            Cobranca = registro.Cobranca;
            Condutor = registro.Condutor;
            Automovel = registro.Automovel;
            KmAutomovel = registro.KmAutomovel;
            DataLocacao = registro.DataLocacao;
            DevolucaoPrevista = registro.DevolucaoPrevista;
            Cupom = registro.Cupom;
            ValorTotalPrevisto = registro.ValorTotalPrevisto;
            listaTaxasSelecionadas = registro.listaTaxasSelecionadas;
        }
    }
}
