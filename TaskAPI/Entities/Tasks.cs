using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace TaskAPI.Entities
{
    public class Tasks
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public string TaskName { get; set; }
        public int SupportUserID { get; set; }
        public int ReviewerUserID { get; set; }
        public decimal PercentProgress { get; set; }
        public DateTime PlanStartDate { get; set; }
        public DateTime PlanEndDate { get; set; }
        public decimal PlanTime { get; set; }
        public decimal ActualTime { get; set; }
        public string Description { get; set; }
        public int CreateUserID { get; set; }
        public DateTime CreateDate { get; set; }
        public int LastModifiUserID { get; set; }
        public DateTime LastModifiDate { get; set; }
        public byte IsViolate { get; set; }
        public int AssignedToUserID { get; set; }
        public int TaskTypeID { get; set; }
        public int PriorityID { get; set; }
        public int StepID { get; set; }
    }
}
