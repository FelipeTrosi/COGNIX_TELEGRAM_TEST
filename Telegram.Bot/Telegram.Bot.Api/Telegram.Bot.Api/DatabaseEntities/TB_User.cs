using System;
using System.Collections.Generic;

#nullable disable

namespace Telegram.Bot.Api.DatabaseEntities
{
    public partial class TB_User
    {
        public TB_User()
        {
            TB_Assistance_RequestUserFinisheds = new HashSet<TB_Assistance_Request>();
            TB_Assistance_RequestUserRecognizeds = new HashSet<TB_Assistance_Request>();
            TB_Assistance_RequestUserRequests = new HashSet<TB_Assistance_Request>();
            TB_Checklist_Result_Workstations = new HashSet<TB_Checklist_Result_Workstation>();
            TB_Checklist_StepResults = new HashSet<TB_Checklist_StepResult>();
            TB_Defects = new HashSet<TB_Defect>();
            TB_Notification_MessageCreatedUsers = new HashSet<TB_Notification_Message>();
            TB_Notification_MessageMentionedUsers = new HashSet<TB_Notification_Message>();
            TB_Notification_ThirdParty_Configs = new HashSet<TB_Notification_ThirdParty_Config>();
            TB_Order_Production_StatusLogs = new HashSet<TB_Order_Production_StatusLog>();
            TB_Order_Productions = new HashSet<TB_Order_Production>();
            TB_Order_StatusLogs = new HashSet<TB_Order_StatusLog>();
            TB_Production_Loss_Records = new HashSet<TB_Production_Loss_Record>();
            TB_QualityWorkplan_StepResult_StatusLogs = new HashSet<TB_QualityWorkplan_StepResult_StatusLog>();
            TB_QualityWorkplan_StepResults = new HashSet<TB_QualityWorkplan_StepResult>();
            TB_User_Permissions = new HashSet<TB_User_Permission>();
            TB_User_Sessions = new HashSet<TB_User_Session>();
            TB_User_SkillMatrices = new HashSet<TB_User_SkillMatrix>();
            TB_Workflow_Result_StatusLogs = new HashSet<TB_Workflow_Result_StatusLog>();
            TB_Workflow_Results = new HashSet<TB_Workflow_Result>();
            TB_Workinstruction_StepResult_StatusLogs = new HashSet<TB_Workinstruction_StepResult_StatusLog>();
            TB_Workinstruction_StepResults = new HashSet<TB_Workinstruction_StepResult>();
            __LogApplications = new HashSet<__LogApplication>();
        }

        public long Id { get; set; }
        public long? DepartmentId { get; set; }
        public string Name { get; set; }
        public string RegistrationCode { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public int? AcessLevel { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }
        public int Status { get; set; }
        public string AssociatedGroup { get; set; }

        public virtual TB_Department Department { get; set; }
        public virtual ICollection<TB_Assistance_Request> TB_Assistance_RequestUserFinisheds { get; set; }
        public virtual ICollection<TB_Assistance_Request> TB_Assistance_RequestUserRecognizeds { get; set; }
        public virtual ICollection<TB_Assistance_Request> TB_Assistance_RequestUserRequests { get; set; }
        public virtual ICollection<TB_Checklist_Result_Workstation> TB_Checklist_Result_Workstations { get; set; }
        public virtual ICollection<TB_Checklist_StepResult> TB_Checklist_StepResults { get; set; }
        public virtual ICollection<TB_Defect> TB_Defects { get; set; }
        public virtual ICollection<TB_Notification_Message> TB_Notification_MessageCreatedUsers { get; set; }
        public virtual ICollection<TB_Notification_Message> TB_Notification_MessageMentionedUsers { get; set; }
        public virtual ICollection<TB_Notification_ThirdParty_Config> TB_Notification_ThirdParty_Configs { get; set; }
        public virtual ICollection<TB_Order_Production_StatusLog> TB_Order_Production_StatusLogs { get; set; }
        public virtual ICollection<TB_Order_Production> TB_Order_Productions { get; set; }
        public virtual ICollection<TB_Order_StatusLog> TB_Order_StatusLogs { get; set; }
        public virtual ICollection<TB_Production_Loss_Record> TB_Production_Loss_Records { get; set; }
        public virtual ICollection<TB_QualityWorkplan_StepResult_StatusLog> TB_QualityWorkplan_StepResult_StatusLogs { get; set; }
        public virtual ICollection<TB_QualityWorkplan_StepResult> TB_QualityWorkplan_StepResults { get; set; }
        public virtual ICollection<TB_User_Permission> TB_User_Permissions { get; set; }
        public virtual ICollection<TB_User_Session> TB_User_Sessions { get; set; }
        public virtual ICollection<TB_User_SkillMatrix> TB_User_SkillMatrices { get; set; }
        public virtual ICollection<TB_Workflow_Result_StatusLog> TB_Workflow_Result_StatusLogs { get; set; }
        public virtual ICollection<TB_Workflow_Result> TB_Workflow_Results { get; set; }
        public virtual ICollection<TB_Workinstruction_StepResult_StatusLog> TB_Workinstruction_StepResult_StatusLogs { get; set; }
        public virtual ICollection<TB_Workinstruction_StepResult> TB_Workinstruction_StepResults { get; set; }
        public virtual ICollection<__LogApplication> __LogApplications { get; set; }
    }
}
