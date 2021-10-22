using FrontlineEBillingAssistant.Core.Models;
using Microsoft.EntityFrameworkCore;

namespace FrontlineEBillingAssistant.Core.Data
{
    public partial class EBillingContext : DbContext
    {
        public EBillingContext()
        {

        }
        public EBillingContext(DbContextOptions<EBillingContext> options) : base(options) { }

        #region DBSets

        public virtual DbSet<ActionOperand> ActionOperands { get; set; }
        public virtual DbSet<ActionOperandFieldType> ActionOperandFieldTypes { get; set; }
        public virtual DbSet<AcuityAutomationReductionReason> AcuityAutomationReductionReasons { get; set; }
        public virtual DbSet<AcuityTestInvoice> AcuityTestInvoices { get; set; }
        public virtual DbSet<AllocationRule> AllocationRules { get; set; }
        public virtual DbSet<AppealQuery16june> AppealQuery16junes { get; set; }
        public virtual DbSet<AppealRule> AppealRules { get; set; }
        public virtual DbSet<ApprovalRule> ApprovalRules { get; set; }
        public virtual DbSet<Client> Clients { get; set; }
        public virtual DbSet<ClientAddress> ClientAddresses { get; set; }
        public virtual DbSet<ClientApprover> ClientApprovers { get; set; }
        public virtual DbSet<ClientContact> ClientContacts { get; set; }
        public virtual DbSet<ClientDocument> ClientDocuments { get; set; }
        public virtual DbSet<ClientInvPrepRate> ClientInvPrepRates { get; set; }
        public virtual DbSet<ClientMatterCustomField> ClientMatterCustomFields { get; set; }
        public virtual DbSet<ClientNote> ClientNotes { get; set; }
        public virtual DbSet<ConditionOperand> ConditionOperands { get; set; }
        public virtual DbSet<CorrectionReportType> CorrectionReportTypes { get; set; }
        public virtual DbSet<CustomEmailTemplate> CustomEmailTemplates { get; set; }
        public virtual DbSet<CustomField> CustomFields { get; set; }
        public virtual DbSet<DashboardArtrackingMonthly> DashboardArtrackingMonthlies { get; set; }
        public virtual DbSet<DashboardStatistic> DashboardStatistics { get; set; }
        public virtual DbSet<Deletedpayer07oct2019> Deletedpayer07oct2019s { get; set; }
        public virtual DbSet<Document> Documents { get; set; }
        public virtual DbSet<EmailTemplate> EmailTemplates { get; set; }
        public virtual DbSet<ExtendData> ExtendDatas { get; set; }
        public virtual DbSet<ExtendHeader> ExtendHeaders { get; set; }
        public virtual DbSet<FavouriteReport> FavouriteReports { get; set; }
        public virtual DbSet<FileExchangeExportLog> FileExchangeExportLogs { get; set; }
        public virtual DbSet<FirmClientHistoricalData> FirmClientHistoricalDatas { get; set; }
        public virtual DbSet<FirmClientHistoricalDataLog> FirmClientHistoricalDataLogs { get; set; }
        public virtual DbSet<InjuryTypeCategory> InjuryTypeCategories { get; set; }
        public virtual DbSet<InjuryTypeCategoryRelation> InjuryTypeCategoryRelations { get; set; }
        public virtual DbSet<InjuryTypeSubCategory> InjuryTypeSubCategories { get; set; }
        public virtual DbSet<InvPrepInvoice> InvPrepInvoices { get; set; }
        public virtual DbSet<InvPrepInvoiceLine> InvPrepInvoiceLines { get; set; }
        public virtual DbSet<Invoice> Invoices { get; set; }
        public virtual DbSet<InvoiceAppliedRule> InvoiceAppliedRules { get; set; }
        public virtual DbSet<InvoiceClient> InvoiceClients { get; set; }
        public virtual DbSet<InvoiceDocument> InvoiceDocuments { get; set; }
        public virtual DbSet<InvoiceFile> InvoiceFiles { get; set; }
        public virtual DbSet<InvoiceFirm> InvoiceFirms { get; set; }
        public virtual DbSet<InvoiceLineItem> InvoiceLineItems { get; set; }
        public virtual DbSet<InvoiceLineItemDiscCred> InvoiceLineItemDiscCreds { get; set; }
        public virtual DbSet<InvoiceLog> InvoiceLogs { get; set; }
        public virtual DbSet<InvoiceMatter> InvoiceMatters { get; set; }
        public virtual DbSet<InvoiceNote> InvoiceNotes { get; set; }
        public virtual DbSet<InvoicePrebillMatchLog> InvoicePrebillMatchLogs { get; set; }
        public virtual DbSet<InvoicePrepInvoiceInvoiceReln> InvoicePrepInvoiceInvoiceRelns { get; set; }
        public virtual DbSet<InvoiceRegulatoryStatement> InvoiceRegulatoryStatements { get; set; }
        public virtual DbSet<InvoiceTaxMatterDiscountCredit> InvoiceTaxMatterDiscountCredits { get; set; }
        public virtual DbSet<InvoiceTaxSummary> InvoiceTaxSummaries { get; set; }
        public virtual DbSet<InvoiceTaxis> InvoiceTaxes { get; set; }
        public virtual DbSet<InvoiceTimekeeperSummary> InvoiceTimekeeperSummaries { get; set; }
        public virtual DbSet<InvoiceUpload> InvoiceUploads { get; set; }
        public virtual DbSet<InvoiceValidation> InvoiceValidations { get; set; }
        public virtual DbSet<LawFirm> LawFirms { get; set; }
        public virtual DbSet<LawFirmClientFileExchangeExportSetting> LawFirmClientFileExchangeExportSettings { get; set; }
        public virtual DbSet<LawFirmContactPerson> LawFirmContactPersons { get; set; }
        public virtual DbSet<LawFirmEbiller> LawFirmEbillers { get; set; }
        public virtual DbSet<LawFirmMatterCustomField> LawFirmMatterCustomFields { get; set; }
        public virtual DbSet<LawFirmNote> LawFirmNotes { get; set; }
        public virtual DbSet<LawFirmOffice> LawFirmOffices { get; set; }
        public virtual DbSet<LawFirmRate> LawFirmRates { get; set; }
        public virtual DbSet<LawfirmClient> LawfirmClients { get; set; }
        public virtual DbSet<LawfirmInvoiceUpload> LawfirmInvoiceUploads { get; set; }
        public virtual DbSet<LineItemCommunication> LineItemCommunications { get; set; }
        public virtual DbSet<LineItemCommunicationsBackup30apr2019> LineItemCommunicationsBackup30apr2019s { get; set; }
        public virtual DbSet<LineItemCommunicationstemp> LineItemCommunicationstemps { get; set; }
        public virtual DbSet<Log> Logs { get; set; }
        public virtual DbSet<LossType> LossTypes { get; set; }
        public virtual DbSet<LossTypeCategory> LossTypeCategories { get; set; }
        public virtual DbSet<MasterAppealQueries1> MasterAppealQueries1s { get; set; }
        public virtual DbSet<MasterAppealQuery> MasterAppealQueries { get; set; }
        public virtual DbSet<MasterBillingType> MasterBillingTypes { get; set; }
        public virtual DbSet<MasterContactType> MasterContactTypes { get; set; }
        public virtual DbSet<MasterCountry> MasterCountries { get; set; }
        public virtual DbSet<MasterCurrency> MasterCurrencies { get; set; }
        public virtual DbSet<MasterDocumentCategory> MasterDocumentCategories { get; set; }
        public virtual DbSet<MasterEbiller> MasterEbillers { get; set; }
        public virtual DbSet<MasterEbillerStatus> MasterEbillerStatuses { get; set; }
        public virtual DbSet<MasterInjurySeverityCode> MasterInjurySeverityCodes { get; set; }
        public virtual DbSet<MasterInjuryType> MasterInjuryTypes { get; set; }
        public virtual DbSet<MasterInvoiceAppealStatus> MasterInvoiceAppealStatuses { get; set; }
        public virtual DbSet<MasterInvoiceStatus> MasterInvoiceStatuses { get; set; }
        public virtual DbSet<MasterLawFirmTimeAndBillingSystem> MasterLawFirmTimeAndBillingSystems { get; set; }
        public virtual DbSet<MasterLitigationVenue> MasterLitigationVenues { get; set; }
        public virtual DbSet<MasterLossType> MasterLossTypes { get; set; }
        public virtual DbSet<MasterMatterCaseType> MasterMatterCaseTypes { get; set; }
        public virtual DbSet<MasterMatterDispositionType> MasterMatterDispositionTypes { get; set; }
        public virtual DbSet<MasterMatterIndemnityType> MasterMatterIndemnityTypes { get; set; }
        public virtual DbSet<MasterMatterLitigationOrOtherCaseType> MasterMatterLitigationOrOtherCaseTypes { get; set; }
        public virtual DbSet<MasterMatterQuestion> MasterMatterQuestions { get; set; }
        public virtual DbSet<MasterMatterWorkersCompIndemnityType> MasterMatterWorkersCompIndemnityTypes { get; set; }
        public virtual DbSet<MasterMatterWorkersCompOtherIndemnityType> MasterMatterWorkersCompOtherIndemnityTypes { get; set; }
        public virtual DbSet<MasterPreparationNote> MasterPreparationNotes { get; set; }
        public virtual DbSet<MasterProductLine> MasterProductLines { get; set; }
        public virtual DbSet<MasterQueries1> MasterQueries1s { get; set; }
        public virtual DbSet<MasterQuery> MasterQueries { get; set; }
        public virtual DbSet<MasterReport> MasterReports { get; set; }
        public virtual DbSet<MasterReportCategory> MasterReportCategories { get; set; }
        public virtual DbSet<MasterRole> MasterRoles { get; set; }
        public virtual DbSet<MasterState> MasterStates { get; set; }
        public virtual DbSet<MasterSuitCounty> MasterSuitCounties { get; set; }
        public virtual DbSet<MasterSuitState> MasterSuitStates { get; set; }
        public virtual DbSet<MasterTaskName> MasterTaskNames { get; set; }
        public virtual DbSet<MasterTemplateActionType> MasterTemplateActionTypes { get; set; }
        public virtual DbSet<MasterTicketArea> MasterTicketAreas { get; set; }
        public virtual DbSet<MasterTimekeeperLevel> MasterTimekeeperLevels { get; set; }
        public virtual DbSet<MasterUserStatus> MasterUserStatuses { get; set; }
        public virtual DbSet<MasterUtbmsCodeSet> MasterUtbmsCodeSets { get; set; }
        public virtual DbSet<MasterUtbmsCodeSetDetail> MasterUtbmsCodeSetDetails { get; set; }
        public virtual DbSet<Matter> Matters { get; set; }
        public virtual DbSet<MatterBudget> MatterBudgets { get; set; }
        public virtual DbSet<MatterBudgetLine> MatterBudgetLines { get; set; }
        public virtual DbSet<MatterClientContact> MatterClientContacts { get; set; }
        public virtual DbSet<MatterCustomField> MatterCustomFields { get; set; }
        public virtual DbSet<MatterCustomFieldValue> MatterCustomFieldValues { get; set; }
        public virtual DbSet<MatterDocument> MatterDocuments { get; set; }
        public virtual DbSet<MatterException> MatterExceptions { get; set; }
        public virtual DbSet<MatterInjuryType> MatterInjuryTypes { get; set; }
        public virtual DbSet<MatterLawFirmContact> MatterLawFirmContacts { get; set; }
        public virtual DbSet<MatterLossType> MatterLossTypes { get; set; }
        public virtual DbSet<MatterNote> MatterNotes { get; set; }
        public virtual DbSet<MatterQuestion> MatterQuestions { get; set; }
        public virtual DbSet<MatterRate> MatterRates { get; set; }
        public virtual DbSet<MatterTimekeeper> MatterTimekeepers { get; set; }
        public virtual DbSet<MelickOct2020Prebill> MelickOct2020Prebills { get; set; }
        public virtual DbSet<Message> Messages { get; set; }
        public virtual DbSet<MessageAttachment> MessageAttachments { get; set; }
        public virtual DbSet<NonIpsinvoice> NonIpsinvoices { get; set; }
        public virtual DbSet<OlsonInvoicedate> OlsonInvoicedates { get; set; }
        public virtual DbSet<OperandFieldType> OperandFieldTypes { get; set; }
        public virtual DbSet<ParamsGetDashboardClientWiseReductionDrillDown> ParamsGetDashboardClientWiseReductionDrillDowns { get; set; }
        public virtual DbSet<ParamsGetTimeKeeperReductionInvoiceDetail> ParamsGetTimeKeeperReductionInvoiceDetails { get; set; }
        public virtual DbSet<PayerDocument> PayerDocuments { get; set; }
        public virtual DbSet<PayerNote> PayerNotes { get; set; }
        public virtual DbSet<Payerlevel> Payerlevels { get; set; }
        public virtual DbSet<PendingInvoiceApprovalNotification> PendingInvoiceApprovalNotifications { get; set; }
        public virtual DbSet<PreBillCorrectionReportDetail> PreBillCorrectionReportDetails { get; set; }
        public virtual DbSet<PreBillUpload> PreBillUploads { get; set; }
        public virtual DbSet<PrebillToInvoiceTklevelMapping> PrebillToInvoiceTklevelMappings { get; set; }
        public virtual DbSet<PreparationReportType> PreparationReportTypes { get; set; }
        public virtual DbSet<ProgrammedAction> ProgrammedActions { get; set; }
        public virtual DbSet<ProgrammedCondition> ProgrammedConditions { get; set; }
        public virtual DbSet<ReleaseNote> ReleaseNotes { get; set; }
        public virtual DbSet<ReminderNotificationMail> ReminderNotificationMails { get; set; }
        public virtual DbSet<ReportSelectedColumn> ReportSelectedColumns { get; set; }
        public virtual DbSet<Rule> Rules { get; set; }
        public virtual DbSet<RuleArea> RuleAreas { get; set; }
        public virtual DbSet<RuleAssignment> RuleAssignments { get; set; }
        public virtual DbSet<RuleAssignmentExcludedProductLine> RuleAssignmentExcludedProductLines { get; set; }
        public virtual DbSet<RuleAssignments1jan2020> RuleAssignments1jan2020s { get; set; }
        public virtual DbSet<RuleCategory> RuleCategories { get; set; }
        public virtual DbSet<RuleEntity> RuleEntities { get; set; }
        public virtual DbSet<RuleField> RuleFields { get; set; }
        public virtual DbSet<RuleFieldType> RuleFieldTypes { get; set; }
        public virtual DbSet<RuleSet> RuleSets { get; set; }
        public virtual DbSet<RulesBackUp> RulesBackUps { get; set; }
        public virtual DbSet<SheehyLibertyInvoicesid15jul2019> SheehyLibertyInvoicesid15jul2019s { get; set; }
        public virtual DbSet<SheehyLibertyInvoicesid15jul20192> SheehyLibertyInvoicesid15jul20192s { get; set; }
        public virtual DbSet<SiteAction> SiteActions { get; set; }
        public virtual DbSet<SystemAlert> SystemAlerts { get; set; }
        public virtual DbSet<SystemTask> SystemTasks { get; set; }
        public virtual DbSet<SystemTaskNote> SystemTaskNotes { get; set; }
        public virtual DbSet<TaxItem> TaxItems { get; set; }
        public virtual DbSet<TempInvoicesDel> TempInvoicesDels { get; set; }
        public virtual DbSet<TempStatefarmBarCapture08aug2020> TempStatefarmBarCapture08aug2020s { get; set; }
        public virtual DbSet<TestLineitemcommunication> TestLineitemcommunications { get; set; }
        public virtual DbSet<TestTable> TestTables { get; set; }
        public virtual DbSet<Ticket> Tickets { get; set; }
        public virtual DbSet<TicketAttachment> TicketAttachments { get; set; }
        public virtual DbSet<TicketCommentAttachment> TicketCommentAttachments { get; set; }
        public virtual DbSet<TicketResponse> TicketResponses { get; set; }
        public virtual DbSet<TimekeeperNote> TimekeeperNotes { get; set; }
        public virtual DbSet<TimekeeperRate> TimekeeperRates { get; set; }
        public virtual DbSet<TmpHannaprebillIssue07Jan2021> TmpHannaprebillIssue07Jan2021s { get; set; }
        public virtual DbSet<TrackingMenuItem> TrackingMenuItems { get; set; }
        public virtual DbSet<TypeOfAddress> TypeOfAddresses { get; set; }
        public virtual DbSet<User> Users { get; set; }
        public virtual DbSet<UserDefinedAction> UserDefinedActions { get; set; }
        public virtual DbSet<UserDefinedCondition> UserDefinedConditions { get; set; }
        public virtual DbSet<UserDefinedConditionsbackup> UserDefinedConditionsbackups { get; set; }
        public virtual DbSet<UserLoginLog> UserLoginLogs { get; set; }
        public virtual DbSet<UserRole> UserRoles { get; set; }
        public virtual DbSet<UserdefinedActionsbackup> UserdefinedActionsbackups { get; set; }
        public virtual DbSet<VwAllBillType> VwAllBillTypes { get; set; }
        public virtual DbSet<VwArtracking> VwArtrackings { get; set; }
        public virtual DbSet<VwDashboardPreBillTracking> VwDashboardPreBillTrackings { get; set; }
        public virtual DbSet<VwDashboardTracking> VwDashboardTrackings { get; set; }
        public virtual DbSet<VwDashboardTrackingAll> VwDashboardTrackingAlls { get; set; }
        public virtual DbSet<VwInvoice> VwInvoices { get; set; }
        public virtual DbSet<VwInvoiceInvalidation> VwInvoiceInvalidations { get; set; }
        public virtual DbSet<VwInvoiceswithoutprebill> VwInvoiceswithoutprebills { get; set; }
        public virtual DbSet<VwInvoiceswithstatusexclude> VwInvoiceswithstatusexcludes { get; set; }
        public virtual DbSet<VwPreBill> VwPreBills { get; set; }
        public virtual DbSet<VwPreBillswithstatusexclude> VwPreBillswithstatusexcludes { get; set; }
        public virtual DbSet<WanekLibertyInvoiceclient> WanekLibertyInvoiceclients { get; set; }
        public virtual DbSet<WanekLibertyMatter> WanekLibertyMatters { get; set; }
        public virtual DbSet<WanekLibertyTimekeeperRate> WanekLibertyTimekeeperRates { get; set; }
        public virtual DbSet<WorkDistributionRule> WorkDistributionRules { get; set; }
        public virtual DbSet<WorkDistributionRuleUser> WorkDistributionRuleUsers { get; set; }
        public virtual DbSet<XaiTesting28> XaiTesting28s { get; set; }
        public virtual DbSet<XaiTesting28NoRule> XaiTesting28NoRules { get; set; }
        public virtual DbSet<XaiTesting28Rule> XaiTesting28Rules { get; set; }
        public virtual DbSet<Xxaii> Xxaiis { get; set; }
        public virtual DbSet<ZarwinAutomationRunsep2019> ZarwinAutomationRunsep2019s { get; set; }
        public virtual DbSet<ZcAiLawfirmMapping> ZcAiLawfirmMappings { get; set; }
        public virtual DbSet<ZcAiTesting> ZcAiTestings { get; set; }
        public virtual DbSet<ZcAiTestingRule> ZcAiTestingRules { get; set; }
        public virtual DbSet<ZcAppealStatusChanngedInvoice31jan2020> ZcAppealStatusChanngedInvoice31jan2020s { get; set; }
        public virtual DbSet<ZcDeletedInvoiceAppliedRulesOn29Aug2019> ZcDeletedInvoiceAppliedRulesOn29Aug2019s { get; set; }
        public virtual DbSet<ZcDeletedLineItemOn29Aug2019> ZcDeletedLineItemOn29Aug2019s { get; set; }
        public virtual DbSet<ZcDxclssgreat1> ZcDxclssgreat1s { get; set; }
        public virtual DbSet<ZcHannaBrophyCigaPrebillInvoiceMatching> ZcHannaBrophyCigaPrebillInvoiceMatchings { get; set; }
        public virtual DbSet<ZcInvPrepInvoiceLinesBackup03may2019> ZcInvPrepInvoiceLinesBackup03may2019s { get; set; }
        public virtual DbSet<ZcInvPrepInvoices03may2019> ZcInvPrepInvoices03may2019s { get; set; }
        public virtual DbSet<ZcInvoiceClients19apr2019> ZcInvoiceClients19apr2019s { get; set; }
        public virtual DbSet<ZcInvoiceLineitems13apr2020> ZcInvoiceLineitems13apr2020s { get; set; }
        public virtual DbSet<ZcInvoicePrepInvoiceInvoiceRelnBackup03may2019> ZcInvoicePrepInvoiceInvoiceRelnBackup03may2019s { get; set; }
        public virtual DbSet<ZcInvoiceTimekeeperSummaries27mar2019> ZcInvoiceTimekeeperSummaries27mar2019s { get; set; }
        public virtual DbSet<ZcInvoiceTraubRsui312690> ZcInvoiceTraubRsui312690s { get; set; }
        public virtual DbSet<ZcInvoiceappliedrules04oct2019> ZcInvoiceappliedrules04oct2019s { get; set; }
        public virtual DbSet<ZcInvoiceappliedrules13apr2020> ZcInvoiceappliedrules13apr2020s { get; set; }
        public virtual DbSet<ZcLmSelectedMattersFeb2020> ZcLmSelectedMattersFeb2020s { get; set; }
        public virtual DbSet<ZcLmSelectedMattersFeb20201> ZcLmSelectedMattersFeb20201s { get; set; }
        public virtual DbSet<ZcQuery> ZcQueries { get; set; }
        public virtual DbSet<ZcRejectToFirm2019> ZcRejectToFirm2019s { get; set; }
        public virtual DbSet<ZcRepeatingBillingcode> ZcRepeatingBillingcodes { get; set; }
        public virtual DbSet<ZcRighiPrebills05nov2019> ZcRighiPrebills05nov2019s { get; set; }
        public virtual DbSet<ZcSmithFreedInvoicesTest> ZcSmithFreedInvoicesTests { get; set; }
        public virtual DbSet<ZcSmithTkJlf23jan2020> ZcSmithTkJlf23jan2020s { get; set; }
        public virtual DbSet<ZcTestInv21may> ZcTestInv21mays { get; set; }
        public virtual DbSet<ZcTokioMattersToMove06march2020> ZcTokioMattersToMove06march2020s { get; set; }
        public virtual DbSet<ZcTop4PayersRedInvoice> ZcTop4PayersRedInvoices { get; set; }
        public virtual DbSet<ZcTop5PayersInvoice> ZcTop5PayersInvoices { get; set; }
        public virtual DbSet<Zcdltinv> Zcdltinvs { get; set; }
        public virtual DbSet<ZchartfordNavigatorsRule> ZchartfordNavigatorsRules { get; set; }
        public virtual DbSet<Zcmatters19apr2019> Zcmatters19apr2019s { get; set; }
        public virtual DbSet<ZcmorrisduffyTokiomarine> ZcmorrisduffyTokiomarines { get; set; }
        public virtual DbSet<InvoiceListingGridModel> InvoiceListingGrid { get; set; }
        public virtual DbSet<InvoiceLineItemsListingGridModel> InvoiceLineItemsListingGrid { get; set; }

        #endregion

        #region On Model Creating
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("Relational:Collation", "Latin1_General_CI_AI");

            modelBuilder.Entity<ActionOperand>(entity =>
            {
                entity.Property(e => e.Operand).IsRequired();
            });

            modelBuilder.Entity<ActionOperandFieldType>(entity =>
            {
                entity.HasIndex(e => e.FieldTypeId, "IX_FieldTypeId");

                entity.HasIndex(e => e.OperandId, "IX_OperandId");

                entity.HasOne(d => d.FieldType)
                    .WithMany(p => p.ActionOperandFieldTypes)
                    .HasForeignKey(d => d.FieldTypeId)
                    .OnDelete(DeleteBehavior.ClientSetNull);

                entity.HasOne(d => d.Operand)
                    .WithMany(p => p.ActionOperandFieldTypes)
                    .HasForeignKey(d => d.OperandId)
                    .OnDelete(DeleteBehavior.ClientSetNull);
            });

            modelBuilder.Entity<AcuityAutomationReductionReason>(entity =>
            {
                entity.HasNoKey();

                entity.Property(e => e.AutomationId).HasMaxLength(100);

                entity.Property(e => e.Id)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("id");

                entity.Property(e => e.ReductionKey).HasMaxLength(100);

                entity.Property(e => e.ReductionReason).HasMaxLength(1000);
            });

            modelBuilder.Entity<AcuityTestInvoice>(entity =>
            {
                entity.HasNoKey();
            });

            modelBuilder.Entity<AllocationRule>(entity =>
            {
                entity.HasIndex(e => new { e.Type, e.LawFirmId, e.ClientId }, "IX_AllocationRules_TypeLawFirmClient");

                entity.Property(e => e.AllocatedToId).HasColumnName("AllocatedTo_Id");

                entity.Property(e => e.ClientId).HasColumnName("Client_Id");

                entity.Property(e => e.CreatedById).HasColumnName("CreatedBy_Id");

                entity.Property(e => e.CreatedTime).HasColumnType("datetime");

                entity.Property(e => e.Description).HasMaxLength(1000);

                entity.Property(e => e.LawFirmId).HasColumnName("LawFirm_Id");

                entity.Property(e => e.ModifiedById).HasColumnName("ModifiedBy_Id");

                entity.Property(e => e.ModifiedTime).HasColumnType("datetime");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.HasOne(d => d.AllocatedTo)
                    .WithMany(p => p.AllocationRuleAllocatedTos)
                    .HasForeignKey(d => d.AllocatedToId)
                    .HasConstraintName("fk_allocationrules_AllocatedTo");

                entity.HasOne(d => d.Client)
                    .WithMany(p => p.AllocationRules)
                    .HasForeignKey(d => d.ClientId)
                    .HasConstraintName("fk_allocationrules_client");

                entity.HasOne(d => d.CreatedBy)
                    .WithMany(p => p.AllocationRuleCreatedBies)
                    .HasForeignKey(d => d.CreatedById)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_allocationrules_CreatedByUser");

                entity.HasOne(d => d.LawFirm)
                    .WithMany(p => p.AllocationRules)
                    .HasForeignKey(d => d.LawFirmId)
                    .HasConstraintName("fk_allocationrules_lawfirm");

                entity.HasOne(d => d.ModifiedBy)
                    .WithMany(p => p.AllocationRuleModifiedBies)
                    .HasForeignKey(d => d.ModifiedById)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_allocationrules_ModifiedByUser");
            });

            modelBuilder.Entity<AppealQuery16june>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("AppealQuery16june");

                entity.Property(e => e.Code).HasMaxLength(255);
            });

            modelBuilder.Entity<AppealRule>(entity =>
            {
                entity.Property(e => e.Change).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.ClientId).HasColumnName("Client_Id");

                entity.Property(e => e.CreatedById).HasColumnName("CreatedBy_Id");

                entity.Property(e => e.CreatedTime).HasColumnType("datetime");

                entity.Property(e => e.Description).HasMaxLength(1000);

                entity.Property(e => e.InvoiceTotal).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.LawFirmId).HasColumnName("LawFirm_Id");

                entity.Property(e => e.ModifiedById).HasColumnName("ModifiedBy_Id");

                entity.Property(e => e.ModifiedTime).HasColumnType("datetime");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.Property(e => e.PaidByPayer).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.PayerExpenseReduction).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.PayerFeeReduction).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.PreparerId).HasColumnName("Preparer_Id");

                entity.Property(e => e.ReductionByPayer).HasColumnType("decimal(18, 2)");

                entity.HasOne(d => d.CreatedBy)
                    .WithMany(p => p.AppealRuleCreatedBies)
                    .HasForeignKey(d => d.CreatedById)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_AppealRules_Users1");

                entity.HasOne(d => d.LawFirm)
                    .WithMany(p => p.AppealRules)
                    .HasForeignKey(d => d.LawFirmId)
                    .HasConstraintName("FK_AppealRules_LawFirms");

                entity.HasOne(d => d.ModifiedBy)
                    .WithMany(p => p.AppealRuleModifiedBies)
                    .HasForeignKey(d => d.ModifiedById)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_AppealRules_Users");
            });

            modelBuilder.Entity<ApprovalRule>(entity =>
            {
                entity.Property(e => e.ApproverId).HasColumnName("Approver_Id");

                entity.Property(e => e.Change).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.ClientId).HasColumnName("Client_Id");

                entity.Property(e => e.CreatedById).HasColumnName("CreatedBy_Id");

                entity.Property(e => e.CreatedTime).HasColumnType("datetime");

                entity.Property(e => e.Description).HasMaxLength(1000);

                entity.Property(e => e.InvoiceTotal).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.LawFirmId).HasColumnName("LawFirm_Id");

                entity.Property(e => e.ModifiedById).HasColumnName("ModifiedBy_Id");

                entity.Property(e => e.ModifiedTime).HasColumnType("datetime");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.Property(e => e.OfflineApproverEmail)
                    .HasMaxLength(255)
                    .HasColumnName("OfflineApprover_Email");

                entity.Property(e => e.PreparerId).HasColumnName("Preparer_Id");

                entity.Property(e => e.SecondApproverId).HasColumnName("SecondApprover_Id");

                entity.Property(e => e.ThirdApproverId).HasColumnName("ThirdApprover_Id");

                entity.HasOne(d => d.Approver)
                    .WithMany(p => p.ApprovalRuleApprovers)
                    .HasForeignKey(d => d.ApproverId)
                    .HasConstraintName("fk_approvalrules_Approver");

                entity.HasOne(d => d.Client)
                    .WithMany(p => p.ApprovalRules)
                    .HasForeignKey(d => d.ClientId)
                    .HasConstraintName("fk_approvalrules_client");

                entity.HasOne(d => d.CreatedBy)
                    .WithMany(p => p.ApprovalRuleCreatedBies)
                    .HasForeignKey(d => d.CreatedById)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_approvalrules_CreatedByUser");

                entity.HasOne(d => d.LawFirm)
                    .WithMany(p => p.ApprovalRules)
                    .HasForeignKey(d => d.LawFirmId)
                    .HasConstraintName("fk_approvalrules_lawfirm");

                entity.HasOne(d => d.ModifiedBy)
                    .WithMany(p => p.ApprovalRuleModifiedBies)
                    .HasForeignKey(d => d.ModifiedById)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_approvalrules_ModifiedByUser");

                entity.HasOne(d => d.Preparer)
                    .WithMany(p => p.ApprovalRulePreparers)
                    .HasForeignKey(d => d.PreparerId)
                    .HasConstraintName("fk_approvalrules_preparer");

                entity.HasOne(d => d.SecondApprover)
                    .WithMany(p => p.ApprovalRuleSecondApprovers)
                    .HasForeignKey(d => d.SecondApproverId)
                    .HasConstraintName("fk_approvalrules_SecondApprover");

                entity.HasOne(d => d.ThirdApprover)
                    .WithMany(p => p.ApprovalRuleThirdApprovers)
                    .HasForeignKey(d => d.ThirdApproverId)
                    .HasConstraintName("fk_approvalrules_ThirdApprover");
            });

            modelBuilder.Entity<Client>(entity =>
            {
                entity.HasIndex(e => e.Name, "IX_Client_Name");

                entity.HasIndex(e => e.CreatedById, "IX_CreatedBy_Id");

                entity.HasIndex(e => e.ModifiedById, "IX_ModifiedBy_Id");

                entity.Property(e => e.Addr1).HasMaxLength(100);

                entity.Property(e => e.Addr2).HasMaxLength(100);

                entity.Property(e => e.Addr3).HasMaxLength(100);

                entity.Property(e => e.City).HasMaxLength(100);

                entity.Property(e => e.Country)
                    .IsRequired()
                    .HasMaxLength(3);

                entity.Property(e => e.CreatedById).HasColumnName("CreatedBy_Id");

                entity.Property(e => e.CreatedTime).HasColumnType("datetime");

                entity.Property(e => e.ModifiedById).HasColumnName("ModifiedBy_Id");

                entity.Property(e => e.ModifiedTime).HasColumnType("datetime");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(255);

                entity.Property(e => e.PinCode).HasMaxLength(10);

                entity.Property(e => e.PrintName).HasMaxLength(255);

                entity.Property(e => e.State).HasMaxLength(50);

                entity.Property(e => e.TaxId).HasMaxLength(50);

                entity.Property(e => e.Tel).HasMaxLength(20);

                entity.HasOne(d => d.CreatedBy)
                    .WithMany(p => p.ClientCreatedBies)
                    .HasForeignKey(d => d.CreatedById);

                entity.HasOne(d => d.ModifiedBy)
                    .WithMany(p => p.ClientModifiedBies)
                    .HasForeignKey(d => d.ModifiedById);
            });

            modelBuilder.Entity<ClientAddress>(entity =>
            {
                entity.HasIndex(e => e.ClientId, "IX_Client_Id");

                entity.HasIndex(e => e.TypeOfAddressId, "IX_TypeOfAddress_Id");

                entity.Property(e => e.Addr1).HasMaxLength(100);

                entity.Property(e => e.Addr2).HasMaxLength(100);

                entity.Property(e => e.Addr3).HasMaxLength(100);

                entity.Property(e => e.City).HasMaxLength(100);

                entity.Property(e => e.ClientId).HasColumnName("Client_Id");

                entity.Property(e => e.Country)
                    .IsRequired()
                    .HasMaxLength(3);

                entity.Property(e => e.Email).HasMaxLength(50);

                entity.Property(e => e.Fax).HasMaxLength(20);

                entity.Property(e => e.PinCode).HasMaxLength(10);

                entity.Property(e => e.State).HasMaxLength(50);

                entity.Property(e => e.Tel).HasMaxLength(20);

                entity.Property(e => e.TypeOfAddressId).HasColumnName("TypeOfAddress_Id");

                entity.HasOne(d => d.Client)
                    .WithMany(p => p.ClientAddresses)
                    .HasForeignKey(d => d.ClientId)
                    .OnDelete(DeleteBehavior.ClientSetNull);

                entity.HasOne(d => d.TypeOfAddress)
                    .WithMany(p => p.ClientAddresses)
                    .HasForeignKey(d => d.TypeOfAddressId)
                    .OnDelete(DeleteBehavior.ClientSetNull);
            });

            modelBuilder.Entity<ClientApprover>(entity =>
            {
                entity.Property(e => e.ApprovalRuleId).HasColumnName("ApprovalRule_Id");

                entity.Property(e => e.ApproverId).HasColumnName("Approver_Id");

                entity.HasOne(d => d.ApprovalRule)
                    .WithMany(p => p.ClientApprovers)
                    .HasForeignKey(d => d.ApprovalRuleId)
                    .HasConstraintName("FK_ClientApprovers_ApprovalRules");

                entity.HasOne(d => d.Approver)
                    .WithMany(p => p.ClientApprovers)
                    .HasForeignKey(d => d.ApproverId)
                    .HasConstraintName("FK_ClientApprovers_Users");
            });

            modelBuilder.Entity<ClientContact>(entity =>
            {
                entity.HasIndex(e => e.LawfirmClientId, "IX_Lawfirm_Client_Id");

                entity.Property(e => e.Cell).HasMaxLength(20);

                entity.Property(e => e.Email).HasMaxLength(100);

                entity.Property(e => e.Fax).HasMaxLength(20);

                entity.Property(e => e.FirstName)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.Property(e => e.LastName).HasMaxLength(100);

                entity.Property(e => e.LawfirmClientId).HasColumnName("Lawfirm_Client_Id");

                entity.Property(e => e.MiddleName).HasMaxLength(100);

                entity.Property(e => e.Tel).HasMaxLength(20);

                entity.HasOne(d => d.LawfirmClient)
                    .WithMany(p => p.ClientContacts)
                    .HasForeignKey(d => d.LawfirmClientId)
                    .OnDelete(DeleteBehavior.ClientSetNull);
            });

            modelBuilder.Entity<ClientDocument>(entity =>
            {
                entity.HasIndex(e => e.ClientId, "IX_Client_Id");

                entity.HasIndex(e => e.DocumentId, "IX_Document_Id");

                entity.Property(e => e.ClientId).HasColumnName("Client_Id");

                entity.Property(e => e.DocumentId).HasColumnName("Document_Id");

                entity.Property(e => e.LawFirmId).HasColumnName("LawFirm_Id");

                entity.HasOne(d => d.Client)
                    .WithMany(p => p.ClientDocuments)
                    .HasForeignKey(d => d.ClientId)
                    .OnDelete(DeleteBehavior.ClientSetNull);

                entity.HasOne(d => d.Document)
                    .WithMany(p => p.ClientDocuments)
                    .HasForeignKey(d => d.DocumentId)
                    .OnDelete(DeleteBehavior.ClientSetNull);

                entity.HasOne(d => d.LawFirm)
                    .WithMany(p => p.ClientDocuments)
                    .HasForeignKey(d => d.LawFirmId)
                    .HasConstraintName("FK_ClientDocuments_LawFirm_Id");
            });

            modelBuilder.Entity<ClientInvPrepRate>(entity =>
            {
                entity.Property(e => e.ClientId).HasColumnName("Client_Id");

                entity.Property(e => e.InvPrepExpRate).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.InvPrepRate).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.LawFirmId).HasColumnName("LawFirm_Id");

                entity.Property(e => e.MasterProductLineId).HasColumnName("MasterProductLine_Id");

                entity.Property(e => e.TaxRate).HasColumnType("decimal(18, 2)");

                entity.HasOne(d => d.Client)
                    .WithMany(p => p.ClientInvPrepRates)
                    .HasForeignKey(d => d.ClientId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__ClientInv__Clien__7FB5F314");

                entity.HasOne(d => d.LawFirm)
                    .WithMany(p => p.ClientInvPrepRates)
                    .HasForeignKey(d => d.LawFirmId)
                    .HasConstraintName("FK_ClientInvPrepRates_LawFirm_Id");

                entity.HasOne(d => d.MasterProductLine)
                    .WithMany(p => p.ClientInvPrepRates)
                    .HasForeignKey(d => d.MasterProductLineId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__ClientInv__Maste__00AA174D");
            });

            modelBuilder.Entity<ClientMatterCustomField>(entity =>
            {
                entity.HasIndex(e => e.ClientId, "IX_Client_Id");

                entity.HasIndex(e => e.CreatedById, "IX_CreatedBy_Id");

                entity.HasIndex(e => e.MatterCustomFieldId, "IX_MatterCustomField_Id");

                entity.HasIndex(e => e.ModifiedById, "IX_ModifiedBy_Id");

                entity.HasIndex(e => e.ProductLineId, "IX_ProductLine_Id");

                entity.Property(e => e.ClientId).HasColumnName("Client_Id");

                entity.Property(e => e.CreatedById).HasColumnName("CreatedBy_Id");

                entity.Property(e => e.CreatedTime).HasColumnType("datetime");

                entity.Property(e => e.MatterCustomFieldId).HasColumnName("MatterCustomField_Id");

                entity.Property(e => e.ModifiedById).HasColumnName("ModifiedBy_Id");

                entity.Property(e => e.ModifiedTime).HasColumnType("datetime");

                entity.Property(e => e.ProductLineId).HasColumnName("ProductLine_Id");

                entity.HasOne(d => d.Client)
                    .WithMany(p => p.ClientMatterCustomFields)
                    .HasForeignKey(d => d.ClientId)
                    .OnDelete(DeleteBehavior.ClientSetNull);

                entity.HasOne(d => d.CreatedBy)
                    .WithMany(p => p.ClientMatterCustomFieldCreatedBies)
                    .HasForeignKey(d => d.CreatedById)
                    .OnDelete(DeleteBehavior.ClientSetNull);

                entity.HasOne(d => d.MatterCustomField)
                    .WithMany(p => p.ClientMatterCustomFields)
                    .HasForeignKey(d => d.MatterCustomFieldId)
                    .OnDelete(DeleteBehavior.ClientSetNull);

                entity.HasOne(d => d.ModifiedBy)
                    .WithMany(p => p.ClientMatterCustomFieldModifiedBies)
                    .HasForeignKey(d => d.ModifiedById)
                    .OnDelete(DeleteBehavior.ClientSetNull);

                entity.HasOne(d => d.ProductLine)
                    .WithMany(p => p.ClientMatterCustomFields)
                    .HasForeignKey(d => d.ProductLineId)
                    .OnDelete(DeleteBehavior.ClientSetNull);
            });

            modelBuilder.Entity<ClientNote>(entity =>
            {
                entity.Property(e => e.ClientId).HasColumnName("Client_Id");

                entity.Property(e => e.CreatedById).HasColumnName("CreatedBy_Id");

                entity.Property(e => e.Note)
                    .IsRequired()
                    .HasMaxLength(1000);

                entity.Property(e => e.NoteTimeStamp).HasColumnType("datetime");

                entity.HasOne(d => d.Client)
                    .WithMany(p => p.ClientNotes)
                    .HasForeignKey(d => d.ClientId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_clientnotes_client");
            });

            modelBuilder.Entity<ConditionOperand>(entity =>
            {
                entity.Property(e => e.Operand).IsRequired();
            });

            modelBuilder.Entity<CorrectionReportType>(entity =>
            {
                entity.Property(e => e.BillType)
                    .IsRequired()
                    .HasMaxLength(10);

                entity.Property(e => e.HelpNote)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.ReportFileName).HasMaxLength(250);

                entity.Property(e => e.ReportName).HasMaxLength(250);
            });

            modelBuilder.Entity<CustomEmailTemplate>(entity =>
            {
                entity.HasIndex(e => e.LawFirmId, "IX_LawFirm_Id");

                entity.HasIndex(e => e.TemplateActionTypeId, "IX_TemplateActionType_Id");

                entity.Property(e => e.From).HasMaxLength(255);

                entity.Property(e => e.LawFirmId).HasColumnName("LawFirm_Id");

                entity.Property(e => e.Subject).HasMaxLength(500);

                entity.Property(e => e.TemplateActionTypeId).HasColumnName("TemplateActionType_Id");

                entity.HasOne(d => d.LawFirm)
                    .WithMany(p => p.CustomEmailTemplates)
                    .HasForeignKey(d => d.LawFirmId)
                    .OnDelete(DeleteBehavior.ClientSetNull);

                entity.HasOne(d => d.TemplateActionType)
                    .WithMany(p => p.CustomEmailTemplates)
                    .HasForeignKey(d => d.TemplateActionTypeId)
                    .OnDelete(DeleteBehavior.ClientSetNull);
            });

            modelBuilder.Entity<CustomField>(entity =>
            {
                entity.HasIndex(e => e.InvoiceMatterId, "IX_CustomFields_InvoiceMatter_Id");

                entity.HasIndex(e => e.InvoiceId, "IX_CustomFields_Invoice_Id");

                entity.Property(e => e.Discriminator)
                    .IsRequired()
                    .HasMaxLength(128);

                entity.Property(e => e.ExtendAddlValue).HasMaxLength(500);

                entity.Property(e => e.ExtendName).HasMaxLength(255);

                entity.Property(e => e.ExtendValue).HasMaxLength(500);

                entity.Property(e => e.InvoiceId).HasColumnName("Invoice_Id");

                entity.Property(e => e.InvoiceMatterId).HasColumnName("InvoiceMatter_Id");

                entity.HasOne(d => d.Invoice)
                    .WithMany(p => p.CustomFields)
                    .HasForeignKey(d => d.InvoiceId);

                entity.HasOne(d => d.InvoiceMatter)
                    .WithMany(p => p.CustomFields)
                    .HasForeignKey(d => d.InvoiceMatterId);
            });

            modelBuilder.Entity<DashboardArtrackingMonthly>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("DashboardARTrackingMonthly");

                entity.Property(e => e.NetReceivable).HasColumnType("decimal(38, 2)");

                entity.Property(e => e.Payer).HasMaxLength(255);

                entity.Property(e => e.PendingWriteOff).HasColumnType("decimal(38, 2)");

                entity.Property(e => e.Writeoff).HasColumnType("decimal(38, 2)");
            });

            modelBuilder.Entity<DashboardStatistic>(entity =>
            {
                entity.Property(e => e.ItemName)
                    .IsRequired()
                    .HasMaxLength(255);

                entity.Property(e => e.MasterRoleId).HasColumnName("MasterRole_Id");

                entity.Property(e => e.Value).HasColumnType("decimal(18, 2)");

                entity.HasOne(d => d.MasterRole)
                    .WithMany(p => p.DashboardStatistics)
                    .HasForeignKey(d => d.MasterRoleId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_dashboardstatistics");
            });

            modelBuilder.Entity<Deletedpayer07oct2019>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("deletedpayer_07oct2019");

                entity.Property(e => e.Addr1).HasMaxLength(100);

                entity.Property(e => e.Addr2).HasMaxLength(100);

                entity.Property(e => e.Addr3).HasMaxLength(100);

                entity.Property(e => e.City).HasMaxLength(100);

                entity.Property(e => e.ClientId).HasColumnName("Client_Id");

                entity.Property(e => e.Country)
                    .IsRequired()
                    .HasMaxLength(3);

                entity.Property(e => e.CreatedById).HasColumnName("CreatedBy_Id");

                entity.Property(e => e.CreatedTime).HasColumnType("datetime");

                entity.Property(e => e.Ebiller)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("EBiller");

                entity.Property(e => e.EbillerAutomationStatus).HasColumnName("EBillerAutomationStatus");

                entity.Property(e => e.EbillerComments)
                    .HasMaxLength(2000)
                    .IsUnicode(false)
                    .HasColumnName("EBillerComments");

                entity.Property(e => e.EbillerEmail)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("EBillerEmail");

                entity.Property(e => e.EbillerPassword)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("EBillerPassword");

                entity.Property(e => e.EbillerReference1)
                    .HasMaxLength(100)
                    .HasColumnName("EBillerReference1");

                entity.Property(e => e.EbillerReference2)
                    .HasMaxLength(100)
                    .HasColumnName("EBillerReference2");

                entity.Property(e => e.EbillerStatus)
                    .HasMaxLength(200)
                    .HasColumnName("EBillerStatus");

                entity.Property(e => e.EbillerStatusChangeDate)
                    .HasColumnType("datetime")
                    .HasColumnName("EBillerStatusChangeDate");

                entity.Property(e => e.EbillerStatusCheckDate)
                    .HasColumnType("datetime")
                    .HasColumnName("EBillerStatusCheckDate");

                entity.Property(e => e.EbillerStatusComments)
                    .HasMaxLength(2000)
                    .HasColumnName("EBillerStatusComments");

                entity.Property(e => e.EbillerUrl)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("EBillerURL");

                entity.Property(e => e.EbillerUserName)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("EBillerUserName");

                entity.Property(e => e.Email).HasMaxLength(100);

                entity.Property(e => e.Fax).HasMaxLength(20);

                entity.Property(e => e.Icrverbiage)
                    .HasMaxLength(2000)
                    .IsUnicode(false)
                    .HasColumnName("ICRVerbiage");

                entity.Property(e => e.Id).ValueGeneratedOnAdd();

                entity.Property(e => e.InvoicePrepExpRate).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.InvoicePrepRate).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.LawFirmEbillerId).HasColumnName("LawFirmEBiller_Id");

                entity.Property(e => e.LawFirmId).HasColumnName("LawFirm_Id");

                entity.Property(e => e.MatterMatchingField)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ModifiedById).HasColumnName("ModifiedBy_Id");

                entity.Property(e => e.ModifiedTime).HasColumnType("datetime");

                entity.Property(e => e.PinCode).HasMaxLength(10);

                entity.Property(e => e.State).HasMaxLength(50);

                entity.Property(e => e.SupportedInvoiceFormat).HasMaxLength(100);

                entity.Property(e => e.SupportedOutputInvoiceFormat).HasMaxLength(100);

                entity.Property(e => e.SupportedPrebillInputFormat).HasMaxLength(100);

                entity.Property(e => e.TaxId).HasMaxLength(50);

                entity.Property(e => e.Tel).HasMaxLength(20);
            });

            modelBuilder.Entity<Document>(entity =>
            {
                entity.HasIndex(e => e.CreatedById, "IX_CreatedBy_Id");

                entity.HasIndex(e => e.DocumentCategoryId, "IX_DocumentCategory_Id");

                entity.Property(e => e.CreatedById).HasColumnName("CreatedBy_Id");

                entity.Property(e => e.CreatedTime).HasColumnType("datetime");

                entity.Property(e => e.Description).HasMaxLength(1000);

                entity.Property(e => e.DisplayName)
                    .IsRequired()
                    .HasMaxLength(255);

                entity.Property(e => e.DocumentCategoryId).HasColumnName("DocumentCategory_Id");

                entity.Property(e => e.Tags).HasMaxLength(1000);

                entity.Property(e => e.UploadedFileName)
                    .IsRequired()
                    .HasMaxLength(255);

                entity.HasOne(d => d.CreatedBy)
                    .WithMany(p => p.Documents)
                    .HasForeignKey(d => d.CreatedById)
                    .OnDelete(DeleteBehavior.ClientSetNull);

                entity.HasOne(d => d.DocumentCategory)
                    .WithMany(p => p.Documents)
                    .HasForeignKey(d => d.DocumentCategoryId)
                    .OnDelete(DeleteBehavior.ClientSetNull);
            });

            modelBuilder.Entity<EmailTemplate>(entity =>
            {
                entity.HasIndex(e => e.TemplateActionTypeId, "IX_TemplateActionType_Id");

                entity.Property(e => e.From).HasMaxLength(255);

                entity.Property(e => e.Subject).HasMaxLength(500);

                entity.Property(e => e.TemplateActionTypeId).HasColumnName("TemplateActionType_Id");

                entity.HasOne(d => d.TemplateActionType)
                    .WithMany(p => p.EmailTemplates)
                    .HasForeignKey(d => d.TemplateActionTypeId)
                    .OnDelete(DeleteBehavior.ClientSetNull);
            });

            modelBuilder.Entity<ExtendData>(entity =>
            {
                entity.HasIndex(e => e.ExtendHeaderId, "IX_ExtendHeaderID");

                entity.Property(e => e.ExtendDataId).HasColumnName("ExtendDataID");

                entity.Property(e => e.ExtendHeaderId).HasColumnName("ExtendHeaderID");

                entity.Property(e => e.ExtendName).HasMaxLength(255);

                entity.Property(e => e.ExtendValue).HasMaxLength(500);

                entity.HasOne(d => d.ExtendHeader)
                    .WithMany(p => p.ExtendData)
                    .HasForeignKey(d => d.ExtendHeaderId)
                    .OnDelete(DeleteBehavior.ClientSetNull);
            });

            modelBuilder.Entity<ExtendHeader>(entity =>
            {
                entity.Property(e => e.ExtendHeaderId).HasColumnName("ExtendHeaderID");

                entity.Property(e => e.App).HasMaxLength(255);

                entity.Property(e => e.Date).HasMaxLength(50);

                entity.Property(e => e.Sequence).HasMaxLength(255);

                entity.Property(e => e.Vendor).HasMaxLength(255);
            });

            modelBuilder.Entity<FavouriteReport>(entity =>
            {
                entity.Property(e => e.MasterReportId).HasColumnName("MasterReport_Id");

                entity.Property(e => e.UserId).HasColumnName("User_Id");

                entity.HasOne(d => d.MasterReport)
                    .WithMany(p => p.FavouriteReports)
                    .HasForeignKey(d => d.MasterReportId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_favouritereport_masterreport");
            });

            modelBuilder.Entity<FileExchangeExportLog>(entity =>
            {
                entity.Property(e => e.SendDate).HasColumnType("datetime");
            });

            modelBuilder.Entity<FirmClientHistoricalData>(entity =>
            {
                entity.Property(e => e.Adjustments).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.Appeal).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.AppealSuccessRate).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.Approved).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.ClientId).HasColumnName("Client_Id");

                entity.Property(e => e.CostShare).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.CreatedById).HasColumnName("CreatedBy_Id");

                entity.Property(e => e.CreatedTime).HasColumnType("datetime");

                entity.Property(e => e.Final).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.Ipscorrection)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("IPSCorrection");

                entity.Property(e => e.LawFirmId).HasColumnName("LawFirm_Id");

                entity.Property(e => e.Net).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.PeriodFrom).HasColumnType("datetime");

                entity.Property(e => e.PeriodTo).HasColumnType("datetime");

                entity.Property(e => e.PostAppealReductionRate).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.Prebilled).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.PromptDiscounts).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.Reduction).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.Uploaded).HasColumnType("decimal(18, 2)");

                entity.HasOne(d => d.Client)
                    .WithMany(p => p.FirmClientHistoricalData)
                    .HasForeignKey(d => d.ClientId)
                    .OnDelete(DeleteBehavior.ClientSetNull);

                entity.HasOne(d => d.LawFirm)
                    .WithMany(p => p.FirmClientHistoricalData)
                    .HasForeignKey(d => d.LawFirmId)
                    .OnDelete(DeleteBehavior.ClientSetNull);
            });

            modelBuilder.Entity<FirmClientHistoricalDataLog>(entity =>
            {
                entity.Property(e => e.ClientId).HasColumnName("Client_Id");

                entity.Property(e => e.LawFirmId).HasColumnName("LawFirm_Id");

                entity.Property(e => e.Narration).IsUnicode(false);

                entity.Property(e => e.TimeStamp).HasColumnType("datetime");

                entity.HasOne(d => d.Client)
                    .WithMany(p => p.FirmClientHistoricalDataLogs)
                    .HasForeignKey(d => d.ClientId)
                    .OnDelete(DeleteBehavior.ClientSetNull);

                entity.HasOne(d => d.LawFirm)
                    .WithMany(p => p.FirmClientHistoricalDataLogs)
                    .HasForeignKey(d => d.LawFirmId)
                    .OnDelete(DeleteBehavior.ClientSetNull);
            });

            modelBuilder.Entity<InjuryTypeCategory>(entity =>
            {
                entity.HasNoKey();

                entity.Property(e => e.CategoryId)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("CategoryID");

                entity.Property(e => e.CategoryName)
                    .HasMaxLength(200)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<InjuryTypeCategoryRelation>(entity =>
            {
                entity.HasNoKey();

                entity.Property(e => e.CategoryId).HasColumnName("CategoryID");

                entity.Property(e => e.Id).ValueGeneratedOnAdd();

                entity.Property(e => e.SubCategoryId).HasColumnName("SubCategoryID");
            });

            modelBuilder.Entity<InjuryTypeSubCategory>(entity =>
            {
                entity.HasNoKey();

                entity.Property(e => e.SubCategoryId)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("SubCategoryID");

                entity.Property(e => e.SubCategoryName)
                    .HasMaxLength(200)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<InvPrepInvoice>(entity =>
            {
                entity.Property(e => e.BilledDate).HasColumnType("datetime");

                entity.Property(e => e.CreatedById).HasColumnName("CreatedBy_Id");

                entity.Property(e => e.FeesOnExpense).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.FeesOnFees).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.InvPrepInvoiceNumber).IsRequired();

                entity.Property(e => e.InvoiceMonth).HasColumnType("datetime");

                entity.Property(e => e.LawFirmId).HasColumnName("LawFirm_Id");

                entity.Property(e => e.TaxAmount).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.TaxRate).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.TotalFees).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.TotalInvoiceValue).HasColumnType("decimal(18, 2)");

                entity.HasOne(d => d.CreatedBy)
                    .WithMany(p => p.InvPrepInvoices)
                    .HasForeignKey(d => d.CreatedById)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_InvPrepInvoices_Users");

                entity.HasOne(d => d.LawFirm)
                    .WithMany(p => p.InvPrepInvoices)
                    .HasForeignKey(d => d.LawFirmId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__InvPrepIn__LawFi__6F7F8B4B");
            });

            modelBuilder.Entity<InvPrepInvoiceLine>(entity =>
            {
                entity.Property(e => e.Description).HasMaxLength(2000);

                entity.Property(e => e.Fees).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.InvPrepInvoiceId).HasColumnName("InvPrepInvoice_Id");

                entity.Property(e => e.Rate).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.TotalInvoiceValue).HasColumnType("decimal(18, 2)");

                entity.HasOne(d => d.InvPrepInvoice)
                    .WithMany(p => p.InvPrepInvoiceLines)
                    .HasForeignKey(d => d.InvPrepInvoiceId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__InvPrepIn__InvPr__74444068");
            });

            modelBuilder.Entity<Invoice>(entity =>
            {
                entity.HasIndex(e => e.AssignedToUserId, "IX_AssignedToUser_Id");

                entity.HasIndex(e => e.ExportedDate, "IX_ExportedDate");

                entity.HasIndex(e => e.InvoiceClientId, "IX_InvoiceClient_Id");

                entity.HasIndex(e => e.InvoiceCode, "IX_InvoiceCode");

                entity.HasIndex(e => e.InvoiceDate, "IX_InvoiceDate");

                entity.HasIndex(e => e.InvoiceStatusId, "IX_InvoiceStatusId");

                entity.HasIndex(e => e.EbillerStatus, "IX_Invoices_EBillerStatus");

                entity.HasIndex(e => e.EbillerStatusChangeDate, "IX_Invoices_EBillerStatusChangeDate");

                entity.HasIndex(e => e.EbillerStatusCheckDate, "IX_Invoices_EBillerStatusCheckDate");

                entity.HasIndex(e => new { e.InvoiceStatusId, e.AppealStatus }, "IX_Invoices_InvoiceStatusId_InvoiceAppealStatusId");

                entity.HasIndex(e => e.IsLineLevelPayerReductionDataProcessed, "IX_Invoices_NumberOfPayerReductions");

                entity.HasIndex(e => e.PaidDate, "IX_PaidDate");

                entity.HasIndex(e => e.PreparedDate, "IX_PreparedDate");

                entity.HasIndex(e => e.UploadedDate, "IX_UploadedDate");

                entity.HasIndex(e => e.WfstatusChangeDate, "IX_WFStatusChangeDate");

                entity.HasIndex(e => e.WorkFlowOwnerId, "IX_WorkFlowOwner_Id");

                entity.Property(e => e.AppealCreditReceivedAmount).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.AppealCreditReceivedDate).HasColumnType("datetime");

                entity.Property(e => e.AppealDeadlineDate).HasColumnType("datetime");

                entity.Property(e => e.AppealDescription).HasMaxLength(2000);

                entity.Property(e => e.AppealResponseAmount).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.AppealResponseDate).HasColumnType("datetime");

                entity.Property(e => e.AppealResponseDescription).HasMaxLength(2000);

                entity.Property(e => e.AppealResponseExpenses).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.AppealResponseFees).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.AppealStatusComments)
                    .HasMaxLength(2000)
                    .IsUnicode(false);

                entity.Property(e => e.AppealedAmount).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.AppealedDate).HasColumnType("datetime");

                entity.Property(e => e.AppealedExpenses).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.AppealedFees).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.ApprovedById).HasColumnName("ApprovedBy_Id");

                entity.Property(e => e.ApproverComment)
                    .HasMaxLength(4000)
                    .IsUnicode(false);

                entity.Property(e => e.AssignedToUserId).HasColumnName("AssignedToUser_Id");

                entity.Property(e => e.BillToClientAddressAddress1)
                    .HasMaxLength(100)
                    .HasColumnName("BillToClientAddress_Address1");

                entity.Property(e => e.BillToClientAddressAddress2)
                    .HasMaxLength(100)
                    .HasColumnName("BillToClientAddress_Address2");

                entity.Property(e => e.BillToClientAddressAddress3)
                    .HasMaxLength(100)
                    .HasColumnName("BillToClientAddress_Address3");

                entity.Property(e => e.BillToClientAddressCity)
                    .HasMaxLength(100)
                    .HasColumnName("BillToClientAddress_City");

                entity.Property(e => e.BillToClientAddressCountry)
                    .HasMaxLength(100)
                    .HasColumnName("BillToClientAddress_Country");

                entity.Property(e => e.BillToClientAddressFax)
                    .HasMaxLength(20)
                    .HasColumnName("BillToClientAddress_Fax");

                entity.Property(e => e.BillToClientAddressPhone)
                    .HasMaxLength(20)
                    .HasColumnName("BillToClientAddress_Phone");

                entity.Property(e => e.BillToClientAddressStateProvince)
                    .HasMaxLength(100)
                    .HasColumnName("BillToClientAddress_StateProvince");

                entity.Property(e => e.BillToClientAddressZipPostalCode)
                    .HasMaxLength(100)
                    .HasColumnName("BillToClientAddress_ZipPostalCode");

                entity.Property(e => e.BillToClientName).HasMaxLength(255);

                entity.Property(e => e.BillToClientTaxId).HasMaxLength(100);

                entity.Property(e => e.BillType)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.ClientApprovedDate).HasColumnType("datetime");

                entity.Property(e => e.ClientApproverComment)
                    .HasMaxLength(4000)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedById).HasColumnName("CreatedBy_Id");

                entity.Property(e => e.CurrentApprovalRuleId).HasColumnName("CurrentApprovalRule_Id");

                entity.Property(e => e.DeductedExpenseByPayer).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.DeductedFeesByPayer).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.Description).HasMaxLength(4000);

                entity.Property(e => e.DescriptionModified).HasMaxLength(4000);

                entity.Property(e => e.EbillerCostshareAdjustments).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.EbillerGuidelineAdjustments).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.EbillerOriginalBilledAmount).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.EbillerOriginalBilledExpenses).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.EbillerOriginalBilledFees).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.EbillerOtherDiscountDescription)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.EbillerOtherDiscounts).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.EbillerProcessingFees).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.EbillerPromptPayDiscounts).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.EbillerReference1)
                    .HasMaxLength(100)
                    .HasColumnName("EBillerReference1");

                entity.Property(e => e.EbillerReference2)
                    .HasMaxLength(100)
                    .HasColumnName("EBillerReference2");

                entity.Property(e => e.EbillerStatus)
                    .HasMaxLength(200)
                    .HasColumnName("EBillerStatus");

                entity.Property(e => e.EbillerStatusChangeDate)
                    .HasColumnType("datetime")
                    .HasColumnName("EBillerStatusChangeDate");

                entity.Property(e => e.EbillerStatusCheckDate)
                    .HasColumnType("datetime")
                    .HasColumnName("EBillerStatusCheckDate");

                entity.Property(e => e.EbillerStatusComments)
                    .HasMaxLength(2000)
                    .HasColumnName("EBillerStatusComments");

                entity.Property(e => e.EbillerToPayAmount).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.EndDate).HasColumnType("datetime");

                entity.Property(e => e.ExportedById).HasColumnName("ExportedBy_Id");

                entity.Property(e => e.ExportedDate).HasColumnType("datetime");

                entity.Property(e => e.FinalPaidAmount).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.FinalPaidAmountWithDisc).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.FinalPaidExpenses).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.FinalPaidFees).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.FinalPaymentReceivedAmount).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.FirstApproverComment)
                    .HasMaxLength(4000)
                    .IsUnicode(false);

                entity.Property(e => e.ImageFileName).HasMaxLength(255);

                entity.Property(e => e.InitialPaymentReceivedAmount).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.InvoiceClientId).HasColumnName("InvoiceClient_Id");

                entity.Property(e => e.InvoiceCode).HasMaxLength(100);

                entity.Property(e => e.InvoiceCurrency).HasMaxLength(20);

                entity.Property(e => e.InvoiceDate).HasColumnType("datetime");

                entity.Property(e => e.InvoiceDueDate).HasMaxLength(20);

                entity.Property(e => e.InvoiceOtherCurrency).HasMaxLength(20);

                entity.Property(e => e.InvoiceTotal).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.InvoiceTotalModified).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.IsThisAcreditNote).HasColumnName("IsThisACreditNote");

                entity.Property(e => e.IsThisAtaxInvoice).HasColumnName("IsThisATaxInvoice");

                entity.Property(e => e.NetTotal).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.NetTotalModified).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.OfflineApproverEmail)
                    .HasMaxLength(255)
                    .HasColumnName("OfflineApprover_Email");

                entity.Property(e => e.PaidDate).HasColumnType("datetime");

                entity.Property(e => e.PaidExpenseWithCostShare).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.PaidExpenseWithDisc).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.PaidFeesWithCostShare).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.PaidFeesWithDisc).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.PaidTotalByPayer).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.PaidTotalWithCostShare).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.PayableByClientAddressAddress1)
                    .HasMaxLength(100)
                    .HasColumnName("PayableByClientAddress_Address1");

                entity.Property(e => e.PayableByClientAddressAddress2)
                    .HasMaxLength(100)
                    .HasColumnName("PayableByClientAddress_Address2");

                entity.Property(e => e.PayableByClientAddressAddress3)
                    .HasMaxLength(100)
                    .HasColumnName("PayableByClientAddress_Address3");

                entity.Property(e => e.PayableByClientAddressCity)
                    .HasMaxLength(100)
                    .HasColumnName("PayableByClientAddress_City");

                entity.Property(e => e.PayableByClientAddressCountry)
                    .HasMaxLength(100)
                    .HasColumnName("PayableByClientAddress_Country");

                entity.Property(e => e.PayableByClientAddressFax)
                    .HasMaxLength(20)
                    .HasColumnName("PayableByClientAddress_Fax");

                entity.Property(e => e.PayableByClientAddressPhone)
                    .HasMaxLength(20)
                    .HasColumnName("PayableByClientAddress_Phone");

                entity.Property(e => e.PayableByClientAddressStateProvince)
                    .HasMaxLength(100)
                    .HasColumnName("PayableByClientAddress_StateProvince");

                entity.Property(e => e.PayableByClientAddressZipPostalCode)
                    .HasMaxLength(100)
                    .HasColumnName("PayableByClientAddress_ZipPostalCode");

                entity.Property(e => e.PayableByClientName).HasMaxLength(255);

                entity.Property(e => e.PayableByClientTaxId).HasMaxLength(100);

                entity.Property(e => e.PaymentRecievedDate).HasColumnType("datetime");

                entity.Property(e => e.PaymentTerms).HasMaxLength(255);

                entity.Property(e => e.PreparationEndTime).HasColumnType("datetime");

                entity.Property(e => e.PreparationStartTime).HasColumnType("datetime");

                entity.Property(e => e.PreparedByUserId).HasColumnName("PreparedByUser_Id");

                entity.Property(e => e.PreparedDate).HasColumnType("datetime");

                entity.Property(e => e.PreviousWorkFlowOwnerId).HasColumnName("PreviousWorkFlowOwner_Id");

                entity.Property(e => e.ProcessedByWhichRuleSystem).HasMaxLength(10);

                entity.Property(e => e.PromptDiscExpensePercen).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.PromptDiscFeesPercen).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.ReceivedDate).HasColumnType("datetime");

                entity.Property(e => e.ReferenceInvoice).HasMaxLength(100);

                entity.Property(e => e.RejectReason)
                    .HasMaxLength(2000)
                    .IsUnicode(false);

                entity.Property(e => e.RuleCode).HasMaxLength(255);

                entity.Property(e => e.RuleId).HasColumnName("Rule_Id");

                entity.Property(e => e.RulesetApplied).HasMaxLength(200);

                entity.Property(e => e.SecondApproverComment)
                    .HasMaxLength(4000)
                    .IsUnicode(false);

                entity.Property(e => e.SendForClientApprovalDate).HasColumnType("datetime");

                entity.Property(e => e.StartDate).HasColumnType("datetime");

                entity.Property(e => e.SubmittedToPayerDate).HasColumnType("datetime");

                entity.Property(e => e.Tag).HasMaxLength(255);

                entity.Property(e => e.TaxInvoiceClientAddressAddress1)
                    .HasMaxLength(100)
                    .HasColumnName("TaxInvoiceClientAddress_Address1");

                entity.Property(e => e.TaxInvoiceClientAddressAddress2)
                    .HasMaxLength(100)
                    .HasColumnName("TaxInvoiceClientAddress_Address2");

                entity.Property(e => e.TaxInvoiceClientAddressAddress3)
                    .HasMaxLength(100)
                    .HasColumnName("TaxInvoiceClientAddress_Address3");

                entity.Property(e => e.TaxInvoiceClientAddressCity)
                    .HasMaxLength(100)
                    .HasColumnName("TaxInvoiceClientAddress_City");

                entity.Property(e => e.TaxInvoiceClientAddressCountry)
                    .HasMaxLength(100)
                    .HasColumnName("TaxInvoiceClientAddress_Country");

                entity.Property(e => e.TaxInvoiceClientAddressFax)
                    .HasMaxLength(20)
                    .HasColumnName("TaxInvoiceClientAddress_Fax");

                entity.Property(e => e.TaxInvoiceClientAddressPhone)
                    .HasMaxLength(20)
                    .HasColumnName("TaxInvoiceClientAddress_Phone");

                entity.Property(e => e.TaxInvoiceClientAddressStateProvince)
                    .HasMaxLength(100)
                    .HasColumnName("TaxInvoiceClientAddress_StateProvince");

                entity.Property(e => e.TaxInvoiceClientAddressZipPostalCode)
                    .HasMaxLength(100)
                    .HasColumnName("TaxInvoiceClientAddress_ZipPostalCode");

                entity.Property(e => e.TaxInvoiceClientName).HasMaxLength(255);

                entity.Property(e => e.TaxInvoiceClientTaxId).HasMaxLength(100);

                entity.Property(e => e.TaxPointDate).HasColumnType("datetime");

                entity.Property(e => e.ThirdApproverComment)
                    .HasMaxLength(4000)
                    .IsUnicode(false);

                entity.Property(e => e.TotalDiscCred).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.TotalDiscCredModified).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.TotalDue).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.TotalDueModified).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.TotalDueOther).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.TotalDueOtherModified).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.TotalExpense).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.TotalExpenseModified).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.TotalFee).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.TotalFeeModified).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.TotalTax).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.TotalTaxModified).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.TotalTaxOther).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.TotalTaxOtherModified).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.UploadedDate).HasColumnType("datetime");

                entity.Property(e => e.WfstatusChangeDate)
                    .HasColumnType("datetime")
                    .HasColumnName("WFStatusChangeDate");

                entity.Property(e => e.WorkFlowOwnerId).HasColumnName("WorkFlowOwner_Id");

                entity.Property(e => e.WriteOffReceivedAmount).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.WriteOffReceivedDate).HasColumnType("datetime");

                entity.HasOne(d => d.ApprovedBy)
                    .WithMany(p => p.InvoiceApprovedBies)
                    .HasForeignKey(d => d.ApprovedById)
                    .HasConstraintName("FK_Invoices_ApprovingUser");

                entity.HasOne(d => d.AssignedToUser)
                    .WithMany(p => p.InvoiceAssignedToUsers)
                    .HasForeignKey(d => d.AssignedToUserId);

                entity.HasOne(d => d.CreatedBy)
                    .WithMany(p => p.InvoiceCreatedBies)
                    .HasForeignKey(d => d.CreatedById);

                entity.HasOne(d => d.ExportedBy)
                    .WithMany(p => p.InvoiceExportedBies)
                    .HasForeignKey(d => d.ExportedById)
                    .HasConstraintName("FK_Invoices_ExportingUser");

                entity.HasOne(d => d.InvoiceClient)
                    .WithMany(p => p.Invoices)
                    .HasForeignKey(d => d.InvoiceClientId)
                    .OnDelete(DeleteBehavior.ClientSetNull);

                entity.HasOne(d => d.PreparedByUser)
                    .WithMany(p => p.InvoicePreparedByUsers)
                    .HasForeignKey(d => d.PreparedByUserId)
                    .HasConstraintName("FK__Invoices__Prepar__075714DC");

                entity.HasOne(d => d.Rule)
                    .WithMany(p => p.Invoices)
                    .HasForeignKey(d => d.RuleId)
                    .HasConstraintName("FK__Invoices__Rule_I__4F12BBB9");

                entity.HasOne(d => d.WorkFlowOwner)
                    .WithMany(p => p.InvoiceWorkFlowOwners)
                    .HasForeignKey(d => d.WorkFlowOwnerId)
                    .HasConstraintName("FK_Invoices_WFOwner");
            });

            modelBuilder.Entity<InvoiceAppliedRule>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.InvoiceId).HasColumnName("Invoice_ID");

                entity.Property(e => e.LineItemId).HasColumnName("LineItem_ID");

                entity.Property(e => e.RuleCode)
                    .HasMaxLength(20)
                    .HasColumnName("Rule_Code");

                entity.Property(e => e.RuleId).HasColumnName("Rule_Id");
            });

            modelBuilder.Entity<InvoiceClient>(entity =>
            {
                entity.HasIndex(e => e.ClientId, "IX_Client_Id");

                entity.HasIndex(e => e.InvoiceFirmId, "IX_InvoiceFirm_Id");

                entity.Property(e => e.AddressAddress1)
                    .HasMaxLength(100)
                    .HasColumnName("Address_Address1");

                entity.Property(e => e.AddressAddress2)
                    .HasMaxLength(100)
                    .HasColumnName("Address_Address2");

                entity.Property(e => e.AddressAddress3)
                    .HasMaxLength(100)
                    .HasColumnName("Address_Address3");

                entity.Property(e => e.AddressCity)
                    .HasMaxLength(100)
                    .HasColumnName("Address_City");

                entity.Property(e => e.AddressCountry)
                    .HasMaxLength(100)
                    .HasColumnName("Address_Country");

                entity.Property(e => e.AddressFax)
                    .HasMaxLength(20)
                    .HasColumnName("Address_Fax");

                entity.Property(e => e.AddressPhone)
                    .HasMaxLength(20)
                    .HasColumnName("Address_Phone");

                entity.Property(e => e.AddressStateProvince)
                    .HasMaxLength(100)
                    .HasColumnName("Address_StateProvince");

                entity.Property(e => e.AddressZipPostalCode)
                    .HasMaxLength(100)
                    .HasColumnName("Address_ZipPostalCode");

                entity.Property(e => e.ClientCode).HasMaxLength(100);

                entity.Property(e => e.ClientCodeModified).HasMaxLength(100);

                entity.Property(e => e.ClientId).HasColumnName("Client_Id");

                entity.Property(e => e.ContactContactCode)
                    .HasMaxLength(100)
                    .HasColumnName("Contact_ContactCode");

                entity.Property(e => e.ContactEmail)
                    .HasMaxLength(255)
                    .HasColumnName("Contact_Email");

                entity.Property(e => e.ContactFax)
                    .HasMaxLength(20)
                    .HasColumnName("Contact_Fax");

                entity.Property(e => e.ContactFirstName)
                    .HasMaxLength(100)
                    .HasColumnName("Contact_FirstName");

                entity.Property(e => e.ContactLastName)
                    .HasMaxLength(100)
                    .HasColumnName("Contact_LastName");

                entity.Property(e => e.ContactPhone)
                    .HasMaxLength(20)
                    .HasColumnName("Contact_Phone");

                entity.Property(e => e.InvoiceFirmId).HasColumnName("InvoiceFirm_Id");

                entity.Property(e => e.LawFirmCode).HasMaxLength(100);

                entity.Property(e => e.Name).HasMaxLength(255);

                entity.Property(e => e.TaxId).HasMaxLength(20);

                entity.HasOne(d => d.Client)
                    .WithMany(p => p.InvoiceClients)
                    .HasForeignKey(d => d.ClientId);

                entity.HasOne(d => d.InvoiceFirm)
                    .WithMany(p => p.InvoiceClients)
                    .HasForeignKey(d => d.InvoiceFirmId)
                    .OnDelete(DeleteBehavior.ClientSetNull);
            });

            modelBuilder.Entity<InvoiceDocument>(entity =>
            {
                entity.HasIndex(e => e.DocumentId, "IX_Document_Id");

                entity.HasIndex(e => e.InvoiceId, "IX_Invoice_Id");

                entity.Property(e => e.DocumentId).HasColumnName("Document_Id");

                entity.Property(e => e.InvoiceId).HasColumnName("Invoice_Id");

                entity.HasOne(d => d.Document)
                    .WithMany(p => p.InvoiceDocuments)
                    .HasForeignKey(d => d.DocumentId)
                    .OnDelete(DeleteBehavior.ClientSetNull);

                entity.HasOne(d => d.Invoice)
                    .WithMany(p => p.InvoiceDocuments)
                    .HasForeignKey(d => d.InvoiceId)
                    .OnDelete(DeleteBehavior.ClientSetNull);
            });

            modelBuilder.Entity<InvoiceFile>(entity =>
            {
                entity.Property(e => e.CreatedTime).HasColumnType("datetime");

                entity.Property(e => e.InvoiceFileType)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ModifiedTime).HasColumnType("datetime");
            });

            modelBuilder.Entity<InvoiceFirm>(entity =>
            {
                entity.HasIndex(e => e.InvoiceFileId, "IX_InvoiceFile_Id");

                entity.HasIndex(e => e.LawFirmId, "IX_LawFirm_Id");

                entity.Property(e => e.AppVersion).HasMaxLength(100);

                entity.Property(e => e.InvoiceFileId).HasColumnName("InvoiceFile_Id");

                entity.Property(e => e.LawFirmAddressAddress1)
                    .HasMaxLength(100)
                    .HasColumnName("LawFirmAddress_Address1");

                entity.Property(e => e.LawFirmAddressAddress2)
                    .HasMaxLength(100)
                    .HasColumnName("LawFirmAddress_Address2");

                entity.Property(e => e.LawFirmAddressAddress3)
                    .HasMaxLength(100)
                    .HasColumnName("LawFirmAddress_Address3");

                entity.Property(e => e.LawFirmAddressCity)
                    .HasMaxLength(100)
                    .HasColumnName("LawFirmAddress_City");

                entity.Property(e => e.LawFirmAddressCountry)
                    .HasMaxLength(100)
                    .HasColumnName("LawFirmAddress_Country");

                entity.Property(e => e.LawFirmAddressFax)
                    .HasMaxLength(20)
                    .HasColumnName("LawFirmAddress_Fax");

                entity.Property(e => e.LawFirmAddressPhone)
                    .HasMaxLength(20)
                    .HasColumnName("LawFirmAddress_Phone");

                entity.Property(e => e.LawFirmAddressStateProvince)
                    .HasMaxLength(100)
                    .HasColumnName("LawFirmAddress_StateProvince");

                entity.Property(e => e.LawFirmAddressZipPostalCode)
                    .HasMaxLength(100)
                    .HasColumnName("LawFirmAddress_ZipPostalCode");

                entity.Property(e => e.LawFirmContactContactCode)
                    .HasMaxLength(100)
                    .HasColumnName("LawFirmContact_ContactCode");

                entity.Property(e => e.LawFirmContactEmail)
                    .HasMaxLength(255)
                    .HasColumnName("LawFirmContact_Email");

                entity.Property(e => e.LawFirmContactFax)
                    .HasMaxLength(20)
                    .HasColumnName("LawFirmContact_Fax");

                entity.Property(e => e.LawFirmContactFirstName)
                    .HasMaxLength(100)
                    .HasColumnName("LawFirmContact_FirstName");

                entity.Property(e => e.LawFirmContactLastName)
                    .HasMaxLength(100)
                    .HasColumnName("LawFirmContact_LastName");

                entity.Property(e => e.LawFirmContactPhone)
                    .HasMaxLength(20)
                    .HasColumnName("LawFirmContact_Phone");

                entity.Property(e => e.LawFirmId).HasColumnName("LawFirm_Id");

                entity.Property(e => e.LawFirmId1)
                    .HasMaxLength(100)
                    .HasColumnName("LawFirmId");

                entity.Property(e => e.LawFirmName).HasMaxLength(255);

                entity.Property(e => e.LawFirmRemittanceAddressAddress1)
                    .HasMaxLength(100)
                    .HasColumnName("LawFirmRemittanceAddress_Address1");

                entity.Property(e => e.LawFirmRemittanceAddressAddress2)
                    .HasMaxLength(100)
                    .HasColumnName("LawFirmRemittanceAddress_Address2");

                entity.Property(e => e.LawFirmRemittanceAddressAddress3)
                    .HasMaxLength(100)
                    .HasColumnName("LawFirmRemittanceAddress_Address3");

                entity.Property(e => e.LawFirmRemittanceAddressCity)
                    .HasMaxLength(100)
                    .HasColumnName("LawFirmRemittanceAddress_City");

                entity.Property(e => e.LawFirmRemittanceAddressCountry)
                    .HasMaxLength(100)
                    .HasColumnName("LawFirmRemittanceAddress_Country");

                entity.Property(e => e.LawFirmRemittanceAddressFax)
                    .HasMaxLength(20)
                    .HasColumnName("LawFirmRemittanceAddress_Fax");

                entity.Property(e => e.LawFirmRemittanceAddressPhone)
                    .HasMaxLength(20)
                    .HasColumnName("LawFirmRemittanceAddress_Phone");

                entity.Property(e => e.LawFirmRemittanceAddressStateProvince)
                    .HasMaxLength(100)
                    .HasColumnName("LawFirmRemittanceAddress_StateProvince");

                entity.Property(e => e.LawFirmRemittanceAddressZipPostalCode)
                    .HasMaxLength(100)
                    .HasColumnName("LawFirmRemittanceAddress_ZipPostalCode");

                entity.Property(e => e.SourceApp).HasMaxLength(100);

                entity.Property(e => e.Url)
                    .HasMaxLength(100)
                    .HasColumnName("URL");

                entity.Property(e => e.VendorUniqueId).HasMaxLength(100);

                entity.HasOne(d => d.InvoiceFile)
                    .WithMany(p => p.InvoiceFirms)
                    .HasForeignKey(d => d.InvoiceFileId)
                    .OnDelete(DeleteBehavior.ClientSetNull);

                entity.HasOne(d => d.LawFirm)
                    .WithMany(p => p.InvoiceFirms)
                    .HasForeignKey(d => d.LawFirmId)
                    .OnDelete(DeleteBehavior.ClientSetNull);
            });

            modelBuilder.Entity<InvoiceLineItem>(entity =>
            {
                entity.HasIndex(e => e.ExtendHeaderModifiedExtendHeaderId, "IX_ExtendHeaderModified_ExtendHeaderID");

                entity.HasIndex(e => e.ExtendHeaderExtendHeaderId, "IX_ExtendHeader_ExtendHeaderID");

                entity.HasIndex(e => e.NumberOfPayerReductions, "IX_InvoiceLineItems_NumberOfPayerReductions");

                entity.HasIndex(e => e.InvoiceMatterId, "IX_InvoiceMatter_Id");

                entity.HasIndex(e => e.InvoiceMatterId1, "IX_InvoiceMatter_Id1");

                entity.HasIndex(e => e.InvoiceMatterId2, "IX_InvoiceMatter_Id2");

                entity.HasIndex(e => e.InvoiceMatterId3, "IX_InvoiceMatter_Id3");

                entity.HasIndex(e => e.RuleId, "IX_RuleCategoryID");

                entity.HasIndex(e => e.RuleCategoryId, "IX_RuleCategoryID_New");

                entity.HasIndex(e => e.TimekeeperId, "IX_Timekeeper_Id");

                entity.HasIndex(e => e.PayerReductionReason, "NonClusteredIndex-PayerReductionReason");

                entity.Property(e => e.AgreedRate).HasColumnType("decimal(18, 0)");

                entity.Property(e => e.AmountReducedByPayer).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.BaseAmount).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.BaseAmountModified).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.ChargeDate).HasColumnType("datetime");

                entity.Property(e => e.ChargeDateModified).HasColumnType("datetime");

                entity.Property(e => e.ChargeDesciption).HasMaxLength(4000);

                entity.Property(e => e.ChargeDesciptionModified).HasMaxLength(4000);

                entity.Property(e => e.ChargeType)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength(true);

                entity.Property(e => e.ChargeTypeModified)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength(true);

                entity.Property(e => e.CommunicationModifiedDate).HasColumnType("datetime");

                entity.Property(e => e.DiscountPercentage).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.DiscountTypeNote).HasMaxLength(500);

                entity.Property(e => e.Discriminator)
                    .IsRequired()
                    .HasMaxLength(128);

                entity.Property(e => e.ExtendHeaderExtendHeaderId).HasColumnName("ExtendHeader_ExtendHeaderID");

                entity.Property(e => e.ExtendHeaderModifiedExtendHeaderId).HasColumnName("ExtendHeaderModified_ExtendHeaderID");

                entity.Property(e => e.InvoiceMatterId).HasColumnName("InvoiceMatter_Id");

                entity.Property(e => e.InvoiceMatterId1).HasColumnName("InvoiceMatter_Id1");

                entity.Property(e => e.InvoiceMatterId2).HasColumnName("InvoiceMatter_Id2");

                entity.Property(e => e.InvoiceMatterId3).HasColumnName("InvoiceMatter_Id3");

                entity.Property(e => e.ItemDiscountOrCreditAmount).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.ItemDiscountOrCreditAmountModified).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.LineItemTimekeeperId)
                    .HasMaxLength(50)
                    .HasColumnName("LineItemTimekeeperID");

                entity.Property(e => e.LineItemTimekeeperIdmodified)
                    .HasMaxLength(50)
                    .HasColumnName("LineItemTimekeeperIDModified");

                entity.Property(e => e.PayeeName).HasMaxLength(255);

                entity.Property(e => e.PayerReductionNarration)
                    .HasMaxLength(5000)
                    .IsUnicode(false);

                entity.Property(e => e.PayerReductionReason).HasMaxLength(1000);

                entity.Property(e => e.PhaseCode).HasMaxLength(200);

                entity.Property(e => e.PreperationNote).HasMaxLength(1000);

                entity.Property(e => e.Rate).HasColumnType("decimal(18, 4)");

                entity.Property(e => e.RateModified).HasColumnType("decimal(18, 4)");

                entity.Property(e => e.RateReducedByPayer).HasColumnType("decimal(18, 4)");

                entity.Property(e => e.RuleCategoryId).HasColumnName("RuleCategory_Id");

                entity.Property(e => e.RuleCode).HasMaxLength(500);

                entity.Property(e => e.RuleId).HasColumnName("Rule_Id");

                entity.Property(e => e.RuleNote).HasMaxLength(1000);

                entity.Property(e => e.Tag).HasMaxLength(1000);

                entity.Property(e => e.TaskActivityCode).HasMaxLength(100);

                entity.Property(e => e.TaskActivityCodeModified).HasMaxLength(100);

                entity.Property(e => e.TaskCode).HasMaxLength(100);

                entity.Property(e => e.TaskCodeModified).HasMaxLength(100);

                entity.Property(e => e.TaskExpenseCode).HasMaxLength(100);

                entity.Property(e => e.TaskExpenseCodeModified).HasMaxLength(100);

                entity.Property(e => e.TaxTotal).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.TaxTotalModified).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.TimeKeeperName).HasMaxLength(200);

                entity.Property(e => e.TimeKeeperNameModified).HasMaxLength(200);

                entity.Property(e => e.TimekeeperFirstName).HasMaxLength(100);

                entity.Property(e => e.TimekeeperFirstNameModified).HasMaxLength(100);

                entity.Property(e => e.TimekeeperId).HasColumnName("Timekeeper_Id");

                entity.Property(e => e.TimekeeperLastName).HasMaxLength(100);

                entity.Property(e => e.TimekeeperLastNameModified).HasMaxLength(100);

                entity.Property(e => e.TotalAmount).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.TotalAmountModified).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.UnAccountedAdjustments).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.Units).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.UnitsModified).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.UnitsReducedByPayer).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.WorkLocationCountryCode).HasMaxLength(100);

                entity.Property(e => e.WorkLocationCountryCodeModified).HasMaxLength(100);

                entity.Property(e => e.WorkLocationLocality).HasMaxLength(100);

                entity.Property(e => e.WorkLocationLocalityModified).HasMaxLength(100);

                entity.HasOne(d => d.ExtendHeaderExtendHeader)
                    .WithMany(p => p.InvoiceLineItemExtendHeaderExtendHeaders)
                    .HasForeignKey(d => d.ExtendHeaderExtendHeaderId);

                entity.HasOne(d => d.ExtendHeaderModifiedExtendHeader)
                    .WithMany(p => p.InvoiceLineItemExtendHeaderModifiedExtendHeaders)
                    .HasForeignKey(d => d.ExtendHeaderModifiedExtendHeaderId);

                entity.HasOne(d => d.InvoiceMatter)
                    .WithMany(p => p.InvoiceLineItemInvoiceMatters)
                    .HasForeignKey(d => d.InvoiceMatterId)
                    .OnDelete(DeleteBehavior.ClientSetNull);

                entity.HasOne(d => d.InvoiceMatterId1Navigation)
                    .WithMany(p => p.InvoiceLineItemInvoiceMatterId1Navigations)
                    .HasForeignKey(d => d.InvoiceMatterId1);

                entity.HasOne(d => d.InvoiceMatterId2Navigation)
                    .WithMany(p => p.InvoiceLineItemInvoiceMatterId2Navigations)
                    .HasForeignKey(d => d.InvoiceMatterId2);

                entity.HasOne(d => d.InvoiceMatterId3Navigation)
                    .WithMany(p => p.InvoiceLineItemInvoiceMatterId3Navigations)
                    .HasForeignKey(d => d.InvoiceMatterId3);

                entity.HasOne(d => d.RuleCategory)
                    .WithMany(p => p.InvoiceLineItems)
                    .HasForeignKey(d => d.RuleCategoryId)
                    .HasConstraintName("FK_InvoiceLineItems_RuleCategories");

                entity.HasOne(d => d.Rule)
                    .WithMany(p => p.InvoiceLineItems)
                    .HasForeignKey(d => d.RuleId)
                    .HasConstraintName("FK__InvoiceLi__Rule___4E1E9780");

                entity.HasOne(d => d.Timekeeper)
                    .WithMany(p => p.InvoiceLineItems)
                    .HasForeignKey(d => d.TimekeeperId);
            });

            modelBuilder.Entity<InvoiceLineItemDiscCred>(entity =>
            {
                entity.Property(e => e.DiscCredAmount).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.DiscCredNote).HasMaxLength(500);

                entity.Property(e => e.InvoiceExpenseLineItemId).HasColumnName("InvoiceExpenseLineItem_Id");

                entity.Property(e => e.InvoiceFeeLineItemId).HasColumnName("InvoiceFeeLineItem_Id");

                entity.Property(e => e.InvoiceLineItemId).HasColumnName("InvoiceLineItem_Id");

                entity.Property(e => e.Percentage).HasColumnType("decimal(18, 2)");

                entity.HasOne(d => d.InvoiceExpenseLineItem)
                    .WithMany(p => p.InvoiceLineItemDiscCredInvoiceExpenseLineItems)
                    .HasForeignKey(d => d.InvoiceExpenseLineItemId);

                entity.HasOne(d => d.InvoiceFeeLineItem)
                    .WithMany(p => p.InvoiceLineItemDiscCredInvoiceFeeLineItems)
                    .HasForeignKey(d => d.InvoiceFeeLineItemId);

                entity.HasOne(d => d.InvoiceLineItem)
                    .WithMany(p => p.InvoiceLineItemDiscCredInvoiceLineItems)
                    .HasForeignKey(d => d.InvoiceLineItemId)
                    .OnDelete(DeleteBehavior.ClientSetNull);
            });

            modelBuilder.Entity<InvoiceLog>(entity =>
            {
                entity.HasNoKey();

                entity.HasIndex(e => e.InvoiceId, "IX_Invoice_ID");

                entity.Property(e => e.Id).ValueGeneratedOnAdd();

                entity.Property(e => e.InvoiceId).HasColumnName("Invoice_Id");

                entity.Property(e => e.Narration).HasMaxLength(1000);

                entity.Property(e => e.TimeStamp).HasColumnType("datetime");

                entity.Property(e => e.UserId).HasColumnName("User_Id");

                entity.HasOne(d => d.Invoice)
                    .WithMany()
                    .HasForeignKey(d => d.InvoiceId)
                    .HasConstraintName("FK_InvoiceLogs_Invoices");

                entity.HasOne(d => d.User)
                    .WithMany()
                    .HasForeignKey(d => d.UserId)
                    .HasConstraintName("FK_InvoiceLogs_Users");
            });

            modelBuilder.Entity<InvoiceMatter>(entity =>
            {
                entity.HasIndex(e => e.InvoiceId, "IX_Invoice_Id");

                entity.HasIndex(e => e.MatterId, "IX_Matter_Id");

                entity.Property(e => e.AccountType).HasMaxLength(100);

                entity.Property(e => e.AddlReferenceNo).HasMaxLength(100);

                entity.Property(e => e.ClientContactContactCode)
                    .HasMaxLength(100)
                    .HasColumnName("ClientContact_ContactCode");

                entity.Property(e => e.ClientContactEmail)
                    .HasMaxLength(255)
                    .HasColumnName("ClientContact_Email");

                entity.Property(e => e.ClientContactFax)
                    .HasMaxLength(20)
                    .HasColumnName("ClientContact_Fax");

                entity.Property(e => e.ClientContactFirstName)
                    .HasMaxLength(100)
                    .HasColumnName("ClientContact_FirstName");

                entity.Property(e => e.ClientContactLastName)
                    .HasMaxLength(100)
                    .HasColumnName("ClientContact_LastName");

                entity.Property(e => e.ClientContactPhone)
                    .HasMaxLength(20)
                    .HasColumnName("ClientContact_Phone");

                entity.Property(e => e.ClientMatterId).HasMaxLength(100);

                entity.Property(e => e.ClientMatterIdModified).HasMaxLength(100);

                entity.Property(e => e.DiscountExpenseBillPercentage).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.DiscountExpenseBillPercentageModified).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.DiscountExpenseSharePercentage).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.DiscountExpenseSharePercentageModified).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.DiscountFeesBillPercentage).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.DiscountFeesBillPercentageModified).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.DiscountFeesSharePercentage).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.DiscountFeesSharePercentageModified).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.ExpenseTax).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.ExpenseTaxModified).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.FeesTax).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.FeesTaxModified).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.FundsApplied).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.FundsAppliedModified).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.InvoiceId).HasColumnName("Invoice_Id");

                entity.Property(e => e.LawFirmContactContactCode)
                    .HasMaxLength(100)
                    .HasColumnName("LawFirmContact_ContactCode");

                entity.Property(e => e.LawFirmContactEmail)
                    .HasMaxLength(255)
                    .HasColumnName("LawFirmContact_Email");

                entity.Property(e => e.LawFirmContactFax)
                    .HasMaxLength(20)
                    .HasColumnName("LawFirmContact_Fax");

                entity.Property(e => e.LawFirmContactFirstName)
                    .HasMaxLength(100)
                    .HasColumnName("LawFirmContact_FirstName");

                entity.Property(e => e.LawFirmContactLastName)
                    .HasMaxLength(100)
                    .HasColumnName("LawFirmContact_LastName");

                entity.Property(e => e.LawFirmContactPhone)
                    .HasMaxLength(20)
                    .HasColumnName("LawFirmContact_Phone");

                entity.Property(e => e.LawFirmMatterId).HasMaxLength(100);

                entity.Property(e => e.LawFirmMatterIdModified).HasMaxLength(100);

                entity.Property(e => e.ManagingContactContactCode)
                    .HasMaxLength(100)
                    .HasColumnName("ManagingContact_ContactCode");

                entity.Property(e => e.ManagingContactEmail)
                    .HasMaxLength(255)
                    .HasColumnName("ManagingContact_Email");

                entity.Property(e => e.ManagingContactFax)
                    .HasMaxLength(20)
                    .HasColumnName("ManagingContact_Fax");

                entity.Property(e => e.ManagingContactFirstName)
                    .HasMaxLength(100)
                    .HasColumnName("ManagingContact_FirstName");

                entity.Property(e => e.ManagingContactLastName)
                    .HasMaxLength(100)
                    .HasColumnName("ManagingContact_LastName");

                entity.Property(e => e.ManagingContactPhone)
                    .HasMaxLength(20)
                    .HasColumnName("ManagingContact_Phone");

                entity.Property(e => e.MatterDescription).HasMaxLength(2000);

                entity.Property(e => e.MatterId).HasColumnName("Matter_Id");

                entity.Property(e => e.MatterName).HasMaxLength(255);

                entity.Property(e => e.MatterNameModified).HasMaxLength(255);

                entity.Property(e => e.NetExpense).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.NetExpenseModified).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.NetFees).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.NetFeesModified).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.NetTotal).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.NetTotalModified).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.PoNumber).HasMaxLength(100);

                entity.Property(e => e.TotalDiscount).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.TotalDiscountModified).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.TotalExpenseDiscount).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.TotalExpenseDiscountModified).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.TotalExpenses).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.TotalExpensesModified).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.TotalFees).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.TotalFeesDiscount).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.TotalFeesDiscountModified).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.TotalFeesModified).HasColumnType("decimal(18, 2)");

                entity.HasOne(d => d.Invoice)
                    .WithMany(p => p.InvoiceMatters)
                    .HasForeignKey(d => d.InvoiceId)
                    .OnDelete(DeleteBehavior.ClientSetNull);

                entity.HasOne(d => d.Matter)
                    .WithMany(p => p.InvoiceMatters)
                    .HasForeignKey(d => d.MatterId);
            });

            modelBuilder.Entity<InvoiceNote>(entity =>
            {
                entity.HasIndex(e => e.CreatedById, "IX_CreatedBy_Id");

                entity.HasIndex(e => e.InvoiceId, "IX_Invoice_Id");

                entity.Property(e => e.CreatedById).HasColumnName("CreatedBy_Id");

                entity.Property(e => e.InvoiceId).HasColumnName("Invoice_Id");

                entity.Property(e => e.Note)
                    .IsRequired()
                    .HasMaxLength(1000);

                entity.Property(e => e.NoteTimeStamp).HasColumnType("datetime");

                entity.HasOne(d => d.CreatedBy)
                    .WithMany(p => p.InvoiceNotes)
                    .HasForeignKey(d => d.CreatedById)
                    .OnDelete(DeleteBehavior.ClientSetNull);

                entity.HasOne(d => d.Invoice)
                    .WithMany(p => p.InvoiceNotes)
                    .HasForeignKey(d => d.InvoiceId)
                    .OnDelete(DeleteBehavior.ClientSetNull);
            });

            modelBuilder.Entity<InvoicePrebillMatchLog>(entity =>
            {
                entity.ToTable("InvoicePrebillMatchLog");

                entity.HasIndex(e => e.InvoiceId, "IX_Invoice_Id");

                entity.HasIndex(e => e.PrebillId, "IX_Prebill_Id");

                entity.Property(e => e.InvoiceId).HasColumnName("InvoiceID");

                entity.Property(e => e.MatchComments).IsUnicode(false);

                entity.Property(e => e.MatchPercentage).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.PrebillId).HasColumnName("PrebillID");
            });

            modelBuilder.Entity<InvoicePrepInvoiceInvoiceReln>(entity =>
            {
                entity.ToTable("InvoicePrepInvoice_InvoiceReln");

                entity.HasIndex(e => e.InvPrepInvoiceId, "IX_InvoicePrepInvoice_InvoiceReln_InvPrepInvoice_Id");

                entity.HasIndex(e => e.InvoiceId, "IX_InvoicePrepInvoice_InvoiceReln_Invoice_Id");

                entity.Property(e => e.ExpenseRate).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.Fees).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.FeesOnExpense).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.FeesOnFees).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.InvPrepInvoiceId).HasColumnName("InvPrepInvoice_Id");

                entity.Property(e => e.InvoiceId).HasColumnName("Invoice_Id");

                entity.Property(e => e.Rate).HasColumnType("decimal(18, 2)");

                entity.HasOne(d => d.InvPrepInvoice)
                    .WithMany(p => p.InvoicePrepInvoiceInvoiceRelns)
                    .HasForeignKey(d => d.InvPrepInvoiceId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__InvoicePr__InvPr__7908F585");

                entity.HasOne(d => d.Invoice)
                    .WithMany(p => p.InvoicePrepInvoiceInvoiceRelns)
                    .HasForeignKey(d => d.InvoiceId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__InvoicePr__Invoi__79FD19BE");
            });

            modelBuilder.Entity<InvoiceRegulatoryStatement>(entity =>
            {
                entity.HasIndex(e => e.InvoiceId, "IX_Invoice_Id");

                entity.Property(e => e.Heading).HasMaxLength(255);

                entity.Property(e => e.InvoiceId).HasColumnName("Invoice_Id");

                entity.Property(e => e.Statement).HasMaxLength(3000);

                entity.HasOne(d => d.Invoice)
                    .WithMany(p => p.InvoiceRegulatoryStatements)
                    .HasForeignKey(d => d.InvoiceId)
                    .OnDelete(DeleteBehavior.ClientSetNull);
            });

            modelBuilder.Entity<InvoiceTaxMatterDiscountCredit>(entity =>
            {
                entity.HasIndex(e => e.InvoiceLineItemId, "IX_InvoiceLineItem_Id");

                entity.Property(e => e.InvoiceLineItemId).HasColumnName("InvoiceLineItem_Id");

                entity.Property(e => e.TaxId).HasMaxLength(100);

                entity.HasOne(d => d.InvoiceLineItem)
                    .WithMany(p => p.InvoiceTaxMatterDiscountCredits)
                    .HasForeignKey(d => d.InvoiceLineItemId)
                    .OnDelete(DeleteBehavior.ClientSetNull);
            });

            modelBuilder.Entity<InvoiceTaxSummary>(entity =>
            {
                entity.HasIndex(e => e.InvoiceMatterId, "IX_InvoiceMatter_Id");

                entity.Property(e => e.InvoiceMatterId).HasColumnName("InvoiceMatter_Id");

                entity.Property(e => e.TaxId).HasMaxLength(100);

                entity.Property(e => e.TaxOnExpense).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.TaxOnFees).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.TaxableExpense).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.TaxableFees).HasColumnType("decimal(18, 2)");

                entity.HasOne(d => d.InvoiceMatter)
                    .WithMany(p => p.InvoiceTaxSummaries)
                    .HasForeignKey(d => d.InvoiceMatterId)
                    .OnDelete(DeleteBehavior.ClientSetNull);
            });

            modelBuilder.Entity<InvoiceTaxis>(entity =>
            {
                entity.HasIndex(e => e.InvoiceFileId, "IX_InvoiceFile_Id");

                entity.Property(e => e.InvoiceFileId).HasColumnName("InvoiceFile_Id");

                entity.Property(e => e.TaxId).HasMaxLength(100);

                entity.Property(e => e.TaxJurisdictionCountryCode).HasMaxLength(100);

                entity.Property(e => e.TaxJurisdictionLocality).HasMaxLength(255);

                entity.Property(e => e.TaxOnTaxId).HasMaxLength(100);

                entity.Property(e => e.TaxRatePercent).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.TaxType).HasMaxLength(100);

                entity.Property(e => e.TaxVendorId).HasMaxLength(100);

                entity.HasOne(d => d.InvoiceFile)
                    .WithMany(p => p.InvoiceTaxes)
                    .HasForeignKey(d => d.InvoiceFileId)
                    .OnDelete(DeleteBehavior.ClientSetNull);
            });

            modelBuilder.Entity<InvoiceTimekeeperSummary>(entity =>
            {
                entity.HasIndex(e => e.ExtendHeaderExtendHeaderId, "IX_ExtendHeader_ExtendHeaderID");

                entity.HasIndex(e => e.InvoiceMatterId, "IX_InvoiceMatter_Id");

                entity.HasIndex(e => e.TimekeeperId, "IX_Timekeeper_Id");

                entity.Property(e => e.ExtendHeaderExtendHeaderId).HasColumnName("ExtendHeader_ExtendHeaderID");

                entity.Property(e => e.InvoiceMatterId).HasColumnName("InvoiceMatter_Id");

                entity.Property(e => e.TimekeeperFirstName).HasMaxLength(100);

                entity.Property(e => e.TimekeeperId).HasColumnName("Timekeeper_Id");

                entity.Property(e => e.TimekeeperId1)
                    .HasMaxLength(100)
                    .HasColumnName("TimekeeperId");

                entity.Property(e => e.TimekeeperLastName).HasMaxLength(100);

                entity.Property(e => e.TimekeeperRate).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.TimekeeperTotalUnits).HasColumnType("decimal(18, 2)");

                entity.HasOne(d => d.ExtendHeaderExtendHeader)
                    .WithMany(p => p.InvoiceTimekeeperSummaries)
                    .HasForeignKey(d => d.ExtendHeaderExtendHeaderId);

                entity.HasOne(d => d.InvoiceMatter)
                    .WithMany(p => p.InvoiceTimekeeperSummaries)
                    .HasForeignKey(d => d.InvoiceMatterId)
                    .OnDelete(DeleteBehavior.ClientSetNull);

                entity.HasOne(d => d.Timekeeper)
                    .WithMany(p => p.InvoiceTimekeeperSummaries)
                    .HasForeignKey(d => d.TimekeeperId);
            });

            modelBuilder.Entity<InvoiceUpload>(entity =>
            {
                entity.HasIndex(e => e.ClientId, "IX_Client_Id");

                entity.HasIndex(e => e.LawFirmId, "IX_LawFirm_Id");

                entity.HasIndex(e => e.UserId, "IX_User_Id");

                entity.Property(e => e.ClientId).HasColumnName("Client_Id");

                entity.Property(e => e.CreatedTime).HasColumnType("datetime");

                entity.Property(e => e.InvoiceDocumentFileNames).HasMaxLength(2000);

                entity.Property(e => e.InvoiceFileName).HasMaxLength(255);

                entity.Property(e => e.InvoiceNotes).HasMaxLength(2000);

                entity.Property(e => e.LawFirmId).HasColumnName("LawFirm_Id");

                entity.Property(e => e.ReceivedDate).HasColumnType("datetime");

                entity.Property(e => e.TrackingNumber)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.UserId).HasColumnName("User_Id");

                entity.HasOne(d => d.Client)
                    .WithMany(p => p.InvoiceUploads)
                    .HasForeignKey(d => d.ClientId);

                entity.HasOne(d => d.LawFirm)
                    .WithMany(p => p.InvoiceUploads)
                    .HasForeignKey(d => d.LawFirmId)
                    .OnDelete(DeleteBehavior.ClientSetNull);

                entity.HasOne(d => d.User)
                    .WithMany(p => p.InvoiceUploads)
                    .HasForeignKey(d => d.UserId)
                    .OnDelete(DeleteBehavior.ClientSetNull);
            });

            modelBuilder.Entity<InvoiceValidation>(entity =>
            {
                entity.HasKey(e => e.IpsInvoiceId)
                    .HasName("PK__InvoiceV__15C05AB81293BD5E");

                entity.ToTable("InvoiceValidation");

                entity.HasIndex(e => e.IpsInvoiceId, "IX_Invoices_InvoiceValidation");

                entity.Property(e => e.IpsInvoiceId)
                    .ValueGeneratedNever()
                    .HasColumnName("IPS_InvoiceId");

                entity.Property(e => e.Ebiller)
                    .IsRequired()
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.EbillerAppealAdjustment1)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("Ebiller_AppealAdjustment1");

                entity.Property(e => e.EbillerAppealAdjustment2)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("Ebiller_AppealAdjustment2");

                entity.Property(e => e.EbillerAppealAdjustment3)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("Ebiller_AppealAdjustment3");

                entity.Property(e => e.EbillerAppealAllowed1)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("Ebiller_AppealAllowed1");

                entity.Property(e => e.EbillerAppealAllowed2)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("Ebiller_AppealAllowed2");

                entity.Property(e => e.EbillerAppealAllowed3)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("Ebiller_AppealAllowed3");

                entity.Property(e => e.EbillerAppealApplied1)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("Ebiller_AppealApplied1");

                entity.Property(e => e.EbillerAppealApplied2)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("Ebiller_AppealApplied2");

                entity.Property(e => e.EbillerAppealApplied3)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("Ebiller_AppealApplied3");

                entity.Property(e => e.EbillerAppealCostShareAdjustment1)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("Ebiller_AppealCostShareAdjustment1");

                entity.Property(e => e.EbillerAppealCostShareAdjustment2)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("Ebiller_AppealCostShareAdjustment2");

                entity.Property(e => e.EbillerAppealCostShareAdjustment3)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("Ebiller_AppealCostShareAdjustment3");

                entity.Property(e => e.EbillerAppealProcessingFeesAdjustment1)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("Ebiller_AppealProcessingFeesAdjustment1");

                entity.Property(e => e.EbillerAppealProcessingFeesAdjustment2)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("Ebiller_AppealProcessingFeesAdjustment2");

                entity.Property(e => e.EbillerAppealProcessingFeesAdjustment3)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("Ebiller_AppealProcessingFeesAdjustment3");

                entity.Property(e => e.EbillerAppealPromptPayAdjustment1)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("Ebiller_AppealPromptPayAdjustment1");

                entity.Property(e => e.EbillerAppealPromptPayAdjustment2)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("Ebiller_AppealPromptPayAdjustment2");

                entity.Property(e => e.EbillerAppealPromptPayAdjustment3)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("Ebiller_AppealPromptPayAdjustment3");

                entity.Property(e => e.EbillerAppealToPay1)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("Ebiller_AppealToPay1");

                entity.Property(e => e.EbillerAppealToPay2)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("Ebiller_AppealToPay2");

                entity.Property(e => e.EbillerAppealToPay3)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("Ebiller_AppealToPay3");

                entity.Property(e => e.EbillerExpenseAdjAmount)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("Ebiller_ExpenseAdjAmount");

                entity.Property(e => e.EbillerExpenseCostShareAdjAmount)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("Ebiller_ExpenseCostShareAdjAmount");

                entity.Property(e => e.EbillerExpenseCostSharePercent)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("Ebiller_ExpenseCostSharePercent");

                entity.Property(e => e.EbillerExpenseCurrentAmount)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("Ebiller_ExpenseCurrentAmount");

                entity.Property(e => e.EbillerExpenseOrigAmount)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("Ebiller_ExpenseOrigAmount");

                entity.Property(e => e.EbillerExpenseToPayAmount)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("Ebiller_ExpenseToPayAmount");

                entity.Property(e => e.EbillerFeeAdjAmount)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("Ebiller_FeeAdjAmount");

                entity.Property(e => e.EbillerFeeCostShareAdjAmount)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("Ebiller_FeeCostShareAdjAmount");

                entity.Property(e => e.EbillerFeeCostSharePercent)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("Ebiller_FeeCostSharePercent");

                entity.Property(e => e.EbillerFeeCurrentAmount)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("Ebiller_FeeCurrentAmount");

                entity.Property(e => e.EbillerFeeOrigAmount)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("Ebiller_FeeOrigAmount");

                entity.Property(e => e.EbillerFeeToPayAmount)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("Ebiller_FeeToPayAmount");

                entity.Property(e => e.EbillerInvNetTotal)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("Ebiller_InvNetTotal");

                entity.Property(e => e.EbillerInvStatus)
                    .HasMaxLength(200)
                    .IsUnicode(false)
                    .HasColumnName("Ebiller_InvStatus");

                entity.Property(e => e.EbillerIsAppeal)
                    .HasMaxLength(200)
                    .IsUnicode(false)
                    .HasColumnName("Ebiller_IsAppeal");

                entity.Property(e => e.EbillerIsCostShareApplied)
                    .HasMaxLength(200)
                    .IsUnicode(false)
                    .HasColumnName("Ebiller_IsCostShareApplied");

                entity.Property(e => e.EbillerIsPromptPayApplied)
                    .HasMaxLength(200)
                    .IsUnicode(false)
                    .HasColumnName("Ebiller_IsPromptPayApplied");

                entity.Property(e => e.EbillerIsPromptPayFeesOnly)
                    .HasMaxLength(200)
                    .IsUnicode(false)
                    .HasColumnName("Ebiller_IsPromptPayFeesOnly");

                entity.Property(e => e.EbillerProcessingFees)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("Ebiller_ProcessingFees");

                entity.Property(e => e.EbillerPromptPayAmount)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("Ebiller_PromptPayAmount");

                entity.Property(e => e.EbillerPromptPayPendPercent)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("Ebiller_PromptPayPendPercent");

                entity.Property(e => e.EbillerPromptPayPercent)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("Ebiller_PromptPayPercent");

                entity.Property(e => e.EbillerTotalAdjAmount)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("Ebiller_TotalAdjAmount");

                entity.Property(e => e.EbillerTotalApprovedIncludingAppeal)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("Ebiller_TotalApprovedIncludingAppeal");

                entity.Property(e => e.EbillerTotalCostShareAdjAmount)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("Ebiller_TotalCostShareAdjAmount");

                entity.Property(e => e.EbillerTotalCurrentAmount)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("Ebiller_TotalCurrentAmount");

                entity.Property(e => e.EbillerTotalOrigAmount)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("Ebiller_TotalOrigAmount");

                entity.Property(e => e.EbillerTotalToPayAmount)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("Ebiller_TotalToPayAmount");

                entity.Property(e => e.IgnoreFromEbillingAutomation).HasColumnName("IgnoreFromEBillingAutomation");

                entity.Property(e => e.IpsAppealResponseAmount)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("IPS_AppealResponseAmount");

                entity.Property(e => e.IpsAppealResponseExpenses)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("IPS_AppealResponseExpenses");

                entity.Property(e => e.IpsAppealResponseFees)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("IPS_AppealResponseFees");

                entity.Property(e => e.IpsDeductedExpenseByPayer)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("IPS_DeductedExpenseByPayer");

                entity.Property(e => e.IpsDeductedFeesByPayer)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("IPS_DeductedFeesByPayer");

                entity.Property(e => e.IpsFinalPaidAmount)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("IPS_FinalPaidAmount");

                entity.Property(e => e.IpsFinalPaidAmountWithDisc)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("IPS_FinalPaidAmountWithDisc");

                entity.Property(e => e.IpsFinalPaidExpenses)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("IPS_FinalPaidExpenses");

                entity.Property(e => e.IpsFinalPaidFees)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("IPS_FinalPaidFees");

                entity.Property(e => e.IpsInvStatus)
                    .IsRequired()
                    .HasMaxLength(200)
                    .IsUnicode(false)
                    .HasColumnName("IPS_InvStatus");

                entity.Property(e => e.IpsInvoiceCode)
                    .IsRequired()
                    .HasMaxLength(200)
                    .IsUnicode(false)
                    .HasColumnName("IPS_InvoiceCode");

                entity.Property(e => e.IpsInvoiceTotal)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("IPS_InvoiceTotal");

                entity.Property(e => e.IpsInvoiceTotalModified)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("IPS_InvoiceTotalModified");

                entity.Property(e => e.IpsPaidExpenseWithCostShare)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("IPS_PaidExpenseWithCostShare");

                entity.Property(e => e.IpsPaidExpenseWithDisc)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("IPS_PaidExpenseWithDisc");

                entity.Property(e => e.IpsPaidFeesWithCostShare)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("IPS_PaidFeesWithCostShare");

                entity.Property(e => e.IpsPaidFeesWithDisc)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("IPS_PaidFeesWithDisc");

                entity.Property(e => e.IpsPaidTotalByPayer)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("IPS_PaidTotalByPayer");

                entity.Property(e => e.IpsPaidTotalWithCostShare)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("IPS_PaidTotalWithCostShare");

                entity.Property(e => e.IpsPromptDiscExpensePercen)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("IPS_PromptDiscExpensePercen");

                entity.Property(e => e.IpsPromptDiscFeesPercen)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("IPS_PromptDiscFeesPercen");
            });

            modelBuilder.Entity<LawFirm>(entity =>
            {
                entity.HasIndex(e => e.CreatedById, "IX_CreatedBy_Id");

                entity.HasIndex(e => e.ModifiedById, "IX_ModifiedBy_Id");

                entity.HasIndex(e => e.Name, "IX_Name");

                entity.Property(e => e.Addr1).HasMaxLength(100);

                entity.Property(e => e.Addr2).HasMaxLength(100);

                entity.Property(e => e.Addr3).HasMaxLength(100);

                entity.Property(e => e.AllowDrillDownInReduction)
                    .IsRequired()
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.BillingCurrency)
                    .IsRequired()
                    .HasMaxLength(3);

                entity.Property(e => e.City).HasMaxLength(100);

                entity.Property(e => e.Code)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.Country)
                    .IsRequired()
                    .HasMaxLength(3);

                entity.Property(e => e.CreatedById).HasColumnName("CreatedBy_Id");

                entity.Property(e => e.CreatedTime).HasColumnType("datetime");

                entity.Property(e => e.DefaultExpenseQueryContactPersonId).HasColumnName("DefaultExpenseQueryContactPerson_Id");

                entity.Property(e => e.DefaultExpenseQueryCopyContactPersonId).HasColumnName("DefaultExpenseQueryCopyContactPerson_Id");

                entity.Property(e => e.DefaultExpenseQueryCopyUserId).HasColumnName("DefaultExpenseQueryCopyUser_Id");

                entity.Property(e => e.DefaultExpenseQueryUserId).HasColumnName("DefaultExpenseQueryUser_Id");

                entity.Property(e => e.DefaultFeeQueryContactPersonId).HasColumnName("DefaultFeeQueryContactPerson_Id");

                entity.Property(e => e.DefaultFeeQueryCopyContactPersonId).HasColumnName("DefaultFeeQueryCopyContactPerson_Id");

                entity.Property(e => e.DefaultFeeQueryCopyUserId).HasColumnName("DefaultFeeQueryCopyUser_Id");

                entity.Property(e => e.DefaultFeeQueryUserId).HasColumnName("DefaultFeeQueryUser_Id");

                entity.Property(e => e.Email).HasMaxLength(100);

                entity.Property(e => e.Fax).HasMaxLength(20);

                entity.Property(e => e.InvoicePrepExpRate).HasColumnType("decimal(18, 3)");

                entity.Property(e => e.InvoicePrepRate).HasColumnType("decimal(18, 3)");

                entity.Property(e => e.LawFirmBillingSystemId).HasColumnName("LawFirmBillingSystem_Id");

                entity.Property(e => e.ModifiedById).HasColumnName("ModifiedBy_Id");

                entity.Property(e => e.ModifiedTime).HasColumnType("datetime");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(255);

                entity.Property(e => e.PaymentTerms)
                    .IsRequired()
                    .HasMaxLength(255);

                entity.Property(e => e.PinCode).HasMaxLength(10);

                entity.Property(e => e.QueryReminderMailling).HasDefaultValueSql("((0))");

                entity.Property(e => e.RemitAddr1).HasMaxLength(100);

                entity.Property(e => e.RemitAddr2).HasMaxLength(100);

                entity.Property(e => e.RemitAddr3).HasMaxLength(100);

                entity.Property(e => e.RemitCity).HasMaxLength(100);

                entity.Property(e => e.RemitCountry).HasMaxLength(3);

                entity.Property(e => e.RemitPinCode).HasMaxLength(10);

                entity.Property(e => e.RemitState).HasMaxLength(50);

                entity.Property(e => e.State).HasMaxLength(50);

                entity.Property(e => e.TaxId).HasMaxLength(50);

                entity.Property(e => e.TaxRate).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.Tel).HasMaxLength(20);

                entity.HasOne(d => d.CreatedBy)
                    .WithMany(p => p.LawFirmCreatedBies)
                    .HasForeignKey(d => d.CreatedById)
                    .OnDelete(DeleteBehavior.ClientSetNull);

                entity.HasOne(d => d.DefaultExpenseQueryCopyContactPerson)
                    .WithMany(p => p.LawFirmDefaultExpenseQueryCopyContactPeople)
                    .HasForeignKey(d => d.DefaultExpenseQueryCopyContactPersonId)
                    .HasConstraintName("fk_LawFirms_DefaultExpenseQueryCopyContactPerson");

                entity.HasOne(d => d.DefaultExpenseQueryCopyUser)
                    .WithMany(p => p.LawFirmDefaultExpenseQueryCopyUsers)
                    .HasForeignKey(d => d.DefaultExpenseQueryCopyUserId)
                    .HasConstraintName("fk_LawFirms_ExpenseQueryCopyUser");

                entity.HasOne(d => d.DefaultExpenseQueryUser)
                    .WithMany(p => p.LawFirmDefaultExpenseQueryUsers)
                    .HasForeignKey(d => d.DefaultExpenseQueryUserId)
                    .HasConstraintName("fk_LawFirms_DefaultExpenseQueryUser");

                entity.HasOne(d => d.DefaultFeeQueryCopyContactPerson)
                    .WithMany(p => p.LawFirmDefaultFeeQueryCopyContactPeople)
                    .HasForeignKey(d => d.DefaultFeeQueryCopyContactPersonId)
                    .HasConstraintName("fk_LawFirms_DefaultFeeQueryCopyContactPerson");

                entity.HasOne(d => d.DefaultFeeQueryCopyUser)
                    .WithMany(p => p.LawFirmDefaultFeeQueryCopyUsers)
                    .HasForeignKey(d => d.DefaultFeeQueryCopyUserId)
                    .HasConstraintName("fk_LawFirms_DefaultFeeQueryCopyUser");

                entity.HasOne(d => d.DefaultFeeQueryUser)
                    .WithMany(p => p.LawFirmDefaultFeeQueryUsers)
                    .HasForeignKey(d => d.DefaultFeeQueryUserId)
                    .HasConstraintName("fk_LawFirms_DefaultFeeQueryUser");

                entity.HasOne(d => d.LawFirmBillingSystem)
                    .WithMany(p => p.LawFirms)
                    .HasForeignKey(d => d.LawFirmBillingSystemId)
                    .OnDelete(DeleteBehavior.Cascade)
                    .HasConstraintName("FK_lawfirms_MasterLawFirmTimeAndBillingSystems");

                entity.HasOne(d => d.ModifiedBy)
                    .WithMany(p => p.LawFirmModifiedBies)
                    .HasForeignKey(d => d.ModifiedById)
                    .OnDelete(DeleteBehavior.ClientSetNull);
            });

            modelBuilder.Entity<LawFirmClientFileExchangeExportSetting>(entity =>
            {
                entity.Property(e => e.ExportFolderPath).HasMaxLength(1000);

                entity.Property(e => e.Format).HasMaxLength(500);

                entity.Property(e => e.Ftppassword)
                    .HasMaxLength(500)
                    .HasColumnName("FTPPassword");

                entity.Property(e => e.Ftppath)
                    .HasMaxLength(1000)
                    .HasColumnName("FTPPath");

                entity.Property(e => e.FtpuserName)
                    .HasMaxLength(500)
                    .HasColumnName("FTPUserName");

                entity.Property(e => e.LastRunDate).HasColumnType("datetime");

                entity.Property(e => e.RunDate).HasColumnType("datetime");

                entity.Property(e => e.Type).HasMaxLength(500);
            });

            modelBuilder.Entity<LawFirmContactPerson>(entity =>
            {
                entity.HasIndex(e => e.CreatedById, "IX_CreatedBy_Id");

                entity.HasIndex(e => e.LawFirmId, "IX_LawFirm_Id");

                entity.HasIndex(e => e.MasterTimekeeperLevelId, "IX_MasterTimekeeperLevel_Id");

                entity.HasIndex(e => e.ModifiedById, "IX_ModifiedBy_Id");

                entity.HasIndex(e => e.UserId, "IX_User_Id");

                entity.Property(e => e.BillingCode).HasMaxLength(20);

                entity.Property(e => e.Cell).HasMaxLength(20);

                entity.Property(e => e.CreatedById).HasColumnName("CreatedBy_Id");

                entity.Property(e => e.CreatedTime).HasColumnType("datetime");

                entity.Property(e => e.Discriminator)
                    .IsRequired()
                    .HasMaxLength(128);

                entity.Property(e => e.EbillerReference1)
                    .HasMaxLength(100)
                    .HasColumnName("EBillerReference1");

                entity.Property(e => e.EbillerReference2)
                    .HasMaxLength(100)
                    .HasColumnName("EBillerReference2");

                entity.Property(e => e.EbillerStatus)
                    .HasMaxLength(200)
                    .HasColumnName("EBillerStatus");

                entity.Property(e => e.EbillerStatusChangeDate)
                    .HasColumnType("datetime")
                    .HasColumnName("EBillerStatusChangeDate");

                entity.Property(e => e.EbillerStatusCheckDate)
                    .HasColumnType("datetime")
                    .HasColumnName("EBillerStatusCheckDate");

                entity.Property(e => e.EbillerStatusComments)
                    .HasMaxLength(2000)
                    .HasColumnName("EBillerStatusComments");

                entity.Property(e => e.Fax).HasMaxLength(20);

                entity.Property(e => e.FirstName)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.Property(e => e.LastName).HasMaxLength(100);

                entity.Property(e => e.LawFirmId).HasColumnName("LawFirm_Id");

                entity.Property(e => e.MasterTimekeeperLevelId).HasColumnName("MasterTimekeeperLevel_Id");

                entity.Property(e => e.MiddleName).HasMaxLength(100);

                entity.Property(e => e.ModifiedById).HasColumnName("ModifiedBy_Id");

                entity.Property(e => e.ModifiedTime).HasColumnType("datetime");

                entity.Property(e => e.PrimaryEmail)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.Property(e => e.SecondaryEmail).HasMaxLength(100);

                entity.Property(e => e.StatusId).HasColumnName("Status_Id");

                entity.Property(e => e.Tel).HasMaxLength(20);

                entity.Property(e => e.UserId).HasColumnName("User_Id");

                entity.HasOne(d => d.CreatedBy)
                    .WithMany(p => p.LawFirmContactPersonCreatedBies)
                    .HasForeignKey(d => d.CreatedById)
                    .OnDelete(DeleteBehavior.ClientSetNull);

                entity.HasOne(d => d.LawFirm)
                    .WithMany(p => p.LawFirmContactPeople)
                    .HasForeignKey(d => d.LawFirmId)
                    .OnDelete(DeleteBehavior.ClientSetNull);

                entity.HasOne(d => d.MasterTimekeeperLevel)
                    .WithMany(p => p.LawFirmContactPeople)
                    .HasForeignKey(d => d.MasterTimekeeperLevelId);

                entity.HasOne(d => d.ModifiedBy)
                    .WithMany(p => p.LawFirmContactPersonModifiedBies)
                    .HasForeignKey(d => d.ModifiedById)
                    .OnDelete(DeleteBehavior.ClientSetNull);

                entity.HasOne(d => d.User)
                    .WithMany(p => p.LawFirmContactPersonUsers)
                    .HasForeignKey(d => d.UserId);
            });

            modelBuilder.Entity<LawFirmEbiller>(entity =>
            {
                entity.ToTable("LawFirmEBillers");

                entity.Property(e => e.Comments).HasMaxLength(2000);

                entity.Property(e => e.CreatedById).HasColumnName("CreatedBy_Id");

                entity.Property(e => e.CreatedTime).HasColumnType("datetime");

                entity.Property(e => e.ExtraInfo1).HasMaxLength(100);

                entity.Property(e => e.ExtraInfo2).HasMaxLength(100);

                entity.Property(e => e.LawFirmId).HasColumnName("LawFirm_Id");

                entity.Property(e => e.Login).HasMaxLength(100);

                entity.Property(e => e.LoginStatus)
                    .HasMaxLength(1000)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('Active')");

                entity.Property(e => e.MasterEbillerId).HasColumnName("MasterEBiller_Id");

                entity.Property(e => e.ModifiedById).HasColumnName("ModifiedBy_Id");

                entity.Property(e => e.ModifiedTime).HasColumnType("datetime");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.Property(e => e.Password).HasMaxLength(100);

                entity.HasOne(d => d.CreatedBy)
                    .WithMany(p => p.LawFirmEbillerCreatedBies)
                    .HasForeignKey(d => d.CreatedById)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_lawfirmebiller_modifiedBy");

                entity.HasOne(d => d.LawFirm)
                    .WithMany(p => p.LawFirmEbillers)
                    .HasForeignKey(d => d.LawFirmId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_lawfirmebiller_lawfirm");

                entity.HasOne(d => d.MasterEbiller)
                    .WithMany(p => p.LawFirmEbillers)
                    .HasForeignKey(d => d.MasterEbillerId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_lawfirmebiller_masterebiller");

                entity.HasOne(d => d.ModifiedBy)
                    .WithMany(p => p.LawFirmEbillerModifiedBies)
                    .HasForeignKey(d => d.ModifiedById)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_lawfirmebiller_createdBy");
            });

            modelBuilder.Entity<LawFirmMatterCustomField>(entity =>
            {
                entity.HasIndex(e => e.CreatedById, "IX_CreatedBy_Id");

                entity.HasIndex(e => e.LawFirmId, "IX_LawFirm_Id");

                entity.HasIndex(e => e.MatterCustomFieldId, "IX_MatterCustomField_Id");

                entity.HasIndex(e => e.ModifiedById, "IX_ModifiedBy_Id");

                entity.HasIndex(e => e.ProductLineId, "IX_ProductLine_Id");

                entity.Property(e => e.CreatedById).HasColumnName("CreatedBy_Id");

                entity.Property(e => e.CreatedTime).HasColumnType("datetime");

                entity.Property(e => e.LawFirmId).HasColumnName("LawFirm_Id");

                entity.Property(e => e.MatterCustomFieldId).HasColumnName("MatterCustomField_Id");

                entity.Property(e => e.ModifiedById).HasColumnName("ModifiedBy_Id");

                entity.Property(e => e.ModifiedTime).HasColumnType("datetime");

                entity.Property(e => e.ProductLineId).HasColumnName("ProductLine_Id");

                entity.HasOne(d => d.CreatedBy)
                    .WithMany(p => p.LawFirmMatterCustomFieldCreatedBies)
                    .HasForeignKey(d => d.CreatedById)
                    .OnDelete(DeleteBehavior.ClientSetNull);

                entity.HasOne(d => d.LawFirm)
                    .WithMany(p => p.LawFirmMatterCustomFields)
                    .HasForeignKey(d => d.LawFirmId)
                    .OnDelete(DeleteBehavior.ClientSetNull);

                entity.HasOne(d => d.MatterCustomField)
                    .WithMany(p => p.LawFirmMatterCustomFields)
                    .HasForeignKey(d => d.MatterCustomFieldId)
                    .OnDelete(DeleteBehavior.ClientSetNull);

                entity.HasOne(d => d.ModifiedBy)
                    .WithMany(p => p.LawFirmMatterCustomFieldModifiedBies)
                    .HasForeignKey(d => d.ModifiedById)
                    .OnDelete(DeleteBehavior.ClientSetNull);

                entity.HasOne(d => d.ProductLine)
                    .WithMany(p => p.LawFirmMatterCustomFields)
                    .HasForeignKey(d => d.ProductLineId)
                    .OnDelete(DeleteBehavior.ClientSetNull);
            });

            modelBuilder.Entity<LawFirmNote>(entity =>
            {
                entity.Property(e => e.CreatedById).HasColumnName("CreatedBy_Id");

                entity.Property(e => e.LawFirmId).HasColumnName("LawFirm_Id");

                entity.Property(e => e.Note)
                    .IsRequired()
                    .HasMaxLength(1000);

                entity.Property(e => e.NoteTimeStamp).HasColumnType("datetime");

                entity.HasOne(d => d.CreatedBy)
                    .WithMany(p => p.LawFirmNotes)
                    .HasForeignKey(d => d.CreatedById)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_LawFirmNotes_Users");

                entity.HasOne(d => d.LawFirm)
                    .WithMany(p => p.LawFirmNotes)
                    .HasForeignKey(d => d.LawFirmId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_LawFirmNotes_LawFirmNotes");
            });

            modelBuilder.Entity<LawFirmOffice>(entity =>
            {
                entity.HasIndex(e => e.CreatedById, "IX_CreatedBy_Id");

                entity.HasIndex(e => e.LawFirmId, "IX_LawFirm_Id");

                entity.HasIndex(e => e.ModifiedById, "IX_ModifiedBy_Id");

                entity.Property(e => e.Addr1)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.Property(e => e.Addr2).HasMaxLength(100);

                entity.Property(e => e.Addr3).HasMaxLength(100);

                entity.Property(e => e.City)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.Property(e => e.Country)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.Property(e => e.CreatedById).HasColumnName("CreatedBy_Id");

                entity.Property(e => e.CreatedTime).HasColumnType("datetime");

                entity.Property(e => e.Email).HasMaxLength(50);

                entity.Property(e => e.Fax).HasMaxLength(20);

                entity.Property(e => e.InvoicePrepExpRate).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.InvoicePrepRate).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.LawFirmId).HasColumnName("LawFirm_Id");

                entity.Property(e => e.LocationTitle)
                    .IsRequired()
                    .HasMaxLength(255);

                entity.Property(e => e.ModifiedById).HasColumnName("ModifiedBy_Id");

                entity.Property(e => e.ModifiedTime).HasColumnType("datetime");

                entity.Property(e => e.PinCode).HasMaxLength(10);

                entity.Property(e => e.RemitAddr1).HasMaxLength(100);

                entity.Property(e => e.RemitAddr2).HasMaxLength(100);

                entity.Property(e => e.RemitAddr3).HasMaxLength(100);

                entity.Property(e => e.RemitCity).HasMaxLength(100);

                entity.Property(e => e.RemitCountry).HasMaxLength(100);

                entity.Property(e => e.RemitPinCode).HasMaxLength(10);

                entity.Property(e => e.RemitState).HasMaxLength(50);

                entity.Property(e => e.State).HasMaxLength(50);

                entity.Property(e => e.TaxId).HasMaxLength(30);

                entity.Property(e => e.TaxRate).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.Tel).HasMaxLength(20);

                entity.HasOne(d => d.CreatedBy)
                    .WithMany(p => p.LawFirmOfficeCreatedBies)
                    .HasForeignKey(d => d.CreatedById)
                    .OnDelete(DeleteBehavior.ClientSetNull);

                entity.HasOne(d => d.LawFirm)
                    .WithMany(p => p.LawFirmOffices)
                    .HasForeignKey(d => d.LawFirmId)
                    .OnDelete(DeleteBehavior.ClientSetNull);

                entity.HasOne(d => d.ModifiedBy)
                    .WithMany(p => p.LawFirmOfficeModifiedBies)
                    .HasForeignKey(d => d.ModifiedById)
                    .OnDelete(DeleteBehavior.ClientSetNull);
            });

            modelBuilder.Entity<LawFirmRate>(entity =>
            {
                entity.HasNoKey();

                entity.HasIndex(e => e.ClientId, "IX_Client_Id");

                entity.HasIndex(e => e.LawFirmId, "IX_LawFirm_Id");

                entity.HasIndex(e => e.ProductLineId, "IX_ProductLine_Id");

                entity.Property(e => e.Associate).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.Clerk).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.ClientId).HasColumnName("Client_Id");

                entity.Property(e => e.Id).ValueGeneratedOnAdd();

                entity.Property(e => e.LawFirmId).HasColumnName("LawFirm_Id");

                entity.Property(e => e.LegalAssistant).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.OfCounsel).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.Paralegal).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.Partner).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.ProductLineId).HasColumnName("ProductLine_Id");

                entity.Property(e => e.RateFrom).HasColumnType("datetime");

                entity.Property(e => e.Secretary).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.SeniorAssociate).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.SeniorPartner).HasColumnType("decimal(18, 2)");

                entity.HasOne(d => d.Client)
                    .WithMany()
                    .HasForeignKey(d => d.ClientId);

                entity.HasOne(d => d.LawFirm)
                    .WithMany()
                    .HasForeignKey(d => d.LawFirmId)
                    .OnDelete(DeleteBehavior.ClientSetNull);

                entity.HasOne(d => d.ProductLine)
                    .WithMany()
                    .HasForeignKey(d => d.ProductLineId);
            });

            modelBuilder.Entity<LawfirmClient>(entity =>
            {
                entity.HasIndex(e => e.ClientId, "IX_Client_Id");

                entity.HasIndex(e => e.CreatedById, "IX_CreatedBy_Id");

                entity.HasIndex(e => e.LawFirmId, "IX_LawFirm_Id");

                entity.HasIndex(e => e.ModifiedById, "IX_ModifiedBy_Id");

                entity.Property(e => e.Addr1).HasMaxLength(100);

                entity.Property(e => e.Addr2).HasMaxLength(100);

                entity.Property(e => e.Addr3).HasMaxLength(100);

                entity.Property(e => e.City).HasMaxLength(100);

                entity.Property(e => e.ClientId).HasColumnName("Client_Id");

                entity.Property(e => e.Country)
                    .IsRequired()
                    .HasMaxLength(3);

                entity.Property(e => e.CreatedById).HasColumnName("CreatedBy_Id");

                entity.Property(e => e.CreatedTime).HasColumnType("datetime");

                entity.Property(e => e.Ebiller)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("EBiller");

                entity.Property(e => e.EbillerAutomationStatus).HasColumnName("EBillerAutomationStatus");

                entity.Property(e => e.EbillerComments)
                    .HasMaxLength(2000)
                    .IsUnicode(false)
                    .HasColumnName("EBillerComments");

                entity.Property(e => e.EbillerEmail)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("EBillerEmail");

                entity.Property(e => e.EbillerPassword)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("EBillerPassword");

                entity.Property(e => e.EbillerReference1)
                    .HasMaxLength(100)
                    .HasColumnName("EBillerReference1");

                entity.Property(e => e.EbillerReference2)
                    .HasMaxLength(100)
                    .HasColumnName("EBillerReference2");

                entity.Property(e => e.EbillerStatus)
                    .HasMaxLength(200)
                    .HasColumnName("EBillerStatus");

                entity.Property(e => e.EbillerStatusChangeDate)
                    .HasColumnType("datetime")
                    .HasColumnName("EBillerStatusChangeDate");

                entity.Property(e => e.EbillerStatusCheckDate)
                    .HasColumnType("datetime")
                    .HasColumnName("EBillerStatusCheckDate");

                entity.Property(e => e.EbillerStatusComments)
                    .HasMaxLength(2000)
                    .HasColumnName("EBillerStatusComments");

                entity.Property(e => e.EbillerUrl)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("EBillerURL");

                entity.Property(e => e.EbillerUserName)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("EBillerUserName");

                entity.Property(e => e.Email).HasMaxLength(100);

                entity.Property(e => e.Fax).HasMaxLength(20);

                entity.Property(e => e.Icrverbiage)
                    .HasMaxLength(2000)
                    .IsUnicode(false)
                    .HasColumnName("ICRVerbiage");

                entity.Property(e => e.InvoicePrepExpRate).HasColumnType("decimal(18, 3)");

                entity.Property(e => e.InvoicePrepRate).HasColumnType("decimal(18, 3)");

                entity.Property(e => e.LawFirmEbillerId).HasColumnName("LawFirmEBiller_Id");

                entity.Property(e => e.LawFirmId).HasColumnName("LawFirm_Id");

                entity.Property(e => e.MatterMatchingField)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ModifiedById).HasColumnName("ModifiedBy_Id");

                entity.Property(e => e.ModifiedTime).HasColumnType("datetime");

                entity.Property(e => e.PinCode).HasMaxLength(10);

                entity.Property(e => e.State).HasMaxLength(50);

                entity.Property(e => e.SupportedInvoiceFormat).HasMaxLength(100);

                entity.Property(e => e.SupportedOutputInvoiceFormat).HasMaxLength(100);

                entity.Property(e => e.SupportedPrebillInputFormat).HasMaxLength(100);

                entity.Property(e => e.TaxId).HasMaxLength(50);

                entity.Property(e => e.Tel).HasMaxLength(20);

                entity.HasOne(d => d.Client)
                    .WithMany(p => p.LawfirmClients)
                    .HasForeignKey(d => d.ClientId)
                    .OnDelete(DeleteBehavior.ClientSetNull);

                entity.HasOne(d => d.CreatedBy)
                    .WithMany(p => p.LawfirmClientCreatedBies)
                    .HasForeignKey(d => d.CreatedById)
                    .OnDelete(DeleteBehavior.ClientSetNull);

                entity.HasOne(d => d.LawFirmEbiller)
                    .WithMany(p => p.LawfirmClients)
                    .HasForeignKey(d => d.LawFirmEbillerId)
                    .HasConstraintName("fk_lawfirmeclients_lawfirmebiller");

                entity.HasOne(d => d.LawFirm)
                    .WithMany(p => p.LawfirmClients)
                    .HasForeignKey(d => d.LawFirmId)
                    .OnDelete(DeleteBehavior.ClientSetNull);

                entity.HasOne(d => d.ModifiedBy)
                    .WithMany(p => p.LawfirmClientModifiedBies)
                    .HasForeignKey(d => d.ModifiedById)
                    .OnDelete(DeleteBehavior.ClientSetNull);
            });

            modelBuilder.Entity<LawfirmInvoiceUpload>(entity =>
            {
                entity.Property(e => e.ClientId).HasColumnName("Client_Id");

                entity.Property(e => e.CreatedTime).HasColumnType("datetime");

                entity.Property(e => e.InvoiceDocumentFileNames).HasMaxLength(2000);

                entity.Property(e => e.InvoiceFileName).HasMaxLength(255);

                entity.Property(e => e.LawFirmId).HasColumnName("LawFirm_Id");

                entity.Property(e => e.UserId).HasColumnName("User_Id");
            });

            modelBuilder.Entity<LineItemCommunication>(entity =>
            {
                entity.HasIndex(e => e.AddressedToUserId, "IX_AddressedToUser_Id");

                entity.HasIndex(e => e.EscalatedBy1, "IX_Escalated_By1");

                entity.HasIndex(e => e.EscalatedBy2, "IX_Escalated_By2");

                entity.HasIndex(e => e.InvoiceLineItemId, "IX_InvoiceLineItem_Id");

                entity.HasIndex(e => e.WrittenByUserId, "IX_WrittenByUser_id");

                entity.Property(e => e.AddressedToContactId).HasColumnName("AddressedToContact_id");

                entity.Property(e => e.AddressedToUserId).HasColumnName("AddressedToUser_Id");

                entity.Property(e => e.Cc)
                    .HasMaxLength(1000)
                    .IsUnicode(false)
                    .HasColumnName("CC");

                entity.Property(e => e.EscalateResponseReceivedDate)
                    .HasColumnType("datetime")
                    .HasColumnName("Escalate_Response_Received_Date");

                entity.Property(e => e.EscalateResponseText).IsUnicode(false);

                entity.Property(e => e.EscalatedBy1)
                    .HasMaxLength(1000)
                    .IsUnicode(false)
                    .HasColumnName("Escalated_By1");

                entity.Property(e => e.EscalatedBy2)
                    .HasMaxLength(1000)
                    .IsUnicode(false)
                    .HasColumnName("Escalated_By2");

                entity.Property(e => e.EscalatedDate1)
                    .HasColumnType("datetime")
                    .HasColumnName("Escalated_Date1");

                entity.Property(e => e.EscalatedDate2)
                    .HasColumnType("datetime")
                    .HasColumnName("Escalated_Date2");

                entity.Property(e => e.EscalatedUniqueId1)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("EscalatedUniqueID1");

                entity.Property(e => e.EscalatedUniqueId2)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("EscalatedUniqueID2");

                entity.Property(e => e.FollowUpResponseReceivedDate)
                    .HasColumnType("datetime")
                    .HasColumnName("FollowUp_Response_Received_Date");

                entity.Property(e => e.FollowupBy1)
                    .HasMaxLength(1000)
                    .IsUnicode(false)
                    .HasColumnName("Followup_By1");

                entity.Property(e => e.FollowupBy2)
                    .HasMaxLength(1000)
                    .IsUnicode(false)
                    .HasColumnName("Followup_By2");

                entity.Property(e => e.FollowupDate1)
                    .HasColumnType("datetime")
                    .HasColumnName("Followup_Date1");

                entity.Property(e => e.FollowupDate2)
                    .HasColumnType("datetime")
                    .HasColumnName("Followup_Date2");

                entity.Property(e => e.FollowupResponseText).IsUnicode(false);

                entity.Property(e => e.FollowupUniqueId1)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("FollowupUniqueID1");

                entity.Property(e => e.FollowupUniqueId2)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("FollowupUniqueID2");

                entity.Property(e => e.InvoiceLineItemId).HasColumnName("InvoiceLineItem_Id");

                entity.Property(e => e.IsPrivateToIps).HasColumnName("IsPrivateToIPS");

                entity.Property(e => e.QueryAttachments).HasMaxLength(4000);

                entity.Property(e => e.ResponseReceivedDate)
                    .HasColumnType("datetime")
                    .HasColumnName("Response_Received_Date");

                entity.Property(e => e.ResponseText).IsUnicode(false);

                entity.Property(e => e.SendQueryUniqueId)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.StatusChangeDate)
                    .HasColumnType("datetime")
                    .HasColumnName("Status_Change_Date");

                entity.Property(e => e.WrittenByUserId).HasColumnName("WrittenByUser_id");

                entity.Property(e => e.WrittenDate).HasColumnType("datetime");

                entity.HasOne(d => d.AddressedToUser)
                    .WithMany(p => p.LineItemCommunicationAddressedToUsers)
                    .HasForeignKey(d => d.AddressedToUserId);

                entity.HasOne(d => d.InvoiceLineItem)
                    .WithMany(p => p.LineItemCommunications)
                    .HasForeignKey(d => d.InvoiceLineItemId)
                    .OnDelete(DeleteBehavior.ClientSetNull);

                entity.HasOne(d => d.WrittenByUser)
                    .WithMany(p => p.LineItemCommunicationWrittenByUsers)
                    .HasForeignKey(d => d.WrittenByUserId)
                    .OnDelete(DeleteBehavior.ClientSetNull);
            });

            modelBuilder.Entity<LineItemCommunicationsBackup30apr2019>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("LineItemCommunicationsBackup_30Apr2019");

                entity.Property(e => e.AddressedToContactId).HasColumnName("AddressedToContact_id");

                entity.Property(e => e.AddressedToUserId).HasColumnName("AddressedToUser_Id");

                entity.Property(e => e.Cc)
                    .HasMaxLength(1000)
                    .IsUnicode(false)
                    .HasColumnName("CC");

                entity.Property(e => e.EscalateResponseReceivedDate)
                    .HasColumnType("datetime")
                    .HasColumnName("Escalate_Response_Received_Date");

                entity.Property(e => e.EscalateResponseText).IsUnicode(false);

                entity.Property(e => e.EscalatedBy1)
                    .HasMaxLength(1000)
                    .IsUnicode(false)
                    .HasColumnName("Escalated_By1");

                entity.Property(e => e.EscalatedBy2)
                    .HasMaxLength(1000)
                    .IsUnicode(false)
                    .HasColumnName("Escalated_By2");

                entity.Property(e => e.EscalatedDate1)
                    .HasColumnType("datetime")
                    .HasColumnName("Escalated_Date1");

                entity.Property(e => e.EscalatedDate2)
                    .HasColumnType("datetime")
                    .HasColumnName("Escalated_Date2");

                entity.Property(e => e.EscalatedUniqueId1)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("EscalatedUniqueID1");

                entity.Property(e => e.EscalatedUniqueId2)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("EscalatedUniqueID2");

                entity.Property(e => e.FollowUpResponseReceivedDate)
                    .HasColumnType("datetime")
                    .HasColumnName("FollowUp_Response_Received_Date");

                entity.Property(e => e.FollowupBy1)
                    .HasMaxLength(1000)
                    .IsUnicode(false)
                    .HasColumnName("Followup_By1");

                entity.Property(e => e.FollowupBy2)
                    .HasMaxLength(1000)
                    .IsUnicode(false)
                    .HasColumnName("Followup_By2");

                entity.Property(e => e.FollowupDate1)
                    .HasColumnType("datetime")
                    .HasColumnName("Followup_Date1");

                entity.Property(e => e.FollowupDate2)
                    .HasColumnType("datetime")
                    .HasColumnName("Followup_Date2");

                entity.Property(e => e.FollowupResponseText).IsUnicode(false);

                entity.Property(e => e.FollowupUniqueId1)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("FollowupUniqueID1");

                entity.Property(e => e.FollowupUniqueId2)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("FollowupUniqueID2");

                entity.Property(e => e.Id).ValueGeneratedOnAdd();

                entity.Property(e => e.InvoiceLineItemId).HasColumnName("InvoiceLineItem_Id");

                entity.Property(e => e.IsPrivateToIps).HasColumnName("IsPrivateToIPS");

                entity.Property(e => e.ResponseReceivedDate)
                    .HasColumnType("datetime")
                    .HasColumnName("Response_Received_Date");

                entity.Property(e => e.ResponseText).IsUnicode(false);

                entity.Property(e => e.SendQueryUniqueId)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.StatusChangeDate)
                    .HasColumnType("datetime")
                    .HasColumnName("Status_Change_Date");

                entity.Property(e => e.WrittenByUserId).HasColumnName("WrittenByUser_id");

                entity.Property(e => e.WrittenDate).HasColumnType("datetime");
            });

            modelBuilder.Entity<LineItemCommunicationstemp>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("LineItemCommunicationstemp");

                entity.Property(e => e.AddressedToContactId).HasColumnName("AddressedToContact_id");

                entity.Property(e => e.AddressedToUserId).HasColumnName("AddressedToUser_Id");

                entity.Property(e => e.Cc)
                    .HasMaxLength(1000)
                    .IsUnicode(false)
                    .HasColumnName("CC");

                entity.Property(e => e.EscalateResponseText).IsUnicode(false);

                entity.Property(e => e.EscalatedBy1)
                    .HasMaxLength(1000)
                    .IsUnicode(false)
                    .HasColumnName("Escalated_By1");

                entity.Property(e => e.EscalatedBy2)
                    .HasMaxLength(1000)
                    .IsUnicode(false)
                    .HasColumnName("Escalated_By2");

                entity.Property(e => e.EscalatedDate1)
                    .HasColumnType("datetime")
                    .HasColumnName("Escalated_Date1");

                entity.Property(e => e.EscalatedDate2)
                    .HasColumnType("datetime")
                    .HasColumnName("Escalated_Date2");

                entity.Property(e => e.EscalatedUniqueId1)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("EscalatedUniqueID1");

                entity.Property(e => e.EscalatedUniqueId2)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("EscalatedUniqueID2");

                entity.Property(e => e.FollowupBy1)
                    .HasMaxLength(1000)
                    .IsUnicode(false)
                    .HasColumnName("Followup_By1");

                entity.Property(e => e.FollowupBy2)
                    .HasMaxLength(1000)
                    .IsUnicode(false)
                    .HasColumnName("Followup_By2");

                entity.Property(e => e.FollowupDate1)
                    .HasColumnType("datetime")
                    .HasColumnName("Followup_Date1");

                entity.Property(e => e.FollowupDate2)
                    .HasColumnType("datetime")
                    .HasColumnName("Followup_Date2");

                entity.Property(e => e.FollowupResponseText).IsUnicode(false);

                entity.Property(e => e.FollowupUniqueId1)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("FollowupUniqueID1");

                entity.Property(e => e.FollowupUniqueId2)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("FollowupUniqueID2");

                entity.Property(e => e.Id).ValueGeneratedOnAdd();

                entity.Property(e => e.InvoiceLineItemId).HasColumnName("InvoiceLineItem_Id");

                entity.Property(e => e.IsPrivateToIps).HasColumnName("IsPrivateToIPS");

                entity.Property(e => e.ResponseText).IsUnicode(false);

                entity.Property(e => e.SendQueryUniqueId)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.WrittenByUserId).HasColumnName("WrittenByUser_id");

                entity.Property(e => e.WrittenDate).HasColumnType("datetime");
            });

            modelBuilder.Entity<Log>(entity =>
            {
                entity.Property(e => e.EntityId).HasColumnName("Entity_Id");

                entity.Property(e => e.LogDate).HasColumnType("datetime");

                entity.Property(e => e.Narration).HasMaxLength(2000);

                entity.Property(e => e.UserId).HasColumnName("User_Id");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.Logs)
                    .HasForeignKey(d => d.UserId)
                    .HasConstraintName("FK_Logs_Users");
            });

            modelBuilder.Entity<LossType>(entity =>
            {
                entity.HasNoKey();

                entity.Property(e => e.CategoryId).HasColumnName("CategoryID");

                entity.Property(e => e.LossTypeId).ValueGeneratedOnAdd();

                entity.Property(e => e.LossTypeName)
                    .HasMaxLength(200)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<LossTypeCategory>(entity =>
            {
                entity.HasNoKey();

                entity.Property(e => e.CategoryId)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("CategoryID");

                entity.Property(e => e.CategoryName)
                    .HasMaxLength(200)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<MasterAppealQueries1>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("MasterAppealQueries1");

                entity.Property(e => e.Code)
                    .HasMaxLength(60)
                    .IsUnicode(false);

                entity.Property(e => e.Id).ValueGeneratedOnAdd();

                entity.Property(e => e.Query)
                    .IsRequired()
                    .HasMaxLength(1000);
            });

            modelBuilder.Entity<MasterAppealQuery>(entity =>
            {
                entity.Property(e => e.Code)
                    .HasMaxLength(60)
                    .IsUnicode(false);

                entity.Property(e => e.Query)
                    .IsRequired()
                    .HasMaxLength(1000);
            });

            modelBuilder.Entity<MasterBillingType>(entity =>
            {
                entity.Property(e => e.BillingCode)
                    .IsRequired()
                    .HasMaxLength(255);
            });

            modelBuilder.Entity<MasterContactType>(entity =>
            {
                entity.Property(e => e.Description)
                    .IsRequired()
                    .HasMaxLength(500);

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(100);
            });

            modelBuilder.Entity<MasterCountry>(entity =>
            {
                entity.Property(e => e.Code)
                    .IsRequired()
                    .HasMaxLength(3);

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<MasterCurrency>(entity =>
            {
                entity.HasIndex(e => e.MasterCountryId, "IX_MasterCountry_Id");

                entity.Property(e => e.Code)
                    .IsRequired()
                    .HasMaxLength(3);

                entity.Property(e => e.MasterCountryId).HasColumnName("MasterCountry_Id");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.HasOne(d => d.MasterCountry)
                    .WithMany(p => p.MasterCurrencies)
                    .HasForeignKey(d => d.MasterCountryId);
            });

            modelBuilder.Entity<MasterDocumentCategory>(entity =>
            {
                entity.HasIndex(e => e.CreatedById, "IX_CreatedBy_Id");

                entity.HasIndex(e => e.ModifiedById, "IX_ModifiedBy_Id");

                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.CreatedById).HasColumnName("CreatedBy_Id");

                entity.Property(e => e.CreatedTime).HasColumnType("datetime");

                entity.Property(e => e.Description)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.Property(e => e.ModifiedById).HasColumnName("ModifiedBy_Id");

                entity.Property(e => e.ModifiedTime).HasColumnType("datetime");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.HasOne(d => d.CreatedBy)
                    .WithMany(p => p.MasterDocumentCategoryCreatedBies)
                    .HasForeignKey(d => d.CreatedById)
                    .OnDelete(DeleteBehavior.ClientSetNull);

                entity.HasOne(d => d.ModifiedBy)
                    .WithMany(p => p.MasterDocumentCategoryModifiedBies)
                    .HasForeignKey(d => d.ModifiedById)
                    .OnDelete(DeleteBehavior.ClientSetNull);
            });

            modelBuilder.Entity<MasterEbiller>(entity =>
            {
                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.AutomationId).HasMaxLength(100);

                entity.Property(e => e.AutomationUrl).HasMaxLength(150);

                entity.Property(e => e.Comments).HasMaxLength(2000);

                entity.Property(e => e.EbillerFamily)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.Property(e => e.Email).HasMaxLength(150);

                entity.Property(e => e.ExtraInfo1).HasMaxLength(100);

                entity.Property(e => e.ExtraInfo2).HasMaxLength(100);

                entity.Property(e => e.IsLineLevelParserAvailable).HasDefaultValueSql("((0))");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.Property(e => e.Port).HasMaxLength(5);

                entity.Property(e => e.Url).HasMaxLength(150);
            });

            modelBuilder.Entity<MasterEbillerStatus>(entity =>
            {
                entity.ToTable("MasterEBillerStatus");

                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.MasterEbillerId).HasColumnName("MasterEBiller_Id");

                entity.Property(e => e.StatusName)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.HasOne(d => d.MasterEbiller)
                    .WithMany(p => p.MasterEbillerStatuses)
                    .HasForeignKey(d => d.MasterEbillerId)
                    .HasConstraintName("fk_MasterEBillerStatus_masterebiller");
            });

            modelBuilder.Entity<MasterInjurySeverityCode>(entity =>
            {
                entity.HasNoKey();

                entity.Property(e => e.Id).ValueGeneratedOnAdd();

                entity.Property(e => e.InjurySeverityCode)
                    .IsRequired()
                    .HasMaxLength(255);
            });

            modelBuilder.Entity<MasterInjuryType>(entity =>
            {
                entity.HasNoKey();

                entity.Property(e => e.Id).ValueGeneratedOnAdd();

                entity.Property(e => e.TypeName)
                    .IsRequired()
                    .HasMaxLength(255);
            });

            modelBuilder.Entity<MasterInvoiceAppealStatus>(entity =>
            {
                entity.HasKey(e => e.AppealStatusId)
                    .HasName("PK__MasterIn__BBAD81E1473C8FC7");

                entity.ToTable("MasterInvoiceAppealStatus");

                entity.Property(e => e.AppealStatusId).ValueGeneratedNever();

                entity.Property(e => e.AppealStatusName)
                    .IsRequired()
                    .HasMaxLength(100);
            });

            modelBuilder.Entity<MasterInvoiceStatus>(entity =>
            {
                entity.HasKey(e => e.StatusId)
                    .HasName("PK__MasterIn__C8EE2063436BFEE3");

                entity.ToTable("MasterInvoiceStatus");

                entity.Property(e => e.StatusId).ValueGeneratedNever();

                entity.Property(e => e.StatusName)
                    .IsRequired()
                    .HasMaxLength(100);
            });

            modelBuilder.Entity<MasterLawFirmTimeAndBillingSystem>(entity =>
            {
                entity.Property(e => e.Name).HasMaxLength(255);
            });

            modelBuilder.Entity<MasterLitigationVenue>(entity =>
            {
                entity.HasNoKey();

                entity.Property(e => e.Id).ValueGeneratedOnAdd();

                entity.Property(e => e.LitigationVenueName)
                    .IsRequired()
                    .HasMaxLength(255);
            });

            modelBuilder.Entity<MasterLossType>(entity =>
            {
                entity.HasNoKey();

                entity.Property(e => e.Id).ValueGeneratedOnAdd();

                entity.Property(e => e.TypeName)
                    .IsRequired()
                    .HasMaxLength(255);
            });

            modelBuilder.Entity<MasterMatterCaseType>(entity =>
            {
                entity.HasNoKey();

                entity.Property(e => e.CaseType)
                    .IsRequired()
                    .HasMaxLength(255);

                entity.Property(e => e.Id).ValueGeneratedOnAdd();
            });

            modelBuilder.Entity<MasterMatterDispositionType>(entity =>
            {
                entity.HasNoKey();

                entity.Property(e => e.DispositionType)
                    .IsRequired()
                    .HasMaxLength(255);

                entity.Property(e => e.Id).ValueGeneratedOnAdd();
            });

            modelBuilder.Entity<MasterMatterIndemnityType>(entity =>
            {
                entity.HasNoKey();

                entity.Property(e => e.Id).ValueGeneratedOnAdd();

                entity.Property(e => e.IndemnityType)
                    .IsRequired()
                    .HasMaxLength(255);
            });

            modelBuilder.Entity<MasterMatterLitigationOrOtherCaseType>(entity =>
            {
                entity.HasNoKey();

                entity.Property(e => e.CaseType)
                    .IsRequired()
                    .HasMaxLength(255);

                entity.Property(e => e.Id).ValueGeneratedOnAdd();
            });

            modelBuilder.Entity<MasterMatterQuestion>(entity =>
            {
                entity.HasNoKey();

                entity.Property(e => e.Id).ValueGeneratedOnAdd();

                entity.Property(e => e.Question)
                    .IsRequired()
                    .HasMaxLength(255);
            });

            modelBuilder.Entity<MasterMatterWorkersCompIndemnityType>(entity =>
            {
                entity.HasNoKey();

                entity.Property(e => e.Id).ValueGeneratedOnAdd();

                entity.Property(e => e.IndemnityType)
                    .IsRequired()
                    .HasMaxLength(255);
            });

            modelBuilder.Entity<MasterMatterWorkersCompOtherIndemnityType>(entity =>
            {
                entity.HasNoKey();

                entity.Property(e => e.Id).ValueGeneratedOnAdd();

                entity.Property(e => e.IndemnityType)
                    .IsRequired()
                    .HasMaxLength(255);
            });

            modelBuilder.Entity<MasterPreparationNote>(entity =>
            {
                entity.Property(e => e.PreparationNote)
                    .IsRequired()
                    .HasMaxLength(1000);
            });

            modelBuilder.Entity<MasterProductLine>(entity =>
            {
                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(255);
            });

            modelBuilder.Entity<MasterQueries1>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("MasterQueries1");

                entity.Property(e => e.Code)
                    .HasMaxLength(60)
                    .IsUnicode(false);

                entity.Property(e => e.Id).ValueGeneratedOnAdd();

                entity.Property(e => e.Query)
                    .IsRequired()
                    .HasMaxLength(1000);
            });

            modelBuilder.Entity<MasterQuery>(entity =>
            {
                entity.Property(e => e.Code)
                    .HasMaxLength(60)
                    .IsUnicode(false);

                entity.Property(e => e.Query)
                    .IsRequired()
                    .HasMaxLength(1000);
            });

            modelBuilder.Entity<MasterReport>(entity =>
            {
                entity.Property(e => e.ActionMethod)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.Area).HasMaxLength(50);

                entity.Property(e => e.Controller)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.Description).HasMaxLength(2000);

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(255);

                entity.Property(e => e.ReportCategoryId).HasColumnName("ReportCategory_Id");

                entity.Property(e => e.ReportUrl).HasMaxLength(2000);

                entity.HasOne(d => d.ReportCategory)
                    .WithMany(p => p.MasterReports)
                    .HasForeignKey(d => d.ReportCategoryId);
            });

            modelBuilder.Entity<MasterReportCategory>(entity =>
            {
                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(255);
            });

            modelBuilder.Entity<MasterRole>(entity =>
            {
                entity.Property(e => e.Description)
                    .IsRequired()
                    .HasMaxLength(255);

                entity.Property(e => e.DisplayName)
                    .IsRequired()
                    .HasMaxLength(20);

                entity.Property(e => e.IsIpsuser).HasColumnName("IsIPSUser");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(20);
            });

            modelBuilder.Entity<MasterState>(entity =>
            {
                entity.HasIndex(e => e.MasterCountryId, "IX_MasterCountry_Id");

                entity.Property(e => e.Code)
                    .IsRequired()
                    .HasMaxLength(3);

                entity.Property(e => e.MasterCountryId).HasColumnName("MasterCountry_Id");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.HasOne(d => d.MasterCountry)
                    .WithMany(p => p.MasterStates)
                    .HasForeignKey(d => d.MasterCountryId)
                    .OnDelete(DeleteBehavior.ClientSetNull);
            });

            modelBuilder.Entity<MasterSuitCounty>(entity =>
            {
                entity.HasNoKey();

                entity.Property(e => e.CountyName)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.Id).ValueGeneratedOnAdd();

                entity.Property(e => e.StateId).HasColumnName("StateID");
            });

            modelBuilder.Entity<MasterSuitState>(entity =>
            {
                entity.HasNoKey();

                entity.Property(e => e.Id).ValueGeneratedOnAdd();

                entity.Property(e => e.StateName)
                    .IsRequired()
                    .HasMaxLength(255);
            });

            modelBuilder.Entity<MasterTaskName>(entity =>
            {
                entity.HasKey(e => e.TaskName)
                    .HasName("PK__MasterTa__1E0558885772F790");

                entity.Property(e => e.TaskName).HasMaxLength(100);

                entity.Property(e => e.DisplayName)
                    .IsRequired()
                    .HasMaxLength(100);
            });

            modelBuilder.Entity<MasterTicketArea>(entity =>
            {
                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(100);
            });

            modelBuilder.Entity<MasterTimekeeperLevel>(entity =>
            {
                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(60);

                entity.Property(e => e.TimeKeeperMappingLevel).HasMaxLength(120);
            });

            modelBuilder.Entity<MasterUserStatus>(entity =>
            {
                entity.ToTable("MasterUserStatus");

                entity.Property(e => e.Status)
                    .IsRequired()
                    .HasMaxLength(20);
            });

            modelBuilder.Entity<MasterUtbmsCodeSet>(entity =>
            {
                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(20);
            });

            modelBuilder.Entity<MasterUtbmsCodeSetDetail>(entity =>
            {
                entity.Property(e => e.MasterUtbmsCodeSetId).HasColumnName("MasterUtbmsCodeSet_Id");

                entity.Property(e => e.Name).HasMaxLength(200);

                entity.Property(e => e.PhaseCode).HasMaxLength(200);

                entity.Property(e => e.PhaseDescription).HasMaxLength(3000);

                entity.Property(e => e.PhaseName).HasMaxLength(200);

                entity.Property(e => e.TaskCode).HasMaxLength(200);

                entity.Property(e => e.TaskDescription).HasMaxLength(3000);

                entity.Property(e => e.TaskName).HasMaxLength(200);

                entity.HasOne(d => d.MasterUtbmsCodeSet)
                    .WithMany(p => p.MasterUtbmsCodeSetDetails)
                    .HasForeignKey(d => d.MasterUtbmsCodeSetId);
            });

            modelBuilder.Entity<Matter>(entity =>
            {
                entity.HasIndex(e => e.BillingTypeId, "IX_BillingType_Id");

                entity.HasIndex(e => e.ClientId, "IX_Client_Id");

                entity.HasIndex(e => e.CreatedById, "IX_CreatedBy_Id");

                entity.HasIndex(e => e.LawFirmId, "IX_LawFirm_Id");

                entity.HasIndex(e => e.MasterUtbmsCodeSetId, "IX_MasterUtbmsCodeSet_Id");

                entity.HasIndex(e => e.ModifiedById, "IX_ModifiedBy_Id");

                entity.HasIndex(e => e.ProductLineId, "IX_ProductLine_Id");

                entity.Property(e => e.AddlReferenceNo).HasMaxLength(100);

                entity.Property(e => e.BillingTypeId).HasColumnName("BillingType_Id");

                entity.Property(e => e.CaseTypeId).HasColumnName("CaseTypeID");

                entity.Property(e => e.ClaimAmount).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.ClaimEndDate).HasColumnType("datetime");

                entity.Property(e => e.ClientId).HasColumnName("Client_Id");

                entity.Property(e => e.ClientMatterId)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.CreatedById).HasColumnName("CreatedBy_Id");

                entity.Property(e => e.CreatedTime).HasColumnType("datetime");

                entity.Property(e => e.DateAssigned).HasColumnType("datetime");

                entity.Property(e => e.DateClosed).HasColumnType("datetime");

                entity.Property(e => e.DateOfLoss).HasColumnType("datetime");

                entity.Property(e => e.Description).HasMaxLength(1000);

                entity.Property(e => e.DispositionAmount).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.DispositionTypeId).HasColumnName("DispositionTypeID");

                entity.Property(e => e.EbillerReference1)
                    .HasMaxLength(100)
                    .HasColumnName("EBillerReference1");

                entity.Property(e => e.EbillerReference2)
                    .HasMaxLength(100)
                    .HasColumnName("EBillerReference2");

                entity.Property(e => e.EbillerStatus)
                    .HasMaxLength(200)
                    .HasColumnName("EBillerStatus");

                entity.Property(e => e.EbillerStatusChangeDate)
                    .HasColumnType("datetime")
                    .HasColumnName("EBillerStatusChangeDate");

                entity.Property(e => e.EbillerStatusCheckDate)
                    .HasColumnType("datetime")
                    .HasColumnName("EBillerStatusCheckDate");

                entity.Property(e => e.EbillerStatusComments)
                    .HasMaxLength(2000)
                    .HasColumnName("EBillerStatusComments");

                entity.Property(e => e.IndemnityTypeId).HasColumnName("IndemnityTypeID");

                entity.Property(e => e.InitialEstimateOfExposure).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.InjurySeverityCodeId).HasColumnName("InjurySeverityCodeID");

                entity.Property(e => e.IsSplitBill).HasDefaultValueSql("((0))");

                entity.Property(e => e.Jurisdiction).HasMaxLength(50);

                entity.Property(e => e.LawFirmId).HasColumnName("LawFirm_Id");

                entity.Property(e => e.LawFirmMatterId).HasMaxLength(50);

                entity.Property(e => e.LitigationOrOtherCaseTypeId).HasColumnName("LitigationOrOtherCaseTypeID");

                entity.Property(e => e.LitigationVenueId).HasColumnName("LitigationVenueID");

                entity.Property(e => e.MasterUtbmsCodeSetId).HasColumnName("MasterUtbmsCodeSet_Id");

                entity.Property(e => e.ModifiedById).HasColumnName("ModifiedBy_Id");

                entity.Property(e => e.ModifiedTime).HasColumnType("datetime");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.Property(e => e.PersonalInjuryIndemnityFigure).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.ProductLineId).HasColumnName("ProductLine_Id");

                entity.Property(e => e.ProductLineOtherText).HasMaxLength(100);

                entity.Property(e => e.PropertyDamageIndemnityFigure).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.ResponsibleAttorney)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.SettlementAmount).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.SuitCountry)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.SuitCountyId).HasColumnName("SuitCountyID");

                entity.Property(e => e.SuitStateId).HasColumnName("SuitStateID");

                entity.Property(e => e.TotalIndemnityFigure).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.TypeOfInjuryId).HasColumnName("TypeOfInjuryID");

                entity.Property(e => e.TypeOfLossId).HasColumnName("TypeOfLossID");

                entity.Property(e => e.VerdictAmount).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.WorkerCompDisabilityPercentage).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.WorkerCompLostEarnings).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.WorkerCompMedicals).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.WorkersCompIndemnityTypeId).HasColumnName("WorkersCompIndemnityTypeID");

                entity.Property(e => e.WorkersCompOtherIndemnityTypeId).HasColumnName("WorkersCompOtherIndemnityTypeID");

                entity.HasOne(d => d.BillingType)
                    .WithMany(p => p.Matters)
                    .HasForeignKey(d => d.BillingTypeId);

                entity.HasOne(d => d.Client)
                    .WithMany(p => p.Matters)
                    .HasForeignKey(d => d.ClientId)
                    .OnDelete(DeleteBehavior.ClientSetNull);

                entity.HasOne(d => d.CreatedBy)
                    .WithMany(p => p.MatterCreatedBies)
                    .HasForeignKey(d => d.CreatedById)
                    .OnDelete(DeleteBehavior.ClientSetNull);

                entity.HasOne(d => d.LawFirm)
                    .WithMany(p => p.Matters)
                    .HasForeignKey(d => d.LawFirmId)
                    .OnDelete(DeleteBehavior.ClientSetNull);

                entity.HasOne(d => d.LawFirmLocation)
                    .WithMany(p => p.Matters)
                    .HasForeignKey(d => d.LawFirmLocationId)
                    .HasConstraintName("FK_LawFirmOffices_Matters");

                entity.HasOne(d => d.MasterUtbmsCodeSet)
                    .WithMany(p => p.Matters)
                    .HasForeignKey(d => d.MasterUtbmsCodeSetId)
                    .OnDelete(DeleteBehavior.ClientSetNull);

                entity.HasOne(d => d.ModifiedBy)
                    .WithMany(p => p.MatterModifiedBies)
                    .HasForeignKey(d => d.ModifiedById)
                    .OnDelete(DeleteBehavior.ClientSetNull);

                entity.HasOne(d => d.ProductLine)
                    .WithMany(p => p.Matters)
                    .HasForeignKey(d => d.ProductLineId);
            });

            modelBuilder.Entity<MatterBudget>(entity =>
            {
                entity.Property(e => e.CreatedById).HasColumnName("CreatedBy_Id");

                entity.Property(e => e.Date).HasColumnType("datetime");

                entity.Property(e => e.Description).HasMaxLength(1000);

                entity.Property(e => e.EbillerReference1)
                    .HasMaxLength(100)
                    .HasColumnName("EBillerReference1");

                entity.Property(e => e.EbillerReference2)
                    .HasMaxLength(100)
                    .HasColumnName("EBillerReference2");

                entity.Property(e => e.EbillerStatus)
                    .HasMaxLength(200)
                    .HasColumnName("EBillerStatus");

                entity.Property(e => e.EbillerStatusChangeDate)
                    .HasColumnType("datetime")
                    .HasColumnName("EBillerStatusChangeDate");

                entity.Property(e => e.EbillerStatusCheckDate)
                    .HasColumnType("datetime")
                    .HasColumnName("EBillerStatusCheckDate");

                entity.Property(e => e.EbillerStatusComments)
                    .HasMaxLength(2000)
                    .HasColumnName("EBillerStatusComments");

                entity.Property(e => e.Expense).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.Fees).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.MatterId).HasColumnName("Matter_Id");

                entity.Property(e => e.PreIpsexpenseBilled)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("PreIPSExpenseBilled");

                entity.Property(e => e.PreIpsfeesBilled)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("PreIPSFeesBilled");

                entity.Property(e => e.PreIpstotalBilled)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("PreIPSTotalBilled");

                entity.Property(e => e.Total).HasColumnType("decimal(18, 2)");

                entity.HasOne(d => d.CreatedBy)
                    .WithMany(p => p.MatterBudgets)
                    .HasForeignKey(d => d.CreatedById)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_MatterBudgets_Users2");

                entity.HasOne(d => d.Matter)
                    .WithMany(p => p.MatterBudgets)
                    .HasForeignKey(d => d.MatterId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_MatterBudgets_Matters");
            });

            modelBuilder.Entity<MatterBudgetLine>(entity =>
            {
                entity.Property(e => e.BudgetedAmount).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.MatterBudgetId).HasColumnName("MatterBudget_Id");

                entity.Property(e => e.Part).HasMaxLength(100);

                entity.Property(e => e.PreTrackingAmount).HasColumnType("decimal(18, 2)");

                entity.HasOne(d => d.MatterBudget)
                    .WithMany(p => p.MatterBudgetLines)
                    .HasForeignKey(d => d.MatterBudgetId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_MatterBudgetLines_matterBudget");
            });

            modelBuilder.Entity<MatterClientContact>(entity =>
            {
                entity.HasIndex(e => e.ClientContactId, "IX_ClientContact_Id");

                entity.HasIndex(e => e.MasterContactTypeId, "IX_MasterContactType_Id");

                entity.HasIndex(e => e.MatterId, "IX_Matter_Id");

                entity.Property(e => e.ClientContactId).HasColumnName("ClientContact_Id");

                entity.Property(e => e.MasterContactTypeId).HasColumnName("MasterContactType_Id");

                entity.Property(e => e.MatterId).HasColumnName("Matter_Id");

                entity.HasOne(d => d.ClientContact)
                    .WithMany(p => p.MatterClientContacts)
                    .HasForeignKey(d => d.ClientContactId)
                    .OnDelete(DeleteBehavior.ClientSetNull);

                entity.HasOne(d => d.MasterContactType)
                    .WithMany(p => p.MatterClientContacts)
                    .HasForeignKey(d => d.MasterContactTypeId)
                    .OnDelete(DeleteBehavior.ClientSetNull);

                entity.HasOne(d => d.Matter)
                    .WithMany(p => p.MatterClientContacts)
                    .HasForeignKey(d => d.MatterId)
                    .OnDelete(DeleteBehavior.ClientSetNull);
            });

            modelBuilder.Entity<MatterCustomField>(entity =>
            {
                entity.HasIndex(e => e.CreatedById, "IX_CreatedBy_Id");

                entity.HasIndex(e => e.ModifiedById, "IX_ModifiedBy_Id");

                entity.Property(e => e.CreatedById).HasColumnName("CreatedBy_Id");

                entity.Property(e => e.CreatedTime).HasColumnType("datetime");

                entity.Property(e => e.DefaultValue).HasMaxLength(255);

                entity.Property(e => e.DisplayName)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.Property(e => e.HelpText).HasMaxLength(1000);

                entity.Property(e => e.Key)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.Property(e => e.ModifiedById).HasColumnName("ModifiedBy_Id");

                entity.Property(e => e.ModifiedTime).HasColumnType("datetime");

                entity.Property(e => e.Options).HasMaxLength(1000);

                entity.Property(e => e.ValidationExpression).HasMaxLength(255);

                entity.Property(e => e.ValidationMessage).HasMaxLength(255);

                entity.HasOne(d => d.CreatedBy)
                    .WithMany(p => p.MatterCustomFieldCreatedBies)
                    .HasForeignKey(d => d.CreatedById)
                    .OnDelete(DeleteBehavior.ClientSetNull);

                entity.HasOne(d => d.ModifiedBy)
                    .WithMany(p => p.MatterCustomFieldModifiedBies)
                    .HasForeignKey(d => d.ModifiedById)
                    .OnDelete(DeleteBehavior.ClientSetNull);
            });

            modelBuilder.Entity<MatterCustomFieldValue>(entity =>
            {
                entity.HasIndex(e => e.MatterCustomFieldId, "IX_MatterCustomField_Id");

                entity.HasIndex(e => e.MatterId, "IX_Matter_Id");

                entity.Property(e => e.MatterCustomFieldId).HasColumnName("MatterCustomField_Id");

                entity.Property(e => e.MatterId).HasColumnName("Matter_Id");

                entity.Property(e => e.Value).HasMaxLength(255);

                entity.HasOne(d => d.MatterCustomField)
                    .WithMany(p => p.MatterCustomFieldValues)
                    .HasForeignKey(d => d.MatterCustomFieldId)
                    .OnDelete(DeleteBehavior.ClientSetNull);

                entity.HasOne(d => d.Matter)
                    .WithMany(p => p.MatterCustomFieldValues)
                    .HasForeignKey(d => d.MatterId)
                    .OnDelete(DeleteBehavior.ClientSetNull);
            });

            modelBuilder.Entity<MatterDocument>(entity =>
            {
                entity.HasIndex(e => e.DocumentId, "IX_Document_Id");

                entity.HasIndex(e => e.MatterId, "IX_Matter_Id");

                entity.Property(e => e.DocumentId).HasColumnName("Document_Id");

                entity.Property(e => e.MatterId).HasColumnName("Matter_Id");

                entity.HasOne(d => d.Document)
                    .WithMany(p => p.MatterDocuments)
                    .HasForeignKey(d => d.DocumentId)
                    .OnDelete(DeleteBehavior.ClientSetNull);

                entity.HasOne(d => d.Matter)
                    .WithMany(p => p.MatterDocuments)
                    .HasForeignKey(d => d.MatterId)
                    .OnDelete(DeleteBehavior.ClientSetNull);
            });

            modelBuilder.Entity<MatterException>(entity =>
            {
                entity.HasIndex(e => e.CreatedById, "IX_CreatedBy_Id");

                entity.HasIndex(e => e.MatterId, "IX_Matter_Id");

                entity.HasIndex(e => e.ModifiedById, "IX_ModifiedBy_Id");

                entity.HasIndex(e => e.RuleId, "IX_Rule_Id");

                entity.Property(e => e.CreatedById).HasColumnName("CreatedBy_Id");

                entity.Property(e => e.CreatedTime).HasColumnType("datetime");

                entity.Property(e => e.Description).HasMaxLength(100);

                entity.Property(e => e.MatterId).HasColumnName("Matter_Id");

                entity.Property(e => e.ModifiedById).HasColumnName("ModifiedBy_Id");

                entity.Property(e => e.ModifiedTime).HasColumnType("datetime");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.RuleId).HasColumnName("Rule_Id");

                entity.Property(e => e.ValidFrom).HasColumnType("datetime");

                entity.Property(e => e.ValidTo).HasColumnType("datetime");

                entity.HasOne(d => d.CreatedBy)
                    .WithMany(p => p.MatterExceptionCreatedBies)
                    .HasForeignKey(d => d.CreatedById)
                    .OnDelete(DeleteBehavior.ClientSetNull);

                entity.HasOne(d => d.Matter)
                    .WithMany(p => p.MatterExceptions)
                    .HasForeignKey(d => d.MatterId)
                    .OnDelete(DeleteBehavior.ClientSetNull);

                entity.HasOne(d => d.ModifiedBy)
                    .WithMany(p => p.MatterExceptionModifiedBies)
                    .HasForeignKey(d => d.ModifiedById)
                    .OnDelete(DeleteBehavior.ClientSetNull);

                entity.HasOne(d => d.Rule)
                    .WithMany(p => p.MatterExceptions)
                    .HasForeignKey(d => d.RuleId);
            });

            modelBuilder.Entity<MatterInjuryType>(entity =>
            {
                entity.HasNoKey();

                entity.Property(e => e.Id).ValueGeneratedOnAdd();

                entity.Property(e => e.InjuryTypeCategoryRelationId).HasColumnName("InjuryTypeCategoryRelationID");

                entity.Property(e => e.MatterId).HasColumnName("MatterID");
            });

            modelBuilder.Entity<MatterLawFirmContact>(entity =>
            {
                entity.HasIndex(e => e.LawFirmContactPersonId, "IX_LawFirmContactPerson_Id");

                entity.HasIndex(e => e.MasterContactTypeId, "IX_MasterContactType_Id");

                entity.HasIndex(e => e.MatterId, "IX_Matter_Id");

                entity.Property(e => e.LawFirmContactPersonId).HasColumnName("LawFirmContactPerson_Id");

                entity.Property(e => e.MasterContactTypeId).HasColumnName("MasterContactType_Id");

                entity.Property(e => e.MatterId).HasColumnName("Matter_Id");

                entity.HasOne(d => d.LawFirmContactPerson)
                    .WithMany(p => p.MatterLawFirmContacts)
                    .HasForeignKey(d => d.LawFirmContactPersonId)
                    .OnDelete(DeleteBehavior.ClientSetNull);

                entity.HasOne(d => d.MasterContactType)
                    .WithMany(p => p.MatterLawFirmContacts)
                    .HasForeignKey(d => d.MasterContactTypeId)
                    .OnDelete(DeleteBehavior.ClientSetNull);

                entity.HasOne(d => d.Matter)
                    .WithMany(p => p.MatterLawFirmContacts)
                    .HasForeignKey(d => d.MatterId)
                    .OnDelete(DeleteBehavior.ClientSetNull);
            });

            modelBuilder.Entity<MatterLossType>(entity =>
            {
                entity.HasNoKey();

                entity.Property(e => e.Id).ValueGeneratedOnAdd();

                entity.Property(e => e.LossTypeId).HasColumnName("LossTypeID");

                entity.Property(e => e.MatterId).HasColumnName("MatterID");
            });

            modelBuilder.Entity<MatterNote>(entity =>
            {
                entity.HasIndex(e => e.CreatedById, "IX_CreatedBy_Id");

                entity.HasIndex(e => e.MatterId, "IX_Matter_Id");

                entity.Property(e => e.CreatedById).HasColumnName("CreatedBy_Id");

                entity.Property(e => e.MatterId).HasColumnName("Matter_Id");

                entity.Property(e => e.Note)
                    .IsRequired()
                    .HasMaxLength(1000);

                entity.Property(e => e.NoteTimeStamp).HasColumnType("datetime");

                entity.HasOne(d => d.CreatedBy)
                    .WithMany(p => p.MatterNotes)
                    .HasForeignKey(d => d.CreatedById)
                    .OnDelete(DeleteBehavior.ClientSetNull);

                entity.HasOne(d => d.Matter)
                    .WithMany(p => p.MatterNotes)
                    .HasForeignKey(d => d.MatterId)
                    .OnDelete(DeleteBehavior.ClientSetNull);
            });

            modelBuilder.Entity<MatterQuestion>(entity =>
            {
                entity.HasNoKey();

                entity.Property(e => e.Id).ValueGeneratedOnAdd();

                entity.Property(e => e.MatterId).HasColumnName("MatterID");

                entity.Property(e => e.QuestionId).HasColumnName("QuestionID");
            });

            modelBuilder.Entity<MatterRate>(entity =>
            {
                entity.HasIndex(e => e.MatterId, "IX_MatterRates_MatterId");

                entity.Property(e => e.Associate).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.Clerk).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.LegalAssistant).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.MatterId).HasColumnName("Matter_Id");

                entity.Property(e => e.OfCounsel).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.Paralegal).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.Partner).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.RateFrom).HasColumnType("datetime");

                entity.Property(e => e.Secretary).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.SeniorAssociate).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.SeniorPartner).HasColumnType("decimal(18, 2)");

                entity.HasOne(d => d.Matter)
                    .WithMany(p => p.MatterRates)
                    .HasForeignKey(d => d.MatterId)
                    .OnDelete(DeleteBehavior.ClientSetNull);
            });

            modelBuilder.Entity<MatterTimekeeper>(entity =>
            {
                entity.Property(e => e.MatterId).HasColumnName("Matter_Id");

                entity.Property(e => e.Rate).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.RateFrom).HasColumnType("datetime");

                entity.Property(e => e.TimekeeperId).HasColumnName("Timekeeper_Id");

                entity.HasOne(d => d.Matter)
                    .WithMany(p => p.MatterTimekeepers)
                    .HasForeignKey(d => d.MatterId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_MatterTimekeepers_Matters");

                entity.HasOne(d => d.Timekeeper)
                    .WithMany(p => p.MatterTimekeepers)
                    .HasForeignKey(d => d.TimekeeperId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_MatterTimekeepers_LawFirmContactPersons");
            });

            modelBuilder.Entity<MelickOct2020Prebill>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("Melick_Oct2020_prebills");

                entity.Property(e => e.Invoicedate)
                    .HasColumnType("datetime")
                    .HasColumnName("invoicedate");
            });

            modelBuilder.Entity<Message>(entity =>
            {
                entity.Property(e => e.CreatedTime).HasColumnType("datetime");

                entity.Property(e => e.FromUserId).HasColumnName("FromUser_Id");

                entity.Property(e => e.MessageContent).IsRequired();

                entity.Property(e => e.Subject).HasMaxLength(500);

                entity.Property(e => e.ToOrganizationId).HasColumnName("ToOrganization_Id");

                entity.Property(e => e.ToUserId).HasColumnName("ToUser_Id");

                entity.HasOne(d => d.FromUser)
                    .WithMany(p => p.MessageFromUsers)
                    .HasForeignKey(d => d.FromUserId)
                    .HasConstraintName("fk_messages_users_from");

                entity.HasOne(d => d.InvoiceLineItem)
                    .WithMany(p => p.Messages)
                    .HasForeignKey(d => d.InvoiceLineItemId)
                    .HasConstraintName("FK_Messages_InvoiceLineItems");

                entity.HasOne(d => d.ParentMessage)
                    .WithMany(p => p.InverseParentMessage)
                    .HasForeignKey(d => d.ParentMessageId)
                    .HasConstraintName("FK_Messages_Messages");

                entity.HasOne(d => d.ToOrganization)
                    .WithMany(p => p.Messages)
                    .HasForeignKey(d => d.ToOrganizationId)
                    .HasConstraintName("fk_messages_lawfirm_to");

                entity.HasOne(d => d.ToUser)
                    .WithMany(p => p.MessageToUsers)
                    .HasForeignKey(d => d.ToUserId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_messages_users_to");
            });

            modelBuilder.Entity<MessageAttachment>(entity =>
            {
                entity.Property(e => e.MessageId).HasColumnName("Message_Id");

                entity.Property(e => e.OriginalFileName)
                    .IsRequired()
                    .HasMaxLength(255);

                entity.Property(e => e.SavedFileName)
                    .IsRequired()
                    .HasMaxLength(255);

                entity.HasOne(d => d.Message)
                    .WithMany(p => p.MessageAttachments)
                    .HasForeignKey(d => d.MessageId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_messageattachments_message_id");
            });

            modelBuilder.Entity<NonIpsinvoice>(entity =>
            {
                entity.ToTable("NonIPSInvoices");

                entity.HasIndex(e => e.ClientName, "IX_NonIPSInvoices_ClientName");

                entity.HasIndex(e => e.InvoiceDate, "IX_NonIPSInvoices_InvoiceDate");

                entity.HasIndex(e => e.InvoiceNumber, "IX_NonIPSInvoices_InvoiceNumber");

                entity.HasIndex(e => e.LawFirmId, "IX_NonIPSInvoices_LAwFIrmId");

                entity.Property(e => e.ClientMatterId).HasMaxLength(255);

                entity.Property(e => e.ClientName)
                    .IsRequired()
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.FirmMatterId).HasMaxLength(255);

                entity.Property(e => e.InvoiceAmount).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.InvoiceDate).HasColumnType("date");

                entity.Property(e => e.InvoiceNumber)
                    .IsRequired()
                    .HasMaxLength(255);

                entity.Property(e => e.LawFirmId).HasColumnName("LawFirm_Id");

                entity.Property(e => e.MatterName).HasMaxLength(1000);

                entity.Property(e => e.PaymentReceived1Amount).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.PaymentReceived1Date).HasColumnType("date");

                entity.Property(e => e.PaymentReceived2Amount).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.PaymentReceived2Date).HasColumnType("date");

                entity.Property(e => e.PaymentReceived3Amount).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.PaymentReceived3Date).HasColumnType("date");

                entity.Property(e => e.TotalPaymentReceived).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.TotalWriteOff).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.WriteOff1).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.WriteOff1Date).HasColumnType("date");

                entity.Property(e => e.WriteOff2).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.WriteOff2Date).HasColumnType("date");
            });

            modelBuilder.Entity<OlsonInvoicedate>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("Olson_invoicedate");
            });

            modelBuilder.Entity<OperandFieldType>(entity =>
            {
                entity.HasIndex(e => e.FieldTypeId, "IX_FieldTypeId");

                entity.HasIndex(e => e.OperandId, "IX_OperandId");

                entity.HasOne(d => d.FieldType)
                    .WithMany(p => p.OperandFieldTypes)
                    .HasForeignKey(d => d.FieldTypeId)
                    .OnDelete(DeleteBehavior.ClientSetNull);

                entity.HasOne(d => d.Operand)
                    .WithMany(p => p.OperandFieldTypes)
                    .HasForeignKey(d => d.OperandId)
                    .OnDelete(DeleteBehavior.ClientSetNull);
            });

            modelBuilder.Entity<ParamsGetDashboardClientWiseReductionDrillDown>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("paramsGetDashboardClientWiseReductionDrillDown");

                entity.Property(e => e.SortDirection)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.SortOrder)
                    .HasMaxLength(1000)
                    .IsUnicode(false);

                entity.Property(e => e.Status)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("status");

                entity.Property(e => e.StrQuery)
                    .IsUnicode(false)
                    .HasColumnName("strQuery");
            });

            modelBuilder.Entity<ParamsGetTimeKeeperReductionInvoiceDetail>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("paramsGetTimeKeeperReductionInvoiceDetails");

                entity.Property(e => e.Category).IsUnicode(false);

                entity.Property(e => e.FromDate).HasColumnType("datetime");

                entity.Property(e => e.SortDirection)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.SortOrder)
                    .HasMaxLength(1000)
                    .IsUnicode(false);

                entity.Property(e => e.Status)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.StrQuery)
                    .IsUnicode(false)
                    .HasColumnName("strQuery");

                entity.Property(e => e.TimekeeperId).HasColumnName("TimekeeperID");

                entity.Property(e => e.ToDate).HasColumnType("datetime");
            });

            modelBuilder.Entity<PayerDocument>(entity =>
            {
                entity.Property(e => e.ClientId).HasColumnName("Client_Id");

                entity.Property(e => e.DocumentId).HasColumnName("Document_Id");

                entity.HasOne(d => d.Client)
                    .WithMany(p => p.PayerDocuments)
                    .HasForeignKey(d => d.ClientId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_payerdocument_client");

                entity.HasOne(d => d.Document)
                    .WithMany(p => p.PayerDocuments)
                    .HasForeignKey(d => d.DocumentId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_payerdocument_document");
            });

            modelBuilder.Entity<PayerNote>(entity =>
            {
                entity.Property(e => e.ClientId).HasColumnName("Client_Id");

                entity.Property(e => e.CreatedById).HasColumnName("CreatedBy_Id");

                entity.Property(e => e.Note)
                    .IsRequired()
                    .HasMaxLength(1000);

                entity.Property(e => e.NoteTimeStamp).HasColumnType("datetime");

                entity.HasOne(d => d.Client)
                    .WithMany(p => p.PayerNotes)
                    .HasForeignKey(d => d.ClientId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_payerntoes_client");
            });

            modelBuilder.Entity<Payerlevel>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("payerlevel#");

                entity.Property(e => e.ActualFileName).HasMaxLength(256);

                entity.Property(e => e.Id).ValueGeneratedOnAdd();

                entity.Property(e => e.InvoiceFileId).HasColumnName("Invoice_File_Id");

                entity.Property(e => e.InvoiceId).HasColumnName("Invoice_Id");

                entity.Property(e => e.LogicalFileName).HasMaxLength(256);

                entity.Property(e => e.OwnerId).HasColumnName("Owner_Id");

                entity.Property(e => e.ParentTaskId).HasColumnName("Parent_Task_id");

                entity.Property(e => e.Tags)
                    .HasMaxLength(1000)
                    .IsUnicode(false);

                entity.Property(e => e.TaskCompletionTime).HasColumnType("datetime");

                entity.Property(e => e.TaskName)
                    .IsRequired()
                    .HasMaxLength(256)
                    .IsUnicode(false);

                entity.Property(e => e.TaskRequestedTime).HasColumnType("datetime");

                entity.Property(e => e.TaskRequestingUserId).HasColumnName("Task_Requesting_User_Id");

                entity.Property(e => e.TaskUpdateTime).HasColumnType("datetime");
            });

            modelBuilder.Entity<PendingInvoiceApprovalNotification>(entity =>
            {
                entity.Property(e => e.InvoiceId).HasColumnName("Invoice_Id");

                entity.Property(e => e.OfflineApproverEmail)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("OfflineApprover_Email");

                entity.Property(e => e.OfflineApproverMailUniqueId)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("OfflineApproverMail_UniqueId");

                entity.Property(e => e.ResponseReceivedDate).HasColumnType("datetime");

                entity.Property(e => e.ResponseText).IsUnicode(false);

                entity.Property(e => e.SendDate).HasColumnType("datetime");

                entity.Property(e => e.SendToPersonId)
                    .HasMaxLength(300)
                    .IsUnicode(false)
                    .HasColumnName("SendToPerson_Id");

                entity.HasOne(d => d.Invoice)
                    .WithMany(p => p.PendingInvoiceApprovalNotifications)
                    .HasForeignKey(d => d.InvoiceId)
                    .HasConstraintName("FK_PendingInvoiceApprovalNotifications_Invoices");
            });

            modelBuilder.Entity<PreBillCorrectionReportDetail>(entity =>
            {
                entity.HasNoKey();

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.Id).ValueGeneratedOnAdd();

                entity.Property(e => e.ReportDisplayName)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.ReportOriginalName)
                    .HasMaxLength(500)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<PreBillUpload>(entity =>
            {
                entity.Property(e => e.ClientId).HasColumnName("Client_Id");

                entity.Property(e => e.CreatedTime).HasColumnType("datetime");

                entity.Property(e => e.LawFirmId).HasColumnName("LawFirm_Id");

                entity.Property(e => e.PreBillDocumentFileNames).HasMaxLength(2000);

                entity.Property(e => e.PreBillFileName).HasMaxLength(255);

                entity.Property(e => e.PreBillNotes).HasMaxLength(2000);

                entity.Property(e => e.ReceivedDate).HasColumnType("datetime");

                entity.Property(e => e.UserId).HasColumnName("User_Id");

                entity.HasOne(d => d.Client)
                    .WithMany(p => p.PreBillUploads)
                    .HasForeignKey(d => d.ClientId);

                entity.HasOne(d => d.LawFirm)
                    .WithMany(p => p.PreBillUploads)
                    .HasForeignKey(d => d.LawFirmId)
                    .OnDelete(DeleteBehavior.ClientSetNull);

                entity.HasOne(d => d.User)
                    .WithMany(p => p.PreBillUploads)
                    .HasForeignKey(d => d.UserId)
                    .OnDelete(DeleteBehavior.ClientSetNull);
            });

            modelBuilder.Entity<PrebillToInvoiceTklevelMapping>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("PrebillToInvoiceTKLevelMapping");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(60);

                entity.Property(e => e.TimeKeeperMappingLevel).HasMaxLength(120);
            });

            modelBuilder.Entity<PreparationReportType>(entity =>
            {
                entity.Property(e => e.BillType)
                    .IsRequired()
                    .HasMaxLength(10);

                entity.Property(e => e.HelpNote)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.ReportFileName).HasMaxLength(250);

                entity.Property(e => e.ReportName).HasMaxLength(250);
            });

            modelBuilder.Entity<ProgrammedAction>(entity =>
            {
                entity.HasIndex(e => e.RuleAreaId, "IX_RuleArea_Id");

                entity.Property(e => e.ClassName).HasMaxLength(200);

                entity.Property(e => e.Description).HasMaxLength(1000);

                entity.Property(e => e.Name).HasMaxLength(200);

                entity.Property(e => e.RuleAreaId).HasColumnName("RuleArea_Id");

                entity.HasOne(d => d.RuleArea)
                    .WithMany(p => p.ProgrammedActions)
                    .HasForeignKey(d => d.RuleAreaId)
                    .OnDelete(DeleteBehavior.ClientSetNull);
            });

            modelBuilder.Entity<ProgrammedCondition>(entity =>
            {
                entity.HasIndex(e => e.RuleAreaId, "IX_RuleArea_Id");

                entity.Property(e => e.ClassName).HasMaxLength(200);

                entity.Property(e => e.Description).HasMaxLength(1000);

                entity.Property(e => e.Name).HasMaxLength(200);

                entity.Property(e => e.RuleAreaId).HasColumnName("RuleArea_Id");

                entity.HasOne(d => d.RuleArea)
                    .WithMany(p => p.ProgrammedConditions)
                    .HasForeignKey(d => d.RuleAreaId)
                    .OnDelete(DeleteBehavior.ClientSetNull);
            });

            modelBuilder.Entity<ReleaseNote>(entity =>
            {
                entity.Property(e => e.FilePath)
                    .IsRequired()
                    .HasMaxLength(255);

                entity.Property(e => e.VersionName)
                    .IsRequired()
                    .HasMaxLength(25);
            });

            modelBuilder.Entity<ReminderNotificationMail>(entity =>
            {
                entity.HasKey(e => e.NotifyLogId)
                    .HasName("PK_ReminderMailNotification");

                entity.Property(e => e.InvoiceAppealDate).HasColumnType("datetime");

                entity.Property(e => e.InvoiceAppealEndDate).HasColumnType("datetime");

                entity.Property(e => e.InvoiceId).HasColumnName("invoiceId");

                entity.Property(e => e.SendDate).HasColumnType("datetime");
            });

            modelBuilder.Entity<ReportSelectedColumn>(entity =>
            {
                entity.Property(e => e.ColumnId).HasColumnName("Column_Id");

                entity.Property(e => e.ReportId).HasColumnName("Report_Id");

                entity.Property(e => e.UserId).HasColumnName("User_Id");
            });

            modelBuilder.Entity<Rule>(entity =>
            {
                entity.HasIndex(e => e.RuleAreaId, "IX_RuleArea_Id");

                entity.HasIndex(e => e.RuleCategoryId, "IX_RuleCategory_Id");

                entity.HasIndex(e => e.RuleSetId, "IX_RuleSet_Id");

                entity.Property(e => e.Action).HasMaxLength(1000);

                entity.Property(e => e.ActionClassName).HasMaxLength(255);

                entity.Property(e => e.AdjustmentNote).HasMaxLength(1000);

                entity.Property(e => e.Code).HasMaxLength(20);

                entity.Property(e => e.Condition).HasMaxLength(2000);

                entity.Property(e => e.ConditionClassName).HasMaxLength(255);

                entity.Property(e => e.CreatedById).HasColumnName("CreatedBy_Id");

                entity.Property(e => e.CreatedTime).HasColumnType("datetime");

                entity.Property(e => e.Description).HasMaxLength(1000);

                entity.Property(e => e.ExportActionTypeId).HasColumnName("ExportActionTypeID");

                entity.Property(e => e.ExportAdjustmentNote).HasMaxLength(1000);

                entity.Property(e => e.IsExport).HasDefaultValueSql("((0))");

                entity.Property(e => e.IsManual).HasDefaultValueSql("((0))");

                entity.Property(e => e.IsMerged).HasDefaultValueSql("((0))");

                entity.Property(e => e.IsPrebill).HasDefaultValueSql("((0))");

                entity.Property(e => e.IsValidation).HasDefaultValueSql("((0))");

                entity.Property(e => e.ManualActionTypeId).HasColumnName("ManualActionTypeID");

                entity.Property(e => e.ManualAdjustmentNote).HasMaxLength(1000);

                entity.Property(e => e.ModifiedById).HasColumnName("ModifiedBy_Id");

                entity.Property(e => e.ModifiedTime).HasColumnType("datetime");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(255);

                entity.Property(e => e.PrebillActionTypeId).HasColumnName("PrebillActionTypeID");

                entity.Property(e => e.PrebillAdjustmentNote).HasMaxLength(1000);

                entity.Property(e => e.RuleAreaId).HasColumnName("RuleArea_Id");

                entity.Property(e => e.RuleCategoryId).HasColumnName("RuleCategory_Id");

                entity.Property(e => e.RuleSetId).HasColumnName("RuleSet_Id");

                entity.Property(e => e.ValidationActionTypeId).HasColumnName("ValidationActionTypeID");

                entity.HasOne(d => d.CreatedBy)
                    .WithMany(p => p.RuleCreatedBies)
                    .HasForeignKey(d => d.CreatedById)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Rules_Users");

                entity.HasOne(d => d.ModifiedBy)
                    .WithMany(p => p.RuleModifiedBies)
                    .HasForeignKey(d => d.ModifiedById)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Rules_Users1");

                entity.HasOne(d => d.RuleArea)
                    .WithMany(p => p.Rules)
                    .HasForeignKey(d => d.RuleAreaId)
                    .OnDelete(DeleteBehavior.ClientSetNull);

                entity.HasOne(d => d.RuleCategory)
                    .WithMany(p => p.Rules)
                    .HasForeignKey(d => d.RuleCategoryId)
                    .OnDelete(DeleteBehavior.ClientSetNull);

                entity.HasOne(d => d.RuleSet)
                    .WithMany(p => p.Rules)
                    .HasForeignKey(d => d.RuleSetId);
            });

            modelBuilder.Entity<RuleArea>(entity =>
            {
                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(255);
            });

            modelBuilder.Entity<RuleAssignment>(entity =>
            {
                entity.HasNoKey();

                entity.HasIndex(e => new { e.ClientId, e.LawFirmId }, "RuleAssignment");

                entity.HasIndex(e => e.RuleId, "RuleAssignment_Rule_ID");

                entity.Property(e => e.ClientId).HasColumnName("Client_Id");

                entity.Property(e => e.Id).ValueGeneratedOnAdd();

                entity.Property(e => e.LawFirmId).HasColumnName("LawFirm_Id");

                entity.Property(e => e.ProductLineId).HasColumnName("ProductLine_Id");

                entity.Property(e => e.RuleId).HasColumnName("Rule_Id");

                entity.HasOne(d => d.ProductLine)
                    .WithMany()
                    .HasForeignKey(d => d.ProductLineId)
                    .HasConstraintName("FK_RuleAssignment_ProductLine");
            });

            modelBuilder.Entity<RuleAssignmentExcludedProductLine>(entity =>
            {
                entity.HasNoKey();

                entity.Property(e => e.Id).ValueGeneratedOnAdd();

                entity.Property(e => e.ProductLineId).HasColumnName("ProductLine_Id");

                entity.Property(e => e.RuleAssignmentId).HasColumnName("RuleAssignment_Id");

                entity.HasOne(d => d.ProductLine)
                    .WithMany()
                    .HasForeignKey(d => d.ProductLineId)
                    .HasConstraintName("FK_RuleAssignmentExcludedProductLines_ProductLine");
            });

            modelBuilder.Entity<RuleAssignments1jan2020>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("RuleAssignments_1jan2020");

                entity.Property(e => e.ClientId).HasColumnName("Client_Id");

                entity.Property(e => e.Id).ValueGeneratedOnAdd();

                entity.Property(e => e.LawFirmId).HasColumnName("LawFirm_Id");

                entity.Property(e => e.ProductLineId).HasColumnName("ProductLine_Id");

                entity.Property(e => e.RuleId).HasColumnName("Rule_Id");
            });

            modelBuilder.Entity<RuleCategory>(entity =>
            {
                entity.Property(e => e.IsShowInDdl).HasColumnName("IsShowInDDL");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(255);
            });

            modelBuilder.Entity<RuleEntity>(entity =>
            {
                entity.Property(e => e.Code)
                    .IsRequired()
                    .HasMaxLength(255);

                entity.Property(e => e.Description).HasMaxLength(1000);

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(255);
            });

            modelBuilder.Entity<RuleField>(entity =>
            {
                entity.HasIndex(e => e.RuleEntityId, "IX_RuleEntity_Id");

                entity.Property(e => e.Code)
                    .IsRequired()
                    .HasMaxLength(255);

                entity.Property(e => e.Description).HasMaxLength(1000);

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(255);

                entity.Property(e => e.ProgrammedRuleEntityId).HasColumnName("ProgrammedRuleEntity_Id");

                entity.Property(e => e.RuleEntityId).HasColumnName("RuleEntity_Id");

                entity.HasOne(d => d.ProgrammedRuleEntity)
                    .WithMany(p => p.RuleFieldProgrammedRuleEntities)
                    .HasForeignKey(d => d.ProgrammedRuleEntityId)
                    .HasConstraintName("FK__RuleField__Progr__5006DFF2");

                entity.HasOne(d => d.RuleEntity)
                    .WithMany(p => p.RuleFieldRuleEntities)
                    .HasForeignKey(d => d.RuleEntityId)
                    .OnDelete(DeleteBehavior.ClientSetNull);
            });

            modelBuilder.Entity<RuleFieldType>(entity =>
            {
                entity.Property(e => e.FieldType).HasMaxLength(255);
            });

            modelBuilder.Entity<RuleSet>(entity =>
            {
                entity.HasIndex(e => e.ClientId, "IX_Client_Id");

                entity.HasIndex(e => e.CreatedById, "IX_CreatedBy_Id");

                entity.HasIndex(e => e.MasterProductLineId, "IX_MasterProductLine_Id");

                entity.HasIndex(e => e.ModifiedById, "IX_ModifiedBy_Id");

                entity.Property(e => e.ClientId).HasColumnName("Client_Id");

                entity.Property(e => e.CreatedById).HasColumnName("CreatedBy_Id");

                entity.Property(e => e.CreatedTime).HasColumnType("datetime");

                entity.Property(e => e.Description).HasMaxLength(1000);

                entity.Property(e => e.MasterProductLineId).HasColumnName("MasterProductLine_Id");

                entity.Property(e => e.ModifiedById).HasColumnName("ModifiedBy_Id");

                entity.Property(e => e.ModifiedTime).HasColumnType("datetime");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(255);

                entity.HasOne(d => d.Client)
                    .WithMany(p => p.RuleSets)
                    .HasForeignKey(d => d.ClientId);

                entity.HasOne(d => d.CreatedBy)
                    .WithMany(p => p.RuleSetCreatedBies)
                    .HasForeignKey(d => d.CreatedById)
                    .OnDelete(DeleteBehavior.ClientSetNull);

                entity.HasOne(d => d.MasterProductLine)
                    .WithMany(p => p.RuleSets)
                    .HasForeignKey(d => d.MasterProductLineId);

                entity.HasOne(d => d.ModifiedBy)
                    .WithMany(p => p.RuleSetModifiedBies)
                    .HasForeignKey(d => d.ModifiedById)
                    .OnDelete(DeleteBehavior.ClientSetNull);
            });

            modelBuilder.Entity<RulesBackUp>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("RulesBackUp");

                entity.Property(e => e.Action).HasMaxLength(1000);

                entity.Property(e => e.ActionClassName).HasMaxLength(255);

                entity.Property(e => e.AdjustmentNote).HasMaxLength(1000);

                entity.Property(e => e.Code).HasMaxLength(20);

                entity.Property(e => e.Condition).HasMaxLength(2000);

                entity.Property(e => e.ConditionClassName).HasMaxLength(255);

                entity.Property(e => e.CreatedById).HasColumnName("CreatedBy_Id");

                entity.Property(e => e.CreatedTime).HasColumnType("datetime");

                entity.Property(e => e.Description).HasMaxLength(1000);

                entity.Property(e => e.Id).ValueGeneratedOnAdd();

                entity.Property(e => e.ModifiedById).HasColumnName("ModifiedBy_Id");

                entity.Property(e => e.ModifiedTime).HasColumnType("datetime");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(255);

                entity.Property(e => e.RuleAreaId).HasColumnName("RuleArea_Id");

                entity.Property(e => e.RuleCategoryId).HasColumnName("RuleCategory_Id");

                entity.Property(e => e.RuleSetId).HasColumnName("RuleSet_Id");
            });

            modelBuilder.Entity<SheehyLibertyInvoicesid15jul2019>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("sheehy_liberty_Invoicesid_15jul2019");
            });

            modelBuilder.Entity<SheehyLibertyInvoicesid15jul20192>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("sheehy_liberty_Invoicesid_15jul2019_2");
            });

            modelBuilder.Entity<SiteAction>(entity =>
            {
                entity.Property(e => e.Area).HasMaxLength(50);

                entity.Property(e => e.Controller)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.RoleNames).HasMaxLength(255);
            });

            modelBuilder.Entity<SystemAlert>(entity =>
            {
                entity.HasIndex(e => e.Subject, "IX_SystemAlert_Subject");

                entity.Property(e => e.AlertCreatedTime).HasColumnType("datetime");

                entity.Property(e => e.Message).IsUnicode(false);

                entity.Property(e => e.ShortMessage)
                    .HasMaxLength(256)
                    .IsUnicode(false);

                entity.Property(e => e.Subject)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<SystemTask>(entity =>
            {
                entity.HasIndex(e => e.OwnerId, "IX_SystemTask_Owner_Id");

                entity.HasIndex(e => e.ParentTaskId, "IX_SystemTask_ParentTaskId");

                entity.HasIndex(e => e.TaskName, "IX_SystemTask_TaskName");

                entity.HasIndex(e => e.TaskRequestingUserId, "IX_SystemTask_Task_Requesting_User_Id");

                entity.Property(e => e.ActualFileName).HasMaxLength(256);

                entity.Property(e => e.InvoiceFileId).HasColumnName("Invoice_File_Id");

                entity.Property(e => e.InvoiceId).HasColumnName("Invoice_Id");

                entity.Property(e => e.LogicalFileName).HasMaxLength(256);

                entity.Property(e => e.OwnerId).HasColumnName("Owner_Id");

                entity.Property(e => e.ParentTaskId).HasColumnName("Parent_Task_id");

                entity.Property(e => e.Tags)
                    .HasMaxLength(1000)
                    .IsUnicode(false);

                entity.Property(e => e.TaskCompletionTime).HasColumnType("datetime");

                entity.Property(e => e.TaskName)
                    .IsRequired()
                    .HasMaxLength(256)
                    .IsUnicode(false);

                entity.Property(e => e.TaskRequestedTime).HasColumnType("datetime");

                entity.Property(e => e.TaskRequestingUserId).HasColumnName("Task_Requesting_User_Id");

                entity.Property(e => e.TaskUpdateTime).HasColumnType("datetime");

                entity.HasOne(d => d.InvoiceFile)
                    .WithMany(p => p.SystemTasks)
                    .HasForeignKey(d => d.InvoiceFileId)
                    .OnDelete(DeleteBehavior.SetNull)
                    .HasConstraintName("FK_SystemTask_InvoiceFiles");

                entity.HasOne(d => d.Invoice)
                    .WithMany(p => p.SystemTasks)
                    .HasForeignKey(d => d.InvoiceId)
                    .OnDelete(DeleteBehavior.SetNull)
                    .HasConstraintName("FK_SystemTask_Invoices");

                entity.HasOne(d => d.ParentTask)
                    .WithMany(p => p.InverseParentTask)
                    .HasForeignKey(d => d.ParentTaskId)
                    .HasConstraintName("FK_SystemTask_SystemTask1");

                entity.HasOne(d => d.TaskRequestingUser)
                    .WithMany(p => p.SystemTasks)
                    .HasForeignKey(d => d.TaskRequestingUserId)
                    .HasConstraintName("FK_SystemTask_Users");
            });

            modelBuilder.Entity<SystemTaskNote>(entity =>
            {
                entity.HasIndex(e => e.SystemTaskId, "IX_SystemTaskNotes_SystemTask_Id");

                entity.Property(e => e.FileName).HasMaxLength(256);

                entity.Property(e => e.LogicalFileName).HasMaxLength(256);

                entity.Property(e => e.Note).HasMaxLength(4000);

                entity.Property(e => e.NoteTimestamp).HasColumnType("datetime");

                entity.Property(e => e.SystemTaskId).HasColumnName("SystemTask_Id");

                entity.Property(e => e.UserId).HasColumnName("User_Id");

                entity.HasOne(d => d.SystemTask)
                    .WithMany(p => p.SystemTaskNotes)
                    .HasForeignKey(d => d.SystemTaskId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_SystemTaskNotes_systemtask");
            });

            modelBuilder.Entity<TaxItem>(entity =>
            {
                entity.HasIndex(e => e.InvoiceLineItemId, "IX_InvoiceLineItem_Id");

                entity.Property(e => e.InvoiceLineItemId).HasColumnName("InvoiceLineItem_Id");

                entity.Property(e => e.TaxId).HasMaxLength(20);

                entity.HasOne(d => d.InvoiceLineItem)
                    .WithMany(p => p.TaxItems)
                    .HasForeignKey(d => d.InvoiceLineItemId)
                    .OnDelete(DeleteBehavior.ClientSetNull);
            });

            modelBuilder.Entity<TempInvoicesDel>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("tempInvoicesDel");

                entity.Property(e => e.InvoiceId).HasColumnName("InvoiceID");
            });

            modelBuilder.Entity<TempStatefarmBarCapture08aug2020>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("tempStatefarmBarCapture_08Aug2020");

                entity.Property(e => e.ClientMatterIdModified).HasMaxLength(100);

                entity.Property(e => e.InvoiceDate).HasColumnType("datetime");

                entity.Property(e => e.InvoiceNum).HasMaxLength(100);

                entity.Property(e => e.ModInvoiceTotal).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.OrigInvoiceTotal).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.StatusName).HasMaxLength(100);
            });

            modelBuilder.Entity<TestLineitemcommunication>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("testLineitemcommunications");

                entity.Property(e => e.AddressedToContactId).HasColumnName("AddressedToContact_id");

                entity.Property(e => e.AddressedToUserId).HasColumnName("AddressedToUser_Id");

                entity.Property(e => e.Cc)
                    .HasMaxLength(1000)
                    .IsUnicode(false)
                    .HasColumnName("CC");

                entity.Property(e => e.EscalateResponseText).IsUnicode(false);

                entity.Property(e => e.EscalatedBy1)
                    .HasMaxLength(1000)
                    .IsUnicode(false)
                    .HasColumnName("Escalated_By1");

                entity.Property(e => e.EscalatedBy2)
                    .HasMaxLength(1000)
                    .IsUnicode(false)
                    .HasColumnName("Escalated_By2");

                entity.Property(e => e.EscalatedDate1)
                    .HasColumnType("datetime")
                    .HasColumnName("Escalated_Date1");

                entity.Property(e => e.EscalatedDate2)
                    .HasColumnType("datetime")
                    .HasColumnName("Escalated_Date2");

                entity.Property(e => e.EscalatedUniqueId1)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("EscalatedUniqueID1");

                entity.Property(e => e.EscalatedUniqueId2)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("EscalatedUniqueID2");

                entity.Property(e => e.FollowupBy1)
                    .HasMaxLength(1000)
                    .IsUnicode(false)
                    .HasColumnName("Followup_By1");

                entity.Property(e => e.FollowupBy2)
                    .HasMaxLength(1000)
                    .IsUnicode(false)
                    .HasColumnName("Followup_By2");

                entity.Property(e => e.FollowupDate1)
                    .HasColumnType("datetime")
                    .HasColumnName("Followup_Date1");

                entity.Property(e => e.FollowupDate2)
                    .HasColumnType("datetime")
                    .HasColumnName("Followup_Date2");

                entity.Property(e => e.FollowupResponseText).IsUnicode(false);

                entity.Property(e => e.FollowupUniqueId1)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("FollowupUniqueID1");

                entity.Property(e => e.FollowupUniqueId2)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("FollowupUniqueID2");

                entity.Property(e => e.Id).ValueGeneratedOnAdd();

                entity.Property(e => e.InvoiceLineItemId).HasColumnName("InvoiceLineItem_Id");

                entity.Property(e => e.IsPrivateToIps).HasColumnName("IsPrivateToIPS");

                entity.Property(e => e.ResponseText).IsUnicode(false);

                entity.Property(e => e.SendQueryUniqueId)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.WrittenByUserId).HasColumnName("WrittenByUser_id");

                entity.Property(e => e.WrittenDate).HasColumnType("datetime");
            });

            modelBuilder.Entity<TestTable>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("TestTable$");

                entity.Property(e => e.Client).HasMaxLength(255);

                entity.Property(e => e.FirmClient)
                    .HasMaxLength(255)
                    .HasColumnName("FirmClient ");

                entity.Property(e => e.FirmClientMatterId).HasColumnName("Firm_Client_Matter_ID");

                entity.Property(e => e.FirmMatterId)
                    .HasMaxLength(255)
                    .HasColumnName("Firm_Matter_ID");

                entity.Property(e => e.LineOfBusiness)
                    .HasMaxLength(255)
                    .HasColumnName("Line_of_Business");

                entity.Property(e => e.MatterName)
                    .HasMaxLength(255)
                    .HasColumnName("Matter_Name");

                entity.Property(e => e.SlNo).HasColumnName("SL No");

                entity.Property(e => e.Status).HasMaxLength(255);
            });

            modelBuilder.Entity<Ticket>(entity =>
            {
                entity.HasIndex(e => e.AssignedById, "IX_AssignedBy_Id");

                entity.HasIndex(e => e.AssignedToId, "IX_AssignedTo_Id");

                entity.HasIndex(e => e.RaisedById, "IX_RaisedBy_Id");

                entity.HasIndex(e => e.ResolvedById, "IX_ResolvedBy_Id");

                entity.HasIndex(e => e.TicketAreaId, "IX_TicketAreaId");

                entity.Property(e => e.AssignedById).HasColumnName("AssignedBy_Id");

                entity.Property(e => e.AssignedDate).HasColumnType("datetime");

                entity.Property(e => e.AssignedToId).HasColumnName("AssignedTo_Id");

                entity.Property(e => e.Description)
                    .IsRequired()
                    .HasMaxLength(2000);

                entity.Property(e => e.RaisedById).HasColumnName("RaisedBy_Id");

                entity.Property(e => e.RaisedDate).HasColumnType("datetime");

                entity.Property(e => e.ResolvedById).HasColumnName("ResolvedBy_Id");

                entity.Property(e => e.ResolvedDate).HasColumnType("datetime");

                entity.Property(e => e.Subject)
                    .IsRequired()
                    .HasMaxLength(255);

                entity.Property(e => e.TicketNo).HasMaxLength(100);

                entity.HasOne(d => d.AssignedBy)
                    .WithMany(p => p.TicketAssignedBies)
                    .HasForeignKey(d => d.AssignedById);

                entity.HasOne(d => d.AssignedTo)
                    .WithMany(p => p.TicketAssignedTos)
                    .HasForeignKey(d => d.AssignedToId);

                entity.HasOne(d => d.RaisedBy)
                    .WithMany(p => p.TicketRaisedBies)
                    .HasForeignKey(d => d.RaisedById)
                    .OnDelete(DeleteBehavior.ClientSetNull);

                entity.HasOne(d => d.ResolvedBy)
                    .WithMany(p => p.TicketResolvedBies)
                    .HasForeignKey(d => d.ResolvedById);

                entity.HasOne(d => d.TicketArea)
                    .WithMany(p => p.Tickets)
                    .HasForeignKey(d => d.TicketAreaId)
                    .OnDelete(DeleteBehavior.ClientSetNull);
            });

            modelBuilder.Entity<TicketAttachment>(entity =>
            {
                entity.HasIndex(e => e.TicketId, "IX_Ticket_Id");

                entity.Property(e => e.OriginalFileName)
                    .IsRequired()
                    .HasMaxLength(255);

                entity.Property(e => e.SavedFileName)
                    .IsRequired()
                    .HasMaxLength(255);

                entity.Property(e => e.TicketId).HasColumnName("Ticket_Id");

                entity.HasOne(d => d.Ticket)
                    .WithMany(p => p.TicketAttachments)
                    .HasForeignKey(d => d.TicketId)
                    .OnDelete(DeleteBehavior.ClientSetNull);
            });

            modelBuilder.Entity<TicketCommentAttachment>(entity =>
            {
                entity.HasIndex(e => e.TicketCommentId, "IX_TicketComment_Id");

                entity.Property(e => e.OriginalFileName)
                    .IsRequired()
                    .HasMaxLength(255);

                entity.Property(e => e.SavedFileName)
                    .IsRequired()
                    .HasMaxLength(255);

                entity.Property(e => e.TicketCommentId).HasColumnName("TicketComment_Id");

                entity.HasOne(d => d.TicketComment)
                    .WithMany(p => p.TicketCommentAttachments)
                    .HasForeignKey(d => d.TicketCommentId)
                    .OnDelete(DeleteBehavior.ClientSetNull);
            });

            modelBuilder.Entity<TicketResponse>(entity =>
            {
                entity.HasIndex(e => e.CreatedById, "IX_CreatedBy_Id");

                entity.HasIndex(e => e.TicketId, "IX_Ticket_Id");

                entity.Property(e => e.Comment)
                    .IsRequired()
                    .HasMaxLength(2000);

                entity.Property(e => e.CreatedById).HasColumnName("CreatedBy_Id");

                entity.Property(e => e.CreatedTime).HasColumnType("datetime");

                entity.Property(e => e.TicketId).HasColumnName("Ticket_Id");

                entity.HasOne(d => d.CreatedBy)
                    .WithMany(p => p.TicketResponses)
                    .HasForeignKey(d => d.CreatedById)
                    .OnDelete(DeleteBehavior.ClientSetNull);

                entity.HasOne(d => d.Ticket)
                    .WithMany(p => p.TicketResponses)
                    .HasForeignKey(d => d.TicketId)
                    .OnDelete(DeleteBehavior.ClientSetNull);
            });

            modelBuilder.Entity<TimekeeperNote>(entity =>
            {
                entity.HasIndex(e => e.TimekeeperId, "IX_Timekeeper_Id");

                entity.Property(e => e.CreatedById).HasColumnName("CreatedBy_Id");

                entity.Property(e => e.Note)
                    .IsRequired()
                    .HasMaxLength(1000);

                entity.Property(e => e.NoteTimeStamp).HasColumnType("datetime");

                entity.Property(e => e.TimekeeperId).HasColumnName("Timekeeper_Id");

                entity.HasOne(d => d.CreatedBy)
                    .WithMany(p => p.TimekeeperNotes)
                    .HasForeignKey(d => d.CreatedById)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_TimekeeperNotes_Users");

                entity.HasOne(d => d.Timekeeper)
                    .WithMany(p => p.TimekeeperNotes)
                    .HasForeignKey(d => d.TimekeeperId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_TimekeeperNotes_TimekeeperNotes");
            });

            modelBuilder.Entity<TimekeeperRate>(entity =>
            {
                entity.HasNoKey();

                entity.HasIndex(e => e.BillingCode, "IX_BillingCode");

                entity.HasIndex(e => e.ClientId, "IX_Client_Id");

                entity.HasIndex(e => e.TimekeeperId, "IX_Timekeeper_Id");

                entity.HasIndex(e => e.ProductLineId, "Ix_ProductLine_Id");

                entity.Property(e => e.BillingCode).HasMaxLength(100);

                entity.Property(e => e.ClientId).HasColumnName("Client_Id");

                entity.Property(e => e.Id).ValueGeneratedOnAdd();

                entity.Property(e => e.Note).HasMaxLength(1000);

                entity.Property(e => e.ProductLineId).HasColumnName("ProductLine_Id");

                entity.Property(e => e.Rate).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.RateFrom).HasColumnType("datetime");

                entity.Property(e => e.TimekeeperId).HasColumnName("Timekeeper_Id");

                entity.HasOne(d => d.Client)
                    .WithMany()
                    .HasForeignKey(d => d.ClientId);

                entity.HasOne(d => d.ProductLine)
                    .WithMany()
                    .HasForeignKey(d => d.ProductLineId);

                entity.HasOne(d => d.Timekeeper)
                    .WithMany()
                    .HasForeignKey(d => d.TimekeeperId)
                    .OnDelete(DeleteBehavior.ClientSetNull);
            });

            modelBuilder.Entity<TmpHannaprebillIssue07Jan2021>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("tmp_hannaprebillIssue07Jan2021");
            });

            modelBuilder.Entity<TrackingMenuItem>(entity =>
            {
                entity.Property(e => e.MenuName)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TypeOfAddress>(entity =>
            {
                entity.Property(e => e.TypeName)
                    .IsRequired()
                    .HasMaxLength(20);
            });

            modelBuilder.Entity<User>(entity =>
            {
                entity.HasIndex(e => e.CreatedById, "IX_CreatedBy_Id");

                entity.HasIndex(e => e.LawFirmId, "IX_LawFirm_Id");

                entity.HasIndex(e => e.ModifiedById, "IX_ModifiedBy_Id");

                entity.HasIndex(e => e.Login, "Ix_Login");

                entity.Property(e => e.CreatedById).HasColumnName("CreatedBy_Id");

                entity.Property(e => e.CreatedTime).HasColumnType("datetime");

                entity.Property(e => e.Email).HasMaxLength(255);

                entity.Property(e => e.Fax).HasMaxLength(20);

                entity.Property(e => e.FirstName)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.Property(e => e.LastName).HasMaxLength(100);

                entity.Property(e => e.LawFirmId).HasColumnName("LawFirm_Id");

                entity.Property(e => e.Login)
                    .IsRequired()
                    .HasMaxLength(255);

                entity.Property(e => e.MiddleName).HasMaxLength(100);

                entity.Property(e => e.ModifiedById).HasColumnName("ModifiedBy_Id");

                entity.Property(e => e.ModifiedTime).HasColumnType("datetime");

                entity.Property(e => e.Password)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.Tel).HasMaxLength(20);

                entity.HasOne(d => d.CreatedBy)
                    .WithMany(p => p.InverseCreatedBy)
                    .HasForeignKey(d => d.CreatedById)
                    .OnDelete(DeleteBehavior.ClientSetNull);

                entity.HasOne(d => d.LawFirm)
                    .WithMany(p => p.Users)
                    .HasForeignKey(d => d.LawFirmId);

                entity.HasOne(d => d.ModifiedBy)
                    .WithMany(p => p.InverseModifiedBy)
                    .HasForeignKey(d => d.ModifiedById)
                    .OnDelete(DeleteBehavior.ClientSetNull);
            });

            modelBuilder.Entity<UserDefinedAction>(entity =>
            {
                entity.HasIndex(e => e.RuleEntityId, "IX_RuleEntity_Id");

                entity.HasIndex(e => e.RuleFieldId, "IX_RuleField_Id");

                entity.HasIndex(e => e.RuleId, "IX_RuleId");

                entity.Property(e => e.RuleEntityId).HasColumnName("RuleEntity_Id");

                entity.Property(e => e.RuleFieldId).HasColumnName("RuleField_Id");

                entity.Property(e => e.Value).HasMaxLength(1000);

                entity.HasOne(d => d.RuleEntity)
                    .WithMany(p => p.UserDefinedActions)
                    .HasForeignKey(d => d.RuleEntityId)
                    .OnDelete(DeleteBehavior.ClientSetNull);

                entity.HasOne(d => d.RuleField)
                    .WithMany(p => p.UserDefinedActions)
                    .HasForeignKey(d => d.RuleFieldId)
                    .OnDelete(DeleteBehavior.ClientSetNull);

                entity.HasOne(d => d.Rule)
                    .WithMany(p => p.UserDefinedActions)
                    .HasForeignKey(d => d.RuleId)
                    .OnDelete(DeleteBehavior.ClientSetNull);
            });

            modelBuilder.Entity<UserDefinedCondition>(entity =>
            {
                entity.HasIndex(e => e.RuleEntityId, "IX_RuleEntity_Id");

                entity.HasIndex(e => e.RuleFieldId, "IX_RuleField_Id");

                entity.HasIndex(e => e.RuleId, "IX_RuleId");

                entity.Property(e => e.RuleEntityId).HasColumnName("RuleEntity_Id");

                entity.Property(e => e.RuleFieldId).HasColumnName("RuleField_Id");

                entity.Property(e => e.Value).HasMaxLength(1000);

                entity.HasOne(d => d.RuleEntity)
                    .WithMany(p => p.UserDefinedConditions)
                    .HasForeignKey(d => d.RuleEntityId)
                    .OnDelete(DeleteBehavior.ClientSetNull);

                entity.HasOne(d => d.RuleField)
                    .WithMany(p => p.UserDefinedConditions)
                    .HasForeignKey(d => d.RuleFieldId)
                    .OnDelete(DeleteBehavior.ClientSetNull);

                entity.HasOne(d => d.Rule)
                    .WithMany(p => p.UserDefinedConditions)
                    .HasForeignKey(d => d.RuleId)
                    .OnDelete(DeleteBehavior.ClientSetNull);
            });

            modelBuilder.Entity<UserDefinedConditionsbackup>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("UserDefinedConditionsbackup");

                entity.Property(e => e.Id).ValueGeneratedOnAdd();

                entity.Property(e => e.RuleEntityId).HasColumnName("RuleEntity_Id");

                entity.Property(e => e.RuleFieldId).HasColumnName("RuleField_Id");

                entity.Property(e => e.Value).HasMaxLength(1000);
            });

            modelBuilder.Entity<UserLoginLog>(entity =>
            {
                entity.Property(e => e.LoginTime).HasColumnType("datetime");

                entity.Property(e => e.UserId).HasColumnName("User_Id");

                entity.Property(e => e.UserLogin)
                    .IsRequired()
                    .HasMaxLength(255);

                entity.HasOne(d => d.User)
                    .WithMany(p => p.UserLoginLogs)
                    .HasForeignKey(d => d.UserId)
                    .HasConstraintName("FK__UserLogin__User___0662F0A3");
            });

            modelBuilder.Entity<UserRole>(entity =>
            {
                entity.HasIndex(e => e.MasterRoleId, "IX_MasterRole_Id");

                entity.HasIndex(e => e.UserId, "IX_User_Id");

                entity.Property(e => e.MasterRoleId).HasColumnName("MasterRole_Id");

                entity.Property(e => e.UserId).HasColumnName("User_Id");

                entity.HasOne(d => d.MasterRole)
                    .WithMany(p => p.UserRoles)
                    .HasForeignKey(d => d.MasterRoleId)
                    .OnDelete(DeleteBehavior.ClientSetNull);

                entity.HasOne(d => d.User)
                    .WithMany(p => p.UserRoles)
                    .HasForeignKey(d => d.UserId)
                    .OnDelete(DeleteBehavior.ClientSetNull);
            });

            modelBuilder.Entity<UserdefinedActionsbackup>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("userdefinedActionsbackup");

                entity.Property(e => e.Id).ValueGeneratedOnAdd();

                entity.Property(e => e.RuleEntityId).HasColumnName("RuleEntity_Id");

                entity.Property(e => e.RuleFieldId).HasColumnName("RuleField_Id");

                entity.Property(e => e.Value).HasMaxLength(1000);
            });

            modelBuilder.Entity<VwAllBillType>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("vwAllBillTypes");

                entity.Property(e => e.AppealResponseAmount).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.AppealResponseDate).HasColumnType("datetime");

                entity.Property(e => e.AppealResponseExpenses).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.AppealResponseFees).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.AppealStatusComments)
                    .HasMaxLength(2000)
                    .IsUnicode(false);

                entity.Property(e => e.AppealedAmount).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.AppealedDate).HasColumnType("datetime");

                entity.Property(e => e.BillType)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.ClientName).HasMaxLength(255);

                entity.Property(e => e.DeductedExpenseByPayer).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.DeductedFeesByPayer).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.Ebiller).HasMaxLength(100);

                entity.Property(e => e.EbillerStatus)
                    .HasMaxLength(200)
                    .HasColumnName("EBillerStatus");

                entity.Property(e => e.ExportedDate).HasColumnType("datetime");

                entity.Property(e => e.FinalPaidAmount).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.FinalPaidAmountWithDisc).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.FinalPaidExpenses).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.FinalPaidFees).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.InvoiceCode).HasMaxLength(100);

                entity.Property(e => e.InvoiceDate).HasColumnType("datetime");

                entity.Property(e => e.InvoiceTotal).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.InvoiceTotalModified).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.Invoicecreatedby).HasColumnName("invoicecreatedby");

                entity.Property(e => e.LawFirmId).HasColumnName("LawFIrmId");

                entity.Property(e => e.LawFirmName)
                    .HasMaxLength(255)
                    .HasColumnName("LawFIrmName");

                entity.Property(e => e.PaidDate).HasColumnType("datetime");

                entity.Property(e => e.PaidExpenseWithCostShare).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.PaidExpenseWithDisc).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.PaidFeesWithCostShare).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.PaidFeesWithDisc).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.PaidTotalByPayer).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.PaidTotalWithCostShare).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.PreparedDate).HasColumnType("datetime");

                entity.Property(e => e.PromptDiscExpensePercen).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.PromptDiscFeesPercen).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.ReceivedDate).HasColumnType("datetime");

                entity.Property(e => e.RejectReason)
                    .HasMaxLength(2000)
                    .IsUnicode(false);

                entity.Property(e => e.StatusName).HasMaxLength(100);

                entity.Property(e => e.TotalDiscCred).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.TotalExpense).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.TotalExpenseModified).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.TotalFee).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.TotalTax).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.Totalfeemodified)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("totalfeemodified");

                entity.Property(e => e.UploadedDate).HasColumnType("datetime");

                entity.Property(e => e.WfstatusChangeDate)
                    .HasColumnType("datetime")
                    .HasColumnName("WFStatusChangeDate");
            });

            modelBuilder.Entity<VwArtracking>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("vw_ARTracking");

                entity.Property(e => e.Ar)
                    .HasColumnType("decimal(23, 2)")
                    .HasColumnName("AR");

                entity.Property(e => e.ClientName)
                    .IsRequired()
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.FirmMatterId).HasMaxLength(255);

                entity.Property(e => e.InvoiceAmount).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.InvoiceDate).HasColumnType("date");

                entity.Property(e => e.InvoiceNumber)
                    .IsRequired()
                    .HasMaxLength(255);

                entity.Property(e => e.InvoiceType)
                    .IsRequired()
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.MonthName)
                    .HasMaxLength(30)
                    .HasColumnName("MONTH_NAME");

                entity.Property(e => e.MonthNumber).HasColumnName("MONTH_NUMBER");

                entity.Property(e => e.PaymentReceived).HasColumnType("decimal(20, 2)");

                entity.Property(e => e.TotalWriteOff).HasColumnType("decimal(19, 2)");

                entity.Property(e => e.WeekOfMonth).HasColumnName("WEEK_OF_MONTH");

                entity.Property(e => e.YearNumber).HasColumnName("YEAR_NUMBER");
            });

            modelBuilder.Entity<VwDashboardPreBillTracking>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("vw_DashboardPreBillTracking");

                entity.Property(e => e.AppealDeadlineDate).HasColumnType("datetime");

                entity.Property(e => e.AppealStatus)
                    .IsRequired()
                    .HasMaxLength(26)
                    .IsUnicode(false);

                entity.Property(e => e.ClientName).HasMaxLength(255);

                entity.Property(e => e.Clientmatterid)
                    .HasMaxLength(50)
                    .HasColumnName("clientmatterid");

                entity.Property(e => e.Comments)
                    .HasMaxLength(2000)
                    .IsUnicode(false);

                entity.Property(e => e.CostShareAdjustment).HasColumnType("decimal(19, 2)");

                entity.Property(e => e.EbillerStatusDate)
                    .HasColumnType("datetime")
                    .HasColumnName("EBillerStatusDate");

                entity.Property(e => e.Ebillerstatus)
                    .HasMaxLength(200)
                    .HasColumnName("ebillerstatus");

                entity.Property(e => e.Exporteddate)
                    .HasColumnType("datetime")
                    .HasColumnName("exporteddate");

                entity.Property(e => e.FinalPaidAmount).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.GrossReceivable).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.InvoiceTotal).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.InvoiceTotalModified).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.InvoiceType)
                    .IsRequired()
                    .HasMaxLength(8)
                    .IsUnicode(false);

                entity.Property(e => e.Invoicecode)
                    .HasMaxLength(100)
                    .HasColumnName("invoicecode");

                entity.Property(e => e.Invoicedate)
                    .HasColumnType("datetime")
                    .HasColumnName("invoicedate");

                entity.Property(e => e.Invoicestatusid).HasColumnName("invoicestatusid");

                entity.Property(e => e.InvoicetotalmodifiedForIpscorrectionPercentage)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("InvoicetotalmodifiedForIPSCorrectionPercentage");

                entity.Property(e => e.Ipscorrection)
                    .HasColumnType("decimal(19, 2)")
                    .HasColumnName("IPSCorrection");

                entity.Property(e => e.IpscorrectionExpenses)
                    .HasColumnType("decimal(19, 2)")
                    .HasColumnName("IPSCorrectionExpenses");

                entity.Property(e => e.IpscorrectionFee)
                    .HasColumnType("decimal(19, 2)")
                    .HasColumnName("IPSCorrectionFee");

                entity.Property(e => e.IpscorrectionTotal)
                    .HasColumnType("decimal(20, 2)")
                    .HasColumnName("IPSCorrectionTotal");

                entity.Property(e => e.Lawfirmmatterid)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnName("lawfirmmatterid");

                entity.Property(e => e.MatterName).HasMaxLength(100);

                entity.Property(e => e.MonthName)
                    .HasMaxLength(30)
                    .HasColumnName("MONTH_NAME");

                entity.Property(e => e.MonthNumber).HasColumnName("MONTH_NUMBER");

                entity.Property(e => e.NetReceivable).HasColumnType("decimal(24, 2)");

                entity.Property(e => e.Newstatusname)
                    .HasMaxLength(18)
                    .IsUnicode(false)
                    .HasColumnName("newstatusname");

                entity.Property(e => e.NotSubmitted).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.OriginalExpenses).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.OriginalFee).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.OriginalTotal).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.OtherDiscounts).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.PayerApprovedAmount).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.PayerCorrectionExpenses).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.PayerCorrectionFee).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.PayerCorrectionTotal).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.PayerReduction).HasColumnType("decimal(19, 2)");

                entity.Property(e => e.PaymentReceived).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.Pending).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.PendingWriteOff).HasColumnType("decimal(21, 2)");

                entity.Property(e => e.ProcessingFees).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.PromptpayDiscounts).HasColumnType("decimal(19, 2)");

                entity.Property(e => e.StatusDate).HasColumnType("datetime");

                entity.Property(e => e.Statusname)
                    .IsRequired()
                    .HasMaxLength(100)
                    .HasColumnName("statusname");

                entity.Property(e => e.SubmittedExpenses).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.SubmittedFee).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.SubmittedTotal).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.ToPayAmount).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.Uploadeddate)
                    .HasColumnType("datetime")
                    .HasColumnName("uploadeddate");

                entity.Property(e => e.WeekOfMonth).HasColumnName("WEEK_OF_MONTH");

                entity.Property(e => e.WriteOff).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.YearNumber).HasColumnName("YEAR_NUMBER");
            });

            modelBuilder.Entity<VwDashboardTracking>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("vw_DashboardTracking");

                entity.Property(e => e.AppealDeadlineDate).HasColumnType("datetime");

                entity.Property(e => e.AppealRejectedAmount).HasColumnType("decimal(19, 2)");

                entity.Property(e => e.AppealResponseAmount).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.AppealStatus)
                    .IsRequired()
                    .HasMaxLength(26)
                    .IsUnicode(false);

                entity.Property(e => e.AppealedAmount).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.AppealedDate).HasColumnType("datetime");

                entity.Property(e => e.ClaimNumber)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.Property(e => e.ClientName).HasMaxLength(255);

                entity.Property(e => e.Clientmatterid)
                    .HasMaxLength(50)
                    .HasColumnName("clientmatterid");

                entity.Property(e => e.Comments)
                    .HasMaxLength(2000)
                    .IsUnicode(false);

                entity.Property(e => e.CostShareAdjustment).HasColumnType("decimal(19, 2)");

                entity.Property(e => e.EbillerStatusDate)
                    .HasColumnType("datetime")
                    .HasColumnName("EBillerStatusDate");

                entity.Property(e => e.Ebillerstatus)
                    .HasMaxLength(200)
                    .HasColumnName("ebillerstatus");

                entity.Property(e => e.Exporteddate)
                    .HasColumnType("datetime")
                    .HasColumnName("exporteddate");

                entity.Property(e => e.FinalPaidAmount).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.GrossReceivable).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.InvoiceTotal).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.InvoiceTotalModified).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.InvoiceType)
                    .IsRequired()
                    .HasMaxLength(8)
                    .IsUnicode(false);

                entity.Property(e => e.Invoicecode)
                    .HasMaxLength(100)
                    .HasColumnName("invoicecode");

                entity.Property(e => e.Invoicedate)
                    .HasColumnType("datetime")
                    .HasColumnName("invoicedate");

                entity.Property(e => e.Invoicestatusid).HasColumnName("invoicestatusid");

                entity.Property(e => e.InvoicetotalmodifiedForIpscorrectionPercentage)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("InvoicetotalmodifiedForIPSCorrectionPercentage");

                entity.Property(e => e.Ipscorrection)
                    .HasColumnType("decimal(19, 2)")
                    .HasColumnName("IPSCorrection");

                entity.Property(e => e.IpscorrectionExpenses)
                    .HasColumnType("decimal(19, 2)")
                    .HasColumnName("IPSCorrectionExpenses");

                entity.Property(e => e.IpscorrectionFee)
                    .HasColumnType("decimal(19, 2)")
                    .HasColumnName("IPSCorrectionFee");

                entity.Property(e => e.IpscorrectionTotal)
                    .HasColumnType("decimal(20, 2)")
                    .HasColumnName("IPSCorrectionTotal");

                entity.Property(e => e.Lawfirmmatterid)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnName("lawfirmmatterid");

                entity.Property(e => e.MatterName).HasMaxLength(100);

                entity.Property(e => e.MonthName)
                    .HasMaxLength(30)
                    .HasColumnName("MONTH_NAME");

                entity.Property(e => e.MonthNumber).HasColumnName("MONTH_NUMBER");

                entity.Property(e => e.NetReceivable).HasColumnType("decimal(24, 2)");

                entity.Property(e => e.NewAppealStatus)
                    .HasMaxLength(21)
                    .IsUnicode(false);

                entity.Property(e => e.Newstatusname)
                    .HasMaxLength(18)
                    .IsUnicode(false)
                    .HasColumnName("newstatusname");

                entity.Property(e => e.NotSubmitted).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.OriginalExpenses).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.OriginalFee).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.OriginalTotal).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.OtherDiscounts).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.PayerAdjustmentExpense).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.PayerAdjustmentFee).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.PayerAdjustments).HasColumnType("decimal(19, 2)");

                entity.Property(e => e.PayerApprovedAmount).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.PayerCorrectionExpenses).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.PayerCorrectionFee).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.PayerCorrectionTotal).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.PayerReduction).HasColumnType("decimal(19, 2)");

                entity.Property(e => e.PayerReductionBeforeAppeal).HasColumnType("decimal(19, 2)");

                entity.Property(e => e.PaymentReceived).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.Pending).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.PendingWriteOff).HasColumnType("decimal(21, 2)");

                entity.Property(e => e.PreparedDate).HasColumnType("datetime");

                entity.Property(e => e.ProcessingFees).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.PromptpayDiscounts).HasColumnType("decimal(19, 2)");

                entity.Property(e => e.StatusDate).HasColumnType("datetime");

                entity.Property(e => e.Statusname)
                    .IsRequired()
                    .HasMaxLength(100)
                    .HasColumnName("statusname");

                entity.Property(e => e.SubmittedExpenses).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.SubmittedFee).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.SubmittedTotal).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.ToPayAmount).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.Uploadeddate)
                    .HasColumnType("datetime")
                    .HasColumnName("uploadeddate");

                entity.Property(e => e.WeekOfMonth).HasColumnName("WEEK_OF_MONTH");

                entity.Property(e => e.WriteOff).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.YearNumber).HasColumnName("YEAR_NUMBER");
            });

            modelBuilder.Entity<VwDashboardTrackingAll>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("vw_DashboardTracking_All");

                entity.Property(e => e.AppealDeadlineDate).HasColumnType("datetime");

                entity.Property(e => e.AppealRejectedAmount).HasColumnType("decimal(19, 2)");

                entity.Property(e => e.AppealResponseAmount).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.AppealStatus)
                    .IsRequired()
                    .HasMaxLength(26)
                    .IsUnicode(false);

                entity.Property(e => e.AppealedAmount).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.AppealedDate).HasColumnType("datetime");

                entity.Property(e => e.ClaimNumber)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.Property(e => e.ClientName).HasMaxLength(255);

                entity.Property(e => e.Clientmatterid)
                    .HasMaxLength(50)
                    .HasColumnName("clientmatterid");

                entity.Property(e => e.Comments)
                    .HasMaxLength(2000)
                    .IsUnicode(false);

                entity.Property(e => e.CostShareAdjustment).HasColumnType("decimal(19, 2)");

                entity.Property(e => e.EbillerStatusDate)
                    .HasColumnType("datetime")
                    .HasColumnName("EBillerStatusDate");

                entity.Property(e => e.Ebillerstatus)
                    .HasMaxLength(200)
                    .HasColumnName("ebillerstatus");

                entity.Property(e => e.Exporteddate)
                    .HasColumnType("datetime")
                    .HasColumnName("exporteddate");

                entity.Property(e => e.FinalPaidAmount).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.GrossReceivable).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.InvoiceTotal).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.InvoiceTotalModified).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.InvoiceType)
                    .IsRequired()
                    .HasMaxLength(8)
                    .IsUnicode(false);

                entity.Property(e => e.Invoicecode)
                    .HasMaxLength(100)
                    .HasColumnName("invoicecode");

                entity.Property(e => e.Invoicedate)
                    .HasColumnType("datetime")
                    .HasColumnName("invoicedate");

                entity.Property(e => e.Invoicestatusid).HasColumnName("invoicestatusid");

                entity.Property(e => e.InvoicetotalmodifiedForIpscorrectionPercentage)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("InvoicetotalmodifiedForIPSCorrectionPercentage");

                entity.Property(e => e.Ipscorrection)
                    .HasColumnType("decimal(19, 2)")
                    .HasColumnName("IPSCorrection");

                entity.Property(e => e.IpscorrectionExpenses)
                    .HasColumnType("decimal(19, 2)")
                    .HasColumnName("IPSCorrectionExpenses");

                entity.Property(e => e.IpscorrectionFee)
                    .HasColumnType("decimal(19, 2)")
                    .HasColumnName("IPSCorrectionFee");

                entity.Property(e => e.IpscorrectionTotal)
                    .HasColumnType("decimal(20, 2)")
                    .HasColumnName("IPSCorrectionTotal");

                entity.Property(e => e.LawfirmName)
                    .IsRequired()
                    .HasMaxLength(255);

                entity.Property(e => e.Lawfirmmatterid)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnName("lawfirmmatterid");

                entity.Property(e => e.MatterName).HasMaxLength(100);

                entity.Property(e => e.MonthName)
                    .HasMaxLength(30)
                    .HasColumnName("MONTH_NAME");

                entity.Property(e => e.MonthNumber).HasColumnName("MONTH_NUMBER");

                entity.Property(e => e.NetReceivable).HasColumnType("decimal(24, 2)");

                entity.Property(e => e.NewAppealStatus)
                    .HasMaxLength(21)
                    .IsUnicode(false);

                entity.Property(e => e.Newstatusname)
                    .HasMaxLength(18)
                    .IsUnicode(false)
                    .HasColumnName("newstatusname");

                entity.Property(e => e.NotSubmitted).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.OriginalExpenses).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.OriginalFee).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.OriginalTotal).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.OtherDiscounts).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.PayerAdjustmentExpense).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.PayerAdjustmentFee).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.PayerAdjustments).HasColumnType("decimal(19, 2)");

                entity.Property(e => e.PayerApprovedAmount).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.PayerCorrectionExpenses).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.PayerCorrectionFee).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.PayerCorrectionTotal).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.PayerReduction).HasColumnType("decimal(19, 2)");

                entity.Property(e => e.PayerReductionBeforeAppeal).HasColumnType("decimal(19, 2)");

                entity.Property(e => e.PaymentReceived).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.Pending).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.PendingWriteOff).HasColumnType("decimal(21, 2)");

                entity.Property(e => e.PreparedDate).HasColumnType("datetime");

                entity.Property(e => e.ProcessingFees).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.PromptpayDiscounts).HasColumnType("decimal(19, 2)");

                entity.Property(e => e.StatusDate).HasColumnType("datetime");

                entity.Property(e => e.Statusname)
                    .IsRequired()
                    .HasMaxLength(100)
                    .HasColumnName("statusname");

                entity.Property(e => e.SubmittedExpenses).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.SubmittedFee).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.SubmittedTotal).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.ToPayAmount).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.Uploadeddate)
                    .HasColumnType("datetime")
                    .HasColumnName("uploadeddate");

                entity.Property(e => e.WeekOfMonth).HasColumnName("WEEK_OF_MONTH");

                entity.Property(e => e.WriteOff).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.YearNumber).HasColumnName("YEAR_NUMBER");
            });

            modelBuilder.Entity<VwInvoice>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("vwInvoices");

                entity.Property(e => e.AppealResponseAmount).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.AppealResponseExpenses).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.AppealResponseFees).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.AppealStatusComments)
                    .HasMaxLength(2000)
                    .IsUnicode(false);

                entity.Property(e => e.ClientName).HasMaxLength(255);

                entity.Property(e => e.DeductedExpenseByPayer).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.DeductedFeesByPayer).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.Ebiller).HasMaxLength(100);

                entity.Property(e => e.EbillerCostshareAdjustments).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.EbillerGuidelineAdjustments).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.EbillerOriginalBilledAmount).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.EbillerOriginalBilledExpenses).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.EbillerOriginalBilledFees).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.EbillerOtherDiscountDescription)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.EbillerOtherDiscounts).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.EbillerProcessingFees).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.EbillerPromptPayDiscounts).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.EbillerStatus)
                    .HasMaxLength(200)
                    .HasColumnName("EBillerStatus");

                entity.Property(e => e.EbillerToPayAmount).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.Exporteddate).HasColumnType("datetime");

                entity.Property(e => e.FinalPaidAmount).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.FinalPaidAmountWithDisc).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.FinalPaidExpenses).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.FinalPaidFees).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.FinalPaymentReceivedAmount).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.InitialPaymentReceivedAmount).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.InvoiceCode).HasMaxLength(100);

                entity.Property(e => e.InvoiceDate).HasColumnType("datetime");

                entity.Property(e => e.InvoiceTotal).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.InvoiceTotalModified).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.LawFirmId).HasColumnName("LawFIrmId");

                entity.Property(e => e.LawFirmName)
                    .HasMaxLength(255)
                    .HasColumnName("LawFIrmName");

                entity.Property(e => e.PaidDate).HasColumnType("datetime");

                entity.Property(e => e.PaidExpenseWithCostShare).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.PaidExpenseWithDisc).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.PaidFeesWithCostShare).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.PaidFeesWithDisc).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.PaidTotalByPayer).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.PaidTotalWithCostShare).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.PreparedDate).HasColumnType("datetime");

                entity.Property(e => e.PromptDiscExpensePercen).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.PromptDiscFeesPercen).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.ReceivedDate).HasColumnType("datetime");

                entity.Property(e => e.RejectReason)
                    .HasMaxLength(2000)
                    .IsUnicode(false);

                entity.Property(e => e.StatusName).HasMaxLength(100);

                entity.Property(e => e.SubmittedToPayerDate).HasColumnType("datetime");

                entity.Property(e => e.TotalDiscCred).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.TotalExpense).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.TotalExpenseModified).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.TotalFeeModified).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.TotalTax).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.Totalfee).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.UploadedDate).HasColumnType("datetime");

                entity.Property(e => e.WfstatusChangeDate)
                    .HasColumnType("datetime")
                    .HasColumnName("WFStatusChangeDate");

                entity.Property(e => e.WriteOffReceivedAmount).HasColumnType("decimal(18, 2)");
            });

            modelBuilder.Entity<VwInvoiceInvalidation>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("vwInvoiceInvalidations");

                entity.Property(e => e.AppealResponseAmount).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.AppealResponseExpenses).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.AppealResponseFees).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.ClientName).HasMaxLength(255);

                entity.Property(e => e.DeductedExpenseByPayer).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.DeductedFeesByPayer).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.Ebiller).HasMaxLength(100);

                entity.Property(e => e.EbillerCostshareAdjustments).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.EbillerExpenseAdjAmount)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("Ebiller_ExpenseAdjAmount");

                entity.Property(e => e.EbillerExpenseCostShareAdjAmount)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("Ebiller_ExpenseCostShareAdjAmount");

                entity.Property(e => e.EbillerExpenseCostSharePercent)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("Ebiller_ExpenseCostSharePercent");

                entity.Property(e => e.EbillerExpenseCurrentAmount)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("Ebiller_ExpenseCurrentAmount");

                entity.Property(e => e.EbillerExpenseOrigAmount)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("Ebiller_ExpenseOrigAmount");

                entity.Property(e => e.EbillerExpenseToPayAmount)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("Ebiller_ExpenseToPayAmount");

                entity.Property(e => e.EbillerFeeAdjAmount)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("Ebiller_FeeAdjAmount");

                entity.Property(e => e.EbillerFeeCostShareAdjAmount)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("Ebiller_FeeCostShareAdjAmount");

                entity.Property(e => e.EbillerFeeCostSharePercent)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("Ebiller_FeeCostSharePercent");

                entity.Property(e => e.EbillerFeeCurrentAmount)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("Ebiller_FeeCurrentAmount");

                entity.Property(e => e.EbillerFeeOrigAmount)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("Ebiller_FeeOrigAmount");

                entity.Property(e => e.EbillerFeeToPayAmount)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("Ebiller_FeeToPayAmount");

                entity.Property(e => e.EbillerGuidelineAdjustments).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.EbillerInvNetTotal)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("Ebiller_InvNetTotal");

                entity.Property(e => e.EbillerInvStatus)
                    .HasMaxLength(200)
                    .IsUnicode(false)
                    .HasColumnName("Ebiller_InvStatus");

                entity.Property(e => e.EbillerOriginalBilledAmount).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.EbillerOriginalBilledExpenses).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.EbillerOriginalBilledFees).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.EbillerOtherDiscountDescription)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.EbillerOtherDiscounts).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.EbillerProcessingFees).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.EbillerProcessingFees1)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("Ebiller_ProcessingFees");

                entity.Property(e => e.EbillerPromptPayAmount)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("Ebiller_PromptPayAmount");

                entity.Property(e => e.EbillerPromptPayDiscounts).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.EbillerStatus)
                    .HasMaxLength(200)
                    .HasColumnName("EBillerStatus");

                entity.Property(e => e.EbillerToPayAmount).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.EbillerTotalAdjAmount)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("Ebiller_TotalAdjAmount");

                entity.Property(e => e.EbillerTotalApprovedIncludingAppeal)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("Ebiller_TotalApprovedIncludingAppeal");

                entity.Property(e => e.EbillerTotalCostShareAdjAmount)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("Ebiller_TotalCostShareAdjAmount");

                entity.Property(e => e.EbillerTotalCurrentAmount)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("Ebiller_TotalCurrentAmount");

                entity.Property(e => e.EbillerTotalOrigAmount)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("Ebiller_TotalOrigAmount");

                entity.Property(e => e.EbillerTotalToPayAmount)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("Ebiller_TotalToPayAmount");

                entity.Property(e => e.FinalPaidAmount).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.FinalPaidAmountWithDisc).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.FinalPaidExpenses).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.FinalPaidFees).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.FinalPaymentReceivedAmount).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.InitialPaymentReceivedAmount).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.InvoiceCode).HasMaxLength(100);

                entity.Property(e => e.InvoiceDate).HasColumnType("datetime");

                entity.Property(e => e.InvoiceTotal).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.InvoiceTotalModified).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.InvoiceValidationEbiller)
                    .IsRequired()
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.LawFirmId).HasColumnName("LawFIrmId");

                entity.Property(e => e.LawFirmName)
                    .HasMaxLength(255)
                    .HasColumnName("LawFIrmName");

                entity.Property(e => e.PaidExpenseWithCostShare).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.PaidExpenseWithDisc).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.PaidFeesWithCostShare).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.PaidFeesWithDisc).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.PaidTotalByPayer).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.PaidTotalWithCostShare).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.PromptDiscExpensePercen).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.PromptDiscFeesPercen).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.StatusName).HasMaxLength(100);

                entity.Property(e => e.TotalAppealAllowed).HasColumnType("decimal(20, 2)");

                entity.Property(e => e.UploadedDate).HasColumnType("datetime");

                entity.Property(e => e.WfstatusChangeDate)
                    .HasColumnType("datetime")
                    .HasColumnName("WFStatusChangeDate");

                entity.Property(e => e.WriteOffReceivedAmount).HasColumnType("decimal(18, 2)");
            });

            modelBuilder.Entity<VwInvoiceswithoutprebill>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("vwInvoiceswithoutprebills");

                entity.Property(e => e.AppealResponseAmount).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.AppealResponseExpenses).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.AppealResponseFees).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.ClientName).HasMaxLength(255);

                entity.Property(e => e.DeductedExpenseByPayer).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.DeductedFeesByPayer).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.Ebiller).HasMaxLength(100);

                entity.Property(e => e.EbillerStatus)
                    .HasMaxLength(200)
                    .HasColumnName("EBillerStatus");

                entity.Property(e => e.FinalPaidAmount).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.FinalPaidAmountWithDisc).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.FinalPaidExpenses).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.FinalPaidFees).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.InvoiceCode).HasMaxLength(100);

                entity.Property(e => e.InvoiceDate).HasColumnType("datetime");

                entity.Property(e => e.InvoiceTotal).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.InvoiceTotalModified).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.LawFirmId).HasColumnName("LawFIrmId");

                entity.Property(e => e.LawFirmName)
                    .HasMaxLength(255)
                    .HasColumnName("LawFIrmName");

                entity.Property(e => e.PaidExpenseWithCostShare).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.PaidExpenseWithDisc).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.PaidFeesWithCostShare).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.PaidFeesWithDisc).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.PaidTotalByPayer).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.PaidTotalWithCostShare).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.PromptDiscExpensePercen).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.PromptDiscFeesPercen).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.StatusName).HasMaxLength(100);

                entity.Property(e => e.UploadedDate).HasColumnType("datetime");

                entity.Property(e => e.WfstatusChangeDate)
                    .HasColumnType("datetime")
                    .HasColumnName("WFStatusChangeDate");
            });

            modelBuilder.Entity<VwInvoiceswithstatusexclude>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("vwInvoiceswithstatusexclude");

                entity.Property(e => e.AppealResponseAmount).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.AppealResponseDate).HasColumnType("datetime");

                entity.Property(e => e.AppealResponseExpenses).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.AppealResponseFees).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.AppealStatusComments)
                    .HasMaxLength(2000)
                    .IsUnicode(false);

                entity.Property(e => e.AppealedAmount).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.AppealedDate).HasColumnType("datetime");

                entity.Property(e => e.ClientName).HasMaxLength(255);

                entity.Property(e => e.DeductedExpenseByPayer).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.DeductedFeesByPayer).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.Ebiller).HasMaxLength(100);

                entity.Property(e => e.EbillerStatus)
                    .HasMaxLength(200)
                    .HasColumnName("EBillerStatus");

                entity.Property(e => e.ExportedDate).HasColumnType("datetime");

                entity.Property(e => e.FinalPaidAmount).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.FinalPaidAmountWithDisc).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.FinalPaidExpenses).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.FinalPaidFees).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.InvoiceCode).HasMaxLength(100);

                entity.Property(e => e.InvoiceDate).HasColumnType("datetime");

                entity.Property(e => e.InvoiceTotal).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.InvoiceTotalModified).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.Invoicecreatedby).HasColumnName("invoicecreatedby");

                entity.Property(e => e.LawFirmId).HasColumnName("LawFIrmId");

                entity.Property(e => e.LawFirmName)
                    .HasMaxLength(255)
                    .HasColumnName("LawFIrmName");

                entity.Property(e => e.PaidDate).HasColumnType("datetime");

                entity.Property(e => e.PaidExpenseWithCostShare).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.PaidExpenseWithDisc).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.PaidFeesWithCostShare).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.PaidFeesWithDisc).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.PaidTotalByPayer).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.PaidTotalWithCostShare).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.PreparedDate).HasColumnType("datetime");

                entity.Property(e => e.PromptDiscExpensePercen).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.PromptDiscFeesPercen).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.ReceivedDate).HasColumnType("datetime");

                entity.Property(e => e.RejectReason)
                    .HasMaxLength(2000)
                    .IsUnicode(false);

                entity.Property(e => e.StatusName).HasMaxLength(100);

                entity.Property(e => e.TotalDiscCred).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.TotalExpense).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.TotalExpenseModified).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.TotalFee).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.TotalTax).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.Totalfeemodified)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("totalfeemodified");

                entity.Property(e => e.UploadedDate).HasColumnType("datetime");

                entity.Property(e => e.WfstatusChangeDate)
                    .HasColumnType("datetime")
                    .HasColumnName("WFStatusChangeDate");
            });

            modelBuilder.Entity<VwPreBill>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("vwPreBills");

                entity.Property(e => e.AppealResponseAmount).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.AppealResponseExpenses).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.AppealResponseFees).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.AppealStatusComments)
                    .HasMaxLength(2000)
                    .IsUnicode(false);

                entity.Property(e => e.ClientName).HasMaxLength(255);

                entity.Property(e => e.DeductedExpenseByPayer).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.DeductedFeesByPayer).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.Ebiller).HasMaxLength(100);

                entity.Property(e => e.EbillerStatus)
                    .HasMaxLength(200)
                    .HasColumnName("EBillerStatus");

                entity.Property(e => e.Exporteddate).HasColumnType("datetime");

                entity.Property(e => e.FinalPaidAmount).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.FinalPaidAmountWithDisc).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.FinalPaidExpenses).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.FinalPaidFees).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.InvoiceCode).HasMaxLength(100);

                entity.Property(e => e.InvoiceDate).HasColumnType("datetime");

                entity.Property(e => e.InvoiceTotal).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.InvoiceTotalModified).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.LawFirmId).HasColumnName("LawFIrmId");

                entity.Property(e => e.LawFirmName)
                    .HasMaxLength(255)
                    .HasColumnName("LawFIrmName");

                entity.Property(e => e.PaidDate).HasColumnType("datetime");

                entity.Property(e => e.PaidExpenseWithCostShare).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.PaidExpenseWithDisc).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.PaidFeesWithCostShare).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.PaidFeesWithDisc).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.PaidTotalByPayer).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.PaidTotalWithCostShare).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.PreparedDate).HasColumnType("datetime");

                entity.Property(e => e.PromptDiscExpensePercen).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.PromptDiscFeesPercen).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.ReceivedDate).HasColumnType("datetime");

                entity.Property(e => e.RejectReason)
                    .HasMaxLength(2000)
                    .IsUnicode(false);

                entity.Property(e => e.StatusName).HasMaxLength(100);

                entity.Property(e => e.TotalDiscCred).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.TotalExpense).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.TotalExpenseModified).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.TotalFeeModified).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.TotalTax).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.Totalfee).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.UploadedDate).HasColumnType("datetime");

                entity.Property(e => e.WfstatusChangeDate)
                    .HasColumnType("datetime")
                    .HasColumnName("WFStatusChangeDate");
            });

            modelBuilder.Entity<VwPreBillswithstatusexclude>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("vwPreBillswithstatusexclude");

                entity.Property(e => e.AppealResponseAmount).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.AppealResponseDate).HasColumnType("datetime");

                entity.Property(e => e.AppealResponseExpenses).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.AppealResponseFees).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.AppealStatusComments)
                    .HasMaxLength(2000)
                    .IsUnicode(false);

                entity.Property(e => e.AppealedAmount).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.AppealedDate).HasColumnType("datetime");

                entity.Property(e => e.ClientName).HasMaxLength(255);

                entity.Property(e => e.DeductedExpenseByPayer).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.DeductedFeesByPayer).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.Ebiller).HasMaxLength(100);

                entity.Property(e => e.EbillerStatus)
                    .HasMaxLength(200)
                    .HasColumnName("EBillerStatus");

                entity.Property(e => e.ExportedDate).HasColumnType("datetime");

                entity.Property(e => e.FinalPaidAmount).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.FinalPaidAmountWithDisc).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.FinalPaidExpenses).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.FinalPaidFees).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.InvoiceCode).HasMaxLength(100);

                entity.Property(e => e.InvoiceDate).HasColumnType("datetime");

                entity.Property(e => e.InvoiceTotal).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.InvoiceTotalModified).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.Invoicecreatedby).HasColumnName("invoicecreatedby");

                entity.Property(e => e.LawFirmId).HasColumnName("LawFIrmId");

                entity.Property(e => e.LawFirmName)
                    .HasMaxLength(255)
                    .HasColumnName("LawFIrmName");

                entity.Property(e => e.PaidDate).HasColumnType("datetime");

                entity.Property(e => e.PaidExpenseWithCostShare).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.PaidExpenseWithDisc).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.PaidFeesWithCostShare).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.PaidFeesWithDisc).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.PaidTotalByPayer).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.PaidTotalWithCostShare).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.PreparedDate).HasColumnType("datetime");

                entity.Property(e => e.PromptDiscExpensePercen).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.PromptDiscFeesPercen).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.ReceivedDate).HasColumnType("datetime");

                entity.Property(e => e.RejectReason)
                    .HasMaxLength(2000)
                    .IsUnicode(false);

                entity.Property(e => e.StatusName).HasMaxLength(100);

                entity.Property(e => e.TotalDiscCred).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.TotalExpense).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.TotalExpenseModified).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.TotalFee).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.TotalTax).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.Totalfeemodified)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("totalfeemodified");

                entity.Property(e => e.UploadedDate).HasColumnType("datetime");

                entity.Property(e => e.WfstatusChangeDate)
                    .HasColumnType("datetime")
                    .HasColumnName("WFStatusChangeDate");
            });

            modelBuilder.Entity<WanekLibertyInvoiceclient>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("Wanek_liberty_invoiceclients");

                entity.Property(e => e.AddressAddress1)
                    .HasMaxLength(100)
                    .HasColumnName("Address_Address1");

                entity.Property(e => e.AddressAddress2)
                    .HasMaxLength(100)
                    .HasColumnName("Address_Address2");

                entity.Property(e => e.AddressAddress3)
                    .HasMaxLength(100)
                    .HasColumnName("Address_Address3");

                entity.Property(e => e.AddressCity)
                    .HasMaxLength(100)
                    .HasColumnName("Address_City");

                entity.Property(e => e.AddressCountry)
                    .HasMaxLength(100)
                    .HasColumnName("Address_Country");

                entity.Property(e => e.AddressFax)
                    .HasMaxLength(20)
                    .HasColumnName("Address_Fax");

                entity.Property(e => e.AddressPhone)
                    .HasMaxLength(20)
                    .HasColumnName("Address_Phone");

                entity.Property(e => e.AddressStateProvince)
                    .HasMaxLength(100)
                    .HasColumnName("Address_StateProvince");

                entity.Property(e => e.AddressZipPostalCode)
                    .HasMaxLength(100)
                    .HasColumnName("Address_ZipPostalCode");

                entity.Property(e => e.ClientCode).HasMaxLength(100);

                entity.Property(e => e.ClientCodeModified).HasMaxLength(100);

                entity.Property(e => e.ClientId).HasColumnName("Client_Id");

                entity.Property(e => e.ContactContactCode)
                    .HasMaxLength(100)
                    .HasColumnName("Contact_ContactCode");

                entity.Property(e => e.ContactEmail)
                    .HasMaxLength(255)
                    .HasColumnName("Contact_Email");

                entity.Property(e => e.ContactFax)
                    .HasMaxLength(20)
                    .HasColumnName("Contact_Fax");

                entity.Property(e => e.ContactFirstName)
                    .HasMaxLength(100)
                    .HasColumnName("Contact_FirstName");

                entity.Property(e => e.ContactLastName)
                    .HasMaxLength(100)
                    .HasColumnName("Contact_LastName");

                entity.Property(e => e.ContactPhone)
                    .HasMaxLength(20)
                    .HasColumnName("Contact_Phone");

                entity.Property(e => e.Id).ValueGeneratedOnAdd();

                entity.Property(e => e.InvoiceFirmId).HasColumnName("InvoiceFirm_Id");

                entity.Property(e => e.LawFirmCode).HasMaxLength(100);

                entity.Property(e => e.Name).HasMaxLength(255);

                entity.Property(e => e.TaxId).HasMaxLength(20);
            });

            modelBuilder.Entity<WanekLibertyMatter>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("Wanek_Liberty_matters");

                entity.Property(e => e.AddlReferenceNo).HasMaxLength(100);

                entity.Property(e => e.BillingTypeId).HasColumnName("BillingType_Id");

                entity.Property(e => e.ClaimAmount).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.ClaimEndDate).HasColumnType("datetime");

                entity.Property(e => e.ClientId).HasColumnName("Client_Id");

                entity.Property(e => e.ClientMatterId)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.CreatedById).HasColumnName("CreatedBy_Id");

                entity.Property(e => e.CreatedTime).HasColumnType("datetime");

                entity.Property(e => e.DateAssigned).HasColumnType("datetime");

                entity.Property(e => e.DateClosed).HasColumnType("datetime");

                entity.Property(e => e.DateOfLoss).HasColumnType("datetime");

                entity.Property(e => e.Description).HasMaxLength(1000);

                entity.Property(e => e.EbillerReference1)
                    .HasMaxLength(100)
                    .HasColumnName("EBillerReference1");

                entity.Property(e => e.EbillerReference2)
                    .HasMaxLength(100)
                    .HasColumnName("EBillerReference2");

                entity.Property(e => e.EbillerStatus)
                    .HasMaxLength(200)
                    .HasColumnName("EBillerStatus");

                entity.Property(e => e.EbillerStatusChangeDate)
                    .HasColumnType("datetime")
                    .HasColumnName("EBillerStatusChangeDate");

                entity.Property(e => e.EbillerStatusCheckDate)
                    .HasColumnType("datetime")
                    .HasColumnName("EBillerStatusCheckDate");

                entity.Property(e => e.EbillerStatusComments)
                    .HasMaxLength(2000)
                    .HasColumnName("EBillerStatusComments");

                entity.Property(e => e.Id).ValueGeneratedOnAdd();

                entity.Property(e => e.Jurisdiction).HasMaxLength(50);

                entity.Property(e => e.LawFirmId).HasColumnName("LawFirm_Id");

                entity.Property(e => e.LawFirmMatterId).HasMaxLength(50);

                entity.Property(e => e.MasterUtbmsCodeSetId).HasColumnName("MasterUtbmsCodeSet_Id");

                entity.Property(e => e.ModifiedById).HasColumnName("ModifiedBy_Id");

                entity.Property(e => e.ModifiedTime).HasColumnType("datetime");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.Property(e => e.ProductLineId).HasColumnName("ProductLine_Id");

                entity.Property(e => e.ProductLineOtherText).HasMaxLength(100);

                entity.Property(e => e.SettlementAmount).HasColumnType("decimal(18, 2)");
            });

            modelBuilder.Entity<WanekLibertyTimekeeperRate>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("wanek_liberty_TimekeeperRates");

                entity.Property(e => e.BillingCode).HasMaxLength(100);

                entity.Property(e => e.ClientId).HasColumnName("Client_Id");

                entity.Property(e => e.Id).ValueGeneratedOnAdd();

                entity.Property(e => e.Note).HasMaxLength(1000);

                entity.Property(e => e.ProductLineId).HasColumnName("ProductLine_Id");

                entity.Property(e => e.Rate).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.RateFrom).HasColumnType("datetime");

                entity.Property(e => e.TimekeeperId).HasColumnName("Timekeeper_Id");
            });

            modelBuilder.Entity<WorkDistributionRule>(entity =>
            {
                entity.HasIndex(e => e.ClientId, "IX_Client_Id");

                entity.HasIndex(e => e.CreatedById, "IX_CreatedBy_Id");

                entity.HasIndex(e => e.LawFirmId, "IX_LawFirm_Id");

                entity.HasIndex(e => e.ModifiedById, "IX_ModifiedBy_Id");

                entity.Property(e => e.ClientId).HasColumnName("Client_Id");

                entity.Property(e => e.CreatedById).HasColumnName("CreatedBy_Id");

                entity.Property(e => e.CreatedTime).HasColumnType("datetime");

                entity.Property(e => e.Description).HasMaxLength(1000);

                entity.Property(e => e.InvoiceTotal).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.LawFirmId).HasColumnName("LawFirm_Id");

                entity.Property(e => e.ModifiedById).HasColumnName("ModifiedBy_Id");

                entity.Property(e => e.ModifiedTime).HasColumnType("datetime");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.HasOne(d => d.Client)
                    .WithMany(p => p.WorkDistributionRules)
                    .HasForeignKey(d => d.ClientId);

                entity.HasOne(d => d.CreatedBy)
                    .WithMany(p => p.WorkDistributionRuleCreatedBies)
                    .HasForeignKey(d => d.CreatedById)
                    .OnDelete(DeleteBehavior.ClientSetNull);

                entity.HasOne(d => d.LawFirm)
                    .WithMany(p => p.WorkDistributionRules)
                    .HasForeignKey(d => d.LawFirmId);

                entity.HasOne(d => d.ModifiedBy)
                    .WithMany(p => p.WorkDistributionRuleModifiedBies)
                    .HasForeignKey(d => d.ModifiedById)
                    .OnDelete(DeleteBehavior.ClientSetNull);
            });

            modelBuilder.Entity<WorkDistributionRuleUser>(entity =>
            {
                entity.HasIndex(e => e.PreparerId, "IX_Preparer_Id");

                entity.HasIndex(e => e.WorkDistributionRuleId, "IX_WorkDistributionRule_Id");

                entity.Property(e => e.PreparerId).HasColumnName("Preparer_Id");

                entity.Property(e => e.WorkDistributionRuleId).HasColumnName("WorkDistributionRule_Id");

                entity.HasOne(d => d.Preparer)
                    .WithMany(p => p.WorkDistributionRuleUsers)
                    .HasForeignKey(d => d.PreparerId)
                    .OnDelete(DeleteBehavior.ClientSetNull);

                entity.HasOne(d => d.WorkDistributionRule)
                    .WithMany(p => p.WorkDistributionRuleUsers)
                    .HasForeignKey(d => d.WorkDistributionRuleId)
                    .OnDelete(DeleteBehavior.ClientSetNull);
            });

            modelBuilder.Entity<XaiTesting28>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("XAI_Testing_28");

                entity.Property(e => e.CategoryName)
                    .IsRequired()
                    .HasMaxLength(255);

                entity.Property(e => e.ChargeDesciption).HasMaxLength(4000);

                entity.Property(e => e.Lineid).HasColumnName("lineid");

                entity.Property(e => e.Rate).HasColumnType("decimal(18, 4)");

                entity.Property(e => e.Units).HasColumnType("decimal(18, 2)");
            });

            modelBuilder.Entity<XaiTesting28NoRule>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("XAI_Testing_28_NoRule");

                entity.Property(e => e.CategoryName)
                    .IsRequired()
                    .HasMaxLength(255);

                entity.Property(e => e.ChargeDesciption).HasMaxLength(4000);

                entity.Property(e => e.Lineid).HasColumnName("lineid");

                entity.Property(e => e.Rate).HasColumnType("decimal(18, 4)");

                entity.Property(e => e.Units).HasColumnType("decimal(18, 2)");
            });

            modelBuilder.Entity<XaiTesting28Rule>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("XAI_Testing_28_Rule");

                entity.Property(e => e.CategoryName)
                    .IsRequired()
                    .HasMaxLength(255);

                entity.Property(e => e.ChargeDesciption).HasMaxLength(4000);

                entity.Property(e => e.Lineid).HasColumnName("lineid");

                entity.Property(e => e.Rate).HasColumnType("decimal(18, 4)");

                entity.Property(e => e.Units).HasColumnType("decimal(18, 2)");
            });

            modelBuilder.Entity<Xxaii>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("xxaii");

                entity.Property(e => e.ChargeDesciption).HasMaxLength(4000);

                entity.Property(e => e.ChargeDesciptionModified).HasMaxLength(4000);

                entity.Property(e => e.InvoiceNumber).HasMaxLength(100);

                entity.Property(e => e.Invoicetotal)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("invoicetotal");

                entity.Property(e => e.Invoicetotalmodified)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("invoicetotalmodified");

                entity.Property(e => e.Lawfirm)
                    .IsRequired()
                    .HasMaxLength(255);

                entity.Property(e => e.LineItemType)
                    .IsRequired()
                    .HasMaxLength(7)
                    .IsUnicode(false);

                entity.Property(e => e.Payer)
                    .IsRequired()
                    .HasMaxLength(255);

                entity.Property(e => e.Rate).HasColumnType("decimal(18, 4)");

                entity.Property(e => e.RateModified).HasColumnType("decimal(18, 4)");

                entity.Property(e => e.RuleCategory).HasMaxLength(255);

                entity.Property(e => e.TaskActivityCodeModified).HasMaxLength(100);

                entity.Property(e => e.TaskCodeModified).HasMaxLength(100);

                entity.Property(e => e.Tkcode)
                    .HasMaxLength(50)
                    .HasColumnName("TKcode");

                entity.Property(e => e.TotalAmount).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.TotalAmountModified).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.Units).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.UnitsModified).HasColumnType("decimal(18, 2)");
            });

            modelBuilder.Entity<ZarwinAutomationRunsep2019>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("zarwinAutomationRunsep2019");

                entity.Property(e => e.Id).HasColumnName("id");
            });

            modelBuilder.Entity<ZcAiLawfirmMapping>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("ZC_AI_LawfirmMapping");

                entity.Property(e => e.LawfirmId).HasColumnName("lawfirmId");

                entity.Property(e => e.MappedName)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("mappedName");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(255)
                    .HasColumnName("name");
            });

            modelBuilder.Entity<ZcAiTesting>(entity =>
            {
                entity.ToTable("ZC_AI_Testing");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.CategoryName)
                    .IsRequired()
                    .HasMaxLength(255);

                entity.Property(e => e.ChargeDesciption).HasMaxLength(4000);

                entity.Property(e => e.ClientId).HasColumnName("Client_Id");

                entity.Property(e => e.InvId).HasColumnName("invId");

                entity.Property(e => e.IsModified).HasColumnName("isModified");

                entity.Property(e => e.Lineid).HasColumnName("lineid");

                entity.Property(e => e.Rate).HasColumnType("decimal(18, 4)");

                entity.Property(e => e.RuleId).HasColumnName("ruleId");

                entity.Property(e => e.Units).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.Uploadeddate)
                    .HasColumnType("datetime")
                    .HasColumnName("uploadeddate");
            });

            modelBuilder.Entity<ZcAiTestingRule>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("ZC_AI_TestingRules");

                entity.Property(e => e.Description)
                    .HasMaxLength(1000)
                    .HasColumnName("description");

                entity.Property(e => e.Id)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("id");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(255)
                    .HasColumnName("name");

                entity.Property(e => e.RuleCategoryId).HasColumnName("RuleCategory_Id");
            });

            modelBuilder.Entity<ZcAppealStatusChanngedInvoice31jan2020>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("ZC_AppealStatusChanngedInvoice_31Jan2020");

                entity.Property(e => e.AppealStatusName)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.InvoiceDate)
                    .HasColumnType("datetime")
                    .HasColumnName("Invoice Date");

                entity.Property(e => e.InvoiceNumber)
                    .HasMaxLength(100)
                    .HasColumnName("Invoice Number");

                entity.Property(e => e.LawFirm)
                    .IsRequired()
                    .HasMaxLength(255);

                entity.Property(e => e.PaidDate)
                    .HasColumnType("datetime")
                    .HasColumnName("Paid Date");

                entity.Property(e => e.Payer)
                    .IsRequired()
                    .HasMaxLength(255);

                entity.Property(e => e.Status)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.Property(e => e.UploadedDate)
                    .HasColumnType("datetime")
                    .HasColumnName("Uploaded Date");

                entity.Property(e => e.WorkFlowOwnerId).HasColumnName("WorkFlowOwner_Id");
            });

            modelBuilder.Entity<ZcDeletedInvoiceAppliedRulesOn29Aug2019>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("ZC_deletedInvoiceAppliedRules_on29Aug2019");

                entity.Property(e => e.Id)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("ID");

                entity.Property(e => e.InvoiceId).HasColumnName("Invoice_ID");

                entity.Property(e => e.LineItemId).HasColumnName("LineItem_ID");

                entity.Property(e => e.RuleCode)
                    .HasMaxLength(20)
                    .HasColumnName("Rule_Code");

                entity.Property(e => e.RuleId).HasColumnName("Rule_Id");
            });

            modelBuilder.Entity<ZcDeletedLineItemOn29Aug2019>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("ZC_deletedLineItem_on29Aug2019");

                entity.Property(e => e.AgreedRate).HasColumnType("decimal(18, 0)");

                entity.Property(e => e.AmountReducedByPayer).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.BaseAmount).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.BaseAmountModified).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.ChargeDate).HasColumnType("datetime");

                entity.Property(e => e.ChargeDateModified).HasColumnType("datetime");

                entity.Property(e => e.ChargeDesciption).HasMaxLength(4000);

                entity.Property(e => e.ChargeDesciptionModified).HasMaxLength(4000);

                entity.Property(e => e.ChargeType)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength(true);

                entity.Property(e => e.ChargeTypeModified)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength(true);

                entity.Property(e => e.CommunicationModifiedDate).HasColumnType("datetime");

                entity.Property(e => e.DiscountPercentage).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.DiscountTypeNote).HasMaxLength(500);

                entity.Property(e => e.Discriminator)
                    .IsRequired()
                    .HasMaxLength(128);

                entity.Property(e => e.ExtendHeaderExtendHeaderId).HasColumnName("ExtendHeader_ExtendHeaderID");

                entity.Property(e => e.ExtendHeaderModifiedExtendHeaderId).HasColumnName("ExtendHeaderModified_ExtendHeaderID");

                entity.Property(e => e.Id).ValueGeneratedOnAdd();

                entity.Property(e => e.InvoiceMatterId).HasColumnName("InvoiceMatter_Id");

                entity.Property(e => e.InvoiceMatterId1).HasColumnName("InvoiceMatter_Id1");

                entity.Property(e => e.InvoiceMatterId2).HasColumnName("InvoiceMatter_Id2");

                entity.Property(e => e.InvoiceMatterId3).HasColumnName("InvoiceMatter_Id3");

                entity.Property(e => e.ItemDiscountOrCreditAmount).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.ItemDiscountOrCreditAmountModified).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.LineItemTimekeeperId)
                    .HasMaxLength(50)
                    .HasColumnName("LineItemTimekeeperID");

                entity.Property(e => e.LineItemTimekeeperIdmodified)
                    .HasMaxLength(50)
                    .HasColumnName("LineItemTimekeeperIDModified");

                entity.Property(e => e.PayeeName).HasMaxLength(255);

                entity.Property(e => e.PayerReductionNarration)
                    .HasMaxLength(5000)
                    .IsUnicode(false);

                entity.Property(e => e.PayerReductionReason).HasMaxLength(1000);

                entity.Property(e => e.PhaseCode).HasMaxLength(200);

                entity.Property(e => e.PreperationNote).HasMaxLength(1000);

                entity.Property(e => e.Rate).HasColumnType("decimal(18, 4)");

                entity.Property(e => e.RateModified).HasColumnType("decimal(18, 4)");

                entity.Property(e => e.RateReducedByPayer).HasColumnType("decimal(18, 4)");

                entity.Property(e => e.RuleCategoryId).HasColumnName("RuleCategory_Id");

                entity.Property(e => e.RuleCode).HasMaxLength(500);

                entity.Property(e => e.RuleId).HasColumnName("Rule_Id");

                entity.Property(e => e.RuleNote).HasMaxLength(1000);

                entity.Property(e => e.Tag).HasMaxLength(1000);

                entity.Property(e => e.TaskActivityCode).HasMaxLength(100);

                entity.Property(e => e.TaskActivityCodeModified).HasMaxLength(100);

                entity.Property(e => e.TaskCode).HasMaxLength(100);

                entity.Property(e => e.TaskCodeModified).HasMaxLength(100);

                entity.Property(e => e.TaskExpenseCode).HasMaxLength(100);

                entity.Property(e => e.TaskExpenseCodeModified).HasMaxLength(100);

                entity.Property(e => e.TaxTotal).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.TaxTotalModified).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.TimeKeeperName).HasMaxLength(200);

                entity.Property(e => e.TimeKeeperNameModified).HasMaxLength(200);

                entity.Property(e => e.TimekeeperFirstName).HasMaxLength(100);

                entity.Property(e => e.TimekeeperFirstNameModified).HasMaxLength(100);

                entity.Property(e => e.TimekeeperId).HasColumnName("Timekeeper_Id");

                entity.Property(e => e.TimekeeperLastName).HasMaxLength(100);

                entity.Property(e => e.TimekeeperLastNameModified).HasMaxLength(100);

                entity.Property(e => e.TotalAmount).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.TotalAmountModified).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.UnAccountedAdjustments).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.Units).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.UnitsModified).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.UnitsReducedByPayer).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.WorkLocationCountryCode).HasMaxLength(100);

                entity.Property(e => e.WorkLocationCountryCodeModified).HasMaxLength(100);

                entity.Property(e => e.WorkLocationLocality).HasMaxLength(100);

                entity.Property(e => e.WorkLocationLocalityModified).HasMaxLength(100);
            });

            modelBuilder.Entity<ZcDxclssgreat1>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("ZC_DXCLSSGreat1");

                entity.Property(e => e.Id).HasColumnName("id");
            });

            modelBuilder.Entity<ZcHannaBrophyCigaPrebillInvoiceMatching>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("ZC_HannaBrophy_CIGA_PrebillInvoiceMatching");

                entity.Property(e => e.InvYear).HasColumnName("Inv_Year");

                entity.Property(e => e.InvoiceId).HasColumnName("invoiceId");

                entity.Property(e => e.InvoiceMatterId).HasColumnName("Invoice_Matter_id");

                entity.Property(e => e.InvoiceNumber).HasMaxLength(100);

                entity.Property(e => e.LawFirmMatterId)
                    .HasMaxLength(100)
                    .HasColumnName("Law_Firm_MatterId");

                entity.Property(e => e.PrebillId).HasColumnName("prebillId");

                entity.Property(e => e.PrebillMatterId).HasColumnName("Prebill_Matter_id");

                entity.Property(e => e.PrebillNumber).HasMaxLength(100);
            });

            modelBuilder.Entity<ZcInvPrepInvoiceLinesBackup03may2019>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("zc_InvPrepInvoiceLines_backup_03may2019");

                entity.Property(e => e.Description).HasMaxLength(2000);

                entity.Property(e => e.Fees).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.Id).ValueGeneratedOnAdd();

                entity.Property(e => e.InvPrepInvoiceId).HasColumnName("InvPrepInvoice_Id");

                entity.Property(e => e.Rate).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.TotalInvoiceValue).HasColumnType("decimal(18, 2)");
            });

            modelBuilder.Entity<ZcInvPrepInvoices03may2019>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("ZC_InvPrepInvoices_03may2019");

                entity.Property(e => e.BilledDate).HasColumnType("datetime");

                entity.Property(e => e.CreatedById).HasColumnName("CreatedBy_Id");

                entity.Property(e => e.FeesOnExpense).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.FeesOnFees).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.Id).ValueGeneratedOnAdd();

                entity.Property(e => e.InvPrepInvoiceNumber).IsRequired();

                entity.Property(e => e.InvoiceMonth).HasColumnType("datetime");

                entity.Property(e => e.LawFirmId).HasColumnName("LawFirm_Id");

                entity.Property(e => e.TaxAmount).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.TaxRate).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.TotalFees).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.TotalInvoiceValue).HasColumnType("decimal(18, 2)");
            });

            modelBuilder.Entity<ZcInvoiceClients19apr2019>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("zcInvoiceClients_19apr2019");

                entity.Property(e => e.AddressAddress1)
                    .HasMaxLength(100)
                    .HasColumnName("Address_Address1");

                entity.Property(e => e.AddressAddress2)
                    .HasMaxLength(100)
                    .HasColumnName("Address_Address2");

                entity.Property(e => e.AddressAddress3)
                    .HasMaxLength(100)
                    .HasColumnName("Address_Address3");

                entity.Property(e => e.AddressCity)
                    .HasMaxLength(100)
                    .HasColumnName("Address_City");

                entity.Property(e => e.AddressCountry)
                    .HasMaxLength(100)
                    .HasColumnName("Address_Country");

                entity.Property(e => e.AddressFax)
                    .HasMaxLength(20)
                    .HasColumnName("Address_Fax");

                entity.Property(e => e.AddressPhone)
                    .HasMaxLength(20)
                    .HasColumnName("Address_Phone");

                entity.Property(e => e.AddressStateProvince)
                    .HasMaxLength(100)
                    .HasColumnName("Address_StateProvince");

                entity.Property(e => e.AddressZipPostalCode)
                    .HasMaxLength(100)
                    .HasColumnName("Address_ZipPostalCode");

                entity.Property(e => e.ClientCode).HasMaxLength(100);

                entity.Property(e => e.ClientCodeModified).HasMaxLength(100);

                entity.Property(e => e.ClientId).HasColumnName("Client_Id");

                entity.Property(e => e.ContactContactCode)
                    .HasMaxLength(100)
                    .HasColumnName("Contact_ContactCode");

                entity.Property(e => e.ContactEmail)
                    .HasMaxLength(255)
                    .HasColumnName("Contact_Email");

                entity.Property(e => e.ContactFax)
                    .HasMaxLength(20)
                    .HasColumnName("Contact_Fax");

                entity.Property(e => e.ContactFirstName)
                    .HasMaxLength(100)
                    .HasColumnName("Contact_FirstName");

                entity.Property(e => e.ContactLastName)
                    .HasMaxLength(100)
                    .HasColumnName("Contact_LastName");

                entity.Property(e => e.ContactPhone)
                    .HasMaxLength(20)
                    .HasColumnName("Contact_Phone");

                entity.Property(e => e.Id).ValueGeneratedOnAdd();

                entity.Property(e => e.InvoiceFirmId).HasColumnName("InvoiceFirm_Id");

                entity.Property(e => e.LawFirmCode).HasMaxLength(100);

                entity.Property(e => e.Name).HasMaxLength(255);

                entity.Property(e => e.TaxId).HasMaxLength(20);
            });

            modelBuilder.Entity<ZcInvoiceLineitems13apr2020>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("ZC_InvoiceLineitems_13Apr2020");

                entity.Property(e => e.AgreedRate).HasColumnType("decimal(18, 0)");

                entity.Property(e => e.AmountReducedByPayer).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.BaseAmount).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.BaseAmountModified).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.ChargeDate).HasColumnType("datetime");

                entity.Property(e => e.ChargeDateModified).HasColumnType("datetime");

                entity.Property(e => e.ChargeDesciption).HasMaxLength(4000);

                entity.Property(e => e.ChargeDesciptionModified).HasMaxLength(4000);

                entity.Property(e => e.ChargeType)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength(true);

                entity.Property(e => e.ChargeTypeModified)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength(true);

                entity.Property(e => e.CommunicationModifiedDate).HasColumnType("datetime");

                entity.Property(e => e.DiscountPercentage).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.DiscountTypeNote).HasMaxLength(500);

                entity.Property(e => e.Discriminator)
                    .IsRequired()
                    .HasMaxLength(128);

                entity.Property(e => e.ExtendHeaderExtendHeaderId).HasColumnName("ExtendHeader_ExtendHeaderID");

                entity.Property(e => e.ExtendHeaderModifiedExtendHeaderId).HasColumnName("ExtendHeaderModified_ExtendHeaderID");

                entity.Property(e => e.Id).ValueGeneratedOnAdd();

                entity.Property(e => e.InvoiceMatterId).HasColumnName("InvoiceMatter_Id");

                entity.Property(e => e.InvoiceMatterId1).HasColumnName("InvoiceMatter_Id1");

                entity.Property(e => e.InvoiceMatterId2).HasColumnName("InvoiceMatter_Id2");

                entity.Property(e => e.InvoiceMatterId3).HasColumnName("InvoiceMatter_Id3");

                entity.Property(e => e.ItemDiscountOrCreditAmount).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.ItemDiscountOrCreditAmountModified).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.LineItemTimekeeperId)
                    .HasMaxLength(50)
                    .HasColumnName("LineItemTimekeeperID");

                entity.Property(e => e.LineItemTimekeeperIdmodified)
                    .HasMaxLength(50)
                    .HasColumnName("LineItemTimekeeperIDModified");

                entity.Property(e => e.PayeeName).HasMaxLength(255);

                entity.Property(e => e.PayerReductionNarration)
                    .HasMaxLength(5000)
                    .IsUnicode(false);

                entity.Property(e => e.PayerReductionReason).HasMaxLength(1000);

                entity.Property(e => e.PhaseCode).HasMaxLength(200);

                entity.Property(e => e.PreperationNote).HasMaxLength(1000);

                entity.Property(e => e.Rate).HasColumnType("decimal(18, 4)");

                entity.Property(e => e.RateModified).HasColumnType("decimal(18, 4)");

                entity.Property(e => e.RateReducedByPayer).HasColumnType("decimal(18, 4)");

                entity.Property(e => e.RuleCategoryId).HasColumnName("RuleCategory_Id");

                entity.Property(e => e.RuleCode).HasMaxLength(500);

                entity.Property(e => e.RuleId).HasColumnName("Rule_Id");

                entity.Property(e => e.RuleNote).HasMaxLength(1000);

                entity.Property(e => e.Tag).HasMaxLength(1000);

                entity.Property(e => e.TaskActivityCode).HasMaxLength(100);

                entity.Property(e => e.TaskActivityCodeModified).HasMaxLength(100);

                entity.Property(e => e.TaskCode).HasMaxLength(100);

                entity.Property(e => e.TaskCodeModified).HasMaxLength(100);

                entity.Property(e => e.TaskExpenseCode).HasMaxLength(100);

                entity.Property(e => e.TaskExpenseCodeModified).HasMaxLength(100);

                entity.Property(e => e.TaxTotal).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.TaxTotalModified).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.TimeKeeperName).HasMaxLength(200);

                entity.Property(e => e.TimeKeeperNameModified).HasMaxLength(200);

                entity.Property(e => e.TimekeeperFirstName).HasMaxLength(100);

                entity.Property(e => e.TimekeeperFirstNameModified).HasMaxLength(100);

                entity.Property(e => e.TimekeeperId).HasColumnName("Timekeeper_Id");

                entity.Property(e => e.TimekeeperLastName).HasMaxLength(100);

                entity.Property(e => e.TimekeeperLastNameModified).HasMaxLength(100);

                entity.Property(e => e.TotalAmount).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.TotalAmountModified).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.UnAccountedAdjustments).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.Units).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.UnitsModified).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.UnitsReducedByPayer).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.WorkLocationCountryCode).HasMaxLength(100);

                entity.Property(e => e.WorkLocationCountryCodeModified).HasMaxLength(100);

                entity.Property(e => e.WorkLocationLocality).HasMaxLength(100);

                entity.Property(e => e.WorkLocationLocalityModified).HasMaxLength(100);
            });

            modelBuilder.Entity<ZcInvoicePrepInvoiceInvoiceRelnBackup03may2019>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("ZC_InvoicePrepInvoice_InvoiceReln_backup_03may2019");

                entity.Property(e => e.ExpenseRate).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.Fees).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.FeesOnExpense).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.FeesOnFees).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.Id).ValueGeneratedOnAdd();

                entity.Property(e => e.InvPrepInvoiceId).HasColumnName("InvPrepInvoice_Id");

                entity.Property(e => e.InvoiceId).HasColumnName("Invoice_Id");

                entity.Property(e => e.Rate).HasColumnType("decimal(18, 2)");
            });

            modelBuilder.Entity<ZcInvoiceTimekeeperSummaries27mar2019>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("zc_InvoiceTimekeeperSummaries_27mar2019");

                entity.Property(e => e.ExtendHeaderExtendHeaderId).HasColumnName("ExtendHeader_ExtendHeaderID");

                entity.Property(e => e.Id).ValueGeneratedOnAdd();

                entity.Property(e => e.InvoiceMatterId).HasColumnName("InvoiceMatter_Id");

                entity.Property(e => e.TimekeeperFirstName).HasMaxLength(100);

                entity.Property(e => e.TimekeeperId).HasColumnName("Timekeeper_Id");

                entity.Property(e => e.TimekeeperId1)
                    .HasMaxLength(100)
                    .HasColumnName("TimekeeperId");

                entity.Property(e => e.TimekeeperLastName).HasMaxLength(100);

                entity.Property(e => e.TimekeeperRate).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.TimekeeperTotalUnits).HasColumnType("decimal(18, 2)");
            });

            modelBuilder.Entity<ZcInvoiceTraubRsui312690>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("ZC_invoiceTraub_RSUI_#312690");

                entity.Property(e => e.AppealCreditReceivedAmount).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.AppealCreditReceivedDate).HasColumnType("datetime");

                entity.Property(e => e.AppealDeadlineDate).HasColumnType("datetime");

                entity.Property(e => e.AppealDescription).HasMaxLength(2000);

                entity.Property(e => e.AppealResponseAmount).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.AppealResponseDate).HasColumnType("datetime");

                entity.Property(e => e.AppealResponseDescription).HasMaxLength(2000);

                entity.Property(e => e.AppealResponseExpenses).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.AppealResponseFees).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.AppealStatusComments)
                    .HasMaxLength(2000)
                    .IsUnicode(false);

                entity.Property(e => e.AppealedAmount).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.AppealedDate).HasColumnType("datetime");

                entity.Property(e => e.AppealedExpenses).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.AppealedFees).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.ApprovedById).HasColumnName("ApprovedBy_Id");

                entity.Property(e => e.ApproverComment)
                    .HasMaxLength(4000)
                    .IsUnicode(false);

                entity.Property(e => e.AssignedToUserId).HasColumnName("AssignedToUser_Id");

                entity.Property(e => e.BillToClientAddressAddress1)
                    .HasMaxLength(100)
                    .HasColumnName("BillToClientAddress_Address1");

                entity.Property(e => e.BillToClientAddressAddress2)
                    .HasMaxLength(100)
                    .HasColumnName("BillToClientAddress_Address2");

                entity.Property(e => e.BillToClientAddressAddress3)
                    .HasMaxLength(100)
                    .HasColumnName("BillToClientAddress_Address3");

                entity.Property(e => e.BillToClientAddressCity)
                    .HasMaxLength(100)
                    .HasColumnName("BillToClientAddress_City");

                entity.Property(e => e.BillToClientAddressCountry)
                    .HasMaxLength(100)
                    .HasColumnName("BillToClientAddress_Country");

                entity.Property(e => e.BillToClientAddressFax)
                    .HasMaxLength(20)
                    .HasColumnName("BillToClientAddress_Fax");

                entity.Property(e => e.BillToClientAddressPhone)
                    .HasMaxLength(20)
                    .HasColumnName("BillToClientAddress_Phone");

                entity.Property(e => e.BillToClientAddressStateProvince)
                    .HasMaxLength(100)
                    .HasColumnName("BillToClientAddress_StateProvince");

                entity.Property(e => e.BillToClientAddressZipPostalCode)
                    .HasMaxLength(100)
                    .HasColumnName("BillToClientAddress_ZipPostalCode");

                entity.Property(e => e.BillToClientName).HasMaxLength(255);

                entity.Property(e => e.BillToClientTaxId).HasMaxLength(100);

                entity.Property(e => e.BillType)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.ClientApprovedDate).HasColumnType("datetime");

                entity.Property(e => e.ClientApproverComment)
                    .HasMaxLength(4000)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedById).HasColumnName("CreatedBy_Id");

                entity.Property(e => e.CurrentApprovalRuleId).HasColumnName("CurrentApprovalRule_Id");

                entity.Property(e => e.DeductedExpenseByPayer).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.DeductedFeesByPayer).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.Description).HasMaxLength(4000);

                entity.Property(e => e.DescriptionModified).HasMaxLength(4000);

                entity.Property(e => e.EbillerCostshareAdjustments).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.EbillerGuidelineAdjustments).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.EbillerOriginalBilledAmount).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.EbillerOriginalBilledExpenses).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.EbillerOriginalBilledFees).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.EbillerOtherDiscountDescription)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.EbillerOtherDiscounts).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.EbillerProcessingFees).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.EbillerPromptPayDiscounts).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.EbillerReference1)
                    .HasMaxLength(100)
                    .HasColumnName("EBillerReference1");

                entity.Property(e => e.EbillerReference2)
                    .HasMaxLength(100)
                    .HasColumnName("EBillerReference2");

                entity.Property(e => e.EbillerStatus)
                    .HasMaxLength(200)
                    .HasColumnName("EBillerStatus");

                entity.Property(e => e.EbillerStatusChangeDate)
                    .HasColumnType("datetime")
                    .HasColumnName("EBillerStatusChangeDate");

                entity.Property(e => e.EbillerStatusCheckDate)
                    .HasColumnType("datetime")
                    .HasColumnName("EBillerStatusCheckDate");

                entity.Property(e => e.EbillerStatusComments)
                    .HasMaxLength(2000)
                    .HasColumnName("EBillerStatusComments");

                entity.Property(e => e.EbillerToPayAmount).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.EndDate).HasColumnType("datetime");

                entity.Property(e => e.ExportedById).HasColumnName("ExportedBy_Id");

                entity.Property(e => e.ExportedDate).HasColumnType("datetime");

                entity.Property(e => e.FinalPaidAmount).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.FinalPaidAmountWithDisc).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.FinalPaidExpenses).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.FinalPaidFees).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.FinalPaymentReceivedAmount).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.FirstApproverComment)
                    .HasMaxLength(4000)
                    .IsUnicode(false);

                entity.Property(e => e.Id).ValueGeneratedOnAdd();

                entity.Property(e => e.ImageFileName).HasMaxLength(255);

                entity.Property(e => e.InitialPaymentReceivedAmount).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.InvoiceClientId).HasColumnName("InvoiceClient_Id");

                entity.Property(e => e.InvoiceCode).HasMaxLength(100);

                entity.Property(e => e.InvoiceCurrency).HasMaxLength(20);

                entity.Property(e => e.InvoiceDate).HasColumnType("datetime");

                entity.Property(e => e.InvoiceDueDate).HasMaxLength(20);

                entity.Property(e => e.InvoiceOtherCurrency).HasMaxLength(20);

                entity.Property(e => e.InvoiceTotal).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.InvoiceTotalModified).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.IsThisAcreditNote).HasColumnName("IsThisACreditNote");

                entity.Property(e => e.IsThisAtaxInvoice).HasColumnName("IsThisATaxInvoice");

                entity.Property(e => e.NetTotal).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.NetTotalModified).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.OfflineApproverEmail)
                    .HasMaxLength(255)
                    .HasColumnName("OfflineApprover_Email");

                entity.Property(e => e.PaidDate).HasColumnType("datetime");

                entity.Property(e => e.PaidExpenseWithCostShare).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.PaidExpenseWithDisc).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.PaidFeesWithCostShare).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.PaidFeesWithDisc).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.PaidTotalByPayer).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.PaidTotalWithCostShare).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.PayableByClientAddressAddress1)
                    .HasMaxLength(100)
                    .HasColumnName("PayableByClientAddress_Address1");

                entity.Property(e => e.PayableByClientAddressAddress2)
                    .HasMaxLength(100)
                    .HasColumnName("PayableByClientAddress_Address2");

                entity.Property(e => e.PayableByClientAddressAddress3)
                    .HasMaxLength(100)
                    .HasColumnName("PayableByClientAddress_Address3");

                entity.Property(e => e.PayableByClientAddressCity)
                    .HasMaxLength(100)
                    .HasColumnName("PayableByClientAddress_City");

                entity.Property(e => e.PayableByClientAddressCountry)
                    .HasMaxLength(100)
                    .HasColumnName("PayableByClientAddress_Country");

                entity.Property(e => e.PayableByClientAddressFax)
                    .HasMaxLength(20)
                    .HasColumnName("PayableByClientAddress_Fax");

                entity.Property(e => e.PayableByClientAddressPhone)
                    .HasMaxLength(20)
                    .HasColumnName("PayableByClientAddress_Phone");

                entity.Property(e => e.PayableByClientAddressStateProvince)
                    .HasMaxLength(100)
                    .HasColumnName("PayableByClientAddress_StateProvince");

                entity.Property(e => e.PayableByClientAddressZipPostalCode)
                    .HasMaxLength(100)
                    .HasColumnName("PayableByClientAddress_ZipPostalCode");

                entity.Property(e => e.PayableByClientName).HasMaxLength(255);

                entity.Property(e => e.PayableByClientTaxId).HasMaxLength(100);

                entity.Property(e => e.PaymentRecievedDate).HasColumnType("datetime");

                entity.Property(e => e.PaymentTerms).HasMaxLength(255);

                entity.Property(e => e.PreparationEndTime).HasColumnType("datetime");

                entity.Property(e => e.PreparationStartTime).HasColumnType("datetime");

                entity.Property(e => e.PreparedByUserId).HasColumnName("PreparedByUser_Id");

                entity.Property(e => e.PreparedDate).HasColumnType("datetime");

                entity.Property(e => e.PreviousWorkFlowOwnerId).HasColumnName("PreviousWorkFlowOwner_Id");

                entity.Property(e => e.ProcessedByWhichRuleSystem).HasMaxLength(10);

                entity.Property(e => e.PromptDiscExpensePercen).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.PromptDiscFeesPercen).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.ReceivedDate).HasColumnType("datetime");

                entity.Property(e => e.ReferenceInvoice).HasMaxLength(100);

                entity.Property(e => e.RejectReason)
                    .HasMaxLength(2000)
                    .IsUnicode(false);

                entity.Property(e => e.RuleCode).HasMaxLength(255);

                entity.Property(e => e.RuleId).HasColumnName("Rule_Id");

                entity.Property(e => e.RulesetApplied).HasMaxLength(200);

                entity.Property(e => e.SecondApproverComment)
                    .HasMaxLength(4000)
                    .IsUnicode(false);

                entity.Property(e => e.SendForClientApprovalDate).HasColumnType("datetime");

                entity.Property(e => e.StartDate).HasColumnType("datetime");

                entity.Property(e => e.SubmittedToPayerDate).HasColumnType("datetime");

                entity.Property(e => e.Tag).HasMaxLength(255);

                entity.Property(e => e.TaxInvoiceClientAddressAddress1)
                    .HasMaxLength(100)
                    .HasColumnName("TaxInvoiceClientAddress_Address1");

                entity.Property(e => e.TaxInvoiceClientAddressAddress2)
                    .HasMaxLength(100)
                    .HasColumnName("TaxInvoiceClientAddress_Address2");

                entity.Property(e => e.TaxInvoiceClientAddressAddress3)
                    .HasMaxLength(100)
                    .HasColumnName("TaxInvoiceClientAddress_Address3");

                entity.Property(e => e.TaxInvoiceClientAddressCity)
                    .HasMaxLength(100)
                    .HasColumnName("TaxInvoiceClientAddress_City");

                entity.Property(e => e.TaxInvoiceClientAddressCountry)
                    .HasMaxLength(100)
                    .HasColumnName("TaxInvoiceClientAddress_Country");

                entity.Property(e => e.TaxInvoiceClientAddressFax)
                    .HasMaxLength(20)
                    .HasColumnName("TaxInvoiceClientAddress_Fax");

                entity.Property(e => e.TaxInvoiceClientAddressPhone)
                    .HasMaxLength(20)
                    .HasColumnName("TaxInvoiceClientAddress_Phone");

                entity.Property(e => e.TaxInvoiceClientAddressStateProvince)
                    .HasMaxLength(100)
                    .HasColumnName("TaxInvoiceClientAddress_StateProvince");

                entity.Property(e => e.TaxInvoiceClientAddressZipPostalCode)
                    .HasMaxLength(100)
                    .HasColumnName("TaxInvoiceClientAddress_ZipPostalCode");

                entity.Property(e => e.TaxInvoiceClientName).HasMaxLength(255);

                entity.Property(e => e.TaxInvoiceClientTaxId).HasMaxLength(100);

                entity.Property(e => e.TaxPointDate).HasColumnType("datetime");

                entity.Property(e => e.ThirdApproverComment)
                    .HasMaxLength(4000)
                    .IsUnicode(false);

                entity.Property(e => e.TotalDiscCred).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.TotalDiscCredModified).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.TotalDue).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.TotalDueModified).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.TotalDueOther).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.TotalDueOtherModified).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.TotalExpense).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.TotalExpenseModified).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.TotalFee).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.TotalFeeModified).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.TotalTax).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.TotalTaxModified).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.TotalTaxOther).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.TotalTaxOtherModified).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.UploadedDate).HasColumnType("datetime");

                entity.Property(e => e.WfstatusChangeDate)
                    .HasColumnType("datetime")
                    .HasColumnName("WFStatusChangeDate");

                entity.Property(e => e.WorkFlowOwnerId).HasColumnName("WorkFlowOwner_Id");

                entity.Property(e => e.WriteOffReceivedAmount).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.WriteOffReceivedDate).HasColumnType("datetime");
            });

            modelBuilder.Entity<ZcInvoiceappliedrules04oct2019>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("ZC_invoiceappliedrules_04Oct2019");

                entity.Property(e => e.Id)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("ID");

                entity.Property(e => e.InvoiceId).HasColumnName("Invoice_ID");

                entity.Property(e => e.LineItemId).HasColumnName("LineItem_ID");

                entity.Property(e => e.RuleCode)
                    .HasMaxLength(20)
                    .HasColumnName("Rule_Code");

                entity.Property(e => e.RuleId).HasColumnName("Rule_Id");
            });

            modelBuilder.Entity<ZcInvoiceappliedrules13apr2020>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("ZC_invoiceappliedrules_13Apr2020");

                entity.Property(e => e.Id)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("ID");

                entity.Property(e => e.InvoiceId).HasColumnName("Invoice_ID");

                entity.Property(e => e.LineItemId).HasColumnName("LineItem_ID");

                entity.Property(e => e.RuleCode)
                    .HasMaxLength(20)
                    .HasColumnName("Rule_Code");

                entity.Property(e => e.RuleId).HasColumnName("Rule_Id");
            });

            modelBuilder.Entity<ZcLmSelectedMattersFeb2020>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("ZC_LM_selectedMatters_feb2020");

                entity.Property(e => e.AddlReferenceNo).HasMaxLength(100);

                entity.Property(e => e.BillingTypeId).HasColumnName("BillingType_Id");

                entity.Property(e => e.CaseTypeId).HasColumnName("CaseTypeID");

                entity.Property(e => e.ClaimAmount).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.ClaimEndDate).HasColumnType("datetime");

                entity.Property(e => e.ClientId).HasColumnName("Client_Id");

                entity.Property(e => e.ClientMatterId)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.CreatedById).HasColumnName("CreatedBy_Id");

                entity.Property(e => e.CreatedTime).HasColumnType("datetime");

                entity.Property(e => e.DateAssigned).HasColumnType("datetime");

                entity.Property(e => e.DateClosed).HasColumnType("datetime");

                entity.Property(e => e.DateOfLoss).HasColumnType("datetime");

                entity.Property(e => e.Description).HasMaxLength(1000);

                entity.Property(e => e.DispositionAmount).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.DispositionTypeId).HasColumnName("DispositionTypeID");

                entity.Property(e => e.EbillerReference1)
                    .HasMaxLength(100)
                    .HasColumnName("EBillerReference1");

                entity.Property(e => e.EbillerReference2)
                    .HasMaxLength(100)
                    .HasColumnName("EBillerReference2");

                entity.Property(e => e.EbillerStatus)
                    .HasMaxLength(200)
                    .HasColumnName("EBillerStatus");

                entity.Property(e => e.EbillerStatusChangeDate)
                    .HasColumnType("datetime")
                    .HasColumnName("EBillerStatusChangeDate");

                entity.Property(e => e.EbillerStatusCheckDate)
                    .HasColumnType("datetime")
                    .HasColumnName("EBillerStatusCheckDate");

                entity.Property(e => e.EbillerStatusComments)
                    .HasMaxLength(2000)
                    .HasColumnName("EBillerStatusComments");

                entity.Property(e => e.Id).ValueGeneratedOnAdd();

                entity.Property(e => e.IndemnityTypeId).HasColumnName("IndemnityTypeID");

                entity.Property(e => e.InitialEstimateOfExposure).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.InjurySeverityCodeId).HasColumnName("InjurySeverityCodeID");

                entity.Property(e => e.Jurisdiction).HasMaxLength(50);

                entity.Property(e => e.LawFirmId).HasColumnName("LawFirm_Id");

                entity.Property(e => e.LawFirmMatterId).HasMaxLength(50);

                entity.Property(e => e.LitigationOrOtherCaseTypeId).HasColumnName("LitigationOrOtherCaseTypeID");

                entity.Property(e => e.LitigationVenueId).HasColumnName("LitigationVenueID");

                entity.Property(e => e.MasterUtbmsCodeSetId).HasColumnName("MasterUtbmsCodeSet_Id");

                entity.Property(e => e.ModifiedById).HasColumnName("ModifiedBy_Id");

                entity.Property(e => e.ModifiedTime).HasColumnType("datetime");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.Property(e => e.PersonalInjuryIndemnityFigure).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.ProductLineId).HasColumnName("ProductLine_Id");

                entity.Property(e => e.ProductLineOtherText).HasMaxLength(100);

                entity.Property(e => e.PropertyDamageIndemnityFigure).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.ResponsibleAttorney)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.SettlementAmount).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.SuitCountry)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.SuitCountyId).HasColumnName("SuitCountyID");

                entity.Property(e => e.SuitStateId).HasColumnName("SuitStateID");

                entity.Property(e => e.TotalIndemnityFigure).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.TypeOfInjuryId).HasColumnName("TypeOfInjuryID");

                entity.Property(e => e.TypeOfLossId).HasColumnName("TypeOfLossID");

                entity.Property(e => e.VerdictAmount).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.WorkerCompDisabilityPercentage).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.WorkerCompLostEarnings).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.WorkerCompMedicals).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.WorkersCompIndemnityTypeId).HasColumnName("WorkersCompIndemnityTypeID");

                entity.Property(e => e.WorkersCompOtherIndemnityTypeId).HasColumnName("WorkersCompOtherIndemnityTypeID");
            });

            modelBuilder.Entity<ZcLmSelectedMattersFeb20201>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("ZC_LM_selectedMatters_feb20201");

                entity.Property(e => e.AddlReferenceNo).HasMaxLength(100);

                entity.Property(e => e.BillingTypeId).HasColumnName("BillingType_Id");

                entity.Property(e => e.CaseTypeId).HasColumnName("CaseTypeID");

                entity.Property(e => e.ClaimAmount).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.ClaimEndDate).HasColumnType("datetime");

                entity.Property(e => e.ClientId).HasColumnName("Client_Id");

                entity.Property(e => e.ClientMatterId)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.CreatedById).HasColumnName("CreatedBy_Id");

                entity.Property(e => e.CreatedTime).HasColumnType("datetime");

                entity.Property(e => e.DateAssigned).HasColumnType("datetime");

                entity.Property(e => e.DateClosed).HasColumnType("datetime");

                entity.Property(e => e.DateOfLoss).HasColumnType("datetime");

                entity.Property(e => e.Description).HasMaxLength(1000);

                entity.Property(e => e.DispositionAmount).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.DispositionTypeId).HasColumnName("DispositionTypeID");

                entity.Property(e => e.EbillerReference1)
                    .HasMaxLength(100)
                    .HasColumnName("EBillerReference1");

                entity.Property(e => e.EbillerReference2)
                    .HasMaxLength(100)
                    .HasColumnName("EBillerReference2");

                entity.Property(e => e.EbillerStatus)
                    .HasMaxLength(200)
                    .HasColumnName("EBillerStatus");

                entity.Property(e => e.EbillerStatusChangeDate)
                    .HasColumnType("datetime")
                    .HasColumnName("EBillerStatusChangeDate");

                entity.Property(e => e.EbillerStatusCheckDate)
                    .HasColumnType("datetime")
                    .HasColumnName("EBillerStatusCheckDate");

                entity.Property(e => e.EbillerStatusComments)
                    .HasMaxLength(2000)
                    .HasColumnName("EBillerStatusComments");

                entity.Property(e => e.Id).ValueGeneratedOnAdd();

                entity.Property(e => e.IndemnityTypeId).HasColumnName("IndemnityTypeID");

                entity.Property(e => e.InitialEstimateOfExposure).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.InjurySeverityCodeId).HasColumnName("InjurySeverityCodeID");

                entity.Property(e => e.Jurisdiction).HasMaxLength(50);

                entity.Property(e => e.LawFirmId).HasColumnName("LawFirm_Id");

                entity.Property(e => e.LawFirmMatterId).HasMaxLength(50);

                entity.Property(e => e.LitigationOrOtherCaseTypeId).HasColumnName("LitigationOrOtherCaseTypeID");

                entity.Property(e => e.LitigationVenueId).HasColumnName("LitigationVenueID");

                entity.Property(e => e.MasterUtbmsCodeSetId).HasColumnName("MasterUtbmsCodeSet_Id");

                entity.Property(e => e.ModifiedById).HasColumnName("ModifiedBy_Id");

                entity.Property(e => e.ModifiedTime).HasColumnType("datetime");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.Property(e => e.PersonalInjuryIndemnityFigure).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.ProductLineId).HasColumnName("ProductLine_Id");

                entity.Property(e => e.ProductLineOtherText).HasMaxLength(100);

                entity.Property(e => e.PropertyDamageIndemnityFigure).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.ResponsibleAttorney)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.SettlementAmount).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.SuitCountry)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.SuitCountyId).HasColumnName("SuitCountyID");

                entity.Property(e => e.SuitStateId).HasColumnName("SuitStateID");

                entity.Property(e => e.TotalIndemnityFigure).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.TypeOfInjuryId).HasColumnName("TypeOfInjuryID");

                entity.Property(e => e.TypeOfLossId).HasColumnName("TypeOfLossID");

                entity.Property(e => e.VerdictAmount).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.WorkerCompDisabilityPercentage).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.WorkerCompLostEarnings).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.WorkerCompMedicals).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.WorkersCompIndemnityTypeId).HasColumnName("WorkersCompIndemnityTypeID");

                entity.Property(e => e.WorkersCompOtherIndemnityTypeId).HasColumnName("WorkersCompOtherIndemnityTypeID");
            });

            modelBuilder.Entity<ZcQuery>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("zcQuery");

                entity.Property(e => e.DateT)
                    .HasColumnType("datetime")
                    .HasColumnName("dateT");

                entity.Property(e => e.Fromsp)
                    .IsUnicode(false)
                    .HasColumnName("fromsp");

                entity.Property(e => e.Query).IsUnicode(false);
            });

            modelBuilder.Entity<ZcRejectToFirm2019>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("zc_rejectToFirm_2019");

                entity.Property(e => e.Invoicecode)
                    .HasMaxLength(100)
                    .HasColumnName("invoicecode");
            });

            modelBuilder.Entity<ZcRepeatingBillingcode>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("ZC_repeatingBillingcode");

                entity.Property(e => e.BillingCode).HasMaxLength(20);

                entity.Property(e => e.LawFirmId).HasColumnName("LawFirm_Id");
            });

            modelBuilder.Entity<ZcRighiPrebills05nov2019>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("ZC_righiPrebills_05nov2019");

                entity.Property(e => e.Invoicecode)
                    .HasMaxLength(100)
                    .HasColumnName("invoicecode");
            });

            modelBuilder.Entity<ZcSmithFreedInvoicesTest>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("ZC_smithFreedInvoices_test");

                entity.Property(e => e.Id)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("id");

                entity.Property(e => e.Invoicecode)
                    .HasMaxLength(100)
                    .HasColumnName("invoicecode");
            });

            modelBuilder.Entity<ZcSmithTkJlf23jan2020>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("ZC_smith_tkJLF_23jan2020");

                entity.Property(e => e.Id).HasColumnName("id");
            });

            modelBuilder.Entity<ZcTestInv21may>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("zc_Test_inv_21may");

                entity.Property(e => e.AppealCreditReceivedAmount).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.AppealCreditReceivedDate).HasColumnType("datetime");

                entity.Property(e => e.AppealDeadlineDate).HasColumnType("datetime");

                entity.Property(e => e.AppealDescription).HasMaxLength(2000);

                entity.Property(e => e.AppealResponseAmount).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.AppealResponseDate).HasColumnType("datetime");

                entity.Property(e => e.AppealResponseDescription).HasMaxLength(2000);

                entity.Property(e => e.AppealResponseExpenses).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.AppealResponseFees).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.AppealStatusComments)
                    .HasMaxLength(2000)
                    .IsUnicode(false);

                entity.Property(e => e.AppealedAmount).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.AppealedDate).HasColumnType("datetime");

                entity.Property(e => e.AppealedExpenses).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.AppealedFees).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.ApprovedById).HasColumnName("ApprovedBy_Id");

                entity.Property(e => e.ApproverComment)
                    .HasMaxLength(4000)
                    .IsUnicode(false);

                entity.Property(e => e.AssignedToUserId).HasColumnName("AssignedToUser_Id");

                entity.Property(e => e.BillToClientAddressAddress1)
                    .HasMaxLength(100)
                    .HasColumnName("BillToClientAddress_Address1");

                entity.Property(e => e.BillToClientAddressAddress2)
                    .HasMaxLength(100)
                    .HasColumnName("BillToClientAddress_Address2");

                entity.Property(e => e.BillToClientAddressAddress3)
                    .HasMaxLength(100)
                    .HasColumnName("BillToClientAddress_Address3");

                entity.Property(e => e.BillToClientAddressCity)
                    .HasMaxLength(100)
                    .HasColumnName("BillToClientAddress_City");

                entity.Property(e => e.BillToClientAddressCountry)
                    .HasMaxLength(100)
                    .HasColumnName("BillToClientAddress_Country");

                entity.Property(e => e.BillToClientAddressFax)
                    .HasMaxLength(20)
                    .HasColumnName("BillToClientAddress_Fax");

                entity.Property(e => e.BillToClientAddressPhone)
                    .HasMaxLength(20)
                    .HasColumnName("BillToClientAddress_Phone");

                entity.Property(e => e.BillToClientAddressStateProvince)
                    .HasMaxLength(100)
                    .HasColumnName("BillToClientAddress_StateProvince");

                entity.Property(e => e.BillToClientAddressZipPostalCode)
                    .HasMaxLength(100)
                    .HasColumnName("BillToClientAddress_ZipPostalCode");

                entity.Property(e => e.BillToClientName).HasMaxLength(255);

                entity.Property(e => e.BillToClientTaxId).HasMaxLength(100);

                entity.Property(e => e.BillType)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.ClientApprovedDate).HasColumnType("datetime");

                entity.Property(e => e.ClientApproverComment)
                    .HasMaxLength(4000)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedById).HasColumnName("CreatedBy_Id");

                entity.Property(e => e.CurrentApprovalRuleId).HasColumnName("CurrentApprovalRule_Id");

                entity.Property(e => e.DeductedExpenseByPayer).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.DeductedFeesByPayer).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.Description).HasMaxLength(4000);

                entity.Property(e => e.DescriptionModified).HasMaxLength(4000);

                entity.Property(e => e.EbillerCostshareAdjustments).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.EbillerGuidelineAdjustments).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.EbillerOriginalBilledAmount).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.EbillerOriginalBilledExpenses).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.EbillerOriginalBilledFees).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.EbillerOtherDiscountDescription)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.EbillerOtherDiscounts).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.EbillerProcessingFees).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.EbillerPromptPayDiscounts).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.EbillerReference1)
                    .HasMaxLength(100)
                    .HasColumnName("EBillerReference1");

                entity.Property(e => e.EbillerReference2)
                    .HasMaxLength(100)
                    .HasColumnName("EBillerReference2");

                entity.Property(e => e.EbillerStatus)
                    .HasMaxLength(200)
                    .HasColumnName("EBillerStatus");

                entity.Property(e => e.EbillerStatusChangeDate)
                    .HasColumnType("datetime")
                    .HasColumnName("EBillerStatusChangeDate");

                entity.Property(e => e.EbillerStatusCheckDate)
                    .HasColumnType("datetime")
                    .HasColumnName("EBillerStatusCheckDate");

                entity.Property(e => e.EbillerStatusComments)
                    .HasMaxLength(2000)
                    .HasColumnName("EBillerStatusComments");

                entity.Property(e => e.EbillerToPayAmount).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.EndDate).HasColumnType("datetime");

                entity.Property(e => e.ExportedById).HasColumnName("ExportedBy_Id");

                entity.Property(e => e.ExportedDate).HasColumnType("datetime");

                entity.Property(e => e.FinalPaidAmount).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.FinalPaidAmountWithDisc).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.FinalPaidExpenses).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.FinalPaidFees).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.FinalPaymentReceivedAmount).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.FirstApproverComment)
                    .HasMaxLength(4000)
                    .IsUnicode(false);

                entity.Property(e => e.Id).ValueGeneratedOnAdd();

                entity.Property(e => e.ImageFileName).HasMaxLength(255);

                entity.Property(e => e.InitialPaymentReceivedAmount).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.InvoiceClientId).HasColumnName("InvoiceClient_Id");

                entity.Property(e => e.InvoiceCode).HasMaxLength(100);

                entity.Property(e => e.InvoiceCurrency).HasMaxLength(20);

                entity.Property(e => e.InvoiceDate).HasColumnType("datetime");

                entity.Property(e => e.InvoiceDueDate).HasMaxLength(20);

                entity.Property(e => e.InvoiceOtherCurrency).HasMaxLength(20);

                entity.Property(e => e.InvoiceTotal).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.InvoiceTotalModified).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.IsThisAcreditNote).HasColumnName("IsThisACreditNote");

                entity.Property(e => e.IsThisAtaxInvoice).HasColumnName("IsThisATaxInvoice");

                entity.Property(e => e.NetTotal).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.NetTotalModified).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.OfflineApproverEmail)
                    .HasMaxLength(255)
                    .HasColumnName("OfflineApprover_Email");

                entity.Property(e => e.PaidDate).HasColumnType("datetime");

                entity.Property(e => e.PaidExpenseWithCostShare).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.PaidExpenseWithDisc).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.PaidFeesWithCostShare).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.PaidFeesWithDisc).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.PaidTotalByPayer).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.PaidTotalWithCostShare).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.PayableByClientAddressAddress1)
                    .HasMaxLength(100)
                    .HasColumnName("PayableByClientAddress_Address1");

                entity.Property(e => e.PayableByClientAddressAddress2)
                    .HasMaxLength(100)
                    .HasColumnName("PayableByClientAddress_Address2");

                entity.Property(e => e.PayableByClientAddressAddress3)
                    .HasMaxLength(100)
                    .HasColumnName("PayableByClientAddress_Address3");

                entity.Property(e => e.PayableByClientAddressCity)
                    .HasMaxLength(100)
                    .HasColumnName("PayableByClientAddress_City");

                entity.Property(e => e.PayableByClientAddressCountry)
                    .HasMaxLength(100)
                    .HasColumnName("PayableByClientAddress_Country");

                entity.Property(e => e.PayableByClientAddressFax)
                    .HasMaxLength(20)
                    .HasColumnName("PayableByClientAddress_Fax");

                entity.Property(e => e.PayableByClientAddressPhone)
                    .HasMaxLength(20)
                    .HasColumnName("PayableByClientAddress_Phone");

                entity.Property(e => e.PayableByClientAddressStateProvince)
                    .HasMaxLength(100)
                    .HasColumnName("PayableByClientAddress_StateProvince");

                entity.Property(e => e.PayableByClientAddressZipPostalCode)
                    .HasMaxLength(100)
                    .HasColumnName("PayableByClientAddress_ZipPostalCode");

                entity.Property(e => e.PayableByClientName).HasMaxLength(255);

                entity.Property(e => e.PayableByClientTaxId).HasMaxLength(100);

                entity.Property(e => e.PaymentRecievedDate).HasColumnType("datetime");

                entity.Property(e => e.PaymentTerms).HasMaxLength(255);

                entity.Property(e => e.PreparationEndTime).HasColumnType("datetime");

                entity.Property(e => e.PreparationStartTime).HasColumnType("datetime");

                entity.Property(e => e.PreparedByUserId).HasColumnName("PreparedByUser_Id");

                entity.Property(e => e.PreparedDate).HasColumnType("datetime");

                entity.Property(e => e.PreviousWorkFlowOwnerId).HasColumnName("PreviousWorkFlowOwner_Id");

                entity.Property(e => e.ProcessedByWhichRuleSystem).HasMaxLength(10);

                entity.Property(e => e.PromptDiscExpensePercen).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.PromptDiscFeesPercen).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.ReceivedDate).HasColumnType("datetime");

                entity.Property(e => e.ReferenceInvoice).HasMaxLength(100);

                entity.Property(e => e.RejectReason)
                    .HasMaxLength(2000)
                    .IsUnicode(false);

                entity.Property(e => e.RuleCode).HasMaxLength(255);

                entity.Property(e => e.RuleId).HasColumnName("Rule_Id");

                entity.Property(e => e.RulesetApplied).HasMaxLength(200);

                entity.Property(e => e.SecondApproverComment)
                    .HasMaxLength(4000)
                    .IsUnicode(false);

                entity.Property(e => e.SendForClientApprovalDate).HasColumnType("datetime");

                entity.Property(e => e.StartDate).HasColumnType("datetime");

                entity.Property(e => e.SubmittedToPayerDate).HasColumnType("datetime");

                entity.Property(e => e.Tag).HasMaxLength(255);

                entity.Property(e => e.TaxInvoiceClientAddressAddress1)
                    .HasMaxLength(100)
                    .HasColumnName("TaxInvoiceClientAddress_Address1");

                entity.Property(e => e.TaxInvoiceClientAddressAddress2)
                    .HasMaxLength(100)
                    .HasColumnName("TaxInvoiceClientAddress_Address2");

                entity.Property(e => e.TaxInvoiceClientAddressAddress3)
                    .HasMaxLength(100)
                    .HasColumnName("TaxInvoiceClientAddress_Address3");

                entity.Property(e => e.TaxInvoiceClientAddressCity)
                    .HasMaxLength(100)
                    .HasColumnName("TaxInvoiceClientAddress_City");

                entity.Property(e => e.TaxInvoiceClientAddressCountry)
                    .HasMaxLength(100)
                    .HasColumnName("TaxInvoiceClientAddress_Country");

                entity.Property(e => e.TaxInvoiceClientAddressFax)
                    .HasMaxLength(20)
                    .HasColumnName("TaxInvoiceClientAddress_Fax");

                entity.Property(e => e.TaxInvoiceClientAddressPhone)
                    .HasMaxLength(20)
                    .HasColumnName("TaxInvoiceClientAddress_Phone");

                entity.Property(e => e.TaxInvoiceClientAddressStateProvince)
                    .HasMaxLength(100)
                    .HasColumnName("TaxInvoiceClientAddress_StateProvince");

                entity.Property(e => e.TaxInvoiceClientAddressZipPostalCode)
                    .HasMaxLength(100)
                    .HasColumnName("TaxInvoiceClientAddress_ZipPostalCode");

                entity.Property(e => e.TaxInvoiceClientName).HasMaxLength(255);

                entity.Property(e => e.TaxInvoiceClientTaxId).HasMaxLength(100);

                entity.Property(e => e.TaxPointDate).HasColumnType("datetime");

                entity.Property(e => e.ThirdApproverComment)
                    .HasMaxLength(4000)
                    .IsUnicode(false);

                entity.Property(e => e.TotalDiscCred).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.TotalDiscCredModified).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.TotalDue).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.TotalDueModified).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.TotalDueOther).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.TotalDueOtherModified).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.TotalExpense).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.TotalExpenseModified).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.TotalFee).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.TotalFeeModified).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.TotalTax).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.TotalTaxModified).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.TotalTaxOther).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.TotalTaxOtherModified).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.UploadedDate).HasColumnType("datetime");

                entity.Property(e => e.WfstatusChangeDate)
                    .HasColumnType("datetime")
                    .HasColumnName("WFStatusChangeDate");

                entity.Property(e => e.WorkFlowOwnerId).HasColumnName("WorkFlowOwner_Id");

                entity.Property(e => e.WriteOffReceivedAmount).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.WriteOffReceivedDate).HasColumnType("datetime");
            });

            modelBuilder.Entity<ZcTokioMattersToMove06march2020>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("ZC_TokioMattersToMove_06March2020");

                entity.Property(e => e.ClientMatterId)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.CurrentPayer).HasColumnName("currentPayer");

                entity.Property(e => e.CurrentPname)
                    .IsRequired()
                    .HasMaxLength(255)
                    .HasColumnName("currentPname");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.LawFirmMatterId).HasMaxLength(50);

                entity.Property(e => e.Mattername)
                    .IsRequired()
                    .HasMaxLength(100)
                    .HasColumnName("mattername");

                entity.Property(e => e.Moveto).HasColumnName("moveto");

                entity.Property(e => e.MovetoPname)
                    .IsRequired()
                    .HasMaxLength(255)
                    .HasColumnName("movetoPname");

                entity.Property(e => e._).HasColumnName("#");
            });

            modelBuilder.Entity<ZcTop4PayersRedInvoice>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("ZC_top4PayersRedInvoices");

                entity.Property(e => e.ClientId).HasColumnName("client_id");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Invoicecode)
                    .HasMaxLength(100)
                    .HasColumnName("invoicecode");

                entity.Property(e => e.Invoicetotal)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("invoicetotal");

                entity.Property(e => e.Invoicetotalmodified)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("invoicetotalmodified");

                entity.Property(e => e.LawFirm)
                    .IsRequired()
                    .HasMaxLength(255);

                entity.Property(e => e.Payer)
                    .IsRequired()
                    .HasMaxLength(255)
                    .HasColumnName("payer");
            });

            modelBuilder.Entity<ZcTop5PayersInvoice>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("ZC_top5PayersInvoices");

                entity.HasIndex(e => new { e.InvId, e.ClientId }, "<Name of Missing Index, sysname,>");

                entity.Property(e => e.ClientId).HasColumnName("client_id");

                entity.Property(e => e.InvId).HasColumnName("invId");

                entity.Property(e => e.InvNum)
                    .HasMaxLength(100)
                    .HasColumnName("invNum");

                entity.Property(e => e.Invoicetotal)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("invoicetotal");

                entity.Property(e => e.Invoicetotalmodified)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("invoicetotalmodified");

                entity.Property(e => e.LawFirmMappedName)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Lawfirm)
                    .IsRequired()
                    .HasMaxLength(255);

                entity.Property(e => e.LawfirmId).HasColumnName("lawfirm_id");

                entity.Property(e => e.Payer)
                    .IsRequired()
                    .HasMaxLength(255);
            });

            modelBuilder.Entity<Zcdltinv>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("zcdltinv");

                entity.Property(e => e.Id).HasColumnName("id");
            });

            modelBuilder.Entity<ZchartfordNavigatorsRule>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("ZCHartfordNavigatorsRules");

                entity.Property(e => e.ClientId).HasColumnName("Client_Id");

                entity.Property(e => e.Id).ValueGeneratedOnAdd();

                entity.Property(e => e.LawFirmId).HasColumnName("LawFirm_Id");

                entity.Property(e => e.ProductLineId).HasColumnName("ProductLine_Id");

                entity.Property(e => e.RuleId).HasColumnName("Rule_Id");
            });

            modelBuilder.Entity<Zcmatters19apr2019>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("zcmatters_19apr2019");

                entity.Property(e => e.AddlReferenceNo).HasMaxLength(100);

                entity.Property(e => e.BillingTypeId).HasColumnName("BillingType_Id");

                entity.Property(e => e.ClaimAmount).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.ClaimEndDate).HasColumnType("datetime");

                entity.Property(e => e.ClientId).HasColumnName("Client_Id");

                entity.Property(e => e.ClientMatterId)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.CreatedById).HasColumnName("CreatedBy_Id");

                entity.Property(e => e.CreatedTime).HasColumnType("datetime");

                entity.Property(e => e.DateAssigned).HasColumnType("datetime");

                entity.Property(e => e.DateClosed).HasColumnType("datetime");

                entity.Property(e => e.DateOfLoss).HasColumnType("datetime");

                entity.Property(e => e.Description).HasMaxLength(1000);

                entity.Property(e => e.EbillerReference1)
                    .HasMaxLength(100)
                    .HasColumnName("EBillerReference1");

                entity.Property(e => e.EbillerReference2)
                    .HasMaxLength(100)
                    .HasColumnName("EBillerReference2");

                entity.Property(e => e.EbillerStatus)
                    .HasMaxLength(200)
                    .HasColumnName("EBillerStatus");

                entity.Property(e => e.EbillerStatusChangeDate)
                    .HasColumnType("datetime")
                    .HasColumnName("EBillerStatusChangeDate");

                entity.Property(e => e.EbillerStatusCheckDate)
                    .HasColumnType("datetime")
                    .HasColumnName("EBillerStatusCheckDate");

                entity.Property(e => e.EbillerStatusComments)
                    .HasMaxLength(2000)
                    .HasColumnName("EBillerStatusComments");

                entity.Property(e => e.Id).ValueGeneratedOnAdd();

                entity.Property(e => e.Jurisdiction).HasMaxLength(50);

                entity.Property(e => e.LawFirmId).HasColumnName("LawFirm_Id");

                entity.Property(e => e.LawFirmMatterId).HasMaxLength(50);

                entity.Property(e => e.MasterUtbmsCodeSetId).HasColumnName("MasterUtbmsCodeSet_Id");

                entity.Property(e => e.ModifiedById).HasColumnName("ModifiedBy_Id");

                entity.Property(e => e.ModifiedTime).HasColumnType("datetime");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.Property(e => e.ProductLineId).HasColumnName("ProductLine_Id");

                entity.Property(e => e.ProductLineOtherText).HasMaxLength(100);

                entity.Property(e => e.SettlementAmount).HasColumnType("decimal(18, 2)");
            });

            modelBuilder.Entity<ZcmorrisduffyTokiomarine>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("ZCmorrisduffy_tokiomarine");

                entity.Property(e => e.AppealDeadlineDate).HasColumnType("datetime");

                entity.Property(e => e.AutomationUrl).HasMaxLength(150);

                entity.Property(e => e.ClientId).HasColumnName("client_id");

                entity.Property(e => e.ClientName).HasMaxLength(255);

                entity.Property(e => e.EbillerStatus).HasMaxLength(200);

                entity.Property(e => e.EbillerStatusCheckDate)
                    .HasColumnType("datetime")
                    .HasColumnName("EBillerStatusCheckDate");

                entity.Property(e => e.Flogin)
                    .HasMaxLength(100)
                    .HasColumnName("FLogin");

                entity.Property(e => e.Fpassword)
                    .HasMaxLength(100)
                    .HasColumnName("FPassword");

                entity.Property(e => e.Invid).HasColumnName("invid");

                entity.Property(e => e.Invoicecode)
                    .HasMaxLength(100)
                    .HasColumnName("invoicecode");

                entity.Property(e => e.Invoicedate)
                    .HasColumnType("datetime")
                    .HasColumnName("invoicedate");

                entity.Property(e => e.Invoicestatusid).HasColumnName("invoicestatusid");

                entity.Property(e => e.LawFirm).HasMaxLength(255);

                entity.Property(e => e.LawFirmEbillerId).HasColumnName("LawFirmEbiller_Id");

                entity.Property(e => e.LawFirmId).HasColumnName("LawFirm_Id");

                entity.Property(e => e.MasterEbillersId).HasColumnName("MasterEbillers_Id");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.Property(e => e.Statusname)
                    .HasMaxLength(100)
                    .HasColumnName("statusname");
            });

            modelBuilder.Entity<InvoiceListingGridModel>().HasNoKey();

            modelBuilder.Entity<InvoiceLineItemsListingGridModel>().HasNoKey();

            OnModelCreatingPartial(modelBuilder);
        }
        #endregion

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
