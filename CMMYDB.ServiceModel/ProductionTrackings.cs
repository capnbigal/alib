using System;
using System.IO;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization;
using ServiceStack;
using ServiceStack.DataAnnotations;
using CMMYDB;

namespace CMMYDB.ServiceModel;

public class QueryEmployees : QueryDb<Employee>
{
    public int? Id { get; set; }
    public List<int>? Ids { get; set; }
}

public class CreateEmployee : ICreateDb<Employee>, IReturn<IdResponse>
{
    [ValidateNotEmpty]
    public string FirstName { get; set; }
    [ValidateNotEmpty]
    public string LastName { get; set; }
    public Gender Gender { get; set; }
    public DateTime DateOfBirth { get; set; }
    [ValidateNotEmpty]
    public string Email { get; set; }
    [ValidateNotEmpty]
    public string PhoneNumber { get; set; }
    [ValidateNotEmpty]
    public string Address { get; set; }
    public DateTime HireDate { get; set; }
    [ValidateNotEmpty]
    public string Position { get; set; }
    public int DepartmentId { get; set; }
    public int WorkAreaId { get; set; }
}

public class UpdateEmployee : IPatchDb<Employee>, IReturn<IdResponse>
{
    public int Id { get; set; }
    public string? FirstName { get; set; }
    public string? LastName { get; set; }
    public Gender? Gender { get; set; }
    public DateTime? DateOfBirth { get; set; }
    public string? Email { get; set; }
    public string? PhoneNumber { get; set; }
    public string? Address { get; set; }
    public DateTime? HireDate { get; set; }
    public string? Position { get; set; }
    public int? DepartmentId { get; set; }
    public int? WorkAreaId { get; set; }
}

public class DeleteEmployee : IDeleteDb<Employee>, IReturnVoid
{
    public int? Id { get; set; }
    public List<int>? Ids { get; set; }
}

public class QueryPayrolls : QueryDb<Payroll>
{
    public int? Id { get; set; }
    public List<int>? Ids { get; set; }
}

public class CreatePayroll : ICreateDb<Payroll>, IReturn<IdResponse>
{
    public int EmployeeId { get; set; }
    public DateTime PayrollDate { get; set; }
    public int GrossPay { get; set; }
    public int NetPay { get; set; }
    public PayrollFrequency Frequency { get; set; }
}

public class UpdatePayroll : IPatchDb<Payroll>, IReturn<IdResponse>
{
    public int Id { get; set; }
    public int? EmployeeId { get; set; }
    public DateTime? PayrollDate { get; set; }
    public int? GrossPay { get; set; }
    public int? NetPay { get; set; }
    public PayrollFrequency? Frequency { get; set; }
}

public class DeletePayroll : IDeleteDb<Payroll>, IReturnVoid
{
    public int? Id { get; set; }
    public List<int>? Ids { get; set; }
}

public class QueryBenefits : QueryDb<Benefit>
{
    public int? Id { get; set; }
    public List<int>? Ids { get; set; }
}

public class CreateBenefit : ICreateDb<Benefit>, IReturn<IdResponse>
{
    public int EmployeeId { get; set; }
    public BenefitType BenefitType { get; set; }
    public decimal CoverageAmount { get; set; }
    public DateTime StartDate { get; set; }
    public DateTime EndDate { get; set; }
}

public class UpdateBenefit : IPatchDb<Benefit>, IReturn<IdResponse>
{
    public int Id { get; set; }
    public int? EmployeeId { get; set; }
    public BenefitType? BenefitType { get; set; }
    public decimal? CoverageAmount { get; set; }
    public DateTime? StartDate { get; set; }
    public DateTime? EndDate { get; set; }
}

public class DeleteBenefit : IDeleteDb<Benefit>, IReturnVoid
{
    public int? Id { get; set; }
    public List<int>? Ids { get; set; }
}

public class QueryRecruitments : QueryDb<Recruitment>
{
    public int? Id { get; set; }
    public List<int>? Ids { get; set; }
}

public class CreateRecruitment : ICreateDb<Recruitment>, IReturn<IdResponse>
{
    [ValidateNotEmpty]
    public string JobTitle { get; set; }
    [ValidateNotEmpty]
    public string JobDescription { get; set; }
    public RecruitmentStatus Status { get; set; }
    public DateTime PostedDate { get; set; }
    public DateTime ClosingDate { get; set; }
}

public class UpdateRecruitment : IPatchDb<Recruitment>, IReturn<IdResponse>
{
    public int Id { get; set; }
    public string? JobTitle { get; set; }
    public string? JobDescription { get; set; }
    public RecruitmentStatus? Status { get; set; }
    public DateTime? PostedDate { get; set; }
    public DateTime? ClosingDate { get; set; }
}

public class DeleteRecruitment : IDeleteDb<Recruitment>, IReturnVoid
{
    public int? Id { get; set; }
    public List<int>? Ids { get; set; }
}

public class QueryOnboardings : QueryDb<Onboarding>
{
    public int? Id { get; set; }
    public List<int>? Ids { get; set; }
}

public class CreateOnboarding : ICreateDb<Onboarding>, IReturn<IdResponse>
{
    public int EmployeeId { get; set; }
    public DateTime StartDate { get; set; }
    public DateTime EndDate { get; set; }
    [ValidateNotEmpty]
    public string Status { get; set; }
}

public class UpdateOnboarding : IPatchDb<Onboarding>, IReturn<IdResponse>
{
    public int Id { get; set; }
    public int? EmployeeId { get; set; }
    public DateTime? StartDate { get; set; }
    public DateTime? EndDate { get; set; }
    public string? Status { get; set; }
}

public class DeleteOnboarding : IDeleteDb<Onboarding>, IReturnVoid
{
    public int? Id { get; set; }
    public List<int>? Ids { get; set; }
}

public class QueryPerformanceReviews : QueryDb<PerformanceReview>
{
    public int? Id { get; set; }
    public List<int>? Ids { get; set; }
}

public class CreatePerformanceReview : ICreateDb<PerformanceReview>, IReturn<IdResponse>
{
    public int EmployeeId { get; set; }
    public DateTime ReviewDate { get; set; }
    public int ReviewerId { get; set; }
    [ValidateNotEmpty]
    public string Comments { get; set; }
    public int Rating { get; set; }
}

