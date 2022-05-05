using eAgenda.Controladores.Shared;
using eAgenda.Dominio.DespesaModule;
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


    }
}
