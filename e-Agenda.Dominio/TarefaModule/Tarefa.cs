using eAgenda.Dominio.Shared;
using System;
using System.Collections.Generic;


namespace eAgenda.Dominio.TarefaModule
{
    public class Tarefa : EntidadeBase, IEquatable<Tarefa>
    {
        private static int id = 1;
        public string Titulo { get; }

        public Prioridade Prioridade { get; }

        public DateTime? DataCriacao { get; set; }

        public int Percentual { get; private set; }

        public DateTime? DataConclusao { get; private set; }
        public List<Itens> ListaItens { get; private set; }

        public Tarefa()
        {
            this._id = 0;
            ListaItens = new List<Itens>();
        }

        public Tarefa(string titulo, DateTime? dataCriacao, PrioridadeEnum prioridade, List<Itens> lista, TipoAcao tipoAcao, Tarefa tar = null)
        {
            Titulo = titulo;
            if (!(dataCriacao is null))
                DataCriacao = dataCriacao.Value;
            Prioridade = new Prioridade(prioridade);
            ListaItens = lista;
            GerarPorcentagemTarefa();
            if (tipoAcao.ToString() == TipoAcao.Inserindo.ToString())
            {
                GerarId();
            } else if (tipoAcao.ToString() == TipoAcao.Editando.ToString())
            {
                this._id = tar._id;
                this.DataCriacao = tar.DataCriacao;
            }
        }
        public bool AtualizarPercentualLista(List<int> lista)
        {       
            if (!ValidarPorcentagens(lista)) return false;

            for (int x = 0; x < lista.Count; x++)
            {
                ListaItens[x].AtualizarPercentual(lista[x]);
            }
            GerarPorcentagemTarefa();
            return true;
        }
        private void GerarPorcentagemTarefa()
        {
            if(ListaItens.Count <= 0)
            {
                Percentual = 0;
                return;
            }
            int soma = 0;
            foreach (Itens item in ListaItens)
            {
                soma += item.Porcentagem;
            }
            int resultado = soma / ListaItens.Count;
            Percentual = resultado;

            if (EstaConcluida())
            {
                DataConclusao = DateTime.Now;
            }
        }
        private bool ValidarPorcentagens(List<int> lista)
        {
            foreach (int nu in lista)
            {
                if (nu < 0 || nu > 100) return false;
            }
            return true;
        }
        public override bool Equals(object obj)
        {
            return Equals(obj as Tarefa);
        }
        public bool Equals(Tarefa other)
        {
            return other != null &&
                   _id == other._id &&
                   Titulo == other.Titulo &&
                   DataConclusao == other.DataConclusao &&
                   Percentual == other.Percentual &&
                   EqualityComparer<Prioridade>.Default.Equals(Prioridade, other.Prioridade) &&
                   DataCriacao == other.DataCriacao;
        }
        public bool EstaConcluida()
        {
            return Percentual == 100;
        }
        public override int GetHashCode()
        {
            int hashCode = -1307587567;
            hashCode = hashCode * -1521134295 + _id.GetHashCode();
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(Titulo);
            hashCode = hashCode * -1521134295 + DataConclusao.GetHashCode();
            hashCode = hashCode * -1521134295 + Percentual.GetHashCode();
            hashCode = hashCode * -1521134295 + EqualityComparer<Prioridade>.Default.GetHashCode(Prioridade);
            hashCode = hashCode * -1521134295 + DataCriacao.GetHashCode();
            return hashCode;
        }
        public override string Validar()
        {
            string resultadoValidacao = "";

            if (string.IsNullOrEmpty(Titulo))
                resultadoValidacao = "O campo Título é obrigatório";

            if (DataCriacao == DateTime.MinValue)
                resultadoValidacao += QuebraDeLinha(resultadoValidacao) + "O campo Data de Criação é obrigatório";

            if (resultadoValidacao == "")
                resultadoValidacao = "ESTA_VALIDO";

            return resultadoValidacao;
        }
        public void GerarId()
        {
            this._id = id;
            id += 1;
        }
    }
}