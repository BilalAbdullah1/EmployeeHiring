using System;
using System.Collections.Generic;

namespace EmployeeHiringProc.Models;

public partial class EmpSubjectTaught
{
    public int EmpStid { get; set; }

    public string Subjects { get; set; } = null!;

    public virtual ICollection<Employee> Employees { get; set; } = new List<Employee>();
}
