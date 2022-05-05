using eAgenda.Controladores.ContatoModule;
using eAgenda.Dominio.ContatoModule;
using eAgenda.Dominio.Shared;
using eAgenda.WindowsApp.Modulos.MolContato.ColetaDados;
using eAgenda.WindowsApp.Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace eAgenda.WindowsApp.Modulos.MolContato.Configuracoes
{
    public class AcoesContato : ICadastravel
    {
        private readonly ControladorContato controlador;
        private readonly TabelaListaContatos tabelaContatos;

        public AcoesContato(ControladorContato controlador)
        {
            this.controlador = controlador;
            tabelaContatos = new TabelaListaContatos(); 
        }

        public void AgruparRegistros()
        {
            throw new NotImplementedException();
        }
        public void FiltrarRegistros()
        {
            FiltroContatoForm telaFiltro = new FiltroContatoForm();

            if (telaFiltro.ShowDialog() == DialogResult.OK)
            {
                List<EntidadeBase> contatos = new List<EntidadeBase>();
                string tipoContato = "";

                switch (telaFiltro.TipoFiltro)
                {
                    case FiltroContatoEnum.TodosContatos:
                        contatos = controlador.SelecionarTodos().Cast<EntidadeBase>().ToList(); ;
                        break;

                    case FiltroContatoEnum.OdemAlfabetica:
                        {
                            contatos = controlador.SelecionarContatosEmOrdemAlfabetica();
                            tipoContato = "Em ordem Alfabetica";
                            break;
                        }

                    default:
                        break;
                }

                tabelaContatos.AtualizarRegistros(contatos);
                TelaPrincipalForm.Instancia.AtualizarRodape($"Visualizando {contatos.Count} contato(s) {tipoContato}");
            }
        }

        public void EditarRegistro()
        {
            int id = tabelaContatos.ObtemIdSelecionado();

            if (id == 0)
            {
                MessageBox.Show("Selecione um Contato para poder editar!", "Edição de Contatos",
                    MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            Contato ContatoSelecionada = controlador.SelecionarPorId(id);

            CadastroContatoForm tela = new CadastroContatoForm();

            tela.Contato = ContatoSelecionada;

            if (tela.ShowDialog() == DialogResult.OK)
            {
                controlador.Editar(id, tela.Contato);

                List<EntidadeBase> contatos = controlador.SelecionarTodos().Cast<EntidadeBase>().ToList(); ;

                tabelaContatos.AtualizarRegistros(contatos);

                TelaPrincipalForm.Instancia.AtualizarRodape($"Contato: [{tela.Contato.Nome}] editado com sucesso");
            }
        }

        public void ExcluirRegistro()
        {
            int id = tabelaContatos.ObtemIdSelecionado();

            if (id == 0)
            {
                MessageBox.Show("Selecione um Contato para poder excluir!", "Exclusão de Contatos",
                    MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            Contato contatoSelecionada = controlador.SelecionarPorId(id);

            if (MessageBox.Show($"Tem certeza que deseja excluir o Contato: [{contatoSelecionada.Nome}] ?",
                "Exclusão de Contatos", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
            {
                controlador.Excluir(id);

                List<EntidadeBase> tarefas = controlador.SelecionarTodos().Cast<EntidadeBase>().ToList();

                tabelaContatos.AtualizarRegistros(tarefas);

                TelaPrincipalForm.Instancia.AtualizarRodape($"Contato: [{contatoSelecionada.Nome}] removido com sucesso");
            }
        }

        public void InserirNovoRegistro()
        {
            CadastroContatoForm tela = new CadastroContatoForm();

            if (tela.ShowDialog() == DialogResult.OK)
            {
                controlador.InserirNovo(tela.Contato);

                List<EntidadeBase> tarefas = controlador.SelecionarTodos().Cast<EntidadeBase>().ToList();

                tabelaContatos.AtualizarRegistros(tarefas);

                TelaPrincipalForm.Instancia.AtualizarRodape($"Contato: [{tela.Contato.Nome}] inserido com sucesso");
            }
        }

        public UserControl ObterTabela()
        {
            List<EntidadeBase> contatos = controlador.SelecionarTodos().Cast<EntidadeBase>().ToList();

            tabelaContatos.AtualizarRegistros(contatos);

            return tabelaContatos;
        }
    }
}
