using System;
using System.Collections.Generic;

#nullable disable

namespace Telegram.Bot.Api.DatabaseEntities
{
    public partial class TB_Result
    {
        public long ResultID { get; set; }
        public long InsertResultID { get; set; }
        public long SystemID { get; set; }
        public long GroupID { get; set; }
        public long SpindleID { get; set; }
        public long BoltID { get; set; }
        public long TighteningID { get; set; }
        public DateTime TimeStamp { get; set; }
        public DateTime DateTtimelastPset { get; set; }
        public int? JobNumber { get; set; }
        public int? PsetNumber { get; set; }
        public int? BatchSize { get; set; }
        public int? BatchCounter { get; set; }
        public int TighteningStatus { get; set; }
        public int BatchStatus { get; set; }
        public int StatusCode { get; set; }
        public long? GraphExist { get; set; }
        public int TorqueStatus { get; set; }
        public int AngleStatus { get; set; }
        public float TorqueMin { get; set; }
        public float TorqueMax { get; set; }
        public float TorqueFinalTarget { get; set; }
        public float TorqueValue { get; set; }
        public float AngleMin { get; set; }
        public float AngleMax { get; set; }
        public float FinalAngleTarget { get; set; }
        public float AngleValue { get; set; }
        public int? Strategy { get; set; }
        public int? TighteningErrorStatus { get; set; }
        public string ParameterSetName { get; set; }
        public int? TorqueValuesUnit { get; set; }
        public int? ResultType { get; set; }
        public string Identifier_result_part_2 { get; set; }
        public string Identifier_result_part_3 { get; set; }
        public string Identifier_result_part_4 { get; set; }
        public int? DiarioBordo { get; set; }
    }
}
