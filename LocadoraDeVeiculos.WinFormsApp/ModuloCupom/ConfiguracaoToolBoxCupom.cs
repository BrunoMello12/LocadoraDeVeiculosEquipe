using LocadoraDeVeiculos.WinFormsApp.Compartilhado;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LocadoraDeVeiculos.WinFormsApp.ModuloCupom
{
    public class ConfiguracaoToolBoxCupom : ConfiguracaoToolBoxBase
    {
        public override string TipoCadastro => "Cadastro de Cupom";

        public override string TooltipInserir => "Inserir Cupom";

        public override string TooltipEditar => "Editar Cupom";

        public override string TooltipExcluir => "Excluir Cupom";
    }
}
