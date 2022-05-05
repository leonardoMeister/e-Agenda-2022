using eAgenda.WindowsApp.Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eAgenda.WindowsApp.Modulos.MolDespesa.Configuracoes
{
    internal class ConfiguracaoDespesaToolBox : IConfiguracaoToolBox
    {
        public string ToolTipAdicionar => "Adicionar uma nova Despesa";

        public string TipoCadastro => "Cadastro de Despesas";

        public string ToolTipEditar => "Editar uma Despesa Existente";

        public string ToolTipExcluir => "Excluir uma Despesa Existente";

        public string ToolTipoFiltrar => "Filtrar as Despesas";

        public bool DessagruparItens => false;

        public bool AgruparItens => false;
    }
}
