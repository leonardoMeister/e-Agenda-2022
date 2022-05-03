using eAgenda.Dominio.Shared;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;



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

            JsonSerializerSettings settings = new JsonSerializerSettings();

            settings.Formatting = Formatting.Indented;

            List<T> lista = JsonConvert.DeserializeObject<List<T>>(tarefasJson, settings);
            if (lista is null)
                return new List<T>();

            else return lista;
        }

        public void GravarTarefasEmArquivo(List<T> listaEntidadeBase)
        {

            if (File.Exists(CaminhoArquivoJson) == false)
                File.Create(CaminhoArquivoJson);

            JsonSerializerSettings settings = new JsonSerializerSettings();

            settings.Formatting = Formatting.Indented;

            string tarefasJson = JsonConvert.SerializeObject(listaEntidadeBase, settings);

            File.WriteAllText(CaminhoArquivoJson, tarefasJson);

        }
    }
}
