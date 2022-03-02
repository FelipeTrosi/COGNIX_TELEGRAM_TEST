using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

#nullable disable

namespace Telegram.Bot.Data.DatabaseEntities
{
    public partial class DatabaseContext : DbContext
    {
        public DatabaseContext()
        {
        }

        public DatabaseContext(DbContextOptions<DatabaseContext> options)
            : base(options)
        {
        }

        public virtual DbSet<TB_Assistance_Request> TB_Assistance_Requests { get; set; }
        public virtual DbSet<TB_AvaliableParameter> TB_AvaliableParameters { get; set; }
        public virtual DbSet<TB_BOM> TB_BOMs { get; set; }
        public virtual DbSet<TB_Checklist_Result_Workstation> TB_Checklist_Result_Workstations { get; set; }
        public virtual DbSet<TB_Checklist_StepResult> TB_Checklist_StepResults { get; set; }
        public virtual DbSet<TB_Checklist_StepResult_Code> TB_Checklist_StepResult_Codes { get; set; }
        public virtual DbSet<TB_Checklist_StepResult_Dimensional> TB_Checklist_StepResult_Dimensionals { get; set; }
        public virtual DbSet<TB_Checklist_StepResult_Tightening> TB_Checklist_StepResult_Tightenings { get; set; }
        public virtual DbSet<TB_Checklist_StepResult_Value> TB_Checklist_StepResult_Values { get; set; }
        public virtual DbSet<TB_Checklist_StepResult_View> TB_Checklist_StepResult_Views { get; set; }
        public virtual DbSet<TB_Client> TB_Clients { get; set; }
        public virtual DbSet<TB_Defect> TB_Defects { get; set; }
        public virtual DbSet<TB_Defect_Type> TB_Defect_Types { get; set; }
        public virtual DbSet<TB_Department> TB_Departments { get; set; }
        public virtual DbSet<TB_DiarioBordo> TB_DiarioBordos { get; set; }
        public virtual DbSet<TB_Equipment> TB_Equipments { get; set; }
        public virtual DbSet<TB_Equipment_PLC_Tag> TB_Equipment_PLC_Tags { get; set; }
        public virtual DbSet<TB_Graph> TB_Graphs { get; set; }
        public virtual DbSet<TB_Identifier> TB_Identifiers { get; set; }
        public virtual DbSet<TB_LocationParameter> TB_LocationParameters { get; set; }
        public virtual DbSet<TB_MaintenanceParameter> TB_MaintenanceParameters { get; set; }
        public virtual DbSet<TB_ManPowerParameter> TB_ManPowerParameters { get; set; }
        public virtual DbSet<TB_MaterialLocation> TB_MaterialLocations { get; set; }
        public virtual DbSet<TB_Multiplicador_Torque> TB_Multiplicador_Torques { get; set; }
        public virtual DbSet<TB_Notification_Message> TB_Notification_Messages { get; set; }
        public virtual DbSet<TB_Notification_ThirdParty_Config> TB_Notification_ThirdParty_Configs { get; set; }
        public virtual DbSet<TB_OP_Alarm> TB_OP_Alarms { get; set; }
        public virtual DbSet<TB_OP_AlarmError> TB_OP_AlarmErrors { get; set; }
        public virtual DbSet<TB_Order> TB_Orders { get; set; }
        public virtual DbSet<TB_Order_Partnumber> TB_Order_Partnumbers { get; set; }
        public virtual DbSet<TB_Order_Production> TB_Order_Productions { get; set; }
        public virtual DbSet<TB_Order_Production_StatusLog> TB_Order_Production_StatusLogs { get; set; }
        public virtual DbSet<TB_Order_StatusLog> TB_Order_StatusLogs { get; set; }
        public virtual DbSet<TB_PerformanceParameter> TB_PerformanceParameters { get; set; }
        public virtual DbSet<TB_Product> TB_Products { get; set; }
        public virtual DbSet<TB_Product_Aux> TB_Product_Auxes { get; set; }
        public virtual DbSet<TB_Product_BOM> TB_Product_BOMs { get; set; }
        public virtual DbSet<TB_ProductionParameter> TB_ProductionParameters { get; set; }
        public virtual DbSet<TB_Production_Loss> TB_Production_Losses { get; set; }
        public virtual DbSet<TB_Production_Loss_Record> TB_Production_Loss_Records { get; set; }
        public virtual DbSet<TB_Production_Loss_Type> TB_Production_Loss_Types { get; set; }
        public virtual DbSet<TB_Provider> TB_Providers { get; set; }
        public virtual DbSet<TB_QualityWorkplan_Code> TB_QualityWorkplan_Codes { get; set; }
        public virtual DbSet<TB_QualityWorkplan_Dimensional> TB_QualityWorkplan_Dimensionals { get; set; }
        public virtual DbSet<TB_QualityWorkplan_StepResult> TB_QualityWorkplan_StepResults { get; set; }
        public virtual DbSet<TB_QualityWorkplan_StepResult_StatusLog> TB_QualityWorkplan_StepResult_StatusLogs { get; set; }
        public virtual DbSet<TB_Result> TB_Results { get; set; }
        public virtual DbSet<TB_Retentive> TB_Retentives { get; set; }
        public virtual DbSet<TB_Schema_Measurement> TB_Schema_Measurements { get; set; }
        public virtual DbSet<TB_Shift> TB_Shifts { get; set; }
        public virtual DbSet<TB_Tool> TB_Tools { get; set; }
        public virtual DbSet<TB_Tool_Automated> TB_Tool_Automateds { get; set; }
        public virtual DbSet<TB_User> TB_Users { get; set; }
        public virtual DbSet<TB_User_Permission> TB_User_Permissions { get; set; }
        public virtual DbSet<TB_User_Session> TB_User_Sessions { get; set; }
        public virtual DbSet<TB_User_SkillMatrix> TB_User_SkillMatrices { get; set; }
        public virtual DbSet<TB_Wokarea> TB_Wokareas { get; set; }
        public virtual DbSet<TB_Workbox> TB_Workboxes { get; set; }
        public virtual DbSet<TB_Workflow_Product> TB_Workflow_Products { get; set; }
        public virtual DbSet<TB_Workflow_Result> TB_Workflow_Results { get; set; }
        public virtual DbSet<TB_Workflow_Result_StatusLog> TB_Workflow_Result_StatusLogs { get; set; }
        public virtual DbSet<TB_Workinstruction_StepResult> TB_Workinstruction_StepResults { get; set; }
        public virtual DbSet<TB_Workinstruction_StepResult_Code> TB_Workinstruction_StepResult_Codes { get; set; }
        public virtual DbSet<TB_Workinstruction_StepResult_IO> TB_Workinstruction_StepResult_IOs { get; set; }
        public virtual DbSet<TB_Workinstruction_StepResult_StatusLog> TB_Workinstruction_StepResult_StatusLogs { get; set; }
        public virtual DbSet<TB_Workinstruction_StepResult_Test> TB_Workinstruction_StepResult_Tests { get; set; }
        public virtual DbSet<TB_Workinstruction_StepResult_Torque> TB_Workinstruction_StepResult_Torques { get; set; }
        public virtual DbSet<TB_Workline> TB_Worklines { get; set; }
        public virtual DbSet<TB_Workline_Configuration> TB_Workline_Configurations { get; set; }
        public virtual DbSet<TB_Workline_PitchTime> TB_Workline_PitchTimes { get; set; }
        public virtual DbSet<TB_Workplant> TB_Workplants { get; set; }
        public virtual DbSet<TB_Workstation> TB_Workstations { get; set; }
        public virtual DbSet<__LogApplication> __LogApplications { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseSqlServer("Server=10.11.12.10,1432;Database=LSM_MESDB_FPT_NEF_HOMOLOG;Persist Security Info=true; User Id=sa; Password=Cnxsql2015");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("Relational:Collation", "SQL_Latin1_General_CP1_CI_AS");

            modelBuilder.Entity<TB_Assistance_Request>(entity =>
            {
                entity.ToTable("TB_Assistance_Request");

                entity.HasIndex(e => e.UserFinishedId, "IX_TB_Assistance_Request_UserFinishedId");

                entity.HasIndex(e => e.UserRecognizedId, "IX_TB_Assistance_Request_UserRecognizedId");

                entity.HasIndex(e => e.UserRequestId, "IX_TB_Assistance_Request_UserRequestId");

                entity.HasIndex(e => e.WorkstationId, "IX_TB_Assistance_Request_WorkstationId");

                entity.Property(e => e.Code).HasMaxLength(50);

                entity.Property(e => e.FinishedDateTime).HasColumnType("datetime");

                entity.Property(e => e.RecognizedDateTime).HasColumnType("datetime");

                entity.Property(e => e.RequestDateTime).HasColumnType("datetime");

                entity.HasOne(d => d.UserFinished)
                    .WithMany(p => p.TB_Assistance_RequestUserFinisheds)
                    .HasForeignKey(d => d.UserFinishedId)
                    .HasConstraintName("FK_TB_Assistance_Request_TB_User_Finished_Id");

                entity.HasOne(d => d.UserRecognized)
                    .WithMany(p => p.TB_Assistance_RequestUserRecognizeds)
                    .HasForeignKey(d => d.UserRecognizedId)
                    .HasConstraintName("FK_TB_Assistance_Request_TB_User_Recognized_Id");

                entity.HasOne(d => d.UserRequest)
                    .WithMany(p => p.TB_Assistance_RequestUserRequests)
                    .HasForeignKey(d => d.UserRequestId)
                    .HasConstraintName("FK_TB_Assistance_Request_TB_User_Request_Id");

                entity.HasOne(d => d.Workstation)
                    .WithMany(p => p.TB_Assistance_Requests)
                    .HasForeignKey(d => d.WorkstationId)
                    .HasConstraintName("FK_TB_Assistance_Request_TB_Workstation_Id");
            });

            modelBuilder.Entity<TB_AvaliableParameter>(entity =>
            {
                entity.ToTable("TB_AvaliableParameter");
            });

            modelBuilder.Entity<TB_BOM>(entity =>
            {
                entity.ToTable("TB_BOM");

                entity.HasIndex(e => e.ParentMaterialId, "IX_TB_BOM_ParentMaterialId");

                entity.HasIndex(e => e.ProviderId, "IX_TB_BOM_ProviderId");

                entity.Property(e => e.IsActived).HasDefaultValueSql("((1))");

                entity.Property(e => e.Material)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.Qty).HasDefaultValueSql("((1))");

                entity.Property(e => e.RevisionNumber).HasDefaultValueSql("((1))");

                entity.HasOne(d => d.ParentMaterial)
                    .WithMany(p => p.InverseParentMaterial)
                    .HasForeignKey(d => d.ParentMaterialId)
                    .HasConstraintName("FK_TB_BOM_ParentMaterial");

                entity.HasOne(d => d.Provider)
                    .WithMany(p => p.TB_BOMs)
                    .HasForeignKey(d => d.ProviderId);
            });

