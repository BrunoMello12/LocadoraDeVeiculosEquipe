using LocadoraDeVeiculos.Aplicacao.ModuloAluguel;
using LocadoraDeVeiculos.Aplicacao.ModuloAutomovel;
using LocadoraDeVeiculos.Aplicacao.ModuloCliente;
using LocadoraDeVeiculos.Aplicacao.ModuloCobranca;
using LocadoraDeVeiculos.Aplicacao.ModuloCondutor;
using LocadoraDeVeiculos.Aplicacao.ModuloCupom;
using LocadoraDeVeiculos.Aplicacao.ModuloFuncionario;
using LocadoraDeVeiculos.Aplicacao.ModuloGrupoAutomoveis;
using LocadoraDeVeiculos.Aplicacao.ModuloParceiro;
using LocadoraDeVeiculos.Aplicacao.ModuloTaxasServicos;
using LocadoraDeVeiculos.Dominio.ModuloAluguel;
using LocadoraDeVeiculos.Dominio.ModuloAutomovel;
using LocadoraDeVeiculos.Dominio.ModuloCliente;
using LocadoraDeVeiculos.Dominio.ModuloCobranca;
using LocadoraDeVeiculos.Dominio.ModuloCondutor;
using LocadoraDeVeiculos.Dominio.ModuloCupom;
using LocadoraDeVeiculos.Dominio.ModuloFuncionario;
using LocadoraDeVeiculos.Dominio.ModuloGrupoAutomoveis;
using LocadoraDeVeiculos.Dominio.ModuloParceiro;
using LocadoraDeVeiculos.Dominio.ModuloTaxasServicos;
using LocadoraDeVeiculos.Infra.Json.ModuloPrecos;
using LocadoraDeVeiculos.Infra.Json.Serializadores;
using LocadoraDeVeiculos.Infra.Orm.Compartilhado;
using LocadoraDeVeiculos.Infra.Orm.ModuloAluguel;
using LocadoraDeVeiculos.Infra.Orm.ModuloAutomovel;
using LocadoraDeVeiculos.Infra.Orm.ModuloCliente;
using LocadoraDeVeiculos.Infra.Orm.ModuloCobranca;
using LocadoraDeVeiculos.Infra.Orm.ModuloCondutor;
using LocadoraDeVeiculos.Infra.Orm.ModuloCupom;
using LocadoraDeVeiculos.Infra.Orm.ModuloFuncionario;
using LocadoraDeVeiculos.Infra.Orm.ModuloGrupoAutomoveis;
using LocadoraDeVeiculos.Infra.Orm.ModuloParceiro;
using LocadoraDeVeiculos.Infra.Orm.ModuloTaxasServicos;
using LocadoraDeVeiculos.WinFormsApp.Compartilhado;
using LocadoraDeVeiculos.WinFormsApp.ModuloAluguel;
using LocadoraDeVeiculos.WinFormsApp.ModuloAutomovel;
using LocadoraDeVeiculos.WinFormsApp.ModuloCliente;
using LocadoraDeVeiculos.WinFormsApp.ModuloCobranca;
using LocadoraDeVeiculos.WinFormsApp.ModuloCondutor;
using LocadoraDeVeiculos.WinFormsApp.ModuloCupom;
using LocadoraDeVeiculos.WinFormsApp.ModuloFuncionario;
using LocadoraDeVeiculos.WinFormsApp.ModuloGrupoAutomoveis;
using LocadoraDeVeiculos.WinFormsApp.ModuloParceiro;
using LocadoraDeVeiculos.WinFormsApp.ModuloTaxasServicos;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;

namespace LocadoraDeVeiculos.WinFormsApp
{
    public partial class TelaPrincipalForm : Form
    {
        private Dictionary<string, ControladorBase> controladores;
        private ControladorBase controlador;

        public TelaPrincipalForm()
        {

            InitializeComponent();

            Instancia = this;

            labelRodape.Text = string.Empty;
            lblTipoCadastro.Text = string.Empty;

            controladores = new Dictionary<string, ControladorBase>();

            ConfigurarControladores();
        }

        public static TelaPrincipalForm Instancia
        {
            get;
            private set;
        }