public class UpdatePerformanceReview : IPatchDb<PerformanceReview>, IReturn<IdResponse>
{
    public int Id { get; set; }
    public int? EmployeeId { get; set; }
    public DateTime? ReviewDate { get; set; }
    public int? ReviewerId { get; set; }
    public string? Comments { get; set; }
    public int? Rating { get; set; }
}

public class DeletePerformanceReview : IDeleteDb<PerformanceReview>, IReturnVoid
{
    public int? Id { get; set; }
    public List<int>? Ids { get; set; }
}

public class QueryTrainings : QueryDb<Training>
{
    public int? Id { get; set; }
    public List<int>? Ids { get; set; }
}

public class CreateTraining : ICreateDb<Training>, IReturn<IdResponse>
{
    public int EmployeeId { get; set; }
    [ValidateNotEmpty]
    public string TrainingName { get; set; }
    public DateTime TrainingDate { get; set; }
    public TrainingStatus Status { get; set; }
    [Input(Type="file",Multiple=false)]
    [UploadTo("secure")]
    [ValidateNotEmpty]
    public string Certificate { get; set; }
}

public class UpdateTraining : IPatchDb<Training>, IReturn<IdResponse>
{
    public int Id { get; set; }
    public int? EmployeeId { get; set; }
    public string? TrainingName { get; set; }
    public DateTime? TrainingDate { get; set; }
    public TrainingStatus? Status { get; set; }
    [Input(Type="file",Multiple=false)]
    [UploadTo("secure")]
    public string? Certificate { get; set; }
}

public class DeleteTraining : IDeleteDb<Training>, IReturnVoid
{
    public int? Id { get; set; }
    public List<int>? Ids { get; set; }
}

public class QueryWorkInstructions : QueryDb<WorkInstruction>
{
    public int? Id { get; set; }
    public List<int>? Ids { get; set; }
}

public class CreateWorkInstruction : ICreateDb<WorkInstruction>, IReturn<IdResponse>
{
    [ValidateNotEmpty]
    public string Title { get; set; }
    [ValidateNotEmpty]
    public string Description { get; set; }
    [ValidateNotEmpty]
    public string Version { get; set; }
    public DateTime CreatedDate { get; set; }
    public DateTime UpdatedDate { get; set; }
}

public class UpdateWorkInstruction : IPatchDb<WorkInstruction>, IReturn<IdResponse>
{
    public int Id { get; set; }
    public string? Title { get; set; }
    public string? Description { get; set; }
    public string? Version { get; set; }
    public DateTime? CreatedDate { get; set; }
    public DateTime? UpdatedDate { get; set; }
}

public class DeleteWorkInstruction : IDeleteDb<WorkInstruction>, IReturnVoid
{
    public int? Id { get; set; }
    public List<int>? Ids { get; set; }
}

public class QueryWorkAreas : QueryDb<WorkArea>
{
    public int? Id { get; set; }
    public List<int>? Ids { get; set; }
}

public class CreateWorkArea : ICreateDb<WorkArea>, IReturn<IdResponse>
{
    [ValidateNotEmpty]
    public string Name { get; set; }
    [ValidateNotEmpty]
    public string Description { get; set; }
    public int SupervisorId { get; set; }
    public int ManagerId { get; set; }
}

public class UpdateWorkArea : IPatchDb<WorkArea>, IReturn<IdResponse>
{
    public int Id { get; set; }
    public string? Name { get; set; }
    public string? Description { get; set; }
    public int? SupervisorId { get; set; }
    public int? ManagerId { get; set; }
}

public class DeleteWorkArea : IDeleteDb<WorkArea>, IReturnVoid
{
    public int? Id { get; set; }
    public List<int>? Ids { get; set; }
}

public class QueryWorkAreaStations : QueryDb<WorkAreaStation>
{
    public int? Id { get; set; }
    public List<int>? Ids { get; set; }
}

public class CreateWorkAreaStation : ICreateDb<WorkAreaStation>, IReturn<IdResponse>
{
    public int WorkAreaId { get; set; }
    [ValidateNotEmpty]
    public string StationName { get; set; }
    [ValidateNotEmpty]
    public string Description { get; set; }
}

public class UpdateWorkAreaStation : IPatchDb<WorkAreaStation>, IReturn<IdResponse>
{
    public int Id { get; set; }
    public int? WorkAreaId { get; set; }
    public string? StationName { get; set; }
    public string? Description { get; set; }
}

public class DeleteWorkAreaStation : IDeleteDb<WorkAreaStation>, IReturnVoid
{
    public int? Id { get; set; }
    public List<int>? Ids { get; set; }
}

public class QueryWorkAreaEquipments : QueryDb<WorkAreaEquipment>
{
    public int? Id { get; set; }
    public List<int>? Ids { get; set; }
}

public class CreateWorkAreaEquipment : ICreateDb<WorkAreaEquipment>, IReturn<IdResponse>
{
    public int WorkAreaId { get; set; }
    [ValidateNotEmpty]
    public string EquipmentName { get; set; }
    [ValidateNotEmpty]
    public string Description { get; set; }
}

public class UpdateWorkAreaEquipment : IPatchDb<WorkAreaEquipment>, IReturn<IdResponse>
{
    public int Id { get; set; }
    public int? WorkAreaId { get; set; }
    public string? EquipmentName { get; set; }
    public string? Description { get; set; }
}

public class DeleteWorkAreaEquipment : IDeleteDb<WorkAreaEquipment>, IReturnVoid
{
    public int? Id { get; set; }
    public List<int>? Ids { get; set; }
}

public class QueryWorkAreaCheckSheets : QueryDb<WorkAreaCheckSheet>
{
    public int? Id { get; set; }
    public List<int>? Ids { get; set; }
}

public class CreateWorkAreaCheckSheet : ICreateDb<WorkAreaCheckSheet>, IReturn<IdResponse>
{
    public int WorkAreaId { get; set; }
    [ValidateNotEmpty]
    public string CheckSheetName { get; set; }
    [ValidateNotEmpty]
    public string Description { get; set; }
}

