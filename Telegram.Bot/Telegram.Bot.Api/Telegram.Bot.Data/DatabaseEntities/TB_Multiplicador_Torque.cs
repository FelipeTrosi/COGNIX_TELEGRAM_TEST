using System;
using System.Collections.Generic;

#nullable disable

namespace Telegram.Bot.Data.DatabaseEntities
{
    public partial class TB_Multiplicador_Torque
    {
        public long IdMultiplicadorTorque { get; set; }
        public string Nome { get; set; }
        public double Fator { get; set; }
        public DateTime? ValidadeInicio { get; set; }
        public DateTime? ValidadeFim { get; set; }
        public string Pset { get; set; }
        public int Situacao { get; set; }
        public long IdControlador { get; set; }
    }
}
