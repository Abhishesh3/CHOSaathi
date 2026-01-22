using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace CHO_Saathi.Models;

public partial class ApplicationDBContext : DbContext
{
    public ApplicationDBContext()
    {
    }

    public ApplicationDBContext(DbContextOptions<ApplicationDBContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Admission> Admissions { get; set; }

    public virtual DbSet<Allergy> Allergies { get; set; }

    public virtual DbSet<AndroidMetadatum> AndroidMetadata { get; set; }

    public virtual DbSet<Anm> Anms { get; set; }

    public virtual DbSet<AnmcatchmentArea> AnmcatchmentAreas { get; set; }

    public virtual DbSet<AnmcatchmentAreaTransHist> AnmcatchmentAreaTransHists { get; set; }

    public virtual DbSet<Anmml> Anmmls { get; set; }

    public virtual DbSet<AnmtransferHistory> AnmtransferHistories { get; set; }

    public virtual DbSet<AppCategory> AppCategories { get; set; }

    public virtual DbSet<AppCategoryItem> AppCategoryItems { get; set; }

    public virtual DbSet<Appointment> Appointments { get; set; }

    public virtual DbSet<Asha> Ashas { get; set; }

    public virtual DbSet<AshaMapping> AshaMappings { get; set; }

    public virtual DbSet<AshaVillage> AshaVillages { get; set; }

    public virtual DbSet<Ashaml> Ashamls { get; set; }

    public virtual DbSet<AskFor> AskFors { get; set; }

    public virtual DbSet<Attendance> Attendances { get; set; }

    public virtual DbSet<Bank> Banks { get; set; }

    public virtual DbSet<BankBranch> BankBranches { get; set; }

    public virtual DbSet<BankBranchMl> BankBranchMls { get; set; }

    public virtual DbSet<BankMl> BankMls { get; set; }

    public virtual DbSet<BankType> BankTypes { get; set; }

    public virtual DbSet<Billing> Billings { get; set; }

    public virtual DbSet<Cadre> Cadres { get; set; }

    public virtual DbSet<CadreMl> CadreMls { get; set; }

    public virtual DbSet<CaseDischargeReportPdfharshit> CaseDischargeReportPdfharshits { get; set; }

    public virtual DbSet<Casepnc> Casepncs { get; set; }

    public virtual DbSet<Center> Centers { get; set; }

    public virtual DbSet<Checkup> Checkups { get; set; }

    public virtual DbSet<Cho> Chos { get; set; }

    public virtual DbSet<ChoMapped> ChoMappeds { get; set; }

    public virtual DbSet<Claim> Claims { get; set; }

    public virtual DbSet<CmpAskFor> CmpAskFors { get; set; }

    public virtual DbSet<CmpAskForAnswer> CmpAskForAnswers { get; set; }

    public virtual DbSet<CmpAskForResult> CmpAskForResults { get; set; }

    public virtual DbSet<CmpExamination> CmpExaminations { get; set; }

    public virtual DbSet<CmpExaminationResult> CmpExaminationResults { get; set; }

    public virtual DbSet<CmpPastHistory> CmpPastHistories { get; set; }

    public virtual DbSet<CmpPastHistoryResult> CmpPastHistoryResults { get; set; }

    public virtual DbSet<CmpPatientVisit> CmpPatientVisits { get; set; }

    public virtual DbSet<CmpSubSymptom> CmpSubSymptoms { get; set; }

    public virtual DbSet<CmpSymptom> CmpSymptoms { get; set; }

    public virtual DbSet<CommonSymptomsWeb> CommonSymptomsWebs { get; set; }

    public virtual DbSet<Complication> Complications { get; set; }

    public virtual DbSet<CoughTest> CoughTests { get; set; }

    public virtual DbSet<Counseling> Counselings { get; set; }

    public virtual DbSet<DataImport> DataImports { get; set; }

    public virtual DbSet<DataImportError> DataImportErrors { get; set; }

    public virtual DbSet<DataItem> DataItems { get; set; }

    public virtual DbSet<DataItemDvalue> DataItemDvalues { get; set; }

    public virtual DbSet<Department> Departments { get; set; }

    public virtual DbSet<DiarrheaTest> DiarrheaTests { get; set; }

    public virtual DbSet<Discharge> Discharges { get; set; }

    public virtual DbSet<Distribution> Distributions { get; set; }

    public virtual DbSet<Doctor> Doctors { get; set; }

    public virtual DbSet<Drug> Drugs { get; set; }

    public virtual DbSet<EmergencyVisit> EmergencyVisits { get; set; }

    public virtual DbSet<Examination> Examinations { get; set; }

    public virtual DbSet<Expense> Expenses { get; set; }

    public virtual DbSet<FamilyHistory> FamilyHistories { get; set; }

    public virtual DbSet<FeedingAssessment> FeedingAssessments { get; set; }

    public virtual DbSet<FeverTest> FeverTests { get; set; }

    public virtual DbSet<Flag> Flags { get; set; }

    public virtual DbSet<FlagValue> FlagValues { get; set; }

    public virtual DbSet<FlagValueMl> FlagValueMls { get; set; }

    public virtual DbSet<Followup> Followups { get; set; }

    public virtual DbSet<Gender> Genders { get; set; }

    public virtual DbSet<GenderMl> GenderMls { get; set; }

    public virtual DbSet<GeneticDisorder> GeneticDisorders { get; set; }

    public virtual DbSet<Grievance> Grievances { get; set; }

    public virtual DbSet<Habit> Habits { get; set; }

    public virtual DbSet<HealthCamp> HealthCamps { get; set; }

    public virtual DbSet<Immunization> Immunizations { get; set; }

    public virtual DbSet<Immunization1> Immunizations1 { get; set; }

    public virtual DbSet<InfantDiarrheaTest> InfantDiarrheaTests { get; set; }

    public virtual DbSet<InfantJaundiceTest> InfantJaundiceTests { get; set; }

    public virtual DbSet<Insurance> Insurances { get; set; }

    public virtual DbSet<Inventory> Inventories { get; set; }

    public virtual DbSet<LabResult> LabResults { get; set; }

    public virtual DbSet<LabTest> LabTests { get; set; }

    public virtual DbSet<Language> Languages { get; set; }

    public virtual DbSet<Leaf> Leaves { get; set; }

    public virtual DbSet<Lifestyle> Lifestyles { get; set; }

    public virtual DbSet<LocationBlock> LocationBlocks { get; set; }

    public virtual DbSet<LocationBlockMl> LocationBlockMls { get; set; }

    public virtual DbSet<LocationDistrict> LocationDistricts { get; set; }

    public virtual DbSet<LocationDistrictMl> LocationDistrictMls { get; set; }

    public virtual DbSet<LocationFacility> LocationFacilities { get; set; }

    public virtual DbSet<LocationFacility10dec25> LocationFacility10dec25s { get; set; }

    public virtual DbSet<LocationFacilityMl> LocationFacilityMls { get; set; }

    public virtual DbSet<LocationFacilityType> LocationFacilityTypes { get; set; }

    public virtual DbSet<LocationFacilityTypeMl> LocationFacilityTypeMls { get; set; }

    public virtual DbSet<LocationGp> LocationGps { get; set; }

    public virtual DbSet<LocationGpml> LocationGpmls { get; set; }

    public virtual DbSet<LocationState> LocationStates { get; set; }

    public virtual DbSet<LocationStateMl> LocationStateMls { get; set; }

    public virtual DbSet<LocationSubFacility> LocationSubFacilities { get; set; }

    public virtual DbSet<LocationSubFacility10dec25> LocationSubFacility10dec25s { get; set; }

    public virtual DbSet<LocationSubFacilityMl> LocationSubFacilityMls { get; set; }

    public virtual DbSet<LocationVillage> LocationVillages { get; set; }

    public virtual DbSet<LocationVillageMl> LocationVillageMls { get; set; }

    public virtual DbSet<MedicalEmergency> MedicalEmergencies { get; set; }

    public virtual DbSet<MedicalHistory> MedicalHistories { get; set; }

    public virtual DbSet<MedicationHistory> MedicationHistories { get; set; }

    public virtual DbSet<Menu> Menus { get; set; }

    public virtual DbSet<MenuMl> MenuMls { get; set; }

    public virtual DbSet<Mortality> Mortalities { get; set; }

    public virtual DbSet<MstApplication> MstApplications { get; set; }

    public virtual DbSet<MstApplicationKeyGeneration> MstApplicationKeyGenerations { get; set; }

    public virtual DbSet<MstMenu> MstMenus { get; set; }

    public virtual DbSet<MstMonth> MstMonths { get; set; }

    public virtual DbSet<MstYear> MstYears { get; set; }

    public virtual DbSet<Note> Notes { get; set; }

    public virtual DbSet<Operation> Operations { get; set; }

    public virtual DbSet<OutreachVisit> OutreachVisits { get; set; }

    public virtual DbSet<PastHistory> PastHistories { get; set; }

    public virtual DbSet<Patient> Patients { get; set; }

    public virtual DbSet<PatientVisit> PatientVisits { get; set; }

    public virtual DbSet<Payment> Payments { get; set; }

    public virtual DbSet<Payroll> Payrolls { get; set; }

    public virtual DbSet<PendWebNic> PendWebNics { get; set; }

    public virtual DbSet<Performance> Performances { get; set; }

    public virtual DbSet<PhysicalTest> PhysicalTests { get; set; }

    public virtual DbSet<Prescription> Prescriptions { get; set; }

    public virtual DbSet<Procedure> Procedures { get; set; }

    public virtual DbSet<Purchase> Purchases { get; set; }

    public virtual DbSet<PwAskForResult> PwAskForResults { get; set; }

    public virtual DbSet<PwExaminationResult> PwExaminationResults { get; set; }

    public virtual DbSet<PwPastHistoryResult> PwPastHistoryResults { get; set; }

    public virtual DbSet<Radiology> Radiologies { get; set; }

    public virtual DbSet<Referral> Referrals { get; set; }

    public virtual DbSet<ReferralsIn> ReferralsIns { get; set; }

    public virtual DbSet<ReferralsOut> ReferralsOuts { get; set; }

    public virtual DbSet<ResponseDatum> ResponseData { get; set; }

    public virtual DbSet<Role> Roles { get; set; }

    public virtual DbSet<Role1> Roles1 { get; set; }

    public virtual DbSet<RoleMenu> RoleMenus { get; set; }

    public virtual DbSet<RoleMl> RoleMls { get; set; }

    public virtual DbSet<RoomMasterTable> RoomMasterTables { get; set; }

    public virtual DbSet<RoutineAssessment> RoutineAssessments { get; set; }

    public virtual DbSet<Screening> Screenings { get; set; }

    public virtual DbSet<ScreeningResult> ScreeningResults { get; set; }

    public virtual DbSet<Shift> Shifts { get; set; }

    public virtual DbSet<SocialHistory> SocialHistories { get; set; }

    public virtual DbSet<Staff> Staff { get; set; }

    public virtual DbSet<StateEntryTypewise> StateEntryTypewises { get; set; }

    public virtual DbSet<Stock> Stocks { get; set; }

    public virtual DbSet<SubSymptom> SubSymptoms { get; set; }

    public virtual DbSet<Supplier> Suppliers { get; set; }

    public virtual DbSet<SurgicalHistory> SurgicalHistories { get; set; }

    public virtual DbSet<Symptom> Symptoms { get; set; }

    public virtual DbSet<SymptomsType> SymptomsTypes { get; set; }

    public virtual DbSet<TblCounselling> TblCounsellings { get; set; }

    public virtual DbSet<TblCounsellingStatus> TblCounsellingStatuses { get; set; }

    public virtual DbSet<TblDoctorProfile> TblDoctorProfiles { get; set; }

    public virtual DbSet<TblDrug> TblDrugs { get; set; }

    public virtual DbSet<TblDrugType> TblDrugTypes { get; set; }

    public virtual DbSet<TblPolicy> TblPolicies { get; set; }

    public virtual DbSet<TblPolicyDesc> TblPolicyDescs { get; set; }

    public virtual DbSet<TblPrasavStaff> TblPrasavStaffs { get; set; }

    public virtual DbSet<Training> Training { get; set; }

    public virtual DbSet<TreatmentMaster> TreatmentMasters { get; set; }

    public virtual DbSet<User> Users { get; set; }

    public virtual DbSet<User1> Users1 { get; set; }

    public virtual DbSet<UserAnm> UserAnms { get; set; }

    public virtual DbSet<UserAsha> UserAshas { get; set; }

    public virtual DbSet<UserBlock> UserBlocks { get; set; }

    public virtual DbSet<UserCho> UserChos { get; set; }

    public virtual DbSet<UserDistrict> UserDistricts { get; set; }

    public virtual DbSet<UserFacility> UserFacilities { get; set; }

    public virtual DbSet<UserMidWifery> UserMidWiferies { get; set; }

    public virtual DbSet<UserState> UserStates { get; set; }

    public virtual DbSet<UserVillage> UserVillages { get; set; }

    public virtual DbSet<VaccinationHistory> VaccinationHistories { get; set; }

    public virtual DbSet<ViewAllAnctableDatum> ViewAllAnctableData { get; set; }

    public virtual DbSet<ViewAnmlist> ViewAnmlists { get; set; }

    public virtual DbSet<ViewBeneficaryPrivate> ViewBeneficaryPrivates { get; set; }

    public virtual DbSet<ViewBeneficiary> ViewBeneficiaries { get; set; }

    public virtual DbSet<ViewBlockWiseFilterDatum> ViewBlockWiseFilterData { get; set; }

    public virtual DbSet<ViewCaseDischargeReportPdf> ViewCaseDischargeReportPdfs { get; set; }

    public virtual DbSet<ViewChildRegistration> ViewChildRegistrations { get; set; }

    public virtual DbSet<ViewCopregistration> ViewCopregistrations { get; set; }

    public virtual DbSet<ViewCounselling> ViewCounsellings { get; set; }

    public virtual DbSet<ViewDischargePdf> ViewDischargePdfs { get; set; }

    public virtual DbSet<ViewDistrictWiseDatum> ViewDistrictWiseData { get; set; }

    public virtual DbSet<ViewFacilityWiseFilter> ViewFacilityWiseFilters { get; set; }

    public virtual DbSet<ViewGetAncDataInfo> ViewGetAncDataInfos { get; set; }

    public virtual DbSet<ViewGetRegistration> ViewGetRegistrations { get; set; }

    public virtual DbSet<ViewJssyBeneficiaryInfoModel> ViewJssyBeneficiaryInfoModels { get; set; }

    public virtual DbSet<ViewJssyDeliveryInfoModel> ViewJssyDeliveryInfoModels { get; set; }

    public virtual DbSet<ViewJssyDischargeInfoModel> ViewJssyDischargeInfoModels { get; set; }

    public virtual DbSet<ViewPregnantWoman> ViewPregnantWomen { get; set; }

    public virtual DbSet<ViewPwcountReport> ViewPwcountReports { get; set; }

    public virtual DbSet<ViewPwjourney> ViewPwjourneys { get; set; }

    public virtual DbSet<ViewPwreportCountLineList> ViewPwreportCountLineLists { get; set; }

    public virtual DbSet<ViewPwtotalJourney> ViewPwtotalJourneys { get; set; }

    public virtual DbSet<ViewRegistration> ViewRegistrations { get; set; }

    public virtual DbSet<ViewSyncTblBeneficiary> ViewSyncTblBeneficiaries { get; set; }

    public virtual DbSet<ViewTblAncdetail> ViewTblAncdetails { get; set; }

    public virtual DbSet<ViewTblChildHomeVisit> ViewTblChildHomeVisits { get; set; }

    public virtual DbSet<ViewTblChildImmunization> ViewTblChildImmunizations { get; set; }

    public virtual DbSet<ViewTblChildPncdetail> ViewTblChildPncdetails { get; set; }

    public virtual DbSet<ViewTblDeliveryDetail> ViewTblDeliveryDetails { get; set; }

    public virtual DbSet<ViewTblDeliveryOutcome> ViewTblDeliveryOutcomes { get; set; }

    public virtual DbSet<ViewTblDischargeNote> ViewTblDischargeNotes { get; set; }

    public virtual DbSet<ViewTblEccategory> ViewTblEccategories { get; set; }

    public virtual DbSet<ViewTblIntrapartumRegistration> ViewTblIntrapartumRegistrations { get; set; }

    public virtual DbSet<ViewTblLamaDeathForm> ViewTblLamaDeathForms { get; set; }

    public virtual DbSet<ViewTblLrAdmission> ViewTblLrAdmissions { get; set; }

    public virtual DbSet<ViewTblPartography> ViewTblPartographies { get; set; }

    public virtual DbSet<ViewTblPncdetail> ViewTblPncdetails { get; set; }

    public virtual DbSet<ViewTblPostpartumSummery> ViewTblPostpartumSummeries { get; set; }

    public virtual DbSet<ViewTblReferral> ViewTblReferrals { get; set; }

    public virtual DbSet<ViewTblReferred> ViewTblReferreds { get; set; }

    public virtual DbSet<ViewTblState> ViewTblStates { get; set; }

    public virtual DbSet<ViewTotalPregnantWoman> ViewTotalPregnantWomen { get; set; }

    public virtual DbSet<ViewUserList> ViewUserLists { get; set; }

    public virtual DbSet<Village> Villages { get; set; }

    public virtual DbSet<Visit> Visits { get; set; }

    public virtual DbSet<Vital> Vitals { get; set; }

    public virtual DbSet<VwAncdetailsContinuumReport> VwAncdetailsContinuumReports { get; set; }

    public virtual DbSet<VwChildRegistrationDetail> VwChildRegistrationDetails { get; set; }

    public virtual DbSet<VwChildRegistrationDetails1> VwChildRegistrationDetails1s { get; set; }

    public virtual DbSet<VwChildRegistrationDetails19april2025> VwChildRegistrationDetails19april2025s { get; set; }

    public virtual DbSet<VwChildRegistrationDetails21april2025Backup> VwChildRegistrationDetails21april2025Backups { get; set; }

    public virtual DbSet<VwComplicationsId> VwComplicationsIds { get; set; }

    public virtual DbSet<VwDeliveryDetail> VwDeliveryDetails { get; set; }

    public virtual DbSet<VwDeliveryNote> VwDeliveryNotes { get; set; }

    public virtual DbSet<VwPdmonitoring> VwPdmonitorings { get; set; }

    public virtual DbSet<VwPrasavGeoArea> VwPrasavGeoAreas { get; set; }

    public virtual DbSet<VwSecondChildRegistrationDetail> VwSecondChildRegistrationDetails { get; set; }

    public virtual DbSet<Wfl> Wfls { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        if (!optionsBuilder.IsConfigured)
        {
            IConfigurationRoot configuration = new ConfigurationBuilder().SetBasePath(AppDomain.CurrentDomain.BaseDirectory).AddJsonFile("appsetting.json").Build();
            optionsBuilder.UseSqlServer(configuration.GetConnectionString("DefaultConnectionString"));
        }
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Admission>(entity =>
        {
            entity.HasKey(e => e.Sno).HasName("PK__admissio__DDDF6446113AA420");

            entity.ToTable("admissions");

            entity.Property(e => e.Sno).HasColumnName("sno");
            entity.Property(e => e.AdmissionDate)
                .HasMaxLength(50)
                .HasColumnName("admission_date");
            entity.Property(e => e.AdmissionId).HasColumnName("admissionId");
            entity.Property(e => e.CreatedOn)
                .HasMaxLength(50)
                .HasColumnName("createdOn");
            entity.Property(e => e.DischargeDate)
                .HasMaxLength(50)
                .HasColumnName("discharge_date");
            entity.Property(e => e.Hospital)
                .HasMaxLength(255)
                .HasColumnName("hospital");
            entity.Property(e => e.PatientId).HasColumnName("patient_id");
            entity.Property(e => e.Reason).HasColumnName("reason");
            entity.Property(e => e.Remarks).HasColumnName("remarks");
        });

        modelBuilder.Entity<Allergy>(entity =>
        {
            entity.HasKey(e => e.Sno).HasName("PK__allergie__DDDF64468801023A");

            entity.ToTable("allergies");

            entity.Property(e => e.Sno).HasColumnName("sno");
            entity.Property(e => e.Allergen)
                .HasMaxLength(255)
                .HasColumnName("allergen");
            entity.Property(e => e.AllergyId).HasColumnName("allergyId");
            entity.Property(e => e.PatientId).HasColumnName("patient_id");
            entity.Property(e => e.Reaction).HasColumnName("reaction");
            entity.Property(e => e.RecordedOn)
                .HasMaxLength(50)
                .HasColumnName("recordedOn");
            entity.Property(e => e.Severity)
                .HasMaxLength(50)
                .HasColumnName("severity");
        });

        modelBuilder.Entity<AndroidMetadatum>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("android_metadata");

            entity.Property(e => e.Locale)
                .HasMaxLength(10)
                .HasColumnName("locale");
        });

        modelBuilder.Entity<Anm>(entity =>
        {
            entity.HasKey(e => e.Anmid).HasName("PK_ANMMaster");

            entity.ToTable("ANM");

            entity.Property(e => e.Anmid).HasColumnName("ANMID");
            entity.Property(e => e.Anmname)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("ANMName");
            entity.Property(e => e.BlockId).HasColumnName("BlockID");
            entity.Property(e => e.CadreId).HasColumnName("CadreID");
            entity.Property(e => e.CreatedOn).HasColumnType("datetime");
            entity.Property(e => e.DistrictId).HasColumnName("DistrictID");
            entity.Property(e => e.EmailId)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("EmailID");
            entity.Property(e => e.FacilityId).HasColumnName("FacilityID");
            entity.Property(e => e.GenderId).HasColumnName("GenderID");
            entity.Property(e => e.MobileNo)
                .HasMaxLength(10)
                .IsUnicode(false);
            entity.Property(e => e.RoleId).HasColumnName("RoleID");
            entity.Property(e => e.StateId).HasColumnName("StateID");
            entity.Property(e => e.SubFacilityId).HasColumnName("SubFacilityID");
            entity.Property(e => e.UpdatedOn).HasColumnType("datetime");
            entity.Property(e => e.Username)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.VillageId).HasColumnName("VillageID");

            entity.HasOne(d => d.Block).WithMany(p => p.Anms)
                .HasForeignKey(d => d.BlockId)
                .HasConstraintName("FK_ANM_LocationBlock");

            entity.HasOne(d => d.Cadre).WithMany(p => p.Anms)
                .HasForeignKey(d => d.CadreId)
                .HasConstraintName("FK_ANM_Cadre");

            entity.HasOne(d => d.District).WithMany(p => p.Anms)
                .HasForeignKey(d => d.DistrictId)
                .HasConstraintName("FK_ANM_LocationDistrict");

            entity.HasOne(d => d.Facility).WithMany(p => p.Anms)
                .HasForeignKey(d => d.FacilityId)
                .HasConstraintName("FK_ANM_LocationFacility");

            entity.HasOne(d => d.Gender).WithMany(p => p.Anms)
                .HasForeignKey(d => d.GenderId)
                .HasConstraintName("FK_ANM_Gender");

            entity.HasOne(d => d.Role).WithMany(p => p.Anms)
                .HasForeignKey(d => d.RoleId)
                .HasConstraintName("FK_ANM_Role");

            entity.HasOne(d => d.State).WithMany(p => p.Anms)
                .HasForeignKey(d => d.StateId)
                .HasConstraintName("FK_ANM_LocationState");

            entity.HasOne(d => d.SubFacility).WithMany(p => p.Anms)
                .HasForeignKey(d => d.SubFacilityId)
                .HasConstraintName("FK_ANM_LocationSubFacility");

            entity.HasOne(d => d.Village).WithMany(p => p.Anms)
                .HasForeignKey(d => d.VillageId)
                .HasConstraintName("FK_ANM_LocationVillage");
        });

        modelBuilder.Entity<AnmcatchmentArea>(entity =>
        {
            entity.HasKey(e => e.AnmareaId);

            entity.ToTable("ANMCatchmentArea");

            entity.Property(e => e.AnmareaId).HasColumnName("ANMAreaID");
            entity.Property(e => e.Anmid).HasColumnName("ANMID");
            entity.Property(e => e.FacilityId).HasColumnName("FacilityID");
            entity.Property(e => e.SubFacilityId).HasColumnName("SubFacilityID");
            entity.Property(e => e.VillageId).HasColumnName("VillageID");

            entity.HasOne(d => d.Anm).WithMany(p => p.AnmcatchmentAreas)
                .HasForeignKey(d => d.Anmid)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_ANMCatchmentArea_ANM");

            entity.HasOne(d => d.Village).WithMany(p => p.AnmcatchmentAreas)
                .HasForeignKey(d => d.VillageId)
                .HasConstraintName("FK_ANMCatchmentArea_LocationVillage");
        });

        modelBuilder.Entity<AnmcatchmentAreaTransHist>(entity =>
        {
            entity.HasKey(e => e.AnmareaTransferId);

            entity.ToTable("ANMCatchmentAreaTransHist");

            entity.Property(e => e.AnmareaTransferId).HasColumnName("ANMAreaTransferID");
            entity.Property(e => e.Anmid).HasColumnName("ANMID");
            entity.Property(e => e.FacilityId).HasColumnName("FacilityID");
            entity.Property(e => e.SubFacilityId).HasColumnName("SubFacilityID");
            entity.Property(e => e.TransferedOn).HasColumnType("datetime");
            entity.Property(e => e.VillageId).HasColumnName("VillageID");

            entity.HasOne(d => d.Anm).WithMany(p => p.AnmcatchmentAreaTransHists)
                .HasForeignKey(d => d.Anmid)
                .HasConstraintName("FK_ANMCatchmentAreaTransHist_ANM");

            entity.HasOne(d => d.CreatedByNavigation).WithMany(p => p.AnmcatchmentAreaTransHists)
                .HasForeignKey(d => d.CreatedBy)
                .HasConstraintName("FK_ANMCatchmentAreaTransHist_User");

            entity.HasOne(d => d.Village).WithMany(p => p.AnmcatchmentAreaTransHists)
                .HasForeignKey(d => d.VillageId)
                .HasConstraintName("FK_ANMCatchmentAreaTransHist_LocationVillage");
        });

        modelBuilder.Entity<Anmml>(entity =>
        {
            entity.HasKey(e => new { e.Anmmlid, e.Anmid, e.LangId });

            entity.ToTable("ANMML");

            entity.Property(e => e.Anmmlid)
                .ValueGeneratedOnAdd()
                .HasColumnName("ANMMLID");
            entity.Property(e => e.Anmid).HasColumnName("ANMID");
            entity.Property(e => e.LangId).HasColumnName("LangID");
            entity.Property(e => e.Anmname)
                .HasMaxLength(50)
                .HasColumnName("ANMName");
            entity.Property(e => e.BlockId).HasColumnName("BlockID");
            entity.Property(e => e.CadreId).HasColumnName("CadreID");
            entity.Property(e => e.DistrictId).HasColumnName("DistrictID");
            entity.Property(e => e.FacilityId).HasColumnName("FacilityID");
            entity.Property(e => e.IsDeleted).HasDefaultValue(0);
            entity.Property(e => e.RoleId).HasColumnName("RoleID");
            entity.Property(e => e.StateId).HasColumnName("StateID");
            entity.Property(e => e.SubFacilityId).HasColumnName("SubFacilityID");
            entity.Property(e => e.VillageId).HasColumnName("VillageID");
        });

        modelBuilder.Entity<AnmtransferHistory>(entity =>
        {
            entity.HasKey(e => e.AnmtransferId).HasName("PK_ANMTransferHistory_1");

            entity.ToTable("ANMTransferHistory");

            entity.Property(e => e.AnmtransferId).HasColumnName("ANMTransferID");
            entity.Property(e => e.Anmid).HasColumnName("ANMID");
            entity.Property(e => e.CreatedOn).HasColumnType("datetime");
            entity.Property(e => e.FacilityId).HasColumnName("FacilityID");
            entity.Property(e => e.SubFacilityId).HasColumnName("SubFacilityID");
            entity.Property(e => e.TransferedOn).HasColumnType("datetime");
            entity.Property(e => e.VillageId).HasColumnName("VillageID");

            entity.HasOne(d => d.Anm).WithMany(p => p.AnmtransferHistories)
                .HasForeignKey(d => d.Anmid)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_ANMTransferHistory_ANM");

            entity.HasOne(d => d.CreatedByNavigation).WithMany(p => p.AnmtransferHistories)
                .HasForeignKey(d => d.CreatedBy)
                .HasConstraintName("FK_ANMTransferHistory_User");

            entity.HasOne(d => d.Village).WithMany(p => p.AnmtransferHistories)
                .HasForeignKey(d => d.VillageId)
                .HasConstraintName("FK_ANMTransferHistory_LocationVillage");
        });

        modelBuilder.Entity<AppCategory>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("app_categories");

            entity.Property(e => e.Code)
                .HasMaxLength(20)
                .HasColumnName("code");
            entity.Property(e => e.Created)
                .HasColumnType("smalldatetime")
                .HasColumnName("created");
            entity.Property(e => e.CreatedBy).HasColumnName("created_by");
            entity.Property(e => e.Description).HasColumnName("description");
            entity.Property(e => e.EDescription)
                .HasMaxLength(500)
                .HasColumnName("E_Description");
            entity.Property(e => e.EName)
                .HasMaxLength(200)
                .HasColumnName("E_Name");
            entity.Property(e => e.FlagId).HasColumnName("FlagID");
            entity.Property(e => e.HDescription)
                .HasMaxLength(500)
                .HasColumnName("H_Description");
            entity.Property(e => e.HName)
                .HasMaxLength(200)
                .HasColumnName("H_Name");
            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.IsDeleted).HasColumnName("is_deleted");
            entity.Property(e => e.Modified)
                .HasColumnType("smalldatetime")
                .HasColumnName("modified");
            entity.Property(e => e.ModifiedBy).HasColumnName("modified_by");
            entity.Property(e => e.Name)
                .HasMaxLength(255)
                .HasColumnName("name");
        });

        modelBuilder.Entity<AppCategoryItem>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("app_category_items");

            entity.Property(e => e.AppCategoryId).HasColumnName("app_category_id");
            entity.Property(e => e.ArbitGrpNo).HasColumnName("arbit_grp_no");
            entity.Property(e => e.Code)
                .HasMaxLength(20)
                .HasColumnName("code");
            entity.Property(e => e.Created)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("smalldatetime")
                .HasColumnName("created");
            entity.Property(e => e.CreatedBy).HasColumnName("created_by");
            entity.Property(e => e.Description).HasColumnName("description");
            entity.Property(e => e.DisplayOrder).HasColumnName("display_order");
            entity.Property(e => e.EDescription)
                .HasMaxLength(500)
                .HasColumnName("E_Description");
            entity.Property(e => e.EName)
                .HasMaxLength(500)
                .HasColumnName("E_Name");
            entity.Property(e => e.ErchvalueId).HasColumnName("ERCHValueID");
            entity.Property(e => e.FlagId).HasColumnName("FlagID");
            entity.Property(e => e.HDescription)
                .HasMaxLength(500)
                .HasColumnName("H_Description");
            entity.Property(e => e.HName)
                .HasMaxLength(500)
                .HasColumnName("H_Name");
            entity.Property(e => e.Id)
                .ValueGeneratedOnAdd()
                .HasColumnName("id");
            entity.Property(e => e.IsDeleted).HasColumnName("is_deleted");
            entity.Property(e => e.IsOther).HasColumnName("is_other");
            entity.Property(e => e.Metadata).HasColumnName("metadata");
            entity.Property(e => e.Modified)
                .HasColumnType("smalldatetime")
                .HasColumnName("modified");
            entity.Property(e => e.ModifiedBy).HasColumnName("modified_by");
            entity.Property(e => e.Name)
                .HasMaxLength(255)
                .HasColumnName("name");
            entity.Property(e => e.Pctsid)
                .HasDefaultValue(0)
                .HasColumnName("PCTSID");
            entity.Property(e => e.ResRoles).HasColumnName("res_roles");
            entity.Property(e => e.ResView).HasColumnName("res_view");
        });

        modelBuilder.Entity<Appointment>(entity =>
        {
            entity.HasKey(e => e.Sno).HasName("PK__appointm__DDDF64469984C99C");

            entity.ToTable("appointments");

            entity.Property(e => e.Sno).HasColumnName("sno");
            entity.Property(e => e.AppointmentId).HasColumnName("appointmentId");
            entity.Property(e => e.CreatedOn)
                .HasMaxLength(50)
                .HasColumnName("createdOn");
            entity.Property(e => e.Date)
                .HasMaxLength(50)
                .HasColumnName("date");
            entity.Property(e => e.DoctorId).HasColumnName("doctorId");
            entity.Property(e => e.PatientId).HasColumnName("patient_id");
            entity.Property(e => e.Reason).HasColumnName("reason");
            entity.Property(e => e.Status)
                .HasMaxLength(50)
                .HasColumnName("status");
            entity.Property(e => e.Time)
                .HasMaxLength(50)
                .HasColumnName("time");
        });

        modelBuilder.Entity<Asha>(entity =>
        {
            entity.ToTable("ASHA");

            entity.Property(e => e.Ashaid).HasColumnName("ASHAID");
            entity.Property(e => e.Anmid).HasColumnName("ANMID");
            entity.Property(e => e.Ashaname)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("ASHAName");
            entity.Property(e => e.CreatedOn).HasColumnType("datetime");
            entity.Property(e => e.EmailId)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("EmailID");
            entity.Property(e => e.MobileNo)
                .HasMaxLength(10)
                .IsUnicode(false);
            entity.Property(e => e.UpdatedOn).HasColumnType("datetime");
        });

        modelBuilder.Entity<AshaMapping>(entity =>
        {
            entity.ToTable("AshaMapping");

            entity.Property(e => e.AshaMappingId).HasColumnName("AshaMappingID");
            entity.Property(e => e.AshaId).HasColumnName("AshaID");
            entity.Property(e => e.CadreId).HasColumnName("CadreID");
            entity.Property(e => e.FacilityId).HasColumnName("FacilityID");
            entity.Property(e => e.IsDeleted).HasDefaultValue(0);
            entity.Property(e => e.SubFacilityId).HasColumnName("SubFacilityID");
            entity.Property(e => e.VillageId).HasColumnName("VillageID");
        });

        modelBuilder.Entity<AshaVillage>(entity =>
        {
            entity.HasKey(e => e.AshaVillId);

            entity.Property(e => e.AshaVillId).HasColumnName("AshaVillID");
            entity.Property(e => e.Ashaid).HasColumnName("ASHAID");
            entity.Property(e => e.VillageId).HasColumnName("VillageID");
        });

        modelBuilder.Entity<Ashaml>(entity =>
        {
            entity.HasKey(e => new { e.Ashaid, e.LangId }).HasName("PK_ASHAML_1");

            entity.ToTable("ASHAML");

            entity.Property(e => e.Ashaid).HasColumnName("ASHAID");
            entity.Property(e => e.LangId).HasColumnName("LangID");
            entity.Property(e => e.Anmid).HasColumnName("ANMID");
            entity.Property(e => e.Ashaname)
                .HasMaxLength(50)
                .HasColumnName("ASHAName");
        });

        modelBuilder.Entity<AskFor>(entity =>
        {
            entity.HasKey(e => e.Sno).HasName("PK__ask_for__DDDF6446791DCC59");

            entity.ToTable("ask_for");

            entity.Property(e => e.Sno).HasColumnName("sno");
            entity.Property(e => e.CharLimit)
                .HasMaxLength(10)
                .HasColumnName("char_limit");
            entity.Property(e => e.Code)
                .HasMaxLength(20)
                .HasColumnName("code");
            entity.Property(e => e.FieldType)
                .HasMaxLength(20)
                .HasColumnName("field_type");
            entity.Property(e => e.InputType)
                .HasMaxLength(20)
                .HasColumnName("input_type");
            entity.Property(e => e.Mandatory).HasColumnName("mandatory");
            entity.Property(e => e.MaxValue)
                .HasMaxLength(10)
                .HasColumnName("max_value");
            entity.Property(e => e.MinValue)
                .HasMaxLength(10)
                .HasColumnName("min_value");
            entity.Property(e => e.QuestionEn)
                .HasMaxLength(255)
                .HasColumnName("question_en");
            entity.Property(e => e.QuestionHi)
                .HasMaxLength(255)
                .HasColumnName("question_hi");
            entity.Property(e => e.Symptoms)
                .HasMaxLength(255)
                .HasColumnName("symptoms");
        });

        modelBuilder.Entity<Attendance>(entity =>
        {
            entity.HasKey(e => e.Sno).HasName("PK__attendan__DDDF6446C0A42E13");

            entity.ToTable("attendance");

            entity.Property(e => e.Sno).HasColumnName("sno");
            entity.Property(e => e.AttendanceId).HasColumnName("attendanceId");
            entity.Property(e => e.CreatedOn)
                .HasMaxLength(50)
                .HasColumnName("createdOn");
            entity.Property(e => e.Date)
                .HasMaxLength(50)
                .HasColumnName("date");
            entity.Property(e => e.Remarks).HasColumnName("remarks");
            entity.Property(e => e.StaffId).HasColumnName("staffId");
            entity.Property(e => e.Status)
                .HasMaxLength(50)
                .HasColumnName("status");
        });

        modelBuilder.Entity<Bank>(entity =>
        {
            entity.HasKey(e => e.BankUid);

            entity.ToTable("Bank");

            entity.Property(e => e.BankUid).HasColumnName("BankUID");
            entity.Property(e => e.BankAccountLen)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.BankCode)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.BankId).HasColumnName("BankID");
            entity.Property(e => e.BankName)
                .HasMaxLength(150)
                .IsUnicode(false);
            entity.Property(e => e.BankShortName)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.BankTypeId).HasColumnName("BankTypeID");
            entity.Property(e => e.CreatedOn).HasColumnType("datetime");
            entity.Property(e => e.IsServer).HasDefaultValue(1);
            entity.Property(e => e.UpdatedOn).HasColumnType("datetime");
        });

        modelBuilder.Entity<BankBranch>(entity =>
        {
            entity.HasKey(e => e.BankBranchUid);

            entity.ToTable("BankBranch");

            entity.Property(e => e.BankBranchUid).HasColumnName("BankBranchUID");
            entity.Property(e => e.BankBranchId).HasColumnName("BankBranchID");
            entity.Property(e => e.BankId).HasColumnName("BankID");
            entity.Property(e => e.CreatedOn).HasColumnType("datetime");
            entity.Property(e => e.DistrictId).HasColumnName("DistrictID");
            entity.Property(e => e.Ifsccode).HasColumnName("IFSCCode");
            entity.Property(e => e.IsServer).HasDefaultValue(1);
            entity.Property(e => e.RuralUrbanId).HasColumnName("RuralUrbanID");
            entity.Property(e => e.StateId).HasColumnName("StateID");
            entity.Property(e => e.UpdatedOn).HasColumnType("datetime");
            entity.Property(e => e.VillageId).HasColumnName("VillageID");
        });

        modelBuilder.Entity<BankBranchMl>(entity =>
        {
            entity.HasKey(e => e.BankBranchId);

            entity.ToTable("BankBranchML");

            entity.Property(e => e.BankBranchId).HasColumnName("BankBranchID");
            entity.Property(e => e.BankId).HasColumnName("BankID");
            entity.Property(e => e.CreatedOn).HasColumnType("datetime");
            entity.Property(e => e.Ifsccode).HasColumnName("IFSCCode");
            entity.Property(e => e.RuralUrbanId).HasColumnName("RuralUrbanID");
            entity.Property(e => e.UpdatedOn).HasColumnType("datetime");
            entity.Property(e => e.VillageId).HasColumnName("VillageID");
        });

        modelBuilder.Entity<BankMl>(entity =>
        {
            entity.HasKey(e => e.BankId);

            entity.ToTable("BankML");

            entity.Property(e => e.BankId).HasColumnName("BankID");
            entity.Property(e => e.BankAccountLen)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.BankCode)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.BankName)
                .HasMaxLength(150)
                .IsUnicode(false);
            entity.Property(e => e.BankShortName)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.BankTypeId).HasColumnName("BankTypeID");
            entity.Property(e => e.CreatedOn).HasColumnType("datetime");
            entity.Property(e => e.UpdatedOn).HasColumnType("datetime");
        });

        modelBuilder.Entity<BankType>(entity =>
        {
            entity.ToTable("BankType");

            entity.Property(e => e.BankTypeId).HasColumnName("BankTypeID");
            entity.Property(e => e.BankType1)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("BankType");
            entity.Property(e => e.CreatedOn).HasColumnType("datetime");
            entity.Property(e => e.UpdatedOn).HasColumnType("datetime");
        });

        modelBuilder.Entity<Billing>(entity =>
        {
            entity.HasKey(e => e.Sno).HasName("PK__billing__DDDF6446FE3FD8A9");

            entity.ToTable("billing");

            entity.Property(e => e.Sno).HasColumnName("sno");
            entity.Property(e => e.Amount)
                .HasMaxLength(50)
                .HasColumnName("amount");
            entity.Property(e => e.BillingDate)
                .HasMaxLength(50)
                .HasColumnName("billing_date");
            entity.Property(e => e.BillingId).HasColumnName("billingId");
            entity.Property(e => e.CreatedOn)
                .HasMaxLength(50)
                .HasColumnName("createdOn");
            entity.Property(e => e.PatientId).HasColumnName("patient_id");
            entity.Property(e => e.PaymentStatus)
                .HasMaxLength(50)
                .HasColumnName("payment_status");
            entity.Property(e => e.Remarks).HasColumnName("remarks");
        });

        modelBuilder.Entity<Cadre>(entity =>
        {
            entity.HasKey(e => e.CadreId).HasName("PK_Cadremaster");

            entity.ToTable("Cadre");

            entity.Property(e => e.CadreId).HasColumnName("CadreID");
            entity.Property(e => e.Cadre1)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("Cadre");
            entity.Property(e => e.Createdon).HasColumnType("datetime");
            entity.Property(e => e.UpdatedOn).HasColumnType("datetime");
        });

        modelBuilder.Entity<CadreMl>(entity =>
        {
            entity.HasKey(e => new { e.CadreId, e.LangId });

            entity.ToTable("CadreML");

            entity.Property(e => e.CadreId).HasColumnName("CadreID");
            entity.Property(e => e.LangId).HasColumnName("LangID");
            entity.Property(e => e.Cadre).HasMaxLength(50);

            entity.HasOne(d => d.CadreNavigation).WithMany(p => p.CadreMls)
                .HasForeignKey(d => d.CadreId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_CadreML_Cadre");
        });

        modelBuilder.Entity<CaseDischargeReportPdfharshit>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("case_discharge_report_pdfharshit");

            entity.Property(e => e.Add)
                .HasMaxLength(50)
                .UseCollation("SQL_Latin1_General_CP1_CI_AS")
                .HasColumnName("add");
            entity.Property(e => e.AdmTime)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("adm_time");
            entity.Property(e => e.Age).HasColumnName("age");
            entity.Property(e => e.AsmanCode)
                .HasMaxLength(22)
                .UseCollation("SQL_Latin1_General_CP1_CI_AS")
                .HasColumnName("asman_code");
            entity.Property(e => e.Baby1Comp)
                .HasMaxLength(255)
                .HasColumnName("baby1_comp");
            entity.Property(e => e.Baby1CompItems)
                .HasMaxLength(200)
                .UseCollation("SQL_Latin1_General_CP1_CI_AS")
                .HasColumnName("baby1_comp_items");
            entity.Property(e => e.Baby1CompOthr)
                .HasMaxLength(100)
                .UseCollation("SQL_Latin1_General_CP1_CI_AS")
                .HasColumnName("baby1_comp_othr");
            entity.Property(e => e.Baby1DelPlace)
                .HasMaxLength(255)
                .HasColumnName("baby1_del_place");
            entity.Property(e => e.Baby1RefToSncu)
                .HasMaxLength(255)
                .HasColumnName("baby1_ref_to_sncu");
            entity.Property(e => e.Baby1RefToSncuItems)
                .HasMaxLength(200)
                .UseCollation("SQL_Latin1_General_CP1_CI_AS")
                .HasColumnName("baby1_ref_to_sncu_items");
            entity.Property(e => e.Baby1RefToSncuOthr)
                .HasMaxLength(100)
                .UseCollation("SQL_Latin1_General_CP1_CI_AS")
                .HasColumnName("baby1_ref_to_sncu_othr");
            entity.Property(e => e.Baby1Temp)
                .HasColumnType("decimal(5, 2)")
                .HasColumnName("baby1_temp");
            entity.Property(e => e.Baby1ToInstitutionId).HasColumnName("baby1_to_institution_id");
            entity.Property(e => e.Baby1ToInstitutionOther)
                .HasMaxLength(255)
                .UseCollation("SQL_Latin1_General_CP1_CI_AS")
                .HasColumnName("baby1_to_institution_other");
            entity.Property(e => e.Baby1WeightGm)
                .HasMaxLength(5)
                .UseCollation("SQL_Latin1_General_CP1_CI_AS")
                .HasColumnName("baby1_weight_gm");
            entity.Property(e => e.Baby2Comp)
                .HasMaxLength(255)
                .HasColumnName("baby2_comp");
            entity.Property(e => e.Baby2CompItems)
                .HasMaxLength(200)
                .UseCollation("SQL_Latin1_General_CP1_CI_AS")
                .HasColumnName("baby2_comp_items");
            entity.Property(e => e.Baby2CompOthr)
                .HasMaxLength(100)
                .UseCollation("SQL_Latin1_General_CP1_CI_AS")
                .HasColumnName("baby2_comp_othr");
            entity.Property(e => e.Baby2DelPlace)
                .HasMaxLength(255)
                .HasColumnName("baby2_del_place");
            entity.Property(e => e.Baby2RefToSncu)
                .HasMaxLength(255)
                .HasColumnName("baby2_ref_to_sncu");
            entity.Property(e => e.Baby2RefToSncuItems)
                .HasMaxLength(200)
                .UseCollation("SQL_Latin1_General_CP1_CI_AS")
                .HasColumnName("baby2_ref_to_sncu_items");
            entity.Property(e => e.Baby2RefToSncuOthr)
                .HasMaxLength(100)
                .UseCollation("SQL_Latin1_General_CP1_CI_AS")
                .HasColumnName("baby2_ref_to_sncu_othr");
            entity.Property(e => e.Baby2Temp)
                .HasColumnType("decimal(5, 2)")
                .HasColumnName("baby2_temp");
            entity.Property(e => e.Baby2ToInstitutionId).HasColumnName("baby2_to_institution_id");
            entity.Property(e => e.Baby2ToInstitutionOther)
                .HasMaxLength(255)
                .UseCollation("SQL_Latin1_General_CP1_CI_AS")
                .HasColumnName("baby2_to_institution_other");
            entity.Property(e => e.Baby2WeightGm)
                .HasMaxLength(5)
                .UseCollation("SQL_Latin1_General_CP1_CI_AS")
                .HasColumnName("baby2_weight_gm");
            entity.Property(e => e.Baby3Comp)
                .HasMaxLength(255)
                .HasColumnName("baby3_comp");
            entity.Property(e => e.Baby3CompItems)
                .HasMaxLength(200)
                .UseCollation("SQL_Latin1_General_CP1_CI_AS")
                .HasColumnName("baby3_comp_items");
            entity.Property(e => e.Baby3CompOthr)
                .HasMaxLength(100)
                .UseCollation("SQL_Latin1_General_CP1_CI_AS")
                .HasColumnName("baby3_comp_othr");
            entity.Property(e => e.Baby3DelPlace)
                .HasMaxLength(255)
                .HasColumnName("baby3_del_place");
            entity.Property(e => e.Baby3RefToSncu)
                .HasMaxLength(255)
                .HasColumnName("baby3_ref_to_sncu");
            entity.Property(e => e.Baby3RefToSncuItems)
                .HasMaxLength(200)
                .UseCollation("SQL_Latin1_General_CP1_CI_AS")
                .HasColumnName("baby3_ref_to_sncu_items");
            entity.Property(e => e.Baby3RefToSncuOthr)
                .HasMaxLength(100)
                .UseCollation("SQL_Latin1_General_CP1_CI_AS")
                .HasColumnName("baby3_ref_to_sncu_othr");
            entity.Property(e => e.Baby3Temp)
                .HasColumnType("decimal(5, 2)")
                .HasColumnName("baby3_temp");
            entity.Property(e => e.Baby3ToInstitutionId).HasColumnName("baby3_to_institution_id");
            entity.Property(e => e.Baby3ToInstitutionOther)
                .HasMaxLength(255)
                .UseCollation("SQL_Latin1_General_CP1_CI_AS")
                .HasColumnName("baby3_to_institution_other");
            entity.Property(e => e.Baby3WeightGm)
                .HasMaxLength(5)
                .UseCollation("SQL_Latin1_General_CP1_CI_AS")
                .HasColumnName("baby3_weight_gm");
            entity.Property(e => e.Baby4Comp)
                .HasMaxLength(255)
                .HasColumnName("baby4_comp");
            entity.Property(e => e.Baby4CompItems)
                .HasMaxLength(200)
                .UseCollation("SQL_Latin1_General_CP1_CI_AS")
                .HasColumnName("baby4_comp_items");
            entity.Property(e => e.Baby4CompOthr)
                .HasMaxLength(100)
                .UseCollation("SQL_Latin1_General_CP1_CI_AS")
                .HasColumnName("baby4_comp_othr");
            entity.Property(e => e.Baby4DelPlace)
                .HasMaxLength(255)
                .HasColumnName("baby4_del_place");
            entity.Property(e => e.Baby4RefToSncu)
                .HasMaxLength(255)
                .HasColumnName("baby4_ref_to_sncu");
            entity.Property(e => e.Baby4RefToSncuItems)
                .HasMaxLength(200)
                .UseCollation("SQL_Latin1_General_CP1_CI_AS")
                .HasColumnName("baby4_ref_to_sncu_items");
            entity.Property(e => e.Baby4RefToSncuOthr)
                .HasMaxLength(100)
                .UseCollation("SQL_Latin1_General_CP1_CI_AS")
                .HasColumnName("baby4_ref_to_sncu_othr");
            entity.Property(e => e.Baby4Temp)
                .HasColumnType("decimal(5, 2)")
                .HasColumnName("baby4_temp");
            entity.Property(e => e.Baby4ToInstitutionId).HasColumnName("baby4_to_institution_id");
            entity.Property(e => e.Baby4ToInstitutionOther)
                .HasMaxLength(255)
                .UseCollation("SQL_Latin1_General_CP1_CI_AS")
                .HasColumnName("baby4_to_institution_other");
            entity.Property(e => e.Baby4WeightGm)
                .HasMaxLength(5)
                .UseCollation("SQL_Latin1_General_CP1_CI_AS")
                .HasColumnName("baby4_weight_gm");
            entity.Property(e => e.BabyKitProvide)
                .HasMaxLength(3)
                .IsUnicode(false);
            entity.Property(e => e.Bg)
                .HasMaxLength(255)
                .HasColumnName("bg");
            entity.Property(e => e.Birth1CertGiven)
                .HasMaxLength(255)
                .HasColumnName("Birth1_cert_given");
            entity.Property(e => e.Birth2CertGiven)
                .HasMaxLength(255)
                .HasColumnName("Birth2_cert_given");
            entity.Property(e => e.Birth3CertGiven)
                .HasMaxLength(255)
                .HasColumnName("Birth3_cert_given");
            entity.Property(e => e.Birth4CertGiven)
                .HasMaxLength(255)
                .HasColumnName("Birth4_cert_given");
            entity.Property(e => e.BirthDefects1)
                .HasMaxLength(255)
                .HasColumnName("birth_defects1");
            entity.Property(e => e.BirthDefects2)
                .HasMaxLength(255)
                .HasColumnName("birth_defects2");
            entity.Property(e => e.BirthDefects3)
                .HasMaxLength(255)
                .HasColumnName("birth_defects3");
            entity.Property(e => e.BirthDefects4)
                .HasMaxLength(255)
                .HasColumnName("birth_defects4");
            entity.Property(e => e.BirthDefectsItems1).HasColumnName("birth_defects_items1");
            entity.Property(e => e.BirthDefectsItems2).HasColumnName("birth_defects_items2");
            entity.Property(e => e.BirthDefectsItems3).HasColumnName("birth_defects_items3");
            entity.Property(e => e.BirthDefectsItems4).HasColumnName("birth_defects_items4");
            entity.Property(e => e.BirthDefectsOthr1)
                .HasMaxLength(150)
                .UseCollation("SQL_Latin1_General_CP1_CI_AS")
                .HasColumnName("birth_defects_othr1");
            entity.Property(e => e.BirthDefectsOthr2)
                .HasMaxLength(150)
                .UseCollation("SQL_Latin1_General_CP1_CI_AS")
                .HasColumnName("birth_defects_othr2");
            entity.Property(e => e.BirthDefectsOthr3)
                .HasMaxLength(150)
                .UseCollation("SQL_Latin1_General_CP1_CI_AS")
                .HasColumnName("birth_defects_othr3");
            entity.Property(e => e.BirthDefectsOthr4)
                .HasMaxLength(150)
                .UseCollation("SQL_Latin1_General_CP1_CI_AS")
                .HasColumnName("birth_defects_othr4");
            entity.Property(e => e.BirthGirlCmMsg)
                .HasMaxLength(255)
                .HasColumnName("birth_girl_cm_msg");
            entity.Property(e => e.BloodTrans)
                .HasMaxLength(255)
                .HasColumnName("blood_trans");
            entity.Property(e => e.BloodTransType).HasColumnName("blood_trans_type");
            entity.Property(e => e.BloodTransUnitts)
                .HasMaxLength(200)
                .UseCollation("SQL_Latin1_General_CP1_CI_AS")
                .HasColumnName("blood_trans_unitts");
            entity.Property(e => e.BpMax).HasColumnName("bp_max");
            entity.Property(e => e.BpMin).HasColumnName("bp_min");
            entity.Property(e => e.BplDesiGheeCoupon)
                .HasMaxLength(255)
                .HasColumnName("bpl_desi_ghee_coupon");
            entity.Property(e => e.Breast1FeedInitiated)
                .HasMaxLength(255)
                .HasColumnName("breast1_feed_initiated");
            entity.Property(e => e.Breast2FeedInitiated)
                .HasMaxLength(255)
                .HasColumnName("breast2_feed_initiated");
            entity.Property(e => e.Breast3FeedInitiated)
                .HasMaxLength(255)
                .HasColumnName("breast3_feed_initiated");
            entity.Property(e => e.Breast4FeedInitiated)
                .HasMaxLength(255)
                .HasColumnName("breast4_feed_initiated");
            entity.Property(e => e.BsOgtt)
                .HasMaxLength(20)
                .UseCollation("SQL_Latin1_General_CP1_CI_AS")
                .HasColumnName("bs_ogtt");
            entity.Property(e => e.BsRan)
                .HasMaxLength(20)
                .UseCollation("SQL_Latin1_General_CP1_CI_AS")
                .HasColumnName("bs_ran");
            entity.Property(e => e.CaseId).HasColumnName("case_id");
            entity.Property(e => e.CaseName)
                .HasMaxLength(50)
                .UseCollation("SQL_Latin1_General_CP1_CI_AS")
                .HasColumnName("case_name");
            entity.Property(e => e.CauseOfCesarean1)
                .HasMaxLength(200)
                .UseCollation("SQL_Latin1_General_CP1_CI_AS")
                .HasColumnName("cause_of_cesarean1");
            entity.Property(e => e.CauseOfCesarean2)
                .HasMaxLength(200)
                .UseCollation("SQL_Latin1_General_CP1_CI_AS")
                .HasColumnName("cause_of_cesarean2");
            entity.Property(e => e.CauseOfCesarean3)
                .HasMaxLength(200)
                .UseCollation("SQL_Latin1_General_CP1_CI_AS")
                .HasColumnName("cause_of_cesarean3");
            entity.Property(e => e.CauseOfCesarean4)
                .HasMaxLength(200)
                .UseCollation("SQL_Latin1_General_CP1_CI_AS")
                .HasColumnName("cause_of_cesarean4");
            entity.Property(e => e.Complications).HasColumnName("complications");
            entity.Property(e => e.Condom)
                .HasMaxLength(255)
                .HasColumnName("condom");
            entity.Property(e => e.CounsDangerSigns)
                .HasMaxLength(255)
                .HasColumnName("couns_danger_signs");
            entity.Property(e => e.DateOfAdmission)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("date_of_admission");
            entity.Property(e => e.DateOfDelivery1)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("date_of_delivery1");
            entity.Property(e => e.DeliveryPlace1)
                .HasMaxLength(8)
                .IsUnicode(false);
            entity.Property(e => e.DischargeTime)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("discharge_time");
            entity.Property(e => e.DischargeType)
                .HasMaxLength(255)
                .HasColumnName("discharge_type");
            entity.Property(e => e.DisplayOrder).HasColumnName("display_order");
            entity.Property(e => e.District)
                .HasMaxLength(150)
                .UseCollation("SQL_Latin1_General_CP1_CI_AS")
                .HasColumnName("district");
            entity.Property(e => e.Do)
                .HasMaxLength(50)
                .UseCollation("SQL_Latin1_General_CP1_CI_AS")
                .HasColumnName("do");
            entity.Property(e => e.DurOfGestation)
                .HasMaxLength(6)
                .UseCollation("SQL_Latin1_General_CP1_CI_AS")
                .HasColumnName("dur_of_gestation");
            entity.Property(e => e.FollowUpTime)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("follow_up_time");
            entity.Property(e => e.FoodService)
                .HasMaxLength(255)
                .HasColumnName("food_service");
            entity.Property(e => e.FoodServiceDays)
                .HasMaxLength(255)
                .HasColumnName("food_service_days");
            entity.Property(e => e.Hbsag)
                .HasMaxLength(255)
                .HasColumnName("hbsag");
            entity.Property(e => e.Hiv)
                .HasMaxLength(255)
                .HasColumnName("hiv");
            entity.Property(e => e.Injectable)
                .HasMaxLength(255)
                .HasColumnName("injectable");
            entity.Property(e => e.InstitutionName)
                .HasMaxLength(150)
                .UseCollation("SQL_Latin1_General_CP1_CI_AS")
                .HasColumnName("institution_name");
            entity.Property(e => e.IpdNo)
                .HasMaxLength(20)
                .UseCollation("SQL_Latin1_General_CP1_CI_AS")
                .HasColumnName("ipd_no");
            entity.Property(e => e.IpdNoCase)
                .HasMaxLength(20)
                .UseCollation("SQL_Latin1_General_CP1_CI_AS")
                .HasColumnName("ipd_no_case");
            entity.Property(e => e.IsRefBaby1).HasColumnName("is_ref_baby1");
            entity.Property(e => e.IsRefBaby2).HasColumnName("is_ref_baby2");
            entity.Property(e => e.IsRefBaby3).HasColumnName("is_ref_baby3");
            entity.Property(e => e.IsRefBaby4).HasColumnName("is_ref_baby4");
            entity.Property(e => e.IsRefMother).HasColumnName("is_ref_mother");
            entity.Property(e => e.Lam)
                .HasMaxLength(255)
                .HasColumnName("lam");
            entity.Property(e => e.LbrRegNo)
                .HasMaxLength(20)
                .UseCollation("SQL_Latin1_General_CP1_CI_AS")
                .HasColumnName("lbr_reg_no");
            entity.Property(e => e.MTemp)
                .HasColumnType("decimal(5, 2)")
                .HasColumnName("m_temp");
            entity.Property(e => e.MotherAliveDischarge)
                .HasMaxLength(3)
                .IsUnicode(false);
            entity.Property(e => e.MotherComp)
                .HasMaxLength(255)
                .HasColumnName("mother_comp");
            entity.Property(e => e.MotherCompItems)
                .HasMaxLength(200)
                .UseCollation("SQL_Latin1_General_CP1_CI_AS")
                .HasColumnName("mother_comp_items");
            entity.Property(e => e.MotherCompOthr)
                .HasMaxLength(100)
                .UseCollation("SQL_Latin1_General_CP1_CI_AS")
                .HasColumnName("mother_comp_othr");
            entity.Property(e => e.MotherCottageWard)
                .HasMaxLength(3)
                .IsUnicode(false);
            entity.Property(e => e.NoOfDeliveries)
                .HasMaxLength(255)
                .HasColumnName("no_of_deliveries");
            entity.Property(e => e.OdNo)
                .HasMaxLength(20)
                .UseCollation("SQL_Latin1_General_CP1_CI_AS")
                .HasColumnName("od_no");
            entity.Property(e => e.OutcomeOfDelivery1)
                .HasMaxLength(255)
                .HasColumnName("outcome_of_delivery1");
            entity.Property(e => e.OutcomeOfDelivery2)
                .HasMaxLength(255)
                .HasColumnName("outcome_of_delivery2");
            entity.Property(e => e.OutcomeOfDelivery3)
                .HasMaxLength(255)
                .HasColumnName("outcome_of_delivery3");
            entity.Property(e => e.OutcomeOfDelivery4)
                .HasMaxLength(255)
                .HasColumnName("outcome_of_delivery4");
            entity.Property(e => e.PctsRchNo)
                .HasMaxLength(255)
                .UseCollation("SQL_Latin1_General_CP1_CI_AS")
                .HasColumnName("pcts_rch_no");
            entity.Property(e => e.PdHemoglobin).HasColumnName("pd_hemoglobin");
            entity.Property(e => e.PpiucdInserted)
                .HasMaxLength(255)
                .HasColumnName("ppiucd_inserted");
            entity.Property(e => e.PpiucdInsertedNameHlthWrkr)
                .HasMaxLength(50)
                .UseCollation("SQL_Latin1_General_CP1_CI_AS")
                .HasColumnName("ppiucd_inserted_name_hlth_wrkr");
            entity.Property(e => e.PpiucdInsertedTime)
                .HasMaxLength(13)
                .IsUnicode(false)
                .HasColumnName("ppiucd_inserted_time");
            entity.Property(e => e.PptPpsTime)
                .HasColumnType("smalldatetime")
                .HasColumnName("ppt_pps_time");
            entity.Property(e => e.PptctWasGiven1)
                .HasMaxLength(255)
                .HasColumnName("pptct_was_given1");
            entity.Property(e => e.PptctWasGiven2)
                .HasMaxLength(255)
                .HasColumnName("pptct_was_given2");
            entity.Property(e => e.PptctWasGiven3)
                .HasMaxLength(255)
                .HasColumnName("pptct_was_given3");
            entity.Property(e => e.PptctWasGiven4)
                .HasMaxLength(255)
                .HasColumnName("pptct_was_given4");
            entity.Property(e => e.ProvisionVehicle)
                .HasMaxLength(255)
                .HasColumnName("provision_vehicle");
            entity.Property(e => e.RefOutFinishTime)
                .HasPrecision(0)
                .HasColumnName("ref_out_finish_time");
            entity.Property(e => e.RefReasonBaby1)
                .UseCollation("SQL_Latin1_General_CP1_CI_AS")
                .HasColumnName("ref_reason_baby1");
            entity.Property(e => e.RefReasonBaby2)
                .UseCollation("SQL_Latin1_General_CP1_CI_AS")
                .HasColumnName("ref_reason_baby2");
            entity.Property(e => e.RefReasonBaby3)
                .UseCollation("SQL_Latin1_General_CP1_CI_AS")
                .HasColumnName("ref_reason_baby3");
            entity.Property(e => e.RefReasonBaby4)
                .UseCollation("SQL_Latin1_General_CP1_CI_AS")
                .HasColumnName("ref_reason_baby4");
            entity.Property(e => e.ServDesig)
                .HasMaxLength(50)
                .UseCollation("SQL_Latin1_General_CP1_CI_AS")
                .HasColumnName("serv_desig");
            entity.Property(e => e.ServId).HasColumnName("serv_id");
            entity.Property(e => e.ServName)
                .HasMaxLength(50)
                .UseCollation("SQL_Latin1_General_CP1_CI_AS")
                .HasColumnName("serv_name");
            entity.Property(e => e.ServPhone)
                .HasMaxLength(15)
                .UseCollation("SQL_Latin1_General_CP1_CI_AS")
                .HasColumnName("serv_phone");
            entity.Property(e => e.SexOfBaby1)
                .HasMaxLength(255)
                .HasColumnName("sex_of_baby1");
            entity.Property(e => e.SexOfBaby2)
                .HasMaxLength(255)
                .HasColumnName("sex_of_baby2");
            entity.Property(e => e.SexOfBaby3)
                .HasMaxLength(255)
                .HasColumnName("sex_of_baby3");
            entity.Property(e => e.SexOfBaby4)
                .HasMaxLength(255)
                .HasColumnName("sex_of_baby4");
            entity.Property(e => e.Still1BirthType).HasColumnName("still1_birth_type");
            entity.Property(e => e.Still2BirthType).HasColumnName("still2_birth_type");
            entity.Property(e => e.Still3BirthType).HasColumnName("still3_birth_type");
            entity.Property(e => e.Still4BirthType).HasColumnName("still4_birth_type");
            entity.Property(e => e.ThyroidT3)
                .HasMaxLength(20)
                .UseCollation("SQL_Latin1_General_CP1_CI_AS")
                .HasColumnName("thyroid_t3");
            entity.Property(e => e.ThyroidT4)
                .HasMaxLength(20)
                .UseCollation("SQL_Latin1_General_CP1_CI_AS")
                .HasColumnName("thyroid_t4");
            entity.Property(e => e.ThyroidTsh)
                .HasMaxLength(20)
                .UseCollation("SQL_Latin1_General_CP1_CI_AS")
                .HasColumnName("thyroid_tsh");
            entity.Property(e => e.TimeOfDelivery1)
                .HasMaxLength(15)
                .IsUnicode(false)
                .HasColumnName("time_of_delivery1");
            entity.Property(e => e.TimeOfDelivery2)
                .HasPrecision(0)
                .HasColumnName("time_of_delivery2");
            entity.Property(e => e.TimeOfDelivery3)
                .HasPrecision(0)
                .HasColumnName("time_of_delivery3");
            entity.Property(e => e.TimeOfDelivery4)
                .HasPrecision(0)
                .HasColumnName("time_of_delivery4");
            entity.Property(e => e.TreatAdvised).HasColumnName("treat_advised");
            entity.Property(e => e.TreatAdvisedOthr)
                .UseCollation("SQL_Latin1_General_CP1_CI_AS")
                .HasColumnName("treat_advised_othr");
            entity.Property(e => e.TypeOfAssisDel1).HasColumnName("type_of_assis_del1");
            entity.Property(e => e.TypeOfAssisDel2).HasColumnName("type_of_assis_del2");
            entity.Property(e => e.TypeOfAssisDel3).HasColumnName("type_of_assis_del3");
            entity.Property(e => e.TypeOfAssisDel4).HasColumnName("type_of_assis_del4");
            entity.Property(e => e.TypeOfDelivery1)
                .HasMaxLength(255)
                .HasColumnName("type_of_delivery1");
            entity.Property(e => e.TypeOfDelivery2)
                .HasMaxLength(255)
                .HasColumnName("type_of_delivery2");
            entity.Property(e => e.TypeOfDelivery3)
                .HasMaxLength(255)
                .HasColumnName("type_of_delivery3");
            entity.Property(e => e.TypeOfDelivery4)
                .HasMaxLength(255)
                .HasColumnName("type_of_delivery4");
            entity.Property(e => e.UrineAlb)
                .HasMaxLength(255)
                .HasColumnName("urine_alb");
            entity.Property(e => e.UrineAnalysis).HasColumnName("urine_analysis");
            entity.Property(e => e.UrineCreatinine)
                .HasMaxLength(100)
                .UseCollation("SQL_Latin1_General_CP1_CI_AS")
                .HasColumnName("urine_creatinine");
            entity.Property(e => e.UrineOther)
                .HasMaxLength(100)
                .UseCollation("SQL_Latin1_General_CP1_CI_AS")
                .HasColumnName("urine_other");
            entity.Property(e => e.UrineSugar).HasColumnName("urine_sugar");
            entity.Property(e => e.VaccinationOfBaby1).HasColumnName("vaccination_of_baby1");
            entity.Property(e => e.VaccinationOfBaby2).HasColumnName("vaccination_of_baby2");
            entity.Property(e => e.VaccinationOfBaby3).HasColumnName("vaccination_of_baby3");
            entity.Property(e => e.VaccinationOfBaby4).HasColumnName("vaccination_of_baby4");
            entity.Property(e => e.VdrlRpr)
                .HasMaxLength(255)
                .HasColumnName("vdrl_rpr");
            entity.Property(e => e.VitK1Dose1)
                .HasMaxLength(255)
                .HasColumnName("vit_k1_dose1");
            entity.Property(e => e.VitK1Dose2)
                .HasMaxLength(255)
                .HasColumnName("vit_k1_dose2");
            entity.Property(e => e.VitK1Dose3)
                .HasMaxLength(255)
                .HasColumnName("vit_k1_dose3");
            entity.Property(e => e.VitK1Dose4)
                .HasMaxLength(255)
                .HasColumnName("vit_k1_dose4");
            entity.Property(e => e.Wo)
                .HasMaxLength(50)
                .UseCollation("SQL_Latin1_General_CP1_CI_AS")
                .HasColumnName("wo");
        });

        modelBuilder.Entity<Casepnc>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("casepnc");

            entity.Property(e => e.AsmanCode)
                .HasMaxLength(22)
                .UseCollation("SQL_Latin1_General_CP1_CI_AS")
                .HasColumnName("asman_code");
            entity.Property(e => e.BPncB1)
                .HasMaxLength(255)
                .UseCollation("SQL_Latin1_General_CP1_CI_AS")
                .HasColumnName("B_PNC_B1");
            entity.Property(e => e.BPncB2)
                .HasMaxLength(255)
                .UseCollation("SQL_Latin1_General_CP1_CI_AS")
                .HasColumnName("B_PNC_B2");
            entity.Property(e => e.BPncB3)
                .HasMaxLength(255)
                .UseCollation("SQL_Latin1_General_CP1_CI_AS")
                .HasColumnName("B_PNC_B3");
            entity.Property(e => e.BPncB4)
                .HasMaxLength(255)
                .UseCollation("SQL_Latin1_General_CP1_CI_AS")
                .HasColumnName("B_PNC_B4");
            entity.Property(e => e.BPncB5)
                .HasMaxLength(255)
                .UseCollation("SQL_Latin1_General_CP1_CI_AS")
                .HasColumnName("B_PNC_B5");
            entity.Property(e => e.BPncB6)
                .HasMaxLength(255)
                .UseCollation("SQL_Latin1_General_CP1_CI_AS")
                .HasColumnName("B_PNC_B6");
            entity.Property(e => e.BPncC1)
                .HasMaxLength(255)
                .UseCollation("SQL_Latin1_General_CP1_CI_AS")
                .HasColumnName("B_PNC_C_1");
            entity.Property(e => e.BPncC2)
                .HasMaxLength(255)
                .UseCollation("SQL_Latin1_General_CP1_CI_AS")
                .HasColumnName("B_PNC_C_2");
            entity.Property(e => e.BPncC3)
                .HasMaxLength(255)
                .UseCollation("SQL_Latin1_General_CP1_CI_AS")
                .HasColumnName("B_PNC_C_3");
            entity.Property(e => e.BPncC4)
                .HasMaxLength(255)
                .UseCollation("SQL_Latin1_General_CP1_CI_AS")
                .HasColumnName("B_PNC_C_4");
            entity.Property(e => e.BPncC5)
                .HasMaxLength(255)
                .UseCollation("SQL_Latin1_General_CP1_CI_AS")
                .HasColumnName("B_PNC_C_5");
            entity.Property(e => e.BPncC6)
                .HasMaxLength(255)
                .UseCollation("SQL_Latin1_General_CP1_CI_AS")
                .HasColumnName("B_PNC_C_6");
            entity.Property(e => e.BPncCon1)
                .HasMaxLength(255)
                .UseCollation("SQL_Latin1_General_CP1_CI_AS")
                .HasColumnName("B_PNC_Con_1");
            entity.Property(e => e.BPncCon2)
                .HasMaxLength(255)
                .UseCollation("SQL_Latin1_General_CP1_CI_AS")
                .HasColumnName("B_PNC_Con_2");
            entity.Property(e => e.BPncCon3)
                .HasMaxLength(255)
                .UseCollation("SQL_Latin1_General_CP1_CI_AS")
                .HasColumnName("B_PNC_Con_3");
            entity.Property(e => e.BPncCon4)
                .HasMaxLength(255)
                .UseCollation("SQL_Latin1_General_CP1_CI_AS")
                .HasColumnName("B_PNC_Con_4");
            entity.Property(e => e.BPncCon5)
                .HasMaxLength(255)
                .UseCollation("SQL_Latin1_General_CP1_CI_AS")
                .HasColumnName("B_PNC_Con_5");
            entity.Property(e => e.BPncCon6)
                .HasMaxLength(255)
                .UseCollation("SQL_Latin1_General_CP1_CI_AS")
                .HasColumnName("B_PNC_Con_6");
            entity.Property(e => e.BPncD1)
                .HasMaxLength(255)
                .UseCollation("SQL_Latin1_General_CP1_CI_AS")
                .HasColumnName("B_PNC_D_1");
            entity.Property(e => e.BPncD2)
                .HasMaxLength(255)
                .UseCollation("SQL_Latin1_General_CP1_CI_AS")
                .HasColumnName("B_PNC_D_2");
            entity.Property(e => e.BPncD3)
                .HasMaxLength(255)
                .UseCollation("SQL_Latin1_General_CP1_CI_AS")
                .HasColumnName("B_PNC_D_3");
            entity.Property(e => e.BPncD4)
                .HasMaxLength(255)
                .UseCollation("SQL_Latin1_General_CP1_CI_AS")
                .HasColumnName("B_PNC_D_4");
            entity.Property(e => e.BPncD5)
                .HasMaxLength(255)
                .UseCollation("SQL_Latin1_General_CP1_CI_AS")
                .HasColumnName("B_PNC_D_5");
            entity.Property(e => e.BPncD6)
                .HasMaxLength(255)
                .UseCollation("SQL_Latin1_General_CP1_CI_AS")
                .HasColumnName("B_PNC_D_6");
            entity.Property(e => e.BPncJ1)
                .HasMaxLength(255)
                .UseCollation("SQL_Latin1_General_CP1_CI_AS")
                .HasColumnName("B_PNC_J_1");
            entity.Property(e => e.BPncJ2)
                .HasMaxLength(255)
                .UseCollation("SQL_Latin1_General_CP1_CI_AS")
                .HasColumnName("B_PNC_J_2");
            entity.Property(e => e.BPncJ3)
                .HasMaxLength(255)
                .UseCollation("SQL_Latin1_General_CP1_CI_AS")
                .HasColumnName("B_PNC_J_3");
            entity.Property(e => e.BPncJ4)
                .HasMaxLength(255)
                .UseCollation("SQL_Latin1_General_CP1_CI_AS")
                .HasColumnName("B_PNC_J_4");
            entity.Property(e => e.BPncJ5)
                .HasMaxLength(255)
                .UseCollation("SQL_Latin1_General_CP1_CI_AS")
                .HasColumnName("B_PNC_J_5");
            entity.Property(e => e.BPncJ6)
                .HasMaxLength(255)
                .UseCollation("SQL_Latin1_General_CP1_CI_AS")
                .HasColumnName("B_PNC_J_6");
            entity.Property(e => e.BPncRr1)
                .HasMaxLength(255)
                .UseCollation("SQL_Latin1_General_CP1_CI_AS")
                .HasColumnName("B_PNC_RR1");
            entity.Property(e => e.BPncRr2)
                .HasMaxLength(255)
                .UseCollation("SQL_Latin1_General_CP1_CI_AS")
                .HasColumnName("B_PNC_RR2");
            entity.Property(e => e.BPncRr3)
                .HasMaxLength(255)
                .UseCollation("SQL_Latin1_General_CP1_CI_AS")
                .HasColumnName("B_PNC_RR3");
            entity.Property(e => e.BPncRr4)
                .HasMaxLength(255)
                .UseCollation("SQL_Latin1_General_CP1_CI_AS")
                .HasColumnName("B_PNC_RR4");
            entity.Property(e => e.BPncRr5)
                .HasMaxLength(255)
                .UseCollation("SQL_Latin1_General_CP1_CI_AS")
                .HasColumnName("B_PNC_RR5");
            entity.Property(e => e.BPncRr6)
                .HasMaxLength(255)
                .UseCollation("SQL_Latin1_General_CP1_CI_AS")
                .HasColumnName("B_PNC_RR6");
            entity.Property(e => e.BPncS1)
                .HasMaxLength(255)
                .UseCollation("SQL_Latin1_General_CP1_CI_AS")
                .HasColumnName("B_PNC_S_1");
            entity.Property(e => e.BPncS2)
                .HasMaxLength(255)
                .UseCollation("SQL_Latin1_General_CP1_CI_AS")
                .HasColumnName("B_PNC_S_2");
            entity.Property(e => e.BPncS3)
                .HasMaxLength(255)
                .UseCollation("SQL_Latin1_General_CP1_CI_AS")
                .HasColumnName("B_PNC_S_3");
            entity.Property(e => e.BPncS4)
                .HasMaxLength(255)
                .UseCollation("SQL_Latin1_General_CP1_CI_AS")
                .HasColumnName("B_PNC_S_4");
            entity.Property(e => e.BPncS5)
                .HasMaxLength(255)
                .UseCollation("SQL_Latin1_General_CP1_CI_AS")
                .HasColumnName("B_PNC_S_5");
            entity.Property(e => e.BPncS6)
                .HasMaxLength(255)
                .UseCollation("SQL_Latin1_General_CP1_CI_AS")
                .HasColumnName("B_PNC_S_6");
            entity.Property(e => e.BPncU1)
                .HasMaxLength(255)
                .UseCollation("SQL_Latin1_General_CP1_CI_AS")
                .HasColumnName("B_PNC_U_1");
            entity.Property(e => e.BPncU2)
                .HasMaxLength(255)
                .UseCollation("SQL_Latin1_General_CP1_CI_AS")
                .HasColumnName("B_PNC_U_2");
            entity.Property(e => e.BPncU3)
                .HasMaxLength(255)
                .UseCollation("SQL_Latin1_General_CP1_CI_AS")
                .HasColumnName("B_PNC_U_3");
            entity.Property(e => e.BPncU4)
                .HasMaxLength(255)
                .UseCollation("SQL_Latin1_General_CP1_CI_AS")
                .HasColumnName("B_PNC_U_4");
            entity.Property(e => e.BPncU5)
                .HasMaxLength(255)
                .UseCollation("SQL_Latin1_General_CP1_CI_AS")
                .HasColumnName("B_PNC_U_5");
            entity.Property(e => e.BPncU6)
                .HasMaxLength(255)
                .UseCollation("SQL_Latin1_General_CP1_CI_AS")
                .HasColumnName("B_PNC_U_6");
            entity.Property(e => e.BPncV1)
                .HasMaxLength(255)
                .UseCollation("SQL_Latin1_General_CP1_CI_AS")
                .HasColumnName("B_PNC_V_1");
            entity.Property(e => e.BPncV2)
                .HasMaxLength(255)
                .UseCollation("SQL_Latin1_General_CP1_CI_AS")
                .HasColumnName("B_PNC_V_2");
            entity.Property(e => e.BPncV3)
                .HasMaxLength(255)
                .UseCollation("SQL_Latin1_General_CP1_CI_AS")
                .HasColumnName("B_PNC_V_3");
            entity.Property(e => e.BPncV4)
                .HasMaxLength(255)
                .UseCollation("SQL_Latin1_General_CP1_CI_AS")
                .HasColumnName("B_PNC_V_4");
            entity.Property(e => e.BPncV5)
                .HasMaxLength(255)
                .UseCollation("SQL_Latin1_General_CP1_CI_AS")
                .HasColumnName("B_PNC_V_5");
            entity.Property(e => e.BPncV6)
                .HasMaxLength(255)
                .UseCollation("SQL_Latin1_General_CP1_CI_AS")
                .HasColumnName("B_PNC_V_6");
            entity.Property(e => e.MPncBld1)
                .HasMaxLength(255)
                .UseCollation("SQL_Latin1_General_CP1_CI_AS")
                .HasColumnName("M_PNC_BLD1");
            entity.Property(e => e.MPncBld2)
                .HasMaxLength(255)
                .UseCollation("SQL_Latin1_General_CP1_CI_AS")
                .HasColumnName("M_PNC_BLD2");
            entity.Property(e => e.MPncBld3)
                .HasMaxLength(255)
                .UseCollation("SQL_Latin1_General_CP1_CI_AS")
                .HasColumnName("M_PNC_BLD3");
            entity.Property(e => e.MPncBld4)
                .HasMaxLength(255)
                .UseCollation("SQL_Latin1_General_CP1_CI_AS")
                .HasColumnName("M_PNC_BLD4");
            entity.Property(e => e.MPncBld5)
                .HasMaxLength(255)
                .UseCollation("SQL_Latin1_General_CP1_CI_AS")
                .HasColumnName("M_PNC_BLD5");
            entity.Property(e => e.MPncBld6)
                .HasMaxLength(255)
                .UseCollation("SQL_Latin1_General_CP1_CI_AS")
                .HasColumnName("M_PNC_BLD6");
            entity.Property(e => e.MPncBp1)
                .HasMaxLength(255)
                .UseCollation("SQL_Latin1_General_CP1_CI_AS")
                .HasColumnName("M_PNC_BP1");
            entity.Property(e => e.MPncBp2)
                .HasMaxLength(255)
                .UseCollation("SQL_Latin1_General_CP1_CI_AS")
                .HasColumnName("M_PNC_BP2");
            entity.Property(e => e.MPncBp3)
                .HasMaxLength(255)
                .UseCollation("SQL_Latin1_General_CP1_CI_AS")
                .HasColumnName("M_PNC_BP3");
            entity.Property(e => e.MPncBp4)
                .HasMaxLength(255)
                .UseCollation("SQL_Latin1_General_CP1_CI_AS")
                .HasColumnName("M_PNC_BP4");
            entity.Property(e => e.MPncBp5)
                .HasMaxLength(255)
                .UseCollation("SQL_Latin1_General_CP1_CI_AS")
                .HasColumnName("M_PNC_BP5");
            entity.Property(e => e.MPncBp6)
                .HasMaxLength(255)
                .UseCollation("SQL_Latin1_General_CP1_CI_AS")
                .HasColumnName("M_PNC_BP6");
            entity.Property(e => e.MPncBrP1)
                .HasMaxLength(255)
                .UseCollation("SQL_Latin1_General_CP1_CI_AS")
                .HasColumnName("M_PNC_BR_P1");
            entity.Property(e => e.MPncBrP2)
                .HasMaxLength(255)
                .UseCollation("SQL_Latin1_General_CP1_CI_AS")
                .HasColumnName("M_PNC_BR_P2");
            entity.Property(e => e.MPncBrP3)
                .HasMaxLength(255)
                .UseCollation("SQL_Latin1_General_CP1_CI_AS")
                .HasColumnName("M_PNC_BR_P3");
            entity.Property(e => e.MPncBrP4)
                .HasMaxLength(255)
                .UseCollation("SQL_Latin1_General_CP1_CI_AS")
                .HasColumnName("M_PNC_BR_P4");
            entity.Property(e => e.MPncBrP5)
                .HasMaxLength(255)
                .UseCollation("SQL_Latin1_General_CP1_CI_AS")
                .HasColumnName("M_PNC_BR_P5");
            entity.Property(e => e.MPncBrP6)
                .HasMaxLength(255)
                .UseCollation("SQL_Latin1_General_CP1_CI_AS")
                .HasColumnName("M_PNC_BR_P6");
            entity.Property(e => e.MPncC1)
                .HasMaxLength(255)
                .UseCollation("SQL_Latin1_General_CP1_CI_AS")
                .HasColumnName("M_PNC_C1");
            entity.Property(e => e.MPncC2)
                .HasMaxLength(255)
                .UseCollation("SQL_Latin1_General_CP1_CI_AS")
                .HasColumnName("M_PNC_C2");
            entity.Property(e => e.MPncC3)
                .HasMaxLength(255)
                .UseCollation("SQL_Latin1_General_CP1_CI_AS")
                .HasColumnName("M_PNC_C3");
            entity.Property(e => e.MPncC4)
                .HasMaxLength(255)
                .UseCollation("SQL_Latin1_General_CP1_CI_AS")
                .HasColumnName("M_PNC_C4");
            entity.Property(e => e.MPncC5)
                .HasMaxLength(255)
                .UseCollation("SQL_Latin1_General_CP1_CI_AS")
                .HasColumnName("M_PNC_C5");
            entity.Property(e => e.MPncC6)
                .HasMaxLength(255)
                .UseCollation("SQL_Latin1_General_CP1_CI_AS")
                .HasColumnName("M_PNC_C6");
            entity.Property(e => e.MPncEp1)
                .HasMaxLength(255)
                .UseCollation("SQL_Latin1_General_CP1_CI_AS")
                .HasColumnName("M_PNC_EP1");
            entity.Property(e => e.MPncEp2)
                .HasMaxLength(255)
                .UseCollation("SQL_Latin1_General_CP1_CI_AS")
                .HasColumnName("M_PNC_EP2");
            entity.Property(e => e.MPncEp3)
                .HasMaxLength(255)
                .UseCollation("SQL_Latin1_General_CP1_CI_AS")
                .HasColumnName("M_PNC_EP3");
            entity.Property(e => e.MPncEp4)
                .HasMaxLength(255)
                .UseCollation("SQL_Latin1_General_CP1_CI_AS")
                .HasColumnName("M_PNC_EP4");
            entity.Property(e => e.MPncEp5)
                .HasMaxLength(255)
                .UseCollation("SQL_Latin1_General_CP1_CI_AS")
                .HasColumnName("M_PNC_EP5");
            entity.Property(e => e.MPncEp6)
                .HasMaxLength(255)
                .UseCollation("SQL_Latin1_General_CP1_CI_AS")
                .HasColumnName("M_PNC_EP6");
            entity.Property(e => e.MPncFc1)
                .HasMaxLength(255)
                .UseCollation("SQL_Latin1_General_CP1_CI_AS")
                .HasColumnName("M_PNC_FC_1");
            entity.Property(e => e.MPncFc2)
                .HasMaxLength(255)
                .UseCollation("SQL_Latin1_General_CP1_CI_AS")
                .HasColumnName("M_PNC_FC_2");
            entity.Property(e => e.MPncFc3)
                .HasMaxLength(255)
                .UseCollation("SQL_Latin1_General_CP1_CI_AS")
                .HasColumnName("M_PNC_FC_3");
            entity.Property(e => e.MPncFc4)
                .HasMaxLength(255)
                .UseCollation("SQL_Latin1_General_CP1_CI_AS")
                .HasColumnName("M_PNC_FC_4");
            entity.Property(e => e.MPncFc5)
                .HasMaxLength(255)
                .UseCollation("SQL_Latin1_General_CP1_CI_AS")
                .HasColumnName("M_PNC_FC_5");
            entity.Property(e => e.MPncFc6)
                .HasMaxLength(255)
                .UseCollation("SQL_Latin1_General_CP1_CI_AS")
                .HasColumnName("M_PNC_FC_6");
            entity.Property(e => e.MPncFp)
                .HasMaxLength(255)
                .UseCollation("SQL_Latin1_General_CP1_CI_AS")
                .HasColumnName("M_PNC_FP");
            entity.Property(e => e.MPncFp2)
                .HasMaxLength(255)
                .UseCollation("SQL_Latin1_General_CP1_CI_AS")
                .HasColumnName("M_PNC_FP2");
            entity.Property(e => e.MPncFp3)
                .HasMaxLength(255)
                .UseCollation("SQL_Latin1_General_CP1_CI_AS")
                .HasColumnName("M_PNC_FP3");
            entity.Property(e => e.MPncFp4)
                .HasMaxLength(255)
                .UseCollation("SQL_Latin1_General_CP1_CI_AS")
                .HasColumnName("M_PNC_FP4");
            entity.Property(e => e.MPncFp5)
                .HasMaxLength(255)
                .UseCollation("SQL_Latin1_General_CP1_CI_AS")
                .HasColumnName("M_PNC_FP5");
            entity.Property(e => e.MPncFp6)
                .HasMaxLength(255)
                .UseCollation("SQL_Latin1_General_CP1_CI_AS")
                .HasColumnName("M_PNC_FP6");
            entity.Property(e => e.MPncHb1)
                .HasMaxLength(255)
                .UseCollation("SQL_Latin1_General_CP1_CI_AS")
                .HasColumnName("M_PNC_HB_1");
            entity.Property(e => e.MPncHb2)
                .HasMaxLength(255)
                .UseCollation("SQL_Latin1_General_CP1_CI_AS")
                .HasColumnName("M_PNC_HB_2");
            entity.Property(e => e.MPncHb3)
                .HasMaxLength(255)
                .UseCollation("SQL_Latin1_General_CP1_CI_AS")
                .HasColumnName("M_PNC_HB_3");
            entity.Property(e => e.MPncHb4)
                .HasMaxLength(255)
                .UseCollation("SQL_Latin1_General_CP1_CI_AS")
                .HasColumnName("M_PNC_HB_4");
            entity.Property(e => e.MPncHb5)
                .HasMaxLength(255)
                .UseCollation("SQL_Latin1_General_CP1_CI_AS")
                .HasColumnName("M_PNC_HB_5");
            entity.Property(e => e.MPncHb6)
                .HasMaxLength(255)
                .UseCollation("SQL_Latin1_General_CP1_CI_AS")
                .HasColumnName("M_PNC_HB_6");
            entity.Property(e => e.MPncP1)
                .HasMaxLength(255)
                .UseCollation("SQL_Latin1_General_CP1_CI_AS")
                .HasColumnName("M_PNC_P1");
            entity.Property(e => e.MPncP2)
                .HasMaxLength(255)
                .UseCollation("SQL_Latin1_General_CP1_CI_AS")
                .HasColumnName("M_PNC_P2");
            entity.Property(e => e.MPncP3)
                .HasMaxLength(255)
                .UseCollation("SQL_Latin1_General_CP1_CI_AS")
                .HasColumnName("M_PNC_P3");
            entity.Property(e => e.MPncP4)
                .HasMaxLength(255)
                .UseCollation("SQL_Latin1_General_CP1_CI_AS")
                .HasColumnName("M_PNC_P4");
            entity.Property(e => e.MPncP5)
                .HasMaxLength(255)
                .UseCollation("SQL_Latin1_General_CP1_CI_AS")
                .HasColumnName("M_PNC_P5");
            entity.Property(e => e.MPncP6)
                .HasMaxLength(255)
                .UseCollation("SQL_Latin1_General_CP1_CI_AS")
                .HasColumnName("M_PNC_P6");
            entity.Property(e => e.MPncPa1)
                .HasMaxLength(255)
                .UseCollation("SQL_Latin1_General_CP1_CI_AS")
                .HasColumnName("M_PNC_PA1");
            entity.Property(e => e.MPncPa2)
                .HasMaxLength(255)
                .UseCollation("SQL_Latin1_General_CP1_CI_AS")
                .HasColumnName("M_PNC_PA2");
            entity.Property(e => e.MPncPa3)
                .HasMaxLength(255)
                .UseCollation("SQL_Latin1_General_CP1_CI_AS")
                .HasColumnName("M_PNC_PA3");
            entity.Property(e => e.MPncPa4)
                .HasMaxLength(255)
                .UseCollation("SQL_Latin1_General_CP1_CI_AS")
                .HasColumnName("M_PNC_PA4");
            entity.Property(e => e.MPncPa5)
                .HasMaxLength(255)
                .UseCollation("SQL_Latin1_General_CP1_CI_AS")
                .HasColumnName("M_PNC_PA5");
            entity.Property(e => e.MPncPa6)
                .HasMaxLength(255)
                .UseCollation("SQL_Latin1_General_CP1_CI_AS")
                .HasColumnName("M_PNC_PA6");
            entity.Property(e => e.MPncT1)
                .HasMaxLength(255)
                .UseCollation("SQL_Latin1_General_CP1_CI_AS")
                .HasColumnName("M_PNC_T1");
            entity.Property(e => e.MPncT2)
                .HasMaxLength(255)
                .UseCollation("SQL_Latin1_General_CP1_CI_AS")
                .HasColumnName("M_PNC_T2");
            entity.Property(e => e.MPncT3)
                .HasMaxLength(255)
                .UseCollation("SQL_Latin1_General_CP1_CI_AS")
                .HasColumnName("M_PNC_T3");
            entity.Property(e => e.MPncT4)
                .HasMaxLength(255)
                .UseCollation("SQL_Latin1_General_CP1_CI_AS")
                .HasColumnName("M_PNC_T4");
            entity.Property(e => e.MPncT5)
                .HasMaxLength(255)
                .UseCollation("SQL_Latin1_General_CP1_CI_AS")
                .HasColumnName("M_PNC_T5");
            entity.Property(e => e.MPncT6)
                .HasMaxLength(255)
                .UseCollation("SQL_Latin1_General_CP1_CI_AS")
                .HasColumnName("M_PNC_T6");
            entity.Property(e => e.MPncU1)
                .HasMaxLength(255)
                .UseCollation("SQL_Latin1_General_CP1_CI_AS")
                .HasColumnName("M_PNC_U1");
            entity.Property(e => e.MPncU2)
                .HasMaxLength(255)
                .UseCollation("SQL_Latin1_General_CP1_CI_AS")
                .HasColumnName("M_PNC_U2");
            entity.Property(e => e.MPncU3)
                .HasMaxLength(255)
                .UseCollation("SQL_Latin1_General_CP1_CI_AS")
                .HasColumnName("M_PNC_U3");
            entity.Property(e => e.MPncU4)
                .HasMaxLength(255)
                .UseCollation("SQL_Latin1_General_CP1_CI_AS")
                .HasColumnName("M_PNC_U4");
            entity.Property(e => e.MPncU5)
                .HasMaxLength(255)
                .UseCollation("SQL_Latin1_General_CP1_CI_AS")
                .HasColumnName("M_PNC_U5");
            entity.Property(e => e.MPncU6)
                .HasMaxLength(255)
                .UseCollation("SQL_Latin1_General_CP1_CI_AS")
                .HasColumnName("M_PNC_U6");
        });

        modelBuilder.Entity<Center>(entity =>
        {
            entity.HasKey(e => e.Sno).HasName("PK__centers__DDDF6446EA84A463");

            entity.ToTable("centers");

            entity.Property(e => e.Sno).HasColumnName("sno");
            entity.Property(e => e.Address).HasColumnName("address");
            entity.Property(e => e.Block)
                .HasMaxLength(100)
                .HasColumnName("block");
            entity.Property(e => e.CenterId)
                .HasMaxLength(50)
                .HasColumnName("centerId");
            entity.Property(e => e.CreatedOn)
                .HasMaxLength(50)
                .HasColumnName("createdOn");
            entity.Property(e => e.District)
                .HasMaxLength(100)
                .HasColumnName("district");
            entity.Property(e => e.Name)
                .HasMaxLength(255)
                .HasColumnName("name");
            entity.Property(e => e.Pincode)
                .HasMaxLength(20)
                .HasColumnName("pincode");
            entity.Property(e => e.State)
                .HasMaxLength(100)
                .HasColumnName("state");
        });

        modelBuilder.Entity<Checkup>(entity =>
        {
            entity.HasKey(e => e.Sno).HasName("PK__checkups__DDDF6446504BAE0D");

            entity.ToTable("checkups");

            entity.Property(e => e.Sno).HasColumnName("sno");
            entity.Property(e => e.CheckupDate)
                .HasMaxLength(50)
                .HasColumnName("checkup_date");
            entity.Property(e => e.CheckupId).HasColumnName("checkupId");
            entity.Property(e => e.CreatedOn)
                .HasMaxLength(50)
                .HasColumnName("createdOn");
            entity.Property(e => e.DoctorId).HasColumnName("doctorId");
            entity.Property(e => e.Findings).HasColumnName("findings");
            entity.Property(e => e.PatientId).HasColumnName("patient_id");
            entity.Property(e => e.Recommendations).HasColumnName("recommendations");
        });

        modelBuilder.Entity<Cho>(entity =>
        {
            entity.HasKey(e => e.Choid).HasName("PK_CHOID");

            entity.ToTable("CHO");

            entity.Property(e => e.Choid).HasColumnName("CHOID");
            entity.Property(e => e.BlockId).HasColumnName("BlockID");
            entity.Property(e => e.CadreId).HasColumnName("CadreID");
            entity.Property(e => e.Choname)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("CHOName");
            entity.Property(e => e.CreatedOn).HasColumnType("datetime");
            entity.Property(e => e.DistrictId).HasColumnName("DistrictID");
            entity.Property(e => e.EmailId)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("EmailID");
            entity.Property(e => e.FacilityId).HasColumnName("FacilityID");
            entity.Property(e => e.FacilityTypeId).HasColumnName("FacilityTypeID");
            entity.Property(e => e.GenderId).HasColumnName("GenderID");
            entity.Property(e => e.IsActive).HasDefaultValue(true);
            entity.Property(e => e.IsDeleted).HasDefaultValue(0);
            entity.Property(e => e.MobileNo)
                .HasMaxLength(10)
                .IsUnicode(false);
            entity.Property(e => e.RoleId).HasColumnName("RoleID");
            entity.Property(e => e.StateId).HasColumnName("StateID");
            entity.Property(e => e.SubFacilityId).HasColumnName("SubFacilityID");
            entity.Property(e => e.UpdatedOn).HasColumnType("datetime");
            entity.Property(e => e.Username)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.VillageId).HasColumnName("VillageID");

            entity.HasOne(d => d.Block).WithMany(p => p.Chos)
                .HasForeignKey(d => d.BlockId)
                .HasConstraintName("FK_CHO_LocationBlock");

            entity.HasOne(d => d.District).WithMany(p => p.Chos)
                .HasForeignKey(d => d.DistrictId)
                .HasConstraintName("FK_CHO_LocationDistrict");

            entity.HasOne(d => d.Facility).WithMany(p => p.Chos)
                .HasForeignKey(d => d.FacilityId)
                .HasConstraintName("FK_CHO_LocationFacility");

            entity.HasOne(d => d.FacilityType).WithMany(p => p.Chos)
                .HasForeignKey(d => d.FacilityTypeId)
                .HasConstraintName("FK_CHO_LocationFacilityType");

            entity.HasOne(d => d.Gender).WithMany(p => p.Chos)
                .HasForeignKey(d => d.GenderId)
                .HasConstraintName("FK_CHO_Gender");

            entity.HasOne(d => d.Role).WithMany(p => p.Chos)
                .HasForeignKey(d => d.RoleId)
                .HasConstraintName("FK_CHO_Role");

            entity.HasOne(d => d.State).WithMany(p => p.Chos)
                .HasForeignKey(d => d.StateId)
                .HasConstraintName("FK_CHO_LocationState");

            entity.HasOne(d => d.SubFacility).WithMany(p => p.Chos)
                .HasForeignKey(d => d.SubFacilityId)
                .HasConstraintName("FK_CHO_LocationSubFacility");
        });

        modelBuilder.Entity<ChoMapped>(entity =>
        {
            entity.HasKey(e => e.ChomappingId);

            entity.ToTable("CHO_Mapped");

            entity.Property(e => e.ChomappingId).HasColumnName("CHOMappingID");
            entity.Property(e => e.Choid).HasColumnName("CHOID");
            entity.Property(e => e.CreatedOn).HasColumnType("datetime");
            entity.Property(e => e.FacilityId).HasColumnName("FacilityID");
            entity.Property(e => e.IsActive).HasDefaultValue(true);
            entity.Property(e => e.IsDeleted).HasDefaultValue(0);
            entity.Property(e => e.SubFacilityId).HasColumnName("SubFacilityID");
            entity.Property(e => e.UpdatedOn).HasColumnType("datetime");
            entity.Property(e => e.VillageId).HasColumnName("VillageID");

            entity.HasOne(d => d.Cho).WithMany(p => p.ChoMappeds)
                .HasForeignKey(d => d.Choid)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_CHO_Mapped_CHO");

            entity.HasOne(d => d.Facility).WithMany(p => p.ChoMappeds)
                .HasForeignKey(d => d.FacilityId)
                .HasConstraintName("FK_CHO_Mapped_LocationFacility");

            entity.HasOne(d => d.SubFacility).WithMany(p => p.ChoMappeds)
                .HasForeignKey(d => d.SubFacilityId)
                .HasConstraintName("FK_CHO_Mapped_LocationSubFacility");

            entity.HasOne(d => d.Village).WithMany(p => p.ChoMappeds)
                .HasForeignKey(d => d.VillageId)
                .HasConstraintName("FK_CHO_Mapped_LocationVillage");
        });

        modelBuilder.Entity<Claim>(entity =>
        {
            entity.HasKey(e => e.Sno).HasName("PK__claims__DDDF64461FCFF23A");

            entity.ToTable("claims");

            entity.Property(e => e.Sno).HasColumnName("sno");
            entity.Property(e => e.Amount)
                .HasMaxLength(50)
                .HasColumnName("amount");
            entity.Property(e => e.ClaimDate)
                .HasMaxLength(50)
                .HasColumnName("claim_date");
            entity.Property(e => e.ClaimId).HasColumnName("claimId");
            entity.Property(e => e.CreatedOn)
                .HasMaxLength(50)
                .HasColumnName("createdOn");
            entity.Property(e => e.InsuranceId).HasColumnName("insuranceId");
            entity.Property(e => e.PatientId).HasColumnName("patient_id");
            entity.Property(e => e.Remarks).HasColumnName("remarks");
            entity.Property(e => e.Status)
                .HasMaxLength(50)
                .HasColumnName("status");
        });

        modelBuilder.Entity<CmpAskFor>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("cmp_ask_for");

            entity.Property(e => e.CharLimit)
                .HasMaxLength(10)
                .HasColumnName("char_limit");
            entity.Property(e => e.Code)
                .HasMaxLength(20)
                .HasColumnName("code");
            entity.Property(e => e.FieldType)
                .HasMaxLength(20)
                .HasColumnName("field_type");
            entity.Property(e => e.InputType)
                .HasMaxLength(20)
                .HasColumnName("input_type");
            entity.Property(e => e.Mandatory).HasColumnName("mandatory");
            entity.Property(e => e.MaxValue)
                .HasMaxLength(10)
                .HasColumnName("max_value");
            entity.Property(e => e.MinValue)
                .HasMaxLength(10)
                .HasColumnName("min_value");
            entity.Property(e => e.QuestionEn)
                .HasMaxLength(255)
                .HasColumnName("question_en");
            entity.Property(e => e.QuestionHi)
                .HasMaxLength(255)
                .HasColumnName("question_hi");
            entity.Property(e => e.Sno)
                .ValueGeneratedOnAdd()
                .HasColumnName("sno");
            entity.Property(e => e.Symptoms)
                .HasMaxLength(255)
                .HasColumnName("symptoms");
        });

        modelBuilder.Entity<CmpAskForAnswer>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__cmp_ask___3214EC072899EBAE");

            entity.ToTable("cmp_ask_for_Answers");

            entity.Property(e => e.Answer).HasMaxLength(255);
            entity.Property(e => e.CmpAskForResultId).HasColumnName("cmp_ask_for_resultId");
        });

        modelBuilder.Entity<CmpAskForResult>(entity =>
        {
            entity.HasKey(e => e.Sno).HasName("PK__cmp_ask___DDDF6446B32DA713");

            entity.ToTable("cmp_ask_for_result");

            entity.Property(e => e.Sno).HasColumnName("sno");
            entity.Property(e => e.Answer).HasColumnName("answer");
            entity.Property(e => e.Data).HasColumnName("data");
            entity.Property(e => e.MobileId).HasColumnName("mobile_id");
            entity.Property(e => e.PatientGuid).HasColumnName("PatientGUID");
            entity.Property(e => e.PatientId).HasColumnName("patient_id");
            entity.Property(e => e.QId).HasColumnName("q_id");
            entity.Property(e => e.VisitDate).HasColumnName("visit_date");
            entity.Property(e => e.VisitNo).HasColumnName("visit_no");
        });

        modelBuilder.Entity<CmpExamination>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("cmp_examinations");

            entity.Property(e => e.CharLimit)
                .HasMaxLength(10)
                .HasColumnName("char_limit");
            entity.Property(e => e.Code)
                .HasMaxLength(20)
                .HasColumnName("code");
            entity.Property(e => e.DefaultValue)
                .HasMaxLength(255)
                .HasColumnName("default_value");
            entity.Property(e => e.ExaminationEn)
                .HasMaxLength(255)
                .HasColumnName("examination_en");
            entity.Property(e => e.ExaminationHi)
                .HasMaxLength(255)
                .HasColumnName("examination_hi");
            entity.Property(e => e.FieldType)
                .HasMaxLength(20)
                .HasColumnName("field_type");
            entity.Property(e => e.InputType)
                .HasMaxLength(20)
                .HasColumnName("input_type");
            entity.Property(e => e.Mandatory).HasColumnName("mandatory");
            entity.Property(e => e.MaxValue)
                .HasMaxLength(10)
                .HasColumnName("max_value");
            entity.Property(e => e.MinValue)
                .HasMaxLength(10)
                .HasColumnName("min_value");
            entity.Property(e => e.Sno)
                .ValueGeneratedOnAdd()
                .HasColumnName("sno");
            entity.Property(e => e.Symptoms)
                .HasMaxLength(255)
                .HasColumnName("symptoms");
        });

        modelBuilder.Entity<CmpExaminationResult>(entity =>
        {
            entity.HasKey(e => e.Sno).HasName("PK__cmp_exam__DDDF64469A4C5499");

            entity.ToTable("cmp_examination_result");

            entity.Property(e => e.Sno).HasColumnName("sno");
            entity.Property(e => e.Answer).HasColumnName("answer");
            entity.Property(e => e.Data).HasColumnName("data");
            entity.Property(e => e.MobileId).HasColumnName("mobile_id");
            entity.Property(e => e.PatientGuid).HasColumnName("PatientGUID");
            entity.Property(e => e.PatientId).HasColumnName("patient_id");
            entity.Property(e => e.QId).HasColumnName("q_id");
            entity.Property(e => e.VisitDate).HasColumnName("visit_date");
            entity.Property(e => e.VisitNo).HasColumnName("visit_no");
        });

        modelBuilder.Entity<CmpPastHistory>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("cmp_past_history");

            entity.Property(e => e.CharLimit)
                .HasMaxLength(10)
                .HasColumnName("char_limit");
            entity.Property(e => e.Code)
                .HasMaxLength(20)
                .HasColumnName("code");
            entity.Property(e => e.FieldType)
                .HasMaxLength(20)
                .HasColumnName("field_type");
            entity.Property(e => e.HistoryEn)
                .HasMaxLength(255)
                .HasColumnName("history_en");
            entity.Property(e => e.HistoryHi)
                .HasMaxLength(255)
                .HasColumnName("history_hi");
            entity.Property(e => e.InputType)
                .HasMaxLength(20)
                .HasColumnName("input_type");
            entity.Property(e => e.Mandatory).HasColumnName("mandatory");
            entity.Property(e => e.MaxValue)
                .HasMaxLength(10)
                .HasColumnName("max_value");
            entity.Property(e => e.MinValue)
                .HasMaxLength(10)
                .HasColumnName("min_value");
            entity.Property(e => e.Sno)
                .ValueGeneratedOnAdd()
                .HasColumnName("sno");
            entity.Property(e => e.Symptoms)
                .HasMaxLength(255)
                .HasColumnName("symptoms");
        });

        modelBuilder.Entity<CmpPastHistoryResult>(entity =>
        {
            entity.HasKey(e => e.Sno).HasName("PK__cmp_past__DDDF64465D177A95");

            entity.ToTable("cmp_past_history_result");

            entity.Property(e => e.Sno).HasColumnName("sno");
            entity.Property(e => e.Answer).HasColumnName("answer");
            entity.Property(e => e.Data).HasColumnName("data");
            entity.Property(e => e.MobileId).HasColumnName("mobile_id");
            entity.Property(e => e.PatientGuid).HasColumnName("PatientGUID");
            entity.Property(e => e.PatientId).HasColumnName("patient_id");
            entity.Property(e => e.QId).HasColumnName("q_id");
            entity.Property(e => e.VisitDate).HasColumnName("visit_date");
            entity.Property(e => e.VisitNo).HasColumnName("visit_no");
        });

        modelBuilder.Entity<CmpPatientVisit>(entity =>
        {
            entity.HasKey(e => e.PatientVisitId).HasName("PK__cmp_pati__D7B1D91F6378E17A");

            entity.ToTable("cmp_patient_visit");

            entity.Property(e => e.PatientVisitId).HasColumnName("patientVisitID");
            entity.Property(e => e.AbdominalpainDay)
                .HasDefaultValue(0)
                .HasColumnName("abdominalpain_day");
            entity.Property(e => e.AgeInDays).HasColumnName("age_in_days");
            entity.Property(e => e.AgeInMonths).HasColumnName("age_in_months");
            entity.Property(e => e.AgeInWeeks).HasColumnName("age_in_weeks");
            entity.Property(e => e.AgeInYears).HasColumnName("age_in_years");
            entity.Property(e => e.BackpainDay)
                .HasDefaultValue(0)
                .HasColumnName("backpain_day");
            entity.Property(e => e.ConstipationDay)
                .HasDefaultValue(0)
                .HasColumnName("constipation_day");
            entity.Property(e => e.CoughDay)
                .HasDefaultValue(0)
                .HasColumnName("cough_day");
            entity.Property(e => e.CreatedAt).HasColumnName("createdAt");
            entity.Property(e => e.CreatedBy).HasColumnName("createdBy");
            entity.Property(e => e.CurrentStatus)
                .HasDefaultValue(0)
                .HasColumnName("current_status");
            entity.Property(e => e.DangerSign).HasColumnName("dangerSign");
            entity.Property(e => e.DeathDate)
                .HasColumnType("datetime")
                .HasColumnName("death_date");
            entity.Property(e => e.DiarrheaDay)
                .HasDefaultValue(0)
                .HasColumnName("diarrhea_day");
            entity.Property(e => e.DischargeDate)
                .HasColumnType("datetime")
                .HasColumnName("discharge_date");
            entity.Property(e => e.FeverDay)
                .HasDefaultValue(0)
                .HasColumnName("fever_day");
            entity.Property(e => e.FollowUpDate)
                .HasColumnType("datetime")
                .HasColumnName("followUpDate");
            entity.Property(e => e.HeadacheDay)
                .HasDefaultValue(0)
                .HasColumnName("headache_day");
            entity.Property(e => e.JointpainDay)
                .HasDefaultValue(0)
                .HasColumnName("jointpain_day");
            entity.Property(e => e.MobileId).HasColumnName("mobile_id");
            entity.Property(e => e.OtherSymptom).HasColumnName("otherSymptom");
            entity.Property(e => e.PatientGuid).HasColumnName("PatientGUID");
            entity.Property(e => e.PatientId).HasColumnName("patient_id");
            entity.Property(e => e.Referred).HasColumnName("referred");
            entity.Property(e => e.ReferredLocation).HasColumnName("referred_location");
            entity.Property(e => e.RespiratoryDay)
                .HasDefaultValue(0)
                .HasColumnName("respiratory_day");
            entity.Property(e => e.SkinlesionDay)
                .HasDefaultValue(0)
                .HasColumnName("skinlesion_day");
            entity.Property(e => e.SummaryKey)
                .IsUnicode(false)
                .HasColumnName("summary_key");
            entity.Property(e => e.Symptoms).HasColumnName("symptoms");
            entity.Property(e => e.TimeStamp).HasColumnName("timeStamp");
            entity.Property(e => e.VisitDate)
                .HasColumnType("datetime")
                .HasColumnName("visit_date");
            entity.Property(e => e.VisitNo).HasColumnName("visit_no");
        });

        modelBuilder.Entity<CmpSubSymptom>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("cmp_sub_symptoms");

            entity.Property(e => e.CharLimit)
                .HasMaxLength(10)
                .HasColumnName("char_limit");
            entity.Property(e => e.FieldType)
                .HasMaxLength(20)
                .HasColumnName("field_type");
            entity.Property(e => e.FieldsEn)
                .HasMaxLength(255)
                .HasColumnName("fields_en");
            entity.Property(e => e.FieldsHi)
                .HasMaxLength(255)
                .HasColumnName("fields_hi");
            entity.Property(e => e.InputType)
                .HasMaxLength(20)
                .HasColumnName("input_type");
            entity.Property(e => e.Mandatory).HasColumnName("mandatory");
            entity.Property(e => e.MaxValue)
                .HasMaxLength(10)
                .HasColumnName("max_value");
            entity.Property(e => e.MinValue)
                .HasMaxLength(10)
                .HasColumnName("min_value");
            entity.Property(e => e.ParentCode)
                .HasMaxLength(20)
                .HasColumnName("parent_code");
            entity.Property(e => e.Sno)
                .ValueGeneratedOnAdd()
                .HasColumnName("sno");
        });

        modelBuilder.Entity<CmpSymptom>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("cmp_symptoms");

            entity.Property(e => e.Code)
                .HasMaxLength(255)
                .HasColumnName("code");
            entity.Property(e => e.Sno)
                .HasMaxLength(255)
                .HasColumnName("sno");
            entity.Property(e => e.SymptomEn)
                .HasMaxLength(255)
                .HasColumnName("symptom_en");
            entity.Property(e => e.SymptomHi)
                .HasMaxLength(255)
                .HasColumnName("symptom_hi");
            entity.Property(e => e.SymptomsId).HasMaxLength(255);
        });

        modelBuilder.Entity<CommonSymptomsWeb>(entity =>
        {
            entity.HasKey(e => e.SymptomsId).HasName("PK__CommonSy__D26F2A86F1CEBD8B");

            entity.ToTable("CommonSymptomsWeb");

            entity.Property(e => e.CreatedOn).HasColumnType("datetime");
            entity.Property(e => e.SymptomsName)
                .HasMaxLength(100)
                .IsUnicode(false);
        });

        modelBuilder.Entity<Complication>(entity =>
        {
            entity.HasKey(e => e.Sno).HasName("PK__complica__DDDF644642C8BFEF");

            entity.ToTable("complications");

            entity.Property(e => e.Sno).HasColumnName("sno");
            entity.Property(e => e.ComplicationId).HasColumnName("complicationId");
            entity.Property(e => e.Description).HasColumnName("description");
            entity.Property(e => e.PatientId).HasColumnName("patient_id");
            entity.Property(e => e.RecordedOn)
                .HasMaxLength(50)
                .HasColumnName("recordedOn");
            entity.Property(e => e.Severity)
                .HasMaxLength(50)
                .HasColumnName("severity");
        });

        modelBuilder.Entity<CoughTest>(entity =>
        {
            entity.HasKey(e => e.Sno).HasName("PK__cough_te__DDDF6446DA6484F9");

            entity.ToTable("cough_test");

            entity.Property(e => e.Sno).HasColumnName("sno");
            entity.Property(e => e.BreathAMin).HasColumnName("breath_a_min");
            entity.Property(e => e.ChestIndrawing).HasColumnName("chest_indrawing");
            entity.Property(e => e.CoughDuration).HasColumnName("cough_duration");
            entity.Property(e => e.MobileId).HasColumnName("mobile_id");
            entity.Property(e => e.OxygenSatuaration)
                .HasMaxLength(20)
                .HasColumnName("oxygen_satuaration");
            entity.Property(e => e.PatientGuid).HasColumnName("PatientGUID");
            entity.Property(e => e.PatientId).HasColumnName("patient_id");
            entity.Property(e => e.TimeStamp).HasColumnName("timeStamp");
            entity.Property(e => e.VisitNo).HasColumnName("visit_no");
        });

        modelBuilder.Entity<Counseling>(entity =>
        {
            entity.HasKey(e => e.Sno).HasName("PK__counseli__DDDF64465E1E27AE");

            entity.ToTable("counseling");

            entity.Property(e => e.Sno).HasColumnName("sno");
            entity.Property(e => e.CounselingId).HasColumnName("counselingId");
            entity.Property(e => e.Counselor)
                .HasMaxLength(255)
                .HasColumnName("counselor");
            entity.Property(e => e.CreatedOn)
                .HasMaxLength(50)
                .HasColumnName("createdOn");
            entity.Property(e => e.Date)
                .HasMaxLength(50)
                .HasColumnName("date");
            entity.Property(e => e.Notes).HasColumnName("notes");
            entity.Property(e => e.PatientId).HasColumnName("patient_id");
            entity.Property(e => e.Type)
                .HasMaxLength(100)
                .HasColumnName("type");
        });

        modelBuilder.Entity<DataImport>(entity =>
        {
            entity.HasKey(e => e.ImportId);

            entity.ToTable("DataImport");

            entity.Property(e => e.ImportId).HasColumnName("ImportID");
            entity.Property(e => e.Apiname).HasColumnName("APIName");
            entity.Property(e => e.BenGuid)
                .IsUnicode(false)
                .HasColumnName("BenGUID");
            entity.Property(e => e.CreatedOn).HasColumnType("datetime");
            entity.Property(e => e.UserId).HasColumnName("UserID");
        });

        modelBuilder.Entity<DataImportError>(entity =>
        {
            entity.HasKey(e => e.ImportErrorId);

            entity.ToTable("DataImportError");

            entity.Property(e => e.ImportErrorId).HasColumnName("ImportErrorID");
            entity.Property(e => e.AdmissionGuid).HasColumnName("AdmissionGUID");
            entity.Property(e => e.Ancguid).HasColumnName("ANCGUID");
            entity.Property(e => e.Apiname).HasColumnName("APIName");
            entity.Property(e => e.BenGuid).HasColumnName("BenGUID");
            entity.Property(e => e.ChildImmunizationGuid).HasColumnName("ChildImmunizationGUID");
            entity.Property(e => e.ChildPncguid).HasColumnName("ChildPNCGUID");
            entity.Property(e => e.ChildRegisGuid).HasColumnName("ChildRegisGUID");
            entity.Property(e => e.DelOutGuid).HasColumnName("DelOutGUID");
            entity.Property(e => e.DeliveryNoteGuid).HasColumnName("DeliveryNoteGUID");
            entity.Property(e => e.DischargeNoteGuid).HasColumnName("DischargeNoteGUID");
            entity.Property(e => e.EccategoryGuid).HasColumnName("ECCategoryGUID");
            entity.Property(e => e.ErrorDate).HasColumnType("datetime");
            entity.Property(e => e.HomeVisitGuid).HasColumnName("HomeVisitGUID");
            entity.Property(e => e.ImportId).HasColumnName("ImportID");
            entity.Property(e => e.IntrapartumGuid).HasColumnName("IntrapartumGUID");
            entity.Property(e => e.LamaDeathFormGuid).HasColumnName("LamaDeathFormGUID");
            entity.Property(e => e.PartographyGuid).HasColumnName("PartographyGUID");
            entity.Property(e => e.Pncguid).HasColumnName("PNCGUID");
            entity.Property(e => e.PostpartumSummeryGuid).HasColumnName("PostpartumSummeryGUID");
            entity.Property(e => e.PrescribeDrugGuid).HasColumnName("PrescribeDrugGUID");
            entity.Property(e => e.PwcategoryGuid).HasColumnName("PWCategoryGUID");
            entity.Property(e => e.RefGuid).HasColumnName("RefGUID");
            entity.Property(e => e.ReferralGuid).HasColumnName("ReferralGUID");
            entity.Property(e => e.StausDesc).HasMaxLength(50);
            entity.Property(e => e.Vhndguid).HasColumnName("VHNDGUID");
            entity.Property(e => e.VitialInfoGuid).HasColumnName("VitialInfoGUID");
        });

        modelBuilder.Entity<DataItem>(entity =>
        {
            entity.ToTable("DataItem");

            entity.Property(e => e.DataitemId).HasColumnName("DataitemID");
            entity.Property(e => e.DataItem1)
                .HasMaxLength(500)
                .IsUnicode(false)
                .HasColumnName("DataItem");
            entity.Property(e => e.DataItemCategoryId).HasColumnName("DataItemCategoryID");
            entity.Property(e => e.DataItemCode).HasMaxLength(50);
        });

        modelBuilder.Entity<DataItemDvalue>(entity =>
        {
            entity.HasKey(e => e.DataItemValueId);

            entity.ToTable("DataItemDValue");

            entity.Property(e => e.DataItemValueId).HasColumnName("DataItemValueID");
            entity.Property(e => e.BlockId).HasColumnName("BlockID");
            entity.Property(e => e.DataitemId).HasColumnName("DataitemID");
            entity.Property(e => e.DistrictId).HasColumnName("DistrictID");
            entity.Property(e => e.Dvalue).HasColumnName("DValue");
            entity.Property(e => e.StateId).HasColumnName("StateID");
        });

        modelBuilder.Entity<Department>(entity =>
        {
            entity.HasKey(e => e.Sno).HasName("PK__departme__DDDF6446E395698E");

            entity.ToTable("departments");

            entity.Property(e => e.Sno).HasColumnName("sno");
            entity.Property(e => e.CreatedOn)
                .HasMaxLength(50)
                .HasColumnName("createdOn");
            entity.Property(e => e.DepartmentId).HasColumnName("departmentId");
            entity.Property(e => e.Description).HasColumnName("description");
            entity.Property(e => e.Name)
                .HasMaxLength(255)
                .HasColumnName("name");
        });

        modelBuilder.Entity<DiarrheaTest>(entity =>
        {
            entity.HasKey(e => e.Sno).HasName("PK__diarrhea__DDDF6446FEDDB63F");

            entity.ToTable("diarrhea_test");

            entity.Property(e => e.Sno).HasColumnName("sno");
            entity.Property(e => e.BloodInStool).HasColumnName("blood_in_stool");
            entity.Property(e => e.DrinkEagerly).HasColumnName("drink_eagerly");
            entity.Property(e => e.DurationDiarrhea).HasColumnName("duration_diarrhea");
            entity.Property(e => e.MobileId).HasColumnName("mobile_id");
            entity.Property(e => e.PatientGuid).HasColumnName("PatientGUID");
            entity.Property(e => e.PatientId).HasColumnName("patient_id");
            entity.Property(e => e.Restless).HasColumnName("restless");
            entity.Property(e => e.SkinPinchSlow).HasColumnName("skin_pinch_slow");
            entity.Property(e => e.SkinPinchVerySlow).HasColumnName("skin_pinch_very_slow");
            entity.Property(e => e.SunkenEyes).HasColumnName("sunken_eyes");
            entity.Property(e => e.TimeStamp).HasColumnName("timeStamp");
            entity.Property(e => e.UnableToDrink).HasColumnName("unable_to_drink");
            entity.Property(e => e.Unconsious).HasColumnName("unconsious");
            entity.Property(e => e.VisitNo).HasColumnName("visit_no");
        });

        modelBuilder.Entity<Discharge>(entity =>
        {
            entity.HasKey(e => e.Sno).HasName("PK__discharg__DDDF6446F3AEB1ED");

            entity.ToTable("discharges");

            entity.Property(e => e.Sno).HasColumnName("sno");
            entity.Property(e => e.AdmissionId).HasColumnName("admissionId");
            entity.Property(e => e.Condition)
                .HasMaxLength(255)
                .HasColumnName("condition");
            entity.Property(e => e.CreatedOn)
                .HasMaxLength(50)
                .HasColumnName("createdOn");
            entity.Property(e => e.DischargeDate)
                .HasMaxLength(50)
                .HasColumnName("discharge_date");
            entity.Property(e => e.DischargeId).HasColumnName("dischargeId");
            entity.Property(e => e.PatientId).HasColumnName("patient_id");
            entity.Property(e => e.Summary).HasColumnName("summary");
        });

        modelBuilder.Entity<Distribution>(entity =>
        {
            entity.HasKey(e => e.Sno).HasName("PK__distribu__DDDF644688D91FC8");

            entity.ToTable("distribution");

            entity.Property(e => e.Sno).HasColumnName("sno");
            entity.Property(e => e.CreatedOn)
                .HasMaxLength(50)
                .HasColumnName("createdOn");
            entity.Property(e => e.Date)
                .HasMaxLength(50)
                .HasColumnName("date");
            entity.Property(e => e.DistributedTo)
                .HasMaxLength(255)
                .HasColumnName("distributed_to");
            entity.Property(e => e.DistributionId).HasColumnName("distributionId");
            entity.Property(e => e.ItemName)
                .HasMaxLength(255)
                .HasColumnName("item_name");
            entity.Property(e => e.Quantity).HasColumnName("quantity");
            entity.Property(e => e.Remarks).HasColumnName("remarks");
        });

        modelBuilder.Entity<Doctor>(entity =>
        {
            entity.HasKey(e => e.Sno).HasName("PK__doctors__DDDF6446B74DC4C3");

            entity.ToTable("doctors");

            entity.Property(e => e.Sno).HasColumnName("sno");
            entity.Property(e => e.CenterId)
                .HasMaxLength(50)
                .HasColumnName("centerId");
            entity.Property(e => e.CreatedOn)
                .HasMaxLength(50)
                .HasColumnName("createdOn");
            entity.Property(e => e.DoctorId).HasColumnName("doctorId");
            entity.Property(e => e.Email)
                .HasMaxLength(255)
                .HasColumnName("email");
            entity.Property(e => e.Mobile)
                .HasMaxLength(20)
                .HasColumnName("mobile");
            entity.Property(e => e.Name)
                .HasMaxLength(255)
                .HasColumnName("name");
            entity.Property(e => e.Specialization)
                .HasMaxLength(255)
                .HasColumnName("specialization");
        });

        modelBuilder.Entity<Drug>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("Drugs");

            entity.Property(e => e.DrugId).HasColumnName("DrugID");
            entity.Property(e => e.DrugName).HasMaxLength(255);
            entity.Property(e => e.DrugTypeName).HasMaxLength(255);
            entity.Property(e => e.Id).HasColumnName("ID");
        });

        modelBuilder.Entity<EmergencyVisit>(entity =>
        {
            entity.HasKey(e => e.Sno).HasName("PK__emergenc__DDDF6446ADF164C4");

            entity.ToTable("emergency_visits");

            entity.Property(e => e.Sno).HasColumnName("sno");
            entity.Property(e => e.CreatedOn)
                .HasMaxLength(50)
                .HasColumnName("createdOn");
            entity.Property(e => e.EmergencyId).HasColumnName("emergencyId");
            entity.Property(e => e.Outcome)
                .HasMaxLength(255)
                .HasColumnName("outcome");
            entity.Property(e => e.PatientId).HasColumnName("patient_id");
            entity.Property(e => e.Reason).HasColumnName("reason");
            entity.Property(e => e.VisitDate)
                .HasMaxLength(50)
                .HasColumnName("visit_date");
        });

        modelBuilder.Entity<Examination>(entity =>
        {
            entity.HasKey(e => e.Sno).HasName("PK__examinat__DDDF64461BCEB61D");

            entity.ToTable("examinations");

            entity.Property(e => e.Sno).HasColumnName("sno");
            entity.Property(e => e.CharLimit)
                .HasMaxLength(10)
                .HasColumnName("char_limit");
            entity.Property(e => e.Code)
                .HasMaxLength(20)
                .HasColumnName("code");
            entity.Property(e => e.DefaultValue)
                .HasMaxLength(255)
                .HasColumnName("default_value");
            entity.Property(e => e.ExaminationEn)
                .HasMaxLength(255)
                .HasColumnName("examination_en");
            entity.Property(e => e.ExaminationHi)
                .HasMaxLength(255)
                .HasColumnName("examination_hi");
            entity.Property(e => e.FieldType)
                .HasMaxLength(20)
                .HasColumnName("field_type");
            entity.Property(e => e.InputType)
                .HasMaxLength(20)
                .HasColumnName("input_type");
            entity.Property(e => e.Mandatory).HasColumnName("mandatory");
            entity.Property(e => e.MaxValue)
                .HasMaxLength(10)
                .HasColumnName("max_value");
            entity.Property(e => e.MinValue)
                .HasMaxLength(10)
                .HasColumnName("min_value");
            entity.Property(e => e.Symptoms)
                .HasMaxLength(255)
                .HasColumnName("symptoms");
        });

        modelBuilder.Entity<Expense>(entity =>
        {
            entity.HasKey(e => e.Sno).HasName("PK__expenses__DDDF6446EF8E1E46");

            entity.ToTable("expenses");

            entity.Property(e => e.Sno).HasColumnName("sno");
            entity.Property(e => e.Amount)
                .HasMaxLength(50)
                .HasColumnName("amount");
            entity.Property(e => e.Category)
                .HasMaxLength(255)
                .HasColumnName("category");
            entity.Property(e => e.CreatedOn)
                .HasMaxLength(50)
                .HasColumnName("createdOn");
            entity.Property(e => e.Date)
                .HasMaxLength(50)
                .HasColumnName("date");
            entity.Property(e => e.ExpenseId).HasColumnName("expenseId");
            entity.Property(e => e.PatientId).HasColumnName("patient_id");
            entity.Property(e => e.Remarks).HasColumnName("remarks");
        });

        modelBuilder.Entity<FamilyHistory>(entity =>
        {
            entity.HasKey(e => e.Sno).HasName("PK__family_h__DDDF6446173D24C8");

            entity.ToTable("family_history");

            entity.Property(e => e.Sno).HasColumnName("sno");
            entity.Property(e => e.AgeOfOnset)
                .HasMaxLength(50)
                .HasColumnName("age_of_onset");
            entity.Property(e => e.Condition)
                .HasMaxLength(255)
                .HasColumnName("condition");
            entity.Property(e => e.FamilyHistoryId).HasColumnName("familyHistoryId");
            entity.Property(e => e.PatientId).HasColumnName("patient_id");
            entity.Property(e => e.RecordedOn)
                .HasMaxLength(50)
                .HasColumnName("recordedOn");
            entity.Property(e => e.Relation)
                .HasMaxLength(100)
                .HasColumnName("relation");
            entity.Property(e => e.Remarks).HasColumnName("remarks");
        });

        modelBuilder.Entity<FeedingAssessment>(entity =>
        {
            entity.HasKey(e => e.Sno).HasName("PK__feeding___DDDF64468D1AA93A");

            entity.ToTable("feeding_assessment");

            entity.Property(e => e.Sno).HasColumnName("sno");
            entity.Property(e => e.AttachmentToBreastNoGood).HasColumnName("attachment_to_breast_no_good");
            entity.Property(e => e.BreastNippleProblem).HasColumnName("breast_nipple_problem");
            entity.Property(e => e.BreastfeedCountDay).HasColumnName("breastfeed_count_day");
            entity.Property(e => e.MobileId).HasColumnName("mobile_id");
            entity.Property(e => e.NotSuckingEffectively).HasColumnName("not_sucking_effectively");
            entity.Property(e => e.PatientId).HasColumnName("patient_id");
            entity.Property(e => e.ReceivedOtherFood).HasColumnName("received_other_food");
            entity.Property(e => e.TimeStamp)
                .HasColumnType("datetime")
                .HasColumnName("timeStamp");
            entity.Property(e => e.UlcerWhitePatch).HasColumnName("ulcer_white_patch");
            entity.Property(e => e.VisitNo).HasColumnName("visit_no");
        });

        modelBuilder.Entity<FeverTest>(entity =>
        {
            entity.HasKey(e => e.Sno).HasName("PK__fever_te__DDDF6446E1A6FC94");

            entity.ToTable("fever_test");

            entity.Property(e => e.Sno).HasColumnName("sno");
            entity.Property(e => e.MalariaRdt).HasColumnName("malaria_rdt");
            entity.Property(e => e.MalariaTestDone).HasColumnName("malaria_test_done");
            entity.Property(e => e.MobileId).HasColumnName("mobile_id");
            entity.Property(e => e.PatientGuid).HasColumnName("PatientGUID");
            entity.Property(e => e.PatientId).HasColumnName("patient_id");
            entity.Property(e => e.StiffNeck).HasColumnName("stiff_neck");
            entity.Property(e => e.Temperature).HasColumnName("temperature");
            entity.Property(e => e.TimeStamp).HasColumnName("timeStamp");
            entity.Property(e => e.VisitNo).HasColumnName("visit_no");
        });

        modelBuilder.Entity<Flag>(entity =>
        {
            entity.HasKey(e => e.FlagId).HasName("PK_FlagMaster");

            entity.ToTable("Flag");

            entity.Property(e => e.FlagId).HasColumnName("FlagID");
            entity.Property(e => e.CreatedOn).HasColumnType("datetime");
            entity.Property(e => e.Description)
                .HasMaxLength(1000)
                .IsUnicode(false);
            entity.Property(e => e.Name)
                .HasMaxLength(120)
                .IsUnicode(false);
            entity.Property(e => e.UpdatedOn).HasColumnType("datetime");
        });

        modelBuilder.Entity<FlagValue>(entity =>
        {
            entity.HasKey(e => e.ValueId);

            entity.Property(e => e.ValueId).HasColumnName("ValueID");
            entity.Property(e => e.CreatedOn).HasColumnType("datetime");
            entity.Property(e => e.FlagId).HasColumnName("FlagID");
            entity.Property(e => e.UpdatedOn).HasColumnType("datetime");
        });

        modelBuilder.Entity<FlagValueMl>(entity =>
        {
            entity.ToTable("FlagValueML");

            entity.Property(e => e.FlagValueMlid).HasColumnName("FlagValueMLID");
            entity.Property(e => e.CreatedOn).HasColumnType("datetime");
            entity.Property(e => e.FlagId).HasColumnName("FlagID");
            entity.Property(e => e.FlagValueId).HasColumnName("FlagValueID");
            entity.Property(e => e.LangId).HasColumnName("LangID");
            entity.Property(e => e.PrasavFlagId).HasColumnName("PrasavFlagID");
            entity.Property(e => e.UpdatedOn).HasColumnType("datetime");
        });

        modelBuilder.Entity<Followup>(entity =>
        {
            entity.HasKey(e => e.Sno).HasName("PK__followup__DDDF64466E2E75B2");

            entity.ToTable("followups");

            entity.Property(e => e.Sno).HasColumnName("sno");
            entity.Property(e => e.CreatedOn)
                .HasMaxLength(50)
                .HasColumnName("createdOn");
            entity.Property(e => e.DoctorId).HasColumnName("doctorId");
            entity.Property(e => e.FollowupDate)
                .HasMaxLength(50)
                .HasColumnName("followup_date");
            entity.Property(e => e.FollowupId).HasColumnName("followupId");
            entity.Property(e => e.PatientId).HasColumnName("patient_id");
            entity.Property(e => e.Purpose)
                .HasMaxLength(255)
                .HasColumnName("purpose");
            entity.Property(e => e.Remarks).HasColumnName("remarks");
        });

        modelBuilder.Entity<Gender>(entity =>
        {
            entity.ToTable("Gender");

            entity.Property(e => e.GenderId).HasColumnName("GenderID");
            entity.Property(e => e.CreatedOn).HasColumnType("datetime");
            entity.Property(e => e.Gender1)
                .HasMaxLength(12)
                .IsUnicode(false)
                .HasColumnName("Gender");
            entity.Property(e => e.UpdatedOn).HasColumnType("datetime");
        });

        modelBuilder.Entity<GenderMl>(entity =>
        {
            entity.HasKey(e => new { e.GenderId, e.LangId });

            entity.ToTable("GenderML");

            entity.Property(e => e.GenderId).HasColumnName("GenderID");
            entity.Property(e => e.LangId).HasColumnName("LangID");
            entity.Property(e => e.Gender).HasMaxLength(50);
        });

        modelBuilder.Entity<GeneticDisorder>(entity =>
        {
            entity.HasKey(e => e.Sno).HasName("PK__genetic___DDDF6446B3EA1FBF");

            entity.ToTable("genetic_disorders");

            entity.Property(e => e.Sno).HasColumnName("sno");
            entity.Property(e => e.Disorder)
                .HasMaxLength(255)
                .HasColumnName("disorder");
            entity.Property(e => e.GeneticDisorderId).HasColumnName("geneticDisorderId");
            entity.Property(e => e.InheritedFrom)
                .HasMaxLength(255)
                .HasColumnName("inherited_from");
            entity.Property(e => e.PatientId).HasColumnName("patient_id");
            entity.Property(e => e.RecordedOn)
                .HasMaxLength(50)
                .HasColumnName("recordedOn");
            entity.Property(e => e.Remarks).HasColumnName("remarks");
        });

        modelBuilder.Entity<Grievance>(entity =>
        {
            entity.HasKey(e => e.Sno).HasName("PK__grievanc__DDDF644694ABBF18");

            entity.ToTable("grievances");

            entity.Property(e => e.Sno).HasColumnName("sno");
            entity.Property(e => e.CreatedOn)
                .HasMaxLength(50)
                .HasColumnName("createdOn");
            entity.Property(e => e.Date)
                .HasMaxLength(50)
                .HasColumnName("date");
            entity.Property(e => e.Description).HasColumnName("description");
            entity.Property(e => e.GrievanceId).HasColumnName("grievanceId");
            entity.Property(e => e.Resolution).HasColumnName("resolution");
            entity.Property(e => e.StaffId).HasColumnName("staffId");
            entity.Property(e => e.Status)
                .HasMaxLength(50)
                .HasColumnName("status");
        });

        modelBuilder.Entity<Habit>(entity =>
        {
            entity.HasKey(e => e.Sno).HasName("PK__habits__DDDF64463C441B5D");

            entity.ToTable("habits");

            entity.Property(e => e.Sno).HasColumnName("sno");
            entity.Property(e => e.Duration)
                .HasMaxLength(100)
                .HasColumnName("duration");
            entity.Property(e => e.Frequency)
                .HasMaxLength(100)
                .HasColumnName("frequency");
            entity.Property(e => e.Habit1)
                .HasMaxLength(100)
                .HasColumnName("habit");
            entity.Property(e => e.HabitId).HasColumnName("habitId");
            entity.Property(e => e.PatientId).HasColumnName("patient_id");
            entity.Property(e => e.RecordedOn)
                .HasMaxLength(50)
                .HasColumnName("recordedOn");
            entity.Property(e => e.Remarks).HasColumnName("remarks");
        });

        modelBuilder.Entity<HealthCamp>(entity =>
        {
            entity.HasKey(e => e.Sno).HasName("PK__health_c__DDDF6446D4E6CB30");

            entity.ToTable("health_camps");

            entity.Property(e => e.Sno).HasColumnName("sno");
            entity.Property(e => e.CampId).HasColumnName("campId");
            entity.Property(e => e.CampName)
                .HasMaxLength(255)
                .HasColumnName("camp_name");
            entity.Property(e => e.CreatedOn)
                .HasMaxLength(50)
                .HasColumnName("createdOn");
            entity.Property(e => e.Date)
                .HasMaxLength(50)
                .HasColumnName("date");
            entity.Property(e => e.PatientId).HasColumnName("patient_id");
            entity.Property(e => e.Remarks).HasColumnName("remarks");
            entity.Property(e => e.Services).HasColumnName("services");
        });

        modelBuilder.Entity<Immunization>(entity =>
        {
            entity.HasKey(e => e.Sno).HasName("PK__immuniza__DDDF6446E671B93B");

            entity.ToTable("immunization");

            entity.Property(e => e.Sno).HasColumnName("sno");
            entity.Property(e => e.IsCompleted).HasColumnName("isCompleted");
            entity.Property(e => e.IsVerified).HasColumnName("isVerified");
            entity.Property(e => e.MobileId).HasColumnName("mobile_id");
            entity.Property(e => e.PatientGuid).HasColumnName("PatientGUID");
            entity.Property(e => e.PatientId).HasColumnName("patient_id");
            entity.Property(e => e.SelectedVaccines).HasColumnName("selectedVaccines");
            entity.Property(e => e.TimeStamp).HasColumnName("timeStamp");
            entity.Property(e => e.VisitNo).HasColumnName("visit_no");
        });

        modelBuilder.Entity<Immunization1>(entity =>
        {
            entity.HasKey(e => e.Sno).HasName("PK__immuniza__DDDF6446E07D1A80");

            entity.ToTable("immunizations");

            entity.Property(e => e.Sno).HasColumnName("sno");
            entity.Property(e => e.CreatedOn)
                .HasMaxLength(50)
                .HasColumnName("createdOn");
            entity.Property(e => e.Date)
                .HasMaxLength(50)
                .HasColumnName("date");
            entity.Property(e => e.Dose)
                .HasMaxLength(50)
                .HasColumnName("dose");
            entity.Property(e => e.ImmunizationId).HasColumnName("immunizationId");
            entity.Property(e => e.PatientId).HasColumnName("patient_id");
            entity.Property(e => e.Remarks).HasColumnName("remarks");
            entity.Property(e => e.Vaccine)
                .HasMaxLength(255)
                .HasColumnName("vaccine");
        });

        modelBuilder.Entity<InfantDiarrheaTest>(entity =>
        {
            entity.HasKey(e => e.Sno).HasName("PK__infant_d__DDDF644622CF4CEC");

            entity.ToTable("infant_diarrhea_test");

            entity.Property(e => e.Sno).HasColumnName("sno");
            entity.Property(e => e.MobileId).HasColumnName("mobile_id");
            entity.Property(e => e.NoMovement).HasColumnName("no_movement");
            entity.Property(e => e.PatientId).HasColumnName("patient_id");
            entity.Property(e => e.Restless).HasColumnName("restless");
            entity.Property(e => e.SkinPinchSlow).HasColumnName("skin_pinch_slow");
            entity.Property(e => e.SkinPinchVerySlow).HasColumnName("skin_pinch_very_slow");
            entity.Property(e => e.SunkenEyes).HasColumnName("sunken_eyes");
            entity.Property(e => e.TimeStamp)
                .HasColumnType("datetime")
                .HasColumnName("timeStamp");
            entity.Property(e => e.VisitNo).HasColumnName("visit_no");
        });

        modelBuilder.Entity<InfantJaundiceTest>(entity =>
        {
            entity.HasKey(e => e.Sno).HasName("PK__infant_j__DDDF64462DA45764");

            entity.ToTable("infant_jaundice_test");

            entity.Property(e => e.Sno).HasColumnName("sno");
            entity.Property(e => e.JaudiceAge)
                .HasMaxLength(50)
                .HasColumnName("jaudice_age");
            entity.Property(e => e.MobileId).HasColumnName("mobile_id");
            entity.Property(e => e.PatientId).HasColumnName("patient_id");
            entity.Property(e => e.TimeStamp)
                .HasColumnType("datetime")
                .HasColumnName("timeStamp");
            entity.Property(e => e.VisitNo).HasColumnName("visit_no");
            entity.Property(e => e.YellowPalmSole).HasColumnName("yellow_palm_sole");
        });

        modelBuilder.Entity<Insurance>(entity =>
        {
            entity.HasKey(e => e.Sno).HasName("PK__insuranc__DDDF64466819A71E");

            entity.ToTable("insurance");

            entity.Property(e => e.Sno).HasColumnName("sno");
            entity.Property(e => e.CoverageDetails).HasColumnName("coverage_details");
            entity.Property(e => e.CreatedOn)
                .HasMaxLength(50)
                .HasColumnName("createdOn");
            entity.Property(e => e.EndDate)
                .HasMaxLength(50)
                .HasColumnName("end_date");
            entity.Property(e => e.InsuranceId).HasColumnName("insuranceId");
            entity.Property(e => e.PatientId).HasColumnName("patient_id");
            entity.Property(e => e.PolicyNumber)
                .HasMaxLength(100)
                .HasColumnName("policy_number");
            entity.Property(e => e.Provider)
                .HasMaxLength(255)
                .HasColumnName("provider");
            entity.Property(e => e.StartDate)
                .HasMaxLength(50)
                .HasColumnName("start_date");
        });

        modelBuilder.Entity<Inventory>(entity =>
        {
            entity.HasKey(e => e.Sno).HasName("PK__inventor__DDDF6446EB0E4353");

            entity.ToTable("inventory");

            entity.Property(e => e.Sno).HasColumnName("sno");
            entity.Property(e => e.Category)
                .HasMaxLength(255)
                .HasColumnName("category");
            entity.Property(e => e.CreatedOn)
                .HasMaxLength(50)
                .HasColumnName("createdOn");
            entity.Property(e => e.ExpiryDate)
                .HasMaxLength(50)
                .HasColumnName("expiry_date");
            entity.Property(e => e.InventoryId).HasColumnName("inventoryId");
            entity.Property(e => e.ItemName)
                .HasMaxLength(255)
                .HasColumnName("item_name");
            entity.Property(e => e.Quantity).HasColumnName("quantity");
            entity.Property(e => e.Unit)
                .HasMaxLength(50)
                .HasColumnName("unit");
        });

        modelBuilder.Entity<LabResult>(entity =>
        {
            entity.HasKey(e => e.Sno).HasName("PK__lab_resu__DDDF6446CF4E9153");

            entity.ToTable("lab_results");

            entity.Property(e => e.Sno).HasColumnName("sno");
            entity.Property(e => e.PatientId).HasColumnName("patient_id");
            entity.Property(e => e.RecordedOn)
                .HasMaxLength(50)
                .HasColumnName("recordedOn");
            entity.Property(e => e.ReferenceRange)
                .HasMaxLength(100)
                .HasColumnName("reference_range");
            entity.Property(e => e.Result).HasColumnName("result");
            entity.Property(e => e.ResultId).HasColumnName("resultId");
            entity.Property(e => e.TestId).HasColumnName("testId");
            entity.Property(e => e.Unit)
                .HasMaxLength(50)
                .HasColumnName("unit");
        });

        modelBuilder.Entity<LabTest>(entity =>
        {
            entity.HasKey(e => e.Sno).HasName("PK__lab_test__DDDF644666DC1B67");

            entity.ToTable("lab_tests");

            entity.Property(e => e.Sno).HasColumnName("sno");
            entity.Property(e => e.Code)
                .HasMaxLength(100)
                .HasColumnName("code");
            entity.Property(e => e.Description).HasColumnName("description");
            entity.Property(e => e.NormalRange)
                .HasMaxLength(255)
                .HasColumnName("normal_range");
            entity.Property(e => e.TestId).HasColumnName("testId");
            entity.Property(e => e.TestName)
                .HasMaxLength(255)
                .HasColumnName("test_name");
            entity.Property(e => e.Unit)
                .HasMaxLength(50)
                .HasColumnName("unit");
        });

        modelBuilder.Entity<Language>(entity =>
        {
            entity.HasKey(e => e.LangId);

            entity.ToTable("Language");

            entity.Property(e => e.LangId).HasColumnName("LangID");
            entity.Property(e => e.CreatedOn).HasColumnType("datetime");
            entity.Property(e => e.Lang)
                .HasMaxLength(9)
                .IsUnicode(false);
            entity.Property(e => e.UpdatedOn).HasColumnType("datetime");
        });

        modelBuilder.Entity<Leaf>(entity =>
        {
            entity.HasKey(e => e.Sno).HasName("PK__leaves__DDDF6446FCF9F6DC");

            entity.ToTable("leaves");

            entity.Property(e => e.Sno).HasColumnName("sno");
            entity.Property(e => e.CreatedOn)
                .HasMaxLength(50)
                .HasColumnName("createdOn");
            entity.Property(e => e.EndDate)
                .HasMaxLength(50)
                .HasColumnName("end_date");
            entity.Property(e => e.LeaveId).HasColumnName("leaveId");
            entity.Property(e => e.Remarks).HasColumnName("remarks");
            entity.Property(e => e.StaffId).HasColumnName("staffId");
            entity.Property(e => e.StartDate)
                .HasMaxLength(50)
                .HasColumnName("start_date");
            entity.Property(e => e.Status)
                .HasMaxLength(50)
                .HasColumnName("status");
            entity.Property(e => e.Type)
                .HasMaxLength(50)
                .HasColumnName("type");
        });

        modelBuilder.Entity<Lifestyle>(entity =>
        {
            entity.HasKey(e => e.Sno).HasName("PK__lifestyl__DDDF64462AF553C9");

            entity.ToTable("lifestyle");

            entity.Property(e => e.Sno).HasColumnName("sno");
            entity.Property(e => e.Alcohol)
                .HasMaxLength(50)
                .HasColumnName("alcohol");
            entity.Property(e => e.Diet)
                .HasMaxLength(255)
                .HasColumnName("diet");
            entity.Property(e => e.Exercise)
                .HasMaxLength(255)
                .HasColumnName("exercise");
            entity.Property(e => e.LifestyleId).HasColumnName("lifestyleId");
            entity.Property(e => e.PatientId).HasColumnName("patient_id");
            entity.Property(e => e.RecordedOn)
                .HasMaxLength(50)
                .HasColumnName("recordedOn");
            entity.Property(e => e.Sleep)
                .HasMaxLength(50)
                .HasColumnName("sleep");
            entity.Property(e => e.Smoking)
                .HasMaxLength(50)
                .HasColumnName("smoking");
        });

        modelBuilder.Entity<LocationBlock>(entity =>
        {
            entity.HasKey(e => e.BlockId).HasName("PK_MSTBlock");

            entity.ToTable("LocationBlock");

            entity.Property(e => e.BlockId).HasColumnName("BlockID");
            entity.Property(e => e.BlockName).HasMaxLength(255);
            entity.Property(e => e.BlockPcode).HasColumnName("BlockPCode");
            entity.Property(e => e.CreatedBy).HasDefaultValue(1);
            entity.Property(e => e.CreatedOn)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.DistrictId).HasColumnName("DistrictID");
            entity.Property(e => e.IsDeleted).HasDefaultValue(0);
            entity.Property(e => e.MddsCode).HasColumnName("MDDS_Code");
            entity.Property(e => e.StateId).HasColumnName("StateID");
            entity.Property(e => e.TalukaId)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("TalukaID");
            entity.Property(e => e.UpdatedOn).HasColumnType("datetime");

            entity.HasOne(d => d.District).WithMany(p => p.LocationBlocks)
                .HasForeignKey(d => d.DistrictId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_LocationBlock_LocationDistrict");

            entity.HasOne(d => d.State).WithMany(p => p.LocationBlocks)
                .HasForeignKey(d => d.StateId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_LocationBlock_LocationState");
        });

        modelBuilder.Entity<LocationBlockMl>(entity =>
        {
            entity.HasKey(e => new { e.BlockMlid, e.BlockId, e.LangId });

            entity.ToTable("LocationBlockML");

            entity.Property(e => e.BlockMlid)
                .ValueGeneratedOnAdd()
                .HasColumnName("BlockMLID");
            entity.Property(e => e.BlockId).HasColumnName("BlockID");
            entity.Property(e => e.LangId).HasColumnName("LangID");
            entity.Property(e => e.BlockName).HasMaxLength(255);

            entity.HasOne(d => d.Block).WithMany(p => p.LocationBlockMls)
                .HasForeignKey(d => d.BlockId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_LocationBlockML_LocationBlock");
        });

        modelBuilder.Entity<LocationDistrict>(entity =>
        {
            entity.HasKey(e => e.DistrictId).HasName("PK_MSTDistrict");

            entity.ToTable("LocationDistrict");

            entity.Property(e => e.DistrictId).HasColumnName("DistrictID");
            entity.Property(e => e.CreatedBy).HasDefaultValue(1);
            entity.Property(e => e.CreatedOn)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.District).HasMaxLength(250);
            entity.Property(e => e.DistrictPcode).HasColumnName("DistrictPCode");
            entity.Property(e => e.DistrictShortName)
                .HasMaxLength(5)
                .IsUnicode(false);
            entity.Property(e => e.Gisid)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("GISid");
            entity.Property(e => e.IsDeleted).HasDefaultValue(0);
            entity.Property(e => e.MddsCode).HasColumnName("MDDS_Code");
            entity.Property(e => e.StateId).HasColumnName("StateID");
            entity.Property(e => e.UpdatedOn).HasColumnType("datetime");

            entity.HasOne(d => d.State).WithMany(p => p.LocationDistricts)
                .HasForeignKey(d => d.StateId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_LocationDistrict_LocationState");
        });

        modelBuilder.Entity<LocationDistrictMl>(entity =>
        {
            entity.HasKey(e => new { e.DistrictMlid, e.DistrictId, e.LangId });

            entity.ToTable("LocationDistrictML");

            entity.Property(e => e.DistrictMlid)
                .ValueGeneratedOnAdd()
                .HasColumnName("DistrictMLID");
            entity.Property(e => e.DistrictId).HasColumnName("DistrictID");
            entity.Property(e => e.LangId).HasColumnName("LangID");
            entity.Property(e => e.District).HasMaxLength(50);

            entity.HasOne(d => d.DistrictNavigation).WithMany(p => p.LocationDistrictMls)
                .HasForeignKey(d => d.DistrictId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_LocationDistrictML_LocationDistrict");
        });

        modelBuilder.Entity<LocationFacility>(entity =>
        {
            entity.HasKey(e => e.FacilityId);

            entity.ToTable("LocationFacility");

            entity.Property(e => e.FacilityId).HasColumnName("FacilityID");
            entity.Property(e => e.BlockId).HasColumnName("BlockID");
            entity.Property(e => e.CreatedOn).HasColumnType("datetime");
            entity.Property(e => e.DistrictId).HasColumnName("DistrictID");
            entity.Property(e => e.FacilityAddress)
                .HasMaxLength(250)
                .IsUnicode(false);
            entity.Property(e => e.FacilityCode)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.FacilityContactNo)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.FacilityName)
                .HasMaxLength(150)
                .IsUnicode(false);
            entity.Property(e => e.FacilityPcode).HasColumnName("FacilityPCode");
            entity.Property(e => e.FacilityTypeId).HasColumnName("FacilityTypeID");
            entity.Property(e => e.StateId).HasColumnName("StateID");
            entity.Property(e => e.TalukaId)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("TalukaID");
            entity.Property(e => e.UpdatedOn).HasColumnType("datetime");

            entity.HasOne(d => d.Block).WithMany(p => p.LocationFacilities)
                .HasForeignKey(d => d.BlockId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_LocationFacility_LocationBlock");

            entity.HasOne(d => d.District).WithMany(p => p.LocationFacilities)
                .HasForeignKey(d => d.DistrictId)
                .HasConstraintName("FK_LocationFacility_LocationDistrict");

            entity.HasOne(d => d.FacilityType).WithMany(p => p.LocationFacilities)
                .HasForeignKey(d => d.FacilityTypeId)
                .HasConstraintName("FK_LocationFacility_LocationFacilityType");

            entity.HasOne(d => d.State).WithMany(p => p.LocationFacilities)
                .HasForeignKey(d => d.StateId)
                .HasConstraintName("FK_LocationFacility_LocationState");
        });

        modelBuilder.Entity<LocationFacility10dec25>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("LocationFacility_10Dec25");

            entity.Property(e => e.BlockId).HasColumnName("BlockID");
            entity.Property(e => e.CreatedOn).HasColumnType("datetime");
            entity.Property(e => e.DistrictId).HasColumnName("DistrictID");
            entity.Property(e => e.FacilityAddress)
                .HasMaxLength(250)
                .IsUnicode(false);
            entity.Property(e => e.FacilityCode)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.FacilityContactNo)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.FacilityId)
                .ValueGeneratedOnAdd()
                .HasColumnName("FacilityID");
            entity.Property(e => e.FacilityName)
                .HasMaxLength(150)
                .IsUnicode(false);
            entity.Property(e => e.FacilityPcode).HasColumnName("FacilityPCode");
            entity.Property(e => e.FacilityTypeId).HasColumnName("FacilityTypeID");
            entity.Property(e => e.StateId).HasColumnName("StateID");
            entity.Property(e => e.TalukaId)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("TalukaID");
            entity.Property(e => e.UpdatedOn).HasColumnType("datetime");
        });

        modelBuilder.Entity<LocationFacilityMl>(entity =>
        {
            entity.HasKey(e => new { e.FacilityMlid, e.FacilityId, e.LangId });

            entity.ToTable("LocationFacilityML");

            entity.Property(e => e.FacilityMlid)
                .ValueGeneratedOnAdd()
                .HasColumnName("FacilityMLID");
            entity.Property(e => e.FacilityId).HasColumnName("FacilityID");
            entity.Property(e => e.LangId).HasColumnName("LangID");
            entity.Property(e => e.FacilityAddress).HasMaxLength(250);
            entity.Property(e => e.FacilityContactNo).HasMaxLength(50);
            entity.Property(e => e.FacilityName).HasMaxLength(150);

            entity.HasOne(d => d.Facility).WithMany(p => p.LocationFacilityMls)
                .HasForeignKey(d => d.FacilityId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_LocationFacilityML_LocationFacility");
        });

        modelBuilder.Entity<LocationFacilityType>(entity =>
        {
            entity.HasKey(e => e.FacilityTypeId);

            entity.ToTable("LocationFacilityType");

            entity.Property(e => e.FacilityTypeId).HasColumnName("FacilityTypeID");
            entity.Property(e => e.CreatedOn).HasColumnType("datetime");
            entity.Property(e => e.FacilityType)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.FacilityTypeCode)
                .HasMaxLength(10)
                .IsUnicode(false);
            entity.Property(e => e.UpdatedOn).HasColumnType("datetime");
        });

        modelBuilder.Entity<LocationFacilityTypeMl>(entity =>
        {
            entity.HasKey(e => new { e.FacilityTypeMlid, e.FacilityTypeId, e.LangId });

            entity.ToTable("LocationFacilityTypeML");

            entity.Property(e => e.FacilityTypeMlid)
                .ValueGeneratedOnAdd()
                .HasColumnName("FacilityTypeMLID");
            entity.Property(e => e.FacilityTypeId).HasColumnName("FacilityTypeID");
            entity.Property(e => e.LangId).HasColumnName("LangID");
            entity.Property(e => e.FacilityType).HasMaxLength(100);

            entity.HasOne(d => d.FacilityTypeNavigation).WithMany(p => p.LocationFacilityTypeMls)
                .HasForeignKey(d => d.FacilityTypeId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_LocationFacilityTypeML_LocationFacilityType");
        });

        modelBuilder.Entity<LocationGp>(entity =>
        {
            entity.HasKey(e => e.GpId).HasName("PK_MSTGP");

            entity.ToTable("LocationGP");

            entity.Property(e => e.GpId).HasColumnName("GpID");
            entity.Property(e => e.BlockId).HasColumnName("BlockID");
            entity.Property(e => e.CreatedBy).HasDefaultValue(1);
            entity.Property(e => e.CreatedOn)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.DistrictId).HasColumnName("DistrictID");
            entity.Property(e => e.GpName)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.Gpcode).HasColumnName("GPCode");
            entity.Property(e => e.StateId).HasColumnName("StateID");
            entity.Property(e => e.UpdatedOn).HasColumnType("datetime");
        });

        modelBuilder.Entity<LocationGpml>(entity =>
        {
            entity.HasKey(e => new { e.LangId, e.GpId });

            entity.ToTable("LocationGPML");

            entity.Property(e => e.LangId).HasColumnName("LangID");
            entity.Property(e => e.GpId).HasColumnName("GpID");
            entity.Property(e => e.GpName).HasMaxLength(100);
        });

        modelBuilder.Entity<LocationState>(entity =>
        {
            entity.HasKey(e => e.StateId);

            entity.ToTable("LocationState");

            entity.Property(e => e.StateId).HasColumnName("StateID");
            entity.Property(e => e.CreatedBy).HasDefaultValue(1);
            entity.Property(e => e.CreatedOn)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.Gisid)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("GISid");
            entity.Property(e => e.StateName).HasMaxLength(250);
            entity.Property(e => e.StateShortName)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.UpdatedOn).HasColumnType("datetime");
        });

        modelBuilder.Entity<LocationStateMl>(entity =>
        {
            entity.HasKey(e => new { e.StateMlid, e.StateId, e.LangId });

            entity.ToTable("LocationStateML");

            entity.Property(e => e.StateMlid)
                .ValueGeneratedOnAdd()
                .HasColumnName("StateMLID");
            entity.Property(e => e.StateId).HasColumnName("StateID");
            entity.Property(e => e.LangId).HasColumnName("LangID");
            entity.Property(e => e.StateName).HasMaxLength(250);

            entity.HasOne(d => d.State).WithMany(p => p.LocationStateMls)
                .HasForeignKey(d => d.StateId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_LocationStateML_LocationState");
        });

        modelBuilder.Entity<LocationSubFacility>(entity =>
        {
            entity.HasKey(e => e.SubFacilityId);

            entity.ToTable("LocationSubFacility");

            entity.Property(e => e.SubFacilityId).HasColumnName("SubFacilityID");
            entity.Property(e => e.BlockId).HasColumnName("BlockID");
            entity.Property(e => e.CreatedOn).HasColumnType("datetime");
            entity.Property(e => e.DistrictId).HasColumnName("DistrictID");
            entity.Property(e => e.FacilityId).HasColumnName("FacilityID");
            entity.Property(e => e.FacilityTypeId).HasColumnName("FacilityTypeID");
            entity.Property(e => e.StateId).HasColumnName("StateID");
            entity.Property(e => e.SubFacility).HasMaxLength(250);
            entity.Property(e => e.SubFacilityCode)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.SubFacilityPcode).HasColumnName("SubFacilityPCode");
            entity.Property(e => e.TalukaId)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("TalukaID");
            entity.Property(e => e.UpdatedOn).HasColumnType("datetime");

            entity.HasOne(d => d.Block).WithMany(p => p.LocationSubFacilities)
                .HasForeignKey(d => d.BlockId)
                .HasConstraintName("FK_LocationSubFacility_LocationBlock");

            entity.HasOne(d => d.District).WithMany(p => p.LocationSubFacilities)
                .HasForeignKey(d => d.DistrictId)
                .HasConstraintName("FK_LocationSubFacility_LocationDistrict");

            entity.HasOne(d => d.Facility).WithMany(p => p.LocationSubFacilities)
                .HasForeignKey(d => d.FacilityId)
                .HasConstraintName("FK_LocationSubFacility_LocationFacility");

            entity.HasOne(d => d.FacilityType).WithMany(p => p.LocationSubFacilities)
                .HasForeignKey(d => d.FacilityTypeId)
                .HasConstraintName("FK_LocationSubFacility_LocationFacilityType");

            entity.HasOne(d => d.State).WithMany(p => p.LocationSubFacilities)
                .HasForeignKey(d => d.StateId)
                .HasConstraintName("FK_LocationSubFacility_LocationState");
        });

        modelBuilder.Entity<LocationSubFacility10dec25>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("LocationSubFacility_10Dec25");

            entity.Property(e => e.BlockId).HasColumnName("BlockID");
            entity.Property(e => e.CreatedOn).HasColumnType("datetime");
            entity.Property(e => e.DistrictId).HasColumnName("DistrictID");
            entity.Property(e => e.FacilityId).HasColumnName("FacilityID");
            entity.Property(e => e.FacilityTypeId).HasColumnName("FacilityTypeID");
            entity.Property(e => e.StateId).HasColumnName("StateID");
            entity.Property(e => e.SubFacility).HasMaxLength(250);
            entity.Property(e => e.SubFacilityCode)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.SubFacilityId)
                .ValueGeneratedOnAdd()
                .HasColumnName("SubFacilityID");
            entity.Property(e => e.SubFacilityPcode).HasColumnName("SubFacilityPCode");
            entity.Property(e => e.TalukaId)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("TalukaID");
            entity.Property(e => e.UpdatedOn).HasColumnType("datetime");
        });

        modelBuilder.Entity<LocationSubFacilityMl>(entity =>
        {
            entity.HasKey(e => new { e.SubFacilityMlid, e.SubFacilityId, e.LangId });

            entity.ToTable("LocationSubFacilityML");

            entity.Property(e => e.SubFacilityMlid)
                .ValueGeneratedOnAdd()
                .HasColumnName("SubFacilityMLID");
            entity.Property(e => e.SubFacilityId).HasColumnName("SubFacilityID");
            entity.Property(e => e.LangId).HasColumnName("LangID");
            entity.Property(e => e.BlockId).HasColumnName("BlockID");
            entity.Property(e => e.CreatedOn).HasColumnType("datetime");
            entity.Property(e => e.DistrictId).HasColumnName("DistrictID");
            entity.Property(e => e.FacilityId).HasColumnName("FacilityID");
            entity.Property(e => e.FacilityTypeId).HasColumnName("FacilityTypeID");
            entity.Property(e => e.StateId).HasColumnName("StateID");
            entity.Property(e => e.SubFacility).HasMaxLength(250);
            entity.Property(e => e.UpdatedOn).HasColumnType("datetime");

            entity.HasOne(d => d.SubFacilityNavigation).WithMany(p => p.LocationSubFacilityMls)
                .HasForeignKey(d => d.SubFacilityId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_LocationSubFacilityML_LocationSubFacility");
        });

        modelBuilder.Entity<LocationVillage>(entity =>
        {
            entity.HasKey(e => e.VillageId);

            entity.ToTable("LocationVillage");

            entity.Property(e => e.VillageId).HasColumnName("VillageID");
            entity.Property(e => e.BlockId).HasColumnName("BlockID");
            entity.Property(e => e.CreatedOn).HasColumnType("datetime");
            entity.Property(e => e.DistrictId).HasColumnName("DistrictID");
            entity.Property(e => e.FacilityId).HasColumnName("FacilityID");
            entity.Property(e => e.FacilityTypeId).HasColumnName("FacilityTypeID");
            entity.Property(e => e.Gpid).HasColumnName("GPID");
            entity.Property(e => e.IsDeleted).HasDefaultValue(0);
            entity.Property(e => e.StateId).HasColumnName("StateID");
            entity.Property(e => e.SubFacilityId).HasColumnName("SubFacilityID");
            entity.Property(e => e.TalukaId)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("TalukaID");
            entity.Property(e => e.UpdatedOn).HasColumnType("datetime");
            entity.Property(e => e.Village)
                .HasMaxLength(150)
                .IsUnicode(false);
            entity.Property(e => e.VillagePcode).HasColumnName("VillagePCode");

            entity.HasOne(d => d.Block).WithMany(p => p.LocationVillages)
                .HasForeignKey(d => d.BlockId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_LocationVillage_LocationBlock");

            entity.HasOne(d => d.District).WithMany(p => p.LocationVillages)
                .HasForeignKey(d => d.DistrictId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_LocationVillage_LocationDistrict");

            entity.HasOne(d => d.Facility).WithMany(p => p.LocationVillages)
                .HasForeignKey(d => d.FacilityId)
                .HasConstraintName("FK_LocationVillage_LocationFacility");

            entity.HasOne(d => d.FacilityType).WithMany(p => p.LocationVillages)
                .HasForeignKey(d => d.FacilityTypeId)
                .HasConstraintName("FK_LocationVillage_LocationFacilityType");

            entity.HasOne(d => d.State).WithMany(p => p.LocationVillages)
                .HasForeignKey(d => d.StateId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_LocationVillage_LocationState");

            entity.HasOne(d => d.SubFacility).WithMany(p => p.LocationVillages)
                .HasForeignKey(d => d.SubFacilityId)
                .HasConstraintName("FK_LocationVillage_LocationSubFacility");
        });

        modelBuilder.Entity<LocationVillageMl>(entity =>
        {
            entity.HasKey(e => new { e.VillageMlid, e.VillageId, e.LangId });

            entity.ToTable("LocationVillageML");

            entity.Property(e => e.VillageMlid)
                .ValueGeneratedOnAdd()
                .HasColumnName("VillageMLID");
            entity.Property(e => e.VillageId).HasColumnName("VillageID");
            entity.Property(e => e.LangId).HasColumnName("LangID");
            entity.Property(e => e.Village).HasMaxLength(150);
        });

        modelBuilder.Entity<MedicalEmergency>(entity =>
        {
            entity.HasKey(e => e.MeId);

            entity.ToTable("medical_emergency");

            entity.Property(e => e.MeId).HasColumnName("me_id");
            entity.Property(e => e.Age).HasColumnName("age");
            entity.Property(e => e.Anaphylaxis)
                .HasMaxLength(50)
                .HasColumnName("anaphylaxis");
            entity.Property(e => e.AssessAirway).HasColumnName("assessAirway");
            entity.Property(e => e.AssessBreathing).HasColumnName("assessBreathing");
            entity.Property(e => e.AssessCirculation).HasColumnName("assessCirculation");
            entity.Property(e => e.BloodGlucose)
                .HasMaxLength(50)
                .HasColumnName("bloodGlucose");
            entity.Property(e => e.BreathingType)
                .HasMaxLength(50)
                .HasColumnName("breathingType");
            entity.Property(e => e.Burns).HasColumnName("burns");
            entity.Property(e => e.CapillaryRefillDate).HasColumnName("capillaryRefillDate");
            entity.Property(e => e.CapillaryRefillTime).HasColumnName("capillaryRefillTime");
            entity.Property(e => e.ChestPain).HasColumnName("chestPain");
            entity.Property(e => e.Crt).HasColumnName("crt");
            entity.Property(e => e.Diastolic)
                .HasMaxLength(50)
                .HasColumnName("diastolic");
            entity.Property(e => e.Gender)
                .HasMaxLength(50)
                .HasColumnName("gender");
            entity.Property(e => e.IsBleeding).HasColumnName("isBleeding");
            entity.Property(e => e.IsBreathing).HasColumnName("isBreathing");
            entity.Property(e => e.IsChoking).HasColumnName("isChoking");
            entity.Property(e => e.IsCold).HasColumnName("isCold");
            entity.Property(e => e.IsCough).HasColumnName("isCough");
            entity.Property(e => e.IsEdited).HasColumnName("isEdited");
            entity.Property(e => e.IsForeignObject).HasColumnName("isForeignObject");
            entity.Property(e => e.IsPulse).HasColumnName("isPulse");
            entity.Property(e => e.MeGuid).HasColumnName("me_guid");
            entity.Property(e => e.Mobile)
                .HasMaxLength(50)
                .HasColumnName("mobile");
            entity.Property(e => e.Name)
                .HasMaxLength(50)
                .HasColumnName("name");
            entity.Property(e => e.ObstructionSign)
                .HasMaxLength(50)
                .HasColumnName("obstructionSign");
            entity.Property(e => e.PatientRespond).HasColumnName("patientRespond");
            entity.Property(e => e.Poisoning).HasColumnName("poisoning");
            entity.Property(e => e.Pulse)
                .HasMaxLength(50)
                .HasColumnName("pulse");
            entity.Property(e => e.Rbs)
                .HasMaxLength(50)
                .HasColumnName("rbs");
            entity.Property(e => e.RespiratoryDistress).HasColumnName("respiratoryDistress");
            entity.Property(e => e.Rr)
                .HasMaxLength(50)
                .HasColumnName("rr");
            entity.Property(e => e.Seizure).HasColumnName("seizure");
            entity.Property(e => e.SnakeBite).HasColumnName("snakeBite");
            entity.Property(e => e.Spo2)
                .HasMaxLength(50)
                .HasColumnName("spo2");
            entity.Property(e => e.Step1CallAmbulance).HasColumnName("step1CallAmbulance");
            entity.Property(e => e.StrokeSymptoms).HasColumnName("strokeSymptoms");
            entity.Property(e => e.Systolic)
                .HasMaxLength(50)
                .HasColumnName("systolic");
            entity.Property(e => e.Trauma).HasColumnName("trauma");
            entity.Property(e => e.UnconsciousNonTrauma).HasColumnName("unconsciousNonTrauma");
        });

        modelBuilder.Entity<MedicalHistory>(entity =>
        {
            entity.HasKey(e => e.Sno).HasName("PK__medical___DDDF6446371524C0");

            entity.ToTable("medical_history");

            entity.Property(e => e.Sno).HasColumnName("sno");
            entity.Property(e => e.Condition)
                .HasMaxLength(255)
                .HasColumnName("condition");
            entity.Property(e => e.DiagnosedOn)
                .HasMaxLength(50)
                .HasColumnName("diagnosedOn");
            entity.Property(e => e.HistoryId).HasColumnName("historyId");
            entity.Property(e => e.PatientId).HasColumnName("patient_id");
            entity.Property(e => e.RecordedOn)
                .HasMaxLength(50)
                .HasColumnName("recordedOn");
            entity.Property(e => e.Remarks).HasColumnName("remarks");
            entity.Property(e => e.Status)
                .HasMaxLength(50)
                .HasColumnName("status");
        });

        modelBuilder.Entity<MedicationHistory>(entity =>
        {
            entity.HasKey(e => e.Sno).HasName("PK__medicati__DDDF6446515CBF0D");

            entity.ToTable("medication_history");

            entity.Property(e => e.Sno).HasColumnName("sno");
            entity.Property(e => e.CreatedOn)
                .HasMaxLength(50)
                .HasColumnName("createdOn");
            entity.Property(e => e.Dosage)
                .HasMaxLength(100)
                .HasColumnName("dosage");
            entity.Property(e => e.EndDate)
                .HasMaxLength(50)
                .HasColumnName("end_date");
            entity.Property(e => e.Frequency)
                .HasMaxLength(100)
                .HasColumnName("frequency");
            entity.Property(e => e.HistoryId).HasColumnName("historyId");
            entity.Property(e => e.Medicine)
                .HasMaxLength(255)
                .HasColumnName("medicine");
            entity.Property(e => e.PatientId).HasColumnName("patient_id");
            entity.Property(e => e.Remarks).HasColumnName("remarks");
            entity.Property(e => e.StartDate)
                .HasMaxLength(50)
                .HasColumnName("start_date");
        });

        modelBuilder.Entity<Menu>(entity =>
        {
            entity.ToTable("Menu");

            entity.Property(e => e.MenuId).HasColumnName("MenuID");
            entity.Property(e => e.CreatedOn).HasColumnType("datetime");
            entity.Property(e => e.Menu1)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("Menu");
            entity.Property(e => e.UpdatedOn).HasColumnType("datetime");
        });

        modelBuilder.Entity<MenuMl>(entity =>
        {
            entity.HasKey(e => new { e.MenuId, e.LangId });

            entity.ToTable("MenuML");

            entity.Property(e => e.MenuId).HasColumnName("MenuID");
            entity.Property(e => e.LangId).HasColumnName("LangID");
            entity.Property(e => e.Menu)
                .HasMaxLength(50)
                .IsUnicode(false);

            entity.HasOne(d => d.Lang).WithMany(p => p.MenuMls)
                .HasForeignKey(d => d.LangId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_MenuML_Language");

            entity.HasOne(d => d.MenuNavigation).WithMany(p => p.MenuMls)
                .HasForeignKey(d => d.MenuId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_MenuML_MstMenu");
        });

        modelBuilder.Entity<Mortality>(entity =>
        {
            entity.HasKey(e => e.Sno).HasName("PK__mortalit__DDDF6446DD352F3C");

            entity.ToTable("mortality");

            entity.Property(e => e.Sno).HasColumnName("sno");
            entity.Property(e => e.Cause).HasColumnName("cause");
            entity.Property(e => e.CreatedOn)
                .HasMaxLength(50)
                .HasColumnName("createdOn");
            entity.Property(e => e.DateOfDeath)
                .HasMaxLength(50)
                .HasColumnName("date_of_death");
            entity.Property(e => e.MortalityId).HasColumnName("mortalityId");
            entity.Property(e => e.PatientId).HasColumnName("patient_id");
            entity.Property(e => e.Place)
                .HasMaxLength(255)
                .HasColumnName("place");
            entity.Property(e => e.Remarks).HasColumnName("remarks");
        });

        modelBuilder.Entity<MstApplication>(entity =>
        {
            entity.HasKey(e => e.AppId);

            entity.ToTable("MstApplication");

            entity.Property(e => e.AppId).HasColumnName("AppID");
            entity.Property(e => e.Apiurl).HasColumnName("APIURL");
            entity.Property(e => e.AppGuid)
                .HasMaxLength(200)
                .HasColumnName("AppGUID");
            entity.Property(e => e.ApplicationName).HasMaxLength(300);
            entity.Property(e => e.CreatedOn).HasColumnType("datetime");
            entity.Property(e => e.UpdatedOn).HasColumnType("datetime");
        });

        modelBuilder.Entity<MstApplicationKeyGeneration>(entity =>
        {
            entity.HasKey(e => e.GenId);

            entity.ToTable("MstApplicationKeyGeneration");

            entity.Property(e => e.GenId).HasColumnName("GenID");
            entity.Property(e => e.AppGuid)
                .HasMaxLength(200)
                .HasColumnName("AppGUID");
            entity.Property(e => e.AppId).HasColumnName("AppID");
            entity.Property(e => e.AppKey).HasMaxLength(100);
            entity.Property(e => e.CreatedOn).HasColumnType("datetime");
            entity.Property(e => e.UpdatedOn).HasColumnType("datetime");

            entity.HasOne(d => d.App).WithMany(p => p.MstApplicationKeyGenerations)
                .HasForeignKey(d => d.AppId)
                .HasConstraintName("FK_MstApplicationKeyGeneration_MstApplication");
        });

        modelBuilder.Entity<MstMenu>(entity =>
        {
            entity.HasKey(e => e.MenuId);

            entity.ToTable("MstMenu");

            entity.Property(e => e.MenuId).HasColumnName("MenuID");
            entity.Property(e => e.Action)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Controller)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.CreatedOn).HasColumnType("datetime");
            entity.Property(e => e.IsActive).HasDefaultValue(true);
            entity.Property(e => e.Menu)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.MenuParentId).HasColumnName("MenuParentID");
            entity.Property(e => e.StyleClass)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.UpdatedOn).HasColumnType("datetime");
        });

        modelBuilder.Entity<MstMonth>(entity =>
        {
            entity.HasKey(e => e.MonthId);

            entity.ToTable("MstMonth");

            entity.Property(e => e.MonthId).HasColumnName("MonthID");
            entity.Property(e => e.Month).HasMaxLength(15);
            entity.Property(e => e.MonthS)
                .HasMaxLength(5)
                .IsUnicode(false);
        });

        modelBuilder.Entity<MstYear>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("MstYear");

            entity.Property(e => e.YearName).HasMaxLength(10);
        });

        modelBuilder.Entity<Note>(entity =>
        {
            entity.HasKey(e => e.Sno).HasName("PK__notes__DDDF64465F79FE2A");

            entity.ToTable("notes");

            entity.Property(e => e.Sno).HasColumnName("sno");
            entity.Property(e => e.CreatedOn)
                .HasMaxLength(50)
                .HasColumnName("createdOn");
            entity.Property(e => e.DoctorId).HasColumnName("doctorId");
            entity.Property(e => e.Note1).HasColumnName("note");
            entity.Property(e => e.NoteId).HasColumnName("noteId");
            entity.Property(e => e.PatientId).HasColumnName("patient_id");
        });

        modelBuilder.Entity<Operation>(entity =>
        {
            entity.HasKey(e => e.Sno).HasName("PK__operatio__DDDF64464ECEEE18");

            entity.ToTable("operations");

            entity.Property(e => e.Sno).HasColumnName("sno");
            entity.Property(e => e.CreatedOn)
                .HasMaxLength(50)
                .HasColumnName("createdOn");
            entity.Property(e => e.Date)
                .HasMaxLength(50)
                .HasColumnName("date");
            entity.Property(e => e.Name)
                .HasMaxLength(255)
                .HasColumnName("name");
            entity.Property(e => e.OperationId).HasColumnName("operationId");
            entity.Property(e => e.Outcome)
                .HasMaxLength(255)
                .HasColumnName("outcome");
            entity.Property(e => e.PatientId).HasColumnName("patient_id");
            entity.Property(e => e.Remarks).HasColumnName("remarks");
            entity.Property(e => e.Surgeon)
                .HasMaxLength(255)
                .HasColumnName("surgeon");
        });

        modelBuilder.Entity<OutreachVisit>(entity =>
        {
            entity.HasKey(e => e.Sno).HasName("PK__outreach__DDDF6446500D8824");

            entity.ToTable("outreach_visits");

            entity.Property(e => e.Sno).HasColumnName("sno");
            entity.Property(e => e.CreatedOn)
                .HasMaxLength(50)
                .HasColumnName("createdOn");
            entity.Property(e => e.Date)
                .HasMaxLength(50)
                .HasColumnName("date");
            entity.Property(e => e.Location)
                .HasMaxLength(255)
                .HasColumnName("location");
            entity.Property(e => e.OutreachId).HasColumnName("outreachId");
            entity.Property(e => e.PatientId).HasColumnName("patient_id");
            entity.Property(e => e.Purpose).HasColumnName("purpose");
            entity.Property(e => e.Remarks).HasColumnName("remarks");
        });

        modelBuilder.Entity<PastHistory>(entity =>
        {
            entity.HasKey(e => e.Sno).HasName("PK__past_his__DDDF64465C6C0CDA");

            entity.ToTable("past_history");

            entity.Property(e => e.Sno).HasColumnName("sno");
            entity.Property(e => e.CharLimit)
                .HasMaxLength(10)
                .HasColumnName("char_limit");
            entity.Property(e => e.Code)
                .HasMaxLength(20)
                .HasColumnName("code");
            entity.Property(e => e.FieldType)
                .HasMaxLength(20)
                .HasColumnName("field_type");
            entity.Property(e => e.HistoryEn)
                .HasMaxLength(255)
                .HasColumnName("history_en");
            entity.Property(e => e.HistoryHi)
                .HasMaxLength(255)
                .HasColumnName("history_hi");
            entity.Property(e => e.InputType)
                .HasMaxLength(20)
                .HasColumnName("input_type");
            entity.Property(e => e.Mandatory).HasColumnName("mandatory");
            entity.Property(e => e.MaxValue)
                .HasMaxLength(10)
                .HasColumnName("max_value");
            entity.Property(e => e.MinValue)
                .HasMaxLength(10)
                .HasColumnName("min_value");
            entity.Property(e => e.Symptoms)
                .HasMaxLength(255)
                .HasColumnName("symptoms");
        });

        modelBuilder.Entity<Patient>(entity =>
        {
            entity.HasKey(e => e.Sno).HasName("PK__patients__DDDF6446ABFB93D6");

            entity.ToTable("patients");

            entity.HasIndex(e => e.Mobile, "IX_patients_mobile").IsUnique();

            entity.Property(e => e.Sno).HasColumnName("sno");
            entity.Property(e => e.AbhaId).HasColumnName("abhaId");
            entity.Property(e => e.AgeType).HasColumnName("ageType");
            entity.Property(e => e.AncRegistered).HasColumnName("ancRegistered");
            entity.Property(e => e.CaseCloseDate).HasColumnName("case_close_date");
            entity.Property(e => e.CenterId)
                .HasMaxLength(10)
                .HasColumnName("centerId");
            entity.Property(e => e.CreatedAt)
                .HasColumnType("datetime")
                .HasColumnName("createdAt");
            entity.Property(e => e.CreatedBy).HasColumnName("createdBy");
            entity.Property(e => e.DeathDate).HasColumnName("death_date");
            entity.Property(e => e.Dob).HasColumnName("dob");
            entity.Property(e => e.EddDate).HasColumnName("edd_date");
            entity.Property(e => e.FlowType).HasColumnName("flowType");
            entity.Property(e => e.FollowUpDate).HasColumnName("followUpDate");
            entity.Property(e => e.FullName)
                .HasMaxLength(100)
                .HasColumnName("fullName");
            entity.Property(e => e.Gender)
                .HasMaxLength(10)
                .HasColumnName("gender");
            entity.Property(e => e.HealthWorkerId)
                .HasMaxLength(20)
                .HasColumnName("healthWorkerId");
            entity.Property(e => e.HeightCm).HasColumnName("heightCm");
            entity.Property(e => e.IsActive).HasColumnName("isActive");
            entity.Property(e => e.IsPregnant).HasColumnName("isPregnant");
            entity.Property(e => e.IsWomanPregnant).HasColumnName("isWomanPregnant");
            entity.Property(e => e.LmpDate).HasColumnName("lmp_date");
            entity.Property(e => e.Mobile)
                .HasMaxLength(20)
                .HasColumnName("mobile");
            entity.Property(e => e.MobileId).HasColumnName("mobile_id");
            entity.Property(e => e.Mode).HasColumnName("mode");
            entity.Property(e => e.MonthOfAge).HasColumnName("monthOfAge");
            entity.Property(e => e.PatientGuid).HasColumnName("PatientGUID");
            entity.Property(e => e.PatientId).HasColumnName("patient_id");
            entity.Property(e => e.PatientType).HasColumnName("patientType");
            entity.Property(e => e.RchId)
                .HasMaxLength(20)
                .HasColumnName("rchId");
            entity.Property(e => e.SpouseName)
                .HasMaxLength(100)
                .HasColumnName("spouseName");
            entity.Property(e => e.Status).HasColumnName("status");
            entity.Property(e => e.TotalMonths).HasColumnName("totalMonths");
            entity.Property(e => e.TotalWeeks).HasColumnName("totalWeeks");
            entity.Property(e => e.UpdatedAt)
                .HasColumnType("datetime")
                .HasColumnName("updatedAt");
            entity.Property(e => e.UpdatedBy).HasColumnName("updatedBy");
            entity.Property(e => e.VillageId)
                .HasMaxLength(20)
                .HasColumnName("village_id");
            entity.Property(e => e.VillageName)
                .HasMaxLength(100)
                .HasColumnName("villageName");
            entity.Property(e => e.WeeksOfAge).HasColumnName("weeksOfAge");
            entity.Property(e => e.WeightKg).HasColumnName("weightKg");
            entity.Property(e => e.YearOfAge).HasColumnName("yearOfAge");
        });

        modelBuilder.Entity<PatientVisit>(entity =>
        {
            entity.HasKey(e => e.Sno);

            entity.ToTable("patient_visit");

            entity.Property(e => e.Sno).HasColumnName("sno");
            entity.Property(e => e.AgeInDays).HasColumnName("age_in_days");
            entity.Property(e => e.AgeInMonths).HasColumnName("age_in_months");
            entity.Property(e => e.AgeInWeeks).HasColumnName("age_in_weeks");
            entity.Property(e => e.AgeInYears).HasColumnName("age_in_years");
            entity.Property(e => e.CreatedAt).HasColumnName("createdAt");
            entity.Property(e => e.CreatedBy).HasColumnName("createdBy");
            entity.Property(e => e.CurrentStatus).HasColumnName("current_status");
            entity.Property(e => e.DangerSign).HasColumnName("danger_sign");
            entity.Property(e => e.DeathDate).HasColumnName("death_date");
            entity.Property(e => e.DischargeDate).HasColumnName("discharge_date");
            entity.Property(e => e.FollowUpDate).HasColumnName("followUpDate");
            entity.Property(e => e.GaWeeks).HasColumnName("ga_weeks");
            entity.Property(e => e.MobileId).HasColumnName("mobile_id");
            entity.Property(e => e.OtherSymptom).HasColumnName("otherSymptom");
            entity.Property(e => e.PatientGuid).HasColumnName("PatientGUID");
            entity.Property(e => e.PatientId).HasColumnName("patient_id");
            entity.Property(e => e.Referred).HasColumnName("referred");
            entity.Property(e => e.ReferredLocation)
                .HasMaxLength(255)
                .HasColumnName("referred_location");
            entity.Property(e => e.SummaryKey)
                .IsUnicode(false)
                .HasColumnName("summary_key");
            entity.Property(e => e.Symptoms).HasColumnName("symptoms");
            entity.Property(e => e.SymptomsId)
                .HasMaxLength(50)
                .HasColumnName("symptoms_id");
            entity.Property(e => e.Temperature).HasColumnName("temperature");
            entity.Property(e => e.TimeStamp).HasColumnName("timeStamp");
            entity.Property(e => e.VisitDate).HasColumnName("visit_date");
            entity.Property(e => e.VisitNo).HasColumnName("visit_no");
        });

        modelBuilder.Entity<Payment>(entity =>
        {
            entity.HasKey(e => e.Sno).HasName("PK__payments__DDDF64466E08CAF9");

            entity.ToTable("payments");

            entity.Property(e => e.Sno).HasColumnName("sno");
            entity.Property(e => e.Amount)
                .HasMaxLength(50)
                .HasColumnName("amount");
            entity.Property(e => e.BillingId).HasColumnName("billingId");
            entity.Property(e => e.CreatedOn)
                .HasMaxLength(50)
                .HasColumnName("createdOn");
            entity.Property(e => e.Mode)
                .HasMaxLength(100)
                .HasColumnName("mode");
            entity.Property(e => e.PatientId).HasColumnName("patient_id");
            entity.Property(e => e.PaymentDate)
                .HasMaxLength(50)
                .HasColumnName("payment_date");
            entity.Property(e => e.PaymentId).HasColumnName("paymentId");
            entity.Property(e => e.Status)
                .HasMaxLength(50)
                .HasColumnName("status");
        });

        modelBuilder.Entity<Payroll>(entity =>
        {
            entity.HasKey(e => e.Sno).HasName("PK__payroll__DDDF6446DC46EF6A");

            entity.ToTable("payroll");

            entity.Property(e => e.Sno).HasColumnName("sno");
            entity.Property(e => e.Allowances)
                .HasMaxLength(50)
                .HasColumnName("allowances");
            entity.Property(e => e.BasicSalary)
                .HasMaxLength(50)
                .HasColumnName("basic_salary");
            entity.Property(e => e.CreatedOn)
                .HasMaxLength(50)
                .HasColumnName("createdOn");
            entity.Property(e => e.Deductions)
                .HasMaxLength(50)
                .HasColumnName("deductions");
            entity.Property(e => e.NetSalary)
                .HasMaxLength(50)
                .HasColumnName("net_salary");
            entity.Property(e => e.PaymentDate)
                .HasMaxLength(50)
                .HasColumnName("payment_date");
            entity.Property(e => e.PayrollId).HasColumnName("payrollId");
            entity.Property(e => e.StaffId).HasColumnName("staffId");
        });

        modelBuilder.Entity<PendWebNic>(entity =>
        {
            entity.HasKey(e => e.Sno).HasName("PK__pend_web__DDDF6446920C61CE");

            entity.ToTable("pend_web_nic");

            entity.Property(e => e.Sno).HasColumnName("sno");
            entity.Property(e => e.Message).HasColumnName("message");
            entity.Property(e => e.MobileId).HasColumnName("mobile_id");
            entity.Property(e => e.Msg).HasColumnName("msg");
            entity.Property(e => e.PatientId).HasColumnName("patient_id");
            entity.Property(e => e.RType).HasColumnName("rType");
            entity.Property(e => e.Sent).HasColumnName("sent");
            entity.Property(e => e.VisitNo).HasColumnName("visit_no");
        });

        modelBuilder.Entity<Performance>(entity =>
        {
            entity.HasKey(e => e.Sno).HasName("PK__performa__DDDF64468A9B2B81");

            entity.ToTable("performance");

            entity.Property(e => e.Sno).HasColumnName("sno");
            entity.Property(e => e.Comments).HasColumnName("comments");
            entity.Property(e => e.CreatedOn)
                .HasMaxLength(50)
                .HasColumnName("createdOn");
            entity.Property(e => e.PerformanceId).HasColumnName("performanceId");
            entity.Property(e => e.Rating)
                .HasMaxLength(50)
                .HasColumnName("rating");
            entity.Property(e => e.ReviewDate)
                .HasMaxLength(50)
                .HasColumnName("review_date");
            entity.Property(e => e.StaffId).HasColumnName("staffId");
        });

        modelBuilder.Entity<PhysicalTest>(entity =>
        {
            entity.HasKey(e => e.Sno).HasName("PK__physical__DDDF64463D99D7F2");

            entity.ToTable("physical_test");

            entity.Property(e => e.Sno).HasColumnName("sno");
            entity.Property(e => e.Haemoglobin)
                .HasMaxLength(20)
                .HasColumnName("haemoglobin");
            entity.Property(e => e.Height)
                .HasMaxLength(20)
                .HasColumnName("height");
            entity.Property(e => e.MobileId).HasColumnName("mobile_id");
            entity.Property(e => e.MuacReading)
                .HasMaxLength(20)
                .HasColumnName("muac_reading");
            entity.Property(e => e.OdemaFeet).HasColumnName("odema_feet");
            entity.Property(e => e.PalmerPallor).HasColumnName("palmer_pallor");
            entity.Property(e => e.PatientGuid).HasColumnName("PatientGUID");
            entity.Property(e => e.PatientId).HasColumnName("patient_id");
            entity.Property(e => e.TimeStamp).HasColumnName("timeStamp");
            entity.Property(e => e.VisitNo).HasColumnName("visit_no");
        });

        modelBuilder.Entity<Prescription>(entity =>
        {
            entity.HasKey(e => e.Sno).HasName("PK__prescrip__DDDF6446501F1257");

            entity.ToTable("prescriptions");

            entity.Property(e => e.Sno).HasColumnName("sno");
            entity.Property(e => e.CreatedOn)
                .HasMaxLength(50)
                .HasColumnName("createdOn");
            entity.Property(e => e.DoctorId).HasColumnName("doctorId");
            entity.Property(e => e.Dosage)
                .HasMaxLength(100)
                .HasColumnName("dosage");
            entity.Property(e => e.Duration)
                .HasMaxLength(50)
                .HasColumnName("duration");
            entity.Property(e => e.Frequency)
                .HasMaxLength(50)
                .HasColumnName("frequency");
            entity.Property(e => e.MedicineId).HasColumnName("medicineId");
            entity.Property(e => e.PatientId).HasColumnName("patient_id");
            entity.Property(e => e.PrescriptionId).HasColumnName("prescriptionId");
            entity.Property(e => e.Remarks).HasColumnName("remarks");
        });

        modelBuilder.Entity<Procedure>(entity =>
        {
            entity.HasKey(e => e.Sno).HasName("PK__procedur__DDDF644651D56C4E");

            entity.ToTable("procedures");

            entity.Property(e => e.Sno).HasColumnName("sno");
            entity.Property(e => e.CreatedOn)
                .HasMaxLength(50)
                .HasColumnName("createdOn");
            entity.Property(e => e.Date)
                .HasMaxLength(50)
                .HasColumnName("date");
            entity.Property(e => e.Name)
                .HasMaxLength(255)
                .HasColumnName("name");
            entity.Property(e => e.Outcome)
                .HasMaxLength(255)
                .HasColumnName("outcome");
            entity.Property(e => e.PatientId).HasColumnName("patient_id");
            entity.Property(e => e.ProcedureId).HasColumnName("procedureId");
            entity.Property(e => e.Remarks).HasColumnName("remarks");
        });

        modelBuilder.Entity<Purchase>(entity =>
        {
            entity.HasKey(e => e.Sno).HasName("PK__purchase__DDDF644690D4F89F");

            entity.ToTable("purchases");

            entity.Property(e => e.Sno).HasColumnName("sno");
            entity.Property(e => e.CreatedOn)
                .HasMaxLength(50)
                .HasColumnName("createdOn");
            entity.Property(e => e.ItemName)
                .HasMaxLength(255)
                .HasColumnName("item_name");
            entity.Property(e => e.PurchaseDate)
                .HasMaxLength(50)
                .HasColumnName("purchase_date");
            entity.Property(e => e.PurchaseId).HasColumnName("purchaseId");
            entity.Property(e => e.Quantity).HasColumnName("quantity");
            entity.Property(e => e.SupplierId).HasColumnName("supplierId");
            entity.Property(e => e.TotalPrice)
                .HasMaxLength(50)
                .HasColumnName("total_price");
            entity.Property(e => e.UnitPrice)
                .HasMaxLength(50)
                .HasColumnName("unit_price");
        });

        modelBuilder.Entity<PwAskForResult>(entity =>
        {
            entity.HasKey(e => e.Sno).HasName("PK__pw_ask_f__DDDF644611BC014C");

            entity.ToTable("pw_ask_for_result");

            entity.Property(e => e.Sno).HasColumnName("sno");
            entity.Property(e => e.Answer).HasColumnName("answer");
            entity.Property(e => e.Data).HasColumnName("data");
            entity.Property(e => e.MobileId).HasColumnName("mobile_id");
            entity.Property(e => e.PatientGuid).HasColumnName("PatientGUID");
            entity.Property(e => e.PatientId).HasColumnName("patient_id");
            entity.Property(e => e.QId).HasColumnName("q_id");
            entity.Property(e => e.VisitDate).HasColumnName("visit_date");
            entity.Property(e => e.VisitNo).HasColumnName("visit_no");
        });

        modelBuilder.Entity<PwExaminationResult>(entity =>
        {
            entity.HasKey(e => e.Sno).HasName("PK__pw_exami__DDDF64467B056A37");

            entity.ToTable("pw_examination_result");

            entity.Property(e => e.Sno).HasColumnName("sno");
            entity.Property(e => e.Answer).HasColumnName("answer");
            entity.Property(e => e.Data).HasColumnName("data");
            entity.Property(e => e.MobileId).HasColumnName("mobile_id");
            entity.Property(e => e.PatientGuid).HasColumnName("PatientGUID");
            entity.Property(e => e.PatientId).HasColumnName("patient_id");
            entity.Property(e => e.QId).HasColumnName("q_id");
            entity.Property(e => e.VisitDate).HasColumnName("visit_date");
            entity.Property(e => e.VisitNo).HasColumnName("visit_no");
        });

        modelBuilder.Entity<PwPastHistoryResult>(entity =>
        {
            entity.HasKey(e => e.Sno).HasName("PK__pw_past___DDDF644654181F17");

            entity.ToTable("pw_past_history_result");

            entity.Property(e => e.Sno).HasColumnName("sno");
            entity.Property(e => e.Answer).HasColumnName("answer");
            entity.Property(e => e.Data).HasColumnName("data");
            entity.Property(e => e.MobileId).HasColumnName("mobile_id");
            entity.Property(e => e.PatientGuid).HasColumnName("PatientGUID");
            entity.Property(e => e.PatientId).HasColumnName("patient_id");
            entity.Property(e => e.QId).HasColumnName("q_id");
            entity.Property(e => e.VisitDate).HasColumnName("visit_date");
            entity.Property(e => e.VisitNo).HasColumnName("visit_no");
        });

        modelBuilder.Entity<Radiology>(entity =>
        {
            entity.HasKey(e => e.Sno).HasName("PK__radiolog__DDDF6446FED68212");

            entity.ToTable("radiology");

            entity.Property(e => e.Sno).HasColumnName("sno");
            entity.Property(e => e.Findings).HasColumnName("findings");
            entity.Property(e => e.PatientId).HasColumnName("patient_id");
            entity.Property(e => e.RadiologyId).HasColumnName("radiologyId");
            entity.Property(e => e.RecordedOn)
                .HasMaxLength(50)
                .HasColumnName("recordedOn");
            entity.Property(e => e.Result).HasColumnName("result");
            entity.Property(e => e.TestName)
                .HasMaxLength(255)
                .HasColumnName("test_name");
        });

        modelBuilder.Entity<Referral>(entity =>
        {
            entity.HasKey(e => e.Sno).HasName("PK__referral__DDDF64464AE852D6");

            entity.ToTable("referrals");

            entity.Property(e => e.Sno).HasColumnName("sno");
            entity.Property(e => e.CreatedOn)
                .HasMaxLength(50)
                .HasColumnName("createdOn");
            entity.Property(e => e.PatientId).HasColumnName("patient_id");
            entity.Property(e => e.Reason).HasColumnName("reason");
            entity.Property(e => e.ReferralId).HasColumnName("referralId");
            entity.Property(e => e.ReferredBy).HasColumnName("referredBy");
            entity.Property(e => e.ReferredTo)
                .HasMaxLength(255)
                .HasColumnName("referredTo");
        });

        modelBuilder.Entity<ReferralsIn>(entity =>
        {
            entity.HasKey(e => e.Sno).HasName("PK__referral__DDDF64466E08886B");

            entity.ToTable("referrals_in");

            entity.Property(e => e.Sno).HasColumnName("sno");
            entity.Property(e => e.CreatedOn)
                .HasMaxLength(50)
                .HasColumnName("createdOn");
            entity.Property(e => e.Date)
                .HasMaxLength(50)
                .HasColumnName("date");
            entity.Property(e => e.PatientId).HasColumnName("patient_id");
            entity.Property(e => e.Reason).HasColumnName("reason");
            entity.Property(e => e.ReferralInId).HasColumnName("referralInId");
            entity.Property(e => e.ReferredFrom)
                .HasMaxLength(255)
                .HasColumnName("referredFrom");
        });

        modelBuilder.Entity<ReferralsOut>(entity =>
        {
            entity.HasKey(e => e.Sno).HasName("PK__referral__DDDF644660B6A672");

            entity.ToTable("referrals_out");

            entity.Property(e => e.Sno).HasColumnName("sno");
            entity.Property(e => e.CreatedOn)
                .HasMaxLength(50)
                .HasColumnName("createdOn");
            entity.Property(e => e.Date)
                .HasMaxLength(50)
                .HasColumnName("date");
            entity.Property(e => e.PatientId).HasColumnName("patient_id");
            entity.Property(e => e.Reason).HasColumnName("reason");
            entity.Property(e => e.ReferralOutId).HasColumnName("referralOutId");
            entity.Property(e => e.ReferredTo)
                .HasMaxLength(255)
                .HasColumnName("referredTo");
        });

        modelBuilder.Entity<ResponseDatum>(entity =>
        {
            entity.HasKey(e => e.Sno).HasName("PK__response__DDDF6446D568E1C6");

            entity.ToTable("response_data");

            entity.Property(e => e.Sno).HasColumnName("sno");
            entity.Property(e => e.DateTime)
                .HasColumnType("datetime")
                .HasColumnName("date_time");
            entity.Property(e => e.ReqData).HasColumnName("req_data");
            entity.Property(e => e.RequestType)
                .HasMaxLength(50)
                .HasColumnName("request_type");
            entity.Property(e => e.ResCode)
                .HasMaxLength(10)
                .HasColumnName("res_code");
            entity.Property(e => e.ResData).HasColumnName("res_data");
        });

        modelBuilder.Entity<Role>(entity =>
        {
            entity.HasKey(e => e.RoleId).HasName("PK_MstRole");

            entity.ToTable("Role");

            entity.Property(e => e.RoleId)
                .ValueGeneratedNever()
                .HasColumnName("RoleID");
            entity.Property(e => e.CreatedOn).HasColumnType("datetime");
            entity.Property(e => e.Role1)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("Role");
            entity.Property(e => e.UpdatedOn).HasColumnType("datetime");
        });

        modelBuilder.Entity<Role1>(entity =>
        {
            entity.HasKey(e => e.Sno).HasName("PK__roles__DDDF6446B8A02818");

            entity.ToTable("roles");

            entity.Property(e => e.Sno).HasColumnName("sno");
            entity.Property(e => e.CreatedOn)
                .HasMaxLength(50)
                .HasColumnName("createdOn");
            entity.Property(e => e.Description).HasColumnName("description");
            entity.Property(e => e.RoleId).HasColumnName("roleId");
            entity.Property(e => e.RoleName)
                .HasMaxLength(255)
                .HasColumnName("role_name");
        });

        modelBuilder.Entity<RoleMenu>(entity =>
        {
            entity.HasKey(e => e.RoleMenuId).HasName("PK_RoleMenuRights");

            entity.ToTable("RoleMenu");

            entity.Property(e => e.RoleMenuId).HasColumnName("RoleMenuID");
            entity.Property(e => e.CreatedOn).HasColumnType("datetime");
            entity.Property(e => e.MenuId).HasColumnName("MenuID");
            entity.Property(e => e.RoleId).HasColumnName("RoleID");
            entity.Property(e => e.UpdatedOn).HasColumnType("datetime");

            entity.HasOne(d => d.Menu).WithMany(p => p.RoleMenus)
                .HasForeignKey(d => d.MenuId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_RoleMenu_MstMenu");

            entity.HasOne(d => d.Role).WithMany(p => p.RoleMenus)
                .HasForeignKey(d => d.RoleId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_RoleMenu_Role");
        });

        modelBuilder.Entity<RoleMl>(entity =>
        {
            entity.HasKey(e => new { e.RoleId, e.LangId });

            entity.ToTable("RoleML");

            entity.Property(e => e.RoleId).HasColumnName("RoleID");
            entity.Property(e => e.LangId).HasColumnName("LangID");
            entity.Property(e => e.Role).HasMaxLength(50);
        });

        modelBuilder.Entity<RoomMasterTable>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__room_mas__3213E83F68C074E0");

            entity.ToTable("room_master_table");

            entity.Property(e => e.Id)
                .ValueGeneratedNever()
                .HasColumnName("id");
            entity.Property(e => e.IdentityHash)
                .HasMaxLength(128)
                .HasColumnName("identity_hash");
        });

        modelBuilder.Entity<RoutineAssessment>(entity =>
        {
            entity.HasKey(e => e.Sno).HasName("PK__routine___DDDF644680D17691");

            entity.ToTable("routine_assessment");

            entity.Property(e => e.Sno).HasColumnName("sno");
            entity.Property(e => e.BreathAMin).HasColumnName("breath_a_min");
            entity.Property(e => e.Grunting).HasColumnName("grunting");
            entity.Property(e => e.HadConvulsions).HasColumnName("had_convulsions");
            entity.Property(e => e.MobileId).HasColumnName("mobile_id");
            entity.Property(e => e.MovementOnSimulation).HasColumnName("movement_on_simulation");
            entity.Property(e => e.NoMovement).HasColumnName("no_movement");
            entity.Property(e => e.NotFeedingWell).HasColumnName("not_feeding_well");
            entity.Property(e => e.PatientId).HasColumnName("patient_id");
            entity.Property(e => e.SevereChestIndrawing).HasColumnName("severe_chest_indrawing");
            entity.Property(e => e.SkinPustules).HasColumnName("skin_pustules");
            entity.Property(e => e.Temperature).HasColumnName("temperature");
            entity.Property(e => e.TimeStamp)
                .HasColumnType("datetime")
                .HasColumnName("timeStamp");
            entity.Property(e => e.UmbilicusIndrawingPus).HasColumnName("umbilicus_indrawing_pus");
            entity.Property(e => e.UmbilicusRed).HasColumnName("umbilicus_red");
            entity.Property(e => e.VisitNo).HasColumnName("visit_no");
        });

        modelBuilder.Entity<Screening>(entity =>
        {
            entity.HasKey(e => e.Sno).HasName("PK__screenin__DDDF6446ED63362A");

            entity.ToTable("screenings");

            entity.Property(e => e.Sno).HasColumnName("sno");
            entity.Property(e => e.PatientId).HasColumnName("patient_id");
            entity.Property(e => e.RecordedOn)
                .HasMaxLength(50)
                .HasColumnName("recordedOn");
            entity.Property(e => e.Result).HasColumnName("result");
            entity.Property(e => e.ScreeningId).HasColumnName("screeningId");
            entity.Property(e => e.Type)
                .HasMaxLength(100)
                .HasColumnName("type");
        });

        modelBuilder.Entity<ScreeningResult>(entity =>
        {
            entity.HasKey(e => e.Sno).HasName("PK__screenin__DDDF6446898CA31D");

            entity.ToTable("screening_results");

            entity.Property(e => e.Sno).HasColumnName("sno");
            entity.Property(e => e.CreatedOn)
                .HasMaxLength(50)
                .HasColumnName("createdOn");
            entity.Property(e => e.Date)
                .HasMaxLength(50)
                .HasColumnName("date");
            entity.Property(e => e.PatientId).HasColumnName("patient_id");
            entity.Property(e => e.Remarks).HasColumnName("remarks");
            entity.Property(e => e.Result).HasColumnName("result");
            entity.Property(e => e.ScreeningId).HasColumnName("screeningId");
            entity.Property(e => e.ScreeningResultId).HasColumnName("screeningResultId");
        });

        modelBuilder.Entity<Shift>(entity =>
        {
            entity.HasKey(e => e.Sno).HasName("PK__shifts__DDDF64460A9F84AE");

            entity.ToTable("shifts");

            entity.Property(e => e.Sno).HasColumnName("sno");
            entity.Property(e => e.CreatedOn)
                .HasMaxLength(50)
                .HasColumnName("createdOn");
            entity.Property(e => e.EndTime)
                .HasMaxLength(50)
                .HasColumnName("end_time");
            entity.Property(e => e.Remarks).HasColumnName("remarks");
            entity.Property(e => e.ShiftDate)
                .HasMaxLength(50)
                .HasColumnName("shift_date");
            entity.Property(e => e.ShiftId).HasColumnName("shiftId");
            entity.Property(e => e.StaffId).HasColumnName("staffId");
            entity.Property(e => e.StartTime)
                .HasMaxLength(50)
                .HasColumnName("start_time");
        });

        modelBuilder.Entity<SocialHistory>(entity =>
        {
            entity.HasKey(e => e.Sno).HasName("PK__social_h__DDDF64461B5A0DC6");

            entity.ToTable("social_history");

            entity.Property(e => e.Sno).HasColumnName("sno");
            entity.Property(e => e.Education)
                .HasMaxLength(255)
                .HasColumnName("education");
            entity.Property(e => e.FinancialStatus)
                .HasMaxLength(255)
                .HasColumnName("financial_status");
            entity.Property(e => e.LivingConditions).HasColumnName("living_conditions");
            entity.Property(e => e.MaritalStatus)
                .HasMaxLength(50)
                .HasColumnName("marital_status");
            entity.Property(e => e.Occupation)
                .HasMaxLength(255)
                .HasColumnName("occupation");
            entity.Property(e => e.PatientId).HasColumnName("patient_id");
            entity.Property(e => e.RecordedOn)
                .HasMaxLength(50)
                .HasColumnName("recordedOn");
            entity.Property(e => e.SocialHistoryId).HasColumnName("socialHistoryId");
        });

        modelBuilder.Entity<Staff>(entity =>
        {
            entity.HasKey(e => e.Sno).HasName("PK__staff__DDDF6446A7A32201");

            entity.ToTable("staff");

            entity.Property(e => e.Sno).HasColumnName("sno");
            entity.Property(e => e.Address).HasColumnName("address");
            entity.Property(e => e.Contact)
                .HasMaxLength(255)
                .HasColumnName("contact");
            entity.Property(e => e.CreatedOn)
                .HasMaxLength(50)
                .HasColumnName("createdOn");
            entity.Property(e => e.DateOfJoining)
                .HasMaxLength(50)
                .HasColumnName("date_of_joining");
            entity.Property(e => e.DepartmentId).HasColumnName("departmentId");
            entity.Property(e => e.Email)
                .HasMaxLength(255)
                .HasColumnName("email");
            entity.Property(e => e.Name)
                .HasMaxLength(255)
                .HasColumnName("name");
            entity.Property(e => e.Phone)
                .HasMaxLength(50)
                .HasColumnName("phone");
            entity.Property(e => e.RoleId).HasColumnName("roleId");
            entity.Property(e => e.StaffId).HasColumnName("staffId");
        });

        modelBuilder.Entity<StateEntryTypewise>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("StateEntryTypewise");

            entity.Property(e => e.StateId).HasColumnName("StateID");
            entity.Property(e => e.StateName).HasMaxLength(250);
        });

        modelBuilder.Entity<Stock>(entity =>
        {
            entity.HasKey(e => e.Sno).HasName("PK__stock__DDDF6446CA8CC782");

            entity.ToTable("stock");

            entity.Property(e => e.Sno).HasColumnName("sno");
            entity.Property(e => e.InventoryId).HasColumnName("inventoryId");
            entity.Property(e => e.LastUpdated)
                .HasMaxLength(50)
                .HasColumnName("last_updated");
            entity.Property(e => e.Quantity).HasColumnName("quantity");
            entity.Property(e => e.Remarks).HasColumnName("remarks");
            entity.Property(e => e.StockId).HasColumnName("stockId");
        });

        modelBuilder.Entity<SubSymptom>(entity =>
        {
            entity.HasKey(e => e.Sno).HasName("PK__sub_symp__DDDF644631BBC8A3");

            entity.ToTable("sub_symptoms");

            entity.Property(e => e.Sno).HasColumnName("sno");
            entity.Property(e => e.CharLimit)
                .HasMaxLength(10)
                .HasColumnName("char_limit");
            entity.Property(e => e.FieldType)
                .HasMaxLength(20)
                .HasColumnName("field_type");
            entity.Property(e => e.FieldsEn)
                .HasMaxLength(255)
                .HasColumnName("fields_en");
            entity.Property(e => e.FieldsHi)
                .HasMaxLength(255)
                .HasColumnName("fields_hi");
            entity.Property(e => e.InputType)
                .HasMaxLength(20)
                .HasColumnName("input_type");
            entity.Property(e => e.Mandatory).HasColumnName("mandatory");
            entity.Property(e => e.MaxValue)
                .HasMaxLength(10)
                .HasColumnName("max_value");
            entity.Property(e => e.MinValue)
                .HasMaxLength(10)
                .HasColumnName("min_value");
            entity.Property(e => e.ParentCode)
                .HasMaxLength(20)
                .HasColumnName("parent_code");
        });

        modelBuilder.Entity<Supplier>(entity =>
        {
            entity.HasKey(e => e.Sno).HasName("PK__supplier__DDDF6446DD886A0B");

            entity.ToTable("suppliers");

            entity.Property(e => e.Sno).HasColumnName("sno");
            entity.Property(e => e.Address).HasColumnName("address");
            entity.Property(e => e.Contact)
                .HasMaxLength(255)
                .HasColumnName("contact");
            entity.Property(e => e.CreatedOn)
                .HasMaxLength(50)
                .HasColumnName("createdOn");
            entity.Property(e => e.Email)
                .HasMaxLength(255)
                .HasColumnName("email");
            entity.Property(e => e.Name)
                .HasMaxLength(255)
                .HasColumnName("name");
            entity.Property(e => e.Phone)
                .HasMaxLength(50)
                .HasColumnName("phone");
            entity.Property(e => e.SupplierId).HasColumnName("supplierId");
        });

        modelBuilder.Entity<SurgicalHistory>(entity =>
        {
            entity.HasKey(e => e.Sno).HasName("PK__surgical__DDDF64469C290527");

            entity.ToTable("surgical_history");

            entity.Property(e => e.Sno).HasColumnName("sno");
            entity.Property(e => e.CreatedOn)
                .HasMaxLength(50)
                .HasColumnName("createdOn");
            entity.Property(e => e.Date)
                .HasMaxLength(50)
                .HasColumnName("date");
            entity.Property(e => e.Outcome)
                .HasMaxLength(255)
                .HasColumnName("outcome");
            entity.Property(e => e.PatientId).HasColumnName("patient_id");
            entity.Property(e => e.Remarks).HasColumnName("remarks");
            entity.Property(e => e.Surgery)
                .HasMaxLength(255)
                .HasColumnName("surgery");
            entity.Property(e => e.SurgicalHistoryId).HasColumnName("surgicalHistoryId");
        });

        modelBuilder.Entity<Symptom>(entity =>
        {
            entity.HasKey(e => e.Sno).HasName("PK__symptoms__DDDF64460F34CFDE");

            entity.ToTable("symptoms");

            entity.Property(e => e.Sno).HasColumnName("sno");
            entity.Property(e => e.Code)
                .HasMaxLength(10)
                .HasColumnName("code");
            entity.Property(e => e.SymptomEn)
                .HasMaxLength(255)
                .HasColumnName("symptom_en");
            entity.Property(e => e.SymptomHi)
                .HasMaxLength(255)
                .HasColumnName("symptom_hi");
        });

        modelBuilder.Entity<SymptomsType>(entity =>
        {
            entity.HasKey(e => e.SymptomTypeId).HasName("PK__Symptoms__C39FDFA9A0A758CF");

            entity.ToTable("SymptomsType");

            entity.Property(e => e.SymptomTypeName)
                .HasMaxLength(500)
                .IsUnicode(false);
        });

        modelBuilder.Entity<TblCounselling>(entity =>
        {
            entity.ToTable("tblCounselling");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.AdditionalUrl).HasColumnName("AdditionalURL");
            entity.Property(e => e.AppGuid)
                .HasMaxLength(200)
                .HasColumnName("AppGUID");
            entity.Property(e => e.CreatedOn).HasColumnType("datetime");
            entity.Property(e => e.DataSourceId).HasColumnName("DataSourceID");
            entity.Property(e => e.FileTitle).HasMaxLength(100);
            entity.Property(e => e.LangId).HasColumnName("LangID");
            entity.Property(e => e.UpdatedOn).HasColumnType("datetime");
        });

        modelBuilder.Entity<TblCounsellingStatus>(entity =>
        {
            entity.HasKey(e => e.CounsellingStatusGuid).HasName("PK__tblCouns__7AE2AF001AFB8819");

            entity.ToTable("tblCounsellingStatus");

            entity.Property(e => e.CounsellingStatusGuid)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("CounsellingStatusGUID");
            entity.Property(e => e.CounsellingId).HasColumnName("CounsellingID");
            entity.Property(e => e.CreatedOn)
                .HasMaxLength(255)
                .IsUnicode(false);
            entity.Property(e => e.DataSourceId).HasColumnName("DataSourceID");
            entity.Property(e => e.EndWatchTime)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("endWatchTime");
            entity.Property(e => e.Percentage).HasColumnName("percentage");
            entity.Property(e => e.StartWatchTime)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("startWatchTime");
            entity.Property(e => e.Status).HasColumnName("status");
            entity.Property(e => e.UpdatedOn)
                .HasMaxLength(255)
                .IsUnicode(false);
        });

        modelBuilder.Entity<TblDoctorProfile>(entity =>
        {
            entity.ToTable("tblDoctorProfile");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.CreatedOn).HasColumnType("datetime");
            entity.Property(e => e.DoctorName).HasMaxLength(100);
            entity.Property(e => e.FacilityId).HasColumnName("FacilityID");
            entity.Property(e => e.LangId).HasColumnName("LangID");
            entity.Property(e => e.MoDoctorId).HasColumnName("MoDoctorID");
            entity.Property(e => e.UpdatedOn).HasColumnType("datetime");
        });

        modelBuilder.Entity<TblDrug>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__tblDrugs__908D66F696A845AB");

            entity.ToTable("tblDrugs");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.CreatedOn).HasColumnType("datetime");
            entity.Property(e => e.DrugId).HasColumnName("DrugID");
            entity.Property(e => e.DrugName).HasMaxLength(255);
            entity.Property(e => e.DrugTypeCode).HasMaxLength(255);
            entity.Property(e => e.LangId).HasColumnName("LangID");
            entity.Property(e => e.UpdatedOn).HasColumnType("datetime");
        });

        modelBuilder.Entity<TblDrugType>(entity =>
        {
            entity.HasKey(e => e.DrugTypeId).HasName("PK__tblDrugT__718B4F9996DF4E3F");

            entity.ToTable("tblDrugType");

            entity.Property(e => e.DrugTypeId).HasColumnName("DrugTypeID");
            entity.Property(e => e.CreatedOn).HasColumnType("datetime");
            entity.Property(e => e.DrugTypeCode).HasMaxLength(255);
            entity.Property(e => e.DrugTypeName).HasMaxLength(255);
            entity.Property(e => e.LangId).HasColumnName("LangID");
            entity.Property(e => e.UpdatedOn).HasColumnType("datetime");
        });

        modelBuilder.Entity<TblPolicy>(entity =>
        {
            entity.HasKey(e => e.PolicyId);

            entity.ToTable("tblPolicy");

            entity.Property(e => e.PolicyId).HasColumnName("PolicyID");
            entity.Property(e => e.CreatedOn).HasColumnType("datetime");
            entity.Property(e => e.IsActive).HasDefaultValue(true);
            entity.Property(e => e.IsVerified).HasDefaultValue(true);
            entity.Property(e => e.PolicyHeading).HasMaxLength(250);
            entity.Property(e => e.UpdatedOn).HasColumnType("datetime");
        });

        modelBuilder.Entity<TblPolicyDesc>(entity =>
        {
            entity.HasKey(e => e.PolicyDescId);

            entity.ToTable("tblPolicyDesc");

            entity.Property(e => e.CreatedOn).HasColumnType("datetime");
            entity.Property(e => e.IsActive).HasDefaultValue(true);
            entity.Property(e => e.IsVerified).HasDefaultValue(true);
            entity.Property(e => e.PolicyDescHeading).HasMaxLength(250);
            entity.Property(e => e.UpdatedOn).HasColumnType("datetime");
        });

        modelBuilder.Entity<TblPrasavStaff>(entity =>
        {
            entity.HasKey(e => e.StaffId);

            entity.ToTable("tblPrasavStaff");

            entity.Property(e => e.StaffId).HasColumnName("StaffID");
            entity.Property(e => e.BlockId).HasColumnName("BlockID");
            entity.Property(e => e.CreatedOn).HasColumnType("datetime");
            entity.Property(e => e.DistrictId).HasColumnName("DistrictID");
            entity.Property(e => e.EmailId)
                .HasMaxLength(50)
                .HasColumnName("EmailID");
            entity.Property(e => e.FacilityId).HasColumnName("FacilityID");
            entity.Property(e => e.ImportFlag).HasMaxLength(50);
            entity.Property(e => e.IsActive).HasDefaultValue(1);
            entity.Property(e => e.IsDeleted).HasDefaultValue(0);
            entity.Property(e => e.MobileNo).HasMaxLength(10);
            entity.Property(e => e.RoleId).HasColumnName("RoleID");
            entity.Property(e => e.StateId).HasColumnName("StateID");
            entity.Property(e => e.UpdatedOn).HasColumnType("datetime");
        });

        modelBuilder.Entity<Training>(entity =>
        {
            entity.HasKey(e => e.Sno).HasName("PK__training__DDDF6446FF1A2FCD");

            entity.ToTable("training");

            entity.Property(e => e.Sno).HasColumnName("sno");
            entity.Property(e => e.CreatedOn)
                .HasMaxLength(50)
                .HasColumnName("createdOn");
            entity.Property(e => e.Date)
                .HasMaxLength(50)
                .HasColumnName("date");
            entity.Property(e => e.Duration)
                .HasMaxLength(50)
                .HasColumnName("duration");
            entity.Property(e => e.Remarks).HasColumnName("remarks");
            entity.Property(e => e.StaffId).HasColumnName("staffId");
            entity.Property(e => e.Topic)
                .HasMaxLength(255)
                .HasColumnName("topic");
            entity.Property(e => e.Trainer)
                .HasMaxLength(255)
                .HasColumnName("trainer");
            entity.Property(e => e.TrainingId).HasColumnName("trainingId");
        });

        modelBuilder.Entity<TreatmentMaster>(entity =>
        {
            entity.HasKey(e => e.Sno).HasName("PK__treatmen__DDDF644623CC507B");

            entity.ToTable("treatment_master");

            entity.Property(e => e.Sno).HasColumnName("sno");
            entity.Property(e => e.Code)
                .HasMaxLength(100)
                .HasColumnName("code");
            entity.Property(e => e.TreatmentEn).HasColumnName("treatment_en");
            entity.Property(e => e.TreatmentHi).HasColumnName("treatment_hi");
        });

        modelBuilder.Entity<User>(entity =>
        {
            entity.HasKey(e => e.UserId).HasName("PK_MstUser_1");

            entity.ToTable("User");

            entity.Property(e => e.UserId).HasColumnName("UserID");
            entity.Property(e => e.Anmid).HasColumnName("ANMID");
            entity.Property(e => e.AuthToken)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.AuthToken2)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Captcha).HasMaxLength(50);
            entity.Property(e => e.Choid).HasColumnName("CHOID");
            entity.Property(e => e.CreatedOn).HasColumnType("datetime");
            entity.Property(e => e.EmailId)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("EmailID");
            entity.Property(e => e.IsActive).HasDefaultValue(true);
            entity.Property(e => e.LastLoggedIn).HasColumnType("datetime");
            entity.Property(e => e.MobileNo)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.Name)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.Password)
                .HasMaxLength(250)
                .IsUnicode(false);
            entity.Property(e => e.PwdLinkExpTime)
                .HasColumnType("datetime")
                .HasColumnName("pwdLinkExpTime");
            entity.Property(e => e.RoleId).HasColumnName("RoleID");
            entity.Property(e => e.StaffId).HasColumnName("StaffID");
            entity.Property(e => e.UpdatedOn).HasColumnType("datetime");
            entity.Property(e => e.Username)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Vcode)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasColumnName("VCode");
            entity.Property(e => e.WrongNoofLogin).HasDefaultValue(0);

            entity.HasOne(d => d.Cho).WithMany(p => p.Users)
                .HasForeignKey(d => d.Choid)
                .HasConstraintName("FK_User_CHO");

            entity.HasOne(d => d.Role).WithMany(p => p.Users)
                .HasForeignKey(d => d.RoleId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_User_Role");
        });

        modelBuilder.Entity<User1>(entity =>
        {
            entity.HasKey(e => e.Sno).HasName("PK__users__DDDF64464B24B105");

            entity.ToTable("users");

            entity.Property(e => e.Sno).HasColumnName("sno");
            entity.Property(e => e.CenterId)
                .HasMaxLength(50)
                .HasColumnName("centerId");
            entity.Property(e => e.CreatedOn)
                .HasMaxLength(50)
                .HasColumnName("createdOn");
            entity.Property(e => e.Mobile)
                .HasMaxLength(20)
                .HasColumnName("mobile");
            entity.Property(e => e.Name)
                .HasMaxLength(255)
                .HasColumnName("name");
            entity.Property(e => e.Password)
                .HasMaxLength(255)
                .HasColumnName("password");
            entity.Property(e => e.Role)
                .HasMaxLength(50)
                .HasColumnName("role");
            entity.Property(e => e.UserId).HasColumnName("userId");
        });

        modelBuilder.Entity<UserAnm>(entity =>
        {
            entity.HasKey(e => e.UserAnm1);

            entity.ToTable("UserANM");

            entity.Property(e => e.UserAnm1).HasColumnName("UserANM");
            entity.Property(e => e.Anmid).HasColumnName("ANMID");
            entity.Property(e => e.CreatedOn).HasColumnType("datetime");
            entity.Property(e => e.UserId).HasColumnName("UserID");
        });

        modelBuilder.Entity<UserAsha>(entity =>
        {
            entity.HasKey(e => e.UserAsaid);

            entity.ToTable("UserASHA");

            entity.Property(e => e.UserAsaid).HasColumnName("UserASAID");
            entity.Property(e => e.Anmid).HasColumnName("ANMID");
            entity.Property(e => e.Ashaid).HasColumnName("ASHAID");
            entity.Property(e => e.CreatedOn).HasColumnType("datetime");
            entity.Property(e => e.UserId).HasColumnName("UserID");
        });

        modelBuilder.Entity<UserBlock>(entity =>
        {
            entity.ToTable("UserBlock");

            entity.Property(e => e.UserBlockId).HasColumnName("UserBlockID");
            entity.Property(e => e.BlockId).HasColumnName("BlockID");
            entity.Property(e => e.CreatedOn).HasColumnType("datetime");
            entity.Property(e => e.UserId).HasColumnName("UserID");
        });

        modelBuilder.Entity<UserCho>(entity =>
        {
            entity.HasKey(e => e.UserCho1);

            entity.ToTable("UserCHO");

            entity.Property(e => e.UserCho1).HasColumnName("UserCHO");
            entity.Property(e => e.Choid).HasColumnName("CHOID");
            entity.Property(e => e.CreatedOn).HasColumnType("datetime");
            entity.Property(e => e.UserId).HasColumnName("UserID");

            entity.HasOne(d => d.Cho).WithMany(p => p.UserChos)
                .HasForeignKey(d => d.Choid)
                .HasConstraintName("FK_UserCHO_CHO");

            entity.HasOne(d => d.User).WithMany(p => p.UserChos)
                .HasForeignKey(d => d.UserId)
                .HasConstraintName("FK_UserCHO_User");
        });

        modelBuilder.Entity<UserDistrict>(entity =>
        {
            entity.ToTable("UserDistrict");

            entity.Property(e => e.UserDistrictId).HasColumnName("UserDistrictID");
            entity.Property(e => e.CreatedOn).HasColumnType("datetime");
            entity.Property(e => e.DistrictId).HasColumnName("DistrictID");
            entity.Property(e => e.UserId).HasColumnName("UserID");
        });

        modelBuilder.Entity<UserFacility>(entity =>
        {
            entity.ToTable("UserFacility");

            entity.Property(e => e.UserFacilityId).HasColumnName("UserFacilityID");
            entity.Property(e => e.CreatedOn).HasColumnType("datetime");
            entity.Property(e => e.FacilityId).HasColumnName("FacilityID");
            entity.Property(e => e.RoleId).HasColumnName("RoleID");
            entity.Property(e => e.UserId).HasColumnName("UserID");

            entity.HasOne(d => d.Facility).WithMany(p => p.UserFacilities)
                .HasForeignKey(d => d.FacilityId)
                .HasConstraintName("FK_UserFacility_LocationFacility");

            entity.HasOne(d => d.User).WithMany(p => p.UserFacilities)
                .HasForeignKey(d => d.UserId)
                .HasConstraintName("FK_UserFacility_User");
        });

        modelBuilder.Entity<UserMidWifery>(entity =>
        {
            entity.HasKey(e => e.UserWifeId);

            entity.ToTable("UserMidWifery");

            entity.Property(e => e.UserWifeId).HasColumnName("UserWifeID");
            entity.Property(e => e.CreatedOn).HasColumnType("datetime");
            entity.Property(e => e.FacilityId).HasColumnName("FacilityID");
            entity.Property(e => e.UserId).HasColumnName("UserID");
        });

        modelBuilder.Entity<UserState>(entity =>
        {
            entity.ToTable("UserState");

            entity.Property(e => e.UserStateId).HasColumnName("UserStateID");
            entity.Property(e => e.CreatedOn).HasColumnType("datetime");
            entity.Property(e => e.StateId).HasColumnName("StateID");
            entity.Property(e => e.UserId).HasColumnName("UserID");
        });

        modelBuilder.Entity<UserVillage>(entity =>
        {
            entity.ToTable("UserVillage");

            entity.Property(e => e.UserVillageId).HasColumnName("UserVillageID");
            entity.Property(e => e.CreatedOn).HasColumnType("datetime");
            entity.Property(e => e.UserId).HasColumnName("UserID");
            entity.Property(e => e.VillageId).HasColumnName("VillageID");
        });

        modelBuilder.Entity<VaccinationHistory>(entity =>
        {
            entity.HasKey(e => e.Sno).HasName("PK__vaccinat__DDDF64461807CCFA");

            entity.ToTable("vaccination_history");

            entity.Property(e => e.Sno).HasColumnName("sno");
            entity.Property(e => e.CreatedOn)
                .HasMaxLength(50)
                .HasColumnName("createdOn");
            entity.Property(e => e.Date)
                .HasMaxLength(50)
                .HasColumnName("date");
            entity.Property(e => e.Dose)
                .HasMaxLength(50)
                .HasColumnName("dose");
            entity.Property(e => e.PatientId).HasColumnName("patient_id");
            entity.Property(e => e.Remarks).HasColumnName("remarks");
            entity.Property(e => e.VaccinationHistoryId).HasColumnName("vaccinationHistoryId");
            entity.Property(e => e.Vaccine)
                .HasMaxLength(255)
                .HasColumnName("vaccine");
        });

        modelBuilder.Entity<ViewAllAnctableDatum>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("View_AllANCTableData");

            entity.Property(e => e.AbortionDate)
                .HasMaxLength(30)
                .IsUnicode(false);
            entity.Property(e => e.AbortionTypeId).HasColumnName("AbortionTypeID");
            entity.Property(e => e.AdviceGiven).UseCollation("SQL_Latin1_General_CP1_CI_AS");
            entity.Property(e => e.Ancguid)
                .HasMaxLength(50)
                .IsUnicode(false)
                .UseCollation("SQL_Latin1_General_CP1_CI_AS")
                .HasColumnName("ANCGUID");
            entity.Property(e => e.Ancid).HasColumnName("ANCID");
            entity.Property(e => e.AncvisitDate)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("ANCVisitDate");
            entity.Property(e => e.AncvisitId).HasColumnName("ANCVisitID");
            entity.Property(e => e.AnemiaScreeningResultId).HasColumnName("AnemiaScreeningResultID");
            entity.Property(e => e.AshaId).HasColumnName("AshaID");
            entity.Property(e => e.BeneficiaryGuid)
                .HasMaxLength(100)
                .UseCollation("SQL_Latin1_General_CP1_CI_AS")
                .HasColumnName("BeneficiaryGUID");
            entity.Property(e => e.BlockName).HasMaxLength(255);
            entity.Property(e => e.Bpdiastolic).HasColumnName("BPDiastolic");
            entity.Property(e => e.Bpsystolic).HasColumnName("BPSystolic");
            entity.Property(e => e.Bt).HasColumnName("BT");
            entity.Property(e => e.CollaborationCareReason).UseCollation("SQL_Latin1_General_CP1_CI_AS");
            entity.Property(e => e.ContraceptiveMethod)
                .HasMaxLength(50)
                .IsUnicode(false)
                .UseCollation("SQL_Latin1_General_CP1_CI_AS");
            entity.Property(e => e.CovidResultId).HasColumnName("CovidResultID");
            entity.Property(e => e.CovidTestId).HasColumnName("CovidTestID");
            entity.Property(e => e.CreatedOn).HasColumnType("datetime");
            entity.Property(e => e.Ct).HasColumnName("CT");
            entity.Property(e => e.DataSourceId).HasColumnName("DataSourceID");
            entity.Property(e => e.DeathCauseMdrcommitteeId)
                .HasMaxLength(50)
                .IsUnicode(false)
                .UseCollation("SQL_Latin1_General_CP1_CI_AS")
                .HasColumnName("DeathCauseMDRCommitteeID");
            entity.Property(e => e.DeathCauseMdrcommitteeOther)
                .HasMaxLength(50)
                .IsUnicode(false)
                .UseCollation("SQL_Latin1_General_CP1_CI_AS")
                .HasColumnName("DeathCauseMDRCommitteeOther");
            entity.Property(e => e.DeathDate)
                .HasMaxLength(30)
                .IsUnicode(false);
            entity.Property(e => e.DeathPlaceId).HasColumnName("DeathPlaceID");
            entity.Property(e => e.DeathPlaceOther)
                .HasMaxLength(50)
                .IsUnicode(false)
                .UseCollation("SQL_Latin1_General_CP1_CI_AS");
            entity.Property(e => e.District).HasMaxLength(250);
            entity.Property(e => e.FacilityNameId).HasColumnName("FacilityNameID");
            entity.Property(e => e.FacilityNameOther)
                .HasMaxLength(50)
                .IsUnicode(false)
                .UseCollation("SQL_Latin1_General_CP1_CI_AS");
            entity.Property(e => e.FacilityTypeId).HasColumnName("FacilityTypeID");
            entity.Property(e => e.FoetalMovementId).HasColumnName("FoetalMovementID");
            entity.Property(e => e.FoetalPresentationId).HasColumnName("FoetalPresentationID");
            entity.Property(e => e.FundalHeightUterusSizeId).HasColumnName("FundalHeightUterusSizeID");
            entity.Property(e => e.Hb)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("HB");
            entity.Property(e => e.HighRiskFacilityTypeId).HasColumnName("HighRiskFacilityTypeID");
            entity.Property(e => e.HighRiskSymptomOther)
                .HasMaxLength(250)
                .IsUnicode(false)
                .UseCollation("SQL_Latin1_General_CP1_CI_AS");
            entity.Property(e => e.IcterusId).HasColumnName("IcterusID");
            entity.Property(e => e.InducedFacilityTypeId).HasColumnName("InducedFacilityTypeID");
            entity.Property(e => e.IsAlbendazoleTabId).HasColumnName("IsAlbendazoleTabID");
            entity.Property(e => e.IsBirthCompanionIdentifyId).HasColumnName("IsBirthCompanionIdentifyID");
            entity.Property(e => e.IsBloodSugarTestId).HasColumnName("IsBloodSugarTestID");
            entity.Property(e => e.IsBp).HasColumnName("IsBP");
            entity.Property(e => e.IsBpsystolicId).HasColumnName("IsBPSystolicID");
            entity.Property(e => e.IsHbid).HasColumnName("IsHBID");
            entity.Property(e => e.IsJsskschemeId).HasColumnName("IsJSSKSchemeID");
            entity.Property(e => e.IsMaternalDeathId).HasColumnName("IsMaternalDeathID");
            entity.Property(e => e.IsPwreffered).HasColumnName("IsPWReffered");
            entity.Property(e => e.IsUltrasoundScreeningId).HasColumnName("IsUltrasoundScreeningID");
            entity.Property(e => e.IsUrineTestId).HasColumnName("IsUrineTestID");
            entity.Property(e => e.IsVisitPmsma).HasColumnName("IsVisitPMSMA");
            entity.Property(e => e.Lftid).HasColumnName("LFTID");
            entity.Property(e => e.LftserumBilirubin).HasColumnName("LFTSerumBilirubin");
            entity.Property(e => e.Lftsgot).HasColumnName("LFTSGOT");
            entity.Property(e => e.Lftsgpt).HasColumnName("LFTSGPT");
            entity.Property(e => e.MethodUsedId).HasColumnName("MethodUsedID");
            entity.Property(e => e.OdemaResultId).HasColumnName("OdemaResultID");
            entity.Property(e => e.OdemaTestId).HasColumnName("OdemaTestID");
            entity.Property(e => e.OgtttestFirst).HasColumnName("OGTTTestFirst");
            entity.Property(e => e.OgtttestSecond).HasColumnName("OGTTTestSecond");
            entity.Property(e => e.OtherMethod)
                .HasMaxLength(50)
                .IsUnicode(false)
                .UseCollation("SQL_Latin1_General_CP1_CI_AS");
            entity.Property(e => e.PallorId).HasColumnName("PallorID");
            entity.Property(e => e.PersonName)
                .HasMaxLength(100)
                .UseCollation("SQL_Latin1_General_CP1_CI_AS");
            entity.Property(e => e.PlaceNameId).HasColumnName("PlaceNameID");
            entity.Property(e => e.PlaceNameOther)
                .HasMaxLength(50)
                .IsUnicode(false)
                .UseCollation("SQL_Latin1_General_CP1_CI_AS");
            entity.Property(e => e.PostAbortionContracepDetailId).HasColumnName("PostAbortionContracepDetailID");
            entity.Property(e => e.PreferredContraceptivemethodafterdeliveryId).HasColumnName("PreferredContraceptivemethodafterdeliveryID");
            entity.Property(e => e.PwcategoryGuid)
                .HasMaxLength(100)
                .UseCollation("SQL_Latin1_General_CP1_CI_AS")
                .HasColumnName("PWCategoryGUID");
            entity.Property(e => e.PwreferDate)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("PWReferDate");
            entity.Property(e => e.Pwweight)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("PWWeight");
            entity.Property(e => e.Rbstest).HasColumnName("RBSTest");
            entity.Property(e => e.ReferralFacilityId).HasColumnName("ReferralFacilityID");
            entity.Property(e => e.Remarks).UseCollation("SQL_Latin1_General_CP1_CI_AS");
            entity.Property(e => e.RftbloodUrea).HasColumnName("RFTBloodUrea");
            entity.Property(e => e.Rftid).HasColumnName("RFTID");
            entity.Property(e => e.RftserumCreatinine).HasColumnName("RFTSerumCreatinine");
            entity.Property(e => e.SerumFerritinHr).HasColumnName("SerumFerritinHR");
            entity.Property(e => e.StateName).HasMaxLength(250);
            entity.Property(e => e.StoolOvaid).HasColumnName("StoolOVAId");
            entity.Property(e => e.TotalCalciumVd3tab).HasColumnName("TotalCalciumVD3Tab");
            entity.Property(e => e.TotalIfatab).HasColumnName("TotalIFATab");
            entity.Property(e => e.TotalPregnancyWeekId).HasColumnName("TotalPregnancyWeekID");
            entity.Property(e => e.TttddoseDate)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("TTTDDoseDate");
            entity.Property(e => e.TttddoseId).HasColumnName("TTTDDoseID");
            entity.Property(e => e.UpdatedOn).HasColumnType("datetime");
            entity.Property(e => e.UrineAlbuminId).HasColumnName("UrineAlbuminID");
            entity.Property(e => e.UrineAlbuminPus)
                .HasMaxLength(100)
                .IsUnicode(false)
                .UseCollation("SQL_Latin1_General_CP1_CI_AS");
            entity.Property(e => e.UrineCultureHr)
                .HasMaxLength(100)
                .IsUnicode(false)
                .UseCollation("SQL_Latin1_General_CP1_CI_AS")
                .HasColumnName("UrineCultureHR");
            entity.Property(e => e.UrineCultureHrid).HasColumnName("UrineCultureHRId");
            entity.Property(e => e.UrineMicroscopicRbcid).HasColumnName("UrineMicroscopicRBCId");
            entity.Property(e => e.UrinePregTestId).HasColumnName("UrinePregTestID");
            entity.Property(e => e.UrineSugarId).HasColumnName("UrineSugarID");
            entity.Property(e => e.Village)
                .HasMaxLength(150)
                .IsUnicode(false);
            entity.Property(e => e.VillageId).HasColumnName("VillageID");
            entity.Property(e => e.WomanFirstName)
                .HasMaxLength(100)
                .UseCollation("SQL_Latin1_General_CP1_CI_AS");
            entity.Property(e => e.WomanLastName)
                .HasMaxLength(100)
                .UseCollation("SQL_Latin1_General_CP1_CI_AS");
            entity.Property(e => e.WomanMiddleName)
                .HasMaxLength(100)
                .UseCollation("SQL_Latin1_General_CP1_CI_AS");
        });

        modelBuilder.Entity<ViewAnmlist>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("View_ANMList");

            entity.Property(e => e.Anmid).HasColumnName("ANMID");
            entity.Property(e => e.Anmname)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("ANMName");
            entity.Property(e => e.CadreId).HasColumnName("CadreID");
            entity.Property(e => e.CreatedOn).HasColumnType("datetime");
            entity.Property(e => e.EmailId)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("EmailID");
            entity.Property(e => e.FacilityId).HasColumnName("FacilityID");
            entity.Property(e => e.GenderId).HasColumnName("GenderID");
            entity.Property(e => e.MobileNo)
                .HasMaxLength(10)
                .IsUnicode(false);
            entity.Property(e => e.SubFacilityId).HasColumnName("SubFacilityID");
            entity.Property(e => e.UpdatedOn).HasColumnType("datetime");
            entity.Property(e => e.UserId).HasColumnName("UserID");
        });

        modelBuilder.Entity<ViewBeneficaryPrivate>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("View_BeneficaryPrivate");

            entity.Property(e => e.Address).UseCollation("SQL_Latin1_General_CP1_CI_AS");
            entity.Property(e => e.AshaNameId)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("AshaNameID");
            entity.Property(e => e.BeneficeryType)
                .HasMaxLength(3)
                .IsUnicode(false);
            entity.Property(e => e.BeneficiaryGuid)
                .HasMaxLength(50)
                .IsUnicode(false)
                .UseCollation("SQL_Latin1_General_CP1_CI_AS")
                .HasColumnName("BeneficiaryGUID");
            entity.Property(e => e.BeneficiaryId).HasColumnName("BeneficiaryID");
            entity.Property(e => e.BlockId).HasColumnName("BlockID");
            entity.Property(e => e.BlockName).HasMaxLength(255);
            entity.Property(e => e.CasteId).HasColumnName("CasteID");
            entity.Property(e => e.CreatedOn).HasColumnType("datetime");
            entity.Property(e => e.DataSourceId).HasColumnName("DataSourceID");
            entity.Property(e => e.District).HasMaxLength(250);
            entity.Property(e => e.DistrictId).HasColumnName("DistrictID");
            entity.Property(e => e.HealthProviderNameId)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("HealthProviderNameID");
            entity.Property(e => e.HusbandAccountNo)
                .HasMaxLength(100)
                .IsUnicode(false)
                .UseCollation("SQL_Latin1_General_CP1_CI_AS");
            entity.Property(e => e.HusbandAdhaarNo)
                .HasMaxLength(12)
                .IsUnicode(false)
                .UseCollation("SQL_Latin1_General_CP1_CI_AS");
            entity.Property(e => e.HusbandBank)
                .HasMaxLength(150)
                .IsUnicode(false);
            entity.Property(e => e.HusbandBankAvailable)
                .HasMaxLength(3)
                .IsUnicode(false);
            entity.Property(e => e.HusbandDob)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("HusbandDOB");
            entity.Property(e => e.HusbandEducationLevelId).HasColumnName("HusbandEducationLevelID");
            entity.Property(e => e.HusbandEducationLevelOther)
                .HasMaxLength(100)
                .UseCollation("SQL_Latin1_General_CP1_CI_AS");
            entity.Property(e => e.HusbandName)
                .HasMaxLength(302)
                .UseCollation("SQL_Latin1_General_CP1_CI_AS");
            entity.Property(e => e.HusbandOccupationId).HasColumnName("HusbandOccupationID");
            entity.Property(e => e.HusbandOccupationOther)
                .HasMaxLength(100)
                .UseCollation("SQL_Latin1_General_CP1_CI_AS");
            entity.Property(e => e.IsHusbandAdhaarBankLinkedId).HasColumnName("IsHusbandAdhaarBankLinkedID");
            entity.Property(e => e.IsHusbandCurrentAgeId)
                .HasMaxLength(3)
                .IsUnicode(false)
                .HasColumnName("IsHusbandCurrentAgeID");
            entity.Property(e => e.IsHusbandDobid).HasColumnName("IsHusbandDOBID");
            entity.Property(e => e.IsWomanAdhaarBankLinkedId).HasColumnName("IsWomanAdhaarBankLinkedID");
            entity.Property(e => e.IsWomanCurrentAgeId)
                .HasMaxLength(3)
                .IsUnicode(false)
                .HasColumnName("IsWomanCurrentAgeID");
            entity.Property(e => e.IsWomanDobid).HasColumnName("IsWomanDOBID");
            entity.Property(e => e.Lb).HasColumnName("LB");
            entity.Property(e => e.Ld).HasColumnName("LD");
            entity.Property(e => e.Ls).HasColumnName("LS");
            entity.Property(e => e.MobileNo)
                .HasMaxLength(10)
                .IsUnicode(false)
                .UseCollation("SQL_Latin1_General_CP1_CI_AS");
            entity.Property(e => e.MobileNoOwnerId).HasColumnName("MobileNoOwnerID");
            entity.Property(e => e.Name)
                .HasMaxLength(302)
                .UseCollation("SQL_Latin1_General_CP1_CI_AS");
            entity.Property(e => e.PovertyCategoryId).HasColumnName("PovertyCategoryID");
            entity.Property(e => e.Rchid)
                .HasMaxLength(50)
                .IsUnicode(false)
                .UseCollation("SQL_Latin1_General_CP1_CI_AS")
                .HasColumnName("RCHID");
            entity.Property(e => e.RegistrationDate)
                .HasMaxLength(30)
                .IsUnicode(false);
            entity.Property(e => e.ReligionId).HasColumnName("ReligionID");
            entity.Property(e => e.RoleId).HasColumnName("RoleID");
            entity.Property(e => e.StateName).HasMaxLength(250);
            entity.Property(e => e.UpdatedOn).HasColumnType("datetime");
            entity.Property(e => e.UserName)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.VillageId).HasColumnName("VillageID");
            entity.Property(e => e.WomanAccountNo)
                .HasMaxLength(100)
                .IsUnicode(false)
                .UseCollation("SQL_Latin1_General_CP1_CI_AS");
            entity.Property(e => e.WomanAdhaarNo)
                .HasMaxLength(12)
                .IsUnicode(false)
                .UseCollation("SQL_Latin1_General_CP1_CI_AS");
            entity.Property(e => e.WomanBankAvailable)
                .HasMaxLength(3)
                .IsUnicode(false);
            entity.Property(e => e.WomanDob)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("WomanDOB");
            entity.Property(e => e.WomanEducationLevelId).HasColumnName("WomanEducationLevelID");
            entity.Property(e => e.WomanEducationLevelOther)
                .HasMaxLength(100)
                .UseCollation("SQL_Latin1_General_CP1_CI_AS");
            entity.Property(e => e.WomanOccupationId).HasColumnName("WomanOccupationID");
            entity.Property(e => e.WomanOccupationOther)
                .HasMaxLength(100)
                .UseCollation("SQL_Latin1_General_CP1_CI_AS");
            entity.Property(e => e.WomenBank)
                .HasMaxLength(150)
                .IsUnicode(false);
            entity.Property(e => e.YoungChildAgeMonthId).HasColumnName("YoungChildAgeMonthID");
            entity.Property(e => e.YoungChildAgeYearId).HasColumnName("YoungChildAgeYearID");
            entity.Property(e => e.YoungChildGenderId).HasColumnName("YoungChildGenderID");
        });

        modelBuilder.Entity<ViewBeneficiary>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("View_Beneficiary");

            entity.Property(e => e.Address).UseCollation("SQL_Latin1_General_CP1_CI_AS");
            entity.Property(e => e.AshaNameId)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("AshaNameID");
            entity.Property(e => e.BeneficeryType)
                .HasMaxLength(3)
                .IsUnicode(false);
            entity.Property(e => e.BeneficiaryGuid)
                .HasMaxLength(50)
                .IsUnicode(false)
                .UseCollation("SQL_Latin1_General_CP1_CI_AS")
                .HasColumnName("BeneficiaryGUID");
            entity.Property(e => e.BeneficiaryId).HasColumnName("BeneficiaryID");
            entity.Property(e => e.BlockId).HasColumnName("BlockID");
            entity.Property(e => e.BlockName).HasMaxLength(255);
            entity.Property(e => e.CasteId).HasColumnName("CasteID");
            entity.Property(e => e.CreatedOn).HasColumnType("datetime");
            entity.Property(e => e.DataSourceId).HasColumnName("DataSourceID");
            entity.Property(e => e.District).HasMaxLength(250);
            entity.Property(e => e.DistrictId).HasColumnName("DistrictID");
            entity.Property(e => e.HealthProviderNameId)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("HealthProviderNameID");
            entity.Property(e => e.HusbandAccountNo)
                .HasMaxLength(100)
                .IsUnicode(false)
                .UseCollation("SQL_Latin1_General_CP1_CI_AS");
            entity.Property(e => e.HusbandAdhaarNo)
                .HasMaxLength(12)
                .IsUnicode(false)
                .UseCollation("SQL_Latin1_General_CP1_CI_AS");
            entity.Property(e => e.HusbandBank)
                .HasMaxLength(150)
                .IsUnicode(false);
            entity.Property(e => e.HusbandBankAvailable)
                .HasMaxLength(3)
                .IsUnicode(false);
            entity.Property(e => e.HusbandDob)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("HusbandDOB");
            entity.Property(e => e.HusbandEducationLevelId).HasColumnName("HusbandEducationLevelID");
            entity.Property(e => e.HusbandEducationLevelOther)
                .HasMaxLength(100)
                .UseCollation("SQL_Latin1_General_CP1_CI_AS");
            entity.Property(e => e.HusbandName)
                .HasMaxLength(302)
                .UseCollation("SQL_Latin1_General_CP1_CI_AS");
            entity.Property(e => e.HusbandOccupationId).HasColumnName("HusbandOccupationID");
            entity.Property(e => e.HusbandOccupationOther)
                .HasMaxLength(100)
                .UseCollation("SQL_Latin1_General_CP1_CI_AS");
            entity.Property(e => e.IsHusbandAdhaarBankLinkedId).HasColumnName("IsHusbandAdhaarBankLinkedID");
            entity.Property(e => e.IsHusbandCurrentAgeId)
                .HasMaxLength(3)
                .IsUnicode(false)
                .HasColumnName("IsHusbandCurrentAgeID");
            entity.Property(e => e.IsHusbandDobid).HasColumnName("IsHusbandDOBID");
            entity.Property(e => e.IsWomanAdhaarBankLinkedId).HasColumnName("IsWomanAdhaarBankLinkedID");
            entity.Property(e => e.IsWomanCurrentAgeId)
                .HasMaxLength(3)
                .IsUnicode(false)
                .HasColumnName("IsWomanCurrentAgeID");
            entity.Property(e => e.IsWomanDobid).HasColumnName("IsWomanDOBID");
            entity.Property(e => e.Lb).HasColumnName("LB");
            entity.Property(e => e.Ld).HasColumnName("LD");
            entity.Property(e => e.Ls).HasColumnName("LS");
            entity.Property(e => e.MobileNo)
                .HasMaxLength(10)
                .IsUnicode(false)
                .UseCollation("SQL_Latin1_General_CP1_CI_AS");
            entity.Property(e => e.MobileNoOwnerId).HasColumnName("MobileNoOwnerID");
            entity.Property(e => e.Name)
                .HasMaxLength(302)
                .UseCollation("SQL_Latin1_General_CP1_CI_AS");
            entity.Property(e => e.PovertyCategoryId).HasColumnName("PovertyCategoryID");
            entity.Property(e => e.Rchid)
                .HasMaxLength(50)
                .IsUnicode(false)
                .UseCollation("SQL_Latin1_General_CP1_CI_AS")
                .HasColumnName("RCHID");
            entity.Property(e => e.RegistrationDate)
                .HasMaxLength(30)
                .IsUnicode(false);
            entity.Property(e => e.ReligionId).HasColumnName("ReligionID");
            entity.Property(e => e.RoleId).HasColumnName("RoleID");
            entity.Property(e => e.StateName).HasMaxLength(250);
            entity.Property(e => e.UpdatedOn).HasColumnType("datetime");
            entity.Property(e => e.UserName)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.Village)
                .HasMaxLength(150)
                .IsUnicode(false);
            entity.Property(e => e.VillageId).HasColumnName("VillageID");
            entity.Property(e => e.WomanAccountNo)
                .HasMaxLength(100)
                .IsUnicode(false)
                .UseCollation("SQL_Latin1_General_CP1_CI_AS");
            entity.Property(e => e.WomanAdhaarNo)
                .HasMaxLength(12)
                .IsUnicode(false)
                .UseCollation("SQL_Latin1_General_CP1_CI_AS");
            entity.Property(e => e.WomanBankAvailable)
                .HasMaxLength(3)
                .IsUnicode(false);
            entity.Property(e => e.WomanDob)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("WomanDOB");
            entity.Property(e => e.WomanEducationLevelId).HasColumnName("WomanEducationLevelID");
            entity.Property(e => e.WomanEducationLevelOther)
                .HasMaxLength(100)
                .UseCollation("SQL_Latin1_General_CP1_CI_AS");
            entity.Property(e => e.WomanOccupationId).HasColumnName("WomanOccupationID");
            entity.Property(e => e.WomanOccupationOther)
                .HasMaxLength(100)
                .UseCollation("SQL_Latin1_General_CP1_CI_AS");
            entity.Property(e => e.WomenBank)
                .HasMaxLength(150)
                .IsUnicode(false);
            entity.Property(e => e.YoungChildAgeMonthId).HasColumnName("YoungChildAgeMonthID");
            entity.Property(e => e.YoungChildAgeYearId).HasColumnName("YoungChildAgeYearID");
            entity.Property(e => e.YoungChildGenderId).HasColumnName("YoungChildGenderID");
        });

        modelBuilder.Entity<ViewBlockWiseFilterDatum>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("View_BlockWiseFilterData");

            entity.Property(e => e.BlockId).HasColumnName("BlockID");
            entity.Property(e => e.BlockName).HasMaxLength(255);
            entity.Property(e => e.DistrictId).HasColumnName("DistrictID");
        });

        modelBuilder.Entity<ViewCaseDischargeReportPdf>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("View_case_discharge_report_pdf");

            entity.Property(e => e.Add)
                .HasMaxLength(50)
                .UseCollation("SQL_Latin1_General_CP1_CI_AS")
                .HasColumnName("add");
            entity.Property(e => e.AdmTime)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("adm_time");
            entity.Property(e => e.Age).HasColumnName("age");
            entity.Property(e => e.AsmanCode)
                .HasMaxLength(22)
                .UseCollation("SQL_Latin1_General_CP1_CI_AS")
                .HasColumnName("asman_code");
            entity.Property(e => e.Baby1Comp)
                .HasMaxLength(255)
                .HasColumnName("baby1_comp");
            entity.Property(e => e.Baby1CompItems)
                .HasMaxLength(200)
                .UseCollation("SQL_Latin1_General_CP1_CI_AS")
                .HasColumnName("baby1_comp_items");
            entity.Property(e => e.Baby1CompOthr)
                .HasMaxLength(100)
                .UseCollation("SQL_Latin1_General_CP1_CI_AS")
                .HasColumnName("baby1_comp_othr");
            entity.Property(e => e.Baby1DelPlace)
                .HasMaxLength(255)
                .HasColumnName("baby1_del_place");
            entity.Property(e => e.Baby1RefToSncu)
                .HasMaxLength(255)
                .HasColumnName("baby1_ref_to_sncu");
            entity.Property(e => e.Baby1RefToSncuItems)
                .HasMaxLength(200)
                .UseCollation("SQL_Latin1_General_CP1_CI_AS")
                .HasColumnName("baby1_ref_to_sncu_items");
            entity.Property(e => e.Baby1RefToSncuOthr)
                .HasMaxLength(100)
                .UseCollation("SQL_Latin1_General_CP1_CI_AS")
                .HasColumnName("baby1_ref_to_sncu_othr");
            entity.Property(e => e.Baby1Temp)
                .HasColumnType("decimal(5, 2)")
                .HasColumnName("baby1_temp");
            entity.Property(e => e.Baby1ToInstitutionId).HasColumnName("baby1_to_institution_id");
            entity.Property(e => e.Baby1ToInstitutionOther)
                .HasMaxLength(255)
                .UseCollation("SQL_Latin1_General_CP1_CI_AS")
                .HasColumnName("baby1_to_institution_other");
            entity.Property(e => e.Baby1WeightGm)
                .HasMaxLength(5)
                .UseCollation("SQL_Latin1_General_CP1_CI_AS")
                .HasColumnName("baby1_weight_gm");
            entity.Property(e => e.Baby2Comp)
                .HasMaxLength(255)
                .HasColumnName("baby2_comp");
            entity.Property(e => e.Baby2CompItems)
                .HasMaxLength(200)
                .UseCollation("SQL_Latin1_General_CP1_CI_AS")
                .HasColumnName("baby2_comp_items");
            entity.Property(e => e.Baby2CompOthr)
                .HasMaxLength(100)
                .UseCollation("SQL_Latin1_General_CP1_CI_AS")
                .HasColumnName("baby2_comp_othr");
            entity.Property(e => e.Baby2DelPlace)
                .HasMaxLength(255)
                .HasColumnName("baby2_del_place");
            entity.Property(e => e.Baby2RefToSncu)
                .HasMaxLength(255)
                .HasColumnName("baby2_ref_to_sncu");
            entity.Property(e => e.Baby2RefToSncuItems)
                .HasMaxLength(200)
                .UseCollation("SQL_Latin1_General_CP1_CI_AS")
                .HasColumnName("baby2_ref_to_sncu_items");
            entity.Property(e => e.Baby2RefToSncuOthr)
                .HasMaxLength(100)
                .UseCollation("SQL_Latin1_General_CP1_CI_AS")
                .HasColumnName("baby2_ref_to_sncu_othr");
            entity.Property(e => e.Baby2Temp)
                .HasColumnType("decimal(5, 2)")
                .HasColumnName("baby2_temp");
            entity.Property(e => e.Baby2ToInstitutionId).HasColumnName("baby2_to_institution_id");
            entity.Property(e => e.Baby2ToInstitutionOther)
                .HasMaxLength(255)
                .UseCollation("SQL_Latin1_General_CP1_CI_AS")
                .HasColumnName("baby2_to_institution_other");
            entity.Property(e => e.Baby2WeightGm)
                .HasMaxLength(5)
                .UseCollation("SQL_Latin1_General_CP1_CI_AS")
                .HasColumnName("baby2_weight_gm");
            entity.Property(e => e.Baby3Comp)
                .HasMaxLength(255)
                .HasColumnName("baby3_comp");
            entity.Property(e => e.Baby3CompItems)
                .HasMaxLength(200)
                .UseCollation("SQL_Latin1_General_CP1_CI_AS")
                .HasColumnName("baby3_comp_items");
            entity.Property(e => e.Baby3CompOthr)
                .HasMaxLength(100)
                .UseCollation("SQL_Latin1_General_CP1_CI_AS")
                .HasColumnName("baby3_comp_othr");
            entity.Property(e => e.Baby3DelPlace)
                .HasMaxLength(255)
                .HasColumnName("baby3_del_place");
            entity.Property(e => e.Baby3RefToSncu)
                .HasMaxLength(255)
                .HasColumnName("baby3_ref_to_sncu");
            entity.Property(e => e.Baby3RefToSncuItems)
                .HasMaxLength(200)
                .UseCollation("SQL_Latin1_General_CP1_CI_AS")
                .HasColumnName("baby3_ref_to_sncu_items");
            entity.Property(e => e.Baby3RefToSncuOthr)
                .HasMaxLength(100)
                .UseCollation("SQL_Latin1_General_CP1_CI_AS")
                .HasColumnName("baby3_ref_to_sncu_othr");
            entity.Property(e => e.Baby3Temp)
                .HasColumnType("decimal(5, 2)")
                .HasColumnName("baby3_temp");
            entity.Property(e => e.Baby3ToInstitutionId).HasColumnName("baby3_to_institution_id");
            entity.Property(e => e.Baby3ToInstitutionOther)
                .HasMaxLength(255)
                .UseCollation("SQL_Latin1_General_CP1_CI_AS")
                .HasColumnName("baby3_to_institution_other");
            entity.Property(e => e.Baby3WeightGm)
                .HasMaxLength(5)
                .UseCollation("SQL_Latin1_General_CP1_CI_AS")
                .HasColumnName("baby3_weight_gm");
            entity.Property(e => e.Baby4Comp)
                .HasMaxLength(255)
                .HasColumnName("baby4_comp");
            entity.Property(e => e.Baby4CompItems)
                .HasMaxLength(200)
                .UseCollation("SQL_Latin1_General_CP1_CI_AS")
                .HasColumnName("baby4_comp_items");
            entity.Property(e => e.Baby4CompOthr)
                .HasMaxLength(100)
                .UseCollation("SQL_Latin1_General_CP1_CI_AS")
                .HasColumnName("baby4_comp_othr");
            entity.Property(e => e.Baby4DelPlace)
                .HasMaxLength(255)
                .HasColumnName("baby4_del_place");
            entity.Property(e => e.Baby4RefToSncu)
                .HasMaxLength(255)
                .HasColumnName("baby4_ref_to_sncu");
            entity.Property(e => e.Baby4RefToSncuItems)
                .HasMaxLength(200)
                .UseCollation("SQL_Latin1_General_CP1_CI_AS")
                .HasColumnName("baby4_ref_to_sncu_items");
            entity.Property(e => e.Baby4RefToSncuOthr)
                .HasMaxLength(100)
                .UseCollation("SQL_Latin1_General_CP1_CI_AS")
                .HasColumnName("baby4_ref_to_sncu_othr");
            entity.Property(e => e.Baby4Temp)
                .HasColumnType("decimal(5, 2)")
                .HasColumnName("baby4_temp");
            entity.Property(e => e.Baby4ToInstitutionId).HasColumnName("baby4_to_institution_id");
            entity.Property(e => e.Baby4ToInstitutionOther)
                .HasMaxLength(255)
                .UseCollation("SQL_Latin1_General_CP1_CI_AS")
                .HasColumnName("baby4_to_institution_other");
            entity.Property(e => e.Baby4WeightGm)
                .HasMaxLength(5)
                .UseCollation("SQL_Latin1_General_CP1_CI_AS")
                .HasColumnName("baby4_weight_gm");
            entity.Property(e => e.BabyKitProvide)
                .HasMaxLength(3)
                .IsUnicode(false);
            entity.Property(e => e.Bg)
                .HasMaxLength(255)
                .HasColumnName("bg");
            entity.Property(e => e.Birth1CertGiven)
                .HasMaxLength(255)
                .HasColumnName("Birth1_cert_given");
            entity.Property(e => e.Birth2CertGiven)
                .HasMaxLength(255)
                .HasColumnName("Birth2_cert_given");
            entity.Property(e => e.Birth3CertGiven)
                .HasMaxLength(255)
                .HasColumnName("Birth3_cert_given");
            entity.Property(e => e.Birth4CertGiven)
                .HasMaxLength(255)
                .HasColumnName("Birth4_cert_given");
            entity.Property(e => e.BirthDefects1)
                .HasMaxLength(255)
                .HasColumnName("birth_defects1");
            entity.Property(e => e.BirthDefects2)
                .HasMaxLength(255)
                .HasColumnName("birth_defects2");
            entity.Property(e => e.BirthDefects3)
                .HasMaxLength(255)
                .HasColumnName("birth_defects3");
            entity.Property(e => e.BirthDefects4)
                .HasMaxLength(255)
                .HasColumnName("birth_defects4");
            entity.Property(e => e.BirthDefectsItems1).HasColumnName("birth_defects_items1");
            entity.Property(e => e.BirthDefectsItems2).HasColumnName("birth_defects_items2");
            entity.Property(e => e.BirthDefectsItems3).HasColumnName("birth_defects_items3");
            entity.Property(e => e.BirthDefectsItems4).HasColumnName("birth_defects_items4");
            entity.Property(e => e.BirthDefectsOthr1)
                .HasMaxLength(150)
                .UseCollation("SQL_Latin1_General_CP1_CI_AS")
                .HasColumnName("birth_defects_othr1");
            entity.Property(e => e.BirthDefectsOthr2)
                .HasMaxLength(150)
                .UseCollation("SQL_Latin1_General_CP1_CI_AS")
                .HasColumnName("birth_defects_othr2");
            entity.Property(e => e.BirthDefectsOthr3)
                .HasMaxLength(150)
                .UseCollation("SQL_Latin1_General_CP1_CI_AS")
                .HasColumnName("birth_defects_othr3");
            entity.Property(e => e.BirthDefectsOthr4)
                .HasMaxLength(150)
                .UseCollation("SQL_Latin1_General_CP1_CI_AS")
                .HasColumnName("birth_defects_othr4");
            entity.Property(e => e.BirthGirlCmMsg)
                .HasMaxLength(255)
                .HasColumnName("birth_girl_cm_msg");
            entity.Property(e => e.BloodTrans)
                .HasMaxLength(255)
                .HasColumnName("blood_trans");
            entity.Property(e => e.BloodTransType).HasColumnName("blood_trans_type");
            entity.Property(e => e.BloodTransUnitts)
                .HasMaxLength(200)
                .UseCollation("SQL_Latin1_General_CP1_CI_AS")
                .HasColumnName("blood_trans_unitts");
            entity.Property(e => e.BpMax).HasColumnName("bp_max");
            entity.Property(e => e.BpMin).HasColumnName("bp_min");
            entity.Property(e => e.BplDesiGheeCoupon)
                .HasMaxLength(255)
                .HasColumnName("bpl_desi_ghee_coupon");
            entity.Property(e => e.Breast1FeedInitiated)
                .HasMaxLength(255)
                .HasColumnName("breast1_feed_initiated");
            entity.Property(e => e.Breast2FeedInitiated)
                .HasMaxLength(255)
                .HasColumnName("breast2_feed_initiated");
            entity.Property(e => e.Breast3FeedInitiated)
                .HasMaxLength(255)
                .HasColumnName("breast3_feed_initiated");
            entity.Property(e => e.Breast4FeedInitiated)
                .HasMaxLength(255)
                .HasColumnName("breast4_feed_initiated");
            entity.Property(e => e.BsOgtt)
                .HasMaxLength(20)
                .UseCollation("SQL_Latin1_General_CP1_CI_AS")
                .HasColumnName("bs_ogtt");
            entity.Property(e => e.BsRan)
                .HasMaxLength(20)
                .UseCollation("SQL_Latin1_General_CP1_CI_AS")
                .HasColumnName("bs_ran");
            entity.Property(e => e.CaseId).HasColumnName("case_id");
            entity.Property(e => e.CaseName)
                .HasMaxLength(50)
                .UseCollation("SQL_Latin1_General_CP1_CI_AS")
                .HasColumnName("case_name");
            entity.Property(e => e.CauseOfCesarean1)
                .HasMaxLength(200)
                .UseCollation("SQL_Latin1_General_CP1_CI_AS")
                .HasColumnName("cause_of_cesarean1");
            entity.Property(e => e.CauseOfCesarean2)
                .HasMaxLength(200)
                .UseCollation("SQL_Latin1_General_CP1_CI_AS")
                .HasColumnName("cause_of_cesarean2");
            entity.Property(e => e.CauseOfCesarean3)
                .HasMaxLength(200)
                .UseCollation("SQL_Latin1_General_CP1_CI_AS")
                .HasColumnName("cause_of_cesarean3");
            entity.Property(e => e.CauseOfCesarean4)
                .HasMaxLength(200)
                .UseCollation("SQL_Latin1_General_CP1_CI_AS")
                .HasColumnName("cause_of_cesarean4");
            entity.Property(e => e.Complications).HasColumnName("complications");
            entity.Property(e => e.Condom)
                .HasMaxLength(255)
                .HasColumnName("condom");
            entity.Property(e => e.CounsDangerSigns)
                .HasMaxLength(255)
                .HasColumnName("couns_danger_signs");
            entity.Property(e => e.DateOfAdmission)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("date_of_admission");
            entity.Property(e => e.DateOfDelivery1)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("date_of_delivery1");
            entity.Property(e => e.DeliveryPlace1)
                .HasMaxLength(8)
                .IsUnicode(false);
            entity.Property(e => e.DischargeTime)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("discharge_time");
            entity.Property(e => e.DischargeType)
                .HasMaxLength(255)
                .HasColumnName("discharge_type");
            entity.Property(e => e.DisplayOrder).HasColumnName("display_order");
            entity.Property(e => e.District)
                .HasMaxLength(150)
                .UseCollation("SQL_Latin1_General_CP1_CI_AS")
                .HasColumnName("district");
            entity.Property(e => e.Do)
                .HasMaxLength(50)
                .UseCollation("SQL_Latin1_General_CP1_CI_AS")
                .HasColumnName("do");
            entity.Property(e => e.DurOfGestation)
                .HasMaxLength(6)
                .UseCollation("SQL_Latin1_General_CP1_CI_AS")
                .HasColumnName("dur_of_gestation");
            entity.Property(e => e.FollowUpTime)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("follow_up_time");
            entity.Property(e => e.FoodService)
                .HasMaxLength(255)
                .HasColumnName("food_service");
            entity.Property(e => e.FoodServiceDays)
                .HasMaxLength(255)
                .HasColumnName("food_service_days");
            entity.Property(e => e.Hbsag)
                .HasMaxLength(255)
                .HasColumnName("hbsag");
            entity.Property(e => e.Hiv)
                .HasMaxLength(255)
                .HasColumnName("hiv");
            entity.Property(e => e.Injectable)
                .HasMaxLength(255)
                .HasColumnName("injectable");
            entity.Property(e => e.InstitutionName)
                .HasMaxLength(150)
                .UseCollation("SQL_Latin1_General_CP1_CI_AS")
                .HasColumnName("institution_name");
            entity.Property(e => e.IpdNo)
                .HasMaxLength(20)
                .UseCollation("SQL_Latin1_General_CP1_CI_AS")
                .HasColumnName("ipd_no");
            entity.Property(e => e.IpdNoCase)
                .HasMaxLength(20)
                .UseCollation("SQL_Latin1_General_CP1_CI_AS")
                .HasColumnName("ipd_no_case");
            entity.Property(e => e.IsRefBaby1).HasColumnName("is_ref_baby1");
            entity.Property(e => e.IsRefBaby2).HasColumnName("is_ref_baby2");
            entity.Property(e => e.IsRefBaby3).HasColumnName("is_ref_baby3");
            entity.Property(e => e.IsRefBaby4).HasColumnName("is_ref_baby4");
            entity.Property(e => e.IsRefMother).HasColumnName("is_ref_mother");
            entity.Property(e => e.Lam)
                .HasMaxLength(255)
                .HasColumnName("lam");
            entity.Property(e => e.LbrRegNo)
                .HasMaxLength(20)
                .UseCollation("SQL_Latin1_General_CP1_CI_AS")
                .HasColumnName("lbr_reg_no");
            entity.Property(e => e.MTemp)
                .HasColumnType("decimal(5, 2)")
                .HasColumnName("m_temp");
            entity.Property(e => e.MotherAliveDischarge)
                .HasMaxLength(3)
                .IsUnicode(false);
            entity.Property(e => e.MotherComp)
                .HasMaxLength(255)
                .HasColumnName("mother_comp");
            entity.Property(e => e.MotherCompItems)
                .HasMaxLength(200)
                .UseCollation("SQL_Latin1_General_CP1_CI_AS")
                .HasColumnName("mother_comp_items");
            entity.Property(e => e.MotherCompOthr)
                .HasMaxLength(100)
                .UseCollation("SQL_Latin1_General_CP1_CI_AS")
                .HasColumnName("mother_comp_othr");
            entity.Property(e => e.MotherCottageWard)
                .HasMaxLength(3)
                .IsUnicode(false);
            entity.Property(e => e.NoOfDeliveries)
                .HasMaxLength(255)
                .HasColumnName("no_of_deliveries");
            entity.Property(e => e.OdNo)
                .HasMaxLength(20)
                .UseCollation("SQL_Latin1_General_CP1_CI_AS")
                .HasColumnName("od_no");
            entity.Property(e => e.OutcomeOfDelivery1)
                .HasMaxLength(255)
                .HasColumnName("outcome_of_delivery1");
            entity.Property(e => e.OutcomeOfDelivery2)
                .HasMaxLength(255)
                .HasColumnName("outcome_of_delivery2");
            entity.Property(e => e.OutcomeOfDelivery3)
                .HasMaxLength(255)
                .HasColumnName("outcome_of_delivery3");
            entity.Property(e => e.OutcomeOfDelivery4)
                .HasMaxLength(255)
                .HasColumnName("outcome_of_delivery4");
            entity.Property(e => e.PctsRchNo)
                .HasMaxLength(255)
                .UseCollation("SQL_Latin1_General_CP1_CI_AS")
                .HasColumnName("pcts_rch_no");
            entity.Property(e => e.PdHemoglobin).HasColumnName("pd_hemoglobin");
            entity.Property(e => e.PpiucdInserted)
                .HasMaxLength(255)
                .HasColumnName("ppiucd_inserted");
            entity.Property(e => e.PpiucdInsertedNameHlthWrkr)
                .HasMaxLength(50)
                .UseCollation("SQL_Latin1_General_CP1_CI_AS")
                .HasColumnName("ppiucd_inserted_name_hlth_wrkr");
            entity.Property(e => e.PpiucdInsertedTime)
                .HasMaxLength(13)
                .IsUnicode(false)
                .HasColumnName("ppiucd_inserted_time");
            entity.Property(e => e.PptPpsTime)
                .HasColumnType("smalldatetime")
                .HasColumnName("ppt_pps_time");
            entity.Property(e => e.PptctWasGiven1)
                .HasMaxLength(255)
                .HasColumnName("pptct_was_given1");
            entity.Property(e => e.PptctWasGiven2)
                .HasMaxLength(255)
                .HasColumnName("pptct_was_given2");
            entity.Property(e => e.PptctWasGiven3)
                .HasMaxLength(255)
                .HasColumnName("pptct_was_given3");
            entity.Property(e => e.PptctWasGiven4)
                .HasMaxLength(255)
                .HasColumnName("pptct_was_given4");
            entity.Property(e => e.ProvisionVehicle)
                .HasMaxLength(255)
                .HasColumnName("provision_vehicle");
            entity.Property(e => e.RefOutFinishTime)
                .HasPrecision(0)
                .HasColumnName("ref_out_finish_time");
            entity.Property(e => e.RefReasonBaby1)
                .UseCollation("SQL_Latin1_General_CP1_CI_AS")
                .HasColumnName("ref_reason_baby1");
            entity.Property(e => e.RefReasonBaby2)
                .UseCollation("SQL_Latin1_General_CP1_CI_AS")
                .HasColumnName("ref_reason_baby2");
            entity.Property(e => e.RefReasonBaby3)
                .UseCollation("SQL_Latin1_General_CP1_CI_AS")
                .HasColumnName("ref_reason_baby3");
            entity.Property(e => e.RefReasonBaby4)
                .UseCollation("SQL_Latin1_General_CP1_CI_AS")
                .HasColumnName("ref_reason_baby4");
            entity.Property(e => e.ServDesig)
                .HasMaxLength(50)
                .UseCollation("SQL_Latin1_General_CP1_CI_AS")
                .HasColumnName("serv_desig");
            entity.Property(e => e.ServId).HasColumnName("serv_id");
            entity.Property(e => e.ServName)
                .HasMaxLength(50)
                .UseCollation("SQL_Latin1_General_CP1_CI_AS")
                .HasColumnName("serv_name");
            entity.Property(e => e.ServPhone)
                .HasMaxLength(15)
                .UseCollation("SQL_Latin1_General_CP1_CI_AS")
                .HasColumnName("serv_phone");
            entity.Property(e => e.SexOfBaby1)
                .HasMaxLength(255)
                .HasColumnName("sex_of_baby1");
            entity.Property(e => e.SexOfBaby2)
                .HasMaxLength(255)
                .HasColumnName("sex_of_baby2");
            entity.Property(e => e.SexOfBaby3)
                .HasMaxLength(255)
                .HasColumnName("sex_of_baby3");
            entity.Property(e => e.SexOfBaby4)
                .HasMaxLength(255)
                .HasColumnName("sex_of_baby4");
            entity.Property(e => e.Still1BirthType).HasColumnName("still1_birth_type");
            entity.Property(e => e.Still2BirthType).HasColumnName("still2_birth_type");
            entity.Property(e => e.Still3BirthType).HasColumnName("still3_birth_type");
            entity.Property(e => e.Still4BirthType).HasColumnName("still4_birth_type");
            entity.Property(e => e.ThyroidT3)
                .HasMaxLength(20)
                .UseCollation("SQL_Latin1_General_CP1_CI_AS")
                .HasColumnName("thyroid_t3");
            entity.Property(e => e.ThyroidT4)
                .HasMaxLength(20)
                .UseCollation("SQL_Latin1_General_CP1_CI_AS")
                .HasColumnName("thyroid_t4");
            entity.Property(e => e.ThyroidTsh)
                .HasMaxLength(20)
                .UseCollation("SQL_Latin1_General_CP1_CI_AS")
                .HasColumnName("thyroid_tsh");
            entity.Property(e => e.TimeOfDelivery1)
                .HasMaxLength(15)
                .IsUnicode(false)
                .HasColumnName("time_of_delivery1");
            entity.Property(e => e.TimeOfDelivery2)
                .HasPrecision(0)
                .HasColumnName("time_of_delivery2");
            entity.Property(e => e.TimeOfDelivery3)
                .HasPrecision(0)
                .HasColumnName("time_of_delivery3");
            entity.Property(e => e.TimeOfDelivery4)
                .HasPrecision(0)
                .HasColumnName("time_of_delivery4");
            entity.Property(e => e.TreatAdvised).HasColumnName("treat_advised");
            entity.Property(e => e.TreatAdvisedOthr)
                .UseCollation("SQL_Latin1_General_CP1_CI_AS")
                .HasColumnName("treat_advised_othr");
            entity.Property(e => e.TypeOfAssisDel1).HasColumnName("type_of_assis_del1");
            entity.Property(e => e.TypeOfAssisDel2).HasColumnName("type_of_assis_del2");
            entity.Property(e => e.TypeOfAssisDel3).HasColumnName("type_of_assis_del3");
            entity.Property(e => e.TypeOfAssisDel4).HasColumnName("type_of_assis_del4");
            entity.Property(e => e.TypeOfDelivery1)
                .HasMaxLength(255)
                .HasColumnName("type_of_delivery1");
            entity.Property(e => e.TypeOfDelivery2)
                .HasMaxLength(255)
                .HasColumnName("type_of_delivery2");
            entity.Property(e => e.TypeOfDelivery3)
                .HasMaxLength(255)
                .HasColumnName("type_of_delivery3");
            entity.Property(e => e.TypeOfDelivery4)
                .HasMaxLength(255)
                .HasColumnName("type_of_delivery4");
            entity.Property(e => e.UrineAlb)
                .HasMaxLength(255)
                .HasColumnName("urine_alb");
            entity.Property(e => e.UrineAnalysis).HasColumnName("urine_analysis");
            entity.Property(e => e.UrineCreatinine)
                .HasMaxLength(100)
                .UseCollation("SQL_Latin1_General_CP1_CI_AS")
                .HasColumnName("urine_creatinine");
            entity.Property(e => e.UrineOther)
                .HasMaxLength(100)
                .UseCollation("SQL_Latin1_General_CP1_CI_AS")
                .HasColumnName("urine_other");
            entity.Property(e => e.UrineSugar).HasColumnName("urine_sugar");
            entity.Property(e => e.VaccinationOfBaby1).HasColumnName("vaccination_of_baby1");
            entity.Property(e => e.VaccinationOfBaby2).HasColumnName("vaccination_of_baby2");
            entity.Property(e => e.VaccinationOfBaby3).HasColumnName("vaccination_of_baby3");
            entity.Property(e => e.VaccinationOfBaby4).HasColumnName("vaccination_of_baby4");
            entity.Property(e => e.VdrlRpr)
                .HasMaxLength(255)
                .HasColumnName("vdrl_rpr");
            entity.Property(e => e.VitK1Dose1)
                .HasMaxLength(255)
                .HasColumnName("vit_k1_dose1");
            entity.Property(e => e.VitK1Dose2)
                .HasMaxLength(255)
                .HasColumnName("vit_k1_dose2");
            entity.Property(e => e.VitK1Dose3)
                .HasMaxLength(255)
                .HasColumnName("vit_k1_dose3");
            entity.Property(e => e.VitK1Dose4)
                .HasMaxLength(255)
                .HasColumnName("vit_k1_dose4");
            entity.Property(e => e.Wo)
                .HasMaxLength(50)
                .UseCollation("SQL_Latin1_General_CP1_CI_AS")
                .HasColumnName("wo");
        });

        modelBuilder.Entity<ViewChildRegistration>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("View_ChildRegistration");

            entity.Property(e => e.AdhaarNo)
                .HasMaxLength(50)
                .IsUnicode(false)
                .UseCollation("SQL_Latin1_General_CP1_CI_AS");
            entity.Property(e => e.Asha)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.BeneficiaryGuid)
                .HasMaxLength(50)
                .IsUnicode(false)
                .UseCollation("SQL_Latin1_General_CP1_CI_AS")
                .HasColumnName("BeneficiaryGUID");
            entity.Property(e => e.BirthCertifiNo)
                .HasMaxLength(50)
                .IsUnicode(false)
                .UseCollation("SQL_Latin1_General_CP1_CI_AS");
            entity.Property(e => e.CasteId).HasColumnName("CasteID");
            entity.Property(e => e.ChildName)
                .HasMaxLength(250)
                .IsUnicode(false)
                .UseCollation("SQL_Latin1_General_CP1_CI_AS");
            entity.Property(e => e.ChildRegisGuid)
                .HasMaxLength(50)
                .IsUnicode(false)
                .UseCollation("SQL_Latin1_General_CP1_CI_AS")
                .HasColumnName("ChildRegisGUID");
            entity.Property(e => e.ChildRegisId).HasColumnName("ChildRegisID");
            entity.Property(e => e.CreatedOn).HasColumnType("datetime");
            entity.Property(e => e.DataSourceId).HasColumnName("DataSourceID");
            entity.Property(e => e.DateofRegistration)
                .HasMaxLength(30)
                .IsUnicode(false);
            entity.Property(e => e.Dob)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("DOB");
            entity.Property(e => e.FacilityId).HasColumnName("FacilityID");
            entity.Property(e => e.FacilityTypeId).HasColumnName("FacilityTypeID");
            entity.Property(e => e.FatherName)
                .HasMaxLength(250)
                .IsUnicode(false)
                .UseCollation("SQL_Latin1_General_CP1_CI_AS");
            entity.Property(e => e.GenderId).HasColumnName("GenderID");
            entity.Property(e => e.MobileNo)
                .HasMaxLength(10)
                .IsUnicode(false)
                .UseCollation("SQL_Latin1_General_CP1_CI_AS");
            entity.Property(e => e.MobileNoOwnerId).HasColumnName("MobileNoOwnerID");
            entity.Property(e => e.MotherName)
                .HasMaxLength(250)
                .IsUnicode(false)
                .UseCollation("SQL_Latin1_General_CP1_CI_AS");
            entity.Property(e => e.Provider)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.PwcategoryGuid)
                .HasMaxLength(50)
                .IsUnicode(false)
                .UseCollation("SQL_Latin1_General_CP1_CI_AS")
                .HasColumnName("PWCategoryGUID");
            entity.Property(e => e.RchchildId)
                .HasMaxLength(50)
                .IsUnicode(false)
                .UseCollation("SQL_Latin1_General_CP1_CI_AS")
                .HasColumnName("RCHChildID");
            entity.Property(e => e.RchmotherId)
                .HasMaxLength(50)
                .IsUnicode(false)
                .UseCollation("SQL_Latin1_General_CP1_CI_AS")
                .HasColumnName("RCHMotherID");
            entity.Property(e => e.ReligionId).HasColumnName("ReligionID");
            entity.Property(e => e.UpdatedOn).HasColumnType("datetime");
            entity.Property(e => e.WeightBirth).HasColumnType("decimal(18, 0)");
        });

        modelBuilder.Entity<ViewCopregistration>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("View_COPRegistration");

            entity.Property(e => e.Designation).HasMaxLength(200);
            entity.Property(e => e.Email).HasMaxLength(100);
            entity.Property(e => e.Mobile)
                .HasMaxLength(12)
                .IsUnicode(false);
            entity.Property(e => e.Name).HasMaxLength(200);
            entity.Property(e => e.Organistion).HasMaxLength(200);
            entity.Property(e => e.RegistrationDate)
                .HasMaxLength(30)
                .IsUnicode(false);
            entity.Property(e => e.StateName).HasMaxLength(250);
        });

        modelBuilder.Entity<ViewCounselling>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("View_Counselling");

            entity.Property(e => e.ApplicationName).HasMaxLength(300);
            entity.Property(e => e.CreatedOn).HasColumnType("datetime");
            entity.Property(e => e.DataSourceId).HasColumnName("DataSourceID");
            entity.Property(e => e.FileTitle).HasMaxLength(100);
            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.LangId).HasColumnName("LangID");
            entity.Property(e => e.UpdatedOn).HasColumnType("datetime");
        });

        modelBuilder.Entity<ViewDischargePdf>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("View_Discharge_PDF");

            entity.Property(e => e.Add)
                .HasMaxLength(50)
                .UseCollation("SQL_Latin1_General_CP1_CI_AS")
                .HasColumnName("add");
            entity.Property(e => e.AdmTime)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("adm_time");
            entity.Property(e => e.Age).HasColumnName("age");
            entity.Property(e => e.AsmanCode)
                .HasMaxLength(22)
                .UseCollation("SQL_Latin1_General_CP1_CI_AS")
                .HasColumnName("asman_code");
            entity.Property(e => e.Baby1Comp)
                .HasMaxLength(255)
                .HasColumnName("baby1_comp");
            entity.Property(e => e.Baby1CompItems)
                .HasMaxLength(200)
                .UseCollation("SQL_Latin1_General_CP1_CI_AS")
                .HasColumnName("baby1_comp_items");
            entity.Property(e => e.Baby1CompOthr)
                .HasMaxLength(100)
                .UseCollation("SQL_Latin1_General_CP1_CI_AS")
                .HasColumnName("baby1_comp_othr");
            entity.Property(e => e.Baby1DelPlace).HasColumnName("baby1_del_place");
            entity.Property(e => e.Baby1RefToSncu)
                .HasMaxLength(255)
                .HasColumnName("baby1_ref_to_sncu");
            entity.Property(e => e.Baby1RefToSncuItems)
                .HasMaxLength(200)
                .UseCollation("SQL_Latin1_General_CP1_CI_AS")
                .HasColumnName("baby1_ref_to_sncu_items");
            entity.Property(e => e.Baby1RefToSncuOthr)
                .HasMaxLength(100)
                .UseCollation("SQL_Latin1_General_CP1_CI_AS")
                .HasColumnName("baby1_ref_to_sncu_othr");
            entity.Property(e => e.Baby1Temp)
                .HasColumnType("decimal(5, 2)")
                .HasColumnName("baby1_temp");
            entity.Property(e => e.Baby1ToInstitutionId).HasColumnName("baby1_to_institution_id");
            entity.Property(e => e.Baby1ToInstitutionOther)
                .HasMaxLength(255)
                .UseCollation("SQL_Latin1_General_CP1_CI_AS")
                .HasColumnName("baby1_to_institution_other");
            entity.Property(e => e.Baby1WeightGm)
                .HasMaxLength(5)
                .UseCollation("SQL_Latin1_General_CP1_CI_AS")
                .HasColumnName("baby1_weight_gm");
            entity.Property(e => e.Baby2Comp)
                .HasMaxLength(255)
                .HasColumnName("baby2_comp");
            entity.Property(e => e.Baby2CompItems)
                .HasMaxLength(200)
                .UseCollation("SQL_Latin1_General_CP1_CI_AS")
                .HasColumnName("baby2_comp_items");
            entity.Property(e => e.Baby2CompOthr)
                .HasMaxLength(100)
                .UseCollation("SQL_Latin1_General_CP1_CI_AS")
                .HasColumnName("baby2_comp_othr");
            entity.Property(e => e.Baby2DelPlace).HasColumnName("baby2_del_place");
            entity.Property(e => e.Baby2RefToSncu)
                .HasMaxLength(255)
                .HasColumnName("baby2_ref_to_sncu");
            entity.Property(e => e.Baby2RefToSncuItems)
                .HasMaxLength(200)
                .UseCollation("SQL_Latin1_General_CP1_CI_AS")
                .HasColumnName("baby2_ref_to_sncu_items");
            entity.Property(e => e.Baby2RefToSncuOthr)
                .HasMaxLength(100)
                .UseCollation("SQL_Latin1_General_CP1_CI_AS")
                .HasColumnName("baby2_ref_to_sncu_othr");
            entity.Property(e => e.Baby2Temp)
                .HasColumnType("decimal(5, 2)")
                .HasColumnName("baby2_temp");
            entity.Property(e => e.Baby2ToInstitutionId).HasColumnName("baby2_to_institution_id");
            entity.Property(e => e.Baby2ToInstitutionOther)
                .HasMaxLength(255)
                .UseCollation("SQL_Latin1_General_CP1_CI_AS")
                .HasColumnName("baby2_to_institution_other");
            entity.Property(e => e.Baby2WeightGm)
                .HasMaxLength(5)
                .UseCollation("SQL_Latin1_General_CP1_CI_AS")
                .HasColumnName("baby2_weight_gm");
            entity.Property(e => e.Baby3Comp)
                .HasMaxLength(255)
                .HasColumnName("baby3_comp");
            entity.Property(e => e.Baby3CompItems)
                .HasMaxLength(200)
                .UseCollation("SQL_Latin1_General_CP1_CI_AS")
                .HasColumnName("baby3_comp_items");
            entity.Property(e => e.Baby3CompOthr)
                .HasMaxLength(100)
                .UseCollation("SQL_Latin1_General_CP1_CI_AS")
                .HasColumnName("baby3_comp_othr");
            entity.Property(e => e.Baby3DelPlace).HasColumnName("baby3_del_place");
            entity.Property(e => e.Baby3RefToSncu)
                .HasMaxLength(255)
                .HasColumnName("baby3_ref_to_sncu");
            entity.Property(e => e.Baby3RefToSncuItems)
                .HasMaxLength(200)
                .UseCollation("SQL_Latin1_General_CP1_CI_AS")
                .HasColumnName("baby3_ref_to_sncu_items");
            entity.Property(e => e.Baby3RefToSncuOthr)
                .HasMaxLength(100)
                .UseCollation("SQL_Latin1_General_CP1_CI_AS")
                .HasColumnName("baby3_ref_to_sncu_othr");
            entity.Property(e => e.Baby3Temp)
                .HasColumnType("decimal(5, 2)")
                .HasColumnName("baby3_temp");
            entity.Property(e => e.Baby3ToInstitutionId).HasColumnName("baby3_to_institution_id");
            entity.Property(e => e.Baby3ToInstitutionOther)
                .HasMaxLength(255)
                .UseCollation("SQL_Latin1_General_CP1_CI_AS")
                .HasColumnName("baby3_to_institution_other");
            entity.Property(e => e.Baby3WeightGm)
                .HasMaxLength(5)
                .UseCollation("SQL_Latin1_General_CP1_CI_AS")
                .HasColumnName("baby3_weight_gm");
            entity.Property(e => e.Baby4Comp)
                .HasMaxLength(255)
                .HasColumnName("baby4_comp");
            entity.Property(e => e.Baby4CompItems)
                .HasMaxLength(200)
                .UseCollation("SQL_Latin1_General_CP1_CI_AS")
                .HasColumnName("baby4_comp_items");
            entity.Property(e => e.Baby4CompOthr)
                .HasMaxLength(100)
                .UseCollation("SQL_Latin1_General_CP1_CI_AS")
                .HasColumnName("baby4_comp_othr");
            entity.Property(e => e.Baby4DelPlace).HasColumnName("baby4_del_place");
            entity.Property(e => e.Baby4RefToSncu)
                .HasMaxLength(255)
                .HasColumnName("baby4_ref_to_sncu");
            entity.Property(e => e.Baby4RefToSncuItems)
                .HasMaxLength(200)
                .UseCollation("SQL_Latin1_General_CP1_CI_AS")
                .HasColumnName("baby4_ref_to_sncu_items");
            entity.Property(e => e.Baby4RefToSncuOthr)
                .HasMaxLength(100)
                .UseCollation("SQL_Latin1_General_CP1_CI_AS")
                .HasColumnName("baby4_ref_to_sncu_othr");
            entity.Property(e => e.Baby4Temp)
                .HasColumnType("decimal(5, 2)")
                .HasColumnName("baby4_temp");
            entity.Property(e => e.Baby4ToInstitutionId).HasColumnName("baby4_to_institution_id");
            entity.Property(e => e.Baby4ToInstitutionOther)
                .HasMaxLength(255)
                .UseCollation("SQL_Latin1_General_CP1_CI_AS")
                .HasColumnName("baby4_to_institution_other");
            entity.Property(e => e.Baby4WeightGm)
                .HasMaxLength(5)
                .UseCollation("SQL_Latin1_General_CP1_CI_AS")
                .HasColumnName("baby4_weight_gm");
            entity.Property(e => e.BabyKitProvide)
                .HasMaxLength(3)
                .IsUnicode(false);
            entity.Property(e => e.Bg)
                .HasMaxLength(255)
                .HasColumnName("bg");
            entity.Property(e => e.Birth1CertGiven)
                .HasMaxLength(255)
                .HasColumnName("Birth1_cert_given");
            entity.Property(e => e.Birth2CertGiven)
                .HasMaxLength(255)
                .HasColumnName("Birth2_cert_given");
            entity.Property(e => e.Birth3CertGiven)
                .HasMaxLength(255)
                .HasColumnName("Birth3_cert_given");
            entity.Property(e => e.Birth4CertGiven)
                .HasMaxLength(255)
                .HasColumnName("Birth4_cert_given");
            entity.Property(e => e.BirthDefects1)
                .HasMaxLength(255)
                .HasColumnName("birth_defects1");
            entity.Property(e => e.BirthDefects2)
                .HasMaxLength(255)
                .HasColumnName("birth_defects2");
            entity.Property(e => e.BirthDefects3)
                .HasMaxLength(255)
                .HasColumnName("birth_defects3");
            entity.Property(e => e.BirthDefects4)
                .HasMaxLength(255)
                .HasColumnName("birth_defects4");
            entity.Property(e => e.BirthDefectsItems1).HasColumnName("birth_defects_items1");
            entity.Property(e => e.BirthDefectsItems2).HasColumnName("birth_defects_items2");
            entity.Property(e => e.BirthDefectsItems3).HasColumnName("birth_defects_items3");
            entity.Property(e => e.BirthDefectsItems4).HasColumnName("birth_defects_items4");
            entity.Property(e => e.BirthDefectsOthr1)
                .HasMaxLength(150)
                .UseCollation("SQL_Latin1_General_CP1_CI_AS")
                .HasColumnName("birth_defects_othr1");
            entity.Property(e => e.BirthDefectsOthr2)
                .HasMaxLength(150)
                .UseCollation("SQL_Latin1_General_CP1_CI_AS")
                .HasColumnName("birth_defects_othr2");
            entity.Property(e => e.BirthDefectsOthr3)
                .HasMaxLength(150)
                .UseCollation("SQL_Latin1_General_CP1_CI_AS")
                .HasColumnName("birth_defects_othr3");
            entity.Property(e => e.BirthDefectsOthr4)
                .HasMaxLength(150)
                .UseCollation("SQL_Latin1_General_CP1_CI_AS")
                .HasColumnName("birth_defects_othr4");
            entity.Property(e => e.BirthGirlCmMsg)
                .HasMaxLength(255)
                .HasColumnName("birth_girl_cm_msg");
            entity.Property(e => e.BloodTrans)
                .HasMaxLength(255)
                .HasColumnName("blood_trans");
            entity.Property(e => e.BloodTransType).HasColumnName("blood_trans_type");
            entity.Property(e => e.BloodTransUnitts)
                .HasMaxLength(200)
                .UseCollation("SQL_Latin1_General_CP1_CI_AS")
                .HasColumnName("blood_trans_unitts");
            entity.Property(e => e.BpMax).HasColumnName("bp_max");
            entity.Property(e => e.BpMin).HasColumnName("bp_min");
            entity.Property(e => e.BplDesiGheeCoupon)
                .HasMaxLength(255)
                .HasColumnName("bpl_desi_ghee_coupon");
            entity.Property(e => e.Breast1FeedInitiated)
                .HasMaxLength(255)
                .HasColumnName("breast1_feed_initiated");
            entity.Property(e => e.Breast2FeedInitiated)
                .HasMaxLength(255)
                .HasColumnName("breast2_feed_initiated");
            entity.Property(e => e.Breast3FeedInitiated)
                .HasMaxLength(255)
                .HasColumnName("breast3_feed_initiated");
            entity.Property(e => e.Breast4FeedInitiated)
                .HasMaxLength(255)
                .HasColumnName("breast4_feed_initiated");
            entity.Property(e => e.BsOgtt)
                .HasMaxLength(20)
                .UseCollation("SQL_Latin1_General_CP1_CI_AS")
                .HasColumnName("bs_ogtt");
            entity.Property(e => e.BsRan)
                .HasMaxLength(20)
                .UseCollation("SQL_Latin1_General_CP1_CI_AS")
                .HasColumnName("bs_ran");
            entity.Property(e => e.CaseId).HasColumnName("case_id");
            entity.Property(e => e.CaseName)
                .HasMaxLength(50)
                .UseCollation("SQL_Latin1_General_CP1_CI_AS")
                .HasColumnName("case_name");
            entity.Property(e => e.CauseOfCesarean1)
                .HasMaxLength(200)
                .UseCollation("SQL_Latin1_General_CP1_CI_AS")
                .HasColumnName("cause_of_cesarean1");
            entity.Property(e => e.CauseOfCesarean2)
                .HasMaxLength(200)
                .UseCollation("SQL_Latin1_General_CP1_CI_AS")
                .HasColumnName("cause_of_cesarean2");
            entity.Property(e => e.CauseOfCesarean3)
                .HasMaxLength(200)
                .UseCollation("SQL_Latin1_General_CP1_CI_AS")
                .HasColumnName("cause_of_cesarean3");
            entity.Property(e => e.CauseOfCesarean4)
                .HasMaxLength(200)
                .UseCollation("SQL_Latin1_General_CP1_CI_AS")
                .HasColumnName("cause_of_cesarean4");
            entity.Property(e => e.Complications)
                .HasMaxLength(200)
                .UseCollation("SQL_Latin1_General_CP1_CI_AS")
                .HasColumnName("complications");
            entity.Property(e => e.Condom)
                .HasMaxLength(255)
                .HasColumnName("condom");
            entity.Property(e => e.CounsDangerSigns)
                .HasMaxLength(255)
                .HasColumnName("couns_danger_signs");
            entity.Property(e => e.DateOfAdmission)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("date_of_admission");
            entity.Property(e => e.DateOfDelivery1)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("date_of_delivery1");
            entity.Property(e => e.DeliveryPlace1)
                .HasMaxLength(8)
                .IsUnicode(false);
            entity.Property(e => e.DischargeTime)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("discharge_time");
            entity.Property(e => e.DischargeType)
                .HasMaxLength(255)
                .HasColumnName("discharge_type");
            entity.Property(e => e.DisplayOrder).HasColumnName("display_order");
            entity.Property(e => e.District)
                .HasMaxLength(150)
                .UseCollation("SQL_Latin1_General_CP1_CI_AS")
                .HasColumnName("district");
            entity.Property(e => e.Do)
                .HasMaxLength(50)
                .UseCollation("SQL_Latin1_General_CP1_CI_AS")
                .HasColumnName("do");
            entity.Property(e => e.DurOfGestation)
                .HasMaxLength(6)
                .UseCollation("SQL_Latin1_General_CP1_CI_AS")
                .HasColumnName("dur_of_gestation");
            entity.Property(e => e.FollowUpTime)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("follow_up_time");
            entity.Property(e => e.FoodService)
                .HasMaxLength(255)
                .HasColumnName("food_service");
            entity.Property(e => e.FoodServiceDays)
                .HasMaxLength(255)
                .HasColumnName("food_service_days");
            entity.Property(e => e.Hbsag)
                .HasMaxLength(255)
                .HasColumnName("hbsag");
            entity.Property(e => e.Hiv)
                .HasMaxLength(255)
                .HasColumnName("hiv");
            entity.Property(e => e.Injectable)
                .HasMaxLength(255)
                .HasColumnName("injectable");
            entity.Property(e => e.InstitutionName)
                .HasMaxLength(150)
                .UseCollation("SQL_Latin1_General_CP1_CI_AS")
                .HasColumnName("institution_name");
            entity.Property(e => e.IpdDis)
                .HasMaxLength(20)
                .UseCollation("SQL_Latin1_General_CP1_CI_AS")
                .HasColumnName("ipd_dis");
            entity.Property(e => e.IpdNo)
                .HasMaxLength(20)
                .UseCollation("SQL_Latin1_General_CP1_CI_AS")
                .HasColumnName("ipd_no");
            entity.Property(e => e.IsRefBaby1).HasColumnName("is_ref_baby1");
            entity.Property(e => e.IsRefBaby2).HasColumnName("is_ref_baby2");
            entity.Property(e => e.IsRefBaby3).HasColumnName("is_ref_baby3");
            entity.Property(e => e.IsRefBaby4).HasColumnName("is_ref_baby4");
            entity.Property(e => e.IsRefMother).HasColumnName("is_ref_mother");
            entity.Property(e => e.Lam)
                .HasMaxLength(255)
                .HasColumnName("lam");
            entity.Property(e => e.LbrRegNo)
                .HasMaxLength(20)
                .UseCollation("SQL_Latin1_General_CP1_CI_AS")
                .HasColumnName("lbr_reg_no");
            entity.Property(e => e.MTemp)
                .HasColumnType("decimal(5, 2)")
                .HasColumnName("m_temp");
            entity.Property(e => e.MotherAliveDischarge)
                .HasMaxLength(3)
                .IsUnicode(false);
            entity.Property(e => e.MotherComp)
                .HasMaxLength(255)
                .HasColumnName("mother_comp");
            entity.Property(e => e.MotherCompItems)
                .HasMaxLength(200)
                .UseCollation("SQL_Latin1_General_CP1_CI_AS")
                .HasColumnName("mother_comp_items");
            entity.Property(e => e.MotherCompOthr)
                .HasMaxLength(100)
                .UseCollation("SQL_Latin1_General_CP1_CI_AS")
                .HasColumnName("mother_comp_othr");
            entity.Property(e => e.MotherCottageWard)
                .HasMaxLength(3)
                .IsUnicode(false);
            entity.Property(e => e.NoOfDeliveries)
                .HasMaxLength(255)
                .HasColumnName("no_of_deliveries");
            entity.Property(e => e.OdNo)
                .HasMaxLength(20)
                .UseCollation("SQL_Latin1_General_CP1_CI_AS")
                .HasColumnName("od_no");
            entity.Property(e => e.OutcomeOfDelivery1)
                .HasMaxLength(255)
                .HasColumnName("outcome_of_delivery1");
            entity.Property(e => e.OutcomeOfDelivery2)
                .HasMaxLength(255)
                .HasColumnName("outcome_of_delivery2");
            entity.Property(e => e.OutcomeOfDelivery3)
                .HasMaxLength(255)
                .HasColumnName("outcome_of_delivery3");
            entity.Property(e => e.OutcomeOfDelivery4)
                .HasMaxLength(255)
                .HasColumnName("outcome_of_delivery4");
            entity.Property(e => e.PctsRchNo)
                .HasMaxLength(255)
                .UseCollation("SQL_Latin1_General_CP1_CI_AS")
                .HasColumnName("pcts_rch_no");
            entity.Property(e => e.PdHemoglobin).HasColumnName("pd_hemoglobin");
            entity.Property(e => e.PpiucdInserted)
                .HasMaxLength(255)
                .HasColumnName("ppiucd_inserted");
            entity.Property(e => e.PpiucdInsertedNameHlthWrkr)
                .HasMaxLength(50)
                .UseCollation("SQL_Latin1_General_CP1_CI_AS")
                .HasColumnName("ppiucd_inserted_name_hlth_wrkr");
            entity.Property(e => e.PpiucdInsertedTime)
                .HasMaxLength(13)
                .IsUnicode(false)
                .HasColumnName("ppiucd_inserted_time");
            entity.Property(e => e.PptPpsTime)
                .HasColumnType("smalldatetime")
                .HasColumnName("ppt_pps_time");
            entity.Property(e => e.PptctWasGiven1)
                .HasMaxLength(255)
                .HasColumnName("pptct_was_given1");
            entity.Property(e => e.PptctWasGiven2)
                .HasMaxLength(255)
                .HasColumnName("pptct_was_given2");
            entity.Property(e => e.PptctWasGiven3)
                .HasMaxLength(255)
                .HasColumnName("pptct_was_given3");
            entity.Property(e => e.PptctWasGiven4)
                .HasMaxLength(255)
                .HasColumnName("pptct_was_given4");
            entity.Property(e => e.ProvisionVehicle)
                .HasMaxLength(255)
                .HasColumnName("provision_vehicle");
            entity.Property(e => e.RefOutFinishTime)
                .HasPrecision(0)
                .HasColumnName("ref_out_finish_time");
            entity.Property(e => e.RefReasonBaby1)
                .UseCollation("SQL_Latin1_General_CP1_CI_AS")
                .HasColumnName("ref_reason_baby1");
            entity.Property(e => e.RefReasonBaby2)
                .UseCollation("SQL_Latin1_General_CP1_CI_AS")
                .HasColumnName("ref_reason_baby2");
            entity.Property(e => e.RefReasonBaby3)
                .UseCollation("SQL_Latin1_General_CP1_CI_AS")
                .HasColumnName("ref_reason_baby3");
            entity.Property(e => e.RefReasonBaby4)
                .UseCollation("SQL_Latin1_General_CP1_CI_AS")
                .HasColumnName("ref_reason_baby4");
            entity.Property(e => e.ServDesig)
                .HasMaxLength(50)
                .UseCollation("SQL_Latin1_General_CP1_CI_AS")
                .HasColumnName("serv_desig");
            entity.Property(e => e.ServId).HasColumnName("serv_id");
            entity.Property(e => e.ServName)
                .HasMaxLength(50)
                .UseCollation("SQL_Latin1_General_CP1_CI_AS")
                .HasColumnName("serv_name");
            entity.Property(e => e.ServPhone)
                .HasMaxLength(15)
                .UseCollation("SQL_Latin1_General_CP1_CI_AS")
                .HasColumnName("serv_phone");
            entity.Property(e => e.SexOfBaby1)
                .HasMaxLength(255)
                .HasColumnName("sex_of_baby1");
            entity.Property(e => e.SexOfBaby2)
                .HasMaxLength(255)
                .HasColumnName("sex_of_baby2");
            entity.Property(e => e.SexOfBaby3)
                .HasMaxLength(255)
                .HasColumnName("sex_of_baby3");
            entity.Property(e => e.SexOfBaby4)
                .HasMaxLength(255)
                .HasColumnName("sex_of_baby4");
            entity.Property(e => e.Still1BirthType).HasColumnName("still1_birth_type");
            entity.Property(e => e.Still2BirthType).HasColumnName("still2_birth_type");
            entity.Property(e => e.Still3BirthType).HasColumnName("still3_birth_type");
            entity.Property(e => e.Still4BirthType).HasColumnName("still4_birth_type");
            entity.Property(e => e.ThyroidT3)
                .HasMaxLength(20)
                .UseCollation("SQL_Latin1_General_CP1_CI_AS")
                .HasColumnName("thyroid_t3");
            entity.Property(e => e.ThyroidT4)
                .HasMaxLength(20)
                .UseCollation("SQL_Latin1_General_CP1_CI_AS")
                .HasColumnName("thyroid_t4");
            entity.Property(e => e.ThyroidTsh)
                .HasMaxLength(20)
                .UseCollation("SQL_Latin1_General_CP1_CI_AS")
                .HasColumnName("thyroid_tsh");
            entity.Property(e => e.TimeOfDelivery1)
                .HasMaxLength(15)
                .IsUnicode(false)
                .HasColumnName("time_of_delivery1");
            entity.Property(e => e.TimeOfDelivery2)
                .HasPrecision(0)
                .HasColumnName("time_of_delivery2");
            entity.Property(e => e.TimeOfDelivery3)
                .HasPrecision(0)
                .HasColumnName("time_of_delivery3");
            entity.Property(e => e.TimeOfDelivery4)
                .HasPrecision(0)
                .HasColumnName("time_of_delivery4");
            entity.Property(e => e.TreatAdvised).HasColumnName("treat_advised");
            entity.Property(e => e.TreatAdvisedOthr)
                .UseCollation("SQL_Latin1_General_CP1_CI_AS")
                .HasColumnName("treat_advised_othr");
            entity.Property(e => e.TypeOfAssisDel1).HasColumnName("type_of_assis_del1");
            entity.Property(e => e.TypeOfAssisDel2).HasColumnName("type_of_assis_del2");
            entity.Property(e => e.TypeOfAssisDel3).HasColumnName("type_of_assis_del3");
            entity.Property(e => e.TypeOfAssisDel4).HasColumnName("type_of_assis_del4");
            entity.Property(e => e.TypeOfDelivery1)
                .HasMaxLength(255)
                .HasColumnName("type_of_delivery1");
            entity.Property(e => e.TypeOfDelivery2)
                .HasMaxLength(255)
                .HasColumnName("type_of_delivery2");
            entity.Property(e => e.TypeOfDelivery3)
                .HasMaxLength(255)
                .HasColumnName("type_of_delivery3");
            entity.Property(e => e.TypeOfDelivery4)
                .HasMaxLength(255)
                .HasColumnName("type_of_delivery4");
            entity.Property(e => e.UrineAlb).HasColumnName("urine_alb");
            entity.Property(e => e.UrineAnalysis).HasColumnName("urine_analysis");
            entity.Property(e => e.UrineCreatinine)
                .HasMaxLength(100)
                .UseCollation("SQL_Latin1_General_CP1_CI_AS")
                .HasColumnName("urine_creatinine");
            entity.Property(e => e.UrineOther)
                .HasMaxLength(100)
                .UseCollation("SQL_Latin1_General_CP1_CI_AS")
                .HasColumnName("urine_other");
            entity.Property(e => e.UrineSugar).HasColumnName("urine_sugar");
            entity.Property(e => e.VaccinationOfBaby1).HasColumnName("vaccination_of_baby1");
            entity.Property(e => e.VaccinationOfBaby2).HasColumnName("vaccination_of_baby2");
            entity.Property(e => e.VaccinationOfBaby3).HasColumnName("vaccination_of_baby3");
            entity.Property(e => e.VaccinationOfBaby4).HasColumnName("vaccination_of_baby4");
            entity.Property(e => e.VdrlRpr)
                .HasMaxLength(255)
                .HasColumnName("vdrl_rpr");
            entity.Property(e => e.VitK1Dose1)
                .HasMaxLength(255)
                .HasColumnName("vit_k1_dose1");
            entity.Property(e => e.VitK1Dose2)
                .HasMaxLength(255)
                .HasColumnName("vit_k1_dose2");
            entity.Property(e => e.VitK1Dose3)
                .HasMaxLength(255)
                .HasColumnName("vit_k1_dose3");
            entity.Property(e => e.VitK1Dose4)
                .HasMaxLength(255)
                .HasColumnName("vit_k1_dose4");
            entity.Property(e => e.Wo)
                .HasMaxLength(50)
                .UseCollation("SQL_Latin1_General_CP1_CI_AS")
                .HasColumnName("wo");
        });

        modelBuilder.Entity<ViewDistrictWiseDatum>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("View_DistrictWiseData");

            entity.Property(e => e.District).HasMaxLength(250);
            entity.Property(e => e.DistrictId).HasColumnName("DistrictID");
            entity.Property(e => e.StateId).HasColumnName("StateID");
        });

        modelBuilder.Entity<ViewFacilityWiseFilter>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("View_FacilityWiseFilter");

            entity.Property(e => e.BlockId).HasColumnName("BlockID");
            entity.Property(e => e.FacilityId).HasColumnName("FacilityID");
            entity.Property(e => e.FacilityName)
                .HasMaxLength(150)
                .IsUnicode(false);
        });

        modelBuilder.Entity<ViewGetAncDataInfo>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("View_Get_AncDataInfo");

            entity.Property(e => e.Anc1Date)
                .HasColumnType("datetime")
                .HasColumnName("ANC1 Date");
            entity.Property(e => e.Anc2Date)
                .HasColumnType("datetime")
                .HasColumnName("ANC2 Date");
            entity.Property(e => e.Anc3Date)
                .HasColumnType("datetime")
                .HasColumnName("ANC3 Date");
            entity.Property(e => e.BeneficiaryGuid)
                .HasMaxLength(100)
                .UseCollation("SQL_Latin1_General_CP1_CI_AS")
                .HasColumnName("BeneficiaryGUID");
            entity.Property(e => e.Tt1).HasColumnName("TT1");
            entity.Property(e => e.Tt1date)
                .HasColumnType("datetime")
                .HasColumnName("TT1Date");
            entity.Property(e => e.Tt2).HasColumnName("TT2");
            entity.Property(e => e.Tt2date)
                .HasColumnType("datetime")
                .HasColumnName("TT2Date");
            entity.Property(e => e.Ttb).HasColumnName("TTB");
            entity.Property(e => e.Ttbdate)
                .HasColumnType("datetime")
                .HasColumnName("TTBDate");
        });

        modelBuilder.Entity<ViewGetRegistration>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("View_GetRegistration");
        });

        modelBuilder.Entity<ViewJssyBeneficiaryInfoModel>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("View_JSSY_BeneficiaryInfoModel");

            entity.Property(e => e.AadhaarNo)
                .HasMaxLength(12)
                .IsUnicode(false)
                .UseCollation("SQL_Latin1_General_CP1_CI_AS");
            entity.Property(e => e.Accountname)
                .HasMaxLength(302)
                .UseCollation("SQL_Latin1_General_CP1_CI_AS");
            entity.Property(e => e.Accountno)
                .HasMaxLength(100)
                .IsUnicode(false)
                .UseCollation("SQL_Latin1_General_CP1_CI_AS");
            entity.Property(e => e.Add)
                .UseCollation("SQL_Latin1_General_CP1_CI_AS")
                .HasColumnName("add");
            entity.Property(e => e.AdmTime)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("adm_time");
            entity.Property(e => e.Age).HasColumnName("age");
            entity.Property(e => e.AnmName)
                .HasMaxLength(50)
                .UseCollation("SQL_Latin1_General_CP1_CI_AS")
                .HasColumnName("anm_name");
            entity.Property(e => e.AshaName)
                .HasMaxLength(50)
                .UseCollation("SQL_Latin1_General_CP1_CI_AS")
                .HasColumnName("asha_name");
            entity.Property(e => e.Bank)
                .UseCollation("SQL_Latin1_General_CP1_CI_AS")
                .HasColumnName("bank");
            entity.Property(e => e.BankBranch).UseCollation("SQL_Latin1_General_CP1_CI_AS");
            entity.Property(e => e.BankName)
                .HasMaxLength(150)
                .IsUnicode(false)
                .UseCollation("SQL_Latin1_General_CP1_CI_AS")
                .HasColumnName("Bank_Name");
            entity.Property(e => e.BeforeDelivery500)
                .HasMaxLength(1)
                .IsUnicode(false);
            entity.Property(e => e.BeforeDelivery500Rs)
                .HasMaxLength(1)
                .IsUnicode(false);
            entity.Property(e => e.Bhamashahid)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasColumnName("BHAMASHAHID");
            entity.Property(e => e.Bpl)
                .HasMaxLength(3)
                .IsUnicode(false)
                .HasColumnName("bpl");
            entity.Property(e => e.CaseName)
                .HasMaxLength(50)
                .UseCollation("SQL_Latin1_General_CP1_CI_AS")
                .HasColumnName("case_name");
            entity.Property(e => e.CastName)
                .HasMaxLength(1)
                .IsUnicode(false);
            entity.Property(e => e.CategoryName).HasColumnName("categoryName");
            entity.Property(e => e.DischargeTypeDate)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("discharge_type_Date");
            entity.Property(e => e.DischargeTypeTime)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("discharge_type_time");
            entity.Property(e => e.District).HasColumnName("district");
            entity.Property(e => e.DoctorName)
                .HasMaxLength(200)
                .UseCollation("SQL_Latin1_General_CP1_CI_AS")
                .HasColumnName("doctor_name");
            entity.Property(e => e.DoctorUnit).HasColumnName("doctor_unit");
            entity.Property(e => e.Ecid)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasColumnName("ecid");
            entity.Property(e => e.Ghamantu)
                .HasMaxLength(1)
                .IsUnicode(false);
            entity.Property(e => e.Husbname)
                .HasMaxLength(302)
                .UseCollation("SQL_Latin1_General_CP1_CI_AS");
            entity.Property(e => e.IfscCode)
                .UseCollation("SQL_Latin1_General_CP1_CI_AS")
                .HasColumnName("Ifsc_code");
            entity.Property(e => e.InstitutionName)
                .HasMaxLength(150)
                .UseCollation("SQL_Latin1_General_CP1_CI_AS")
                .HasColumnName("institution_name");
            entity.Property(e => e.InstitutionType)
                .HasMaxLength(30)
                .IsUnicode(false)
                .UseCollation("SQL_Latin1_General_CP1_CI_AS")
                .HasColumnName("institution_Type");
            entity.Property(e => e.IsRefered)
                .HasMaxLength(3)
                .IsUnicode(false);
            entity.Property(e => e.LiveBirths).HasColumnName("live_births");
            entity.Property(e => e.Lmp)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("lmp");
            entity.Property(e => e.LocationRajasthanvalue)
                .HasMaxLength(3)
                .IsUnicode(false)
                .HasColumnName("Location_Rajasthanvalue");
            entity.Property(e => e.Mob)
                .HasMaxLength(10)
                .IsUnicode(false)
                .UseCollation("SQL_Latin1_General_CP1_CI_AS")
                .HasColumnName("mob");
            entity.Property(e => e.PctsRchNo)
                .HasMaxLength(50)
                .IsUnicode(false)
                .UseCollation("SQL_Latin1_General_CP1_CI_AS")
                .HasColumnName("pcts_rch_no");
            entity.Property(e => e.RationCardNo)
                .HasMaxLength(1)
                .IsUnicode(false);
        });

        modelBuilder.Entity<ViewJssyDeliveryInfoModel>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("View_JSSY_DeliveryInfoModel");

            entity.Property(e => e.Babyname)
                .HasMaxLength(100)
                .UseCollation("SQL_Latin1_General_CP1_CI_AS")
                .HasColumnName("babyname");
            entity.Property(e => e.BgName)
                .HasMaxLength(255)
                .HasColumnName("bgName");
            entity.Property(e => e.BirthDefectsItemDatas).HasColumnName("birth_defects_itemDatas");
            entity.Property(e => e.BirthDefectsItems)
                .HasMaxLength(3)
                .IsUnicode(false)
                .HasColumnName("birth_defects_items");
            entity.Property(e => e.BirthType).HasMaxLength(255);
            entity.Property(e => e.BreastFeedInitiatedTime)
                .HasPrecision(0)
                .HasColumnName("breast_feed_initiated_time");
            entity.Property(e => e.DelAborConName)
                .HasMaxLength(50)
                .UseCollation("SQL_Latin1_General_CP1_CI_AS")
                .HasColumnName("del_abor_con_name");
            entity.Property(e => e.DeliveryTime)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("delivery_time");
            entity.Property(e => e.LastDeliveryDate)
                .HasMaxLength(30)
                .IsUnicode(false);
            entity.Property(e => e.NoOfBirth).HasMaxLength(255);
            entity.Property(e => e.PpiucdInserted)
                .HasMaxLength(268)
                .HasColumnName("ppiucd_inserted");
            entity.Property(e => e.Sexofbaby).HasMaxLength(255);
            entity.Property(e => e.TimeOfDelivery)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("time_of_delivery");
            entity.Property(e => e.TypeOfDelivery)
                .HasMaxLength(255)
                .HasColumnName("type_of_delivery");
            entity.Property(e => e.WeightOfBabyGm)
                .HasMaxLength(5)
                .UseCollation("SQL_Latin1_General_CP1_CI_AS")
                .HasColumnName("weight_of_baby_gm");
        });

        modelBuilder.Entity<ViewJssyDischargeInfoModel>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("View_JSSY_DischargeInfoModel");

            entity.Property(e => e.AsmanCode)
                .HasMaxLength(22)
                .UseCollation("SQL_Latin1_General_CP1_CI_AS")
                .HasColumnName("asman_code");
            entity.Property(e => e.BabyKitProvide)
                .HasMaxLength(3)
                .IsUnicode(false);
            entity.Property(e => e.BgName)
                .HasMaxLength(255)
                .HasColumnName("bgName");
            entity.Property(e => e.BloodTransUnitts)
                .HasMaxLength(255)
                .HasColumnName("blood_trans_unitts");
            entity.Property(e => e.Btrans).HasMaxLength(255);
            entity.Property(e => e.DischargeTime)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("discharge_time");
            entity.Property(e => e.DischargeTypeDate)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("discharge_type_Date");
            entity.Property(e => e.DischargeTypeTime)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("discharge_type_time");
            entity.Property(e => e.FoodService)
                .HasMaxLength(255)
                .HasColumnName("food_service");
            entity.Property(e => e.FoodServiceDays)
                .HasMaxLength(255)
                .HasColumnName("food_service_days");
            entity.Property(e => e.MotherAliveDischarge)
                .HasMaxLength(1)
                .IsUnicode(false);
            entity.Property(e => e.MotherCottageWard)
                .HasMaxLength(3)
                .IsUnicode(false);
            entity.Property(e => e.PrivateVehKm).HasColumnName("private_veh_km");
            entity.Property(e => e.PrivateVehNumber)
                .HasMaxLength(100)
                .IsUnicode(false)
                .UseCollation("SQL_Latin1_General_CP1_CI_AS")
                .HasColumnName("private_veh_number");
            entity.Property(e => e.PrivateVehOwner)
                .HasMaxLength(100)
                .UseCollation("SQL_Latin1_General_CP1_CI_AS")
                .HasColumnName("private_veh_owner");
            entity.Property(e => e.VehicleName).HasMaxLength(255);
        });

        modelBuilder.Entity<ViewPregnantWoman>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("View_PregnantWomen");

            entity.Property(e => e.AncregDate)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("ANCRegDate");
            entity.Property(e => e.AshaName)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.BeneficiaryCategoryId).HasColumnName("BeneficiaryCategoryID");
            entity.Property(e => e.BeneficiaryGuid)
                .HasMaxLength(50)
                .IsUnicode(false)
                .UseCollation("SQL_Latin1_General_CP1_CI_AS")
                .HasColumnName("BeneficiaryGUID");
            entity.Property(e => e.CreatedOn).HasColumnType("datetime");
            entity.Property(e => e.DataSourceId).HasColumnName("DataSourceID");
            entity.Property(e => e.Edd)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("EDD");
            entity.Property(e => e.FacilityNameId).HasColumnName("FacilityNameID");
            entity.Property(e => e.FacilityNameOther)
                .HasMaxLength(50)
                .IsUnicode(false)
                .UseCollation("SQL_Latin1_General_CP1_CI_AS");
            entity.Property(e => e.FacilityTypeId).HasColumnName("FacilityTypeID");
            entity.Property(e => e.FacilityTypeOther)
                .HasMaxLength(50)
                .IsUnicode(false)
                .UseCollation("SQL_Latin1_General_CP1_CI_AS");
            entity.Property(e => e.HbsAgdate)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("HBsAGDate");
            entity.Property(e => e.HbsAgresultId).HasColumnName("HBsAGResultID");
            entity.Property(e => e.HealthProviderName)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.Hivdate)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("HIVDate");
            entity.Property(e => e.HivresultId).HasColumnName("HIVResultID");
            entity.Property(e => e.IsHbsAgtestId).HasColumnName("IsHBsAGTestID");
            entity.Property(e => e.IsHivtestId).HasColumnName("IsHIVTestID");
            entity.Property(e => e.IsVdrltestId).HasColumnName("IsVDRLTestID");
            entity.Property(e => e.LastPregnancyComplicationId).HasColumnName("LastPregnancyComplicationID");
            entity.Property(e => e.LastPregnancyComplicationOther)
                .HasMaxLength(50)
                .IsUnicode(false)
                .UseCollation("SQL_Latin1_General_CP1_CI_AS");
            entity.Property(e => e.LastPregnancyDate)
                .HasMaxLength(30)
                .IsUnicode(false);
            entity.Property(e => e.LastPregnancyNoofAbortionId).HasColumnName("LastPregnancyNoofAbortionID");
            entity.Property(e => e.LastPregnancyNoofLiveBirthId).HasColumnName("LastPregnancyNoofLiveBirthID");
            entity.Property(e => e.LastPregnancyNoofStillBirthId).HasColumnName("LastPregnancyNoofStillBirthID");
            entity.Property(e => e.LastPregnancyOutcomeId).HasColumnName("LastPregnancyOutcomeID");
            entity.Property(e => e.LastVisitDate)
                .HasMaxLength(30)
                .IsUnicode(false);
            entity.Property(e => e.LasttolastPregnancyComplicationId)
                .HasMaxLength(50)
                .IsUnicode(false)
                .UseCollation("SQL_Latin1_General_CP1_CI_AS")
                .HasColumnName("LasttolastPregnancyComplicationID");
            entity.Property(e => e.LasttolastPregnancyComplicationOther)
                .HasMaxLength(50)
                .IsUnicode(false)
                .UseCollation("SQL_Latin1_General_CP1_CI_AS");
            entity.Property(e => e.LasttolastPregnancyDate)
                .HasMaxLength(30)
                .IsUnicode(false);
            entity.Property(e => e.LasttolastPregnancyNoofAbortionId).HasColumnName("LasttolastPregnancyNoofAbortionID");
            entity.Property(e => e.LasttolastPregnancyNoofLiveBirthId).HasColumnName("LasttolastPregnancyNoofLiveBirthID");
            entity.Property(e => e.LasttolastPregnancyNoofStillBirthId).HasColumnName("LasttolastPregnancyNoofStillBirthID");
            entity.Property(e => e.LasttolastPregnancyOutcomeId).HasColumnName("LasttolastPregnancyOutcomeID");
            entity.Property(e => e.Lmpdate)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("LMPDate");
            entity.Property(e => e.MobileNoOwnerOther)
                .HasMaxLength(100)
                .IsUnicode(false)
                .UseCollation("SQL_Latin1_General_CP1_CI_AS");
            entity.Property(e => e.PastillnessOther)
                .HasMaxLength(100)
                .IsUnicode(false)
                .UseCollation("SQL_Latin1_General_CP1_CI_AS");
            entity.Property(e => e.PwcategoryGuid)
                .HasMaxLength(50)
                .IsUnicode(false)
                .UseCollation("SQL_Latin1_General_CP1_CI_AS")
                .HasColumnName("PWCategoryGUID");
            entity.Property(e => e.PwcategoryId).HasColumnName("PWCategoryID");
            entity.Property(e => e.UpdatedOn).HasColumnType("datetime");
            entity.Property(e => e.Vdrldate)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("VDRLDate");
            entity.Property(e => e.VdrlresultId).HasColumnName("VDRLResultID");
            entity.Property(e => e.VisitDate).HasColumnType("datetime");
            entity.Property(e => e.WomanMobileNo)
                .HasMaxLength(10)
                .IsUnicode(false)
                .UseCollation("SQL_Latin1_General_CP1_CI_AS");
            entity.Property(e => e.WomanWeight).HasColumnType("decimal(18, 0)");
        });

        modelBuilder.Entity<ViewPwcountReport>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("View_PWCountReport");

            entity.Property(e => e.FirstAnc).HasColumnName("FirstANC");
            entity.Property(e => e.FirstPnc).HasColumnName("FirstPNC");
            entity.Property(e => e.FourthAnc).HasColumnName("FourthANC");
            entity.Property(e => e.Hrp).HasColumnName("HRP");
            entity.Property(e => e.SecondAnc).HasColumnName("SecondANC");
            entity.Property(e => e.SecondPnc).HasColumnName("SecondPNC");
            entity.Property(e => e.ThirdAnc).HasColumnName("ThirdANC");
        });

        modelBuilder.Entity<ViewPwjourney>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("View_PWJourney");

            entity.Property(e => e.BenName)
                .HasMaxLength(302)
                .UseCollation("SQL_Latin1_General_CP1_CI_AS");
            entity.Property(e => e.BeneficiaryId).HasColumnName("BeneficiaryID");
            entity.Property(e => e.BlockName).HasMaxLength(255);
            entity.Property(e => e.District).HasMaxLength(250);
            entity.Property(e => e.HusName)
                .HasMaxLength(302)
                .UseCollation("SQL_Latin1_General_CP1_CI_AS");
            entity.Property(e => e.Lb).HasColumnName("LB");
            entity.Property(e => e.Ld).HasColumnName("LD");
            entity.Property(e => e.Ls).HasColumnName("LS");
            entity.Property(e => e.MobileNo)
                .HasMaxLength(10)
                .IsUnicode(false)
                .UseCollation("SQL_Latin1_General_CP1_CI_AS");
            entity.Property(e => e.Rchid)
                .HasMaxLength(50)
                .IsUnicode(false)
                .UseCollation("SQL_Latin1_General_CP1_CI_AS")
                .HasColumnName("RCHID");
            entity.Property(e => e.RegistrationDate)
                .HasMaxLength(30)
                .IsUnicode(false);
            entity.Property(e => e.StateName).HasMaxLength(250);
            entity.Property(e => e.Village)
                .HasMaxLength(150)
                .IsUnicode(false);
        });

        modelBuilder.Entity<ViewPwreportCountLineList>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("View_PWReportCountLineList");

            entity.Property(e => e.BenName)
                .HasMaxLength(302)
                .UseCollation("SQL_Latin1_General_CP1_CI_AS");
            entity.Property(e => e.BeneficiaryGuid)
                .HasMaxLength(50)
                .IsUnicode(false)
                .UseCollation("SQL_Latin1_General_CP1_CI_AS")
                .HasColumnName("BeneficiaryGUID");
            entity.Property(e => e.BeneficiaryId).HasColumnName("BeneficiaryID");
            entity.Property(e => e.BlockName).HasMaxLength(255);
            entity.Property(e => e.District).HasMaxLength(250);
            entity.Property(e => e.HusName)
                .HasMaxLength(302)
                .UseCollation("SQL_Latin1_General_CP1_CI_AS");
            entity.Property(e => e.Lb).HasColumnName("LB");
            entity.Property(e => e.Ld).HasColumnName("LD");
            entity.Property(e => e.Ls).HasColumnName("LS");
            entity.Property(e => e.MobileNo)
                .HasMaxLength(10)
                .IsUnicode(false)
                .UseCollation("SQL_Latin1_General_CP1_CI_AS");
            entity.Property(e => e.Rchid)
                .HasMaxLength(50)
                .IsUnicode(false)
                .UseCollation("SQL_Latin1_General_CP1_CI_AS")
                .HasColumnName("RCHID");
            entity.Property(e => e.RegistrationDate)
                .HasMaxLength(30)
                .IsUnicode(false);
            entity.Property(e => e.StateName).HasMaxLength(250);
            entity.Property(e => e.Village)
                .HasMaxLength(150)
                .IsUnicode(false);
        });

        modelBuilder.Entity<ViewPwtotalJourney>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("View_PWTotalJourney");

            entity.Property(e => e.Address).UseCollation("SQL_Latin1_General_CP1_CI_AS");
            entity.Property(e => e.AshaNameId).HasColumnName("AshaNameID");
            entity.Property(e => e.BenName)
                .HasMaxLength(302)
                .UseCollation("SQL_Latin1_General_CP1_CI_AS");
            entity.Property(e => e.BeneficeryType).HasColumnName("beneficeryType");
            entity.Property(e => e.BeneficiaryGuid)
                .HasMaxLength(50)
                .IsUnicode(false)
                .UseCollation("SQL_Latin1_General_CP1_CI_AS")
                .HasColumnName("BeneficiaryGUID");
            entity.Property(e => e.BeneficiaryId).HasColumnName("BeneficiaryID");
            entity.Property(e => e.BlockId).HasColumnName("BlockID");
            entity.Property(e => e.BlockName).HasMaxLength(255);
            entity.Property(e => e.CasteId).HasColumnName("CasteID");
            entity.Property(e => e.CreatedOn).HasColumnType("datetime");
            entity.Property(e => e.DataSourceId).HasColumnName("DataSourceID");
            entity.Property(e => e.District).HasMaxLength(250);
            entity.Property(e => e.DistrictId).HasColumnName("DistrictID");
            entity.Property(e => e.FinancialYear).UseCollation("SQL_Latin1_General_CP1_CI_AS");
            entity.Property(e => e.HealthProviderNameId).HasColumnName("HealthProviderNameID");
            entity.Property(e => e.HusbandAccountNo)
                .HasMaxLength(100)
                .IsUnicode(false)
                .UseCollation("SQL_Latin1_General_CP1_CI_AS");
            entity.Property(e => e.HusbandAdhaarNo)
                .HasMaxLength(12)
                .IsUnicode(false)
                .UseCollation("SQL_Latin1_General_CP1_CI_AS");
            entity.Property(e => e.HusbandBankId)
                .HasMaxLength(50)
                .IsUnicode(false)
                .UseCollation("SQL_Latin1_General_CP1_CI_AS")
                .HasColumnName("HusbandBankID");
            entity.Property(e => e.HusbandDob)
                .HasColumnType("datetime")
                .HasColumnName("HusbandDOB");
            entity.Property(e => e.HusbandEducationLevelId).HasColumnName("HusbandEducationLevelID");
            entity.Property(e => e.HusbandEducationLevelOther)
                .HasMaxLength(100)
                .UseCollation("SQL_Latin1_General_CP1_CI_AS");
            entity.Property(e => e.HusbandFirstName)
                .HasMaxLength(100)
                .UseCollation("SQL_Latin1_General_CP1_CI_AS");
            entity.Property(e => e.HusbandLastName)
                .HasMaxLength(100)
                .UseCollation("SQL_Latin1_General_CP1_CI_AS");
            entity.Property(e => e.HusbandMiddleName)
                .HasMaxLength(100)
                .UseCollation("SQL_Latin1_General_CP1_CI_AS");
            entity.Property(e => e.HusbandOccupationId).HasColumnName("HusbandOccupationID");
            entity.Property(e => e.HusbandOccupationOther)
                .HasMaxLength(100)
                .UseCollation("SQL_Latin1_General_CP1_CI_AS");
            entity.Property(e => e.IsHusbandAdhaarBankLinkedId).HasColumnName("IsHusbandAdhaarBankLinkedID");
            entity.Property(e => e.IsHusbandCurrentAgeId).HasColumnName("IsHusbandCurrentAgeID");
            entity.Property(e => e.IsHusbandDobid).HasColumnName("IsHusbandDOBID");
            entity.Property(e => e.IsWomanAdhaarBankLinkedId).HasColumnName("IsWomanAdhaarBankLinkedID");
            entity.Property(e => e.IsWomanCurrentAgeId).HasColumnName("IsWomanCurrentAgeID");
            entity.Property(e => e.IsWomanDobid).HasColumnName("IsWomanDOBID");
            entity.Property(e => e.Lb).HasColumnName("LB");
            entity.Property(e => e.Ld).HasColumnName("LD");
            entity.Property(e => e.Ls).HasColumnName("LS");
            entity.Property(e => e.MasterBeneficiaryGuid)
                .HasMaxLength(100)
                .UseCollation("SQL_Latin1_General_CP1_CI_AS")
                .HasColumnName("MasterBeneficiaryGUID");
            entity.Property(e => e.MobileNo)
                .HasMaxLength(10)
                .IsUnicode(false)
                .UseCollation("SQL_Latin1_General_CP1_CI_AS");
            entity.Property(e => e.MobileNoOwnerId).HasColumnName("MobileNoOwnerID");
            entity.Property(e => e.PovertyCategoryId).HasColumnName("PovertyCategoryID");
            entity.Property(e => e.QrcodeId)
                .HasMaxLength(100)
                .UseCollation("SQL_Latin1_General_CP1_CI_AS")
                .HasColumnName("QRCodeId");
            entity.Property(e => e.Rchid)
                .HasMaxLength(50)
                .IsUnicode(false)
                .UseCollation("SQL_Latin1_General_CP1_CI_AS")
                .HasColumnName("RCHID");
            entity.Property(e => e.RegistrationDate).HasColumnType("datetime");
            entity.Property(e => e.ReligionId).HasColumnName("ReligionID");
            entity.Property(e => e.RoleId).HasColumnName("RoleID");
            entity.Property(e => e.StateName).HasMaxLength(250);
            entity.Property(e => e.UpdatedOn).HasColumnType("datetime");
            entity.Property(e => e.Village)
                .HasMaxLength(150)
                .IsUnicode(false);
            entity.Property(e => e.VillageId).HasColumnName("VillageID");
            entity.Property(e => e.WomanAccountNo)
                .HasMaxLength(100)
                .IsUnicode(false)
                .UseCollation("SQL_Latin1_General_CP1_CI_AS");
            entity.Property(e => e.WomanAdhaarNo)
                .HasMaxLength(12)
                .IsUnicode(false)
                .UseCollation("SQL_Latin1_General_CP1_CI_AS");
            entity.Property(e => e.WomanBankId).HasColumnName("WomanBankID");
            entity.Property(e => e.WomanDob)
                .HasColumnType("datetime")
                .HasColumnName("WomanDOB");
            entity.Property(e => e.WomanEducationLevelId).HasColumnName("WomanEducationLevelID");
            entity.Property(e => e.WomanEducationLevelOther)
                .HasMaxLength(100)
                .UseCollation("SQL_Latin1_General_CP1_CI_AS");
            entity.Property(e => e.WomanFirstName)
                .HasMaxLength(100)
                .UseCollation("SQL_Latin1_General_CP1_CI_AS");
            entity.Property(e => e.WomanLastName)
                .HasMaxLength(100)
                .UseCollation("SQL_Latin1_General_CP1_CI_AS");
            entity.Property(e => e.WomanMiddleName)
                .HasMaxLength(100)
                .UseCollation("SQL_Latin1_General_CP1_CI_AS");
            entity.Property(e => e.WomanOccupationId).HasColumnName("WomanOccupationID");
            entity.Property(e => e.WomanOccupationOther)
                .HasMaxLength(100)
                .UseCollation("SQL_Latin1_General_CP1_CI_AS");
            entity.Property(e => e.YoungChildAgeMonthId).HasColumnName("YoungChildAgeMonthID");
            entity.Property(e => e.YoungChildAgeYearId).HasColumnName("YoungChildAgeYearID");
            entity.Property(e => e.YoungChildGenderId).HasColumnName("YoungChildGenderID");
        });

        modelBuilder.Entity<ViewRegistration>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("View_Registration");

            entity.Property(e => e.District).HasMaxLength(250);
            entity.Property(e => e.Percentage).HasColumnType("decimal(5, 2)");
            entity.Property(e => e.RegisteredPw).HasColumnName("RegisteredPW");
            entity.Property(e => e.StateName).HasMaxLength(250);
            entity.Property(e => e.TotalPw).HasColumnName("TotalPW");
            entity.Property(e => e.Village)
                .HasMaxLength(150)
                .IsUnicode(false);
        });

        modelBuilder.Entity<ViewSyncTblBeneficiary>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("View_Sync_tblBeneficiary");

            entity.Property(e => e.Address).UseCollation("SQL_Latin1_General_CP1_CI_AS");
            entity.Property(e => e.AshaNameId).HasColumnName("AshaNameID");
            entity.Property(e => e.BeneficeryType).HasColumnName("beneficeryType");
            entity.Property(e => e.BeneficiaryGuid)
                .HasMaxLength(50)
                .IsUnicode(false)
                .UseCollation("SQL_Latin1_General_CP1_CI_AS")
                .HasColumnName("BeneficiaryGUID");
            entity.Property(e => e.BeneficiaryId)
                .ValueGeneratedOnAdd()
                .HasColumnName("BeneficiaryID");
            entity.Property(e => e.CasteId).HasColumnName("CasteID");
            entity.Property(e => e.CreatedOn).HasColumnType("datetime");
            entity.Property(e => e.DataSourceId).HasColumnName("DataSourceID");
            entity.Property(e => e.HealthProviderNameId).HasColumnName("HealthProviderNameID");
            entity.Property(e => e.HusbandAccountNo)
                .HasMaxLength(100)
                .IsUnicode(false)
                .UseCollation("SQL_Latin1_General_CP1_CI_AS");
            entity.Property(e => e.HusbandAdhaarNo)
                .HasMaxLength(12)
                .IsUnicode(false)
                .UseCollation("SQL_Latin1_General_CP1_CI_AS");
            entity.Property(e => e.HusbandBankId)
                .HasMaxLength(50)
                .IsUnicode(false)
                .UseCollation("SQL_Latin1_General_CP1_CI_AS")
                .HasColumnName("HusbandBankID");
            entity.Property(e => e.HusbandDob)
                .HasColumnType("datetime")
                .HasColumnName("HusbandDOB");
            entity.Property(e => e.HusbandEducationLevelId).HasColumnName("HusbandEducationLevelID");
            entity.Property(e => e.HusbandEducationLevelOther)
                .HasMaxLength(100)
                .UseCollation("SQL_Latin1_General_CP1_CI_AS");
            entity.Property(e => e.HusbandFirstName)
                .HasMaxLength(100)
                .UseCollation("SQL_Latin1_General_CP1_CI_AS");
            entity.Property(e => e.HusbandLastName)
                .HasMaxLength(100)
                .UseCollation("SQL_Latin1_General_CP1_CI_AS");
            entity.Property(e => e.HusbandMiddleName)
                .HasMaxLength(100)
                .UseCollation("SQL_Latin1_General_CP1_CI_AS");
            entity.Property(e => e.HusbandOccupationId).HasColumnName("HusbandOccupationID");
            entity.Property(e => e.HusbandOccupationOther)
                .HasMaxLength(100)
                .UseCollation("SQL_Latin1_General_CP1_CI_AS");
            entity.Property(e => e.IsHusbandAdhaarBankLinkedId).HasColumnName("IsHusbandAdhaarBankLinkedID");
            entity.Property(e => e.IsHusbandCurrentAgeId).HasColumnName("IsHusbandCurrentAgeID");
            entity.Property(e => e.IsHusbandDobid).HasColumnName("IsHusbandDOBID");
            entity.Property(e => e.IsWomanAdhaarBankLinkedId).HasColumnName("IsWomanAdhaarBankLinkedID");
            entity.Property(e => e.IsWomanCurrentAgeId).HasColumnName("IsWomanCurrentAgeID");
            entity.Property(e => e.IsWomanDobid).HasColumnName("IsWomanDOBID");
            entity.Property(e => e.MobileNo)
                .HasMaxLength(10)
                .IsUnicode(false)
                .UseCollation("SQL_Latin1_General_CP1_CI_AS");
            entity.Property(e => e.MobileNoOwnerId).HasColumnName("MobileNoOwnerID");
            entity.Property(e => e.PovertyCategoryId).HasColumnName("PovertyCategoryID");
            entity.Property(e => e.Rchid)
                .HasMaxLength(50)
                .IsUnicode(false)
                .UseCollation("SQL_Latin1_General_CP1_CI_AS")
                .HasColumnName("RCHID");
            entity.Property(e => e.RegistrationDate).HasColumnType("datetime");
            entity.Property(e => e.ReligionId).HasColumnName("ReligionID");
            entity.Property(e => e.UpdatedOn).HasColumnType("datetime");
            entity.Property(e => e.VillageId).HasColumnName("VillageID");
            entity.Property(e => e.WomanAccountNo)
                .HasMaxLength(100)
                .IsUnicode(false)
                .UseCollation("SQL_Latin1_General_CP1_CI_AS");
            entity.Property(e => e.WomanAdhaarNo)
                .HasMaxLength(12)
                .IsUnicode(false)
                .UseCollation("SQL_Latin1_General_CP1_CI_AS");
            entity.Property(e => e.WomanBankId).HasColumnName("WomanBankID");
            entity.Property(e => e.WomanDob)
                .HasColumnType("datetime")
                .HasColumnName("WomanDOB");
            entity.Property(e => e.WomanEducationLevelId).HasColumnName("WomanEducationLevelID");
            entity.Property(e => e.WomanEducationLevelOther)
                .HasMaxLength(100)
                .UseCollation("SQL_Latin1_General_CP1_CI_AS");
            entity.Property(e => e.WomanFirstName)
                .HasMaxLength(100)
                .UseCollation("SQL_Latin1_General_CP1_CI_AS");
            entity.Property(e => e.WomanLastName)
                .HasMaxLength(100)
                .UseCollation("SQL_Latin1_General_CP1_CI_AS");
            entity.Property(e => e.WomanMiddleName)
                .HasMaxLength(100)
                .UseCollation("SQL_Latin1_General_CP1_CI_AS");
            entity.Property(e => e.WomanOccupationId).HasColumnName("WomanOccupationID");
            entity.Property(e => e.WomanOccupationOther)
                .HasMaxLength(100)
                .UseCollation("SQL_Latin1_General_CP1_CI_AS");
            entity.Property(e => e.YoungChildAgeMonthId).HasColumnName("YoungChildAgeMonthID");
            entity.Property(e => e.YoungChildAgeYearId).HasColumnName("YoungChildAgeYearID");
            entity.Property(e => e.YoungChildGenderId).HasColumnName("YoungChildGenderID");
        });

        modelBuilder.Entity<ViewTblAncdetail>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("View_tblANCDetail");

            entity.Property(e => e.AbortionDate)
                .HasMaxLength(30)
                .IsUnicode(false);
            entity.Property(e => e.AbortionTypeId).HasColumnName("AbortionTypeID");
            entity.Property(e => e.Ancguid)
                .HasMaxLength(50)
                .IsUnicode(false)
                .UseCollation("SQL_Latin1_General_CP1_CI_AS")
                .HasColumnName("ANCGUID");
            entity.Property(e => e.Ancid).HasColumnName("ANCID");
            entity.Property(e => e.AncvisitDate)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("ANCVisitDate");
            entity.Property(e => e.AncvisitId).HasColumnName("ANCVisitID");
            entity.Property(e => e.BeneficiaryGuid)
                .HasMaxLength(100)
                .UseCollation("SQL_Latin1_General_CP1_CI_AS")
                .HasColumnName("BeneficiaryGUID");
            entity.Property(e => e.Bpdiastolic).HasColumnName("BPDiastolic");
            entity.Property(e => e.Bpsystolic).HasColumnName("BPSystolic");
            entity.Property(e => e.CreatedOn).HasColumnType("datetime");
            entity.Property(e => e.DataSourceId).HasColumnName("DataSourceID");
            entity.Property(e => e.DeathCauseMdrcommitteeId)
                .HasMaxLength(50)
                .IsUnicode(false)
                .UseCollation("SQL_Latin1_General_CP1_CI_AS")
                .HasColumnName("DeathCauseMDRCommitteeID");
            entity.Property(e => e.DeathCauseMdrcommitteeOther)
                .HasMaxLength(50)
                .IsUnicode(false)
                .UseCollation("SQL_Latin1_General_CP1_CI_AS")
                .HasColumnName("DeathCauseMDRCommitteeOther");
            entity.Property(e => e.DeathDate).HasColumnType("datetime");
            entity.Property(e => e.DeathPlaceId).HasColumnName("DeathPlaceID");
            entity.Property(e => e.DeathPlaceOther)
                .HasMaxLength(50)
                .IsUnicode(false)
                .UseCollation("SQL_Latin1_General_CP1_CI_AS");
            entity.Property(e => e.FacilityNameId).HasColumnName("FacilityNameID");
            entity.Property(e => e.FacilityNameOther)
                .HasMaxLength(50)
                .IsUnicode(false)
                .UseCollation("SQL_Latin1_General_CP1_CI_AS");
            entity.Property(e => e.FacilityTypeId).HasColumnName("FacilityTypeID");
            entity.Property(e => e.FoetalMovementId).HasColumnName("FoetalMovementID");
            entity.Property(e => e.FoetalPresentationId).HasColumnName("FoetalPresentationID");
            entity.Property(e => e.FundalHeightUterusSizeId).HasColumnName("FundalHeightUterusSizeID");
            entity.Property(e => e.Hb)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("HB");
            entity.Property(e => e.HighRiskFacilityTypeId).HasColumnName("HighRiskFacilityTypeID");
            entity.Property(e => e.HighRiskSymptomOther)
                .HasMaxLength(250)
                .IsUnicode(false)
                .UseCollation("SQL_Latin1_General_CP1_CI_AS");
            entity.Property(e => e.InducedFacilityTypeId).HasColumnName("InducedFacilityTypeID");
            entity.Property(e => e.IsAlbendazoleTabId).HasColumnName("IsAlbendazoleTabID");
            entity.Property(e => e.IsBirthCompanionIdentifyId).HasColumnName("IsBirthCompanionIdentifyID");
            entity.Property(e => e.IsBloodSugarTestId).HasColumnName("IsBloodSugarTestID");
            entity.Property(e => e.IsBp).HasColumnName("IsBP");
            entity.Property(e => e.IsBpsystolicId).HasColumnName("IsBPSystolicID");
            entity.Property(e => e.IsHbid).HasColumnName("IsHBID");
            entity.Property(e => e.IsJsskschemeId).HasColumnName("IsJSSKSchemeID");
            entity.Property(e => e.IsMaternalDeathId).HasColumnName("IsMaternalDeathID");
            entity.Property(e => e.IsUltrasoundScreeningId).HasColumnName("IsUltrasoundScreeningID");
            entity.Property(e => e.IsUrineTestId).HasColumnName("IsUrineTestID");
            entity.Property(e => e.IsVisitPmsma).HasColumnName("IsVisitPMSMA");
            entity.Property(e => e.MethodUsedId).HasColumnName("MethodUsedID");
            entity.Property(e => e.OgtttestFirst).HasColumnName("OGTTTestFirst");
            entity.Property(e => e.OgtttestSecond).HasColumnName("OGTTTestSecond");
            entity.Property(e => e.PlaceNameId).HasColumnName("PlaceNameID");
            entity.Property(e => e.PlaceNameOther)
                .HasMaxLength(50)
                .IsUnicode(false)
                .UseCollation("SQL_Latin1_General_CP1_CI_AS");
            entity.Property(e => e.PostAbortionContracepDetailId).HasColumnName("PostAbortionContracepDetailID");
            entity.Property(e => e.PreferredContraceptivemethodafterdeliveryId).HasColumnName("PreferredContraceptivemethodafterdeliveryID");
            entity.Property(e => e.PwcategoryGuid)
                .HasMaxLength(100)
                .UseCollation("SQL_Latin1_General_CP1_CI_AS")
                .HasColumnName("PWCategoryGUID");
            entity.Property(e => e.PwreferDate)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("PWReferDate");
            entity.Property(e => e.Pwweight)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("PWWeight");
            entity.Property(e => e.ReferralFacilityId).HasColumnName("ReferralFacilityID");
            entity.Property(e => e.TotalCalciumVd3tab).HasColumnName("TotalCalciumVD3Tab");
            entity.Property(e => e.TotalIfatab).HasColumnName("TotalIFATab");
            entity.Property(e => e.TotalPregnancyWeekId).HasColumnName("TotalPregnancyWeekID");
            entity.Property(e => e.TttddoseDate)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("TTTDDoseDate");
            entity.Property(e => e.TttddoseId).HasColumnName("TTTDDoseID");
            entity.Property(e => e.UpdatedOn).HasColumnType("datetime");
            entity.Property(e => e.UrineAlbuminId).HasColumnName("UrineAlbuminID");
            entity.Property(e => e.UrineSugarId).HasColumnName("UrineSugarID");
        });

        modelBuilder.Entity<ViewTblChildHomeVisit>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("View_tblChildHomeVisit");

            entity.Property(e => e.AgeAppropriateIr).HasColumnName("AgeAppropriateIR");
            entity.Property(e => e.BeneficiaryGuid)
                .HasMaxLength(50)
                .IsUnicode(false)
                .UseCollation("SQL_Latin1_General_CP1_CI_AS")
                .HasColumnName("BeneficiaryGUID");
            entity.Property(e => e.BottleIfaprovided).HasColumnName("BottleIFAProvided");
            entity.Property(e => e.Cf12katori23TimesDay).HasColumnName("CF12Katori23TimesDay");
            entity.Property(e => e.Cf12katori34TimesDay).HasColumnName("CF12Katori34TimesDay");
            entity.Property(e => e.Cf23tablespoon).HasColumnName("CF23tablespoon");
            entity.Property(e => e.Cf34katori34TimesDay).HasColumnName("CF34Katori34TimesDay");
            entity.Property(e => e.ChildGreenZoneMcpcard).HasColumnName("ChildGreenZoneMCPCard");
            entity.Property(e => e.ChildImmunizationGuid)
                .HasMaxLength(50)
                .IsUnicode(false)
                .UseCollation("SQL_Latin1_General_CP1_CI_AS")
                .HasColumnName("ChildImmunizationGUID");
            entity.Property(e => e.ChildRegisGuid)
                .HasMaxLength(50)
                .IsUnicode(false)
                .UseCollation("SQL_Latin1_General_CP1_CI_AS")
                .HasColumnName("ChildRegisGUID");
            entity.Property(e => e.CreatedOn)
                .HasMaxLength(30)
                .IsUnicode(false);
            entity.Property(e => e.DataSourceId).HasColumnName("DataSourceID");
            entity.Property(e => e.DateofVisit)
                .HasMaxLength(30)
                .IsUnicode(false);
            entity.Property(e => e.HomeVisitGuid)
                .HasMaxLength(50)
                .IsUnicode(false)
                .UseCollation("SQL_Latin1_General_CP1_CI_AS")
                .HasColumnName("HomeVisitGUID");
            entity.Property(e => e.HomeVisitId).HasColumnName("HomeVisitID");
            entity.Property(e => e.Mcbreastfeeding).HasColumnName("MCBreastfeeding");
            entity.Property(e => e.McfamilyPlanning).HasColumnName("MCFamilyPlanning");
            entity.Property(e => e.MchandWashing).HasColumnName("MCHandWashing");
            entity.Property(e => e.McpcardAccessDevelopment).HasColumnName("MCPCardAccessDevelopment");
            entity.Property(e => e.Orsprovided).HasColumnName("ORSProvided");
            entity.Property(e => e.PwcategoryGuid)
                .HasMaxLength(50)
                .IsUnicode(false)
                .UseCollation("SQL_Latin1_General_CP1_CI_AS")
                .HasColumnName("PWCategoryGUID");
            entity.Property(e => e.RecordingWeightAgeAww).HasColumnName("RecordingWeightAgeAWW");
            entity.Property(e => e.RecordingWeightLengthAww).HasColumnName("RecordingWeightLengthAWW");
            entity.Property(e => e.RedFlagSignDi).HasColumnName("RedFlagSignDI");
            entity.Property(e => e.UpdatedOn)
                .HasMaxLength(30)
                .IsUnicode(false);
        });

        modelBuilder.Entity<ViewTblChildImmunization>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("View_tblChildImmunization");

            entity.Property(e => e.AefireportedId).HasColumnName("AEFIreportedID");
            entity.Property(e => e.AshaNameId).HasColumnName("AshaNameID");
            entity.Property(e => e.BeneficiaryGuid)
                .HasMaxLength(50)
                .IsUnicode(false)
                .UseCollation("SQL_Latin1_General_CP1_CI_AS")
                .HasColumnName("BeneficiaryGUID");
            entity.Property(e => e.ChildImmunizationGuid)
                .HasMaxLength(50)
                .IsUnicode(false)
                .UseCollation("SQL_Latin1_General_CP1_CI_AS")
                .HasColumnName("ChildImmunizationGUID");
            entity.Property(e => e.ChildImmunizationId).HasColumnName("ChildImmunizationID");
            entity.Property(e => e.ChildRegisGuid)
                .HasMaxLength(50)
                .IsUnicode(false)
                .UseCollation("SQL_Latin1_General_CP1_CI_AS")
                .HasColumnName("ChildRegisGUID");
            entity.Property(e => e.Ci2yearsAge).HasColumnName("CI2yearsAge");
            entity.Property(e => e.Ci6months).HasColumnName("CI6months");
            entity.Property(e => e.ClosureReasonId).HasColumnName("ClosureReasonID");
            entity.Property(e => e.CreatedOn)
                .HasMaxLength(30)
                .IsUnicode(false);
            entity.Property(e => e.DataSourceId).HasColumnName("DataSourceID");
            entity.Property(e => e.DateofDeath)
                .HasMaxLength(30)
                .IsUnicode(false);
            entity.Property(e => e.DateofVisit)
                .HasMaxLength(30)
                .IsUnicode(false);
            entity.Property(e => e.Ebf6months).HasColumnName("EBF6months");
            entity.Property(e => e.FbircompletedId).HasColumnName("FBIRCompletedID");
            entity.Property(e => e.Fi12monthsAge).HasColumnName("FI12MonthsAge");
            entity.Property(e => e.HealthProviderNameId).HasColumnName("HealthProviderNameID");
            entity.Property(e => e.ImmunizationDate)
                .HasMaxLength(30)
                .IsUnicode(false);
            entity.Property(e => e.ImmunizationId).HasColumnName("ImmunizationID");
            entity.Property(e => e.Notificatiosent24hrsId).HasColumnName("Notificatiosent24hrsID");
            entity.Property(e => e.Orsgiven).HasColumnName("ORSGiven");
            entity.Property(e => e.OtherDeathCause)
                .HasMaxLength(50)
                .IsUnicode(false)
                .UseCollation("SQL_Latin1_General_CP1_CI_AS");
            entity.Property(e => e.PlaceId).HasColumnName("PlaceID");
            entity.Property(e => e.PlaceNameOther)
                .HasMaxLength(50)
                .IsUnicode(false)
                .UseCollation("SQL_Latin1_General_CP1_CI_AS");
            entity.Property(e => e.ProbableCauseofDeathId).HasColumnName("ProbableCauseofDeathID");
            entity.Property(e => e.PwcategoryGuid)
                .HasMaxLength(50)
                .IsUnicode(false)
                .UseCollation("SQL_Latin1_General_CP1_CI_AS")
                .HasColumnName("PWCategoryGUID");
            entity.Property(e => e.Remarks)
                .HasMaxLength(50)
                .IsUnicode(false)
                .UseCollation("SQL_Latin1_General_CP1_CI_AS");
            entity.Property(e => e.SeriousReasonId).HasColumnName("SeriousReasonID");
            entity.Property(e => e.UpdatedOn)
                .HasMaxLength(30)
                .IsUnicode(false);
            entity.Property(e => e.VaccineBatch)
                .HasMaxLength(50)
                .IsUnicode(false)
                .UseCollation("SQL_Latin1_General_CP1_CI_AS");
            entity.Property(e => e.VaccineExpDate)
                .HasMaxLength(30)
                .IsUnicode(false);
            entity.Property(e => e.VaccineManufacturer)
                .HasMaxLength(50)
                .IsUnicode(false)
                .UseCollation("SQL_Latin1_General_CP1_CI_AS");
            entity.Property(e => e.VaccineName)
                .HasMaxLength(50)
                .IsUnicode(false)
                .UseCollation("SQL_Latin1_General_CP1_CI_AS");
            entity.Property(e => e.WeightofChild).HasColumnType("decimal(18, 0)");
            entity.Property(e => e.ZincGivenOrs).HasColumnName("ZincGivenORS");
        });

        modelBuilder.Entity<ViewTblChildPncdetail>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("View_tblChildPNCDetail");

            entity.Property(e => e.BabyWeight).HasColumnType("decimal(18, 0)");
            entity.Property(e => e.BeneficiaryGuid)
                .HasMaxLength(50)
                .IsUnicode(false)
                .UseCollation("SQL_Latin1_General_CP1_CI_AS")
                .HasColumnName("BeneficiaryGUID");
            entity.Property(e => e.ChildPncguid)
                .HasMaxLength(50)
                .IsUnicode(false)
                .UseCollation("SQL_Latin1_General_CP1_CI_AS")
                .HasColumnName("ChildPNCGUID");
            entity.Property(e => e.ChildPncid).HasColumnName("ChildPNCID");
            entity.Property(e => e.ChildRegisGuid)
                .HasMaxLength(50)
                .IsUnicode(false)
                .UseCollation("SQL_Latin1_General_CP1_CI_AS")
                .HasColumnName("ChildRegisGUID");
            entity.Property(e => e.CreatedOn).HasColumnType("datetime");
            entity.Property(e => e.DataSourceId).HasColumnName("DataSourceID");
            entity.Property(e => e.HbncvisitDate)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("HBNCVisitDate");
            entity.Property(e => e.HbncvisitId).HasColumnName("HBNCVisitID");
            entity.Property(e => e.InfantRemarks).UseCollation("SQL_Latin1_General_CP1_CI_AS");
            entity.Property(e => e.IsBabyFacilityNameOther)
                .HasMaxLength(100)
                .UseCollation("SQL_Latin1_General_CP1_CI_AS");
            entity.Property(e => e.IsBabyInfantDeathCauseOther)
                .HasMaxLength(100)
                .UseCollation("SQL_Latin1_General_CP1_CI_AS");
            entity.Property(e => e.IsInfantNotifiedByAshaid).HasColumnName("IsInfantNotifiedByASHAID");
            entity.Property(e => e.IsinfantFbirbyAnmid).HasColumnName("ISInfantFBIRByANMID");
            entity.Property(e => e.LastVisitDate)
                .HasMaxLength(30)
                .IsUnicode(false);
            entity.Property(e => e.OtherDangerSign)
                .HasMaxLength(100)
                .UseCollation("SQL_Latin1_General_CP1_CI_AS");
            entity.Property(e => e.PwcategoryGuid)
                .HasMaxLength(50)
                .IsUnicode(false)
                .UseCollation("SQL_Latin1_General_CP1_CI_AS")
                .HasColumnName("PWCategoryGUID");
            entity.Property(e => e.UpdatedOn).HasColumnType("datetime");
        });

        modelBuilder.Entity<ViewTblDeliveryDetail>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("View_tblDeliveryDetail");

            entity.Property(e => e.Bcgdate)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("BCGDate");
            entity.Property(e => e.BeneficiaryGuid)
                .HasMaxLength(50)
                .IsUnicode(false)
                .UseCollation("SQL_Latin1_General_CP1_CI_AS")
                .HasColumnName("BeneficiaryGUID");
            entity.Property(e => e.BirthPhysicalDefectId).HasColumnName("BirthPhysicalDefectID");
            entity.Property(e => e.BirthWeight).HasColumnType("decimal(18, 1)");
            entity.Property(e => e.CreatedOn).HasColumnType("datetime");
            entity.Property(e => e.DataSourceId).HasColumnName("DataSourceID");
            entity.Property(e => e.DelDetGuid)
                .HasMaxLength(50)
                .IsUnicode(false)
                .UseCollation("SQL_Latin1_General_CP1_CI_AS")
                .HasColumnName("DelDetGUID");
            entity.Property(e => e.DelDetId).HasColumnName("DelDetID");
            entity.Property(e => e.Dob)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("DOB");
            entity.Property(e => e.DoseId).HasColumnName("DoseID");
            entity.Property(e => e.HepbOdate)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("HEPB_ODate");
            entity.Property(e => e.InfantGenderId).HasColumnName("InfantGenderID");
            entity.Property(e => e.IsBabyCryImmediateId).HasColumnName("IsBabyCryImmediateID");
            entity.Property(e => e.IsBreastFeedStartId).HasColumnName("IsBreastFeedStartID");
            entity.Property(e => e.IsCorticosteroidId).HasColumnName("IsCorticosteroidID");
            entity.Property(e => e.IsHigherFacilityReferId).HasColumnName("IsHigherFacilityReferID");
            entity.Property(e => e.IsOpv0).HasColumnName("IsOPV0");
            entity.Property(e => e.MaturityId)
                .HasMaxLength(50)
                .IsUnicode(false)
                .UseCollation("SQL_Latin1_General_CP1_CI_AS")
                .HasColumnName("MaturityID");
            entity.Property(e => e.Opvodate)
                .HasColumnType("datetime")
                .HasColumnName("OPVODate");
            entity.Property(e => e.PwcategoryGuid)
                .HasMaxLength(100)
                .UseCollation("SQL_Latin1_General_CP1_CI_AS")
                .HasColumnName("PWCategoryGUID");
            entity.Property(e => e.Rchidno).HasColumnName("RCHIDNo");
            entity.Property(e => e.SncuadmissionNo)
                .HasMaxLength(50)
                .IsUnicode(false)
                .UseCollation("SQL_Latin1_General_CP1_CI_AS")
                .HasColumnName("SNCUAdmissionNo");
            entity.Property(e => e.UpdatedOn).HasColumnType("datetime");
            entity.Property(e => e.VitKdate)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("VIT_KDate");
        });

        modelBuilder.Entity<ViewTblDeliveryOutcome>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("View_tblDeliveryOutcome");

            entity.Property(e => e.BeneficiaryGuid)
                .HasMaxLength(100)
                .UseCollation("SQL_Latin1_General_CP1_CI_AS")
                .HasColumnName("BeneficiaryGUID");
            entity.Property(e => e.ConductDeliveryId).HasColumnName("ConductDeliveryID");
            entity.Property(e => e.ConductDeliveryOther)
                .HasMaxLength(50)
                .IsUnicode(false)
                .UseCollation("SQL_Latin1_General_CP1_CI_AS");
            entity.Property(e => e.CreatedOn).HasColumnType("datetime");
            entity.Property(e => e.DataSourceId).HasColumnName("DataSourceID");
            entity.Property(e => e.DeathDate).HasColumnType("datetime");
            entity.Property(e => e.DeathFacilityTypeId)
                .HasMaxLength(10)
                .IsFixedLength()
                .UseCollation("SQL_Latin1_General_CP1_CI_AS")
                .HasColumnName("DeathFacilityTypeID");
            entity.Property(e => e.DeathPlaceId).HasColumnName("DeathPlaceID");
            entity.Property(e => e.DeathPlaceOther)
                .HasMaxLength(50)
                .IsUnicode(false)
                .UseCollation("SQL_Latin1_General_CP1_CI_AS");
            entity.Property(e => e.DelOutGuid)
                .HasMaxLength(50)
                .IsUnicode(false)
                .UseCollation("SQL_Latin1_General_CP1_CI_AS")
                .HasColumnName("DelOutGUID");
            entity.Property(e => e.DelOutId).HasColumnName("DelOutID");
            entity.Property(e => e.DeliveryComplicationId).HasColumnName("DeliveryComplicationID");
            entity.Property(e => e.DeliveryComplicationOther)
                .HasMaxLength(50)
                .IsUnicode(false)
                .UseCollation("SQL_Latin1_General_CP1_CI_AS");
            entity.Property(e => e.DeliveryDate)
                .HasMaxLength(30)
                .IsUnicode(false);
            entity.Property(e => e.DeliveryOutcomeId).HasColumnName("DeliveryOutcomeID");
            entity.Property(e => e.DeliveryPlaceId).HasColumnName("DeliveryPlaceID");
            entity.Property(e => e.DeliveryPlaceOther)
                .HasMaxLength(50)
                .IsUnicode(false)
                .UseCollation("SQL_Latin1_General_CP1_CI_AS");
            entity.Property(e => e.DeliveryTime)
                .HasMaxLength(20)
                .UseCollation("SQL_Latin1_General_CP1_CI_AS");
            entity.Property(e => e.DeliveryTimeHh).HasColumnName("DeliveryTimeHH");
            entity.Property(e => e.DeliveryTypeId).HasColumnName("DeliveryTypeID");
            entity.Property(e => e.DischargeDate)
                .HasMaxLength(30)
                .IsUnicode(false);
            entity.Property(e => e.DischargeTime)
                .HasMaxLength(20)
                .UseCollation("SQL_Latin1_General_CP1_CI_AS");
            entity.Property(e => e.DischargeTimeHh).HasColumnName("DischargeTimeHH");
            entity.Property(e => e.DischargeTimeMm).HasColumnName("DischargeTimeMM");
            entity.Property(e => e.DischargeTimeZoneId).HasColumnName("DischargeTimeZoneID");
            entity.Property(e => e.FacilityTypeId).HasColumnName("FacilityTypeID");
            entity.Property(e => e.FacilityTypeOther)
                .HasMaxLength(50)
                .IsUnicode(false)
                .UseCollation("SQL_Latin1_General_CP1_CI_AS");
            entity.Property(e => e.IsFbircomplete).HasColumnName("IsFBIRComplete");
            entity.Property(e => e.IsFreshId).HasColumnName("IsFreshID");
            entity.Property(e => e.IsJsybeneficiaryId).HasColumnName("IsJSYBeneficiaryID");
            entity.Property(e => e.IsMaceratedId).HasColumnName("IsMaceratedID");
            entity.Property(e => e.IsMaternalDeathId).HasColumnName("IsMaternalDeathID");
            entity.Property(e => e.IsNeonatalDeathFbircompleteId).HasColumnName("IsNeonatalDeathFBIRCompleteID");
            entity.Property(e => e.IsNeonatalDeathNotificationId).HasColumnName("IsNeonatalDeathNotificationID");
            entity.Property(e => e.IsNotiifcationId).HasColumnName("IsNotiifcationID");
            entity.Property(e => e.IsPaymentRecievedId).HasColumnName("IsPaymentRecievedID");
            entity.Property(e => e.MisoprostolTabId).HasColumnName("MisoprostolTabID");
            entity.Property(e => e.NeonatalDeathDate).HasColumnType("datetime");
            entity.Property(e => e.NeonatalDeathPlaceId).HasColumnName("NeonatalDeathPlaceID");
            entity.Property(e => e.NeonatalDeathPlaceOther)
                .HasMaxLength(50)
                .IsUnicode(false)
                .UseCollation("SQL_Latin1_General_CP1_CI_AS");
            entity.Property(e => e.NeonatalDeathReasonId).HasColumnName("NeonatalDeathReasonID");
            entity.Property(e => e.NeonatalDeathReasonOther)
                .HasMaxLength(50)
                .IsUnicode(false)
                .UseCollation("SQL_Latin1_General_CP1_CI_AS");
            entity.Property(e => e.NeonatalFacilityTypeId).HasColumnName("NeonatalFacilityTypeID");
            entity.Property(e => e.NeonatalFacilityTypeOther)
                .HasMaxLength(100)
                .UseCollation("SQL_Latin1_General_CP1_CI_AS");
            entity.Property(e => e.NonobstetriccomplicationId)
                .HasMaxLength(50)
                .IsUnicode(false)
                .UseCollation("SQL_Latin1_General_CP1_CI_AS")
                .HasColumnName("NonobstetriccomplicationID");
            entity.Property(e => e.PwcategoryGuid)
                .HasMaxLength(100)
                .UseCollation("SQL_Latin1_General_CP1_CI_AS")
                .HasColumnName("PWCategoryGUID");
            entity.Property(e => e.ReasonId)
                .HasMaxLength(50)
                .IsUnicode(false)
                .UseCollation("SQL_Latin1_General_CP1_CI_AS")
                .HasColumnName("ReasonID");
            entity.Property(e => e.TotalLiveBirthId).HasColumnName("TotalLiveBirthID");
            entity.Property(e => e.TotalStillBirthId).HasColumnName("TotalStillBirthID");
            entity.Property(e => e.UpdatedOn).HasColumnType("datetime");
        });

        modelBuilder.Entity<ViewTblDischargeNote>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("View_tblDischargeNotes");

            entity.Property(e => e.AdmissionGuid)
                .HasMaxLength(50)
                .IsUnicode(false)
                .UseCollation("SQL_Latin1_General_CP1_CI_AS")
                .HasColumnName("AdmissionGUID");
            entity.Property(e => e.BabyDangerId)
                .HasMaxLength(50)
                .IsUnicode(false)
                .UseCollation("SQL_Latin1_General_CP1_CI_AS");
            entity.Property(e => e.BabyNeedAntibioticsId)
                .HasMaxLength(50)
                .IsUnicode(false)
                .UseCollation("SQL_Latin1_General_CP1_CI_AS");
            entity.Property(e => e.BabyTemperature).HasColumnType("decimal(18, 0)");
            entity.Property(e => e.BabyWeight).HasColumnType("decimal(18, 0)");
            entity.Property(e => e.BeneficiaryGuid)
                .HasMaxLength(50)
                .IsUnicode(false)
                .UseCollation("SQL_Latin1_General_CP1_CI_AS")
                .HasColumnName("BeneficiaryGUID");
            entity.Property(e => e.Bpdistolic).HasColumnName("BPDistolic");
            entity.Property(e => e.Bpsystolic).HasColumnName("BPSystolic");
            entity.Property(e => e.CreatedOn).HasColumnType("datetime");
            entity.Property(e => e.DataSourceId).HasColumnName("DataSourceID");
            entity.Property(e => e.Date).HasColumnType("datetime");
            entity.Property(e => e.DischargeNoteGuid)
                .HasMaxLength(50)
                .IsUnicode(false)
                .UseCollation("SQL_Latin1_General_CP1_CI_AS")
                .HasColumnName("DischargeNoteGUID");
            entity.Property(e => e.DischargeNoteId)
                .ValueGeneratedOnAdd()
                .HasColumnName("DischargeNoteID");
            entity.Property(e => e.FamilyPlanningMethodOther)
                .HasMaxLength(50)
                .IsUnicode(false)
                .UseCollation("SQL_Latin1_General_CP1_CI_AS");
            entity.Property(e => e.Hb).HasColumnName("HB");
            entity.Property(e => e.Hiv).HasColumnName("HIV");
            entity.Property(e => e.MotherDangerId)
                .HasMaxLength(50)
                .IsUnicode(false)
                .UseCollation("SQL_Latin1_General_CP1_CI_AS");
            entity.Property(e => e.MotherNeedAntibioticsId)
                .HasMaxLength(50)
                .IsUnicode(false)
                .UseCollation("SQL_Latin1_General_CP1_CI_AS");
            entity.Property(e => e.MotherTemprature).HasColumnType("decimal(18, 0)");
            entity.Property(e => e.Ogtt).HasColumnName("OGTT");
            entity.Property(e => e.ProviderName)
                .HasMaxLength(50)
                .IsUnicode(false)
                .UseCollation("SQL_Latin1_General_CP1_CI_AS");
            entity.Property(e => e.PwcategoryGuid)
                .HasMaxLength(50)
                .IsUnicode(false)
                .UseCollation("SQL_Latin1_General_CP1_CI_AS")
                .HasColumnName("PWCategoryGUID");
            entity.Property(e => e.Rbs).HasColumnName("RBS");
            entity.Property(e => e.UpdatedOn).HasColumnType("datetime");
        });

        modelBuilder.Entity<ViewTblEccategory>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("View_tblECcategory");

            entity.Property(e => e.AlternativeMethodProvidedId).HasColumnName("AlternativeMethodProvidedID");
            entity.Property(e => e.BeneficiaryGuid)
                .HasMaxLength(50)
                .IsUnicode(false)
                .UseCollation("SQL_Latin1_General_CP1_CI_AS")
                .HasColumnName("BeneficiaryGUID");
            entity.Property(e => e.ContraceptiveMethodId).HasColumnName("ContraceptiveMethodID");
            entity.Property(e => e.ContraceptiveMethodOther)
                .HasMaxLength(100)
                .IsUnicode(false)
                .UseCollation("SQL_Latin1_General_CP1_CI_AS");
            entity.Property(e => e.ContraceptiveMethodSwitchDiscontinuationId).HasColumnName("ContraceptiveMethodSwitchDiscontinuationID");
            entity.Property(e => e.CreatedOn).HasColumnType("datetime");
            entity.Property(e => e.DataSourceId).HasColumnName("DataSourceID");
            entity.Property(e => e.DeathDate).HasColumnType("datetime");
            entity.Property(e => e.DeathPlace)
                .HasMaxLength(50)
                .IsUnicode(false)
                .UseCollation("SQL_Latin1_General_CP1_CI_AS");
            entity.Property(e => e.DeathReason)
                .HasMaxLength(100)
                .IsUnicode(false)
                .UseCollation("SQL_Latin1_General_CP1_CI_AS");
            entity.Property(e => e.DiscontinuationReasonId).HasColumnName("DiscontinuationReasonID");
            entity.Property(e => e.EccategoryGuid)
                .HasMaxLength(50)
                .IsUnicode(false)
                .UseCollation("SQL_Latin1_General_CP1_CI_AS")
                .HasColumnName("ECCategoryGUID");
            entity.Property(e => e.EccategoryId).HasColumnName("ECCategoryID");
            entity.Property(e => e.InsertedIucdtype).HasColumnName("InsertedIUCDType");
            entity.Property(e => e.IsEcdeathId).HasColumnName("IsECDeathID");
            entity.Property(e => e.IsFollowupVisitFacilityId).HasColumnName("IsFollowupVisitFacilityID");
            entity.Property(e => e.IsLactationalAmenorrheaId).HasColumnName("IsLactationalAmenorrheaID");
            entity.Property(e => e.IsWomanBp).HasColumnName("IsWomanBP");
            entity.Property(e => e.IucdinsertionDate)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("IUCDInsertionDate");
            entity.Property(e => e.LastVisitDate)
                .HasMaxLength(30)
                .IsUnicode(false);
            entity.Property(e => e.Lmpdate)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("LMPDate");
            entity.Property(e => e.MenstrualBleedingChangeId).HasColumnName("MenstrualBleedingChangeID");
            entity.Property(e => e.MenstrualBleedingChangeOther)
                .HasMaxLength(100)
                .IsUnicode(false)
                .UseCollation("SQL_Latin1_General_CP1_CI_AS");
            entity.Property(e => e.ModernContraceptiveMethodId).HasColumnName("ModernContraceptiveMethodID");
            entity.Property(e => e.ModernContraceptiveMethodOther)
                .HasMaxLength(100)
                .IsUnicode(false)
                .UseCollation("SQL_Latin1_General_CP1_CI_AS");
            entity.Property(e => e.MpainjectionAdministeredDate)
                .HasColumnType("datetime")
                .HasColumnName("MPAInjectionAdministeredDate");
            entity.Property(e => e.MpainjectionTypeId).HasColumnName("MPAInjectionTypeID");
            entity.Property(e => e.Name)
                .HasMaxLength(302)
                .UseCollation("SQL_Latin1_General_CP1_CI_AS");
            entity.Property(e => e.PlaceNameId).HasColumnName("PlaceNameID");
            entity.Property(e => e.PlaceNameOther)
                .HasMaxLength(100)
                .IsUnicode(false)
                .UseCollation("SQL_Latin1_General_CP1_CI_AS");
            entity.Property(e => e.PregnancyTestId).HasColumnName("PregnancyTestID");
            entity.Property(e => e.Pspvfindings).HasColumnName("PSPVFindings");
            entity.Property(e => e.Rchid)
                .HasMaxLength(50)
                .IsUnicode(false)
                .UseCollation("SQL_Latin1_General_CP1_CI_AS")
                .HasColumnName("RCHID");
            entity.Property(e => e.ServiceFacilityId).HasColumnName("ServiceFacilityID");
            entity.Property(e => e.ServiceFacilityOther)
                .HasMaxLength(100)
                .IsUnicode(false)
                .UseCollation("SQL_Latin1_General_CP1_CI_AS");
            entity.Property(e => e.SterilizationProcedureDate)
                .HasMaxLength(30)
                .IsUnicode(false);
            entity.Property(e => e.SterilizationTypeId).HasColumnName("SterilizationTypeID");
            entity.Property(e => e.UpdatedOn).HasColumnType("datetime");
            entity.Property(e => e.VisitDate)
                .HasMaxLength(30)
                .IsUnicode(false);
            entity.Property(e => e.WomanDiastolicBp).HasColumnName("WomanDiastolicBP");
            entity.Property(e => e.WomanSystolicBp).HasColumnName("WomanSystolicBP");
        });

        modelBuilder.Entity<ViewTblIntrapartumRegistration>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("View_tblIntrapartumRegistration");

            entity.Property(e => e.AdmissionGuid)
                .HasMaxLength(50)
                .IsUnicode(false)
                .UseCollation("SQL_Latin1_General_CP1_CI_AS")
                .HasColumnName("admissionGuid");
            entity.Property(e => e.AnaesthetistNurse).HasColumnName("anaesthetistNurse");
            entity.Property(e => e.BeneficiaryGuid)
                .HasMaxLength(50)
                .IsUnicode(false)
                .UseCollation("SQL_Latin1_General_CP1_CI_AS")
                .HasColumnName("BeneficiaryGUID");
            entity.Property(e => e.Bpdiastolic).HasColumnName("BPDiastolic");
            entity.Property(e => e.Bpsystolic).HasColumnName("BPSystolic");
            entity.Property(e => e.CorticosteroidsGivenId)
                .HasMaxLength(50)
                .IsUnicode(false)
                .UseCollation("SQL_Latin1_General_CP1_CI_AS");
            entity.Property(e => e.CreatedOn).HasColumnType("datetime");
            entity.Property(e => e.DataSourceId).HasColumnName("DataSourceID");
            entity.Property(e => e.Date).HasColumnType("datetime");
            entity.Property(e => e.EssentialSupplyForBaby)
                .HasMaxLength(50)
                .IsUnicode(false)
                .UseCollation("SQL_Latin1_General_CP1_CI_AS");
            entity.Property(e => e.EssentialSupplyForMother)
                .HasMaxLength(50)
                .IsUnicode(false)
                .UseCollation("SQL_Latin1_General_CP1_CI_AS");
            entity.Property(e => e.ExplainCallId)
                .HasMaxLength(50)
                .IsUnicode(false)
                .UseCollation("SQL_Latin1_General_CP1_CI_AS")
                .HasColumnName("ExplainCallID");
            entity.Property(e => e.FlatentPhaseContractions).HasColumnName("FLatentPhaseContractions");
            entity.Property(e => e.FlatentPhaseDilatation).HasColumnName("FLatentPhaseDilatation");
            entity.Property(e => e.FlatentPhaseFhr).HasColumnName("FLatentPhaseFHR");
            entity.Property(e => e.FlatentPhaseTemperature).HasColumnName("FLatentPhaseTemperature");
            entity.Property(e => e.Hivstatus).HasColumnName("HIVStatus");
            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.ImagingDisplayed).HasColumnName("imagingDisplayed");
            entity.Property(e => e.IntrapartumGuid)
                .HasMaxLength(50)
                .IsUnicode(false)
                .UseCollation("SQL_Latin1_General_CP1_CI_AS")
                .HasColumnName("IntrapartumGUID");
            entity.Property(e => e.IntrapartumId)
                .ValueGeneratedOnAdd()
                .HasColumnName("IntrapartumID");
            entity.Property(e => e.LabourNeeded).HasColumnName("labourNeeded");
            entity.Property(e => e.MagnesiumSulfateId)
                .HasMaxLength(50)
                .IsUnicode(false)
                .UseCollation("SQL_Latin1_General_CP1_CI_AS");
            entity.Property(e => e.MotherNeedHelpId)
                .HasMaxLength(50)
                .IsUnicode(false)
                .UseCollation("SQL_Latin1_General_CP1_CI_AS");
            entity.Property(e => e.MotherNeedReferralid)
                .HasMaxLength(50)
                .IsUnicode(false)
                .UseCollation("SQL_Latin1_General_CP1_CI_AS");
            entity.Property(e => e.NameOfAnm)
                .HasMaxLength(50)
                .IsUnicode(false)
                .UseCollation("SQL_Latin1_General_CP1_CI_AS")
                .HasColumnName("NameOfANM");
            entity.Property(e => e.NameOfAsha)
                .HasMaxLength(50)
                .IsUnicode(false)
                .UseCollation("SQL_Latin1_General_CP1_CI_AS");
            entity.Property(e => e.NeedAntibioticsid)
                .HasMaxLength(50)
                .IsUnicode(false)
                .UseCollation("SQL_Latin1_General_CP1_CI_AS");
            entity.Property(e => e.PartographAdmissionDateTime)
                .HasMaxLength(50)
                .IsUnicode(false)
                .UseCollation("SQL_Latin1_General_CP1_CI_AS");
            entity.Property(e => e.PartographBpdiastilic).HasColumnName("PartographBPDiastilic");
            entity.Property(e => e.PartographBpsystolic).HasColumnName("PartographBPSystolic");
            entity.Property(e => e.PartographDateTimeRom)
                .HasMaxLength(50)
                .IsUnicode(false)
                .UseCollation("SQL_Latin1_General_CP1_CI_AS");
            entity.Property(e => e.PartographHusbandName)
                .HasMaxLength(50)
                .IsUnicode(false)
                .UseCollation("SQL_Latin1_General_CP1_CI_AS");
            entity.Property(e => e.PartographName)
                .HasMaxLength(50)
                .IsUnicode(false)
                .UseCollation("SQL_Latin1_General_CP1_CI_AS");
            entity.Property(e => e.PatientSconcerns)
                .HasMaxLength(50)
                .IsUnicode(false)
                .UseCollation("SQL_Latin1_General_CP1_CI_AS");
            entity.Property(e => e.ProviderName)
                .HasMaxLength(100)
                .IsUnicode(false)
                .UseCollation("SQL_Latin1_General_CP1_CI_AS")
                .HasColumnName("providerName");
            entity.Property(e => e.Pulse).HasColumnName("pulse");
            entity.Property(e => e.PwcategoryGuid)
                .HasMaxLength(50)
                .IsUnicode(false)
                .UseCollation("SQL_Latin1_General_CP1_CI_AS")
                .HasColumnName("PWCategoryGUID");
            entity.Property(e => e.SafeChildDate).HasColumnType("datetime");
            entity.Property(e => e.SafeChildMagnesiumSulfate)
                .HasMaxLength(50)
                .IsUnicode(false)
                .UseCollation("SQL_Latin1_General_CP1_CI_AS");
            entity.Property(e => e.SafeChildMagnesiumSulfateId)
                .HasMaxLength(50)
                .IsUnicode(false)
                .UseCollation("SQL_Latin1_General_CP1_CI_AS");
            entity.Property(e => e.SafeChildNeedAntibioticsId)
                .HasMaxLength(50)
                .IsUnicode(false)
                .UseCollation("SQL_Latin1_General_CP1_CI_AS");
            entity.Property(e => e.SafeChildProviderName)
                .HasMaxLength(50)
                .IsUnicode(false)
                .UseCollation("SQL_Latin1_General_CP1_CI_AS");
            entity.Property(e => e.SoapAvailable).HasColumnName("soapAvailable");
            entity.Property(e => e.UpdatedOn).HasColumnType("datetime");
        });

        modelBuilder.Entity<ViewTblLamaDeathForm>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("View_tblLamaDeathForm");

            entity.Property(e => e.AdmissionGuid)
                .HasMaxLength(50)
                .IsUnicode(false)
                .UseCollation("SQL_Latin1_General_CP1_CI_AS")
                .HasColumnName("AdmissionGUID");
            entity.Property(e => e.BeneficiaryGuid)
                .HasMaxLength(50)
                .IsUnicode(false)
                .UseCollation("SQL_Latin1_General_CP1_CI_AS")
                .HasColumnName("BeneficiaryGUID");
            entity.Property(e => e.Bpdystolic).HasColumnName("BPDystolic");
            entity.Property(e => e.Bpsystolic).HasColumnName("BPSystolic");
            entity.Property(e => e.CreatedOn).HasColumnType("datetime");
            entity.Property(e => e.DataSourceId).HasColumnName("DataSourceID");
            entity.Property(e => e.DateDeath).HasColumnType("datetime");
            entity.Property(e => e.DateRefer).HasColumnType("datetime");
            entity.Property(e => e.DeathFormId)
                .ValueGeneratedOnAdd()
                .HasColumnName("DeathFormID");
            entity.Property(e => e.DeathSummary)
                .HasMaxLength(100)
                .IsUnicode(false)
                .UseCollation("SQL_Latin1_General_CP1_CI_AS");
            entity.Property(e => e.Designation)
                .HasMaxLength(50)
                .IsUnicode(false)
                .UseCollation("SQL_Latin1_General_CP1_CI_AS");
            entity.Property(e => e.DetailTreatmentGiven)
                .HasMaxLength(100)
                .IsUnicode(false)
                .UseCollation("SQL_Latin1_General_CP1_CI_AS");
            entity.Property(e => e.FollowDate).HasColumnType("datetime");
            entity.Property(e => e.HighRiskParameters)
                .HasMaxLength(100)
                .IsUnicode(false)
                .UseCollation("SQL_Latin1_General_CP1_CI_AS");
            entity.Property(e => e.LamaDeathFormGuid)
                .HasMaxLength(50)
                .IsUnicode(false)
                .UseCollation("SQL_Latin1_General_CP1_CI_AS")
                .HasColumnName("LamaDeathFormGUID");
            entity.Property(e => e.NameAnaesthetic)
                .HasMaxLength(50)
                .IsUnicode(false)
                .UseCollation("SQL_Latin1_General_CP1_CI_AS");
            entity.Property(e => e.NameServiceProvider)
                .HasMaxLength(50)
                .IsUnicode(false)
                .UseCollation("SQL_Latin1_General_CP1_CI_AS");
            entity.Property(e => e.NameSn)
                .HasMaxLength(100)
                .IsUnicode(false)
                .UseCollation("SQL_Latin1_General_CP1_CI_AS")
                .HasColumnName("NameSN");
            entity.Property(e => e.OtherDetailsBaby)
                .HasMaxLength(50)
                .IsUnicode(false)
                .UseCollation("SQL_Latin1_General_CP1_CI_AS");
            entity.Property(e => e.OtherDetailsMother)
                .HasMaxLength(50)
                .IsUnicode(false)
                .UseCollation("SQL_Latin1_General_CP1_CI_AS");
            entity.Property(e => e.ProvisionVehicleId).HasColumnName("ProvisionVehicleID");
            entity.Property(e => e.ProvisionalDiagnosis)
                .HasMaxLength(50)
                .IsUnicode(false)
                .UseCollation("SQL_Latin1_General_CP1_CI_AS");
            entity.Property(e => e.PwcategoryGuid)
                .HasMaxLength(50)
                .IsUnicode(false)
                .UseCollation("SQL_Latin1_General_CP1_CI_AS")
                .HasColumnName("PWCategoryGUID");
            entity.Property(e => e.ReasonReferral)
                .HasMaxLength(50)
                .IsUnicode(false)
                .UseCollation("SQL_Latin1_General_CP1_CI_AS");
            entity.Property(e => e.ReferralDetails)
                .HasMaxLength(50)
                .IsUnicode(false)
                .UseCollation("SQL_Latin1_General_CP1_CI_AS");
            entity.Property(e => e.ReferralFacilityName)
                .HasMaxLength(50)
                .IsUnicode(false)
                .UseCollation("SQL_Latin1_General_CP1_CI_AS");
            entity.Property(e => e.ReferralFacilityNameId).HasColumnName("ReferralFacilityNameID");
            entity.Property(e => e.ReferralFacilityTypeId).HasColumnName("ReferralFacilityTypeID");
            entity.Property(e => e.ReferralFacilityTypeOther)
                .HasMaxLength(50)
                .IsUnicode(false)
                .UseCollation("SQL_Latin1_General_CP1_CI_AS");
            entity.Property(e => e.Remarks)
                .HasMaxLength(50)
                .IsUnicode(false)
                .UseCollation("SQL_Latin1_General_CP1_CI_AS");
            entity.Property(e => e.Signature)
                .HasMaxLength(50)
                .IsUnicode(false)
                .UseCollation("SQL_Latin1_General_CP1_CI_AS");
            entity.Property(e => e.TimeDeath)
                .HasMaxLength(50)
                .IsUnicode(false)
                .UseCollation("SQL_Latin1_General_CP1_CI_AS");
            entity.Property(e => e.TimeRefer)
                .HasMaxLength(50)
                .IsUnicode(false)
                .UseCollation("SQL_Latin1_General_CP1_CI_AS");
            entity.Property(e => e.TypeAnaesthesia)
                .HasMaxLength(50)
                .IsUnicode(false)
                .UseCollation("SQL_Latin1_General_CP1_CI_AS");
            entity.Property(e => e.UpdatedOn).HasColumnType("datetime");
        });

        modelBuilder.Entity<ViewTblLrAdmission>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("View_tblLrAdmission");

            entity.Property(e => e.AdmissionDate)
                .HasMaxLength(50)
                .IsUnicode(false)
                .UseCollation("SQL_Latin1_General_CP1_CI_AS");
            entity.Property(e => e.AdmissionGuid)
                .HasMaxLength(50)
                .IsUnicode(false)
                .UseCollation("SQL_Latin1_General_CP1_CI_AS")
                .HasColumnName("AdmissionGUID");
            entity.Property(e => e.AdmissionId)
                .ValueGeneratedOnAdd()
                .HasColumnName("AdmissionID");
            entity.Property(e => e.AdmissionTime)
                .HasMaxLength(50)
                .IsUnicode(false)
                .UseCollation("SQL_Latin1_General_CP1_CI_AS");
            entity.Property(e => e.AdmissionTypeId).HasColumnName("AdmissionTypeID");
            entity.Property(e => e.AntiDid).HasColumnName("AntiDId");
            entity.Property(e => e.BeneficiaryGuid)
                .HasMaxLength(50)
                .IsUnicode(false)
                .UseCollation("SQL_Latin1_General_CP1_CI_AS")
                .HasColumnName("BeneficiaryGUID");
            entity.Property(e => e.BirthCompanion)
                .HasMaxLength(50)
                .IsUnicode(false)
                .UseCollation("SQL_Latin1_General_CP1_CI_AS");
            entity.Property(e => e.Bpdiastolic).HasColumnName("BPDiastolic");
            entity.Property(e => e.Bpsystolic).HasColumnName("BPSystolic");
            entity.Property(e => e.ChronicIllness)
                .HasMaxLength(50)
                .IsUnicode(false)
                .UseCollation("SQL_Latin1_General_CP1_CI_AS");
            entity.Property(e => e.ContactNo)
                .HasMaxLength(50)
                .IsUnicode(false)
                .UseCollation("SQL_Latin1_General_CP1_CI_AS");
            entity.Property(e => e.CreatedOn).HasColumnType("datetime");
            entity.Property(e => e.DataSourceId).HasColumnName("DataSourceID");
            entity.Property(e => e.Edddate)
                .HasColumnType("datetime")
                .HasColumnName("EDDdate");
            entity.Property(e => e.FacilityNameOther)
                .HasMaxLength(50)
                .IsUnicode(false)
                .UseCollation("SQL_Latin1_General_CP1_CI_AS");
            entity.Property(e => e.FacilityTypeOther)
                .HasMaxLength(50)
                .IsUnicode(false)
                .UseCollation("SQL_Latin1_General_CP1_CI_AS");
            entity.Property(e => e.Fhr).HasColumnName("FHR");
            entity.Property(e => e.FundalHeight)
                .HasMaxLength(50)
                .IsUnicode(false)
                .UseCollation("SQL_Latin1_General_CP1_CI_AS");
            entity.Property(e => e.Hb).HasColumnType("decimal(18, 4)");
            entity.Property(e => e.Hiv).HasColumnName("HIV");
            entity.Property(e => e.HusbandName)
                .HasMaxLength(50)
                .IsUnicode(false)
                .UseCollation("SQL_Latin1_General_CP1_CI_AS");
            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.IsBpchecked).HasColumnName("IsBPchecked");
            entity.Property(e => e.LabourOnsetDate)
                .HasMaxLength(50)
                .IsUnicode(false)
                .UseCollation("SQL_Latin1_General_CP1_CI_AS")
                .HasColumnName("labourOnsetDate");
            entity.Property(e => e.LabourOnsetTime)
                .HasMaxLength(50)
                .IsUnicode(false)
                .UseCollation("SQL_Latin1_General_CP1_CI_AS")
                .HasColumnName("labourOnsetTime");
            entity.Property(e => e.Lmpdate)
                .HasColumnType("datetime")
                .HasColumnName("LMPDate");
            entity.Property(e => e.MedicalSurgicalHistory)
                .HasMaxLength(50)
                .IsUnicode(false)
                .UseCollation("SQL_Latin1_General_CP1_CI_AS");
            entity.Property(e => e.MotherTd).HasColumnName("MotherTD");
            entity.Property(e => e.Name)
                .HasMaxLength(50)
                .IsUnicode(false)
                .UseCollation("SQL_Latin1_General_CP1_CI_AS");
            entity.Property(e => e.Ogtt).HasColumnName("OGTT");
            entity.Property(e => e.PresentationOther)
                .HasMaxLength(50)
                .IsUnicode(false)
                .UseCollation("SQL_Latin1_General_CP1_CI_AS");
            entity.Property(e => e.PresentingComplaints)
                .HasMaxLength(100)
                .UseCollation("SQL_Latin1_General_CP1_CI_AS");
            entity.Property(e => e.PresentingComplaintsOther)
                .HasMaxLength(50)
                .IsUnicode(false)
                .UseCollation("SQL_Latin1_General_CP1_CI_AS");
            entity.Property(e => e.PwcategoryGuid)
                .HasMaxLength(50)
                .IsUnicode(false)
                .UseCollation("SQL_Latin1_General_CP1_CI_AS")
                .HasColumnName("PWCategoryGUID");
            entity.Property(e => e.ReasonReferral)
                .HasMaxLength(50)
                .IsUnicode(false)
                .UseCollation("SQL_Latin1_General_CP1_CI_AS");
            entity.Property(e => e.ReferralFacilityId).HasColumnName("ReferralFacilityID");
            entity.Property(e => e.ReferralFacilityName)
                .HasMaxLength(100)
                .IsUnicode(false)
                .UseCollation("SQL_Latin1_General_CP1_CI_AS");
            entity.Property(e => e.ReferralFacilityOther)
                .HasMaxLength(50)
                .IsUnicode(false)
                .UseCollation("SQL_Latin1_General_CP1_CI_AS");
            entity.Property(e => e.Spo2).HasColumnName("SPO2");
            entity.Property(e => e.Temperature).HasColumnType("decimal(18, 0)");
            entity.Property(e => e.UpdatedOn)
                .HasMaxLength(50)
                .IsUnicode(false)
                .UseCollation("SQL_Latin1_General_CP1_CI_AS");
            entity.Property(e => e.Usgage).HasColumnName("USGAge");
            entity.Property(e => e.Vdrlrrr).HasColumnName("VDRLRRR");
            entity.Property(e => e.Weight).HasColumnType("decimal(18, 0)");
        });

        modelBuilder.Entity<ViewTblPartography>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("View_tblPartography");

            entity.Property(e => e.BeneficiaryGuid)
                .HasMaxLength(50)
                .IsUnicode(false)
                .UseCollation("SQL_Latin1_General_CP1_CI_AS")
                .HasColumnName("BeneficiaryGUID");
            entity.Property(e => e.Bpdiastolic).HasColumnName("BPDiastolic");
            entity.Property(e => e.Bpsystolic).HasColumnName("BPSystolic");
            entity.Property(e => e.CreatedOn).HasColumnType("datetime");
            entity.Property(e => e.Fhr).HasColumnName("FHR");
            entity.Property(e => e.IntrapartumGuid)
                .HasMaxLength(50)
                .IsUnicode(false)
                .UseCollation("SQL_Latin1_General_CP1_CI_AS")
                .HasColumnName("IntrapartumGUID");
            entity.Property(e => e.PartographyGuid)
                .HasMaxLength(50)
                .IsUnicode(false)
                .UseCollation("SQL_Latin1_General_CP1_CI_AS")
                .HasColumnName("PartographyGUID");
            entity.Property(e => e.PartographyId)
                .ValueGeneratedOnAdd()
                .HasColumnName("PartographyID");
            entity.Property(e => e.PwcategoryGuid)
                .HasMaxLength(50)
                .IsUnicode(false)
                .UseCollation("SQL_Latin1_General_CP1_CI_AS")
                .HasColumnName("PWCategoryGUID");
            entity.Property(e => e.Temprature).HasColumnType("decimal(18, 0)");
            entity.Property(e => e.TrackingDateTime)
                .HasMaxLength(50)
                .IsUnicode(false)
                .UseCollation("SQL_Latin1_General_CP1_CI_AS");
            entity.Property(e => e.UpdatedOn)
                .HasMaxLength(50)
                .IsUnicode(false)
                .UseCollation("SQL_Latin1_General_CP1_CI_AS");
        });

        modelBuilder.Entity<ViewTblPncdetail>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("View_tblPNCDetail");

            entity.Property(e => e.BeneficiaryGuid)
                .HasMaxLength(100)
                .UseCollation("SQL_Latin1_General_CP1_CI_AS")
                .HasColumnName("BeneficiaryGUID");
            entity.Property(e => e.CreatedOn).HasColumnType("datetime");
            entity.Property(e => e.DangerSignId).HasColumnName("DangerSignID");
            entity.Property(e => e.DangerSignOther)
                .HasMaxLength(50)
                .IsUnicode(false)
                .UseCollation("SQL_Latin1_General_CP1_CI_AS");
            entity.Property(e => e.DataSourceId).HasColumnName("DataSourceID");
            entity.Property(e => e.FacilityNameId).HasColumnName("FacilityNameID");
            entity.Property(e => e.FacilityNameOther)
                .HasMaxLength(50)
                .IsUnicode(false)
                .UseCollation("SQL_Latin1_General_CP1_CI_AS");
            entity.Property(e => e.IsMotherPncdeathId).HasColumnName("IsMotherPNCDeathID");
            entity.Property(e => e.IsNotifiedByAshaid).HasColumnName("IsNotifiedByASHAID");
            entity.Property(e => e.IsfbirbyAnmid).HasColumnName("ISFBIRByANMID");
            entity.Property(e => e.LastVisitDate).HasColumnType("datetime");
            entity.Property(e => e.MaternalDeathPlaceId).HasColumnName("MaternalDeathPlaceID");
            entity.Property(e => e.MotherDeathCauseId)
                .HasMaxLength(50)
                .IsUnicode(false)
                .UseCollation("SQL_Latin1_General_CP1_CI_AS")
                .HasColumnName("MotherDeathCauseID");
            entity.Property(e => e.MotherDeathCauseOther)
                .HasMaxLength(50)
                .IsUnicode(false)
                .UseCollation("SQL_Latin1_General_CP1_CI_AS");
            entity.Property(e => e.MotherDeathDate).HasColumnType("datetime");
            entity.Property(e => e.MotherDeathFacilityTypeId).HasColumnName("MotherDeathFacilityTypeID");
            entity.Property(e => e.MotherDeathFacilityTypeOther)
                .HasMaxLength(100)
                .UseCollation("SQL_Latin1_General_CP1_CI_AS");
            entity.Property(e => e.Pncguid)
                .HasMaxLength(50)
                .IsUnicode(false)
                .UseCollation("SQL_Latin1_General_CP1_CI_AS")
                .HasColumnName("PNCGUID");
            entity.Property(e => e.Pncid).HasColumnName("PNCID");
            entity.Property(e => e.PncvisitDate)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("PNCVisitDate");
            entity.Property(e => e.PncvisitId).HasColumnName("PNCVisitID");
            entity.Property(e => e.PostPartumContraMethodId).HasColumnName("PostPartumContraMethodID");
            entity.Property(e => e.PostPartumContraMethodOther)
                .HasMaxLength(50)
                .IsUnicode(false)
                .UseCollation("SQL_Latin1_General_CP1_CI_AS");
            entity.Property(e => e.PwcategoryGuid)
                .HasMaxLength(100)
                .UseCollation("SQL_Latin1_General_CP1_CI_AS")
                .HasColumnName("PWCategoryGUID");
            entity.Property(e => e.ReferralFascilityTypeId).HasColumnName("ReferralFascilityTypeID");
            entity.Property(e => e.Remarks)
                .HasMaxLength(250)
                .IsUnicode(false)
                .UseCollation("SQL_Latin1_General_CP1_CI_AS");
            entity.Property(e => e.TotalCalVitDthreeTab).HasColumnName("TotalCalVitDThreeTab");
            entity.Property(e => e.TotalIfatablet).HasColumnName("TotalIFATablet");
            entity.Property(e => e.UpdatedOn).HasColumnType("datetime");
        });

        modelBuilder.Entity<ViewTblPostpartumSummery>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("View_tblPostpartumSummery");

            entity.Property(e => e.AdmissionGuid)
                .HasMaxLength(50)
                .IsUnicode(false)
                .UseCollation("SQL_Latin1_General_CP1_CI_AS")
                .HasColumnName("AdmissionGUID");
            entity.Property(e => e.BabyComplication)
                .HasMaxLength(50)
                .IsUnicode(false)
                .UseCollation("SQL_Latin1_General_CP1_CI_AS");
            entity.Property(e => e.BabyTemperature).HasColumnType("decimal(18, 0)");
            entity.Property(e => e.BeneficiaryGuid)
                .HasMaxLength(50)
                .IsUnicode(false)
                .UseCollation("SQL_Latin1_General_CP1_CI_AS")
                .HasColumnName("BeneficiaryGUID");
            entity.Property(e => e.BleedingPvid).HasColumnName("BleedingPVId");
            entity.Property(e => e.Bpdistolic).HasColumnName("BPDistolic");
            entity.Property(e => e.Bpsystolic).HasColumnName("BPSystolic");
            entity.Property(e => e.CreatedOn).HasColumnType("datetime");
            entity.Property(e => e.DataSourceId).HasColumnName("DataSourceID");
            entity.Property(e => e.MotherComplicationsId)
                .HasMaxLength(50)
                .IsUnicode(false)
                .UseCollation("SQL_Latin1_General_CP1_CI_AS");
            entity.Property(e => e.OtherReferralReason)
                .HasMaxLength(50)
                .UseCollation("SQL_Latin1_General_CP1_CI_AS");
            entity.Property(e => e.PostpartumSummeryGuid)
                .HasMaxLength(50)
                .IsUnicode(false)
                .UseCollation("SQL_Latin1_General_CP1_CI_AS")
                .HasColumnName("PostpartumSummeryGUID");
            entity.Property(e => e.PostpartumSummeryId)
                .ValueGeneratedOnAdd()
                .HasColumnName("PostpartumSummeryID");
            entity.Property(e => e.Pulse).HasColumnType("decimal(18, 0)");
            entity.Property(e => e.PwcategoryGuid)
                .HasMaxLength(50)
                .IsUnicode(false)
                .UseCollation("SQL_Latin1_General_CP1_CI_AS")
                .HasColumnName("PWCategoryGUID");
            entity.Property(e => e.ReferralReasonId)
                .HasMaxLength(50)
                .IsUnicode(false)
                .UseCollation("SQL_Latin1_General_CP1_CI_AS");
            entity.Property(e => e.RespRate).HasColumnType("decimal(18, 0)");
            entity.Property(e => e.Temp).HasColumnType("decimal(18, 0)");
            entity.Property(e => e.TrackingDateTime)
                .HasMaxLength(50)
                .IsUnicode(false)
                .UseCollation("SQL_Latin1_General_CP1_CI_AS");
            entity.Property(e => e.UpdatedOn).HasColumnType("datetime");
        });

        modelBuilder.Entity<ViewTblReferral>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("View_tblReferral");

            entity.Property(e => e.AnemiaScreeningResultId).HasColumnName("AnemiaScreeningResultID");
            entity.Property(e => e.BeneficiaryGuid)
                .HasMaxLength(50)
                .IsUnicode(false)
                .UseCollation("SQL_Latin1_General_CP1_CI_AS")
                .HasColumnName("BeneficiaryGUID");
            entity.Property(e => e.Bpdistolic).HasColumnName("BPDistolic");
            entity.Property(e => e.Bpsystolic).HasColumnName("BPSystolic");
            entity.Property(e => e.Bt).HasColumnName("BT");
            entity.Property(e => e.CovidResultId).HasColumnName("CovidResultID");
            entity.Property(e => e.CovidTestId).HasColumnName("CovidTestID");
            entity.Property(e => e.CreatedOn).HasColumnType("datetime");
            entity.Property(e => e.Ct).HasColumnName("CT");
            entity.Property(e => e.DataSourceId).HasColumnName("DataSourceID");
            entity.Property(e => e.IsBloodSugarTestId).HasColumnName("IsBloodSugarTestID");
            entity.Property(e => e.IsUrineTestId).HasColumnName("IsUrineTestID");
            entity.Property(e => e.Lftid).HasColumnName("LFTID");
            entity.Property(e => e.LftserumBilirubin).HasColumnName("LFTSerumBilirubin");
            entity.Property(e => e.Lftsgot).HasColumnName("LFTSGOT");
            entity.Property(e => e.Lftsgpt).HasColumnName("LFTSGPT");
            entity.Property(e => e.NextFollowupDate).HasColumnType("datetime");
            entity.Property(e => e.OdemaResultId).HasColumnName("OdemaResultID");
            entity.Property(e => e.OdemaTestId).HasColumnName("OdemaTestID");
            entity.Property(e => e.OgtttestFirst).HasColumnName("OGTTTestFirst");
            entity.Property(e => e.OgtttestSecond).HasColumnName("OGTTTestSecond");
            entity.Property(e => e.PwcategoryGuid)
                .HasMaxLength(50)
                .IsUnicode(false)
                .UseCollation("SQL_Latin1_General_CP1_CI_AS")
                .HasColumnName("PWCategoryGUID");
            entity.Property(e => e.ReferralGuid)
                .HasMaxLength(50)
                .IsUnicode(false)
                .UseCollation("SQL_Latin1_General_CP1_CI_AS")
                .HasColumnName("ReferralGUID");
            entity.Property(e => e.ReferralTypeId).ValueGeneratedOnAdd();
            entity.Property(e => e.RftbloodUrea).HasColumnName("RFTBloodUrea");
            entity.Property(e => e.Rftid).HasColumnName("RFTID");
            entity.Property(e => e.RftserumCreatinine).HasColumnName("RFTSerumCreatinine");
            entity.Property(e => e.SerumFerritinHr).HasColumnName("SerumFerritinHR");
            entity.Property(e => e.StoolOvaid).HasColumnName("StoolOVAId");
            entity.Property(e => e.Temprature).HasColumnType("decimal(18, 0)");
            entity.Property(e => e.UpdatedOn).HasColumnType("datetime");
            entity.Property(e => e.UrineAlbuminId).HasColumnName("UrineAlbuminID");
            entity.Property(e => e.UrineAlbuminPus)
                .HasMaxLength(50)
                .IsUnicode(false)
                .UseCollation("SQL_Latin1_General_CP1_CI_AS");
            entity.Property(e => e.UrineCultureHr)
                .HasMaxLength(50)
                .IsUnicode(false)
                .UseCollation("SQL_Latin1_General_CP1_CI_AS")
                .HasColumnName("UrineCultureHR");
            entity.Property(e => e.UrineCultureHrid).HasColumnName("UrineCultureHRId");
            entity.Property(e => e.UrineMicroscopicRbcid).HasColumnName("UrineMicroscopicRBCId");
            entity.Property(e => e.UrineSugarId).HasColumnName("UrineSugarID");
        });

        modelBuilder.Entity<ViewTblReferred>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("View_tblReferred");

            entity.Property(e => e.BeneficiaryGuid)
                .HasMaxLength(100)
                .IsUnicode(false)
                .UseCollation("SQL_Latin1_General_CP1_CI_AS")
                .HasColumnName("BeneficiaryGUID");
            entity.Property(e => e.PwcategoryGuid)
                .HasMaxLength(100)
                .IsUnicode(false)
                .UseCollation("SQL_Latin1_General_CP1_CI_AS")
                .HasColumnName("PWCategoryGUID");
            entity.Property(e => e.RefGuid)
                .HasMaxLength(100)
                .IsUnicode(false)
                .UseCollation("SQL_Latin1_General_CP1_CI_AS")
                .HasColumnName("RefGUID");
            entity.Property(e => e.RefId)
                .ValueGeneratedOnAdd()
                .HasColumnName("RefID");
            entity.Property(e => e.RefTypeGuid)
                .HasMaxLength(100)
                .IsUnicode(false)
                .UseCollation("SQL_Latin1_General_CP1_CI_AS")
                .HasColumnName("RefTypeGUID");
        });

        modelBuilder.Entity<ViewTblState>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("View_tblState");

            entity.Property(e => e.StateId)
                .ValueGeneratedOnAdd()
                .HasColumnName("StateID");
            entity.Property(e => e.StateName).HasMaxLength(250);
        });

        modelBuilder.Entity<ViewTotalPregnantWoman>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("View_TotalPregnantWomen");

            entity.Property(e => e.Address).UseCollation("SQL_Latin1_General_CP1_CI_AS");
            entity.Property(e => e.AshaNameId).HasColumnName("AshaNameID");
            entity.Property(e => e.BeneficeryType).HasColumnName("beneficeryType");
            entity.Property(e => e.BeneficiaryGuid)
                .HasMaxLength(50)
                .IsUnicode(false)
                .UseCollation("SQL_Latin1_General_CP1_CI_AS")
                .HasColumnName("BeneficiaryGUID");
            entity.Property(e => e.BeneficiaryId).HasColumnName("BeneficiaryID");
            entity.Property(e => e.BlockId).HasColumnName("BlockID");
            entity.Property(e => e.CasteId).HasColumnName("CasteID");
            entity.Property(e => e.CreatedOn).HasColumnType("datetime");
            entity.Property(e => e.DataSourceId).HasColumnName("DataSourceID");
            entity.Property(e => e.DistrictId).HasColumnName("DistrictID");
            entity.Property(e => e.FinancialYear).UseCollation("SQL_Latin1_General_CP1_CI_AS");
            entity.Property(e => e.HealthProviderNameId).HasColumnName("HealthProviderNameID");
            entity.Property(e => e.HusbandAccountNo)
                .HasMaxLength(100)
                .IsUnicode(false)
                .UseCollation("SQL_Latin1_General_CP1_CI_AS");
            entity.Property(e => e.HusbandAdhaarNo)
                .HasMaxLength(12)
                .IsUnicode(false)
                .UseCollation("SQL_Latin1_General_CP1_CI_AS");
            entity.Property(e => e.HusbandBankId)
                .HasMaxLength(50)
                .IsUnicode(false)
                .UseCollation("SQL_Latin1_General_CP1_CI_AS")
                .HasColumnName("HusbandBankID");
            entity.Property(e => e.HusbandDob)
                .HasColumnType("datetime")
                .HasColumnName("HusbandDOB");
            entity.Property(e => e.HusbandEducationLevelId).HasColumnName("HusbandEducationLevelID");
            entity.Property(e => e.HusbandEducationLevelOther)
                .HasMaxLength(100)
                .UseCollation("SQL_Latin1_General_CP1_CI_AS");
            entity.Property(e => e.HusbandFirstName)
                .HasMaxLength(100)
                .UseCollation("SQL_Latin1_General_CP1_CI_AS");
            entity.Property(e => e.HusbandLastName)
                .HasMaxLength(100)
                .UseCollation("SQL_Latin1_General_CP1_CI_AS");
            entity.Property(e => e.HusbandMiddleName)
                .HasMaxLength(100)
                .UseCollation("SQL_Latin1_General_CP1_CI_AS");
            entity.Property(e => e.HusbandOccupationId).HasColumnName("HusbandOccupationID");
            entity.Property(e => e.HusbandOccupationOther)
                .HasMaxLength(100)
                .UseCollation("SQL_Latin1_General_CP1_CI_AS");
            entity.Property(e => e.IsHusbandAdhaarBankLinkedId).HasColumnName("IsHusbandAdhaarBankLinkedID");
            entity.Property(e => e.IsHusbandCurrentAgeId).HasColumnName("IsHusbandCurrentAgeID");
            entity.Property(e => e.IsHusbandDobid).HasColumnName("IsHusbandDOBID");
            entity.Property(e => e.IsWomanAdhaarBankLinkedId).HasColumnName("IsWomanAdhaarBankLinkedID");
            entity.Property(e => e.IsWomanCurrentAgeId).HasColumnName("IsWomanCurrentAgeID");
            entity.Property(e => e.IsWomanDobid).HasColumnName("IsWomanDOBID");
            entity.Property(e => e.MasterBeneficiaryGuid)
                .HasMaxLength(100)
                .UseCollation("SQL_Latin1_General_CP1_CI_AS")
                .HasColumnName("MasterBeneficiaryGUID");
            entity.Property(e => e.MobileNo)
                .HasMaxLength(10)
                .IsUnicode(false)
                .UseCollation("SQL_Latin1_General_CP1_CI_AS");
            entity.Property(e => e.MobileNoOwnerId).HasColumnName("MobileNoOwnerID");
            entity.Property(e => e.PovertyCategoryId).HasColumnName("PovertyCategoryID");
            entity.Property(e => e.QrcodeId)
                .HasMaxLength(100)
                .UseCollation("SQL_Latin1_General_CP1_CI_AS")
                .HasColumnName("QRCodeId");
            entity.Property(e => e.Rchid)
                .HasMaxLength(50)
                .IsUnicode(false)
                .UseCollation("SQL_Latin1_General_CP1_CI_AS")
                .HasColumnName("RCHID");
            entity.Property(e => e.RegistrationDate).HasColumnType("datetime");
            entity.Property(e => e.ReligionId).HasColumnName("ReligionID");
            entity.Property(e => e.RoleId).HasColumnName("RoleID");
            entity.Property(e => e.UpdatedOn).HasColumnType("datetime");
            entity.Property(e => e.VillageId).HasColumnName("VillageID");
            entity.Property(e => e.WomanAccountNo)
                .HasMaxLength(100)
                .IsUnicode(false)
                .UseCollation("SQL_Latin1_General_CP1_CI_AS");
            entity.Property(e => e.WomanAdhaarNo)
                .HasMaxLength(12)
                .IsUnicode(false)
                .UseCollation("SQL_Latin1_General_CP1_CI_AS");
            entity.Property(e => e.WomanBankId).HasColumnName("WomanBankID");
            entity.Property(e => e.WomanDob)
                .HasColumnType("datetime")
                .HasColumnName("WomanDOB");
            entity.Property(e => e.WomanEducationLevelId).HasColumnName("WomanEducationLevelID");
            entity.Property(e => e.WomanEducationLevelOther)
                .HasMaxLength(100)
                .UseCollation("SQL_Latin1_General_CP1_CI_AS");
            entity.Property(e => e.WomanFirstName)
                .HasMaxLength(100)
                .UseCollation("SQL_Latin1_General_CP1_CI_AS");
            entity.Property(e => e.WomanLastName)
                .HasMaxLength(100)
                .UseCollation("SQL_Latin1_General_CP1_CI_AS");
            entity.Property(e => e.WomanMiddleName)
                .HasMaxLength(100)
                .UseCollation("SQL_Latin1_General_CP1_CI_AS");
            entity.Property(e => e.WomanOccupationId).HasColumnName("WomanOccupationID");
            entity.Property(e => e.WomanOccupationOther)
                .HasMaxLength(100)
                .UseCollation("SQL_Latin1_General_CP1_CI_AS");
            entity.Property(e => e.YoungChildAgeMonthId).HasColumnName("YoungChildAgeMonthID");
            entity.Property(e => e.YoungChildAgeYearId).HasColumnName("YoungChildAgeYearID");
            entity.Property(e => e.YoungChildGenderId).HasColumnName("YoungChildGenderID");
        });

        modelBuilder.Entity<ViewUserList>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("View_UserList");

            entity.Property(e => e.BlockId).HasColumnName("BlockID");
            entity.Property(e => e.BlockName).HasMaxLength(255);
            entity.Property(e => e.District).HasMaxLength(250);
            entity.Property(e => e.DistrictId).HasColumnName("DistrictID");
            entity.Property(e => e.EmailId)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("EmailID");
            entity.Property(e => e.FacilityId).HasColumnName("FacilityID");
            entity.Property(e => e.FacilityName)
                .HasMaxLength(150)
                .IsUnicode(false);
            entity.Property(e => e.FullName)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.Role)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.RoleId).HasColumnName("RoleID");
            entity.Property(e => e.StateId).HasColumnName("StateID");
            entity.Property(e => e.StateName).HasMaxLength(250);
            entity.Property(e => e.UserId).HasColumnName("UserID");
            entity.Property(e => e.Username)
                .HasMaxLength(50)
                .IsUnicode(false);
        });

        modelBuilder.Entity<Village>(entity =>
        {
            entity.HasKey(e => e.Sno).HasName("PK__villages__DDDF64468AAF65EA");

            entity.ToTable("villages");

            entity.Property(e => e.Sno).HasColumnName("sno");
            entity.Property(e => e.Name)
                .HasMaxLength(255)
                .HasColumnName("name");
            entity.Property(e => e.SubCenterCode).HasColumnName("subCenter_code");
            entity.Property(e => e.VillageId).HasColumnName("village_id");
        });

        modelBuilder.Entity<Visit>(entity =>
        {
            entity.HasKey(e => e.Sno).HasName("PK__visits__DDDF6446D49B16C7");

            entity.ToTable("visits");

            entity.Property(e => e.Sno).HasColumnName("sno");
            entity.Property(e => e.CreatedOn)
                .HasMaxLength(50)
                .HasColumnName("createdOn");
            entity.Property(e => e.Outcome)
                .HasMaxLength(255)
                .HasColumnName("outcome");
            entity.Property(e => e.PatientId).HasColumnName("patient_id");
            entity.Property(e => e.Purpose).HasColumnName("purpose");
            entity.Property(e => e.Remarks).HasColumnName("remarks");
            entity.Property(e => e.VisitDate)
                .HasMaxLength(50)
                .HasColumnName("visit_date");
            entity.Property(e => e.VisitId).HasColumnName("visitId");
        });

        modelBuilder.Entity<Vital>(entity =>
        {
            entity.HasKey(e => e.Sno).HasName("PK__vitals__DDDF644641F6B524");

            entity.ToTable("vitals");

            entity.Property(e => e.Sno).HasColumnName("sno");
            entity.Property(e => e.Bp)
                .HasMaxLength(50)
                .HasColumnName("bp");
            entity.Property(e => e.Height)
                .HasMaxLength(50)
                .HasColumnName("height");
            entity.Property(e => e.PatientId).HasColumnName("patient_id");
            entity.Property(e => e.Pulse)
                .HasMaxLength(50)
                .HasColumnName("pulse");
            entity.Property(e => e.RecordedOn)
                .HasMaxLength(50)
                .HasColumnName("recordedOn");
            entity.Property(e => e.Temperature)
                .HasMaxLength(50)
                .HasColumnName("temperature");
            entity.Property(e => e.Weight)
                .HasMaxLength(50)
                .HasColumnName("weight");
        });

        modelBuilder.Entity<VwAncdetailsContinuumReport>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("vw_ANCDetailsContinuumReport");

            entity.Property(e => e.Anc1Date)
                .HasColumnType("datetime")
                .HasColumnName("ANC1 Date");
            entity.Property(e => e.Anc2Date)
                .HasColumnType("datetime")
                .HasColumnName("ANC2 Date");
            entity.Property(e => e.Anc3Date)
                .HasColumnType("datetime")
                .HasColumnName("ANC3 Date");
            entity.Property(e => e.Anc4Date)
                .HasColumnType("datetime")
                .HasColumnName("ANC4 Date");
            entity.Property(e => e.AsbLeukocytesAnc1).HasColumnName("ASB leukocytes-ANC1");
            entity.Property(e => e.AsbLeukocytesAnc2).HasColumnName("ASB leukocytes-ANC2");
            entity.Property(e => e.AsbLeukocytesAnc3).HasColumnName("ASB leukocytes-ANC3");
            entity.Property(e => e.AsbLeukocytesAnc4).HasColumnName("ASB leukocytes-ANC4");
            entity.Property(e => e.AsbNitritesAnc1).HasColumnName("ASB nitrites-ANC1");
            entity.Property(e => e.AsbNitritesAnc2).HasColumnName("ASB nitrites-ANC2");
            entity.Property(e => e.AsbNitritesAnc3).HasColumnName("ASB nitrites-ANC3");
            entity.Property(e => e.AsbNitritesAnc4).HasColumnName("ASB nitrites-ANC4");
            entity.Property(e => e.BeneficiaryGuid)
                .HasMaxLength(100)
                .UseCollation("SQL_Latin1_General_CP1_CI_AS")
                .HasColumnName("BeneficiaryGUID");
            entity.Property(e => e.Bpdiastolic1).HasColumnName("BPDiastolic1");
            entity.Property(e => e.Bpdiastolic2).HasColumnName("BPDiastolic2");
            entity.Property(e => e.Bpdiastolic3).HasColumnName("BPDiastolic3");
            entity.Property(e => e.Bpdiastolic4).HasColumnName("BPDiastolic4");
            entity.Property(e => e.Bpsystolic1).HasColumnName("BPSystolic1");
            entity.Property(e => e.Bpsystolic2).HasColumnName("BPSystolic2");
            entity.Property(e => e.Bpsystolic3).HasColumnName("BPSystolic3");
            entity.Property(e => e.Bpsystolic4).HasColumnName("BPSystolic4");
            entity.Property(e => e.HbLevelAnc1)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("HB Level(ANC1)");
            entity.Property(e => e.HbLevelAnc2)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("HB Level(ANC2)");
            entity.Property(e => e.HbLevelAnc3)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("HB Level(ANC3)");
            entity.Property(e => e.HbLevelAnc4)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("HB Level(ANC4)");
            entity.Property(e => e.IfaDateAnc1).HasColumnName("IFA Date(ANC1)");
            entity.Property(e => e.IfaDateAnc2).HasColumnName("IFA Date(ANC2)");
            entity.Property(e => e.IfaDateAnc3).HasColumnName("IFA Date(ANC3)");
            entity.Property(e => e.IfaDateAnc4).HasColumnName("IFA Date(ANC4)");
            entity.Property(e => e.Tt1Date)
                .HasColumnType("datetime")
                .HasColumnName("TT1 Date");
            entity.Property(e => e.Tt1Dose).HasColumnName("TT1 Dose");
            entity.Property(e => e.Tt2Date)
                .HasColumnType("datetime")
                .HasColumnName("TT2 Date");
            entity.Property(e => e.Tt2Dose).HasColumnName("TT2 Dose");
            entity.Property(e => e.UrineAlbuminAnc1).HasColumnName("Urine albumin-ANC1");
            entity.Property(e => e.UrineAlbuminAnc2).HasColumnName("Urine albumin-ANC2");
            entity.Property(e => e.UrineAlbuminAnc3).HasColumnName("Urine albumin-ANC3");
            entity.Property(e => e.UrineAlbuminAnc4).HasColumnName("Urine albumin-ANC4");
            entity.Property(e => e.UrineSugarAnc1).HasColumnName("Urine Sugar-ANC1");
            entity.Property(e => e.UrineSugarAnc2).HasColumnName("Urine Sugar-ANC2");
            entity.Property(e => e.UrineSugarAnc3).HasColumnName("Urine Sugar-ANC3");
            entity.Property(e => e.UrineSugarAnc4).HasColumnName("Urine Sugar-ANC4");
            entity.Property(e => e.WeightAnc1)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("Weight(ANC1)");
            entity.Property(e => e.WeightAnc2)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("Weight(ANC2)");
            entity.Property(e => e.WeightAnc3)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("Weight(ANC3)");
            entity.Property(e => e.WeightAnc4)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("Weight(ANC4)");
        });

        modelBuilder.Entity<VwChildRegistrationDetail>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("vw_ChildRegistrationDetails");

            entity.Property(e => e.AsmanCode)
                .HasMaxLength(22)
                .UseCollation("SQL_Latin1_General_CP1_CI_AS")
                .HasColumnName("asman_code");
            entity.Property(e => e.Bcgdate).HasColumnName("BCGDate");
            entity.Property(e => e.BeneficiaryGuid)
                .HasMaxLength(50)
                .IsUnicode(false)
                .UseCollation("SQL_Latin1_General_CP1_CI_AS")
                .HasColumnName("BeneficiaryGUID");
            entity.Property(e => e.BirthPhysicalDefectId).HasColumnName("BirthPhysicalDefectID");
            entity.Property(e => e.BirthPhysicalDefectOther)
                .HasMaxLength(1)
                .IsUnicode(false);
            entity.Property(e => e.CaseId).HasColumnName("case_id");
            entity.Property(e => e.CasteId).HasColumnName("CasteID");
            entity.Property(e => e.ChildName)
                .HasMaxLength(100)
                .UseCollation("SQL_Latin1_General_CP1_CI_AS");
            entity.Property(e => e.ComplicationsId)
                .HasMaxLength(4000)
                .HasColumnName("ComplicationsID");
            entity.Property(e => e.CreatedOn).HasColumnType("smalldatetime");
            entity.Property(e => e.DataSourceId).HasColumnName("DataSourceID");
            entity.Property(e => e.DateofRegistration).HasPrecision(0);
            entity.Property(e => e.DeliveryNoteGuid).HasColumnName("DeliveryNoteGUID");
            entity.Property(e => e.Dob)
                .HasPrecision(0)
                .HasColumnName("DOB");
            entity.Property(e => e.DoseId).HasColumnName("DoseID");
            entity.Property(e => e.Episiotomy).HasColumnName("episiotomy");
            entity.Property(e => e.FacilityId).HasColumnName("FacilityID");
            entity.Property(e => e.FacilityOther)
                .HasMaxLength(1)
                .IsUnicode(false);
            entity.Property(e => e.FacilityTypeId).HasColumnName("FacilityTypeID");
            entity.Property(e => e.FatherName)
                .HasMaxLength(302)
                .UseCollation("SQL_Latin1_General_CP1_CI_AS");
            entity.Property(e => e.GenderId).HasColumnName("GenderID");
            entity.Property(e => e.HepbOdate).HasColumnName("HEPB_ODate");
            entity.Property(e => e.IsBabyCryImmediateId).HasColumnName("IsBabyCryImmediateID");
            entity.Property(e => e.IsBreastFeedStartId).HasColumnName("IsBreastFeedStartID");
            entity.Property(e => e.IsCorticosteroidId).HasColumnName("IsCorticosteroidID");
            entity.Property(e => e.IsHigherFacilityReferId).HasColumnName("IsHigherFacilityReferID");
            entity.Property(e => e.IsNeonatalDeathFbircompleteId).HasColumnName("IsNeonatalDeathFBIRCompleteID");
            entity.Property(e => e.IsNeonatalDeathNotificationId).HasColumnName("IsNeonatalDeathNotificationID");
            entity.Property(e => e.IsOpv0).HasColumnName("IsOPV0");
            entity.Property(e => e.IsServiceType).HasColumnName("isServiceType");
            entity.Property(e => e.MaturityId).HasColumnName("MaturityID");
            entity.Property(e => e.MobileNo)
                .HasMaxLength(10)
                .IsUnicode(false)
                .UseCollation("SQL_Latin1_General_CP1_CI_AS");
            entity.Property(e => e.MobileNoOwnerId).HasColumnName("MobileNoOwnerID");
            entity.Property(e => e.MotherName)
                .HasMaxLength(302)
                .UseCollation("SQL_Latin1_General_CP1_CI_AS");
            entity.Property(e => e.NeonatalDeathPlaceId).HasColumnName("NeonatalDeathPlaceID");
            entity.Property(e => e.NeonatalDeathPlaceOther)
                .HasMaxLength(1)
                .IsUnicode(false);
            entity.Property(e => e.NeonatalDeathReasonId).HasColumnName("NeonatalDeathReasonID");
            entity.Property(e => e.NeonatalDeathReasonOther)
                .HasMaxLength(1)
                .IsUnicode(false);
            entity.Property(e => e.NeonatalFacilityTypeId).HasColumnName("NeonatalFacilityTypeID");
            entity.Property(e => e.NeonatalFacilityTypeOther)
                .HasMaxLength(1)
                .IsUnicode(false);
            entity.Property(e => e.Opvodate).HasColumnName("OPVODate");
            entity.Property(e => e.Outcome).HasColumnName("outcome");
            entity.Property(e => e.Ppiucdinserted).HasColumnName("PPIUCDInserted");
            entity.Property(e => e.ProviderId).HasColumnName("ProviderID");
            entity.Property(e => e.PwcategoryGuid)
                .HasMaxLength(50)
                .IsUnicode(false)
                .UseCollation("SQL_Latin1_General_CP1_CI_AS")
                .HasColumnName("PWCategoryGUID");
            entity.Property(e => e.QrcodeId)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasColumnName("QRCodeId");
            entity.Property(e => e.RchchildId).HasColumnName("RCHChildID");
            entity.Property(e => e.RchmotherId)
                .HasMaxLength(50)
                .IsUnicode(false)
                .UseCollation("SQL_Latin1_General_CP1_CI_AS")
                .HasColumnName("RCHMotherID");
            entity.Property(e => e.ReligionId).HasColumnName("ReligionID");
            entity.Property(e => e.SncuadmissionNo)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasColumnName("SNCUAdmissionNo");
            entity.Property(e => e.TimeOfDelivery1)
                .HasPrecision(0)
                .HasColumnName("time_of_delivery1");
            entity.Property(e => e.TypeOfDelivery).HasColumnName("type_of_delivery");
            entity.Property(e => e.UploadedOn).HasColumnType("datetime");
            entity.Property(e => e.VillageId).HasColumnName("VillageID");
            entity.Property(e => e.VitKdate).HasColumnName("VIT_KDate");
            entity.Property(e => e.Weight).HasColumnName("weight");
        });

        modelBuilder.Entity<VwChildRegistrationDetails1>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("vw_ChildRegistrationDetails_1");

            entity.Property(e => e.AsmanCode)
                .HasMaxLength(22)
                .UseCollation("SQL_Latin1_General_CP1_CI_AS")
                .HasColumnName("asman_code");
            entity.Property(e => e.Bcgdate).HasColumnName("BCGDate");
            entity.Property(e => e.BeneficiaryGuid)
                .HasMaxLength(50)
                .IsUnicode(false)
                .UseCollation("SQL_Latin1_General_CP1_CI_AS")
                .HasColumnName("BeneficiaryGUID");
            entity.Property(e => e.BirthPhysicalDefectId).HasColumnName("BirthPhysicalDefectID");
            entity.Property(e => e.BirthPhysicalDefectOther)
                .HasMaxLength(1)
                .IsUnicode(false);
            entity.Property(e => e.CaseId).HasColumnName("case_id");
            entity.Property(e => e.CasteId).HasColumnName("CasteID");
            entity.Property(e => e.ChildName)
                .HasMaxLength(100)
                .UseCollation("SQL_Latin1_General_CP1_CI_AS");
            entity.Property(e => e.ComplicationsId)
                .HasMaxLength(4000)
                .HasColumnName("ComplicationsID");
            entity.Property(e => e.CreatedOn).HasColumnType("smalldatetime");
            entity.Property(e => e.DataSourceId).HasColumnName("DataSourceID");
            entity.Property(e => e.DateofRegistration).HasPrecision(0);
            entity.Property(e => e.DeliveryNoteGuid).HasColumnName("DeliveryNoteGUID");
            entity.Property(e => e.Dob)
                .HasPrecision(0)
                .HasColumnName("DOB");
            entity.Property(e => e.DoseId).HasColumnName("DoseID");
            entity.Property(e => e.Episiotomy).HasColumnName("episiotomy");
            entity.Property(e => e.FacilityId).HasColumnName("FacilityID");
            entity.Property(e => e.FacilityOther)
                .HasMaxLength(1)
                .IsUnicode(false);
            entity.Property(e => e.FacilityTypeId).HasColumnName("FacilityTypeID");
            entity.Property(e => e.FatherName)
                .HasMaxLength(302)
                .UseCollation("SQL_Latin1_General_CP1_CI_AS");
            entity.Property(e => e.GenderId).HasColumnName("GenderID");
            entity.Property(e => e.HepbOdate).HasColumnName("HEPB_ODate");
            entity.Property(e => e.IsBabyCryImmediateId).HasColumnName("IsBabyCryImmediateID");
            entity.Property(e => e.IsBreastFeedStartId).HasColumnName("IsBreastFeedStartID");
            entity.Property(e => e.IsCorticosteroidId).HasColumnName("IsCorticosteroidID");
            entity.Property(e => e.IsHigherFacilityReferId).HasColumnName("IsHigherFacilityReferID");
            entity.Property(e => e.IsNeonatalDeathFbircompleteId).HasColumnName("IsNeonatalDeathFBIRCompleteID");
            entity.Property(e => e.IsNeonatalDeathNotificationId).HasColumnName("IsNeonatalDeathNotificationID");
            entity.Property(e => e.IsOpv0).HasColumnName("IsOPV0");
            entity.Property(e => e.IsServiceType).HasColumnName("isServiceType");
            entity.Property(e => e.MaturityId).HasColumnName("MaturityID");
            entity.Property(e => e.MobileNo)
                .HasMaxLength(10)
                .IsUnicode(false)
                .UseCollation("SQL_Latin1_General_CP1_CI_AS");
            entity.Property(e => e.MobileNoOwnerId).HasColumnName("MobileNoOwnerID");
            entity.Property(e => e.MotherName)
                .HasMaxLength(302)
                .UseCollation("SQL_Latin1_General_CP1_CI_AS");
            entity.Property(e => e.NeonatalDeathPlaceId).HasColumnName("NeonatalDeathPlaceID");
            entity.Property(e => e.NeonatalDeathPlaceOther)
                .HasMaxLength(1)
                .IsUnicode(false);
            entity.Property(e => e.NeonatalDeathReasonId).HasColumnName("NeonatalDeathReasonID");
            entity.Property(e => e.NeonatalDeathReasonOther)
                .HasMaxLength(1)
                .IsUnicode(false);
            entity.Property(e => e.NeonatalFacilityTypeId).HasColumnName("NeonatalFacilityTypeID");
            entity.Property(e => e.NeonatalFacilityTypeOther)
                .HasMaxLength(1)
                .IsUnicode(false);
            entity.Property(e => e.Opvodate).HasColumnName("OPVODate");
            entity.Property(e => e.Outcome).HasColumnName("outcome");
            entity.Property(e => e.Ppiucdinserted).HasColumnName("PPIUCDInserted");
            entity.Property(e => e.ProviderId).HasColumnName("ProviderID");
            entity.Property(e => e.PwcategoryGuid)
                .HasMaxLength(50)
                .IsUnicode(false)
                .UseCollation("SQL_Latin1_General_CP1_CI_AS")
                .HasColumnName("PWCategoryGUID");
            entity.Property(e => e.QrcodeId)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasColumnName("QRCodeId");
            entity.Property(e => e.RchchildId).HasColumnName("RCHChildID");
            entity.Property(e => e.RchmotherId)
                .HasMaxLength(50)
                .IsUnicode(false)
                .UseCollation("SQL_Latin1_General_CP1_CI_AS")
                .HasColumnName("RCHMotherID");
            entity.Property(e => e.ReligionId).HasColumnName("ReligionID");
            entity.Property(e => e.SncuadmissionNo)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasColumnName("SNCUAdmissionNo");
            entity.Property(e => e.TimeOfDelivery1)
                .HasPrecision(0)
                .HasColumnName("time_of_delivery1");
            entity.Property(e => e.TypeOfDelivery).HasColumnName("type_of_delivery");
            entity.Property(e => e.UploadedOn).HasColumnType("datetime");
            entity.Property(e => e.VillageId).HasColumnName("VillageID");
            entity.Property(e => e.VitKdate).HasColumnName("VIT_KDate");
            entity.Property(e => e.Weight).HasColumnName("weight");
        });

        modelBuilder.Entity<VwChildRegistrationDetails19april2025>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("vw_ChildRegistrationDetails_19April2025");

            entity.Property(e => e.AsmanCode)
                .HasMaxLength(22)
                .UseCollation("SQL_Latin1_General_CP1_CI_AS")
                .HasColumnName("asman_code");
            entity.Property(e => e.Bcgdate).HasColumnName("BCGDate");
            entity.Property(e => e.BeneficiaryGuid)
                .HasMaxLength(50)
                .IsUnicode(false)
                .UseCollation("SQL_Latin1_General_CP1_CI_AS")
                .HasColumnName("BeneficiaryGUID");
            entity.Property(e => e.BirthPhysicalDefectId).HasColumnName("BirthPhysicalDefectID");
            entity.Property(e => e.BirthPhysicalDefectOther)
                .HasMaxLength(1)
                .IsUnicode(false);
            entity.Property(e => e.CaseId).HasColumnName("case_id");
            entity.Property(e => e.CasteId).HasColumnName("CasteID");
            entity.Property(e => e.ChildName)
                .HasMaxLength(100)
                .UseCollation("SQL_Latin1_General_CP1_CI_AS");
            entity.Property(e => e.ComplicationsId)
                .HasMaxLength(4000)
                .HasColumnName("ComplicationsID");
            entity.Property(e => e.CreatedOn).HasColumnType("smalldatetime");
            entity.Property(e => e.DataSourceId).HasColumnName("DataSourceID");
            entity.Property(e => e.DateofRegistration).HasPrecision(0);
            entity.Property(e => e.DeliveryNoteGuid).HasColumnName("DeliveryNoteGUID");
            entity.Property(e => e.Dob)
                .HasPrecision(0)
                .HasColumnName("DOB");
            entity.Property(e => e.DoseId).HasColumnName("DoseID");
            entity.Property(e => e.Episiotomy).HasColumnName("episiotomy");
            entity.Property(e => e.FacilityId).HasColumnName("FacilityID");
            entity.Property(e => e.FacilityOther)
                .HasMaxLength(1)
                .IsUnicode(false);
            entity.Property(e => e.FacilityTypeId).HasColumnName("FacilityTypeID");
            entity.Property(e => e.FatherName)
                .HasMaxLength(302)
                .UseCollation("SQL_Latin1_General_CP1_CI_AS");
            entity.Property(e => e.GenderId).HasColumnName("GenderID");
            entity.Property(e => e.HepbOdate).HasColumnName("HEPB_ODate");
            entity.Property(e => e.IsBabyCryImmediateId).HasColumnName("IsBabyCryImmediateID");
            entity.Property(e => e.IsBreastFeedStartId).HasColumnName("IsBreastFeedStartID");
            entity.Property(e => e.IsCorticosteroidId).HasColumnName("IsCorticosteroidID");
            entity.Property(e => e.IsHigherFacilityReferId).HasColumnName("IsHigherFacilityReferID");
            entity.Property(e => e.IsNeonatalDeathFbircompleteId).HasColumnName("IsNeonatalDeathFBIRCompleteID");
            entity.Property(e => e.IsNeonatalDeathNotificationId).HasColumnName("IsNeonatalDeathNotificationID");
            entity.Property(e => e.IsOpv0).HasColumnName("IsOPV0");
            entity.Property(e => e.IsServiceType).HasColumnName("isServiceType");
            entity.Property(e => e.MaturityId).HasColumnName("MaturityID");
            entity.Property(e => e.MobileNo)
                .HasMaxLength(10)
                .IsUnicode(false)
                .UseCollation("SQL_Latin1_General_CP1_CI_AS");
            entity.Property(e => e.MobileNoOwnerId).HasColumnName("MobileNoOwnerID");
            entity.Property(e => e.MotherName)
                .HasMaxLength(302)
                .UseCollation("SQL_Latin1_General_CP1_CI_AS");
            entity.Property(e => e.NeonatalDeathPlaceId).HasColumnName("NeonatalDeathPlaceID");
            entity.Property(e => e.NeonatalDeathPlaceOther)
                .HasMaxLength(1)
                .IsUnicode(false);
            entity.Property(e => e.NeonatalDeathReasonId).HasColumnName("NeonatalDeathReasonID");
            entity.Property(e => e.NeonatalDeathReasonOther)
                .HasMaxLength(1)
                .IsUnicode(false);
            entity.Property(e => e.NeonatalFacilityTypeId).HasColumnName("NeonatalFacilityTypeID");
            entity.Property(e => e.NeonatalFacilityTypeOther)
                .HasMaxLength(1)
                .IsUnicode(false);
            entity.Property(e => e.Opvodate).HasColumnName("OPVODate");
            entity.Property(e => e.Outcome).HasColumnName("outcome");
            entity.Property(e => e.Ppiucdinserted).HasColumnName("PPIUCDInserted");
            entity.Property(e => e.ProviderId).HasColumnName("ProviderID");
            entity.Property(e => e.PwcategoryGuid)
                .HasMaxLength(50)
                .IsUnicode(false)
                .UseCollation("SQL_Latin1_General_CP1_CI_AS")
                .HasColumnName("PWCategoryGUID");
            entity.Property(e => e.QrcodeId)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasColumnName("QRCodeId");
            entity.Property(e => e.RchchildId).HasColumnName("RCHChildID");
            entity.Property(e => e.RchmotherId)
                .HasMaxLength(50)
                .IsUnicode(false)
                .UseCollation("SQL_Latin1_General_CP1_CI_AS")
                .HasColumnName("RCHMotherID");
            entity.Property(e => e.ReligionId).HasColumnName("ReligionID");
            entity.Property(e => e.SncuadmissionNo)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasColumnName("SNCUAdmissionNo");
            entity.Property(e => e.TimeOfDelivery1)
                .HasPrecision(0)
                .HasColumnName("time_of_delivery1");
            entity.Property(e => e.TypeOfDelivery).HasColumnName("type_of_delivery");
            entity.Property(e => e.UploadedOn).HasColumnType("datetime");
            entity.Property(e => e.VillageId).HasColumnName("VillageID");
            entity.Property(e => e.VitKdate).HasColumnName("VIT_KDate");
            entity.Property(e => e.Weight).HasColumnName("weight");
        });

        modelBuilder.Entity<VwChildRegistrationDetails21april2025Backup>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("vw_ChildRegistrationDetails_21April2025_Backup");

            entity.Property(e => e.AsmanCode)
                .HasMaxLength(22)
                .UseCollation("SQL_Latin1_General_CP1_CI_AS")
                .HasColumnName("asman_code");
            entity.Property(e => e.Bcgdate).HasColumnName("BCGDate");
            entity.Property(e => e.BeneficiaryGuid)
                .HasMaxLength(50)
                .IsUnicode(false)
                .UseCollation("SQL_Latin1_General_CP1_CI_AS")
                .HasColumnName("BeneficiaryGUID");
            entity.Property(e => e.BirthPhysicalDefectId).HasColumnName("BirthPhysicalDefectID");
            entity.Property(e => e.BirthPhysicalDefectOther)
                .HasMaxLength(1)
                .IsUnicode(false);
            entity.Property(e => e.CaseId).HasColumnName("case_id");
            entity.Property(e => e.CasteId).HasColumnName("CasteID");
            entity.Property(e => e.ChildName)
                .HasMaxLength(100)
                .UseCollation("SQL_Latin1_General_CP1_CI_AS");
            entity.Property(e => e.ComplicationsId)
                .HasMaxLength(4000)
                .HasColumnName("ComplicationsID");
            entity.Property(e => e.CreatedOn).HasColumnType("smalldatetime");
            entity.Property(e => e.DataSourceId).HasColumnName("DataSourceID");
            entity.Property(e => e.DateofRegistration).HasPrecision(0);
            entity.Property(e => e.DeliveryNoteGuid).HasColumnName("DeliveryNoteGUID");
            entity.Property(e => e.Dob)
                .HasPrecision(0)
                .HasColumnName("DOB");
            entity.Property(e => e.DoseId).HasColumnName("DoseID");
            entity.Property(e => e.Episiotomy).HasColumnName("episiotomy");
            entity.Property(e => e.FacilityId).HasColumnName("FacilityID");
            entity.Property(e => e.FacilityOther)
                .HasMaxLength(1)
                .IsUnicode(false);
            entity.Property(e => e.FacilityTypeId).HasColumnName("FacilityTypeID");
            entity.Property(e => e.FatherName)
                .HasMaxLength(302)
                .UseCollation("SQL_Latin1_General_CP1_CI_AS");
            entity.Property(e => e.GenderId).HasColumnName("GenderID");
            entity.Property(e => e.HepbOdate).HasColumnName("HEPB_ODate");
            entity.Property(e => e.IsBabyCryImmediateId).HasColumnName("IsBabyCryImmediateID");
            entity.Property(e => e.IsBreastFeedStartId).HasColumnName("IsBreastFeedStartID");
            entity.Property(e => e.IsCorticosteroidId).HasColumnName("IsCorticosteroidID");
            entity.Property(e => e.IsHigherFacilityReferId).HasColumnName("IsHigherFacilityReferID");
            entity.Property(e => e.IsNeonatalDeathFbircompleteId).HasColumnName("IsNeonatalDeathFBIRCompleteID");
            entity.Property(e => e.IsNeonatalDeathNotificationId).HasColumnName("IsNeonatalDeathNotificationID");
            entity.Property(e => e.IsOpv0).HasColumnName("IsOPV0");
            entity.Property(e => e.IsServiceType).HasColumnName("isServiceType");
            entity.Property(e => e.MaturityId).HasColumnName("MaturityID");
            entity.Property(e => e.MobileNo)
                .HasMaxLength(10)
                .IsUnicode(false)
                .UseCollation("SQL_Latin1_General_CP1_CI_AS");
            entity.Property(e => e.MobileNoOwnerId).HasColumnName("MobileNoOwnerID");
            entity.Property(e => e.MotherName)
                .HasMaxLength(302)
                .UseCollation("SQL_Latin1_General_CP1_CI_AS");
            entity.Property(e => e.NeonatalDeathPlaceId).HasColumnName("NeonatalDeathPlaceID");
            entity.Property(e => e.NeonatalDeathPlaceOther)
                .HasMaxLength(1)
                .IsUnicode(false);
            entity.Property(e => e.NeonatalDeathReasonId).HasColumnName("NeonatalDeathReasonID");
            entity.Property(e => e.NeonatalDeathReasonOther)
                .HasMaxLength(1)
                .IsUnicode(false);
            entity.Property(e => e.NeonatalFacilityTypeId).HasColumnName("NeonatalFacilityTypeID");
            entity.Property(e => e.NeonatalFacilityTypeOther)
                .HasMaxLength(1)
                .IsUnicode(false);
            entity.Property(e => e.Opvodate).HasColumnName("OPVODate");
            entity.Property(e => e.Outcome).HasColumnName("outcome");
            entity.Property(e => e.Ppiucdinserted).HasColumnName("PPIUCDInserted");
            entity.Property(e => e.ProviderId).HasColumnName("ProviderID");
            entity.Property(e => e.PwcategoryGuid)
                .HasMaxLength(50)
                .IsUnicode(false)
                .UseCollation("SQL_Latin1_General_CP1_CI_AS")
                .HasColumnName("PWCategoryGUID");
            entity.Property(e => e.QrcodeId)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasColumnName("QRCodeId");
            entity.Property(e => e.RchchildId).HasColumnName("RCHChildID");
            entity.Property(e => e.RchmotherId)
                .HasMaxLength(50)
                .IsUnicode(false)
                .UseCollation("SQL_Latin1_General_CP1_CI_AS")
                .HasColumnName("RCHMotherID");
            entity.Property(e => e.ReligionId).HasColumnName("ReligionID");
            entity.Property(e => e.SncuadmissionNo)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasColumnName("SNCUAdmissionNo");
            entity.Property(e => e.TimeOfDelivery1)
                .HasPrecision(0)
                .HasColumnName("time_of_delivery1");
            entity.Property(e => e.TypeOfDelivery).HasColumnName("type_of_delivery");
            entity.Property(e => e.UploadedOn).HasColumnType("datetime");
            entity.Property(e => e.VillageId).HasColumnName("VillageID");
            entity.Property(e => e.VitKdate).HasColumnName("VIT_KDate");
            entity.Property(e => e.Weight).HasColumnName("weight");
        });

        modelBuilder.Entity<VwComplicationsId>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("vw_ComplicationsID");

            entity.Property(e => e.AsmanCode)
                .HasMaxLength(22)
                .UseCollation("SQL_Latin1_General_CP1_CI_AS")
                .HasColumnName("asman_code");
            entity.Property(e => e.CaseId).HasColumnName("case_id");
            entity.Property(e => e.ComplicationsId)
                .HasMaxLength(4000)
                .HasColumnName("ComplicationsID");
        });

        modelBuilder.Entity<VwDeliveryDetail>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("vw_DeliveryDetails");

            entity.Property(e => e.AsmanCode)
                .HasMaxLength(22)
                .UseCollation("SQL_Latin1_General_CP1_CI_AS")
                .HasColumnName("asman_code");
            entity.Property(e => e.BeneficiaryGuid)
                .HasMaxLength(50)
                .IsUnicode(false)
                .UseCollation("SQL_Latin1_General_CP1_CI_AS")
                .HasColumnName("BeneficiaryGUID");
            entity.Property(e => e.CaseId).HasColumnName("case_id");
            entity.Property(e => e.ComplicationsId)
                .HasMaxLength(4000)
                .HasColumnName("ComplicationsID");
            entity.Property(e => e.DeliveryNoteGuid).HasColumnName("DeliveryNoteGUID");
            entity.Property(e => e.Episiotomy).HasColumnName("episiotomy");
            entity.Property(e => e.Outcome).HasColumnName("outcome");
            entity.Property(e => e.Ppiucdinserted).HasColumnName("PPIUCDInserted");
            entity.Property(e => e.PwcategoryGuid)
                .HasMaxLength(50)
                .IsUnicode(false)
                .UseCollation("SQL_Latin1_General_CP1_CI_AS")
                .HasColumnName("PWCategoryGUID");
            entity.Property(e => e.TimeOfDelivery1)
                .HasPrecision(0)
                .HasColumnName("time_of_delivery1");
            entity.Property(e => e.TypeOfDelivery).HasColumnName("type_of_delivery");
            entity.Property(e => e.Weight).HasColumnName("weight");
        });

        modelBuilder.Entity<VwDeliveryNote>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("vw_DeliveryNotes");

            entity.Property(e => e.AdmissionDateInLabourRoom).HasColumnName("Admission date in Labour Room");
            entity.Property(e => e.AdmissionTimeInLabourRoom).HasColumnName("Admission time in Labour room");
            entity.Property(e => e.AmtslAdministered)
                .HasMaxLength(3)
                .IsUnicode(false)
                .HasColumnName("AMTSL Administered");
            entity.Property(e => e.AsmanCode)
                .HasMaxLength(22)
                .UseCollation("SQL_Latin1_General_CP1_CI_AS")
                .HasColumnName("asman_code");
            entity.Property(e => e.BabyBirthWeight)
                .HasMaxLength(5)
                .UseCollation("SQL_Latin1_General_CP1_CI_AS")
                .HasColumnName("Baby Birth Weight");
            entity.Property(e => e.BabyComplication).HasColumnName("Baby Complication");
            entity.Property(e => e.BabyTempAtTimeOfDischarge)
                .HasColumnType("decimal(5, 2)")
                .HasColumnName("Baby Temp. at time of Discharge");
            entity.Property(e => e.BirthDefect)
                .HasMaxLength(3)
                .IsUnicode(false)
                .HasColumnName("Birth Defect");
            entity.Property(e => e.BreastfeedingInitiatedIn1hr)
                .HasPrecision(0)
                .HasColumnName("Breastfeeding Initiated in 1hr");
            entity.Property(e => e.ChildComplicationBirthAsphyxia)
                .HasMaxLength(3)
                .IsUnicode(false)
                .HasColumnName("Child Complication - Birth Asphyxia");
            entity.Property(e => e.ChildComplicationNeonatalSepsis)
                .HasMaxLength(3)
                .IsUnicode(false)
                .HasColumnName("Child Complication - Neonatal Sepsis");
            entity.Property(e => e.ChildComplicationPrematurity)
                .HasMaxLength(3)
                .IsUnicode(false)
                .HasColumnName("Child Complication - Prematurity");
            entity.Property(e => e.ChildReferOutBirthAsphyxia)
                .HasMaxLength(3)
                .IsUnicode(false)
                .HasColumnName("Child Refer Out - Birth Asphyxia");
            entity.Property(e => e.ChildReferOutEclampsiaPreEclampsia)
                .HasMaxLength(3)
                .IsUnicode(false)
                .HasColumnName("Child Refer Out - Eclampsia/Pre-Eclampsia");
            entity.Property(e => e.ChildReferOutNeonatalSepsis)
                .HasMaxLength(3)
                .IsUnicode(false)
                .HasColumnName("Child Refer Out - Neonatal Sepsis");
            entity.Property(e => e.ChildReferOutObstructed)
                .HasMaxLength(3)
                .IsUnicode(false)
                .HasColumnName("Child Refer Out - Obstructed");
            entity.Property(e => e.ChildReferOutOther)
                .HasMaxLength(3)
                .IsUnicode(false)
                .HasColumnName("Child Refer Out - Other");
            entity.Property(e => e.ChildReferOutPph)
                .HasMaxLength(3)
                .IsUnicode(false)
                .HasColumnName("Child Refer Out - PPH");
            entity.Property(e => e.ChildReferOutPrematurity)
                .HasMaxLength(3)
                .IsUnicode(false)
                .HasColumnName("Child Refer Out - Prematurity");
            entity.Property(e => e.ChildReferOutProlonged)
                .HasMaxLength(3)
                .IsUnicode(false)
                .HasColumnName("Child Refer Out - Prolonged");
            entity.Property(e => e.ChildReferOutSepsis)
                .HasMaxLength(3)
                .IsUnicode(false)
                .HasColumnName("Child Refer Out - Sepsis");
            entity.Property(e => e.CorticosteroidInjGiven)
                .HasMaxLength(3)
                .IsUnicode(false)
                .HasColumnName("Corticosteroid Inj. Given");
            entity.Property(e => e.DeliveryDateInLabourRoom).HasColumnName("Delivery date in Labour Room");
            entity.Property(e => e.DeliveryTimeInLabourRoom).HasColumnName("Delivery time in Labour room");
            entity.Property(e => e.DeliveryTypeNormalAssistedCSec)
                .HasMaxLength(8)
                .IsUnicode(false)
                .HasColumnName("Delivery Type (Normal/Assisted/C-sec)");
            entity.Property(e => e.EpisiotomyGiven)
                .HasMaxLength(3)
                .IsUnicode(false)
                .HasColumnName("Episiotomy Given");
            entity.Property(e => e.Fhr).HasColumnName("FHR");
            entity.Property(e => e.Gravida)
                .HasMaxLength(255)
                .UseCollation("SQL_Latin1_General_CP1_CI_AS");
            entity.Property(e => e.InjectionOxytocinGiven)
                .HasMaxLength(3)
                .IsUnicode(false)
                .HasColumnName("Injection Oxytocin Given");
            entity.Property(e => e.MaternalWeight).HasColumnName("Maternal Weight");
            entity.Property(e => e.MotherBpAtTimeOfAdmission)
                .HasMaxLength(9)
                .IsUnicode(false)
                .HasColumnName("Mother BP at time of admission");
            entity.Property(e => e.MotherBpAtTimeOfDischarge)
                .HasMaxLength(9)
                .IsUnicode(false)
                .HasColumnName("Mother BP at time of Discharge");
            entity.Property(e => e.MotherComplicationEclampsiaPreEclampsia)
                .HasMaxLength(3)
                .IsUnicode(false)
                .HasColumnName("Mother Complication - Eclampsia/Pre-Eclampsia");
            entity.Property(e => e.MotherComplicationObstructed)
                .HasMaxLength(3)
                .IsUnicode(false)
                .HasColumnName("Mother Complication - Obstructed");
            entity.Property(e => e.MotherComplicationOther)
                .HasMaxLength(3)
                .IsUnicode(false)
                .HasColumnName("Mother Complication - Other");
            entity.Property(e => e.MotherComplicationPph)
                .HasMaxLength(3)
                .IsUnicode(false)
                .HasColumnName("Mother Complication - PPH");
            entity.Property(e => e.MotherComplicationProlonged)
                .HasMaxLength(3)
                .IsUnicode(false)
                .HasColumnName("Mother Complication - Prolonged");
            entity.Property(e => e.MotherComplicationSepsis)
                .HasMaxLength(3)
                .IsUnicode(false)
                .HasColumnName("Mother Complication - Sepsis");
            entity.Property(e => e.MotherHbEstimationAtTimeOfAdmission).HasColumnName("Mother Hb estimation at time of admission");
            entity.Property(e => e.MotherTempAtTimeOfAdmission)
                .HasColumnType("decimal(5, 2)")
                .HasColumnName("Mother Temp. at time of admission");
            entity.Property(e => e.MotherTempAtTimeOfDischarge)
                .HasColumnType("decimal(5, 2)")
                .HasColumnName("Mother Temp. at time of Discharge");
            entity.Property(e => e.OutcomeOfDeliveryLivebirthStillbirth)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("Outcome of Delivery (Livebirth/Stillbirth)");
            entity.Property(e => e.Parity)
                .HasMaxLength(255)
                .UseCollation("SQL_Latin1_General_CP1_CI_AS");
            entity.Property(e => e.PartographInitiation).HasColumnName("Partograph Initiation");
            entity.Property(e => e.ReferToSncu)
                .HasMaxLength(3)
                .IsUnicode(false)
                .HasColumnName("Refer to SNCU");
            entity.Property(e => e.Rr).HasColumnName("RR");
            entity.Property(e => e.SexOfBaby)
                .HasMaxLength(9)
                .IsUnicode(false)
                .HasColumnName("Sex of Baby");
            entity.Property(e => e.TypeOfStillbirth)
                .HasMaxLength(16)
                .IsUnicode(false)
                .HasColumnName("Type of Stillbirth");
            entity.Property(e => e.VitaminK1)
                .HasMaxLength(6)
                .IsUnicode(false)
                .HasColumnName("Vitamin K1");
        });

        modelBuilder.Entity<VwPdmonitoring>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("VW_PDMonitoring");

            entity.Property(e => e.AsmanCode)
                .HasMaxLength(22)
                .UseCollation("SQL_Latin1_General_CP1_CI_AS")
                .HasColumnName("asman_code");
            entity.Property(e => e.NbC1)
                .HasMaxLength(100)
                .UseCollation("SQL_Latin1_General_CP1_CI_AS")
                .HasColumnName("NB_C1");
            entity.Property(e => e.NbC2)
                .HasMaxLength(100)
                .UseCollation("SQL_Latin1_General_CP1_CI_AS")
                .HasColumnName("NB_C2");
            entity.Property(e => e.NbC3)
                .HasMaxLength(100)
                .UseCollation("SQL_Latin1_General_CP1_CI_AS")
                .HasColumnName("NB_C3");
            entity.Property(e => e.NbC4)
                .HasMaxLength(100)
                .UseCollation("SQL_Latin1_General_CP1_CI_AS")
                .HasColumnName("NB_C4");
            entity.Property(e => e.NbC5)
                .HasMaxLength(100)
                .UseCollation("SQL_Latin1_General_CP1_CI_AS")
                .HasColumnName("NB_C5");
            entity.Property(e => e.NbC6)
                .HasMaxLength(100)
                .UseCollation("SQL_Latin1_General_CP1_CI_AS")
                .HasColumnName("NB_C6");
            entity.Property(e => e.NbRr1)
                .HasMaxLength(100)
                .UseCollation("SQL_Latin1_General_CP1_CI_AS")
                .HasColumnName("NB_RR1");
            entity.Property(e => e.NbRr2)
                .HasMaxLength(100)
                .UseCollation("SQL_Latin1_General_CP1_CI_AS")
                .HasColumnName("NB_RR2");
            entity.Property(e => e.NbRr3)
                .HasMaxLength(100)
                .UseCollation("SQL_Latin1_General_CP1_CI_AS")
                .HasColumnName("NB_RR3");
            entity.Property(e => e.NbRr4)
                .HasMaxLength(100)
                .UseCollation("SQL_Latin1_General_CP1_CI_AS")
                .HasColumnName("NB_RR4");
            entity.Property(e => e.NbRr5)
                .HasMaxLength(100)
                .UseCollation("SQL_Latin1_General_CP1_CI_AS")
                .HasColumnName("NB_RR5");
            entity.Property(e => e.NbRr6)
                .HasMaxLength(100)
                .UseCollation("SQL_Latin1_General_CP1_CI_AS")
                .HasColumnName("NB_RR6");
            entity.Property(e => e.NbT1)
                .HasMaxLength(100)
                .UseCollation("SQL_Latin1_General_CP1_CI_AS")
                .HasColumnName("NB_T1");
            entity.Property(e => e.NbT2)
                .HasMaxLength(100)
                .UseCollation("SQL_Latin1_General_CP1_CI_AS")
                .HasColumnName("NB_T2");
            entity.Property(e => e.NbT3)
                .HasMaxLength(100)
                .UseCollation("SQL_Latin1_General_CP1_CI_AS")
                .HasColumnName("NB_T3");
            entity.Property(e => e.NbT4)
                .HasMaxLength(100)
                .UseCollation("SQL_Latin1_General_CP1_CI_AS")
                .HasColumnName("NB_T4");
            entity.Property(e => e.NbT5)
                .HasMaxLength(100)
                .UseCollation("SQL_Latin1_General_CP1_CI_AS")
                .HasColumnName("NB_T5");
            entity.Property(e => e.NbT6)
                .HasMaxLength(100)
                .UseCollation("SQL_Latin1_General_CP1_CI_AS")
                .HasColumnName("NB_T6");
            entity.Property(e => e.PpBleeding1)
                .HasMaxLength(100)
                .UseCollation("SQL_Latin1_General_CP1_CI_AS")
                .HasColumnName("PP_Bleeding1");
            entity.Property(e => e.PpBleeding2)
                .HasMaxLength(100)
                .UseCollation("SQL_Latin1_General_CP1_CI_AS")
                .HasColumnName("PP_Bleeding2");
            entity.Property(e => e.PpBleeding3)
                .HasMaxLength(100)
                .UseCollation("SQL_Latin1_General_CP1_CI_AS")
                .HasColumnName("PP_Bleeding3");
            entity.Property(e => e.PpBleeding4)
                .HasMaxLength(100)
                .UseCollation("SQL_Latin1_General_CP1_CI_AS")
                .HasColumnName("PP_Bleeding4");
            entity.Property(e => e.PpBleeding5)
                .HasMaxLength(100)
                .UseCollation("SQL_Latin1_General_CP1_CI_AS")
                .HasColumnName("PP_Bleeding5");
            entity.Property(e => e.PpBleeding6)
                .HasMaxLength(100)
                .UseCollation("SQL_Latin1_General_CP1_CI_AS")
                .HasColumnName("PP_Bleeding6");
            entity.Property(e => e.PpBp1)
                .HasMaxLength(100)
                .UseCollation("SQL_Latin1_General_CP1_CI_AS")
                .HasColumnName("PP_BP1");
            entity.Property(e => e.PpBp2)
                .HasMaxLength(100)
                .UseCollation("SQL_Latin1_General_CP1_CI_AS")
                .HasColumnName("PP_BP2");
            entity.Property(e => e.PpBp3)
                .HasMaxLength(100)
                .UseCollation("SQL_Latin1_General_CP1_CI_AS")
                .HasColumnName("PP_BP3");
            entity.Property(e => e.PpBp4)
                .HasMaxLength(100)
                .UseCollation("SQL_Latin1_General_CP1_CI_AS")
                .HasColumnName("PP_BP4");
            entity.Property(e => e.PpBp5)
                .HasMaxLength(100)
                .UseCollation("SQL_Latin1_General_CP1_CI_AS")
                .HasColumnName("PP_BP5");
            entity.Property(e => e.PpBp6)
                .HasMaxLength(100)
                .UseCollation("SQL_Latin1_General_CP1_CI_AS")
                .HasColumnName("PP_BP6");
            entity.Property(e => e.PpC1)
                .HasMaxLength(100)
                .UseCollation("SQL_Latin1_General_CP1_CI_AS")
                .HasColumnName("PP_C1");
            entity.Property(e => e.PpC2)
                .HasMaxLength(100)
                .UseCollation("SQL_Latin1_General_CP1_CI_AS")
                .HasColumnName("PP_C2");
            entity.Property(e => e.PpC3)
                .HasMaxLength(100)
                .UseCollation("SQL_Latin1_General_CP1_CI_AS")
                .HasColumnName("PP_C3");
            entity.Property(e => e.PpC4)
                .HasMaxLength(100)
                .UseCollation("SQL_Latin1_General_CP1_CI_AS")
                .HasColumnName("PP_C4");
            entity.Property(e => e.PpC5)
                .HasMaxLength(100)
                .UseCollation("SQL_Latin1_General_CP1_CI_AS")
                .HasColumnName("PP_C5");
            entity.Property(e => e.PpC6)
                .HasMaxLength(100)
                .UseCollation("SQL_Latin1_General_CP1_CI_AS")
                .HasColumnName("PP_C6");
            entity.Property(e => e.PpP1)
                .HasMaxLength(100)
                .UseCollation("SQL_Latin1_General_CP1_CI_AS")
                .HasColumnName("PP_P1");
            entity.Property(e => e.PpP2)
                .HasMaxLength(100)
                .UseCollation("SQL_Latin1_General_CP1_CI_AS")
                .HasColumnName("PP_P2");
            entity.Property(e => e.PpP3)
                .HasMaxLength(100)
                .UseCollation("SQL_Latin1_General_CP1_CI_AS")
                .HasColumnName("PP_P3");
            entity.Property(e => e.PpP4)
                .HasMaxLength(100)
                .UseCollation("SQL_Latin1_General_CP1_CI_AS")
                .HasColumnName("PP_P4");
            entity.Property(e => e.PpP5)
                .HasMaxLength(100)
                .UseCollation("SQL_Latin1_General_CP1_CI_AS")
                .HasColumnName("PP_P5");
            entity.Property(e => e.PpP6)
                .HasMaxLength(100)
                .UseCollation("SQL_Latin1_General_CP1_CI_AS")
                .HasColumnName("PP_P6");
            entity.Property(e => e.PpT1)
                .HasMaxLength(100)
                .UseCollation("SQL_Latin1_General_CP1_CI_AS")
                .HasColumnName("PP_T1");
            entity.Property(e => e.PpT2)
                .HasMaxLength(100)
                .UseCollation("SQL_Latin1_General_CP1_CI_AS")
                .HasColumnName("PP_T2");
            entity.Property(e => e.PpT3)
                .HasMaxLength(100)
                .UseCollation("SQL_Latin1_General_CP1_CI_AS")
                .HasColumnName("PP_T3");
            entity.Property(e => e.PpT4)
                .HasMaxLength(100)
                .UseCollation("SQL_Latin1_General_CP1_CI_AS")
                .HasColumnName("PP_T4");
            entity.Property(e => e.PpT5)
                .HasMaxLength(100)
                .UseCollation("SQL_Latin1_General_CP1_CI_AS")
                .HasColumnName("PP_T5");
            entity.Property(e => e.PpT6)
                .HasMaxLength(100)
                .UseCollation("SQL_Latin1_General_CP1_CI_AS")
                .HasColumnName("PP_T6");
            entity.Property(e => e.PpU1)
                .HasMaxLength(100)
                .UseCollation("SQL_Latin1_General_CP1_CI_AS")
                .HasColumnName("PP_U1");
            entity.Property(e => e.PpU2)
                .HasMaxLength(100)
                .UseCollation("SQL_Latin1_General_CP1_CI_AS")
                .HasColumnName("PP_U2");
            entity.Property(e => e.PpU3)
                .HasMaxLength(100)
                .UseCollation("SQL_Latin1_General_CP1_CI_AS")
                .HasColumnName("PP_U3");
            entity.Property(e => e.PpU4)
                .HasMaxLength(100)
                .UseCollation("SQL_Latin1_General_CP1_CI_AS")
                .HasColumnName("PP_U4");
            entity.Property(e => e.PpU5)
                .HasMaxLength(100)
                .UseCollation("SQL_Latin1_General_CP1_CI_AS")
                .HasColumnName("PP_U5");
            entity.Property(e => e.PpU6)
                .HasMaxLength(100)
                .UseCollation("SQL_Latin1_General_CP1_CI_AS")
                .HasColumnName("PP_U6");
        });

        modelBuilder.Entity<VwPrasavGeoArea>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("vw_Prasav_geo_areas");

            entity.Property(e => e.AreaLevelId).HasColumnName("area_level_id");
            entity.Property(e => e.Code)
                .HasMaxLength(20)
                .UseCollation("SQL_Latin1_General_CP1_CI_AS")
                .HasColumnName("code");
            entity.Property(e => e.Created)
                .HasPrecision(0)
                .HasColumnName("created");
            entity.Property(e => e.CreatedBy).HasColumnName("created_by");
            entity.Property(e => e.Id)
                .ValueGeneratedOnAdd()
                .HasColumnName("id");
            entity.Property(e => e.IsDeleted).HasColumnName("is_deleted");
            entity.Property(e => e.Latitude)
                .HasMaxLength(50)
                .UseCollation("SQL_Latin1_General_CP1_CI_AS")
                .HasColumnName("latitude");
            entity.Property(e => e.Lft).HasColumnName("lft");
            entity.Property(e => e.Longitude)
                .HasMaxLength(50)
                .UseCollation("SQL_Latin1_General_CP1_CI_AS")
                .HasColumnName("longitude");
            entity.Property(e => e.Modified)
                .HasPrecision(0)
                .HasColumnName("modified");
            entity.Property(e => e.ModifiedBy).HasColumnName("modified_by");
            entity.Property(e => e.Name)
                .HasMaxLength(255)
                .UseCollation("SQL_Latin1_General_CP1_CI_AS")
                .HasColumnName("name");
            entity.Property(e => e.ParentId).HasColumnName("parent_id");
            entity.Property(e => e.Rght).HasColumnName("rght");
        });

        modelBuilder.Entity<VwSecondChildRegistrationDetail>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("vw_Second_ChildRegistrationDetails");

            entity.Property(e => e.AsmanCode)
                .HasMaxLength(22)
                .UseCollation("SQL_Latin1_General_CP1_CI_AS")
                .HasColumnName("asman_code");
            entity.Property(e => e.Bcgdate).HasColumnName("BCGDate");
            entity.Property(e => e.BeneficiaryGuid)
                .HasMaxLength(50)
                .IsUnicode(false)
                .UseCollation("SQL_Latin1_General_CP1_CI_AS")
                .HasColumnName("BeneficiaryGUID");
            entity.Property(e => e.BirthPhysicalDefectId).HasColumnName("BirthPhysicalDefectID");
            entity.Property(e => e.BirthPhysicalDefectOther)
                .HasMaxLength(1)
                .IsUnicode(false);
            entity.Property(e => e.CaseId).HasColumnName("case_id");
            entity.Property(e => e.CasteId).HasColumnName("CasteID");
            entity.Property(e => e.ChildName)
                .HasMaxLength(100)
                .UseCollation("SQL_Latin1_General_CP1_CI_AS");
            entity.Property(e => e.ComplicationsId)
                .HasMaxLength(4000)
                .HasColumnName("ComplicationsID");
            entity.Property(e => e.CreatedOn).HasColumnType("smalldatetime");
            entity.Property(e => e.DataSourceId).HasColumnName("DataSourceID");
            entity.Property(e => e.DateofRegistration).HasPrecision(0);
            entity.Property(e => e.DeliveryNoteGuid).HasColumnName("DeliveryNoteGUID");
            entity.Property(e => e.Dob)
                .HasPrecision(0)
                .HasColumnName("DOB");
            entity.Property(e => e.DoseId).HasColumnName("DoseID");
            entity.Property(e => e.Episiotomy).HasColumnName("episiotomy");
            entity.Property(e => e.FacilityId).HasColumnName("FacilityID");
            entity.Property(e => e.FacilityOther)
                .HasMaxLength(1)
                .IsUnicode(false);
            entity.Property(e => e.FacilityTypeId).HasColumnName("FacilityTypeID");
            entity.Property(e => e.FatherName)
                .HasMaxLength(302)
                .UseCollation("SQL_Latin1_General_CP1_CI_AS");
            entity.Property(e => e.GenderId).HasColumnName("GenderID");
            entity.Property(e => e.HepbOdate).HasColumnName("HEPB_ODate");
            entity.Property(e => e.IsBabyCryImmediateId).HasColumnName("IsBabyCryImmediateID");
            entity.Property(e => e.IsBreastFeedStartId).HasColumnName("IsBreastFeedStartID");
            entity.Property(e => e.IsCorticosteroidId).HasColumnName("IsCorticosteroidID");
            entity.Property(e => e.IsHigherFacilityReferId).HasColumnName("IsHigherFacilityReferID");
            entity.Property(e => e.IsNeonatalDeathFbircompleteId).HasColumnName("IsNeonatalDeathFBIRCompleteID");
            entity.Property(e => e.IsNeonatalDeathNotificationId).HasColumnName("IsNeonatalDeathNotificationID");
            entity.Property(e => e.IsOpv0).HasColumnName("IsOPV0");
            entity.Property(e => e.IsServiceType).HasColumnName("isServiceType");
            entity.Property(e => e.MaturityId).HasColumnName("MaturityID");
            entity.Property(e => e.MobileNo)
                .HasMaxLength(10)
                .IsUnicode(false)
                .UseCollation("SQL_Latin1_General_CP1_CI_AS");
            entity.Property(e => e.MobileNoOwnerId).HasColumnName("MobileNoOwnerID");
            entity.Property(e => e.MotherName)
                .HasMaxLength(302)
                .UseCollation("SQL_Latin1_General_CP1_CI_AS");
            entity.Property(e => e.NeonatalDeathPlaceId).HasColumnName("NeonatalDeathPlaceID");
            entity.Property(e => e.NeonatalDeathPlaceOther)
                .HasMaxLength(1)
                .IsUnicode(false);
            entity.Property(e => e.NeonatalDeathReasonId).HasColumnName("NeonatalDeathReasonID");
            entity.Property(e => e.NeonatalDeathReasonOther)
                .HasMaxLength(1)
                .IsUnicode(false);
            entity.Property(e => e.NeonatalFacilityTypeId).HasColumnName("NeonatalFacilityTypeID");
            entity.Property(e => e.NeonatalFacilityTypeOther)
                .HasMaxLength(1)
                .IsUnicode(false);
            entity.Property(e => e.Opvodate).HasColumnName("OPVODate");
            entity.Property(e => e.Outcome).HasColumnName("outcome");
            entity.Property(e => e.Ppiucdinserted).HasColumnName("PPIUCDInserted");
            entity.Property(e => e.ProviderId).HasColumnName("ProviderID");
            entity.Property(e => e.PwcategoryGuid)
                .HasMaxLength(50)
                .IsUnicode(false)
                .UseCollation("SQL_Latin1_General_CP1_CI_AS")
                .HasColumnName("PWCategoryGUID");
            entity.Property(e => e.QrcodeId)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasColumnName("QRCodeId");
            entity.Property(e => e.RchchildId).HasColumnName("RCHChildID");
            entity.Property(e => e.RchmotherId)
                .HasMaxLength(50)
                .IsUnicode(false)
                .UseCollation("SQL_Latin1_General_CP1_CI_AS")
                .HasColumnName("RCHMotherID");
            entity.Property(e => e.ReligionId).HasColumnName("ReligionID");
            entity.Property(e => e.SncuadmissionNo)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasColumnName("SNCUAdmissionNo");
            entity.Property(e => e.TimeOfDelivery1)
                .HasPrecision(0)
                .HasColumnName("time_of_delivery1");
            entity.Property(e => e.TypeOfDelivery).HasColumnName("type_of_delivery");
            entity.Property(e => e.UploadedOn).HasColumnType("datetime");
            entity.Property(e => e.VillageId).HasColumnName("VillageID");
            entity.Property(e => e.VitKdate).HasColumnName("VIT_KDate");
            entity.Property(e => e.Weight).HasColumnName("weight");
        });

        modelBuilder.Entity<Wfl>(entity =>
        {
            entity.HasKey(e => e.Sno).HasName("PK__wfl__DDDF6446B4F7F462");

            entity.ToTable("wfl");

            entity.Property(e => e.Sno).HasColumnName("sno");
            entity.Property(e => e.AgeGroup)
                .HasMaxLength(20)
                .HasColumnName("age_group");
            entity.Property(e => e.Gender)
                .HasMaxLength(10)
                .HasColumnName("gender");
            entity.Property(e => e.Length)
                .HasMaxLength(20)
                .HasColumnName("length");
            entity.Property(e => e.Median)
                .HasMaxLength(20)
                .HasColumnName("median");
            entity.Property(e => e.NegSd1)
                .HasMaxLength(20)
                .HasColumnName("neg_sd_1");
            entity.Property(e => e.NegSd2)
                .HasMaxLength(20)
                .HasColumnName("neg_sd_2");
            entity.Property(e => e.NegSd3)
                .HasMaxLength(20)
                .HasColumnName("neg_sd_3");
            entity.Property(e => e.PosSd1)
                .HasMaxLength(20)
                .HasColumnName("pos_sd_1");
            entity.Property(e => e.PosSd2).HasColumnName("pos_sd_2");
            entity.Property(e => e.PosSd3).HasColumnName("pos_sd_3");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
