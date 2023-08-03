using LocadoraDeVeiculos.Dominio.ModuloCliente;
using LocadoraDeVeiculos.Dominio.ModuloPrecos;
using LocadoraDeVeiculos.WinFormsApp.Compartilhado;

namespace LocadoraDeVeiculos.WinFormsApp.ModuloPrecos
{
    public partial class TelaPrecosForm : Form
    {
        private Precos precos;
        public event GravarRegistroDelegate<Precos> onGravarRegistro;

        public TelaPrecosForm(Precos registro)
        {
            InitializeComponent();
            this.ConfigurarDialog();
            this.precos = registro;
        }

        public Precos ObterPrecos()
        {
            precos.Gasolina = Convert.ToInt32(txtGasolina.Text);
            precos.Gas = Convert.ToInt32(txtGas.Text);
            precos.Diesel = Convert.ToInt32(txtDiesel.Text);
            precos.Alcool = Convert.ToInt32(txtAlcool.Text);

            return precos;
        }

        public void ConfigurarPrecos(Precos precos)
        {
            txtGasolina.Text = precos.Gasolina.ToString();
            txtGas.Text = precos.Gas.ToString();
            txtDiesel.Text = precos.Diesel.ToString();
            txtAlcool.Text = precos.Alcool.ToString();
        }
    }
}