        private void ConfigurarControladores()
        {

            var configuracao = new ConfigurationBuilder()
               .SetBasePath(Directory.GetCurrentDirectory())
               .AddJsonFile("appsettings.json")
               .Build();

            var connectionString = configuracao.GetConnectionString("SqlServer");

            var optionsBuilder = new DbContextOptionsBuilder<LocadoraDeVeiculosDbContext>();

            optionsBuilder.UseSqlServer(connectionString);

            var dbContext = new LocadoraDeVeiculosDbContext(optionsBuilder.Options);

            var migracoesPendentes = dbContext.Database.GetPendingMigrations();

            if (migracoesPendentes.Count() > 0)
            {
                dbContext.Database.Migrate();
            }

            //Cliente
            IRepositorioCliente repositorioCliente = new RepositorioClienteEmOrm(dbContext);
            ValidadorCliente validadorCliente = new ValidadorCliente();
            ServicoCliente servicoCliente = new ServicoCliente(repositorioCliente, validadorCliente);
            controladores.Add("ControladorCliente", new ControladorCliente(repositorioCliente, servicoCliente));

            //Funcionario
            IRepositorioFuncionario repositorioFuncionario = new RepositorioFuncionarioEmOrm(dbContext);
            ValidadorFuncionario validadorFuncionario = new ValidadorFuncionario();
            ServicoFuncionario servicoFuncionario = new ServicoFuncionario(repositorioFuncionario, validadorFuncionario);
            controladores.Add("ControladorFuncionario", new ControladorFuncionario(repositorioFuncionario, servicoFuncionario));

            //grupo Automoveis
            IRepositorioGrupoAutomoveis repositorioGrupoAutomoveis = new RepositorioGrupoAutomoveisEmOrm(dbContext);
            ValidadorGrupoAutomoveis validadorGrupoAutomoveis = new ValidadorGrupoAutomoveis();
            ServicoGrupoAutomoveis servicoGrupoAutomoveis = new ServicoGrupoAutomoveis(repositorioGrupoAutomoveis, validadorGrupoAutomoveis);
            controladores.Add("ControladorGrupoAutomoveis", new ControladorGrupoAutomoveis(servicoGrupoAutomoveis, repositorioGrupoAutomoveis));

            //cobranca
            IRepositorioCobranca repositorioCobranca = new RepositorioCobrancaEmOrm(dbContext);
            ValidadorCobranca validadorCobranca = new ValidadorCobranca();
            ServicoCobranca servicoCobranca = new ServicoCobranca(repositorioCobranca, validadorCobranca);
            controladores.Add("ControladorCobranca", new ControladorCobranca(servicoCobranca, repositorioCobranca, repositorioGrupoAutomoveis));

            //automovel
            IRepositorioAutomovel repositorioAutomovel = new RepositorioAutomovelEmOrm(dbContext);
            ValidadorAutomovel validadorAutovel = new ValidadorAutomovel();
            ServicoAutomovel servicoAutomovel = new ServicoAutomovel(repositorioAutomovel, validadorAutovel);

            SerializadorDadosEmJson serializadorDadosEmJson = new SerializadorDadosEmJson();
            ContextoDadosPrecos contextoDados = new ContextoDadosPrecos(serializadorDadosEmJson);
            RepositorioPrecosJson repositorioPrecosJson = new RepositorioPrecosJson(contextoDados);
            controladores.Add("ControladorAutomovel", new ControladorAutomovel(repositorioAutomovel, repositorioGrupoAutomoveis, servicoAutomovel, repositorioPrecosJson));

            //parceiro
            IRepositorioParceiro repositorioParceiro = new RepositorioParceiroEmOrm(dbContext);
            ValidadorParceiro validadorParceiro = new ValidadorParceiro();
            ServicoParceiro servicoParceiro = new ServicoParceiro(repositorioParceiro, validadorParceiro);
            controladores.Add("ControladorParceiro", new ControladorParceiro(repositorioParceiro, servicoParceiro));

            //cupom
            IRepositorioCupom repositorioCupom = new RepositorioCupomEmOrm(dbContext);
            ValidadorCupom validadorcupom = new ValidadorCupom();
            ServicoCupom servicoCupom = new ServicoCupom(repositorioCupom, validadorcupom);
            controladores.Add("ControladorCupom", new ControladorCupom(servicoCupom, repositorioCupom, repositorioParceiro));

            //condutor
            IRepositorioCondutor repositorioCondutor = new RepositorioCondutorEmOrm(dbContext);
            ValidadorCondutor validadorCondutor = new ValidadorCondutor();
            ServicoCondutor servicoCondutor = new ServicoCondutor(repositorioCondutor, validadorCondutor);
            controladores.Add("ControladorCondutor", new ControladorCondutor(repositorioCondutor, servicoCondutor, repositorioCliente));

            //taxas e servicos
            IRepositorioTaxasServicos repositorioTaxasServicos = new RepositorioTaxasServicosEmOrm(dbContext);
            ValidadorTaxasServicos validadorTaxasServicos = new ValidadorTaxasServicos();
            ServicoTaxasServicos servicoTaxasServicos = new ServicoTaxasServicos(repositorioTaxasServicos, validadorTaxasServicos);
            controladores.Add("ControladorTaxasServicos", new ControladorTaxasServicos(repositorioTaxasServicos, servicoTaxasServicos));

            //Aluguel
            IRepositorioAluguel repositorioAluguel = new RepositorioAluguelEmOrm(dbContext);
            ValidadorAluguel validadorAluguel = new ValidadorAluguel();
            ServicoAluguel servicoAluguel = new ServicoAluguel();
            //RepositorioPrecosJson repositorioPrecosJson = new RepositorioPrecosJson(new ContextoDadosPrecos());
            controladores.Add("ControladorAluguel", new ControladorAluguel(repositorioPrecosJson, repositorioAluguel));

        }

