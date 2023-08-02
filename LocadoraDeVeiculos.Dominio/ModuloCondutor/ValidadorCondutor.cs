using FluentValidation;

namespace LocadoraDeVeiculos.Dominio.ModuloCondutor
{
    public class ValidadorCondutor : AbstractValidator<Condutor>
    {
        public ValidadorCondutor()
        {
            RuleFor(x => x.Cliente)
                .NotNull()
                .NotEmpty();

            RuleFor(x => x.Email)
                .NotEmpty()
                .NotNull()
                .EmailAddress();

            RuleFor(x => x.Cpf)
                .NotEmpty()
                .NotNull()
                .Matches(@"^\d{3}\.\d{3}\.\d{3}-\d{2}$");

            RuleFor(x => x.Cnh)
                .NotNull() 
                .NotEmpty()
                .Matches(@"^\d{2}\.\d{3}\.\d{3}\/\d{4}-\d{2}$");

            RuleFor(x => x.Telefone)
                .NotNull()
                .NotEmpty()
                .Matches(@"^\(\d{2}\) \d{4,5}-\d{4}$");

            RuleFor(x => x.Validade)
                .NotEmpty()
                .NotNull();
        }
    }
}
