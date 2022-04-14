using eAgenda.ConsoleApp.Shared;
using eAgenda.Controladores.TarefaModule;
using eAgenda.Dominio.TarefaModule;
using System;
using System.Collections.Generic;

namespace eAgenda.ConsoleApp.TarefaModule
{
    public class TelaTarefa : TelaCadastroBasico<Tarefa>, ICadastravel
    {
        public readonly ControladorTarefa controladorTarefa;

        public TelaTarefa(ControladorTarefa controladorTarefa)
            : base("Cadastro de Tarefas", controladorTarefa)
        {
            this.controladorTarefa = controladorTarefa;
        }
        public override void EditarRegistro()
        {
            ConfigurarTela(SubtituloDeEdicao());

            string opcao = ObterOpcao();

            if (opcao == "1")
            {
                bool temRegistros = VisualizarTarefasPendentes();

                if (temRegistros == false)
                    return;

                Console.Write("\n" + PerguntaEdicaoQualRegistro());
                int id = Convert.ToInt32(Console.ReadLine());

                bool numeroEncontrado = base.controlador.Existe(id);
                if (numeroEncontrado == false)
                {
                    ApresentarMensagem(MensagemDeRegistroNaoEncontrado() + id, TipoMensagem.Erro);
                    EditarRegistro();
                    return;
                }
                Tarefa tar = base.controlador.SelecionarPorId(id);
                List<int> listaPercentuais = new List<int>();

                for (int x = 0; x < tar.ListaItens.Count; x++)
                {
                    Console.WriteLine();
                    Console.WriteLine("Descrição do iten: " + tar.ListaItens[x].Descricao);
                    Console.WriteLine("Porcentagem atual: " + tar.ListaItens[x].Porcentagem);
                    Console.Write("Digite o novo percentual: ");
                    listaPercentuais.Add(Convert.ToInt32(Console.ReadLine()));
                    Console.WriteLine();
                }

                string auxResult = controladorTarefa.AtualizarPercentual(id, listaPercentuais);
                if (auxResult == "") ApresentarMensagem(MensagemDeEdicaoComSucesso(), TipoMensagem.Sucesso);
                else ApresentarMensagem(auxResult, TipoMensagem.Erro);
            }
            else if (opcao == "2")
            {
                bool temRegistros = VisualizarRegistros(TipoVisualizacao.Pesquisando);

                if (temRegistros == false)
                    return;

                Console.Write("\n" + PerguntaEdicaoQualRegistro());
                int id = Convert.ToInt32(Console.ReadLine());

                bool numeroEncontrado = base.controlador.Existe(id);
                if (numeroEncontrado == false)
                {
                    ApresentarMensagem(MensagemDeRegistroNaoEncontrado() + id, TipoMensagem.Erro);
                    return;
                }

                Tarefa tar = ObterRegistro(TipoAcao.Editando);
                controladorTarefa.Editar(id,tar);
                ApresentarMensagem(MensagemDeEdicaoComSucesso() + id, TipoMensagem.Sucesso);


            }
        }
        public override bool VisualizarRegistros(TipoVisualizacao tipo)
        {
            if (tipo == TipoVisualizacao.VisualizandoTela)
            {
                string opcao = ObterOpcaoFiltroTarefa();
                ConfigurarTela(SubtituloDeVisualizacao());
                switch (opcao)
                {
                    case "1":
                        VisualizarTarefasConcluidas();
                        VisualizarTarefasPendentes();
                        break;
                    case "2":
                        VisualizarTarefasPendentes();
                        break;
                    case "3":
                        VisualizarTarefasConcluidas();
                        break;
                    case "4":
                        VisualizarTarefasOrdenadasPrioridade();
                        break;
                    default:
                        return false;
                }
            }
            if (tipo == TipoVisualizacao.Pesquisando)
                return base.VisualizarRegistros(TipoVisualizacao.VisualizandoTela);


            return true;
        }
        private void VisualizarTarefasOrdenadasPrioridade()
        {
            List<Tarefa> tarefasOrdenadas = controladorTarefa.SelecionarTarefasFiltradasPrioridade();

            Console.WriteLine("\nTarefas Ordenadas Prioridade:\n");

            if (tarefasOrdenadas == null || tarefasOrdenadas.Count == 0)
                ApresentarMensagem("Nenhuma tarefa concluída", TipoMensagem.Atencao);
            else
                ApresentarTabela(tarefasOrdenadas);
        }
        private bool VisualizarTarefasPendentes()
        {
            bool temRegistros = true;

            var tarefasPendentes = controladorTarefa.SelecionarTodasTarefasPendentes();

            Console.WriteLine("\nTarefas Pendentes:\n");

            if (tarefasPendentes == null || tarefasPendentes.Count == 0)
            {
                ApresentarMensagem("Nenhuma tarefa pendente", TipoMensagem.Atencao);
                temRegistros = false;
            }
            else
                ApresentarTabela(tarefasPendentes);

            return temRegistros;
        }
        private void VisualizarTarefasConcluidas()
        {
            var tarefasConcluidas = controladorTarefa.SelecionarTodasTarefasConcluidas();

            Console.WriteLine("\nTarefas Concluídas:\n");

            if (tarefasConcluidas == null || tarefasConcluidas.Count == 0)
                ApresentarMensagem("Nenhuma tarefa concluída", TipoMensagem.Atencao);
            else
                ApresentarTabela(tarefasConcluidas);
        }
        public override void ApresentarTabela(List<Tarefa> registros)
        {
            string configuracaoColunasTabela = "{0,-10} | {1,-25} | {2,-25} | {3,-20} | {4,-15}";

            MontarCabecalhoTabela(configuracaoColunasTabela, "Id", "Título", "Data Conclusão", "Prioridade", "Percentual");

            foreach (Tarefa tarefa in registros)
            {
                string auxDataConclusao = (tarefa.DataConclusao != null) ? tarefa.DataConclusao.ToString() : "Sem Concluir";

                Console.WriteLine(configuracaoColunasTabela,
                    tarefa._id, tarefa.Titulo, auxDataConclusao, tarefa.Prioridade, tarefa.Percentual);
            }
        }
        public override Tarefa ObterRegistro(TipoAcao tipoAcao)
        {
            Console.Write("Digite o título da Tarefa: ");
            string titulo = Console.ReadLine();

            Console.WriteLine("\n0 para prioridade Baixa");
            Console.WriteLine("1 para prioridade Normal");
            Console.WriteLine("2 para prioridade Alta");

            Console.WriteLine("\nDigite a prioridade da Tarefa: ");

            int prioridade = Convert.ToInt32(Console.ReadLine());

            List<Itens> lista = new List<Itens>();

            PegarItensDaTarefa(lista);

            Tarefa tar = new Tarefa(titulo, DateTime.Now.Date, (PrioridadeEnum)prioridade, lista, tipoAcao.ToString());

            return tar;
        }
        private void PegarItensDaTarefa(List<Itens> lista)
        {
            Console.WriteLine();
            int x = 0;
            while (true)
            {
                x++;
                Console.WriteLine($"Informe a descrição do {x} iten: ");
                string descricao = Console.ReadLine();
                Console.WriteLine($"Informe a porcentagem de conclusao do {x} iten: [0-100]");
                int perc = Convert.ToInt32(Console.ReadLine());
                Itens item = new Itens(descricao, perc);
                string validacao = item.Validar();
                if (validacao == "ESTA_VALIDO")
                {
                    lista.Add(item);
                    ApresentarMensagem("Item inserido com sucesso.", TipoMensagem.Sucesso);
                    Console.WriteLine("Gostaria de inserir mais um item? [s]");
                    string auxS = Console.ReadLine();
                    if (auxS.ToLower() == "s") continue;
                    break;
                }
                else
                {
                    ApresentarMensagem(validacao, TipoMensagem.Erro);
                    x--;
                }
            }
        }
        private string ObterOpcaoFiltroTarefa()
        {
            Console.Clear();
            ConfigurarTela("Filtro de busca");
            Console.WriteLine("Digite 1 para Visualizar Todas Tarefas");
            Console.WriteLine("Digite 2 para Visualizar Tarefas pendentes");
            Console.WriteLine("Digite 3 para Visualizar Tarefas concluidas");
            Console.WriteLine("Digite 4 para Visualizar Tarefas Ordenadas por prioridade");

            Console.WriteLine("Digite S para Voltar");
            Console.WriteLine();

            Console.Write("Opção: ");
            string opcao = Console.ReadLine();
            Console.Clear();
            return opcao;

        }
        private new string ObterOpcao()
        {
            Console.WriteLine("Digite 1 para atualizar percentuais");
            Console.WriteLine("Digite 2 para editar os dados da tarefa");

            Console.WriteLine("Digite S para Voltar");
            Console.WriteLine();

            Console.Write("Opção: ");
            string opcao = Console.ReadLine();

            return opcao;
        }
    }
}