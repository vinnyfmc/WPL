using System.ComponentModel;

namespace WPL.Domain
{
    public enum TimeStatusEnum
    {
        [Description("Ativo")]
        Ativo = 1,
        [Description("Inativo")]
        Inativo = 2,
        [Description("Banido temporariamente")]
        BanidoTemporariamente = 3,
        [Description("Banido")]
        BanidoEternamente = 4
    }
}
