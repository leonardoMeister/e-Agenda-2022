using eAgenda.Dominio.ContatoModule;
using eAgenda.Serializador.Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eAgenda.Serializador.ModulosSerializador.ContatoSerial
{
    public class ContatoSerializador : SerializadorBase<Contato>
    {
        string caminhoArquivo;
        public override string CaminhoArquivoJson => caminhoArquivo;

        public ContatoSerializador()
        { 
            CriarOuEstabelecerCaminhoArquivo();
        }

        private void CriarOuEstabelecerCaminhoArquivo()
        {
            caminhoArquivo = ".ContatoSerial.json";

        }

    }
}
