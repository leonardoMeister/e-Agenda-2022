using eAgenda.Controladores.DespesaModulo;
using eAgenda.Dominio.DespesaModule;
using eAgenda.Dominio.Shared;
using eAgenda.WindowsApp.Modulos.MolDespesa.ColetaDados;
using eAgenda.WindowsApp.Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace eAgenda.WindowsApp.Modulos.MolDespesa.Configuracoes
{
    internal class AcoesDespesa : ICadastravel
    {
        private readonly ControladorDespesa controlador;
        private readonly TabelaListaDespesa tabelaDespesa;

        public AcoesDespesa(ControladorDespesa controlador)
        {
            this.controlador = controlador;
            this.tabelaDespesa = new TabelaListaDespesa();
        }

        public void AgruparRegistros()
        {
            throw new NotImplementedException();
        }

        public void EditarRegistro()
        {
            int id = tabelaDespesa.ObtemIdSelecionado();

            if (id == 0)
            {
                MessageBox.Show("Selecione uma Despesa para poder editar!", "Edição de Despesa",
                    MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            Despesa ContatoSelecionada = controlador.SelecionarPorId(id);

            CadastroDespesaForm tela = new CadastroDespesaForm();

            tela.Despesa = ContatoSelecionada;

            if (tela.ShowDialog() == DialogResult.OK)
            {
                controlador.Editar(id, tela.Despesa);

                List<EntidadeBase> despesas = controlador.SelecionarTodos().Cast<EntidadeBase>().ToList(); ;

                tabelaDespesa.AtualizarRegistros(despesas);

                TelaPrincipalForm.Instancia.AtualizarRodape($"Despesa: [{tela.Despesa.Descricao}] editada com sucesso");
            }
        }

        public void ExcluirRegistro()
        {
            int id = tabelaDespesa.ObtemIdSelecionado();

            if (id == 0)
            {
                MessageBox.Show("Selecione uma Despesa para poder excluir!", "Exclusão de Despesas",
                    MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            Despesa despesaSelecionada = controlador.SelecionarPorId(id);

            if (MessageBox.Show($"Tem certeza que deseja excluir a Despesa: [{despesaSelecionada.Descricao}] ?",
                "Exclusão de Despesa", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
            {
                controlador.Excluir(id);

                List<EntidadeBase> despesas = controlador.SelecionarTodos().Cast<EntidadeBase>().ToList();

                tabelaDespesa.AtualizarRegistros(despesas);

                TelaPrincipalForm.Instancia.AtualizarRodape($"Despesa: [{despesaSelecionada.Descricao}] removida com sucesso");
            }
        }

        public void FiltrarRegistros()
        {
            FiltroDespesaForm telaFiltro = new FiltroDespesaForm();

            if (telaFiltro.ShowDialog() == DialogResult.OK)
            {
                List<EntidadeBase> despesas = new List<EntidadeBase>();
                string tipoContato = "";

                switch (telaFiltro.TipoFiltro)
                {
                    case FiltroDespesaEnum.Todas:
                        despesas = controlador.SelecionarTodos().Cast<EntidadeBase>().ToList(); ;
                        break;

                    case FiltroDespesaEnum.OrdenadasPreco:
                        {
                            despesas = controlador.SelecionarTodosOrdenadosPorPreco();
                            tipoContato = "Ordenador por preço";
                            break;
                        }
                    case FiltroDespesaEnum.TotalGastoNoMes:
                        {
                            despesas = controlador.SelecionarTotalGastoNoMes();
                            tipoContato = "Ordenador por preço";
                            break;
                        }
                    case FiltroDespesaEnum.TotalGastoPorCategoria:
                        {
                            despesas = controlador.SelecionarTotalGastoPorCategoria();
                            tipoContato = "Ordenador por preço";
                            break;
                        }
                    case FiltroDespesaEnum.TotalGastoPorCategoriaNoMes:
                        {
                            despesas = controlador.SelecionarTotalGastoPorCategoriaNoMes();
                            tipoContato = "Ordenador por preço";
                            break;
                        }
                    default:
                        break;
                }

                tabelaDespesa.AtualizarRegistros(despesas);
                TelaPrincipalForm.Instancia.AtualizarRodape($"Visualizando {despesas.Count} Despesa(s) {tipoContato}");
            }
        }

        public void InserirNovoRegistro()
        {
            CadastroDespesaForm tela = new CadastroDespesaForm();

            if (tela.ShowDialog() == DialogResult.OK)
            {
                controlador.InserirNovo(tela.Despesa);

                List<EntidadeBase> despesas = controlador.SelecionarTodos().Cast<EntidadeBase>().ToList();

                tabelaDespesa.AtualizarRegistros(despesas);

                TelaPrincipalForm.Instancia.AtualizarRodape($"Despesa: [{tela.Despesa.Descricao}] inserida com sucesso");
            }
        }

        public UserControl ObterTabela()
        {
            List<EntidadeBase> despesas = controlador.SelecionarTodos().Cast<EntidadeBase>().ToList();

            tabelaDespesa.AtualizarRegistros(despesas);

            return tabelaDespesa;
        }
    }
}
