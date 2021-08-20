using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace TaskAPI.Entities
{
    public class Projects
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public string ProjectName { get; set; }
        public string Description { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public int LeaderID { get; set; }
        public int CreateUserID { get; set; }
        public DateTime CreateDate { get; set; }
        public int LastModifiUserID { get; set; }
        public DateTime LastModifiDate { get; set; }
        public decimal PercentProgress { get; set; }

    }
}
