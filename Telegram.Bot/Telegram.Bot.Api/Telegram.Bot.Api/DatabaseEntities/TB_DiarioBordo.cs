using System;
using System.Collections.Generic;

#nullable disable

namespace Telegram.Bot.Api.DatabaseEntities
{
    public partial class TB_DiarioBordo
    {
        public long idDiarioBordo { get; set; }
        public int? idRecurso { get; set; }
        public int? idUsuario { get; set; }
        public string Operacao { get; set; }
        public DateTime? Data { get; set; }
        public string Anomalia { get; set; }
        public string Acao { get; set; }
        public string Responsavel { get; set; }
        public DateTime? Prazo { get; set; }
        public int? EtapaId { get; set; }
        public string Etapa { get; set; }
        public int? Situacao { get; set; }
        public string Justificativa { get; set; }
    }
}