public class UpdateWorkAreaCheckSheet : IPatchDb<WorkAreaCheckSheet>, IReturn<IdResponse>
{
    public int Id { get; set; }
    public int? WorkAreaId { get; set; }
    public string? CheckSheetName { get; set; }
    public string? Description { get; set; }
}

public class DeleteWorkAreaCheckSheet : IDeleteDb<WorkAreaCheckSheet>, IReturnVoid
{
    public int? Id { get; set; }
    public List<int>? Ids { get; set; }
}

public class QueryWorkAreaDetails : QueryDb<WorkAreaDetail>
{
    public int? Id { get; set; }
    public List<int>? Ids { get; set; }
}

public class CreateWorkAreaDetail : ICreateDb<WorkAreaDetail>, IReturn<IdResponse>
{
    public int WorkAreaId { get; set; }
    [ValidateNotEmpty]
    public string DetailName { get; set; }
    [ValidateNotEmpty]
    public string Description { get; set; }
}

public class UpdateWorkAreaDetail : IPatchDb<WorkAreaDetail>, IReturn<IdResponse>
{
    public int Id { get; set; }
    public int? WorkAreaId { get; set; }
    public string? DetailName { get; set; }
    public string? Description { get; set; }
}

public class DeleteWorkAreaDetail : IDeleteDb<WorkAreaDetail>, IReturnVoid
{
    public int? Id { get; set; }
    public List<int>? Ids { get; set; }
}

public class QueryProducts : QueryDb<Product>
{
    public int? Id { get; set; }
    public List<int>? Ids { get; set; }
}

public class CreateProduct : ICreateDb<Product>, IReturn<IdResponse>
{
    [ValidateNotEmpty]
    public string Name { get; set; }
    [ValidateNotEmpty]
    public string Description { get; set; }
    public int SupplierId { get; set; }
}

public class UpdateProduct : IPatchDb<Product>, IReturn<IdResponse>
{
    public int Id { get; set; }
    public string? Name { get; set; }
    public string? Description { get; set; }
    public int? SupplierId { get; set; }
}

public class DeleteProduct : IDeleteDb<Product>, IReturnVoid
{
    public int? Id { get; set; }
    public List<int>? Ids { get; set; }
}

public class QueryQualityAuditProductCheckSheets : QueryDb<QualityAuditProductCheckSheet>
{
    public int? Id { get; set; }
    public List<int>? Ids { get; set; }
}

public class CreateQualityAuditProductCheckSheet : ICreateDb<QualityAuditProductCheckSheet>, IReturn<IdResponse>
{
    public int ProductId { get; set; }
    [ValidateNotEmpty]
    public string CheckSheetName { get; set; }
    [ValidateNotEmpty]
    public string Description { get; set; }
}

public class UpdateQualityAuditProductCheckSheet : IPatchDb<QualityAuditProductCheckSheet>, IReturn<IdResponse>
{
    public int Id { get; set; }
    public int? ProductId { get; set; }
    public string? CheckSheetName { get; set; }
    public string? Description { get; set; }
}

public class DeleteQualityAuditProductCheckSheet : IDeleteDb<QualityAuditProductCheckSheet>, IReturnVoid
{
    public int? Id { get; set; }
    public List<int>? Ids { get; set; }
}

public class QuerySuppliers : QueryDb<Supplier>
{
    public int? Id { get; set; }
    public List<int>? Ids { get; set; }
}

public class CreateSupplier : ICreateDb<Supplier>, IReturn<IdResponse>
{
    [ValidateNotEmpty]
    public string Name { get; set; }
    [ValidateNotEmpty]
    public string ContactPerson { get; set; }
    [ValidateNotEmpty]
    public string Email { get; set; }
    [ValidateNotEmpty]
    public string PhoneNumber { get; set; }
    [ValidateNotEmpty]
    public string Address { get; set; }
}

public class UpdateSupplier : IPatchDb<Supplier>, IReturn<IdResponse>
{
    public int Id { get; set; }
    public string? Name { get; set; }
    public string? ContactPerson { get; set; }
    public string? Email { get; set; }
    public string? PhoneNumber { get; set; }
    public string? Address { get; set; }
}

public class DeleteSupplier : IDeleteDb<Supplier>, IReturnVoid
{
    public int? Id { get; set; }
    public List<int>? Ids { get; set; }
}

public class QuerySupplierQualities : QueryDb<SupplierQuality>
{
    public int? Id { get; set; }
    public List<int>? Ids { get; set; }
}

public class CreateSupplierQuality : ICreateDb<SupplierQuality>, IReturn<IdResponse>
{
    public int SupplierId { get; set; }
    public int QualityScore { get; set; }
    public DateTime AuditDate { get; set; }
    [ValidateNotEmpty]
    public string Comments { get; set; }
}

public class UpdateSupplierQuality : IPatchDb<SupplierQuality>, IReturn<IdResponse>
{
    public int Id { get; set; }
    public int? SupplierId { get; set; }
    public int? QualityScore { get; set; }
    public DateTime? AuditDate { get; set; }
    public string? Comments { get; set; }
}

public class DeleteSupplierQuality : IDeleteDb<SupplierQuality>, IReturnVoid
{
    public int? Id { get; set; }
    public List<int>? Ids { get; set; }
}

public class QueryProductionTrackings : QueryDb<ProductionTracking>
{
    public int? Id { get; set; }
    public List<int>? Ids { get; set; }
}

public class CreateProductionTracking : ICreateDb<ProductionTracking>, IReturn<IdResponse>
{
    public int ProductId { get; set; }
    public int QuantityProduced { get; set; }
    public DateTime ProductionDate { get; set; }
    public int WorkAreaId { get; set; }
}

public class UpdateProductionTracking : IPatchDb<ProductionTracking>, IReturn<IdResponse>
{
    public int Id { get; set; }
    public int? ProductId { get; set; }
    public int? QuantityProduced { get; set; }
    public DateTime? ProductionDate { get; set; }
    public int? WorkAreaId { get; set; }
}

public class DeleteProductionTracking : IDeleteDb<ProductionTracking>, IReturnVoid
{
    public int? Id { get; set; }
    public List<int>? Ids { get; set; }
}

