using System;
using System.Collections.Generic;

namespace EmployeeHiringProc.Models;

public partial class PreferredTeachinglvl
{
    public int EmpptId { get; set; }

    public string TeachingLevels { get; set; } = null!;

    public virtual ICollection<Employee> Employees { get; set; } = new List<Employee>();
}
