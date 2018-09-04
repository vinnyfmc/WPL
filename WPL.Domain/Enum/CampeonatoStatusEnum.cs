using System.ComponentModel;

namespace WPL.Domain
{
    public enum CampeonatoStatusEnum
    {
        [Description("Aguardando Início")]
        AguardandoInicio = 1,
        [Description("Ativo")]
        Ativo = 2,
        [Description("Inativo")]
        Inativo = 3,
        [Description("Pausado temporariamente")]
        PausadoTemporariamente = 4,
        [Description("Cancelado")]
        Cancelado = 5
    }
}
