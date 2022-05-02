using eAgenda.Dominio.ContatoModule;
using eAgenda.Dominio.Shared;
using eAgenda.Dominio.TarefaModule;
using eAgenda.Serializador.Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eAgenda.Serializador.ModulosSerializador.TarefaSerial
{
    public class TarefaSerializador : SerializadorBase<Contato>
    {
        string caminhoArquivo;
        public override string CaminhoArquivoJson => caminhoArquivo;

        public TarefaSerializador()
        {
            CriarOuEstabelecerCaminhoArquivo();
        }

        private void CriarOuEstabelecerCaminhoArquivo()
        {
            caminhoArquivo = "";

        }
    }
}
