using eAgenda.Dominio.DespesaModule;
using eAgenda.Dominio.Shared;
using eAgenda.WindowsApp.Shared;
using System.Collections.Generic;
using System.Windows.Forms;

namespace eAgenda.WindowsApp.Modulos.MolDespesa.Configuracoes
{
    public partial class TabelaListaDespesa : UserControl, IConfiguravelDataGridView
    {
        public TabelaListaDespesa()
        {
            InitializeComponent();
            gridDespesa.ConfigurarGridZebrado();
            gridDespesa.ConfigurarGridSomenteLeitura();
            gridDespesa.Columns.AddRange(ObterColunas());
        }

        public void AtualizarRegistros(List<EntidadeBase> despesas)
        {
            gridDespesa.Rows.Clear();
            foreach (Despesa desp in despesas)
            {
                gridDespesa.Rows.Add(desp._id, desp.Descricao, desp.Categoria.ToString(),
                    desp.Valor, desp.FormaDePagamento,desp.DataDespesa.ToShortDateString());
            }
        }

        public int ObtemIdSelecionado()
        {
            return gridDespesa.SelecionarId<int>();
        }

        public DataGridViewColumn[] ObterColunas()
        {
            var colunas = new DataGridViewColumn[]
                                              {
                new DataGridViewTextBoxColumn { DataPropertyName = "Id", HeaderText = "Id"},

                new DataGridViewTextBoxColumn { DataPropertyName = "Descrição", HeaderText = "Descrição"},

                new DataGridViewTextBoxColumn { DataPropertyName = "Categoria", HeaderText = "Categoria"},

                new DataGridViewTextBoxColumn { DataPropertyName = "Valor", HeaderText = "Valor"},

                new DataGridViewTextBoxColumn {DataPropertyName = "FormaPagamento", HeaderText = "Forma Pagamento"},

                new DataGridViewTextBoxColumn {DataPropertyName = "Data", HeaderText = "Data"},

                                              };

            return colunas;
        }
    }
}
