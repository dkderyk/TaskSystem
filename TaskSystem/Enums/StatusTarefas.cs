﻿using System.ComponentModel;

namespace TaskSystem.Enums
{
    public enum StatusTarefas
    {
        [Description("A Fazer")]
        AFazer = 1,
        [Description("Em Andamento")]
        EmAndamento = 2,
        [Description("Concluido")]
        Concluido = 3,
    }
}