public class QueryMachineEffectivenesses : QueryDb<MachineEffectiveness>
{
    public int? Id { get; set; }
    public List<int>? Ids { get; set; }
}

public class CreateMachineEffectiveness : ICreateDb<MachineEffectiveness>, IReturn<IdResponse>
{
    public int MachineId { get; set; }
    public int EffectivenessScore { get; set; }
    public DateTime AuditDate { get; set; }
    [ValidateNotEmpty]
    public string Comments { get; set; }
}

public class UpdateMachineEffectiveness : IPatchDb<MachineEffectiveness>, IReturn<IdResponse>
{
    public int Id { get; set; }
    public int? MachineId { get; set; }
    public int? EffectivenessScore { get; set; }
    public DateTime? AuditDate { get; set; }
    public string? Comments { get; set; }
}

public class DeleteMachineEffectiveness : IDeleteDb<MachineEffectiveness>, IReturnVoid
{
    public int? Id { get; set; }
    public List<int>? Ids { get; set; }
}

public class QueryWorkAreaSupervisors : QueryDb<WorkAreaSupervisor>
{
    public int? Id { get; set; }
    public List<int>? Ids { get; set; }
}

public class CreateWorkAreaSupervisor : ICreateDb<WorkAreaSupervisor>, IReturn<IdResponse>
{
    public int WorkAreaId { get; set; }
    public int SupervisorId { get; set; }
}

public class UpdateWorkAreaSupervisor : IPatchDb<WorkAreaSupervisor>, IReturn<IdResponse>
{
    public int Id { get; set; }
    public int? WorkAreaId { get; set; }
    public int? SupervisorId { get; set; }
}

public class DeleteWorkAreaSupervisor : IDeleteDb<WorkAreaSupervisor>, IReturnVoid
{
    public int? Id { get; set; }
    public List<int>? Ids { get; set; }
}

public class QueryWorkAreaManagers : QueryDb<WorkAreaManager>
{
    public int? Id { get; set; }
    public List<int>? Ids { get; set; }
}

public class CreateWorkAreaManager : ICreateDb<WorkAreaManager>, IReturn<IdResponse>
{
    public int WorkAreaId { get; set; }
    public int ManagerId { get; set; }
}

public class UpdateWorkAreaManager : IPatchDb<WorkAreaManager>, IReturn<IdResponse>
{
    public int Id { get; set; }
    public int? WorkAreaId { get; set; }
    public int? ManagerId { get; set; }
}

public class DeleteWorkAreaManager : IDeleteDb<WorkAreaManager>, IReturnVoid
{
    public int? Id { get; set; }
    public List<int>? Ids { get; set; }
}

public class QueryWorkAreaRoleAssignments : QueryDb<WorkAreaRoleAssignment>
{
    public int? Id { get; set; }
    public List<int>? Ids { get; set; }
}

public class CreateWorkAreaRoleAssignment : ICreateDb<WorkAreaRoleAssignment>, IReturn<IdResponse>
{
    public int WorkAreaId { get; set; }
    public int EmployeeId { get; set; }
    public WorkAreaRole Role { get; set; }
}

public class UpdateWorkAreaRoleAssignment : IPatchDb<WorkAreaRoleAssignment>, IReturn<IdResponse>
{
    public int Id { get; set; }
    public int? WorkAreaId { get; set; }
    public int? EmployeeId { get; set; }
    public WorkAreaRole? Role { get; set; }
}

public class DeleteWorkAreaRoleAssignment : IDeleteDb<WorkAreaRoleAssignment>, IReturnVoid
{
    public int? Id { get; set; }
    public List<int>? Ids { get; set; }
}

public class QueryWorkInstructionSteps : QueryDb<WorkInstructionStep>
{
    public int? Id { get; set; }
    public List<int>? Ids { get; set; }
}

public class CreateWorkInstructionStep : ICreateDb<WorkInstructionStep>, IReturn<IdResponse>
{
    public int WorkInstructionId { get; set; }
    public int StepNumber { get; set; }
    [ValidateNotEmpty]
    public string Description { get; set; }
}

public class UpdateWorkInstructionStep : IPatchDb<WorkInstructionStep>, IReturn<IdResponse>
{
    public int Id { get; set; }
    public int? WorkInstructionId { get; set; }
    public int? StepNumber { get; set; }
    public string? Description { get; set; }
}

public class DeleteWorkInstructionStep : IDeleteDb<WorkInstructionStep>, IReturnVoid
{
    public int? Id { get; set; }
    public List<int>? Ids { get; set; }
}

public class QueryWorkInstructionModelDetails : QueryDb<WorkInstructionModelDetail>
{
    public int? Id { get; set; }
    public List<int>? Ids { get; set; }
}

public class CreateWorkInstructionModelDetail : ICreateDb<WorkInstructionModelDetail>, IReturn<IdResponse>
{
    public int WorkInstructionId { get; set; }
    [ValidateNotEmpty]
    public string ModelDetail { get; set; }
}

public class UpdateWorkInstructionModelDetail : IPatchDb<WorkInstructionModelDetail>, IReturn<IdResponse>
{
    public int Id { get; set; }
    public int? WorkInstructionId { get; set; }
    public string? ModelDetail { get; set; }
}

public class DeleteWorkInstructionModelDetail : IDeleteDb<WorkInstructionModelDetail>, IReturnVoid
{
    public int? Id { get; set; }
    public List<int>? Ids { get; set; }
}

public class QueryMaterialRequirementsPlannings : QueryDb<MaterialRequirementsPlanning>
{
    public int? Id { get; set; }
    public List<int>? Ids { get; set; }
}

public class CreateMaterialRequirementsPlanning : ICreateDb<MaterialRequirementsPlanning>, IReturn<IdResponse>
{
    public int ProductId { get; set; }
    public int RequiredQuantity { get; set; }
    public DateTime PlannedDate { get; set; }
}

public class UpdateMaterialRequirementsPlanning : IPatchDb<MaterialRequirementsPlanning>, IReturn<IdResponse>
{
    public int Id { get; set; }
    public int? ProductId { get; set; }
    public int? RequiredQuantity { get; set; }
    public DateTime? PlannedDate { get; set; }
}

