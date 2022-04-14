using System;

namespace eAgenda.Dominio.Shared
{
    public abstract class EntidadeBase: Object
    {
        public int _id;

        public abstract string Validar();

        protected string QuebraDeLinha(string resultadoValidacao)
        {
            string quebraDeLinha = "";

            if (string.IsNullOrEmpty(resultadoValidacao) == false)
                quebraDeLinha = Environment.NewLine;

            return quebraDeLinha;
        }
    }
}