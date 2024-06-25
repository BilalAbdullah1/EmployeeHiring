using System;
using System.Collections.Generic;

namespace EmployeeHiringProc.Models;

public partial class EmpPersonalInfo
{
    public int EmpperId { get; set; }

    public DateTime Dob { get; set; }

    public string Address { get; set; } = null!;

    public int GenderId { get; set; }

    public int EmployeeId { get; set; }

    public virtual Employee Employee { get; set; } = null!;

    public virtual EmpGender Gender { get; set; } = null!;
}
