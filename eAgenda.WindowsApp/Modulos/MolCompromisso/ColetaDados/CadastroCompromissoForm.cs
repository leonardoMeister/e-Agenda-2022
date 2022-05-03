using eAgenda.Controladores.ContatoModule;
using eAgenda.Dominio.CompromissoModule;
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

namespace eAgenda.WindowsApp.Modulos.MolCompromisso.ColetaDados
{
    public partial class CadastroCompromissoForm : Form
    {
        private Compromisso compromisso;
        private readonly ControladorContato controlador;

        public CadastroCompromissoForm(ControladorContato control)
        {
            InitializeComponent();
            this.controlador = control;
            AtualizarContatos();

            //Eventos Radio 
            radioOnline.CheckedChanged += new EventHandler(AlterarMeioCompromisso);
            radioPresencial.CheckedChanged += new EventHandler(AlterarMeioCompromisso);
        }
        private Compromisso GerarObjeto()
        {
            string link, local;

            if (EhPresencial())
            {
                link = "";
                local = txtEndereco.Text;
            }
            else
            {
                local = "";
                link = txtEndereco.Text;
            }

            Contato contato = (!(cmbContato.SelectedItem is null)) ? (Contato)cmbContato.SelectedItem : null;

            compromisso = new Compromisso(txtAssunto.Text, local, link, dateCompromisso.Value, horaInicio.Value.TimeOfDay, horaConclusao.Value.TimeOfDay, contato, TipoAcao.Inserindo);

            if (txtId.Text != "") compromisso._id = Convert.ToInt32(txtId.Text);

            return compromisso;
        }
        private void AlterarMeioCompromisso(object sender, EventArgs e)
        {
            RadioButton radio = ((RadioButton)sender);
            labelLocal.Text = (radio.Text == "Presencial") ? "Local" : "Link";
        }
        private void AtualizarContatos()
        {
            cmbContato.Items.Clear();

            foreach (var item in controlador.SelecionarTodos())
            {
                cmbContato.Items.Add(item);
            }
        }
        private bool EhPresencial()
        {
            return (radioPresencial.Checked == true) ? true : false;
        }
        public Compromisso Compromisso
        {
            get { return compromisso; }
            set
            {
                compromisso = value;
                ColocarContato();
                txtId.Text = compromisso._id.ToString();
                txtAssunto.Text = compromisso.Assunto;
                dateCompromisso.Text = compromisso.Data.ToShortDateString();
                horaInicio.Text = compromisso.HoraInicio.ToString();
                horaConclusao.Text = compromisso.HoraTermino.ToString();
            }
        }

        private void ColocarContato()
        {
            if (!(compromisso.Contato is null))
                cmbContato.SelectedItem = compromisso.Contato;
        }

        private void CadastroCompromissoForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            TelaPrincipalForm.Instancia.AtualizarRodape("");

        }

        private void btnGravar_Click(object sender, EventArgs e)
        {
            compromisso = GerarObjeto();

            string resultadoValidacao = compromisso.Validar();

            if (resultadoValidacao != "ESTA_VALIDO")
            {
                string primeiroErro = new StringReader(resultadoValidacao).ReadLine();

                TelaPrincipalForm.Instancia.AtualizarRodape(primeiroErro);

                DialogResult = DialogResult.None;
            }
        }
    }
}
