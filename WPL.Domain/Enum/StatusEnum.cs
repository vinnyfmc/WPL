﻿using System.ComponentModel;

namespace WPL.MongoDB.Domain
{
    public enum StatusEnum
    {
        [Description("Inativo")]
        Inativo = 0,
        [Description("Ativo")]
        Ativo = 1
    }
}
