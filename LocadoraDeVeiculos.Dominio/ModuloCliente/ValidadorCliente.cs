using FluentValidation;
using LocadoraDeVeiculos.Dominio.ModuloFuncionario;

namespace LocadoraDeVeiculos.Dominio.ModuloCliente
{
    public class ValidadorCliente : AbstractValidator<Cliente>, IValidadorCliente
    {
        public ValidadorCliente()
        {
            RuleFor(x => x.Nome)
                      .NotEmpty()
                      .NotNull()
                      .MinimumLength(6);

            RuleFor(x => x.Email)
                      .NotEmpty()
                      .NotNull()
                      .EmailAddress();

            RuleFor(x => x.Telefone)
                      .NotEmpty()
                      .NotNull()
                      /*.Matches(@"^\(\d{2}\) \d{4,5}-\d{4}$")*/;

            RuleFor(x => x.Cpf)
                      .NotEmpty()
                      .NotNull()
                      /*.Matches(@"^\d{3}\.\d{3}\.\d{3}-\d{2}$")*/;

            RuleFor(x => x.Cnpj)
                      .NotEmpty()
                      .NotNull()
                      /*.Matches(@"^\d{2}\.\d{3}\.\d{3}\/\d{4}-\d{2}$")*/;

            RuleFor(x => x.Estado)
                      .NotEmpty()
                      .NotNull()
                      .Length(2);

            RuleFor(x => x.Cidade)
                      .NotEmpty()
                      .NotNull();

            RuleFor(x => x.Bairro)
                      .NotEmpty()
                      .NotNull();

            RuleFor(x => x.Rua)
                      .NotEmpty()
                      .NotNull();

            RuleFor(x => x.NumeroCasa)
                      .NotEmpty()
                      .NotNull();
        }
    }
}
