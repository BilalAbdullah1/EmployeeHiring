using System;
using System.Collections.Generic;

namespace EmployeeHiringProc.Models;

public partial class EmpExperienceAdd
{
    public int EmpExpAddId { get; set; }

    public string ExperienceAdd { get; set; } = null!;

    public virtual ICollection<Employee> Employees { get; set; } = new List<Employee>();
}
