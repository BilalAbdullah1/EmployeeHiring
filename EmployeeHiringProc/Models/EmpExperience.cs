using System;
using System.Collections.Generic;

namespace EmployeeHiringProc.Models;

public partial class EmpExperience
{
    public int EmpExpId { get; set; }

    public string Experience { get; set; } = null!;

    public virtual ICollection<Employee> Employees { get; set; } = new List<Employee>();
}
