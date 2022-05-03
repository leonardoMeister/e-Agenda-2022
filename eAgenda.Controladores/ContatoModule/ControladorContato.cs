using eAgenda.Controladores.Shared;
using eAgenda.Dominio.ContatoModule;
using eAgenda.Dominio.Shared;
using eAgenda.Serializador.ModulosSerializador.TarefaSerial;
using eAgenda.Serializador.Shared;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;

namespace eAgenda.Controladores.ContatoModule
{
    public class ControladorContato : Controlador<Contato>
    {
        public ControladorContato()
        {
        }

        public ControladorContato(SerializadorBase<Contato> serial) : base(serial)
        {
        }

        public List<GrupoContato> SelecionarContatosAgrupados(Func<Contato, string> campo)
        {
            var contatos = base.SelecionarTodos();

            return new AgrupadorContato().Agrupar(contatos, campo);
        }

        public List<EntidadeBase> SelecionarContatosEmOrdemAlfabetica()
        {
            return base.SelecionarTodos().OrderBy(x => x.Nome).Cast<EntidadeBase>().ToList();
        }
    }
}
