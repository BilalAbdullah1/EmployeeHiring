using System;
using System.Collections.Generic;

namespace EmployeeHiringProc.Models;

public partial class GradeLevelsTaught
{
    public int EmpGrdId { get; set; }

    public string Grade { get; set; } = null!;

    public virtual ICollection<Employee> Employees { get; set; } = new List<Employee>();
}
