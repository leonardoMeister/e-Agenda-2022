using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eAgenda.Dominio.TarefaModule
{
    public class Itens
    {
        string _descricao;
        int _porcentagem;

        public string Descricao { get => _descricao; }
        public int Porcentagem { get => _porcentagem;}

        public Itens(string descricao, int porcentagem)
        {
            this._descricao = descricao;
            this._porcentagem = porcentagem;
        }
        public void AtualizarPercentual(int perc)
        {
            this._porcentagem = perc;
        }
        public override string ToString()
        {
            string aux = (_porcentagem == 100) ? "Concluido" : "Sem concluir";
            return $"Titulo Item: {_descricao}, Status Conclusao: {aux}";
        }
        public string Validar()
        {
            string str = "";

            if (_porcentagem < 0 || _porcentagem > 100) str += "Percentual invalido.";
            if (_descricao == "") str += "Descricao invalida..";

            return (str == "") ? "ESTA_VALIDO" : str;
        }
    }
}
