using eAgenda.Dominio.Shared;
using eAgenda.Dominio.TarefaModule;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace eAgenda.WindowsApp.Modulos.MolTarefa.ColetaDados
{
    public partial class CadastroTarefaForm : Form
    {
        Tarefa tarefa;

        public Tarefa Tarefa
        {
            get { return tarefa; }

            set
            {
                tarefa = value;
                AtualizarListaItens();
                txtId.Text = tarefa._id.ToString();
                txtTitulo.Text = tarefa.Titulo;
                cmbPrioridade.SelectedIndex = tarefa.Prioridade.Chave;
            }
        }
        private void AtualizarListaItens()
        {
            listBoxItens.Items.Clear();
            foreach (Itens item in tarefa.ListaItens)
            {
                listBoxItens.Items.Add(item);
            }
        }
        public CadastroTarefaForm()
        {
            InitializeComponent();
            CarregarComboBoxPrioridades();
        }
        private void CarregarComboBoxPrioridades()
        {
            cmbPrioridade.DataSource = Enum.GetValues(typeof(PrioridadeEnum));
        }
        private void btnGravar_Click(object sender, EventArgs e)
        {
            string titulo = txtTitulo.Text;

            PrioridadeEnum prioridade = (PrioridadeEnum)cmbPrioridade.SelectedValue;

            List<Itens> listItens = PegarListaItens();

            if (tarefa is null) tarefa = new Tarefa(titulo, DateTime.Now, prioridade, listItens, TipoAcao.Inserindo);
            else tarefa = new Tarefa(titulo, null, prioridade, listItens, TipoAcao.Editando, tarefa);

            string resultadoValidacao = tarefa.Validar();

            if (resultadoValidacao != "ESTA_VALIDO")
            {
                string primeiroErro = new StringReader(resultadoValidacao).ReadLine();

                TelaPrincipalForm.Instancia.AtualizarRodape(primeiroErro);

                DialogResult = DialogResult.None;
            }
        }
        private List<Itens> PegarListaItens()
        {
            if (listBoxItens.Items.Count > 0) return listBoxItens.Items.Cast<Itens>().ToList();
            else return new List<Itens>();
        }
        private void btnRemoverItemLista_Click(object sender, EventArgs e)
        {
            if (VerificarItemSelecionado())
            {
                Itens item = (Itens)listBoxItens.SelectedItem;
                listBoxItens.Items.Remove(item);
                txtNomeItem.Text = "";
                cmbStatusConclusão.SelectedIndex = -1;
            }
            listBoxItens.SelectedIndex = -1;
        }

        private bool VerificarItemSelecionado()
        {
            return !(listBoxItens.SelectedItem is null);
        }

        private void btnAdicionarItemLista_Click(object sender, EventArgs e)
        {
            if (btnAdicionarItemLista.Text == "Adicionar Item") AdicionarItemLista();

            else if (btnAdicionarItemLista.Text == "Editar Item") EditarItemNaLista();

            listBoxItens.SelectedIndex = -1;
        }

        private void EditarItemNaLista()
        {
            if(! (listBoxItens.SelectedItem is null))
            {
                Itens item = listBoxItens.SelectedItem as Itens;
                listBoxItens.Items.Remove(item);

                string nome = txtNomeItem.Text;
                int aux = (cmbStatusConclusão.SelectedIndex == 0) ? 0 : 100;
                listBoxItens.Items.Add(new Itens(nome, aux));

                LimparCamposSelecao();
            }
        }

        private void AdicionarItemLista()
        {
            try
            {
                string titulo = txtNomeItem.Text;
                string concluidoOuNao = cmbStatusConclusão.SelectedIndex.ToString();
                int porcentagem = concluidoOuNao == "Concluido." ? 100 : 0;
                Itens item = new Itens(titulo, porcentagem);

                listBoxItens.Items.Add(item);
//              AtualizarListaItens();
                LimparCamposSelecao();

            }
            catch
            {
                MessageBox.Show("Selecione um status de conclusao primeiro!");
            }
        }

        private void CadastroTarefaForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            TelaPrincipalForm.Instancia.AtualizarRodape("");
        }

        private void listBoxItens_SelectedValueChanged(object sender, EventArgs e)
        {


            if (!(listBoxItens.SelectedItem is null))
            {
                btnAdicionarItemLista.Text = "Editar Item";
                Itens item = (Itens)listBoxItens.SelectedItem;
                txtNomeItem.Text = item.Descricao;
                if (item.Porcentagem == 100) cmbStatusConclusão.SelectedIndex = 1;
                else cmbStatusConclusão.SelectedIndex = 0;
            }
            else
            {
                btnAdicionarItemLista.Text = "Adicionar Item";
            }


        }

        private void btn_desSelecao_Click(object sender, EventArgs e)
        {
            LimparCamposSelecao();
        }

        private void LimparCamposSelecao()
        {
            listBoxItens.SelectedIndex = -1;
            cmbStatusConclusão.SelectedIndex = -1;
            txtNomeItem.Text = "";
        }
    }
}
