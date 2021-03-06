using eAgenda.Dominio.TarefaModule;
using eAgenda.Serializador.Shared;


namespace eAgenda.Serializador.ModulosSerializador.TarefaSerial
{
    public class TarefaSerializador : SerializadorBase<Tarefa>
    {
        string caminhoArquivo;
        public override string CaminhoArquivoJson => caminhoArquivo;

        public TarefaSerializador()
        {
            caminhoArquivo = ".TarefaSerial.json";
        }
    }
}
