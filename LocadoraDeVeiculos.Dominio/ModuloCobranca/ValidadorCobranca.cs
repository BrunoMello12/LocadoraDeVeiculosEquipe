using FluentValidation;
using System;

namespace LocadoraDeVeiculos.Dominio.ModuloCobranca
{
    public class ValidadorCobranca : AbstractValidator<Cobranca>, IValidadorCobranca
    {
        public ValidadorCobranca()
        {
            RuleFor(x => x.PrecoDiaria)
                .NotEmpty()
                .NotNull()
                .Must(BeDecimal)
                .WithMessage("O campo Preço Diaria deve conter apenas números válidos."); 

            RuleFor(x => x.TipoPlano)
                .Must(x => x != TipoPlanoEnum.Nenhum).WithMessage("Selecione um Plano de cobrança!");

            RuleFor(x => x.GrupoAutomoveis)
                .NotNull();
        }

        private bool BeDecimal(decimal value)
        {
            return decimal.TryParse(value.ToString(), out _);
        }
    }
}
