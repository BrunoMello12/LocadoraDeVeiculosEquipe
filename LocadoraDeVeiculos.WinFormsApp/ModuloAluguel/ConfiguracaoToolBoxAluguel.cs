using LocadoraDeVeiculos.WinFormsApp.Compartilhado;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LocadoraDeVeiculos.WinFormsApp.ModuloAluguel
{
    public class ConfiguracaoToolBoxAluguel : ConfiguracaoToolBoxBase
    {
        public override string TipoCadastro => "Cadastro de Aluguel";

        public override string TooltipInserir => "Inserir Aluguel";

        public override string TooltipEditar => "Editar Aluguel";

        public override string TooltipExcluir => "Excluir Aluguel";
    }
}
