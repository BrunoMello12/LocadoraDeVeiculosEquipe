using LocadoraDeVeiculos.WinFormsApp.Compartilhado;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LocadoraDeVeiculos.WinFormsApp.ModuloFuncionario
{
    public class ConfiguracaoToolBoxFuncionario : ConfiguracaoToolBoxBase
    {
        public override string TipoCadastro => "Cadastro de Funcionario";

        public override string TooltipInserir => "Inserir Funcionario";

        public override string TooltipEditar => "Editar Funcionario";

        public override string TooltipExcluir => "Excluir Funcionario";
    }
}