public class DeleteMaterialRequirementsPlanning : IDeleteDb<MaterialRequirementsPlanning>, IReturnVoid
{
    public int? Id { get; set; }
    public List<int>? Ids { get; set; }
}

public class QueryReports : QueryDb<Report>
{
    public int? Id { get; set; }
    public List<int>? Ids { get; set; }
}

public class CreateReport : ICreateDb<Report>, IReturn<IdResponse>
{
    [ValidateNotEmpty]
    public string ReportName { get; set; }
    public DateTime ReportDate { get; set; }
    [ValidateNotEmpty]
    public string ReportData { get; set; }
}

public class UpdateReport : IPatchDb<Report>, IReturn<IdResponse>
{
    public int Id { get; set; }
    public string? ReportName { get; set; }
    public DateTime? ReportDate { get; set; }
    public string? ReportData { get; set; }
}

public class DeleteReport : IDeleteDb<Report>, IReturnVoid
{
    public int? Id { get; set; }
    public List<int>? Ids { get; set; }
}

[AutoApply(Behavior.AuditQuery)]
public class QueryLogs : QueryDb<Log>
{
    public int? Id { get; set; }
    public List<int>? Ids { get; set; }
}

[AutoApply(Behavior.AuditCreate)]
[ValidateIsAuthenticated]
public class CreateLog : ICreateDb<Log>, IReturn<IdResponse>
{
    [ValidateNotEmpty]
    public string Action { get; set; }
    public DateTime Timestamp { get; set; }
}

[AutoApply(Behavior.AuditModify)]
[ValidateIsAuthenticated]
public class UpdateLog : IPatchDb<Log>, IReturn<IdResponse>
{
    public int Id { get; set; }
    public string? Action { get; set; }
    public DateTime? Timestamp { get; set; }
}

[AutoApply(Behavior.AuditSoftDelete)]
[ValidateIsAuthenticated]
public class DeleteLog : IDeleteDb<Log>, IReturnVoid
{
    public int? Id { get; set; }
    public List<int>? Ids { get; set; }
}

public class QueryPermissions : QueryDb<Permission>
{
    public int? Id { get; set; }
    public List<int>? Ids { get; set; }
}

public class CreatePermission : ICreateDb<Permission>, IReturn<IdResponse>
{
    public int WorkAreaId { get; set; }
    public WorkAreaRole Role { get; set; }
    public PermissionLevel PermissionLevel { get; set; }
}

public class UpdatePermission : IPatchDb<Permission>, IReturn<IdResponse>
{
    public int Id { get; set; }
    public int? WorkAreaId { get; set; }
    public WorkAreaRole? Role { get; set; }
    public PermissionLevel? PermissionLevel { get; set; }
}

public class DeletePermission : IDeleteDb<Permission>, IReturnVoid
{
    public int? Id { get; set; }
    public List<int>? Ids { get; set; }
}


/// <summary>
/// Interfaces
/// </summary>
[Icon(Svg="<svg xmlns='http://www.w3.org/2000/svg' width='1em' height='1em' viewBox='0 0 16 16'><path fill='currentColor' d='M5 3a3 3 0 1 1 6 0a3 3 0 0 1-6 0zm7.001 4h-.553l-3.111 6.316L9.5 7.5L8 6L6.5 7.5l1.163 5.816L4.552 7h-.554c-1.999 0-1.999 1.344-1.999 3v5h12v-5c0-1.656 0-3-1.999-3z'/></svg>")]
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

[Icon(Svg="<svg xmlns='http://www.w3.org/2000/svg' width='1em' height='1em' viewBox='0 0 24 24'><path fill='currentColor' d='M20 4H4c-1.11 0-1.99.89-1.99 2L2 18c0 1.11.89 2 2 2h16c1.11 0 2-.89 2-2V6c0-1.11-.89-2-2-2m0 14H4v-6h16zm0-10H4V6h16z'/></svg>")]
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

[Icon(Svg="<svg xmlns='http://www.w3.org/2000/svg' width='1em' height='1em' viewBox='0 0 14 14'><g fill='none' stroke='currentColor' stroke-linecap='round' stroke-linejoin='round'><path d='M13.5 2.5h-7v5h7zm-3.5 0v5M8.5.5l1.5 2l1.5-2M.5 11l2.444 2.036a2 2 0 0 0 1.28.463h6.442c.46 0 .834-.373.834-.833c0-.92-.746-1.667-1.667-1.667H5.354'/><path d='m3.5 10l.75.75a1.06 1.06 0 0 0 1.5-1.5L4.586 8.085A2 2 0 0 0 3.17 7.5H.5'/></g></svg>")]
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

[Icon(Svg="<svg xmlns='http://www.w3.org/2000/svg' width='1em' height='1em' viewBox='0 0 24 24'><path fill='none' stroke='currentColor' stroke-linecap='round' stroke-linejoin='round' stroke-width='2' d='m5 3l4 1.5v12l6-2.5l-2-1l-1-4l7 2.5V16L9 21l-4-2z'/></svg>")]
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

[Icon(Svg="<svg xmlns='http://www.w3.org/2000/svg' width='1em' height='1em' viewBox='0 0 24 24'><path fill='currentColor' d='M9.5 3A6.5 6.5 0 0 1 16 9.5c0 1.61-.59 3.09-1.56 4.23l.27.27h.79l5 5l-1.5 1.5l-5-5v-.79l-.27-.27A6.52 6.52 0 0 1 9.5 16A6.5 6.5 0 0 1 3 9.5A6.5 6.5 0 0 1 9.5 3m0 2C7 5 5 7 5 9.5S7 14 9.5 14S14 12 14 9.5S12 5 9.5 5'/></svg>")]
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

[Icon(Svg="<svg xmlns='http://www.w3.org/2000/svg' width='1em' height='1em' viewBox='0 0 512 512'><path fill='currentColor' d='M464 48c-67.61.29-117.87 9.6-154.24 25.69c-27.14 12-37.76 21.08-37.76 51.84V448c41.57-37.5 78.46-48 224-48V48ZM48 48c67.61.29 117.87 9.6 154.24 25.69c27.14 12 37.76 21.08 37.76 51.84V448c-41.57-37.5-78.46-48-224-48V48Z'/></svg>")]
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

