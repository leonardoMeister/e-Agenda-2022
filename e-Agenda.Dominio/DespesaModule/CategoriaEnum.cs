using System.ComponentModel;

namespace eAgenda.Dominio.DespesaModule
{
    public enum CategoriaEnum : int
    {
        [Description("Mercado")]
        Mercado = 0,

        [Description("Padaria")]
        Padaria = 1,

        [Description("Farmacia")]
        Farmacia = 2
    }
}