            modelBuilder.Entity<TB_Checklist_Result_Workstation>(entity =>
            {
                entity.ToTable("TB_Checklist_Result_Workstation");

                entity.HasIndex(e => e.OrderProductionId, "IX_TB_Checklist_Result_Workstation_OrderProductionId");

                entity.HasIndex(e => e.UserId, "IX_TB_Checklist_Result_Workstation_UserId");

                entity.HasIndex(e => e.WorkstationId, "IX_TB_Checklist_Result_Workstation_WorkstationId");

                entity.Property(e => e.ChecklistCode)
                    .HasMaxLength(60)
                    .IsUnicode(false);

                entity.Property(e => e.ChecklistId)
                    .HasMaxLength(32)
                    .IsUnicode(false);

                entity.Property(e => e.ChecklistName)
                    .HasMaxLength(80)
                    .IsUnicode(false);

                entity.Property(e => e.FinishedDateTime).HasColumnType("datetime");

                entity.Property(e => e.SerialNumber)
                    .HasMaxLength(60)
                    .IsUnicode(false);

                entity.Property(e => e.StartedDateTime).HasColumnType("datetime");

                entity.HasOne(d => d.OrderProduction)
                    .WithMany(p => p.TB_Checklist_Result_Workstations)
                    .HasForeignKey(d => d.OrderProductionId);

                entity.HasOne(d => d.User)
                    .WithMany(p => p.TB_Checklist_Result_Workstations)
                    .HasForeignKey(d => d.UserId);

                entity.HasOne(d => d.Workstation)
                    .WithMany(p => p.TB_Checklist_Result_Workstations)
                    .HasForeignKey(d => d.WorkstationId);
            });

            modelBuilder.Entity<TB_Checklist_StepResult>(entity =>
            {
                entity.ToTable("TB_Checklist_StepResult");

                entity.HasIndex(e => e.ChecklistResultWorkstationId, "IX_TB_Checklist_StepResult_ChecklistResultWorkstationId");

                entity.HasIndex(e => e.UserId, "IX_TB_Checklist_StepResult_UserId");

                entity.Property(e => e.FinishedDateTime).HasColumnType("datetime");

                entity.Property(e => e.SerialNumber)
                    .HasMaxLength(60)
                    .IsUnicode(false);

                entity.Property(e => e.StartedDateTime).HasColumnType("datetime");

                entity.Property(e => e.StepCode)
                    .HasMaxLength(60)
                    .IsUnicode(false);

                entity.Property(e => e.StepName)
                    .HasMaxLength(80)
                    .IsUnicode(false);

                entity.HasOne(d => d.ChecklistResultWorkstation)
                    .WithMany(p => p.TB_Checklist_StepResults)
                    .HasForeignKey(d => d.ChecklistResultWorkstationId);

                entity.HasOne(d => d.User)
                    .WithMany(p => p.TB_Checklist_StepResults)
                    .HasForeignKey(d => d.UserId);
            });

            modelBuilder.Entity<TB_Checklist_StepResult_Code>(entity =>
            {
                entity.ToTable("TB_Checklist_StepResult_Code");

                entity.HasIndex(e => e.ChecklistStepResultId, "IX_TB_Checklist_StepResult_Code_ChecklistStepResultId");

                entity.HasIndex(e => e.EquipamentId, "IX_TB_Checklist_StepResult_Code_EquipamentId");

                entity.HasIndex(e => e.ToolId, "IX_TB_Checklist_StepResult_Code_ToolId");

                entity.Property(e => e.CodeLoteInfo)
                    .HasMaxLength(60)
                    .IsUnicode(false);

                entity.Property(e => e.DateTime).HasColumnType("datetime");

                entity.Property(e => e.EvidenceFileId)
                    .HasMaxLength(32)
                    .IsUnicode(false);

                entity.Property(e => e.EvidenceText)
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.ExpectedCode)
                    .HasMaxLength(60)
                    .IsUnicode(false);

                entity.Property(e => e.FormatCode)
                    .HasMaxLength(60)
                    .IsUnicode(false);

                entity.Property(e => e.Tag)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.HasOne(d => d.ChecklistStepResult)
                    .WithMany(p => p.TB_Checklist_StepResult_Codes)
                    .HasForeignKey(d => d.ChecklistStepResultId);

                entity.HasOne(d => d.Equipament)
                    .WithMany(p => p.TB_Checklist_StepResult_Codes)
                    .HasForeignKey(d => d.EquipamentId);

                entity.HasOne(d => d.Tool)
                    .WithMany(p => p.TB_Checklist_StepResult_Codes)
                    .HasForeignKey(d => d.ToolId);
            });