[Icon(Svg="<svg xmlns='http://www.w3.org/2000/svg' width='1em' height='1em' viewBox='0 0 256 256'><path fill='currentColor' d='M188 48a27.75 27.75 0 0 0-12 2.71V44a28 28 0 0 0-54.65-8.6A28 28 0 0 0 80 60v64l-3.82-6.13a28 28 0 0 0-48.6 27.82c16 33.77 28.93 57.72 43.72 72.69C86.24 233.54 103.2 240 128 240a88.1 88.1 0 0 0 88-88V76a28 28 0 0 0-28-28m12 104a72.08 72.08 0 0 1-72 72c-20.38 0-33.51-4.88-45.33-16.85C69.44 193.74 57.26 171 41.9 138.58a6 6 0 0 0-.3-.58a12 12 0 0 1 20.79-12a2 2 0 0 0 .14.23l18.67 30A8 8 0 0 0 96 152V60a12 12 0 0 1 24 0v60a8 8 0 0 0 16 0V44a12 12 0 0 1 24 0v76a8 8 0 0 0 16 0V76a12 12 0 0 1 24 0Z'/></svg>")]
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

[Icon(Svg="<svg xmlns='http://www.w3.org/2000/svg' width='1em' height='1em' viewBox='0 0 256 256'><path fill='currentColor' d='M188 48a27.75 27.75 0 0 0-12 2.71V44a28 28 0 0 0-54.65-8.6A28 28 0 0 0 80 60v64l-3.82-6.13a28 28 0 0 0-48.6 27.82c16 33.77 28.93 57.72 43.72 72.69C86.24 233.54 103.2 240 128 240a88.1 88.1 0 0 0 88-88V76a28 28 0 0 0-28-28m12 104a72.08 72.08 0 0 1-72 72c-20.38 0-33.51-4.88-45.33-16.85C69.44 193.74 57.26 171 41.9 138.58a6 6 0 0 0-.3-.58a12 12 0 0 1 20.79-12a2 2 0 0 0 .14.23l18.67 30A8 8 0 0 0 96 152V60a12 12 0 0 1 24 0v60a8 8 0 0 0 16 0V44a12 12 0 0 1 24 0v76a8 8 0 0 0 16 0V76a12 12 0 0 1 24 0Z'/></svg>")]
public class WorkArea
{
    [AutoIncrement]
    public int Id { get; set; }
    public string Name { get; set; }
    public string Description { get; set; }
    public int SupervisorId { get; set; }
    public int ManagerId { get; set; }
}

[Icon(Svg="<svg xmlns='http://www.w3.org/2000/svg' width='1em' height='1em' viewBox='0 0 256 256'><path fill='currentColor' d='M188 48a27.75 27.75 0 0 0-12 2.71V44a28 28 0 0 0-54.65-8.6A28 28 0 0 0 80 60v64l-3.82-6.13a28 28 0 0 0-48.6 27.82c16 33.77 28.93 57.72 43.72 72.69C86.24 233.54 103.2 240 128 240a88.1 88.1 0 0 0 88-88V76a28 28 0 0 0-28-28m12 104a72.08 72.08 0 0 1-72 72c-20.38 0-33.51-4.88-45.33-16.85C69.44 193.74 57.26 171 41.9 138.58a6 6 0 0 0-.3-.58a12 12 0 0 1 20.79-12a2 2 0 0 0 .14.23l18.67 30A8 8 0 0 0 96 152V60a12 12 0 0 1 24 0v60a8 8 0 0 0 16 0V44a12 12 0 0 1 24 0v76a8 8 0 0 0 16 0V76a12 12 0 0 1 24 0Z'/></svg>")]
public class WorkAreaStation
{
    [AutoIncrement]
    public int Id { get; set; }
    [References(typeof(WorkArea))]
    public int WorkAreaId { get; set; }
    public string StationName { get; set; }
    public string Description { get; set; }
}

[Icon(Svg="<svg xmlns='http://www.w3.org/2000/svg' width='1em' height='1em' viewBox='0 0 24 24'><path fill='none' stroke='currentColor' stroke-linecap='round' stroke-linejoin='round' stroke-width='2' d='M7 10h3V7L6.5 3.5a6 6 0 0 1 8 8l6 6a2 2 0 0 1-3 3l-6-6a6 6 0 0 1-8-8z'/></svg>")]
public class WorkAreaEquipment
{
    [AutoIncrement]
    public int Id { get; set; }
    [References(typeof(WorkArea))]
    public int WorkAreaId { get; set; }
    public string EquipmentName { get; set; }
    public string Description { get; set; }
}

[Icon(Svg="<svg xmlns='http://www.w3.org/2000/svg' width='1em' height='1em' viewBox='0 0 24 24'><path fill='currentColor' d='M5.55 19L2 15.45l1.4-1.4l2.125 2.125l4.25-4.25l1.4 1.425zm0-8L2 7.45l1.4-1.4l2.125 2.125l4.25-4.25l1.4 1.425zM13 17v-2h9v2zm0-8V7h9v2z'/></svg>")]
public class WorkAreaCheckSheet
{
    [AutoIncrement]
    public int Id { get; set; }
    [References(typeof(WorkArea))]
    public int WorkAreaId { get; set; }
    public string CheckSheetName { get; set; }
    public string Description { get; set; }
}

[Icon(Svg="<svg xmlns='http://www.w3.org/2000/svg' width='1em' height='1em' viewBox='0 0 24 24'><path fill='none' stroke='currentColor' stroke-linecap='round' stroke-linejoin='round' stroke-width='2' d='M13 12h8m-8 6h8M13 6h8M3 12h1m-1 6h1M3 6h1m4 6h1m-1 6h1M8 6h1'/></svg>")]
public class WorkAreaDetail
{
    [AutoIncrement]
    public int Id { get; set; }
    [References(typeof(WorkArea))]
    public int WorkAreaId { get; set; }
    public string DetailName { get; set; }
    public string Description { get; set; }
}

