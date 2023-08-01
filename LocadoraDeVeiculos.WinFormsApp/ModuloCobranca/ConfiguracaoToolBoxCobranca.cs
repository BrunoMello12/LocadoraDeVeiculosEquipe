using LocadoraDeVeiculos.WinFormsApp.Compartilhado;

namespace LocadoraDeVeiculos.WinFormsApp.ModuloCobranca
{
    public class ConfiguracaoToolBoxCobranca : ConfiguracaoToolBoxBase
    {
        public override string TipoCadastro => "Cadastro de Planos de Cobrança";

        public override string TooltipInserir => "Inserir Plano de Cobrança";

        public override string TooltipEditar => "Editar Plano de Cobrança";

        public override string TooltipExcluir => "Excluir Plano de Cobrança";
    }
}
