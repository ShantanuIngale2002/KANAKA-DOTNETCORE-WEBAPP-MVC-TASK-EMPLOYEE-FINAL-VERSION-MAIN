using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CoreTaskEmployee.Data
{
    public class EmployeeProjectMap
    {
        [Key]
        public int map_id { get; set; } = 0;

       
        [Column("emp_id")]
        public int EmployeeId { get; set; }

        [Column("project_id")]
        public int ProjectId { get; set; }
    }
}
