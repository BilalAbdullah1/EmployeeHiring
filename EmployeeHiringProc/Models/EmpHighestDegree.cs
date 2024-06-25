using System;
using System.Collections.Generic;

namespace EmployeeHiringProc.Models;

public partial class EmpHighestDegree
{
    public int EmpHdid { get; set; }

    public string Degree { get; set; } = null!;

    public virtual ICollection<Employee> Employees { get; set; } = new List<Employee>();
}
