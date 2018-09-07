using System.ComponentModel;

namespace WPL.Domain
{
    public enum JogoStatusEnum
    {
        [Description("Criado")]
        Criado = 1,
        [Description("Confirmado por um time")]
        ConfirmadoPorUmTime = 2,
        [Description("Confirmado")]
        Confirmado = 3,
        [Description("Concluido")]
        Concluido = 4,
        [Description("Cancelado")]
        Cancelado = 5,
        [Description("Suspenso")]
        Suspenso = 6,
        [Description("Análise de fraude")]
        AnaliseFraude = 7
    }
}
