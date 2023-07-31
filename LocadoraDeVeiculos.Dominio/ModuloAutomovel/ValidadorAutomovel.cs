using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace LocadoraDeVeiculos.Dominio.ModuloAutomovel
{
    public class ValidadorAutomovel : AbstractValidator<Automovel>
    {
        public ValidadorAutomovel()
        {
            RuleFor(x => x.GrupoDoAutomovel)
                .NotNull().NotEmpty();

            RuleFor(x => x.Modelo)
                    .NotNull().NotEmpty();

            RuleFor(x => x.Marca)
                    .NotNull().NotEmpty();

            RuleFor(x => x.Cor)
                    .NotNull().NotEmpty();

            RuleFor(x => x.TipoCombustivel)
                    .NotNull().NotEmpty();

            RuleFor(x => x.CapacidadeLitros)
                    .NotNull().NotEmpty();
        }
    }
}
