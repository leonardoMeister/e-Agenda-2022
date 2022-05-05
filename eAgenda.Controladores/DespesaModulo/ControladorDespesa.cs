using eAgenda.Controladores.Shared;
using eAgenda.Dominio.DespesaModule;
using eAgenda.Dominio.Shared;
using eAgenda.Serializador.Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eAgenda.Controladores.DespesaModulo
{
    public class ControladorDespesa : Controlador<Despesa>
    {
        public ControladorDespesa()
        {
        }
        public ControladorDespesa(List<Despesa> novaLista)
        {
            this.lista = novaLista;
        }

        public ControladorDespesa(SerializadorBase<Despesa> serial) : base(serial)
        {

        }

        public List<EntidadeBase> SelecionarTodosOrdenadosPorPreco()
        {
            throw new NotImplementedException();
        }

        public List<EntidadeBase> SelecionarTotalGastoNoMes()
        {
            throw new NotImplementedException();
        }

        public List<EntidadeBase> SelecionarTotalGastoPorCategoria()
        {
            throw new NotImplementedException();
        }

        public List<EntidadeBase> SelecionarTotalGastoPorCategoriaNoMes()
        {
            throw new NotImplementedException();
        }
    }
}
