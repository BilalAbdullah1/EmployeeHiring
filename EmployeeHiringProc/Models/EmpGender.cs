using System;
using System.Collections.Generic;

namespace EmployeeHiringProc.Models;

public partial class EmpGender
{
    public int EmpGid { get; set; }

    public string Gender { get; set; } = null!;

    public virtual ICollection<Employee> Employees { get; set; } = new List<Employee>();
}
