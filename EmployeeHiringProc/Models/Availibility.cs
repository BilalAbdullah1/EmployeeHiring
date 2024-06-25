using System;
using System.Collections.Generic;

namespace EmployeeHiringProc.Models;

public partial class Availibility
{
    public int EmpAvlId { get; set; }

    public string AvailTime { get; set; } = null!;

    public virtual ICollection<Employee> Employees { get; set; } = new List<Employee>();
}
