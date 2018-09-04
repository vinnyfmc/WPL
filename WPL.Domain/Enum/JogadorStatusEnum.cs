using System.ComponentModel;

namespace WPL.Domain
{
    public enum JogadorStatusEnum
    {
        [Description("Criado")]
        Criado = 1,
        [Description("Ativo")]
        Ativo = 2,
        [Description("Inativo")]
        Inativo = 3,
        [Description("Banido temporariamente")]
        BanidoTemporariamente = 4,
        [Description("Banido")]
        BanidoEternamente = 5
    }
}
