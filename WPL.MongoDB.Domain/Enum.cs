using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace WPL.MongoDB.Domain
{
    public class Enum
    {
        public enum StatusEnum
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

        public enum ModalityEnum
        {
            [Description("Player Vs Player")]
            PVP = 1,
            [Description("Team Vs Team")]
            TVT = 2
        }

        public enum ChampionshipStatusEnum
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

        public enum ChampionshipType
        {
            [Description("Eliminatórias")]
            Eliminatoria = 1,
            [Description("Fase de Grupos")]
            FaseGrupo = 2,
            [Description("Liga")]
            Liga = 3
        }

        public enum MatchStatusEnum
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
}
