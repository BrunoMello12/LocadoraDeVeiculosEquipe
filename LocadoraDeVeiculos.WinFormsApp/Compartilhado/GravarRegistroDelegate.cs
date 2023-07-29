using FluentResults;
using LocadoraDeVeiculos.Dominio.Compartilhado;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LocadoraDeVeiculos.WinFormsApp.Compartilhado
{
    public delegate Result GravarRegistroDelegate<TEntidade>(TEntidade disciplina)
         where TEntidade : EntidadeBase<TEntidade>;
}
