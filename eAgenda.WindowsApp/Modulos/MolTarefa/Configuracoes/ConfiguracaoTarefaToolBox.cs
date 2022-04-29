using eAgenda.WindowsApp.Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eAgenda.WindowsApp.Modulos.MolTarefa.Configuracoes
{
    public class ConfiguracaoTarefaToolBox : IConfiguracaoToolBox
    {
        public string ToolTipAdicionar => "Adicionar uma nova Tarefa";

        public string TipoCadastro => "Cadastro de Tarefas";

        public string ToolTipEditar => "Editar uma Tarefa existente";

        public string ToolTipExcluir => "Excluir uma Tarefa existente";
    }
}
