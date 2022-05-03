using eAgenda.Controladores.Shared;
using eAgenda.Dominio.TarefaModule;
using eAgenda.Serializador.Shared;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;

namespace eAgenda.Controladores.TarefaModule
{
    public class ControladorTarefa : Controlador<Tarefa>
    {
        public ControladorTarefa()
        {
        }

        public ControladorTarefa(SerializadorBase<Tarefa> serial) : base(serial)
        {
        }

        public override string Editar(int id, Tarefa registro)
        {
            string resultadoValidacao = registro.Validar();

            if (resultadoValidacao == "ESTA_VALIDO")
            {
                registro._id = id;
                Tarefa tar = SelecionarPorId(id);
                registro.DataCriacao = tar.DataCriacao;
                base.Editar(id, registro);
            }

            return resultadoValidacao;
        }
        public string AtualizarPercentual(int id, List<int> lista)
        {
            Tarefa tarefa = SelecionarPorId(id);

            if (tarefa.AtualizarPercentualLista(lista))
            {
                Editar(tarefa._id, tarefa);
            }
            else
            {
                return "Percentuais invalidos.";
            }

            return "";
        }
        public List<Tarefa> SelecionarTodasTarefasConcluidas()
        {
            List<Tarefa> tarefaList = SelecionarTodos();
            List<Tarefa> tarefaNewList = new List<Tarefa>();

            foreach (Tarefa tar in tarefaList)
            {
                if (tar.EstaConcluida()) tarefaNewList.Add(tar);
            }
            return tarefaNewList;
        }
        public List<Tarefa> SelecionarTodasTarefasPendentes()
        {
            List<Tarefa> tarefaList = SelecionarTodos();
            List<Tarefa> tarefaNewList = new List<Tarefa>();

            foreach (Tarefa tar in tarefaList)
            {
                if (!tar.EstaConcluida()) tarefaNewList.Add(tar);
            }
            return tarefaNewList;

        }
        public List<Tarefa> SelecionarTarefasFiltradasPrioridade()
        {
            List<Tarefa> listaNova = new List<Tarefa>();

            var grupo = SelecionarTodos().GroupBy(c => c.Prioridade.ToString());

            foreach (var tarefaAgrupada in grupo)
            {
                foreach (var tarefa in tarefaAgrupada)
                {
                    listaNova.Add(tarefa);
                }
            }

            return listaNova;
        }
    }
}