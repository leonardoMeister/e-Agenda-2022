using eAgenda.Controladores.TarefaModule;
using eAgenda.Dominio.TarefaModule;
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
            throw new NotImplementedException();
        }

        public void ExcluirRegistro()
        {
            throw new NotImplementedException();
        }

        public void FiltrarRegistros()
        {
            throw new NotImplementedException();
        }

        public void InserirNovoRegistro()
        {
            throw new NotImplementedException();
        }

        public UserControl ObterTabela()
        {
            List<Tarefa> tarefas = controlador.SelecionarTodos();

            tabelaTarefas.AtualizarRegistros(tarefas);

            return tabelaTarefas;
        }
    }
}
