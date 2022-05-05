using eAgenda.Dominio.Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eAgenda.Dominio.DespesaModule
{
    public class Despesa : EntidadeBase
    {

        private static int id = 1;

        string _formaDePagamento;
        string _descricao;
        CategoriaEnum _categoria;
        double _valor;
        DateTime _dataDespesa;

        public Despesa(string formaDePagamento, string descricao, CategoriaEnum categoria, double valor)
        {
            this.FormaDePagamento = formaDePagamento;
            this.Descricao = descricao;
            this.Categoria = categoria;
            this.Valor = valor;
        }

        public string FormaDePagamento { get => _formaDePagamento; set => _formaDePagamento = value; }
        public string Descricao { get => _descricao; set => _descricao = value; }
        public CategoriaEnum Categoria { get => _categoria; set => _categoria = value; }
        public double Valor { get => _valor; set => _valor = value; }
        public DateTime DataDespesa { get => _dataDespesa; set => _dataDespesa = value; }

        public void GerarId()
        {
            this._id = id;
            id += 1;
        }
        public override string ToString()
        {
            return $"Descrição: {Descricao}, Categoria: {Categoria.ToString()}, Valor: {Valor}";
        }
        public override string Validar()
        {
            string resultadoValidacao = "";

            


            if (resultadoValidacao == "")
                resultadoValidacao = "ESTA_VALIDO";

            return resultadoValidacao;
        }
    }

}
