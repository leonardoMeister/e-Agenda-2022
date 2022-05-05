using eAgenda.WindowsApp.Modulos.MolDespesa.Configuracoes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace eAgenda.WindowsApp.Modulos.MolDespesa.ColetaDados
{
    public partial class FiltroDespesaForm : Form
    {
        public FiltroDespesaForm()
        {
            InitializeComponent();
        }
        public FiltroDespesaEnum TipoFiltro
        {
            get
            {
                /*
                if (rdbOrdemAlfa.Checked)
                    return FiltroContatoEnum.OdemAlfabetica;

                else if (rdbTodosContatos.Checked)
                    return FiltroContatoEnum.TodosContatos;


                else*/ return FiltroDespesaEnum.Todas;
            }
        }
    }
}
