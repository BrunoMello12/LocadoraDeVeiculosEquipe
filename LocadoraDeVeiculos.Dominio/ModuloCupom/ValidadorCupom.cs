using FluentValidation;
using LocadoraDeVeiculos.Dominio.Compartilhado;
using System;

namespace LocadoraDeVeiculos.Dominio.ModuloCupom
{
    public class ValidadorCupom : AbstractValidator<Cupom>, IValidadorCupom
    {
        public ValidadorCupom()
        {
            RuleFor(x => x.Nome)
                .NotEmpty()
                .NotNull()
                .MinimumLength(3)
                .NaoPodeCaracteresEspeciais();

            RuleFor(x => x.Valor)
                .NotEmpty()
                .NotNull()
                .Must(BeDecimal)
                .WithMessage("O campo Valor deve conter apenas números válidos.");

            RuleFor(x => x.DataValidade)
                .NotNull()
                .NotEmpty();

            RuleFor(x => x.Parceiro)
                .NotNull()
                .NotEmpty();
        }

        private bool BeDecimal(decimal value)
        {
            return decimal.TryParse(value.ToString(), out _);
        }
    }
}
