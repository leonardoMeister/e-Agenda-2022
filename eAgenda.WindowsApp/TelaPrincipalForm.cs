using eAgenda.Controladores.CompromissoModule;
using eAgenda.Controladores.ContatoModule;
using eAgenda.Controladores.TarefaModule;
using eAgenda.Serializador.ModulosSerializador.CompromissoSerial;
using eAgenda.Serializador.ModulosSerializador.ContatoSerial;
using eAgenda.Serializador.ModulosSerializador.TarefaSerial;
using eAgenda.WindowsApp.Modulos.MolCompromisso.Configuracoes;
using eAgenda.WindowsApp.Modulos.MolContato.Configuracoes;
using eAgenda.WindowsApp.Modulos.MolTarefa.Configuracoes;
using eAgenda.WindowsApp.Shared;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace eAgenda.WindowsApp
{
    public partial class TelaPrincipalForm : Form
    {
        private ICadastravel operacoes;

        ControladorCompromisso controladorCompromisso;
        ControladorContato controladorContato;
        ControladorTarefa controladorTarefa;

        public static TelaPrincipalForm Instancia;

        public TelaPrincipalForm()
        {
            InitializeComponent();
            controladorTarefa = new ControladorTarefa(new TarefaSerializador());
            controladorContato = new ControladorContato(new ContatoSerializador());
            controladorCompromisso = new ControladorCompromisso(new CompromissoSerializador());

            //PopularAplicacaoStatic.PopularAplicacao(controladorContato, controladorTarefa, controladorCompromisso);

            Instancia = this;
        }

        public void AtualizarRodape(string mensagem)
        {
            labelRodape.Text = mensagem;
        }

        private void menuItemTarefas_Click(object sender, EventArgs e)
        {

            ConfiguracaoTarefaToolBox configuracao = new ConfiguracaoTarefaToolBox();

            ConfigurarToolBox(configuracao);

            AtualizarRodape(configuracao.TipoCadastro);

            operacoes = new AcoesTarefa(controladorTarefa);

            ConfigurarPainelRegistros();
        }

        private void menuItemContato_Click(object sender, EventArgs e)
        {

            ConfiguracaoContatoToolBox configuracao = new ConfiguracaoContatoToolBox();

            ConfigurarToolBox(configuracao);

            AtualizarRodape(configuracao.TipoCadastro);

            operacoes = new AcoesContato(controladorContato);

            ConfigurarPainelRegistros();
        }
        private void menuItemCompromisso_Click(object sender, EventArgs e)
        {
            ConfiguracaoCompromissoToolBox configuracao = new ConfiguracaoCompromissoToolBox();

            ConfigurarToolBox(configuracao);

            AtualizarRodape(configuracao.TipoCadastro);

            operacoes = new AcoesCompromisso(controladorCompromisso, controladorContato);

            ConfigurarPainelRegistros();
        }
        private void btnAdicionar_Click(object sender, EventArgs e)
        {
            if (!(operacoes is null))
                operacoes.InserirNovoRegistro();
            else MessageBox.Show("Selecione uma opção de janela primeiro!");
        }
        private void btnEditar_Click(object sender, EventArgs e)
        {
            if (!(operacoes is null))
                operacoes.EditarRegistro();
            else MessageBox.Show("Selecione uma opção de janela primeiro!");
        }
        private void btnExcluir_Click(object sender, EventArgs e)
        {
            if (!(operacoes is null))
                operacoes.ExcluirRegistro();
            else MessageBox.Show("Selecione uma opção de janela primeiro!");
        }
        private void btnFiltrar_Click(object sender, EventArgs e)
        {
            if (!(operacoes is null))
                operacoes.FiltrarRegistros();
            else MessageBox.Show("Selecione uma opção de janela primeiro!");
        }
        private void ConfigurarPainelRegistros()
        {
            UserControl tabela = operacoes.ObterTabela();

            panelRegistros.Controls.Clear();

            panelRegistros.Controls.Add(tabela);

            tabela.Dock = DockStyle.Fill;

        }
        private void ConfigurarToolBox(IConfiguracaoToolBox configuracao)
        {
            labelTipoCadastro.Text = configuracao.TipoCadastro;

            btnAdicionar.ToolTipText = configuracao.ToolTipAdicionar;
            btnEditar.ToolTipText = configuracao.ToolTipEditar;
            btnExcluir.ToolTipText = configuracao.ToolTipExcluir;
            btnFiltrar.ToolTipText = configuracao.ToolTipoFiltrar;

            if (configuracao.DessagruparItens) btnDessagrupar.Enabled = true;
            else btnDessagrupar.Enabled = false;

            if (configuracao.AgruparItens) btnAgrupar.Enabled = true;
            else btnAgrupar.Enabled = false;

        }


    }
}
