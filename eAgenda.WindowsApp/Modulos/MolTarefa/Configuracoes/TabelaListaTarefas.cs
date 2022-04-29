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

namespace eAgenda.WindowsApp.Modulos.MolTarefa.Configuracoes
{
    public partial class TabelaListaTarefas : UserControl, IConfiguravelDataGridView
    { 
        public TabelaListaTarefas()
        {
            InitializeComponent();
            gridTarefas.ConfigurarGridZebrado();
            gridTarefas.ConfigurarGridSomenteLeitura();
            gridTarefas.Columns.AddRange(ObterColunas());
        }

        public void AtualizarRegistros(List<Tarefa> tarefas)
        {
            gridTarefas.Rows.Clear();

            foreach (Tarefa tarefa in tarefas)
            {
                gridTarefas.Rows.Add(tarefa._id, tarefa.Titulo, tarefa.Prioridade,
                    tarefa.Percentual, tarefa.DataCriacao, tarefa.DataConclusao);
            }
        } 

        public int ObtemIdSelecionado()
        {
            return gridTarefas.SelecionarId<int>();
        }

        public DataGridViewColumn[] ObterColunas()
        {
            var colunas = new DataGridViewColumn[]
            {
                new DataGridViewTextBoxColumn { DataPropertyName = "Id", HeaderText = "Id"},

                new DataGridViewTextBoxColumn { DataPropertyName = "Titulo", HeaderText = "Título"},

                new DataGridViewTextBoxColumn { DataPropertyName = "Prioridade", HeaderText = "Prioridade"},

                new DataGridViewTextBoxColumn { DataPropertyName = "Percentual", HeaderText = "Percentual"},

                new DataGridViewTextBoxColumn {DataPropertyName = "DataCriacao", HeaderText = "Data de Criação"},

                new DataGridViewTextBoxColumn {DataPropertyName = "DataConclusao", HeaderText = "Data de Conclusão"}
            };

            return colunas;
        }
    }
}
