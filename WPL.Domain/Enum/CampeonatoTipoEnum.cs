using System.ComponentModel;

namespace WPL.Domain
{
    public enum CampeonatoTipoEnum
    {
        [Description("Liga")]
        Liga = 1,
        [Description("Eliminatórias")]
        Elimininatorias = 2,
        [Description("Fase Grupos com Eliminatórias")]
        GrupoComEliminatorias = 3,
        [Description("Fase Grupos com Liga")]
        GrupoComLiga = 4
    }
}
