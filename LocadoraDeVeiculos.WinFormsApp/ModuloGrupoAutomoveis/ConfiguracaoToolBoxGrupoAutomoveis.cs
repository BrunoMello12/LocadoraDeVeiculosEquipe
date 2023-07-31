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
        public override string TipoCadastro => "Cadastro de Disciplinas";

        public override string TooltipInserir => "Inserir nova Disciplina";

        public override string TooltipEditar => "Editar uma Disciplina existente";

        public override string TooltipExcluir => "Excluir uma Disciplina existente";
    }
}