            modelBuilder.Entity<TB_Checklist_StepResult_Dimensional>(entity =>
            {
                entity.ToTable("TB_Checklist_StepResult_Dimensional");

                entity.HasIndex(e => e.ChecklistStepResultId, "IX_TB_Checklist_StepResult_Dimensional_ChecklistStepResultId");

                entity.HasIndex(e => e.EquipamentId, "IX_TB_Checklist_StepResult_Dimensional_EquipamentId");

                entity.HasIndex(e => e.ToolId, "IX_TB_Checklist_StepResult_Dimensional_ToolId");

                entity.Property(e => e.DateTime).HasColumnType("datetime");

                entity.Property(e => e.EvidenceFileId)
                    .HasMaxLength(32)
                    .IsUnicode(false);

                entity.Property(e => e.EvidenceText)
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.Tag)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.TestName)
                    .HasMaxLength(60)
                    .IsUnicode(false);

                entity.Property(e => e.UnitMeasure)
                    .HasMaxLength(40)
                    .IsUnicode(false);

                entity.HasOne(d => d.ChecklistStepResult)
                    .WithMany(p => p.TB_Checklist_StepResult_Dimensionals)
                    .HasForeignKey(d => d.ChecklistStepResultId);

                entity.HasOne(d => d.Equipament)
                    .WithMany(p => p.TB_Checklist_StepResult_Dimensionals)
                    .HasForeignKey(d => d.EquipamentId);

