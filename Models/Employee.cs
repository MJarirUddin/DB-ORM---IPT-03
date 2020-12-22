using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace IPT03
{
    public class Employee
    {
        public Guid EmployeeId { get; set; }
        public string EmployeeName { get; set; }
        public Guid DepartmentId { get; set; }
        public Department department { get; set; }

    }
}
