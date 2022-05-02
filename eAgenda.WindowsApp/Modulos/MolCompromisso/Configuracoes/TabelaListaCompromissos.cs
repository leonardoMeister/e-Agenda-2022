using eAgenda.Dominio.CompromissoModule;
using eAgenda.Dominio.Shared;
using eAgenda.WindowsApp.Shared;
using System.Collections.Generic;

using System.Windows.Forms;

namespace eAgenda.WindowsApp.Modulos.MolCompromisso.Configuracoes
{
    public partial class TabelaListaCompromissos : UserControl, IConfiguravelDataGridView
    {
        public TabelaListaCompromissos()
        {
            InitializeComponent();
            gridCompromisso.ConfigurarGridZebrado();
            gridCompromisso.ConfigurarGridSomenteLeitura();
            gridCompromisso.Columns.AddRange(ObterColunas());

        }

        public void AtualizarRegistros(List<EntidadeBase> compros)
        {
            gridCompromisso.Rows.Clear();

            foreach (Compromisso compromisso in compros)
            {
                string auxContato = "";
                if (!(compromisso.Contato is null)) auxContato = compromisso.Contato.ToString();

                gridCompromisso.Rows.Add(compromisso._id.ToString(), compromisso.Assunto,
                   auxContato.ToString(),compromisso.Data.Date.ToShortDateString(), compromisso.HoraInicio.ToString(), compromisso.HoraTermino.ToString());
            }
        }

        public int ObtemIdSelecionado()
        {
            return gridCompromisso.SelecionarId<int>();
        }

        public DataGridViewColumn[] ObterColunas()
        {
            var colunas = new DataGridViewColumn[]
                        {
                new DataGridViewTextBoxColumn { DataPropertyName = "Id", HeaderText = "Id"},

                new DataGridViewTextBoxColumn { DataPropertyName = "Assunto", HeaderText = "Assunto"},

                new DataGridViewTextBoxColumn { DataPropertyName = "Contato", HeaderText = "Contato"},

                new DataGridViewTextBoxColumn { DataPropertyName = "Data", HeaderText = "Data"},

                new DataGridViewTextBoxColumn {DataPropertyName = "HoraInicio", HeaderText = "Hora de Inicio"},

                new DataGridViewTextBoxColumn {DataPropertyName = "HoraTermino", HeaderText = "Hora de Termino"}
                        };

            return colunas;
        }
    }
}
