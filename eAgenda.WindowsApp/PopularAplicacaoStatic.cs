using eAgenda.Controladores.CompromissoModule;
using eAgenda.Controladores.ContatoModule;
using eAgenda.Controladores.TarefaModule;
using eAgenda.Dominio.CompromissoModule;
using eAgenda.Dominio.ContatoModule;
using eAgenda.Dominio.Shared;
using eAgenda.Dominio.TarefaModule;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eAgenda.WindowsApp
{
    public class PopularAplicacaoStatic
    {
        public static void PopularAplicacao(ControladorContato controladorContato, ControladorTarefa controladorTarefa, ControladorCompromisso controladorCompromisso)
        {

            #region CONTATO
            Contato contato1 = new Contato("leonardo", "leozinhomm1@gmail.com", "47992398644", "ndd", "func", TipoAcao.Inserindo);
            Contato contato2 = new Contato("pedro", "pedrinhomm1@gmail.com", "47992398644", "ndd", "func", TipoAcao.Inserindo);
            Contato contato3 = new Contato("jose", "josezinhomm1@gmail.com", "47992398644", "mec", "Chefe", TipoAcao.Inserindo);
            Contato contato4 = new Contato("fernando", "fernandinhomm1@gmail.com", "47992398644", "dln", "Chefe", TipoAcao.Inserindo);
            Contato contato5 = new Contato("marco", "marquinhomm1@gmail.com", "47992398644", "klabin", "estagio", TipoAcao.Inserindo);

            controladorContato.InserirNovo(contato1);
            controladorContato.InserirNovo(contato2);
            controladorContato.InserirNovo(contato3);
            controladorContato.InserirNovo(contato4);
            controladorContato.InserirNovo(contato5);
            #endregion

            #region TAREFA
            List<Itens> lista1 = new List<Itens>();
            lista1.Add(new Itens("Coisa a fazer 1", 40));
            lista1.Add(new Itens("Coisa a fazer 2", 60));
            lista1.Add(new Itens("Coisa a fazer 3", 100));
            lista1.Add(new Itens("Coisa a fazer 4", 10));
            Tarefa tarefa1 = new Tarefa("Dever Casa", new DateTime(2002, 06, 20), PrioridadeEnum.Alta, lista1, TipoAcao.Inserindo);

            List<Itens> lista2 = new List<Itens>();
            lista2.Add(new Itens("Coisa a fazer 1", 20));
            lista2.Add(new Itens("Coisa a fazer 2", 13));
            lista2.Add(new Itens("Coisa a fazer 3", 65));
            lista2.Add(new Itens("Coisa a fazer 4", 83));
            Tarefa tarefa2 = new Tarefa("Trabalho", new DateTime(2015, 11, 16), PrioridadeEnum.Baixa, lista2, TipoAcao.Inserindo);
            Tarefa tarefa3 = new Tarefa("Pesquisa", DateTime.Now, PrioridadeEnum.Normal, lista1, TipoAcao.Inserindo);
            Tarefa tarefa4 = new Tarefa("Ir na casa do pedro", DateTime.Now, PrioridadeEnum.Alta, lista2, TipoAcao.Inserindo);

            List<Itens> lista3 = new List<Itens>();
            lista3.Add(new Itens("Coisa a fazer 1", 100));
            lista3.Add(new Itens("Coisa a fazer 2", 100));
            Tarefa tarefa5 = new Tarefa("Fazer atividade", new DateTime(2015, 11, 16), PrioridadeEnum.Baixa, lista3, TipoAcao.Inserindo);

            controladorTarefa.InserirNovo(tarefa1);
            controladorTarefa.InserirNovo(tarefa2);
            controladorTarefa.InserirNovo(tarefa3);
            controladorTarefa.InserirNovo(tarefa4);
            controladorTarefa.InserirNovo(tarefa5);
            #endregion

            #region COMPROMISSO

            //Compromisso de hoje
            Compromisso compromisso1 = new Compromisso("Ir na casa de pedro", "casa do pedro", "Presencial",
                DateTime.Now.Date,
                new TimeSpan(12, 00, 0), new TimeSpan(13, 00, 0), contato3, TipoAcao.Inserindo);
            //Compromisso futuro
            Compromisso compromisso2 = new Compromisso("Falar com professora", "Remoto", "https://meetPedrao.com.br",
                new DateTime((DateTime.Now).AddDays(500).Year, DateTime.Now.Month, DateTime.Now.Day),
                new TimeSpan(14, 00, 0), new TimeSpan(20, 00, 0), contato1, TipoAcao.Inserindo);
            //Compromisso passado
            Compromisso compromisso3 = new Compromisso("Ver notas filho", "Escola", "Presencial",
                new DateTime((DateTime.Now).AddDays(-500).Year, DateTime.Now.Month, DateTime.Now.Day),
                new TimeSpan(8, 00, 0), new TimeSpan(10, 00, 0), contato2, TipoAcao.Inserindo);
            //Compromisso Um dia no futuro
            Compromisso compromisso4 = new Compromisso("ir em algum lugar", "nao sei onde", "Presencial",
                new DateTime(DateTime.Now.Year, DateTime.Now.Month, (DateTime.Now.AddDays(1)).Day),
                new TimeSpan(20, 00, 0), new TimeSpan(22, 00, 0), null, TipoAcao.Inserindo);
            //Compromisso Um dia no passado
            Compromisso compromisso5 = new Compromisso("ir em uma festa", "nao sei onde", "Presencial",
                new DateTime(DateTime.Now.Year, DateTime.Now.Month, (DateTime.Now.AddDays(-1)).Day),
                new TimeSpan(22, 00, 0), new TimeSpan(23, 00, 0), null, TipoAcao.Inserindo);
            //Compromisso no dia de hoje de novo
            Compromisso compromisso6 = new Compromisso("beber agua", "cozinha", "Presencial",
                DateTime.Now.Date,
                new TimeSpan(9, 00, 0), new TimeSpan(9, 30, 0), null, TipoAcao.Inserindo);

            controladorCompromisso.InserirNovo(compromisso1);
            controladorCompromisso.InserirNovo(compromisso2);
            controladorCompromisso.InserirNovo(compromisso3);
            controladorCompromisso.InserirNovo(compromisso4);
            controladorCompromisso.InserirNovo(compromisso5);
            controladorCompromisso.InserirNovo(compromisso6);
            #endregion
        }
    }
}
