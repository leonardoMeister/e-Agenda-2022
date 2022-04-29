using eAgenda.Dominio.ContatoModule;
using eAgenda.Dominio.Shared;
using eAgenda.Dominio.TarefaModule;
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

namespace eAgenda.WindowsApp.Modulos.MolContato.Configuracoes
{
    public partial class TabelaListaContatos : UserControl , IConfiguravelDataGridView
    {
        public TabelaListaContatos()
        {
            InitializeComponent();
            gridContato.ConfigurarGridZebrado();
            gridContato.ConfigurarGridSomenteLeitura();
            gridContato.Columns.AddRange(ObterColunas());
        }
        private void AgruparContatos()
        {
            Subro.Controls.DataGridViewGrouper grupperListaEmpleados = new Subro.Controls.DataGridViewGrouper(gridContato);
            grupperListaEmpleados.RemoveGrouping();
            grupperListaEmpleados.SetGroupOn("Empresa");
            grupperListaEmpleados.Options.ShowGroupName = false;
            grupperListaEmpleados.Options.GroupSortOrder = System.Windows.Forms.SortOrder.None;
            gridContato.Columns["Empresa"].Visible = false;

        }
        public void AtualizarRegistros(List<EntidadeBase> contatos)
        {
            gridContato.Rows.Clear();

            foreach (Contato contato in contatos)
            {
                gridContato.Rows.Add(contato._id, contato.Nome, contato.Empresa,
                    contato.Cargo, contato.Telefone);
            }
        }

        public int ObtemIdSelecionado()
        {
            return gridContato.SelecionarId<int>();
        }

        public DataGridViewColumn[] ObterColunas()
        {
            var colunas = new DataGridViewColumn[]
                                   {
                new DataGridViewTextBoxColumn { DataPropertyName = "Id", HeaderText = "Id"},

                new DataGridViewTextBoxColumn { DataPropertyName = "Nome", HeaderText = "Nome"},

                new DataGridViewTextBoxColumn { DataPropertyName = "Empresa", HeaderText = "Empresa"},

                new DataGridViewTextBoxColumn { DataPropertyName = "Cargo", HeaderText = "Cargo"},

                new DataGridViewTextBoxColumn {DataPropertyName = "Telefone", HeaderText = "Telefone"},

                                   };

            return colunas;
        }
    }
}
