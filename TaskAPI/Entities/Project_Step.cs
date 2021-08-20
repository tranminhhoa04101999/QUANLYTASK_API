using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace TaskAPI.Entities
{
    public class Project_Step
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public string StepName { get; set; }
        public string Description { get; set; }
        public int AssignToUserID { get; set; }
        public int ReviewerUserID { get; set; }
        public int SupportUserID { get; set; }
        public decimal PecentProgress { get; set; }
        public DateTime PlanStartDate { get; set; }
        public DateTime PlanEndDate { get; set; }
        public decimal ActualTime { get; set; }
        public int CreateUserID { get; set; }
        public DateTime CreateDate { get; set; }
        public int LastModifiUserID { get; set; }
        public DateTime LastModifiDate { get; set; }
        public byte DeteleFlg { get; set; }
        public int ProjectID { get; set; }
    }
}
