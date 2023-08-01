using FluentValidation;
using LocadoraDeVeiculos.Dominio.ModuloAutomovel;
using LocadoraDeVeiculos.Dominio.ModuloCliente;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LocadoraDeVeiculos.Dominio.ModuloAluguel
{
    public class ValidadorAluguel : AbstractValidator<Aluguel>
    {
        public ValidadorAluguel()
        {
            RuleFor(x => x.Condutor)
                .NotNull().NotEmpty();

            RuleFor(x => x.GrupoAutomoveis)
                .NotNull().NotEmpty(); 

            RuleFor(x => x.Cobranca)
                .NotNull().NotEmpty(); 

            RuleFor(x => x.Automovel)
                .NotEmpty().NotEmpty();

            RuleFor(x => x.DataLocacao)
                .NotNull().NotEmpty();

            RuleFor(x => x.DevolucaoPrevista)
                .NotEmpty().NotEmpty();
        }

        //public void ClienteJuridicoDevePossuirCondutorPF(Cliente cliente)
        //{
        //    if(cliente.TipoCliente == TipoClienteEnum.PessoaJuridica && cliente)
        //    {

        //    }
        //}
    }
}
