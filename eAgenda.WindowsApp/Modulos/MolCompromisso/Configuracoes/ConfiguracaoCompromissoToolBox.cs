using eAgenda.WindowsApp.Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eAgenda.WindowsApp.Modulos.MolCompromisso.Configuracoes
{
    public class ConfiguracaoCompromissoToolBox : IConfiguracaoToolBox
    {
        public string ToolTipAdicionar => "Adicionar um novo Compromisso";

        public string TipoCadastro => "Cadastro de Compromisso";

        public string ToolTipEditar => "Editar um Compromisso existente";

        public string ToolTipExcluir => "Excluir um Compromisso existente";
    }
}
