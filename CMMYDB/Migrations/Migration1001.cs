using System.Data;
using ServiceStack;
using ServiceStack.DataAnnotations;
using ServiceStack.OrmLite;
using System;
using System.IO;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization;
using CMMYDB;

namespace CMMYDB.Migrations;

public class Migration1001 : MigrationBase
{

    public class Employee
    {
        [AutoIncrement]
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public Gender Gender { get; set; }
        public DateTime DateOfBirth { get; set; }
        public string Email { get; set; }
        public string PhoneNumber { get; set; }
        public string Address { get; set; }
        public DateTime HireDate { get; set; }
        public string Position { get; set; }
        public int DepartmentId { get; set; }
        [References(typeof(WorkArea))]
        public int WorkAreaId { get; set; }
    }
    
    public class Payroll
    {
        [AutoIncrement]
        public int Id { get; set; }
        [References(typeof(Employee))]
        public int EmployeeId { get; set; }
        public DateTime PayrollDate { get; set; }
        public int GrossPay { get; set; }
        public int NetPay { get; set; }
        public PayrollFrequency Frequency { get; set; }
    }
    
    public class Benefit
    {
        [AutoIncrement]
        public int Id { get; set; }
        [References(typeof(Employee))]
        public int EmployeeId { get; set; }
        public BenefitType BenefitType { get; set; }
        public decimal CoverageAmount { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
    }
    
    public class Recruitment
    {
        [AutoIncrement]
        public int Id { get; set; }
        public string JobTitle { get; set; }
        public string JobDescription { get; set; }
        public RecruitmentStatus Status { get; set; }
        public DateTime PostedDate { get; set; }
        public DateTime ClosingDate { get; set; }
    }
    
    public class Onboarding
    {
        [AutoIncrement]
        public int Id { get; set; }
        [References(typeof(Employee))]
        public int EmployeeId { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public string Status { get; set; }
    }
    
    public class PerformanceReview
    {
        [AutoIncrement]
        public int Id { get; set; }
        [References(typeof(Employee))]
        public int EmployeeId { get; set; }
        public DateTime ReviewDate { get; set; }
        public int ReviewerId { get; set; }
        public string Comments { get; set; }
        public int Rating { get; set; }
    }
    
    public class Training
    {
        [AutoIncrement]
        public int Id { get; set; }
        [References(typeof(Employee))]
        public int EmployeeId { get; set; }
        public string TrainingName { get; set; }
        public DateTime TrainingDate { get; set; }
        public TrainingStatus Status { get; set; }
        public string Certificate { get; set; }
    }
    
    public class WorkInstruction
    {
        [AutoIncrement]
        public int Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public string Version { get; set; }
        public DateTime CreatedDate { get; set; }
        public DateTime UpdatedDate { get; set; }
    }
    
    public class WorkArea
    {
        [AutoIncrement]
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public int SupervisorId { get; set; }
        public int ManagerId { get; set; }
    }
    
    public class WorkAreaStation
    {
        [AutoIncrement]
        public int Id { get; set; }
        [References(typeof(WorkArea))]
        public int WorkAreaId { get; set; }
        public string StationName { get; set; }
        public string Description { get; set; }
    }
    
    public class WorkAreaEquipment
    {
        [AutoIncrement]
        public int Id { get; set; }
        [References(typeof(WorkArea))]
        public int WorkAreaId { get; set; }
        public string EquipmentName { get; set; }
        public string Description { get; set; }
    }
    
    public class WorkAreaCheckSheet
    {
        [AutoIncrement]
        public int Id { get; set; }
        [References(typeof(WorkArea))]
        public int WorkAreaId { get; set; }
        public string CheckSheetName { get; set; }
        public string Description { get; set; }
    }
    
    public class WorkAreaDetail
    {
        [AutoIncrement]
        public int Id { get; set; }
        [References(typeof(WorkArea))]
        public int WorkAreaId { get; set; }
        public string DetailName { get; set; }
        public string Description { get; set; }
    }
    
    public class Product
    {
        [AutoIncrement]
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        [References(typeof(Supplier))]
        public int SupplierId { get; set; }
    }
    
    public class QualityAuditProductCheckSheet
    {
        [AutoIncrement]
        public int Id { get; set; }
        [References(typeof(Product))]
        public int ProductId { get; set; }
        public string CheckSheetName { get; set; }
        public string Description { get; set; }
    }
    
    public class Supplier
    {
        [AutoIncrement]
        public int Id { get; set; }
        public string Name { get; set; }
        public string ContactPerson { get; set; }
        public string Email { get; set; }
        public string PhoneNumber { get; set; }
        public string Address { get; set; }
    }
    
    public class SupplierQuality
    {
        [AutoIncrement]
        public int Id { get; set; }
        [References(typeof(Supplier))]
        public int SupplierId { get; set; }
        public int QualityScore { get; set; }
        public DateTime AuditDate { get; set; }
        public string Comments { get; set; }
    }
    
    public class ProductionTracking
    {
        [AutoIncrement]
        public int Id { get; set; }
        [References(typeof(Product))]
        public int ProductId { get; set; }
        public int QuantityProduced { get; set; }
        public DateTime ProductionDate { get; set; }
        [References(typeof(WorkArea))]
        public int WorkAreaId { get; set; }
    }
    
    public class MachineEffectiveness
    {
        [AutoIncrement]
        public int Id { get; set; }
        public int MachineId { get; set; }
        public int EffectivenessScore { get; set; }
        public DateTime AuditDate { get; set; }
        public string Comments { get; set; }
    }
    