        public void AtualizarRodape()
        {
            string mensagemRodape = controlador.ObterMensagemRodape();

            AtualizarRodape(mensagemRodape);
        }

        public void AtualizarRodape(string mensagem)
        {
            labelRodape.Text = mensagem;
        }

        private void ConfigurarBotoes(ConfiguracaoToolBoxBase configuracao)
        {
            btnAdicionar.Enabled = configuracao.InserirHabilitado;
            btnEditar.Enabled = configuracao.EditarHabilitado;
            btnExcluir.Enabled = configuracao.ExcluirHabilitado;
        }

        private void ConfigurarTooltips(ConfiguracaoToolBoxBase configuracao)
        {
            btnAdicionar.ToolTipText = configuracao.TooltipInserir;
            btnEditar.ToolTipText = configuracao.TooltipEditar;
            btnExcluir.ToolTipText = configuracao.TooltipExcluir;
        }

        private void ConfigurarTelaPrincipal(ControladorBase controlador)
        {
            this.controlador = controlador;

            ConfigurarToolbox();

            ConfigurarListagem();

            string mensagemRodape = controlador.ObterMensagemRodape();

            AtualizarRodape(mensagemRodape);
        }

        private void ConfigurarToolbox()
        {
            ConfiguracaoToolBoxBase configuracao = controlador.ObtemConfiguracaoToolbox();

            if (configuracao != null)
            {
                toolBox.Enabled = true;

                lblTipoCadastro.Text = configuracao.TipoCadastro;

                ConfigurarTooltips(configuracao);

                ConfigurarBotoes(configuracao);
            }
        }

        private void ConfigurarListagem()
        {
            AtualizarRodape("");

            var listagemControl = controlador.ObtemListagem();

            panelRegistros.Controls.Clear();

            listagemControl.Dock = DockStyle.Fill;

            panelRegistros.Controls.Add(listagemControl);
        }

        private void btnAdicionar_Click(object sender, EventArgs e)
        {
            controlador.Inserir();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            controlador.Editar();
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            controlador.Excluir();
        }

        private void btnPrecos_Click(object sender, EventArgs e)
        {
            controlador.Precos();
        }

        private void funcionárioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ConfigurarTelaPrincipal(controladores["ControladorFuncionario"]);
        }

        private void taxasEServiçosToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            ConfigurarTelaPrincipal(controladores["ControladorTaxasServicos"]);
        }

        private void cupomToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            ConfigurarTelaPrincipal(controladores["ControladorCupom"]);
        }

        private void parceiroToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            ConfigurarTelaPrincipal(controladores["ControladorParceiro"]);
        }

        private void aluguelToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            ConfigurarTelaPrincipal(controladores["ControladorAluguel"]);
        }

        private void grupoDeAutomóveisToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            ConfigurarTelaPrincipal(controladores["ControladorGrupoAutomoveis"]);
        }

        private void pToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ConfigurarTelaPrincipal(controladores["ControladorCobranca"]);
        }

        private void automóvelToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            ConfigurarTelaPrincipal(controladores["ControladorAutomovel"]);
        }

        private void condutorToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            ConfigurarTelaPrincipal(controladores["ControladorCondutor"]);
        }

        private void clienteToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            ConfigurarTelaPrincipal(controladores["ControladorCliente"]);
        }
    }
}
