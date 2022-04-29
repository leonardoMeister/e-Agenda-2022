using eAgenda.WindowsApp.Modulos.MolContato.Configuracoes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace eAgenda.WindowsApp.Modulos.MolContato.ColetaDados
{
    public partial class FiltroContatoForm : Form
    {
        public FiltroContatoForm()
        {
            InitializeComponent();
        }

        public FiltroContatoEnum TipoFiltro
        {
            get
            {
                if (rdbOrdemAlfa.Checked)
                    return FiltroContatoEnum.OdemAlfabetica;

                else if (rdbTodosContatos.Checked)
                    return FiltroContatoEnum.TodosContatos;


                else return FiltroContatoEnum.TodosContatos;
            }
        }
    }
}
