using LocadoraDeVeiculos.WinFormsApp.Compartilhado;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LocadoraDeVeiculos.WinFormsApp.ModuloGrupoAutomoveis
{
    public class ConfiguracaoToolBoxGrupoAutomoveis : ConfiguracaoToolBoxBase
    {
        public override string TipoCadastro => "Cadastro de Grupo de Automóveis";

        public override string TooltipInserir => "Inserir novo Grupo de Automóveis";

        public override string TooltipEditar => "Editar um Grupo de Automóveis";

        public override string TooltipExcluir => "Excluir um Grupo de Automóveis";
    }
}
