using eAgenda.Controladores.TarefaModule;
using eAgenda.Dominio.Shared;
using eAgenda.Dominio.TarefaModule;
using eAgenda.WindowsApp.Modulos.MolTarefa.ColetaDados;
using eAgenda.WindowsApp.Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace eAgenda.WindowsApp.Modulos.MolTarefa.Configuracoes
{
    public class AcoesTarefa : ICadastravel
    {
        private readonly ControladorTarefa controlador;
        private readonly TabelaListaTarefas tabelaTarefas;

        public AcoesTarefa(ControladorTarefa controlador)
        {
            this.controlador = controlador;
            tabelaTarefas = new TabelaListaTarefas();
        }

        public void AgruparRegistros()
        {
            throw new NotImplementedException();
        }

        public void EditarRegistro()
        {
            int id = tabelaTarefas.ObtemIdSelecionado();

            if (id == 0)
            {
                MessageBox.Show("Selecione uma tarefa para poder editar!", "Edição de Tarefas",
                    MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            Tarefa tarefaSelecionada = controlador.SelecionarPorId(id);

            if (tarefaSelecionada.EstaConcluida())
            {
                MessageBox.Show("Não é permitido a edição de tarefas já concluídas!", "Edição de Tarefas",
                  MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            CadastroTarefaForm tela = new CadastroTarefaForm();

            tela.Tarefa = tarefaSelecionada;

            if (tela.ShowDialog() == DialogResult.OK)
            {
                controlador.Editar(id, tela.Tarefa);

                tabelaTarefas.AtualizarRegistros(controlador.SelecionarTodos().Cast<EntidadeBase>().ToList());

                TelaPrincipalForm.Instancia.AtualizarRodape($"Tarefa: [{tela.Tarefa.Titulo}] editada com sucesso");
            }
        }

        public void ExcluirRegistro()
        {
            int id = tabelaTarefas.ObtemIdSelecionado();

            if (id == 0)
            {
                MessageBox.Show("Selecione uma tarefa para poder excluir!", "Exclusão de Tarefas",
                    MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            Tarefa tarefaSelecionada = controlador.SelecionarPorId(id);

            if (MessageBox.Show($"Tem certeza que deseja excluir a tarefa: [{tarefaSelecionada.Titulo}] ?",
                "Exclusão de Tarefas", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
            {
                controlador.Excluir(id);

                tabelaTarefas.AtualizarRegistros(controlador.SelecionarTodos().Cast<EntidadeBase>().ToList());

                TelaPrincipalForm.Instancia.AtualizarRodape($"Tarefa: [{tarefaSelecionada.Titulo}] removida com sucesso");
            }
        }

        public void FiltrarRegistros()
        {
            FiltroTarefaForm telaFiltro = new FiltroTarefaForm();

            if (telaFiltro.ShowDialog() == DialogResult.OK)
            {
                List<EntidadeBase> tarefas = new List<EntidadeBase>();
                string tipoTarefa = "";

                switch (telaFiltro.TipoFiltro)
                {
                    case FiltroTarefaEnum.TodasTarefas:
                        tarefas = controlador.SelecionarTodos().Cast<EntidadeBase>().ToList();
                        break;

                    case FiltroTarefaEnum.TarefasPendentes:
                        {
                            tarefas = controlador.SelecionarTodasTarefasPendentes().Cast<EntidadeBase>().ToList();
                            tipoTarefa = "pendente(s)";
                            break;
                        }

                    case FiltroTarefaEnum.TarefasConcluidas:
                        {
                            tarefas = controlador.SelecionarTodasTarefasConcluidas().Cast<EntidadeBase>().ToList() ;
                            tipoTarefa = "concluída(s)";
                            break;
                        }

                    default:
                        break;
                }

                tabelaTarefas.AtualizarRegistros(tarefas);
                TelaPrincipalForm.Instancia.AtualizarRodape($"Visualizando {tarefas.Count} tarefa(s) {tipoTarefa}");
            }
        }

        public void InserirNovoRegistro()
        {
            CadastroTarefaForm tela = new CadastroTarefaForm();

            if (tela.ShowDialog() == DialogResult.OK)
            {
                controlador.InserirNovo(tela.Tarefa);

                List<EntidadeBase> tarefas = controlador.SelecionarTodos().Cast<EntidadeBase>().ToList();

                tabelaTarefas.AtualizarRegistros(tarefas);

                TelaPrincipalForm.Instancia.AtualizarRodape($"Tarefa: [{tela.Tarefa.Titulo}] inserido com sucesso");
            }
        }

        public UserControl ObterTabela()
        {
            List<EntidadeBase> tarefas = controlador.SelecionarTodos().Cast<EntidadeBase>().ToList();

            tabelaTarefas.AtualizarRegistros(tarefas);

            return tabelaTarefas;
        }
    }
}
