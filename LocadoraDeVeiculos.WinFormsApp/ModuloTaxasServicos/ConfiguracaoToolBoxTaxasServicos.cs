using LocadoraDeVeiculos.WinFormsApp.Compartilhado;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LocadoraDeVeiculos.WinFormsApp.ModuloTaxasServicos
{
    public class ConfiguracaoToolBoxTaxasServicos : ConfiguracaoToolBoxBase
    {
        public override string TipoCadastro => "Cadastro de Serviço";

        public override string TooltipInserir => "Inserir Serviço";

        public override string TooltipEditar => "Editar Serviço";

        public override string TooltipExcluir => "Excluir Serviço";
    }
}
