using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace TaskAPI.Entities
{
    public class Task_Types
    {
        [Key]
        public int Id { get; set; }
        public string TypeName { get; set; }

    }
}