    public class WorkAreaSupervisor
    {
        [AutoIncrement]
        public int Id { get; set; }
        [References(typeof(WorkArea))]
        public int WorkAreaId { get; set; }
        public int SupervisorId { get; set; }
    }
    
    public class WorkAreaManager
    {
        [AutoIncrement]
        public int Id { get; set; }
        [References(typeof(WorkArea))]
        public int WorkAreaId { get; set; }
        public int ManagerId { get; set; }
    }
    
    public class WorkAreaRoleAssignment
    {
        [AutoIncrement]
        public int Id { get; set; }
        [References(typeof(WorkArea))]
        public int WorkAreaId { get; set; }
        [References(typeof(Employee))]
        public int EmployeeId { get; set; }
        public WorkAreaRole Role { get; set; }
    }
    
    public class WorkInstructionStep
    {
        [AutoIncrement]
        public int Id { get; set; }
        [References(typeof(WorkInstruction))]
        public int WorkInstructionId { get; set; }
        public int StepNumber { get; set; }
        public string Description { get; set; }
    }
    
    public class WorkInstructionModelDetail
    {
        [AutoIncrement]
        public int Id { get; set; }
        [References(typeof(WorkInstruction))]
        public int WorkInstructionId { get; set; }
        public string ModelDetail { get; set; }
    }
    
    public class MaterialRequirementsPlanning
    {
        [AutoIncrement]
        public int Id { get; set; }
        [References(typeof(Product))]
        public int ProductId { get; set; }
        public int RequiredQuantity { get; set; }
        public DateTime PlannedDate { get; set; }
    }
    
    public class Report
    {
        [AutoIncrement]
        public int Id { get; set; }
        public string ReportName { get; set; }
        public DateTime ReportDate { get; set; }
        public string ReportData { get; set; }
    }
    
    public class Log : AuditBase
    {
        [AutoIncrement]
        public int Id { get; set; }
        public string Action { get; set; }
        public DateTime Timestamp { get; set; }
    }
    
    public class Permission
    {
        [AutoIncrement]
        public int Id { get; set; }
        [References(typeof(WorkArea))]
        public int WorkAreaId { get; set; }
        public WorkAreaRole Role { get; set; }
        public PermissionLevel PermissionLevel { get; set; }
    }
    
    public enum Gender
    {
        Male,
        Female,
        Other,
    }
    
    public enum PayrollFrequency
    {
        Weekly,
        BiWeekly,
        Monthly,
    }
    
    public enum BenefitType
    {
        Health,
        Dental,
        Vision,
        Retirement,
    }
    
    public enum RecruitmentStatus
    {
        Open,
        Closed,
        Filled,
    }
    
    public enum TrainingStatus
    {
        NotStarted,
        InProgress,
        Completed,
    }
    
    public enum WorkAreaRole
    {
        Supervisor,
        Manager,
        Operator,
        Technician,
    }
    
    public enum PermissionLevel
    {
        ReadOnly,
        Crud,
    }
    

    public override void Up()
    {
        Db.CreateTable<Recruitment>();
        Db.CreateTable<WorkInstruction>();
        Db.CreateTable<WorkArea>();
        Db.CreateTable<Supplier>();
        Db.CreateTable<MachineEffectiveness>();
        Db.CreateTable<Report>();
        Db.CreateTable<Log>();
        Db.CreateTable<Employee>();
        Db.CreateTable<Payroll>();
        Db.CreateTable<Benefit>();
        Db.CreateTable<Onboarding>();
        Db.CreateTable<PerformanceReview>();
        Db.CreateTable<Training>();
        Db.CreateTable<WorkAreaStation>();
        Db.CreateTable<WorkAreaEquipment>();
        Db.CreateTable<WorkAreaCheckSheet>();
        Db.CreateTable<WorkAreaDetail>();
        Db.CreateTable<Product>();
        Db.CreateTable<QualityAuditProductCheckSheet>();
        Db.CreateTable<SupplierQuality>();
        Db.CreateTable<ProductionTracking>();
        Db.CreateTable<WorkAreaSupervisor>();
        Db.CreateTable<WorkAreaManager>();
        Db.CreateTable<WorkAreaRoleAssignment>();
        Db.CreateTable<WorkInstructionStep>();
        Db.CreateTable<WorkInstructionModelDetail>();
        Db.CreateTable<MaterialRequirementsPlanning>();
        Db.CreateTable<Permission>();
    }

    public override void Down()
    {
        Db.DropTable<Permission>();
        Db.DropTable<MaterialRequirementsPlanning>();
        Db.DropTable<WorkInstructionModelDetail>();
        Db.DropTable<WorkInstructionStep>();
        Db.DropTable<WorkAreaRoleAssignment>();
        Db.DropTable<WorkAreaManager>();
        Db.DropTable<WorkAreaSupervisor>();
        Db.DropTable<ProductionTracking>();
        Db.DropTable<SupplierQuality>();
        Db.DropTable<QualityAuditProductCheckSheet>();
        Db.DropTable<Product>();
        Db.DropTable<WorkAreaDetail>();
        Db.DropTable<WorkAreaCheckSheet>();
        Db.DropTable<WorkAreaEquipment>();
        Db.DropTable<WorkAreaStation>();
        Db.DropTable<Training>();
        Db.DropTable<PerformanceReview>();
        Db.DropTable<Onboarding>();
        Db.DropTable<Benefit>();
        Db.DropTable<Payroll>();
        Db.DropTable<Employee>();
        Db.DropTable<Log>();
        Db.DropTable<Report>();
        Db.DropTable<MachineEffectiveness>();
        Db.DropTable<Supplier>();
        Db.DropTable<WorkArea>();
        Db.DropTable<WorkInstruction>();
        Db.DropTable<Recruitment>();
    }
}