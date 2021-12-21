using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Assignment.Models
{
    public class Assignments
    {
        [Key]
        public long AssignmentID { get; set; }
        [ForeignKey("EmployeeRefId")]
        public Employee Employee { get; set; }
        public long EmployeeRefId { get; set; }
        public string ActionCode { get; set; }
        public string ActionReasonCode {get; set;}
        public DateTime ActualTerminationDate {get; set;} 
        public string AssignmentCategory {get; set;}
       //assignmentDFF(optional): array
  //assignmentExtraInformation(optional): array
        
        public string AssignmentName { get; set; }
        public string AssignmentNumber {get; set;}
        public DateTime AssignmentProjectedEndDate {get; set;} 
        public string AssignmentStatus {get; set;}
        public long AssignmentStatusTypeId {get; set;}
        public long BusinessUnitId {get; set;}
        public DateTime CreationDate { get; set; }
        public string DefaultExpenseAccount { get; set; }
        public long DepartmentId {get; set;}
        public DateTime EffectiveEndDate { get; set; }
        public DateTime EffectiveStartDate {get; set;} 
       
        public string EndTime {get; set;}
        public string Frequency {get; set;}
        public string FullPartTime {get; set;}
        public long GradeId {get; set;}
        public long GradeLadderId {get; set;}
        public long JobId {get; set;}
        public DateTime LastUpdateDate { get; set; }
        public long LegalEntityId {get; set;}
        
        public long LocationId {get; set;}
        public long ManagerAssignmentId {get; set;}
        public long ManagerId {get; set;}
    }
}
