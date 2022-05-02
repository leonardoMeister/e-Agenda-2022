using eAgenda.Dominio.TarefaModule;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using teste1.Shared;

namespace teste1.Modulos.TarefaSerial
{
    public class TarefaSerializador : SerializadorBase<Tarefa>
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