[Icon(Svg="<svg xmlns='http://www.w3.org/2000/svg' width='1em' height='1em' viewBox='0 0 24 24'><path fill='currentColor' d='M22 3H2v6h1v11a2 2 0 0 0 2 2h14a2 2 0 0 0 2-2V9h1zM4 5h16v2H4zm15 15H5V9h14zM9 11h6a2 2 0 0 1-2 2h-2a2 2 0 0 1-2-2'/></svg>")]
public class Product
{
    [AutoIncrement]
    public int Id { get; set; }
    public string Name { get; set; }
    public string Description { get; set; }
    [References(typeof(Supplier))]
    public int SupplierId { get; set; }
}

[Icon(Svg="<svg xmlns='http://www.w3.org/2000/svg' width='1em' height='1em' viewBox='0 0 24 24'><path fill='currentColor' d='M5.55 19L2 15.45l1.4-1.4l2.125 2.125l4.25-4.25l1.4 1.425zm0-8L2 7.45l1.4-1.4l2.125 2.125l4.25-4.25l1.4 1.425zM13 17v-2h9v2zm0-8V7h9v2z'/></svg>")]
public class QualityAuditProductCheckSheet
{
    [AutoIncrement]
    public int Id { get; set; }
    [References(typeof(Product))]
    public int ProductId { get; set; }
    public string CheckSheetName { get; set; }
    public string Description { get; set; }
}

[Icon(Svg="<svg xmlns='http://www.w3.org/2000/svg' width='1em' height='1em' viewBox='0 0 24 24'><path fill='currentColor' d='M3 4a2 2 0 0 0-2 2v11h2a3 3 0 0 0 3 3a3 3 0 0 0 3-3h6a3 3 0 0 0 3 3a3 3 0 0 0 3-3h2v-5l-3-4h-3V4m-7 2l4 4l-4 4v-3H4V9h6m7 .5h2.5l1.97 2.5H17M6 15.5A1.5 1.5 0 0 1 7.5 17A1.5 1.5 0 0 1 6 18.5A1.5 1.5 0 0 1 4.5 17A1.5 1.5 0 0 1 6 15.5m12 0a1.5 1.5 0 0 1 1.5 1.5a1.5 1.5 0 0 1-1.5 1.5a1.5 1.5 0 0 1-1.5-1.5a1.5 1.5 0 0 1 1.5-1.5'/></svg>")]
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

[Icon(Svg="<svg xmlns='http://www.w3.org/2000/svg' width='1em' height='1em' viewBox='0 0 24 24'><path fill='currentColor' d='M3 4a2 2 0 0 0-2 2v11h2a3 3 0 0 0 3 3a3 3 0 0 0 3-3h6a3 3 0 0 0 3 3a3 3 0 0 0 3-3h2v-5l-3-4h-3V4m-7 2l4 4l-4 4v-3H4V9h6m7 .5h2.5l1.97 2.5H17M6 15.5A1.5 1.5 0 0 1 7.5 17A1.5 1.5 0 0 1 6 18.5A1.5 1.5 0 0 1 4.5 17A1.5 1.5 0 0 1 6 15.5m12 0a1.5 1.5 0 0 1 1.5 1.5a1.5 1.5 0 0 1-1.5 1.5a1.5 1.5 0 0 1-1.5-1.5a1.5 1.5 0 0 1 1.5-1.5'/></svg>")]
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

[Icon(Svg="<svg xmlns='http://www.w3.org/2000/svg' width='1em' height='1em' viewBox='0 0 24 24'><path fill='currentColor' d='M22 3H2v6h1v11a2 2 0 0 0 2 2h14a2 2 0 0 0 2-2V9h1zM4 5h16v2H4zm15 15H5V9h14zM9 11h6a2 2 0 0 1-2 2h-2a2 2 0 0 1-2-2'/></svg>")]
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

[Icon(Svg="<svg xmlns='http://www.w3.org/2000/svg' width='1em' height='1em' viewBox='0 0 256 256'><path fill='currentColor' d='M188 48a27.75 27.75 0 0 0-12 2.71V44a28 28 0 0 0-54.65-8.6A28 28 0 0 0 80 60v64l-3.82-6.13a28 28 0 0 0-48.6 27.82c16 33.77 28.93 57.72 43.72 72.69C86.24 233.54 103.2 240 128 240a88.1 88.1 0 0 0 88-88V76a28 28 0 0 0-28-28m12 104a72.08 72.08 0 0 1-72 72c-20.38 0-33.51-4.88-45.33-16.85C69.44 193.74 57.26 171 41.9 138.58a6 6 0 0 0-.3-.58a12 12 0 0 1 20.79-12a2 2 0 0 0 .14.23l18.67 30A8 8 0 0 0 96 152V60a12 12 0 0 1 24 0v60a8 8 0 0 0 16 0V44a12 12 0 0 1 24 0v76a8 8 0 0 0 16 0V76a12 12 0 0 1 24 0Z'/></svg>")]
public class WorkAreaSupervisor
{
    [AutoIncrement]
    public int Id { get; set; }
    [References(typeof(WorkArea))]
    public int WorkAreaId { get; set; }
    public int SupervisorId { get; set; }
}

[Icon(Svg="<svg xmlns='http://www.w3.org/2000/svg' width='1em' height='1em' viewBox='0 0 16 16'><path fill='currentColor' d='M5 3a3 3 0 1 1 6 0a3 3 0 0 1-6 0zm7.001 4h-.553l-3.111 6.316L9.5 7.5L8 6L6.5 7.5l1.163 5.816L4.552 7h-.554c-1.999 0-1.999 1.344-1.999 3v5h12v-5c0-1.656 0-3-1.999-3z'/></svg>")]
public class WorkAreaManager
{
    [AutoIncrement]
    public int Id { get; set; }
    [References(typeof(WorkArea))]
    public int WorkAreaId { get; set; }
    public int ManagerId { get; set; }
}

