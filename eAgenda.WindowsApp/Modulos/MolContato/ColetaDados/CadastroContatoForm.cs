using eAgenda.Controladores.ContatoModule;
using eAgenda.Dominio.ContatoModule;
using eAgenda.Dominio.Shared;
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

namespace eAgenda.WindowsApp.Modulos.MolContato.ColetaDados
{
    public partial class CadastroContatoForm : Form
    {
        private Contato contato;
        
        public CadastroContatoForm()
        {
            InitializeComponent();
        }

        public Contato Contato
        {
            get { return contato; }

            set
            {
                contato = value;

                txtId.Text = contato._id.ToString();
                txtNome.Text = contato.Nome;
                txtEmpresa.Text = contato.Email;
                txtEmail.Text = contato.Email;
                txtCargo.Text = contato.Cargo;
                mkTelefone.Text = contato.Telefone;
            }
        }
        private Contato GerarObjeto()
        {
            if (contato is null) return new Contato(txtNome.Text, txtEmail.Text, mkTelefone.Text, txtEmpresa.Text, txtCargo.Text, TipoAcao.Inserindo);
            else
            {
                contato = new Contato(txtNome.Text, txtEmail.Text, mkTelefone.Text, txtEmpresa.Text, txtCargo.Text, TipoAcao.Editando);
                contato._id = Convert.ToInt32(txtId.Text);
                return contato;
            }
        }

        private void CadastroContatoForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            TelaPrincipalForm.Instancia.AtualizarRodape("");
        }

        private void btnGravar_Click(object sender, EventArgs e)
        {
            contato = GerarObjeto();

            string resultadoValidacao = contato.Validar();

            if (resultadoValidacao != "ESTA_VALIDO")
            {
                string primeiroErro = new StringReader(resultadoValidacao).ReadLine();

                TelaPrincipalForm.Instancia.AtualizarRodape(primeiroErro);

                DialogResult = DialogResult.None;
            }
        }
    }
}
