using System;
using System.Collections.Generic;
using System.Linq;

namespace eAgenda.Dominio.ContatoModule
{
    public class AgrupadorContato
    {
        public List<GrupoContato> Agrupar(List<Contato> contatos, Func<Contato, string> campo)
        {
            if (contatos == null || contatos.Count == 0)
                return null;

            List<GrupoContato> grupoContatos = new List<GrupoContato>();

            var agrupamentos = contatos.GroupBy(campo);

            foreach (var contatoAgrupado in agrupamentos)
            {
                GrupoContato gp = new GrupoContato(contatoAgrupado.Key);

                foreach (var contato in contatoAgrupado)
                {
                    gp.AdicionarContato(contato);
                }

                grupoContatos.Add(gp);
            }

            return grupoContatos;
        }
        public List<GrupoContato> AgruparPorCargo(List<Contato> contatos)
        {
            if (contatos == null || contatos.Count == 0)
                return null;

            List<GrupoContato> grupoContatos = new List<GrupoContato>();

            var agrupamentos = contatos.GroupBy(c => c.Cargo);

            foreach (var contatoAgrupado in agrupamentos)
            {
                GrupoContato gp = new GrupoContato(contatoAgrupado.Key);

                foreach (var contato in contatoAgrupado)
                {
                    gp.AdicionarContato(contato);
                }

                grupoContatos.Add(gp);
            }

            return grupoContatos;
        }        
    }
}