[Icon(Svg="<svg xmlns='http://www.w3.org/2000/svg' width='1em' height='1em' viewBox='0 0 16 16'><path fill='currentColor' d='M6.002 4a1.998 1.998 0 1 1 3.996 0a1.998 1.998 0 0 1-3.996 0M8 3.002a.998.998 0 1 0 0 1.996a.998.998 0 0 0 0-1.996M11 4.5a1.5 1.5 0 1 1 3 0a1.5 1.5 0 0 1-3 0m1.5-.5a.5.5 0 1 0 0 1a.5.5 0 0 0 0-1m-9-1a1.5 1.5 0 1 0 0 3a1.5 1.5 0 0 0 0-3M3 4.5a.5.5 0 1 1 1 0a.5.5 0 0 1-1 0M4.268 7A2 2 0 0 0 4 8H2v2.5a1.5 1.5 0 0 0 2.096 1.377c.074.331.19.647.34.942A2.5 2.5 0 0 1 1 10.5V8a1 1 0 0 1 1-1zm7.296 5.819A2.5 2.5 0 0 0 15 10.5V8a1 1 0 0 0-1-1h-2.268c.17.294.268.635.268 1h2v2.5a1.5 1.5 0 0 1-2.096 1.377q-.114.498-.34.942M6 6.999a1 1 0 0 0-1 1V11a3 3 0 0 0 6 0V8a1 1 0 0 0-1-1zm0 1h4V11a2 2 0 0 1-4 0z'/></svg>")]
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

[Icon(Svg="<svg xmlns='http://www.w3.org/2000/svg' width='1em' height='1em' viewBox='0 0 24 24'><path fill='currentColor' d='M19 15q-1.275 0-2.137-.862T16 12t.863-2.137T19 9t2.138.863T22 12t-.862 2.138T19 15M9 17l-1.4-1.425L10.175 13H2v-2h8.175L7.6 8.4L9 7l5 5z'/></svg>")]
public class WorkInstructionStep
{
    [AutoIncrement]
    public int Id { get; set; }
    [References(typeof(WorkInstruction))]
    public int WorkInstructionId { get; set; }
    public int StepNumber { get; set; }
    public string Description { get; set; }
}

[Icon(Svg="<svg xmlns='http://www.w3.org/2000/svg' width='1em' height='1em' viewBox='0 0 24 24'><path fill='none' stroke='currentColor' stroke-linecap='round' stroke-linejoin='round' stroke-width='2' d='M13 12h8m-8 6h8M13 6h8M3 12h1m-1 6h1M3 6h1m4 6h1m-1 6h1M8 6h1'/></svg>")]
public class WorkInstructionModelDetail
{
    [AutoIncrement]
    public int Id { get; set; }
    [References(typeof(WorkInstruction))]
    public int WorkInstructionId { get; set; }
    public string ModelDetail { get; set; }
}

[Icon(Svg="<svg xmlns='http://www.w3.org/2000/svg' width='1em' height='1em' viewBox='0 0 256 256'><path fill='currentColor' d='M188 48a27.75 27.75 0 0 0-12 2.71V44a28 28 0 0 0-54.65-8.6A28 28 0 0 0 80 60v64l-3.82-6.13a28 28 0 0 0-48.6 27.82c16 33.77 28.93 57.72 43.72 72.69C86.24 233.54 103.2 240 128 240a88.1 88.1 0 0 0 88-88V76a28 28 0 0 0-28-28m12 104a72.08 72.08 0 0 1-72 72c-20.38 0-33.51-4.88-45.33-16.85C69.44 193.74 57.26 171 41.9 138.58a6 6 0 0 0-.3-.58a12 12 0 0 1 20.79-12a2 2 0 0 0 .14.23l18.67 30A8 8 0 0 0 96 152V60a12 12 0 0 1 24 0v60a8 8 0 0 0 16 0V44a12 12 0 0 1 24 0v76a8 8 0 0 0 16 0V76a12 12 0 0 1 24 0Z'/></svg>")]
public class MaterialRequirementsPlanning
{
    [AutoIncrement]
    public int Id { get; set; }
    [References(typeof(Product))]
    public int ProductId { get; set; }
    public int RequiredQuantity { get; set; }
    public DateTime PlannedDate { get; set; }
}

[Icon(Svg="<svg xmlns='http://www.w3.org/2000/svg' width='1em' height='1em' viewBox='0 0 24 24'><path fill='none' stroke='currentColor' stroke-linecap='round' stroke-linejoin='round' stroke-width='1.5' d='M3 3v1.5M3 21v-6m0 0l2.77-.693a9 9 0 0 1 6.208.682l.108.054a9 9 0 0 0 6.086.71l3.114-.732a48.524 48.524 0 0 1-.005-10.499l-3.11.732a9 9 0 0 1-6.085-.711l-.108-.054a9 9 0 0 0-6.208-.682L3 4.5M3 15V4.5'></path></svg>")]
public class Report
{
    [AutoIncrement]
    public int Id { get; set; }
    public string ReportName { get; set; }
    public DateTime ReportDate { get; set; }
    public string ReportData { get; set; }
}

[Icon(Svg="<svg xmlns='http://www.w3.org/2000/svg' width='1em' height='1em' viewBox='0 0 24 24'><path fill='none' stroke='currentColor' stroke-linecap='round' stroke-linejoin='round' stroke-width='2' d='M13 12h8m-8 6h8M13 6h8M3 12h1m-1 6h1M3 6h1m4 6h1m-1 6h1M8 6h1'/></svg>")]
public class Log : AuditBase
{
    [AutoIncrement]
    public int Id { get; set; }
    public string Action { get; set; }
    public DateTime Timestamp { get; set; }
}

[Icon(Svg="<svg xmlns='http://www.w3.org/2000/svg' width='1em' height='1em' viewBox='0 0 24 24'><path fill='currentColor' d='M12 13a1.49 1.49 0 0 0-1 2.61V17a1 1 0 0 0 2 0v-1.39A1.49 1.49 0 0 0 12 13m5-4V7A5 5 0 0 0 7 7v2a3 3 0 0 0-3 3v7a3 3 0 0 0 3 3h10a3 3 0 0 0 3-3v-7a3 3 0 0 0-3-3M9 7a3 3 0 0 1 6 0v2H9Zm9 12a1 1 0 0 1-1 1H7a1 1 0 0 1-1-1v-7a1 1 0 0 1 1-1h10a1 1 0 0 1 1 1Z'/></svg>")]
public class Permission
{
    [AutoIncrement]
    public int Id { get; set; }
    [References(typeof(WorkArea))]
    public int WorkAreaId { get; set; }
    public WorkAreaRole Role { get; set; }
    public PermissionLevel PermissionLevel { get; set; }
}


[Description("Enums")]
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

