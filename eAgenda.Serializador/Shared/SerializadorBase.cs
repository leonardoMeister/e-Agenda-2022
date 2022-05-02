using eAgenda.Dominio.Shared;
using System.Collections.Generic;
using System.IO;
using System.Text.Json;

namespace eAgenda.Serializador.Shared
{
    public  class SerializadorBase<T> where T : EntidadeBase
    {

        public virtual string CaminhoArquivoJson { get; }

        public List<T> CarregarTarefasDoArquivo()
        {
            if (File.Exists(CaminhoArquivoJson) == false)
                return new List<T>();

            string tarefasJson = File.ReadAllText(CaminhoArquivoJson);

            return JsonSerializer.Deserialize<List<T>>(tarefasJson);
        }

        public void GravarTarefasEmArquivo(List<T> listaEntidadeBase)
        {
            var config = new JsonSerializerOptions { WriteIndented = true };

            string tarefasJson = JsonSerializer.Serialize(listaEntidadeBase, config);

            File.WriteAllText(CaminhoArquivoJson, tarefasJson);
        }
    }
}
