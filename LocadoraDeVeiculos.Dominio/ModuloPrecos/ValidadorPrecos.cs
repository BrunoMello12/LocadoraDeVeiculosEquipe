﻿using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LocadoraDeVeiculos.Dominio.ModuloPrecos
{
    public class ValidadorPrecos : AbstractValidator<Precos>, IValidator<Precos>
    {
    }
}
