using LocadoraDeVeiculos.WinFormsApp.Compartilhado;

namespace LocadoraDeVeiculos.WinFormsApp.ModuloCliente
{
    public class ConfiguracaoToolBoxCliente : ConfiguracaoToolBoxBase
    {
        public override string TipoCadastro => "Cadastro de Clientes";

        public override string TooltipInserir => "Inserir Cliente";

        public override string TooltipEditar => "Editar Cliente";

        public override string TooltipExcluir => "Excluir Cliente";
    }
}
