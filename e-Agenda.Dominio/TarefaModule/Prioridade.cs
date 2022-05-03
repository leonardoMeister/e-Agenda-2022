using DescriptionLibrary;

namespace eAgenda.Dominio.TarefaModule
{
    public struct Prioridade
    {
        public PrioridadeEnum prioridade;

        public Prioridade(PrioridadeEnum prioridade)
        {
            this.prioridade = prioridade;
        }

        public int Chave
        {
            get
            {
                return (int)prioridade;
            }
            set
            {
                value = (int)prioridade;
            }
        }

        public override bool Equals(object obj)
        {
            return obj is Prioridade prioridade &&
                   this.prioridade == prioridade.prioridade;
        }

        public override int GetHashCode()
        {
            return -1267430178 + prioridade.GetHashCode();
        }

        public override string ToString()
        {
            return prioridade.Description();
        }



    }
}