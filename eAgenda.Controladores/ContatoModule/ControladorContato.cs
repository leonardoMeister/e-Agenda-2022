using eAgenda.Controladores.Shared;
using eAgenda.Dominio.ContatoModule;
using System;
using System.Collections.Generic;
using System.Data;

namespace eAgenda.Controladores.ContatoModule
{
    public class ControladorContato : Controlador<Contato>
    {      
        public List<GrupoContato> SelecionarContatosAgrupados(Func<Contato, string> campo)
        {
            var contatos = base.SelecionarTodos();

            return new AgrupadorContato().Agrupar(contatos, campo);
        }

    }
}
