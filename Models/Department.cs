using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;


namespace IPT03
{
    public class Department
    {
        [Key]
        public Guid DeptId { get; set; }
        public string DeptName { get; set; }
        public string DeptDesc { get; set; }
    }
}
