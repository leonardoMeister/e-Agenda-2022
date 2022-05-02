using eAgenda.Controladores.CompromissoModule;
using eAgenda.Controladores.ContatoModule;
using eAgenda.Dominio.CompromissoModule;
using eAgenda.Dominio.Shared;
using eAgenda.WindowsApp.Modulos.MolCompromisso.ColetaDados;
using eAgenda.WindowsApp.Modulos.MolContato.ColetaDados;
using eAgenda.WindowsApp.Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace eAgenda.WindowsApp.Modulos.MolCompromisso.Configuracoes
{
    public class AcoesCompromisso : ICadastravel
    {
        private readonly ControladorCompromisso controladorCompromisso;
        private readonly ControladorContato controladorContato;
        private readonly TabelaListaCompromissos tabelaCompromisso;
        public AcoesCompromisso(ControladorCompromisso controladorCompromisso, ControladorContato controladorContato)
        {
            this.controladorCompromisso = controladorCompromisso;
            this.controladorContato = controladorContato;
            tabelaCompromisso = new TabelaListaCompromissos();

        }

        public void AgruparRegistros()
        {
            throw new NotImplementedException();
        }

        public void EditarRegistro()
        {
            int id = tabelaCompromisso.ObtemIdSelecionado();

            if (id == 0)
            {
                MessageBox.Show("Selecione um Compromisso para poder editar!", "Edição de Compromissos",
                    MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            Compromisso compromissoSelecionado = controladorCompromisso.SelecionarPorId(id);

            CadastroCompromissoForm tela = new CadastroCompromissoForm(controladorContato);

            tela.Compromisso = compromissoSelecionado;

            if (tela.ShowDialog() == DialogResult.OK)
            {
                controladorCompromisso.Editar(id, tela.Compromisso);

                List<EntidadeBase> Compromissos = controladorCompromisso.SelecionarTodos().Cast<EntidadeBase>().ToList();

                tabelaCompromisso.AtualizarRegistros(Compromissos);

                TelaPrincipalForm.Instancia.AtualizarRodape($"Compromisso: [{tela.Compromisso.Assunto}] editado com sucesso");
            }
        }

        public void ExcluirRegistro()
        {
            int id = tabelaCompromisso.ObtemIdSelecionado();

            if (id == 0)
            {
                MessageBox.Show("Selecione um Compromisso para poder excluir!", "Exclusão de Compromissos",
                    MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            Compromisso compromissoSelecionado = controladorCompromisso.SelecionarPorId(id);

            if (MessageBox.Show($"Tem certeza que deseja excluir o Compromisso: [{compromissoSelecionado.Assunto}] ?",
                "Exclusão de Compromissos", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
            {
                controladorCompromisso.Excluir(id);

                List<EntidadeBase> compromissos1 = controladorCompromisso.SelecionarTodos().Cast<EntidadeBase>().ToList();

                tabelaCompromisso.AtualizarRegistros(compromissos1);

                TelaPrincipalForm.Instancia.AtualizarRodape($"Compromisso: [{compromissoSelecionado.Assunto}] removido com sucesso");
            }
        }

        public void FiltrarRegistros()
        {
            FiltroCompromissoForm telaFiltro = new FiltroCompromissoForm();

            if (telaFiltro.ShowDialog() == DialogResult.OK)
            {
                List<Compromisso> compromissos = new List<Compromisso>();
                string tipoCompromisso = "";

                switch (telaFiltro.TipoFiltro)
                {
                    case FiltroCompromissoEnum.FiltroTodosCompromissos:
                        compromissos = controladorCompromisso.SelecionarTodos();
                        break;

                    case FiltroCompromissoEnum.FiltroFuturos:
                        {
                            compromissos = controladorCompromisso.SelecionarCompromissosFuturos();
                            tipoCompromisso = "futuro(s)";
                            break;
                        }

                    case FiltroCompromissoEnum.FiltroPassados:
                        {
                            compromissos = controladorCompromisso.SelecionarCompromissosPassados();
                            tipoCompromisso = "passado(s)";
                            break;
                        }

                    case FiltroCompromissoEnum.FiltroProximas24Horas:
                        {
                            compromissos = controladorCompromisso.SelecionarCompromissosPeriodos(DateTime.Now, DateTime.Now.AddDays(1));
                            tipoCompromisso = "Proximas 24 horas";
                            break;
                        }

                    case FiltroCompromissoEnum.FiltroProximaSemana:
                        {
                            compromissos = controladorCompromisso.SelecionarCompromissosPeriodos(DateTime.Now.Date, DateTime.Now.Date.AddDays(7));
                            tipoCompromisso = "Proxima semana";
                            break;
                        }

                    case FiltroCompromissoEnum.FiltroProximoMes:
                        {
                            compromissos = controladorCompromisso.SelecionarCompromissosPeriodos(DateTime.Now.Date, DateTime.Now.Date.AddMonths(1));
                            tipoCompromisso = "Proximo mês";
                            break;
                        }

                    default:
                        break;
                }

                tabelaCompromisso.AtualizarRegistros(compromissos.Cast<EntidadeBase>().ToList());

                TelaPrincipalForm.Instancia.AtualizarRodape($"Visualizando {compromissos.Count} Compromisso(s) {tipoCompromisso}");
            }
        }

        public void InserirNovoRegistro()
        {
            CadastroCompromissoForm tela = new CadastroCompromissoForm(controladorContato);

            if (tela.ShowDialog() == DialogResult.OK)
            {
                controladorCompromisso.InserirNovo(tela.Compromisso);

                List<EntidadeBase> compromissos = controladorCompromisso.SelecionarTodos().Cast<EntidadeBase>().ToList();

                tabelaCompromisso.AtualizarRegistros(compromissos);

                TelaPrincipalForm.Instancia.AtualizarRodape($"Compromisso: [{tela.Compromisso.Assunto}] inserido com sucesso");
            }
        }

        public UserControl ObterTabela()
        {


            
           
            
            List<EntidadeBase> compromissos = controladorCompromisso.SelecionarTodos().Cast<EntidadeBase>().ToList();

            tabelaCompromisso.AtualizarRegistros(compromissos);

            return tabelaCompromisso;
        }
    }
}
