using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LocadoraDeVeiculos.Dominio.Compartilhado
{
    public interface IValidator<T> where T : EntidadeBase<T>
    {
        public ValidationResult Validate(T instance);
    }
}
