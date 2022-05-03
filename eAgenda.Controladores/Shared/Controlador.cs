using eAgenda.Dominio.Shared;
using eAgenda.Dominio.TarefaModule;
using eAgenda.Serializador.ModulosSerializador.TarefaSerial;
using eAgenda.Serializador.Shared;
using System;
using System.Collections.Generic;

namespace eAgenda.Controladores.Shared
{
    public class Controlador<T> where T : EntidadeBase
    {
        public List<T> lista = new List<T>();

        SerializadorBase<T> serializador;

        public Controlador(SerializadorBase<T> serial )
        {
            serializador = serial;

            if (SerialNaoEhNulo())
            {
                serializador = serial;
                lista =  serializador.CarregarTarefasDoArquivo();
            }
        }

        public Controlador()
        {
        }

        private  bool SerialNaoEhNulo()
        {
            return !(serializador is null);
        }

        public virtual string InserirNovo(T registro)
        {
            string resultadoValidacao = registro.Validar();

            if (resultadoValidacao == "ESTA_VALIDO")
            {
                lista.Add(registro);
                if (SerialNaoEhNulo())
                {
                    serializador.GravarTarefasEmArquivo(lista);
                }
                return "ESTA_VALIDO";
            }
            else
                return resultadoValidacao;
        }
        public virtual string Editar(int id, T registro)
        {
            string resultadoValidacao = registro.Validar();

            if (resultadoValidacao == "ESTA_VALIDO")
            {
                registro._id = id;
                lista[lista.FindIndex(x => x._id == id)] = registro;
                if (SerialNaoEhNulo())
                {
                    serializador.GravarTarefasEmArquivo(lista);
                }
                return "ESTA_VALIDO";
            }
            else
                return resultadoValidacao;
        }
        public virtual bool Existe(int id)
        {
            T item = lista.Find(x => x._id == id);
            return (item != null) ? true : false;
        }
        public virtual bool Excluir(int id)
        {
            lista.RemoveAt(lista.FindIndex(x => x._id == id));
            if (SerialNaoEhNulo())
            {
                serializador.GravarTarefasEmArquivo(lista);
            }
            return true;
        }
        public virtual List<T> SelecionarTodos()
        {
            List<T> novaLista = new List<T>(lista);
            return novaLista;
        }
        public virtual T SelecionarPorId(int id)
        {
            return lista.Find(x => x._id == id);
        }

    }
}