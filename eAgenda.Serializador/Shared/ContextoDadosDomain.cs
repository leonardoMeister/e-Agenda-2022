using eAgenda.Dominio.CompromissoModule;
using eAgenda.Dominio.ContatoModule;
using eAgenda.Dominio.Shared;
using eAgenda.Dominio.TarefaModule;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;


namespace eAgenda.Serializador.Shared
{
    public class ContextoDadosDomain 
    {
        private string caminhoArquivo = ".ContextoDadosDomain.json";

        private List<Compromisso> listaCompro;
        private List<Tarefa> listTarefa;
        private List<Contato> listContato;

        public List<Compromisso> ListaCompro { get => listaCompro; set => listaCompro = value; }
        public List<Tarefa> ListTarefa { get => listTarefa; set => listTarefa = value; }
        public List<Contato> ListContato { get => listContato; set => listContato = value; }

        public ContextoDadosDomain(List<Compromisso> listaCompro, List<Tarefa> listTarefa, List<Contato> listContato)
        {
            this.listaCompro = listaCompro;
            this.listTarefa = listTarefa;
            this.listContato = listContato;            
        }
        public ContextoDadosDomain()
        {
            this.listaCompro = new List<Compromisso>();
            this.listTarefa = new List<Tarefa> ();
            this.listContato = new List<Contato>();
        }

        public ContextoDadosDomain CarregarTarefasDoArquivo()
        {

            if (File.Exists(caminhoArquivo) == false)
                return new ContextoDadosDomain();

            string tarefasJson = File.ReadAllText(caminhoArquivo);

            JsonSerializerSettings settings = new JsonSerializerSettings();

            settings.Formatting = Formatting.Indented;
            settings.PreserveReferencesHandling = PreserveReferencesHandling.All;
            ContextoDadosDomain arquivo = JsonConvert.DeserializeObject<ContextoDadosDomain>(tarefasJson, settings);
            if (arquivo is null)
                return new ContextoDadosDomain();

            else return arquivo;
        }
        public void GravarTarefasEmArquivo(ContextoDadosDomain contextoDomain)
        {

            if (File.Exists(caminhoArquivo) == false)
                File.Create(caminhoArquivo);

            JsonSerializerSettings settings = new JsonSerializerSettings();

            settings.Formatting = Formatting.Indented;
            settings.PreserveReferencesHandling = PreserveReferencesHandling.All;

            string tarefasJson = JsonConvert.SerializeObject(contextoDomain, settings);

            File.WriteAllText(caminhoArquivo, tarefasJson);
        }

    }
}
