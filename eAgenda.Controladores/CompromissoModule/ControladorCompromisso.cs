using eAgenda.Controladores.Shared;
using eAgenda.Dominio.CompromissoModule;
using eAgenda.Serializador.Shared;
using System;
using System.Collections.Generic;

namespace eAgenda.Controladores.CompromissoModule
{
    public class ControladorCompromisso : Controlador<Compromisso>
    {
        public ControladorCompromisso()
        {
        }
        public ControladorCompromisso(List<Compromisso> novaLista)
        {
            this.lista = novaLista;
        }

        public ControladorCompromisso(SerializadorBase<Compromisso> serial) : base(serial)
        {

        }

        public override string InserirNovo(Compromisso registro)
        {
            string resultadoValidacao = registro.Validar();

            if (resultadoValidacao == "ESTA_VALIDO")
            {
                bool horarioOcupado = VerificarHorarioOcupado(registro.Data, registro.HoraInicio, registro.HoraTermino);

                if (horarioOcupado)
                    resultadoValidacao = "Nesta data e horário já tem um compromisso agendado";
                else
                    base.InserirNovo(registro);
            }

            return resultadoValidacao;
        }
        public List<Compromisso> SelecionarCompromissosPeriodos(DateTime dataInicio, DateTime dataFim)
        {
            List<Compromisso> lista = SelecionarTodos();
            List<Compromisso> listaNova = new List<Compromisso>();

            foreach (Compromisso compromisso in lista)
            {
                if (compromisso.Data >= DateTime.Now)
                {
                    listaNova.Add(compromisso);
                }
            }
            return listaNova;
        }
        public List<Compromisso> SelecionarCompromissosPassados()
        {
            List<Compromisso> lista = SelecionarTodos();
            List<Compromisso> listaNova = new List<Compromisso>();

            foreach (Compromisso compromisso in lista)
            {
                if (compromisso.Data < DateTime.Now)
                {
                    listaNova.Add(compromisso);
                }
            }
            return listaNova; 
        }
        public List<Compromisso> SelecionarCompromissosDoDia()
        { 
            List<Compromisso> lista = SelecionarTodos();
            List<Compromisso> listaNova = new List<Compromisso>();

            foreach (Compromisso compromisso in lista)
            {
                if (compromisso.Data.Date == DateTime.Now.Date)
                {
                    listaNova.Add(compromisso);
                }
            }
            return listaNova;
        }
        public List<Compromisso> SelecionarCompromissosFuturos()
        {
            List<Compromisso> lista = SelecionarTodos();
            List<Compromisso> listaNova = new List<Compromisso>();

            foreach (Compromisso compromisso in lista)
            {
                if (compromisso.Data.Date > DateTime.Now.Date)
                {
                    listaNova.Add(compromisso);
                }
            }
            return listaNova;
        }
        public List<Compromisso> SelecionarCompromissosDaSemana()
        {
            List<Compromisso> lista = SelecionarTodos();
            List<Compromisso> listaNova = new List<Compromisso>();

            Dictionary<string, int> dicionarioDiasSemana = new Dictionary<string, int>
            {
                {"Sunday", 0 },
                {"Monday", 1 },
                {"Tuesday", 2 },
                {"Wednesday", 3 },
                {"Thursday", 4 },
                {"Friday", 5 },
                {"Saturday", 6 },

            };
            //Data atual da comparação
            DateTime dataSemana = DateTime.Now.Date;
            //voltando ao inicio da semana (sabado)
            dataSemana = dataSemana.AddDays(-dicionarioDiasSemana[dataSemana.DayOfWeek.ToString()]);
            //percorrendo todos oscompromissos
            foreach (Compromisso compromisso in lista)
            {
                //se eles fazem parte do mesmo ano e mês 
                if (compromisso.Data.Year == dataSemana.Year && compromisso.Data.Month == dataSemana.Month)
                {
                    //Criando nova data pra não alterar a data do compromisso
                    DateTime novaData = new DateTime(compromisso.Data.Year, compromisso.Data.Month, compromisso.Data.Day);
                    //voltando ao inicio da semana (sabado)
                    novaData = novaData.AddDays(-dicionarioDiasSemana[novaData.DayOfWeek.ToString()]);
                    
                    //depois de igualar todas as semanas para o sabado verificar se estamos falando da mesma semana/mesmo dia de sabado 
                    if(novaData.Day == dataSemana.Day)
                    {
                        //caso sim ele faz parte da semana e adicionamos na nova lista
                        listaNova.Add(compromisso);
                    }
                }
            }

            return listaNova;
        }
        public bool VerificarHorarioOcupado(DateTime data, TimeSpan horaInicioDesejado, TimeSpan horaTerminoDesejado)
        {
            List<Compromisso> lista = SelecionarTodos();

            foreach (Compromisso compromisso in lista)
            {
                if (compromisso.Data == data)
                {

                    if (horaTerminoDesejado > compromisso.HoraInicio && horaTerminoDesejado < compromisso.HoraTermino)
                        return true;
                    else if (horaInicioDesejado > compromisso.HoraInicio && horaInicioDesejado < compromisso.HoraTermino)
                        return true;
                    else if (compromisso.HoraInicio > horaInicioDesejado && compromisso.HoraInicio < horaTerminoDesejado)
                        return true;
                    else if (compromisso.HoraTermino > horaInicioDesejado && compromisso.HoraTermino < horaTerminoDesejado)
                        return true;
                }
            }
            return false;
        }
    }
}
