using eAgenda.Dominio.CompromissoModule;
using eAgenda.Serializador.Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eAgenda.Serializador.ModulosSerializador.CompromissoSerial
{
    public class CompromissoSerializador : SerializadorBase<Compromisso>
    {
        string caminhoArquivo;
        public override string CaminhoArquivoJson => caminhoArquivo;

        public CompromissoSerializador()
        {
            CriarOuEstabelecerCaminhoArquivo();
        }

        private void CriarOuEstabelecerCaminhoArquivo()
        {
            caminhoArquivo = ".CompromissoSerial.json";

        }
    }
}
