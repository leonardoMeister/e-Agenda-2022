using eAgenda.ConsoleApp.ContatoModule;
using eAgenda.ConsoleApp.Shared;
using eAgenda.Controladores.CompromissoModule;
using eAgenda.Controladores.ContatoModule;
using eAgenda.Dominio.CompromissoModule;
using eAgenda.Dominio.ContatoModule;
using eAgenda.Dominio.Shared;
using System;
using System.Collections.Generic;

namespace eAgenda.ConsoleApp.CompromissoModule
{
    public class TelaCompromisso : TelaCadastroBasico<Compromisso>, ICadastravel
    {
        private readonly ControladorCompromisso controladorCompromisso;
        private readonly TelaContato telaContato;
        private readonly ControladorContato controladorContato;

        public TelaCompromisso(ControladorCompromisso ctrl, TelaContato tela,
            ControladorContato ctrlContato) : base("Cadastro de Compromissos", ctrl)
        {
            controladorCompromisso = ctrl;
            telaContato = tela;
            controladorContato = ctrlContato;
        }
        public override bool VisualizarRegistros(TipoVisualizacao tipo)
        {
            if (tipo == TipoVisualizacao.Pesquisando)
                return base.VisualizarRegistros(TipoVisualizacao.VisualizandoTela);

            if (tipo == TipoVisualizacao.VisualizandoTela)
                ConfigurarTela(SubtituloDeVisualizacao());


            switch (ObterOpcaoVisualizacao())
            {
                case "1":
                    VisualizarCompromissosPeriodo();
                    break;
                case "2":
                    VisualizarCompromissosPassados();
                    break;
                case "3":
                    VisualizarCompromissosFuturos(); 
                    break;
                case "4":
                    VisualizarCompromissosDaSemana();
                    break;
                case "5":
                    VisualizarCompromissosDoDia();
                    break;
                case "6":
                    VisualizarCompromissosTodos();
                    break;
                default:
                    break;
            }

            return true;
        }
        private void VisualizarCompromissosTodos()
        {
            Console.Clear();
            Console.WriteLine("Visualizando todos os compromissos");

            List<Compromisso> compromissosPassados =
                controladorCompromisso.SelecionarTodos();

            if (compromissosPassados == null || compromissosPassados.Count == 0)
                ApresentarMensagem("Nenhum compromisso encontrado", TipoMensagem.Atencao);
            else
                ApresentarTabela(compromissosPassados);
        }
        private void VisualizarCompromissosDoDia()
        {
            Console.Clear();
            Console.WriteLine("Visualizando os compromissos do dia");

            List<Compromisso> compromissosPassados =
                controladorCompromisso.SelecionarCompromissosDoDia();

            if (compromissosPassados == null || compromissosPassados.Count == 0)
                ApresentarMensagem("Nenhum compromisso encontrado", TipoMensagem.Atencao);
            else
                ApresentarTabela(compromissosPassados);
        }
        private void VisualizarCompromissosDaSemana()
        {
            Console.Clear();
            Console.WriteLine("Visualizando os compromissos da Semana");

            List<Compromisso> compromissosPassados =
                controladorCompromisso.SelecionarCompromissosDaSemana();

            if (compromissosPassados == null || compromissosPassados.Count == 0)
                ApresentarMensagem("Nenhum compromisso encontrado", TipoMensagem.Atencao);
            else
                ApresentarTabela(compromissosPassados);
        }
        private void VisualizarCompromissosFuturos()
        {
            Console.Clear();
            Console.WriteLine("Visualizando todos os compromissos futuros");

            List<Compromisso> compromissosPassados =
                controladorCompromisso.SelecionarCompromissosFuturos();

            if (compromissosPassados == null || compromissosPassados.Count == 0)
                ApresentarMensagem("Nenhum compromisso encontrado", TipoMensagem.Atencao);
            else
                ApresentarTabela(compromissosPassados);
        }
        private void VisualizarCompromissosPeriodo()
        {
            Console.Clear();
            Console.WriteLine("Compromissos Futuros: ");

            Console.WriteLine("Filtros");

            Console.Write("Digite a data inicial: ");
            var dataInicio = Convert.ToDateTime(Console.ReadLine());

            Console.Write("Digite a data final: ");
            var dataFim = Convert.ToDateTime(Console.ReadLine());

            List<Compromisso> compromissosFuturos =
                controladorCompromisso.SelecionarCompromissosPeriodos(dataInicio, dataFim);

            if (compromissosFuturos == null || compromissosFuturos.Count == 0)
                ApresentarMensagem("Nenhum compromisso futuro encontrado", TipoMensagem.Atencao);
            else
                ApresentarTabela(compromissosFuturos);
        }
        private void VisualizarCompromissosPassados()
        {
            Console.Clear();
            Console.WriteLine("Compromissos Passados: ");

            List<Compromisso> compromissosPassados =
                controladorCompromisso.SelecionarCompromissosPassados();

            if (compromissosPassados == null || compromissosPassados.Count == 0)
                ApresentarMensagem("Nenhum compromisso passado encontrado", TipoMensagem.Atencao);
            else
                ApresentarTabela(compromissosPassados);
        }
        private string ObterOpcaoVisualizacao()
        {
            Console.WriteLine("Digite 1 para visualizar compromissos por Periodo");
            Console.WriteLine("Digite 2 para visualizar compromissos Passados");
            Console.WriteLine("Digite 3 para visualizar compromissos Futuros");
            Console.WriteLine("Digite 4 para visualizar compromissos da Semana");
            Console.WriteLine("Digite 5 para visualizar compromissos do Dia");
            Console.WriteLine("Digite 6 para visualizar compromissos Todos");
            Console.WriteLine("Digite S para Voltar");
            Console.WriteLine();

            Console.Write("Opção: ");
            string opcao = Console.ReadLine();

            return opcao;
        }
        public override void ApresentarTabela(List<Compromisso> registros)
        {
            string configuracaoColunasTabela = "{0,-10} | {1,-20} | {2,-20} | {3,-15} | {4,-15} | {5,-15}";

            MontarCabecalhoTabela(configuracaoColunasTabela, "Id", "Assunto", "Data", "Hora de início", "Hora de término", "Contato");

            foreach (Compromisso compromisso in registros)
            {
                Console.WriteLine(configuracaoColunasTabela,
                    compromisso._id, compromisso.Assunto, compromisso.Data.ToShortDateString(), compromisso.HoraInicio, compromisso.HoraTermino, compromisso.Contato?.Nome);
            }
        }
        public override Compromisso ObterRegistro(TipoAcao tipoAcao)
        {
            Console.Write("Digite o assunto do compromisso: ");
            string assunto = Console.ReadLine();

            Console.Write("Digite a data do compromisso: ");
            DateTime data = Convert.ToDateTime(Console.ReadLine());

            Console.Write("Digite a hora de inicio do compromisso [12:00]: ");
            string[] strHoraInicio = Console.ReadLine().Split(':');

            TimeSpan horaInicio = new TimeSpan(int.Parse(strHoraInicio[0]), int.Parse(strHoraInicio[1]), 0);

            Console.Write("Digite a hora de inicio do compromisso [12:00]: ");
            string[] strHoraFim = Console.ReadLine().Split(':');

            TimeSpan horaFim = new TimeSpan(int.Parse(strHoraFim[0]), int.Parse(strHoraFim[1]), 0);

            Console.WriteLine("Deseja marcar um contato neste compromisso [S/N]? ");

            string adicionarContato = Console.ReadLine();

            Contato contato = null;
            if (adicionarContato.Equals("s", StringComparison.OrdinalIgnoreCase))
            {
                var contatos = controladorContato.SelecionarTodos();
                telaContato.ApresentarTabela(contatos);

                Console.Write("Digite o id do contato: ");
                int idContato = Convert.ToInt32(Console.ReadLine());
                contato = controladorContato.SelecionarPorId(idContato);
            }

            Console.WriteLine("\n1 para compromisso presencial");
            Console.WriteLine("2 para compromisso remoto");
            Console.Write("\nDigite a forma como será o compromisso: ");

            string local, link;
            int forma = Convert.ToInt32(Console.ReadLine());
            if (forma == 1)
            {
                Console.Write("Digite o local do compromisso: ");
                local = Console.ReadLine();
                link = "Presencial";
            }
            else
            {
                Console.Write("Digite o link da video chamada: ");
                link = Console.ReadLine();
                local = "Remoto";
            }

            Compromisso comp = new Compromisso(assunto, local, link, data, horaInicio, horaFim, contato, tipoAcao);
            return comp;
        }
    }
}