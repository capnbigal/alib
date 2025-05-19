export default {
    group: "Production Trackings",
    items: {
        Employees: {
            type: 'Employee',
            component: {
                template:`
                <AutoQueryGrid :type="type"
                    selected-columns="id,firstName,lastName,gender,dateOfBirth,email,phoneNumber,address,hireDate,position,departmentId,workAreaId" />
                `,
            },
        },
        Payrolls: {
            type: 'Payroll',
            component: {
                template:`
                <AutoQueryGrid :type="type"
                    selected-columns="id,employeeId,payrollDate,grossPay,netPay,frequency" />
                `,
            },
        },
        Benefits: {
            type: 'Benefit',
            component: {
                template:`
                <AutoQueryGrid :type="type"
                    selected-columns="id,employeeId,benefitType,coverageAmount,startDate,endDate" />
                `,
            },
        },
        Recruitments: {
            type: 'Recruitment',
            component: {
                template:`
                <AutoQueryGrid :type="type"
                    selected-columns="id,jobTitle,jobDescription,status,postedDate,closingDate" />
                `,
            },
        },
        Onboardings: {
            type: 'Onboarding',
            component: {
                template:`
                <AutoQueryGrid :type="type"
                    selected-columns="id,employeeId,startDate,endDate,status" />
                `,
            },
        },
        PerformanceReviews: {
            type: 'PerformanceReview',
            component: {
                template:`
                <AutoQueryGrid :type="type"
                    selected-columns="id,employeeId,reviewDate,reviewerId,comments,rating" />
                `,
            },
        },
        Trainings: {
            type: 'Training',
            component: {
                template:`
                <AutoQueryGrid :type="type"
                    selected-columns="id,employeeId,trainingName,trainingDate,status,certificate" />
                `,
            },
        },
        WorkInstructions: {
            type: 'WorkInstruction',
            component: {
                template:`
                <AutoQueryGrid :type="type"
                    selected-columns="id,title,description,version,createdDate,updatedDate" />
                `,
            },
        },
        WorkAreas: {
            type: 'WorkArea',
            component: {
                template:`
                <AutoQueryGrid :type="type"
                    selected-columns="id,name,description,supervisorId,managerId" />
                `,
            },
        },
        WorkAreaStations: {
            type: 'WorkAreaStation',
            component: {
                template:`
                <AutoQueryGrid :type="type"
                    selected-columns="id,workAreaId,stationName,description" />
                `,
            },
        },
        WorkAreaEquipments: {
            type: 'WorkAreaEquipment',
            component: {
                template:`
                <AutoQueryGrid :type="type"
                    selected-columns="id,workAreaId,equipmentName,description" />
                `,
            },
        },
        WorkAreaCheckSheets: {
            type: 'WorkAreaCheckSheet',
            component: {
                template:`
                <AutoQueryGrid :type="type"
                    selected-columns="id,workAreaId,checkSheetName,description" />
                `,
            },
        },
        WorkAreaDetails: {
            type: 'WorkAreaDetail',
            component: {
                template:`
                <AutoQueryGrid :type="type"
                    selected-columns="id,workAreaId,detailName,description" />
                `,
            },
        },
        Products: {
            type: 'Product',
            component: {
                template:`
                <AutoQueryGrid :type="type"
                    selected-columns="id,name,description,supplierId" />
                `,
            },
        },
        QualityAuditProductCheckSheets: {
            type: 'QualityAuditProductCheckSheet',
            component: {
                template:`
                <AutoQueryGrid :type="type"
                    selected-columns="id,productId,checkSheetName,description" />
                `,
            },
        },
        Suppliers: {
            type: 'Supplier',
            component: {
                template:`
                <AutoQueryGrid :type="type"
                    selected-columns="id,name,contactPerson,email,phoneNumber,address" />
                `,
            },
        },
        SupplierQualities: {
            type: 'SupplierQuality',
            component: {
                template:`
                <AutoQueryGrid :type="type"
                    selected-columns="id,supplierId,qualityScore,auditDate,comments" />
                `,
            },
        },
        ProductionTrackings: {
            type: 'ProductionTracking',
            component: {
                template:`
                <AutoQueryGrid :type="type"
                    selected-columns="id,productId,quantityProduced,productionDate,workAreaId" />
                `,
            },
        },
        MachineEffectivenesses: {
            type: 'MachineEffectiveness',
            component: {
                template:`
                <AutoQueryGrid :type="type"
                    selected-columns="id,machineId,effectivenessScore,auditDate,comments" />
                `,
            },
        },
        WorkAreaSupervisors: {
            type: 'WorkAreaSupervisor',
            component: {
                template:`
                <AutoQueryGrid :type="type"
                    selected-columns="id,workAreaId,supervisorId" />
                `,
            },
        },
        WorkAreaManagers: {
            type: 'WorkAreaManager',
            component: {
                template:`
                <AutoQueryGrid :type="type"
                    selected-columns="id,workAreaId,managerId" />
                `,
            },
        },
        WorkAreaRoleAssignments: {
            type: 'WorkAreaRoleAssignment',
            component: {
                template:`
                <AutoQueryGrid :type="type"
                    selected-columns="id,workAreaId,employeeId,role" />
                `,
            },
        },
        WorkInstructionSteps: {
            type: 'WorkInstructionStep',
            component: {
                template:`
                <AutoQueryGrid :type="type"
                    selected-columns="id,workInstructionId,stepNumber,description" />
                `,
            },
        },
        WorkInstructionModelDetails: {
            type: 'WorkInstructionModelDetail',
            component: {
                template:`
                <AutoQueryGrid :type="type"
                    selected-columns="id,workInstructionId,modelDetail" />
                `,
            },
        },
        MaterialRequirementsPlannings: {
            type: 'MaterialRequirementsPlanning',
            component: {
                template:`
                <AutoQueryGrid :type="type"
                    selected-columns="id,productId,requiredQuantity,plannedDate" />
                `,
            },
        },
        Reports: {
            type: 'Report',
            component: {
                template:`
                <AutoQueryGrid :type="type"
                    selected-columns="id,reportName,reportDate,reportData" />
                `,
            },
        },
        Logs: {
            type: 'Log',
            component: {
                template:`
                <AutoQueryGrid :type="type"
                    selected-columns="id,action,timestamp">
                  <template #formfooter="{ form, type, apis, model, id }">
                    <AuditEvents v-if="form === 'edit'" class="mt-4" :key="id" :type="type" :id="id" />
                  </template>
                </AutoQueryGrid>
                `,
            },
        },
        Permissions: {
            type: 'Permission',
            component: {
                template:`
                <AutoQueryGrid :type="type"
                    selected-columns="id,workAreaId,role,permissionLevel" />
                `,
            },
        },
    }
}