                entity.HasOne(d => d.Tool)
                    .WithMany(p => p.TB_Checklist_StepResult_Dimensionals)
                    .HasForeignKey(d => d.ToolId);
            });

            modelBuilder.Entity<TB_Checklist_StepResult_Tightening>(entity =>
            {
                entity.ToTable("TB_Checklist_StepResult_Tightening");

                entity.HasIndex(e => e.ChecklistStepResultId, "IX_TB_Checklist_StepResult_Tightening_ChecklistStepResultId");

                entity.HasIndex(e => e.EquipamentId, "IX_TB_Checklist_StepResult_Tightening_EquipamentId");

                entity.HasIndex(e => e.ToolId, "IX_TB_Checklist_StepResult_Tightening_ToolId");

                entity.Property(e => e.DateTime).HasColumnType("datetime");

                entity.Property(e => e.EvidenceFileId)
                    .HasMaxLength(32)
                    .IsUnicode(false);

                entity.Property(e => e.EvidenceText)
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.PsetName)
                    .HasMaxLength(60)
                    .IsUnicode(false);

                entity.Property(e => e.SerialNumber)
                    .HasMaxLength(60)
                    .IsUnicode(false);

                entity.Property(e => e.Tag)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.UniteMeasureTorque)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.HasOne(d => d.ChecklistStepResult)
                    .WithMany(p => p.TB_Checklist_StepResult_Tightenings)
                    .HasForeignKey(d => d.ChecklistStepResultId);

                entity.HasOne(d => d.Equipament)
                    .WithMany(p => p.TB_Checklist_StepResult_Tightenings)
                    .HasForeignKey(d => d.EquipamentId);

                entity.HasOne(d => d.Tool)
                    .WithMany(p => p.TB_Checklist_StepResult_Tightenings)
                    .HasForeignKey(d => d.ToolId);
            });

            modelBuilder.Entity<TB_Checklist_StepResult_Value>(entity =>
            {
                entity.ToTable("TB_Checklist_StepResult_Value");

                entity.HasIndex(e => e.ChecklistStepResultId, "IX_TB_Checklist_StepResult_Value_ChecklistStepResultId");

                entity.Property(e => e.SampleValue)
                    .HasMaxLength(60)
                    .IsUnicode(false);

                entity.HasOne(d => d.ChecklistStepResult)
                    .WithMany(p => p.TB_Checklist_StepResult_Values)
                    .HasForeignKey(d => d.ChecklistStepResultId);
            });

            modelBuilder.Entity<TB_Checklist_StepResult_View>(entity =>
            {
                entity.ToTable("TB_Checklist_StepResult_View");

                entity.HasIndex(e => e.ChecklistStepResultId, "IX_TB_Checklist_StepResult_View_ChecklistStepResultId");

                entity.Property(e => e.EvidenceFileId)
                    .HasMaxLength(32)
                    .IsUnicode(false);

                entity.Property(e => e.EvidenceText)
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.Tag)
                    .HasMaxLength(60)
                    .IsUnicode(false);

                entity.HasOne(d => d.ChecklistStepResult)
                    .WithMany(p => p.TB_Checklist_StepResult_Views)
                    .HasForeignKey(d => d.ChecklistStepResultId);
            });

            modelBuilder.Entity<TB_Client>(entity =>
            {
                entity.ToTable("TB_Client");

                entity.Property(e => e.IsActived).HasDefaultValueSql("((1))");

                entity.Property(e => e.Name).IsRequired();
            });

            modelBuilder.Entity<TB_Defect>(entity =>
            {
                entity.ToTable("TB_Defect");

                entity.HasIndex(e => e.DefectTypeId, "IX_TB_Defect_DefectTypeId");

                entity.HasIndex(e => e.OrderProductionId, "IX_TB_Defect_OrderProductionId");

                entity.HasIndex(e => e.UserId, "IX_TB_Defect_UserId");

                entity.HasIndex(e => e.WorkplanResultStepId, "IX_TB_Defect_WorkplanResultStepId");

                entity.Property(e => e.DateTime).HasColumnType("datetime");

                entity.HasOne(d => d.DefectType)
                    .WithMany(p => p.TB_Defects)
                    .HasForeignKey(d => d.DefectTypeId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_TB_Defect_TB_DefectType_Id");

                entity.HasOne(d => d.OrderProduction)
                    .WithMany(p => p.TB_Defects)
                    .HasForeignKey(d => d.OrderProductionId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_TB_Defect_TB_Production_ProductionId");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.TB_Defects)
                    .HasForeignKey(d => d.UserId)
                    .OnDelete(DeleteBehavior.ClientSetNull);

                entity.HasOne(d => d.WorkplanResultStep)
                    .WithMany(p => p.TB_Defects)
                    .HasForeignKey(d => d.WorkplanResultStepId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_TB_Defect_TB_QualityWorkplan_StepResults_Id");
            });

            modelBuilder.Entity<TB_Defect_Type>(entity =>
            {
                entity.ToTable("TB_Defect_Type");

                entity.Property(e => e.Code).IsRequired();

                entity.Property(e => e.Description).IsRequired();
            });

            modelBuilder.Entity<TB_Department>(entity =>
            {
                entity.ToTable("TB_Department");

                entity.Property(e => e.IsActived).HasDefaultValueSql("((1))");

                entity.Property(e => e.Name).IsRequired();
            });

            modelBuilder.Entity<TB_DiarioBordo>(entity =>
            {
                entity.HasKey(e => e.idDiarioBordo);

                entity.ToTable("TB_DiarioBordo");

                entity.Property(e => e.Acao)
                    .HasMaxLength(350)
                    .IsUnicode(false);

                entity.Property(e => e.Anomalia)
                    .HasMaxLength(350)
                    .IsUnicode(false);

                entity.Property(e => e.Data).HasColumnType("date");

                entity.Property(e => e.Etapa)
                    .HasMaxLength(350)
                    .IsUnicode(false);

                entity.Property(e => e.Justificativa)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Operacao)
                    .HasMaxLength(350)
                    .IsUnicode(false);

                entity.Property(e => e.Prazo).HasColumnType("date");

                entity.Property(e => e.Responsavel)
                    .HasMaxLength(200)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TB_Equipment>(entity =>
            {
                entity.ToTable("TB_Equipment");

                entity.HasIndex(e => e.WorklineId, "IX_TB_Equipment_WorklineId");

                entity.HasIndex(e => e.WorkstationId, "IX_TB_Equipment_WorkstationId");

                entity.Property(e => e.Code)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.Description).HasMaxLength(100);

                entity.Property(e => e.Name).HasMaxLength(50);

                entity.Property(e => e.NetworkGateway).HasMaxLength(50);

                entity.Property(e => e.NetworkIP).HasMaxLength(50);

                entity.Property(e => e.NetworkMacAddress).HasMaxLength(50);

                entity.Property(e => e.NetworkMask).HasMaxLength(50);

                entity.Property(e => e.NetworkPort).HasMaxLength(50);

                entity.Property(e => e.PortAddress).HasMaxLength(50);

                entity.Property(e => e.SerialNumber).HasMaxLength(50);

                entity.Property(e => e.ServerAddress).HasMaxLength(50);

                entity.Property(e => e.UnitMeasure).HasMaxLength(50);

                entity.HasOne(d => d.Workline)
                    .WithMany(p => p.TB_Equipments)
                    .HasForeignKey(d => d.WorklineId)
                    .HasConstraintName("FK_TB_Equipment_TB_Workline_Id");

                entity.HasOne(d => d.Workstation)
                    .WithMany(p => p.TB_Equipments)
                    .HasForeignKey(d => d.WorkstationId)
                    .HasConstraintName("FK_TB_Equipment_TB_Workstation_Id");
            });

            modelBuilder.Entity<TB_Equipment_PLC_Tag>(entity =>
            {
                entity.ToTable("TB_Equipment_PLC_Tag");

                entity.HasIndex(e => e.EquipamentId, "IX_TB_Equipment_PLC_Tag_EquipamentId");

                entity.Property(e => e.Address)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.Property(e => e.TagName)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.HasOne(d => d.Equipament)
                    .WithMany(p => p.TB_Equipment_PLC_Tags)
                    .HasForeignKey(d => d.EquipamentId)
                    .HasConstraintName("FK_TB_Equipment_PLC_Tag_TB_Equipament_Id");
            });

            modelBuilder.Entity<TB_Graph>(entity =>
            {
                entity.HasKey(e => e.GraphID)
                    .HasName("PK__TB_Graph__BB8FC12A6B1FE932");

                entity.ToTable("TB_Graph");

                entity.Property(e => e.GraphValues)
                    .IsRequired()
                    .IsUnicode(false);

                entity.Property(e => e.TimeStamp).HasColumnType("datetime");
            });

            modelBuilder.Entity<TB_Identifier>(entity =>
            {
                entity.HasKey(e => e.InsertResultID)
                    .HasName("PK__TB_Ident__43622002843D4DA5");

                entity.ToTable("TB_Identifier");

                entity.Property(e => e.Identifier1)
                    .HasMaxLength(25)
                    .IsUnicode(false);

                entity.Property(e => e.Identifier2)
                    .HasMaxLength(25)
                    .IsUnicode(false);

                entity.Property(e => e.Identifier3)
                    .HasMaxLength(25)
                    .IsUnicode(false);

                entity.Property(e => e.Identifier4)
                    .HasMaxLength(25)
                    .IsUnicode(false);

                entity.Property(e => e.modelo)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.seq)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TB_LocationParameter>(entity =>
            {
                entity.ToTable("TB_LocationParameter");

                entity.HasIndex(e => e.AvaliableParameterId, "IX_TB_LocationParameter_AvaliableParameterId");

                entity.HasIndex(e => e.MaintenanceParameterId, "IX_TB_LocationParameter_MaintenanceParameterId");

                entity.HasIndex(e => e.ManPowerParameterId, "IX_TB_LocationParameter_ManPowerParameterId");

                entity.HasIndex(e => e.PerfomanceParameterId, "IX_TB_LocationParameter_PerfomanceParameterId");

                entity.HasIndex(e => e.ProductionParameterId, "IX_TB_LocationParameter_ProductionParameterId");

                entity.Property(e => e.IsActived).HasDefaultValueSql("((1))");

                entity.HasOne(d => d.AvaliableParameter)
                    .WithMany(p => p.TB_LocationParameters)
                    .HasForeignKey(d => d.AvaliableParameterId)
                    .OnDelete(DeleteBehavior.ClientSetNull);

                entity.HasOne(d => d.MaintenanceParameter)
                    .WithMany(p => p.TB_LocationParameters)
                    .HasForeignKey(d => d.MaintenanceParameterId)
                    .OnDelete(DeleteBehavior.ClientSetNull);

                entity.HasOne(d => d.ManPowerParameter)
                    .WithMany(p => p.TB_LocationParameters)
                    .HasForeignKey(d => d.ManPowerParameterId)
                    .OnDelete(DeleteBehavior.ClientSetNull);

                entity.HasOne(d => d.PerfomanceParameter)
                    .WithMany(p => p.TB_LocationParameters)
                    .HasForeignKey(d => d.PerfomanceParameterId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_TB_LocationParameter_TB_PerfomanceParameter_PerfomanceParameterId");

                entity.HasOne(d => d.ProductionParameter)
                    .WithMany(p => p.TB_LocationParameters)
                    .HasForeignKey(d => d.ProductionParameterId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_TB_LocationParameter_TB_Production_ProductionParameterId");
            });

            modelBuilder.Entity<TB_MaintenanceParameter>(entity =>
            {
                entity.ToTable("TB_MaintenanceParameter");
            });

            modelBuilder.Entity<TB_ManPowerParameter>(entity =>
            {
                entity.ToTable("TB_ManPowerParameter");
            });

            modelBuilder.Entity<TB_MaterialLocation>(entity =>
            {
                entity.ToTable("TB_MaterialLocation");

                entity.Property(e => e.IsActived).HasDefaultValueSql("((1))");

                entity.Property(e => e.Name).IsRequired();
            });

            modelBuilder.Entity<TB_Multiplicador_Torque>(entity =>
            {
                entity.HasKey(e => e.IdMultiplicadorTorque);

                entity.ToTable("TB_Multiplicador_Torque");

                entity.Property(e => e.Nome)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Pset)
                    .IsRequired()
                    .IsUnicode(false);

                entity.Property(e => e.Situacao).HasDefaultValueSql("((1))");

                entity.Property(e => e.ValidadeFim).HasColumnType("date");

                entity.Property(e => e.ValidadeInicio).HasColumnType("date");
            });

            modelBuilder.Entity<TB_Notification_Message>(entity =>
            {
                entity.ToTable("TB_Notification_Message");

                entity.HasIndex(e => e.CreatedUserId, "IX_TB_Notification_Message_CreatedUserId");

                entity.HasIndex(e => e.MentionedUserId, "IX_TB_Notification_Message_MentionedUserId");

                entity.Property(e => e.DateTime)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.MessageText).IsRequired();

                entity.HasOne(d => d.CreatedUser)
                    .WithMany(p => p.TB_Notification_MessageCreatedUsers)
                    .HasForeignKey(d => d.CreatedUserId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_TB_Notification_Message.CreatedUser_TB_User_UserId");

                entity.HasOne(d => d.MentionedUser)
                    .WithMany(p => p.TB_Notification_MessageMentionedUsers)
                    .HasForeignKey(d => d.MentionedUserId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_TB_Notification_Message.MentionedUser_TB_User_UserId");
            });

            modelBuilder.Entity<TB_Notification_ThirdParty_Config>(entity =>
            {
                entity.ToTable("TB_Notification_ThirdParty_Config");

                entity.HasIndex(e => e.UserId, "IX_TB_Notification_ThirdParty_Config_UserId");

                entity.Property(e => e.ThirdPartyAppName).IsRequired();

                entity.HasOne(d => d.User)
                    .WithMany(p => p.TB_Notification_ThirdParty_Configs)
                    .HasForeignKey(d => d.UserId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_TB_Notification_ThirdParty_Config.UserId_TB_User_UserId");
            });

            modelBuilder.Entity<TB_OP_Alarm>(entity =>
            {
                entity.HasKey(e => e.InsertAlarmtID);

                entity.ToTable("TB_OP_Alarm");

                entity.Property(e => e.ErrorCode)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.TimeStamp).HasColumnType("datetime");
            });

            modelBuilder.Entity<TB_OP_AlarmError>(entity =>
            {
                entity.HasKey(e => e.IDError);

                entity.ToTable("TB_OP_AlarmError");

                entity.Property(e => e.ErrorCode)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ErrorText)
                    .IsRequired()
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.ErrorType)
                    .HasMaxLength(100)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TB_Order>(entity =>
            {
                entity.ToTable("TB_Order");

                entity.HasIndex(e => e.ClientId, "IX_TB_Order_ClientId");

                entity.HasIndex(e => e.ProductId, "IX_TB_Order_ProductId");

                entity.Property(e => e.DeliveryDate).HasColumnType("datetime");

                entity.Property(e => e.OrderNumber).HasMaxLength(50);

                entity.Property(e => e.RackCode).HasMaxLength(50);

                entity.Property(e => e.RackPosition).HasMaxLength(50);

                entity.Property(e => e.RequestDate).HasColumnType("datetime");

                entity.Property(e => e.SalesOrder).HasMaxLength(50);

                entity.Property(e => e.ScheduleDate).HasColumnType("datetime");

                entity.Property(e => e.SerialNumber).HasMaxLength(50);

                entity.Property(e => e.Source).HasDefaultValueSql("((1))");

                entity.Property(e => e.Status).HasDefaultValueSql("((1))");

                entity.Property(e => e.VINNumber).HasMaxLength(50);

                entity.HasOne(d => d.Client)
                    .WithMany(p => p.TB_Orders)
                    .HasForeignKey(d => d.ClientId);

                entity.HasOne(d => d.Product)
                    .WithMany(p => p.TB_Orders)
                    .HasForeignKey(d => d.ProductId);
            });

            modelBuilder.Entity<TB_Order_Partnumber>(entity =>
            {
                entity.ToTable("TB_Order_Partnumber");

                entity.HasIndex(e => e.OrderId, "IX_TB_Order_Partnumber_OrderId");

                entity.Property(e => e.Partnumber)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.HasOne(d => d.Order)
                    .WithMany(p => p.TB_Order_Partnumbers)
                    .HasForeignKey(d => d.OrderId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_TB_Order_Partnumber_TB_Order_Id");
            });

            modelBuilder.Entity<TB_Order_Production>(entity =>
            {
                entity.ToTable("TB_Order_Production");

                entity.HasIndex(e => e.OrderId, "IX_TB_Order_Production_OrderId");

                entity.HasIndex(e => e.UserId, "IX_TB_Order_Production_UserId");

                entity.Property(e => e.SerialNumber).HasMaxLength(50);

                entity.Property(e => e.Status).HasDefaultValueSql("((1))");

                entity.HasOne(d => d.Order)
                    .WithMany(p => p.TB_Order_Productions)
                    .HasForeignKey(d => d.OrderId);

                entity.HasOne(d => d.User)
                    .WithMany(p => p.TB_Order_Productions)
                    .HasForeignKey(d => d.UserId);
            });

            modelBuilder.Entity<TB_Order_Production_StatusLog>(entity =>
            {
                entity.ToTable("TB_Order_Production_StatusLog");

                entity.HasIndex(e => e.OrderProductionId, "IX_TB_Order_Production_StatusLog_OrderProductionId");

                entity.HasIndex(e => e.UserId, "IX_TB_Order_Production_StatusLog_UserId");

                entity.Property(e => e.DateTime).HasColumnType("datetime");

                entity.HasOne(d => d.OrderProduction)
                    .WithMany(p => p.TB_Order_Production_StatusLogs)
                    .HasForeignKey(d => d.OrderProductionId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_TB_Order_Production_StatusLog_TB_Order_Production_OrderProductioId");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.TB_Order_Production_StatusLogs)
                    .HasForeignKey(d => d.UserId);
            });

            modelBuilder.Entity<TB_Order_StatusLog>(entity =>
            {
                entity.ToTable("TB_Order_StatusLog");

                entity.HasIndex(e => e.OrderId, "IX_TB_Order_StatusLog_OrderId");

                entity.HasIndex(e => e.UserId, "IX_TB_Order_StatusLog_UserId");

                entity.Property(e => e.DateTime).HasColumnType("datetime");

                entity.HasOne(d => d.Order)
                    .WithMany(p => p.TB_Order_StatusLogs)
                    .HasForeignKey(d => d.OrderId)
                    .OnDelete(DeleteBehavior.ClientSetNull);

                entity.HasOne(d => d.User)
                    .WithMany(p => p.TB_Order_StatusLogs)
                    .HasForeignKey(d => d.UserId);
            });

            modelBuilder.Entity<TB_PerformanceParameter>(entity =>
            {
                entity.ToTable("TB_PerformanceParameter");
            });

            modelBuilder.Entity<TB_Product>(entity =>
            {
                entity.ToTable("TB_Product");

                entity.HasIndex(e => e.ClientId, "IX_TB_Product_ClientId");

                entity.Property(e => e.ClientCode).HasMaxLength(50);

                entity.Property(e => e.Code).HasMaxLength(50);

                entity.Property(e => e.IsActived).HasDefaultValueSql("((1))");

                entity.Property(e => e.Model).HasMaxLength(50);

                entity.Property(e => e.RevisionNumber).HasDefaultValueSql("((1))");

                entity.HasOne(d => d.Client)
                    .WithMany(p => p.TB_Products)
                    .HasForeignKey(d => d.ClientId);

                entity.HasOne(d => d.ProductAux)
                    .WithMany(p => p.TB_Products)
                    .HasForeignKey(d => d.ProductAuxId)
                    .HasConstraintName("FK_TB_Product_TB_Product_Aux_Id");
            });

            modelBuilder.Entity<TB_Product_Aux>(entity =>
            {
                entity.ToTable("TB_Product_Aux");
            });

            modelBuilder.Entity<TB_Product_BOM>(entity =>
            {
                entity.ToTable("TB_Product_BOM");

                entity.HasIndex(e => e.BOMId, "IX_TB_Product_BOM_BOMId");

                entity.HasIndex(e => e.ProductId, "IX_TB_Product_BOM_ProductId");

                entity.Property(e => e.IsActived).HasDefaultValueSql("((1))");

                entity.Property(e => e.Qty).HasDefaultValueSql("((1))");

                entity.HasOne(d => d.BOM)
                    .WithMany(p => p.TB_Product_BOMs)
                    .HasForeignKey(d => d.BOMId);

                entity.HasOne(d => d.Product)
                    .WithMany(p => p.TB_Product_BOMs)
                    .HasForeignKey(d => d.ProductId);
            });

            modelBuilder.Entity<TB_ProductionParameter>(entity =>
            {
                entity.ToTable("TB_ProductionParameter");
            });

            modelBuilder.Entity<TB_Production_Loss>(entity =>
            {
                entity.ToTable("TB_Production_Loss");

                entity.HasIndex(e => e.ProductionLossTypeId, "IX_TB_Production_Loss_ProductionLossTypeId");

                entity.Property(e => e.Code).HasMaxLength(50);

                entity.Property(e => e.Description).HasMaxLength(250);

                entity.HasOne(d => d.ProductionLossType)
                    .WithMany(p => p.TB_Production_Losses)
                    .HasForeignKey(d => d.ProductionLossTypeId)
                    .HasConstraintName("FK_TB_Production_Loss_TB_Production_Loss_Type_Id");
            });

            modelBuilder.Entity<TB_Production_Loss_Record>(entity =>
            {
                entity.ToTable("TB_Production_Loss_Record");

                entity.HasIndex(e => e.ProductionId, "IX_TB_Production_Loss_Record_ProductionId");

                entity.HasIndex(e => e.ProductionLossId, "IX_TB_Production_Loss_Record_ProductionLossId");

                entity.HasIndex(e => e.UserId, "IX_TB_Production_Loss_Record_UserId");

                entity.HasIndex(e => e.WorkstationId, "IX_TB_Production_Loss_Record_WorkstationId");

                entity.Property(e => e.FinishedDateTime).HasColumnType("datetime");

                entity.Property(e => e.SerialNumber).HasMaxLength(50);

                entity.Property(e => e.StartedDateTime).HasColumnType("datetime");

                entity.HasOne(d => d.Production)
                    .WithMany(p => p.TB_Production_Loss_Records)
                    .HasForeignKey(d => d.ProductionId)
                    .HasConstraintName("FK_TB_Production_Loss_Record_TB_Order_Production_Id");

                entity.HasOne(d => d.ProductionLoss)
                    .WithMany(p => p.TB_Production_Loss_Records)
                    .HasForeignKey(d => d.ProductionLossId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_TB_Production_Loss_Record_TB_Production_Loss_Id");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.TB_Production_Loss_Records)
                    .HasForeignKey(d => d.UserId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_TB_Production_Loss_Record_TB_User_Id");

                entity.HasOne(d => d.Workstation)
                    .WithMany(p => p.TB_Production_Loss_Records)
                    .HasForeignKey(d => d.WorkstationId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_TB_Production_Loss_Record_TB_Workstation_Id");
            });

            modelBuilder.Entity<TB_Production_Loss_Type>(entity =>
            {
                entity.ToTable("TB_Production_Loss_Type");

                entity.Property(e => e.Code).HasMaxLength(50);

                entity.Property(e => e.Color).HasMaxLength(10);

                entity.Property(e => e.Type).HasMaxLength(250);
            });

            modelBuilder.Entity<TB_Provider>(entity =>
            {
                entity.ToTable("TB_Provider");

                entity.Property(e => e.Code).IsRequired();

                entity.Property(e => e.IsActived).HasDefaultValueSql("((1))");
            });

            modelBuilder.Entity<TB_QualityWorkplan_Code>(entity =>
            {
                entity.ToTable("TB_QualityWorkplan_Code");

                entity.HasIndex(e => e.QualityWorkplanStepResultId, "IX_TB_QualityWorkplan_Code_QualityWorkplanStepResultId");

                entity.Property(e => e.CodeReaded).IsRequired();

                entity.HasOne(d => d.QualityWorkplanStepResult)
                    .WithMany(p => p.TB_QualityWorkplan_Codes)
                    .HasForeignKey(d => d.QualityWorkplanStepResultId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_TB_QualityWorkplan_Code_StepResult_StepResultId");
            });

            modelBuilder.Entity<TB_QualityWorkplan_Dimensional>(entity =>
            {
                entity.ToTable("TB_QualityWorkplan_Dimensional");

                entity.HasIndex(e => e.QualityWorkplanStepResultId, "IX_TB_QualityWorkplan_Dimensional_QualityWorkplanStepResultId");

                entity.Property(e => e.BatchSize).HasDefaultValueSql("((1))");

                entity.HasOne(d => d.QualityWorkplanStepResult)
                    .WithMany(p => p.TB_QualityWorkplan_Dimensionals)
                    .HasForeignKey(d => d.QualityWorkplanStepResultId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("TB_QualityWorkplan_Dimensional_StepResult_StepResultId");
            });

            modelBuilder.Entity<TB_QualityWorkplan_StepResult>(entity =>
            {
                entity.ToTable("TB_QualityWorkplan_StepResult");

                entity.HasIndex(e => e.UserId, "IX_TB_QualityWorkplan_StepResult_UserId");

                entity.HasIndex(e => e.WorkflowResultId, "IX_TB_QualityWorkplan_StepResult_WorkflowResultId");

                entity.HasIndex(e => e.WorkstationId, "IX_TB_QualityWorkplan_StepResult_WorkstationId");

                entity.Property(e => e.StepId).IsRequired();

                entity.Property(e => e.WorkplanId).IsRequired();

                entity.HasOne(d => d.User)
                    .WithMany(p => p.TB_QualityWorkplan_StepResults)
                    .HasForeignKey(d => d.UserId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_TB_QualityWorkplan_StepResult_User_UserId");

                entity.HasOne(d => d.WorkflowResult)
                    .WithMany(p => p.TB_QualityWorkplan_StepResults)
                    .HasForeignKey(d => d.WorkflowResultId);

                entity.HasOne(d => d.Workstation)
                    .WithMany(p => p.TB_QualityWorkplan_StepResults)
                    .HasForeignKey(d => d.WorkstationId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_TB_QualityWorkplan_StepResult_Workstation_WorkstationId");
            });

            modelBuilder.Entity<TB_QualityWorkplan_StepResult_StatusLog>(entity =>
            {
                entity.ToTable("TB_QualityWorkplan_StepResult_StatusLog");

                entity.HasIndex(e => e.QualityWorkplanStepResultId, "IX_TB_QualityWorkplan_StepResult_StatusLog_QualityWorkplanStepResultId");

                entity.HasIndex(e => e.UserId, "IX_TB_QualityWorkplan_StepResult_StatusLog_UserId");

                entity.Property(e => e.DateTime).HasColumnType("datetime");

                entity.HasOne(d => d.QualityWorkplanStepResult)
                    .WithMany(p => p.TB_QualityWorkplan_StepResult_StatusLogs)
                    .HasForeignKey(d => d.QualityWorkplanStepResultId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_TB_QualityWorkplan_StepResult_StatusLog_QualityWorkplanStepResultId");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.TB_QualityWorkplan_StepResult_StatusLogs)
                    .HasForeignKey(d => d.UserId);
            });

            modelBuilder.Entity<TB_Result>(entity =>
            {
                entity.HasKey(e => e.ResultID)
                    .HasName("PK__TB_Resul__976902280C825B76");

                entity.ToTable("TB_Result");

                entity.Property(e => e.DateTtimelastPset).HasColumnType("datetime");

                entity.Property(e => e.DiarioBordo).HasDefaultValueSql("((0))");

                entity.Property(e => e.Identifier_result_part_2)
                    .HasMaxLength(25)
                    .IsUnicode(false);

                entity.Property(e => e.Identifier_result_part_3)
                    .HasMaxLength(25)
                    .IsUnicode(false);

                entity.Property(e => e.Identifier_result_part_4)
                    .HasMaxLength(25)
                    .IsUnicode(false);

                entity.Property(e => e.ParameterSetName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.TimeStamp).HasColumnType("datetime");
            });

            modelBuilder.Entity<TB_Retentive>(entity =>
            {
                entity.ToTable("TB_Retentive");
            });

            modelBuilder.Entity<TB_Schema_Measurement>(entity =>
            {
                entity.ToTable("TB_Schema_Measurement");

                entity.Property(e => e.SchemaName)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TB_Shift>(entity =>
            {
                entity.ToTable("TB_Shift");
            });

            modelBuilder.Entity<TB_Tool>(entity =>
            {
                entity.ToTable("TB_Tool");

                entity.HasIndex(e => e.EquipmentId, "IX_TB_Tool_EquipmentId");

                entity.HasIndex(e => e.ToolAutomatedId, "IX_TB_Tool_ToolAutomatedId");

                entity.Property(e => e.Code)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.Description).HasMaxLength(100);

                entity.Property(e => e.Name).HasMaxLength(50);

                entity.Property(e => e.SerialNumber).HasMaxLength(50);

                entity.HasOne(d => d.Equipment)
                    .WithMany(p => p.TB_Tools)
                    .HasForeignKey(d => d.EquipmentId)
                    .HasConstraintName("FK_TB_Tool_TB_Equipment_Id");

                entity.HasOne(d => d.ToolAutomated)
                    .WithMany(p => p.TB_Tools)
                    .HasForeignKey(d => d.ToolAutomatedId)
                    .HasConstraintName("FK_TB_Tool_TB_Tool_Automated_Id");
            });

            modelBuilder.Entity<TB_Tool_Automated>(entity =>
            {
                entity.ToTable("TB_Tool_Automated");
            });

            modelBuilder.Entity<TB_User>(entity =>
            {
                entity.ToTable("TB_User");

                entity.HasIndex(e => e.DepartmentId, "IX_TB_User_DepartmentId");

                entity.Property(e => e.Name).HasMaxLength(200);

                entity.Property(e => e.Password).HasMaxLength(25);

                entity.Property(e => e.Phone).HasMaxLength(50);

                entity.Property(e => e.RegistrationCode).HasMaxLength(25);

                entity.Property(e => e.Status).HasDefaultValueSql("((1))");

                entity.Property(e => e.Username).HasMaxLength(50);

                entity.HasOne(d => d.Department)
                    .WithMany(p => p.TB_Users)
                    .HasForeignKey(d => d.DepartmentId);
            });

            modelBuilder.Entity<TB_User_Permission>(entity =>
            {
                entity.ToTable("TB_User_Permission");

                entity.HasIndex(e => e.UserId, "IX_TB_User_Permission_UserId");

                entity.Property(e => e.AcessLevel).IsRequired();

                entity.Property(e => e.Module).IsRequired();

                entity.HasOne(d => d.User)
                    .WithMany(p => p.TB_User_Permissions)
                    .HasForeignKey(d => d.UserId)
                    .OnDelete(DeleteBehavior.ClientSetNull);
            });

            modelBuilder.Entity<TB_User_Session>(entity =>
            {
                entity.ToTable("TB_User_Session");

                entity.HasIndex(e => e.UserId, "IX_TB_User_Session_UserId");

                entity.Property(e => e.Hostname).IsRequired();

                entity.Property(e => e.LoginTime).HasColumnType("datetime");

                entity.Property(e => e.Status).HasDefaultValueSql("((1))");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.TB_User_Sessions)
                    .HasForeignKey(d => d.UserId)
                    .OnDelete(DeleteBehavior.ClientSetNull);
            });

            modelBuilder.Entity<TB_User_SkillMatrix>(entity =>
            {
                entity.ToTable("TB_User_SkillMatrix");

                entity.HasIndex(e => e.ProductId, "IX_TB_User_SkillMatrix_ProductId");

                entity.HasIndex(e => e.UserId, "IX_TB_User_SkillMatrix_UserId");

                entity.HasIndex(e => e.WorkstationId, "IX_TB_User_SkillMatrix_WorkstationId");

                entity.HasOne(d => d.Product)
                    .WithMany(p => p.TB_User_SkillMatrices)
                    .HasForeignKey(d => d.ProductId);

                entity.HasOne(d => d.User)
                    .WithMany(p => p.TB_User_SkillMatrices)
                    .HasForeignKey(d => d.UserId)
                    .OnDelete(DeleteBehavior.ClientSetNull);

                entity.HasOne(d => d.Workstation)
                    .WithMany(p => p.TB_User_SkillMatrices)
                    .HasForeignKey(d => d.WorkstationId);
            });

            modelBuilder.Entity<TB_Wokarea>(entity =>
            {
                entity.ToTable("TB_Wokarea");

                entity.HasIndex(e => e.WorkplantId, "IX_TB_Wokarea_WorkplantId");

                entity.Property(e => e.Name).IsRequired();

                entity.HasOne(d => d.Workplant)
                    .WithMany(p => p.TB_Wokareas)
                    .HasForeignKey(d => d.WorkplantId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_TB_Workarea_TB_Workplant_WorkplantId");
            });

            modelBuilder.Entity<TB_Workbox>(entity =>
            {
                entity.ToTable("TB_Workbox");

                entity.HasIndex(e => e.WorklineId, "IX_TB_Workbox_WorklineId");

                entity.Property(e => e.Name).IsRequired();

                entity.HasOne(d => d.Workline)
                    .WithMany(p => p.TB_Workboxes)
                    .HasForeignKey(d => d.WorklineId)
                    .OnDelete(DeleteBehavior.ClientSetNull);
            });

            modelBuilder.Entity<TB_Workflow_Product>(entity =>
            {
                entity.ToTable("TB_Workflow_Product");

                entity.HasIndex(e => e.ProductId, "IX_TB_Workflow_Product_ProductId");

                entity.Property(e => e.WorkflowId).IsRequired();

                entity.HasOne(d => d.Product)
                    .WithMany(p => p.TB_Workflow_Products)
                    .HasForeignKey(d => d.ProductId);
            });

            modelBuilder.Entity<TB_Workflow_Result>(entity =>
            {
                entity.ToTable("TB_Workflow_Result");

                entity.HasIndex(e => e.ProductionId, "IX_TB_Workflow_Result_ProductionId");

                entity.HasIndex(e => e.UserId, "IX_TB_Workflow_Result_UserId");

                entity.HasIndex(e => e.WorkstationId, "IX_TB_Workflow_Result_WorkstationId");

                entity.Property(e => e.FinishedDateTime).HasColumnType("datetime");

                entity.Property(e => e.InstructionId)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.OperationId).IsRequired();

                entity.Property(e => e.StartedDateTime).HasColumnType("datetime");

                entity.Property(e => e.WorkflowId)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.HasOne(d => d.Production)
                    .WithMany(p => p.TB_Workflow_Results)
                    .HasForeignKey(d => d.ProductionId)
                    .OnDelete(DeleteBehavior.ClientSetNull);

                entity.HasOne(d => d.User)
                    .WithMany(p => p.TB_Workflow_Results)
                    .HasForeignKey(d => d.UserId)
                    .OnDelete(DeleteBehavior.ClientSetNull);

                entity.HasOne(d => d.Workstation)
                    .WithMany(p => p.TB_Workflow_Results)
                    .HasForeignKey(d => d.WorkstationId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_TB_Workflow_Result_TB_Workstation_WokstationId");
            });

            modelBuilder.Entity<TB_Workflow_Result_StatusLog>(entity =>
            {
                entity.ToTable("TB_Workflow_Result_StatusLog");

                entity.HasIndex(e => e.UserId, "IX_TB_Workflow_Result_StatusLog_UserId");

                entity.HasIndex(e => e.WorkflowResultId, "IX_TB_Workflow_Result_StatusLog_WorkflowResultId");

                entity.Property(e => e.DateTime).HasColumnType("datetime");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.TB_Workflow_Result_StatusLogs)
                    .HasForeignKey(d => d.UserId);

                entity.HasOne(d => d.WorkflowResult)
                    .WithMany(p => p.TB_Workflow_Result_StatusLogs)
                    .HasForeignKey(d => d.WorkflowResultId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_TB_Workflow_Result_StatusLog_WorkflowResultId");
            });

            modelBuilder.Entity<TB_Workinstruction_StepResult>(entity =>
            {
                entity.ToTable("TB_Workinstruction_StepResult");

                entity.HasIndex(e => e.UserId, "IX_TB_Workinstruction_StepResult_UserId");

                entity.HasIndex(e => e.WorkflowResultId, "IX_TB_Workinstruction_StepResult_WorkflowResultId");

                entity.HasIndex(e => e.WorkstationId, "IX_TB_Workinstruction_StepResult_WorkstationId");

                entity.Property(e => e.FinishedDateTime).HasColumnType("datetime");

                entity.Property(e => e.StartedDateTime).HasColumnType("datetime");

                entity.Property(e => e.StepId).HasMaxLength(100);

                entity.Property(e => e.WorkinstructionId)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.HasOne(d => d.User)
                    .WithMany(p => p.TB_Workinstruction_StepResults)
                    .HasForeignKey(d => d.UserId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_TB_WorkinstructionStepResult_TB_User_UserId");

                entity.HasOne(d => d.WorkflowResult)
                    .WithMany(p => p.TB_Workinstruction_StepResults)
                    .HasForeignKey(d => d.WorkflowResultId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_TB_WorkinstructionStepResult_TB_WorkflowResult_Id");

                entity.HasOne(d => d.Workstation)
                    .WithMany(p => p.TB_Workinstruction_StepResults)
                    .HasForeignKey(d => d.WorkstationId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_TB_WorkinstructionStepResult_TB_Workstation_Id");
            });

            modelBuilder.Entity<TB_Workinstruction_StepResult_Code>(entity =>
            {
                entity.ToTable("TB_Workinstruction_StepResult_Code");

                entity.HasIndex(e => e.WorkinstructionStepResultId, "IX_TB_Workinstruction_StepResult_Code_WorkinstructionStepResultId");

                entity.Property(e => e.BatchSize).HasDefaultValueSql("((1))");

                entity.Property(e => e.ExpectedCode).IsRequired();

                entity.Property(e => e.ReadedCode).IsRequired();

                entity.HasOne(d => d.WorkinstructionStepResult)
                    .WithMany(p => p.TB_Workinstruction_StepResult_Codes)
                    .HasForeignKey(d => d.WorkinstructionStepResultId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_TB_Workinstruction_StepResult_Code_WorkinstructionStepResultId");
            });

            modelBuilder.Entity<TB_Workinstruction_StepResult_IO>(entity =>
            {
                entity.ToTable("TB_Workinstruction_StepResult_IO");

                entity.HasIndex(e => e.WorkinstructionStepResultId, "IX_TB_Workinstruction_StepResult_IO_WorkinstructionStepResultId");

                entity.Property(e => e.DateTime).HasColumnType("datetime");

                entity.Property(e => e.Value)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.HasOne(d => d.WorkinstructionStepResult)
                    .WithMany(p => p.TB_Workinstruction_StepResult_IOs)
                    .HasForeignKey(d => d.WorkinstructionStepResultId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_TB_Workinstruction_StepResult_IO_WorkinstructionStepResultId");
            });

            modelBuilder.Entity<TB_Workinstruction_StepResult_StatusLog>(entity =>
            {
                entity.ToTable("TB_Workinstruction_StepResult_StatusLog");

                entity.HasIndex(e => e.UserId, "IX_TB_Workinstruction_StepResult_StatusLog_UserId");

                entity.HasIndex(e => e.WorkinstructionStepResultId, "IX_TB_Workinstruction_StepResult_StatusLog_WorkinstructionStepResultId");

                entity.Property(e => e.DateTime).HasColumnType("datetime");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.TB_Workinstruction_StepResult_StatusLogs)
                    .HasForeignKey(d => d.UserId);

                entity.HasOne(d => d.WorkinstructionStepResult)
                    .WithMany(p => p.TB_Workinstruction_StepResult_StatusLogs)
                    .HasForeignKey(d => d.WorkinstructionStepResultId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_TB_Workinstruction_Step_Result_StatusLog_WorkinstructionStepResultId");
            });

            modelBuilder.Entity<TB_Workinstruction_StepResult_Test>(entity =>
            {
                entity.ToTable("TB_Workinstruction_StepResult_Test");

                entity.HasIndex(e => e.WorkinstructionStepResultId, "IX_TB_Workinstruction_StepResult_Test_WorkinstructionStepResultId");

                entity.Property(e => e.Address).IsRequired();

                entity.Property(e => e.MaxValue).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.MinValue).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.Name).IsRequired();

                entity.Property(e => e.Unit)
                    .IsRequired()
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Value).HasColumnType("decimal(18, 2)");

                entity.HasOne(d => d.WorkinstructionStepResult)
                    .WithMany(p => p.TB_Workinstruction_StepResult_Tests)
                    .HasForeignKey(d => d.WorkinstructionStepResultId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_TB_Workinstruction_StepResult_Test_WorkinstructionStepResultId");
            });

            modelBuilder.Entity<TB_Workinstruction_StepResult_Torque>(entity =>
            {
                entity.ToTable("TB_Workinstruction_StepResult_Torque");

                entity.HasIndex(e => e.EquipmentId, "IX_TB_Workinstruction_StepResult_Torque_EquipmentId");

                entity.HasIndex(e => e.ToolId, "IX_TB_Workinstruction_StepResult_Torque_ToolId");

                entity.HasIndex(e => e.WorkinstructionStepResultId, "IX_TB_Workinstruction_StepResult_Torque_WorkinstructionStepResultId");

                entity.Property(e => e.AngleMax).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.AngleMin).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.AngleValue).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.BoltId)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.Property(e => e.DateTime).HasColumnType("datetime");

                entity.Property(e => e.Tags)
                    .IsRequired()
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.TorqueMax).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.TorqueMin).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.TorqueValue).HasColumnType("decimal(18, 2)");

                entity.HasOne(d => d.Equipment)
                    .WithMany(p => p.TB_Workinstruction_StepResult_Torques)
                    .HasForeignKey(d => d.EquipmentId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_TB_Workinstruction_StepResult_Torque_TB_Equipment_Id");

                entity.HasOne(d => d.Tool)
                    .WithMany(p => p.TB_Workinstruction_StepResult_Torques)
                    .HasForeignKey(d => d.ToolId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_TB_Workinstruction_StepResult_Torque_TB_Tool_Id");

                entity.HasOne(d => d.WorkinstructionStepResult)
                    .WithMany(p => p.TB_Workinstruction_StepResult_Torques)
                    .HasForeignKey(d => d.WorkinstructionStepResultId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_TB_Workinstruction_StepResult_Torque_WorkinstructionStepResultId");
            });

            modelBuilder.Entity<TB_Workline>(entity =>
            {
                entity.ToTable("TB_Workline");

                entity.HasIndex(e => e.WorkareaId, "IX_TB_Workline_WorkareaId");

                entity.Property(e => e.Name).IsRequired();

                entity.HasOne(d => d.Workarea)
                    .WithMany(p => p.TB_Worklines)
                    .HasForeignKey(d => d.WorkareaId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_TB_Workline_TB_Workarea_WorkareaId");
            });

            modelBuilder.Entity<TB_Workline_Configuration>(entity =>
            {
                entity.ToTable("TB_Workline_Configuration");

                entity.HasIndex(e => e.DepartmentId, "IX_TB_Workline_Configuration_DepartmentId");

                entity.HasIndex(e => e.WorklineId, "IX_TB_Workline_Configuration_WorklineId");

                entity.HasOne(d => d.Department)
                    .WithMany(p => p.TB_Workline_Configurations)
                    .HasForeignKey(d => d.DepartmentId)
                    .HasConstraintName("FK_TB_Workline_Configuration_TB_Department_Id");

                entity.HasOne(d => d.Workline)
                    .WithMany(p => p.TB_Workline_Configurations)
                    .HasForeignKey(d => d.WorklineId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_TB_Workline_Configuration_TB_Workline_Id");
            });

            modelBuilder.Entity<TB_Workline_PitchTime>(entity =>
            {
                entity.ToTable("TB_Workline_PitchTime");

                entity.HasIndex(e => e.WorklineId, "IX_TB_Workline_PitchTime_WorklineId");
            });

            modelBuilder.Entity<TB_Workplant>(entity =>
            {
                entity.ToTable("TB_Workplant");

                entity.Property(e => e.Name).IsRequired();
            });

            modelBuilder.Entity<TB_Workstation>(entity =>
            {
                entity.ToTable("TB_Workstation");

                entity.HasIndex(e => e.WorkboxId, "IX_TB_Workstation_WorkboxId");

                entity.Property(e => e.Name).IsRequired();

                entity.HasOne(d => d.Workbox)
                    .WithMany(p => p.TB_Workstations)
                    .HasForeignKey(d => d.WorkboxId);
            });

            modelBuilder.Entity<__LogApplication>(entity =>
            {
                entity.ToTable("__LogApplication");

                entity.HasIndex(e => e.UserId, "IX___LogApplication_UserId");

                entity.Property(e => e.DateTime).HasColumnType("datetime");

                entity.Property(e => e.OriginalState).IsRequired();

                entity.Property(e => e.StateId).IsRequired();

                entity.Property(e => e.StateName).IsRequired();

                entity.HasOne(d => d.User)
                    .WithMany(p => p.__LogApplications)
                    .HasForeignKey(d => d.UserId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_LogApplication_TB_User_UserId");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
