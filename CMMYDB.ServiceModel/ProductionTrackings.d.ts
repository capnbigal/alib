/// <reference path="./api.d.ts" />
export type Config = {
  prompt:    "A facility wide App for managing employee data, payroll, benefits administration, recruitment, onboarding, performance management, training, work instructions, training records, work areas, work instruction work area details, work area stations, work area equipment, work area check sheets, work area details, products, quality audit product check sheets, suppliers, supplier quality, production tracking, machine effectiveness, work area supervisor, work area manager, work area roles, work instruction steps, work instruction model details, material requirements planning, reporting platform for everything, logging, permissions based on work area role, access to work area role specific information, CRUD by work area permission, or read only for general area permission"
  api:       "~/CMMYDB.ServiceModel/ProductionTrackings.cs"
  migration: "~/CMMYDB/Migrations/Migration1001.cs"
  uiMjs:     "~/CMMYDB/wwwroot/admin/sections/ProductionTrackings.mjs"
}

// Enums
export enum Gender {
  Male,
  Female,
  Other,
}

export enum PayrollFrequency {
  Weekly,
  BiWeekly,
  Monthly,
}

export enum BenefitType {
  Health,
  Dental,
  Vision,
  Retirement,
}

export enum RecruitmentStatus {
  Open,
  Closed,
  Filled,
}

export enum TrainingStatus {
  NotStarted,
  InProgress,
  Completed,
}

export enum WorkAreaRole {
  Supervisor,
  Manager,
  Operator,
  Technician,
}

export enum PermissionLevel {
  ReadOnly,
  Crud,
}

// Interfaces
export class Employee {
  id: number
  firstName: string
  lastName: string
  gender: Gender
  dateOfBirth: Date
  email: string
  phoneNumber: string
  address: string
  hireDate: Date
  position: string
  departmentId: number
  workAreaId: number
}

export class Payroll {
  id: number
  employeeId: number
  payrollDate: Date
  grossPay: number
  netPay: number
  frequency: PayrollFrequency
}

export class Benefit {
  id: number
  employeeId: number
  benefitType: BenefitType
  coverageAmount: number
  startDate: Date
  endDate: Date
}

export class Recruitment {
  id: number
  jobTitle: string
  jobDescription: string
  status: RecruitmentStatus
  postedDate: Date
  closingDate: Date
}

export class Onboarding {
  id: number
  employeeId: number
  startDate: Date
  endDate: Date
  status: string
}

export class PerformanceReview {
  id: number
  employeeId: number
  reviewDate: Date
  reviewerId: number
  comments: string
  rating: number
}

export class Training {
  id: number
  employeeId: number
  trainingName: string
  trainingDate: Date
  status: TrainingStatus
  @input({type:"file",multiple:false})
  @uploadTo("secure")
  certificate: string
}

export class WorkInstruction {
  id: number
  title: string
  description: string
  version: string
  createdDate: Date
  updatedDate: Date
}

export class WorkArea {
  id: number
  name: string
  description: string
  supervisorId: number
  managerId: number
}

export class WorkAreaStation {
  id: number
  workAreaId: number
  stationName: string
  description: string
}

export class WorkAreaEquipment {
  id: number
  workAreaId: number
  equipmentName: string
  description: string
}

export class WorkAreaCheckSheet {
  id: number
  workAreaId: number
  checkSheetName: string
  description: string
}

export class WorkAreaDetail {
  id: number
  workAreaId: number
  detailName: string
  description: string
}

export class Product {
  id: number
  name: string
  description: string
  supplierId: number
}

export class QualityAuditProductCheckSheet {
  id: number
  productId: number
  checkSheetName: string
  description: string
}

export class Supplier {
  id: number
  name: string
  contactPerson: string
  email: string
  phoneNumber: string
  address: string
}

export class SupplierQuality {
  id: number
  supplierId: number
  qualityScore: number
  auditDate: Date
  comments: string
}

export class ProductionTracking {
  id: number
  productId: number
  quantityProduced: number
  productionDate: Date
  workAreaId: number
}

export class MachineEffectiveness {
  id: number
  machineId: number
  effectivenessScore: number
  auditDate: Date
  comments: string
}

export class WorkAreaSupervisor {
  id: number
  workAreaId: number
  supervisorId: number
}

export class WorkAreaManager {
  id: number
  workAreaId: number
  managerId: number
}

export class WorkAreaRoleAssignment {
  id: number
  workAreaId: number
  employeeId: number
  role: WorkAreaRole
}

export class WorkInstructionStep {
  id: number
  workInstructionId: number
  stepNumber: number
  description: string
}

export class WorkInstructionModelDetail {
  id: number
  workInstructionId: number
  modelDetail: string
}

export class MaterialRequirementsPlanning {
  id: number
  productId: number
  requiredQuantity: number
  plannedDate: Date
}

export class Report {
  id: number
  reportName: string
  reportDate: Date
  reportData: string
}

export class Log extends AuditBase {
  id: number
  action: string
  timestamp: Date
}

export class Permission {
  id: number
  workAreaId: number
  role: WorkAreaRole
  permissionLevel: PermissionLevel
}
