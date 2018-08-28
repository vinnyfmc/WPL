using System.ComponentModel;

namespace WPL.Domain
{
    public enum JogadorStatusEnum
    {
        [Description("Criado")]
        CRIADO = 1,
        [Description("Ativo")]
        ATIVO = 2,
        [Description("Inativo")]
        INATIVO = 3,
        [Description("Banido temporariamente")]
        BANIDOTEMPORARIAMENTE = 4,
        [Description("Banido")]
        BANIDOETERNAMENTE = 5
    }
}
