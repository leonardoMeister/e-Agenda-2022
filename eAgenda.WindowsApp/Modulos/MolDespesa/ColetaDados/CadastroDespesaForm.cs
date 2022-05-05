using eAgenda.Dominio.DespesaModule;
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
    public partial class CadastroDespesaForm : Form
    {
        private Despesa despesa;
        public CadastroDespesaForm()
        {
            InitializeComponent();
        }
        public Despesa Despesa
        {
            get { return despesa; }

            set
            {
                despesa = value;
                /*
                txtId.Text = contato._id.ToString();
                txtNome.Text = contato.Nome;
                txtEmpresa.Text = contato.Email;
                txtEmail.Text = contato.Email;
                txtCargo.Text = contato.Cargo;
                mkTelefone.Text = contato.Telefone;*/
            }
        }
    }
}
