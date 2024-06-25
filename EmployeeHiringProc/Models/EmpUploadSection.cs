using System;
using System.Collections.Generic;

namespace EmployeeHiringProc.Models;

public partial class EmpUploadSection
{
    public int EmpUpsecId { get; set; }

    public string UploadFile { get; set; } = null!;

    public string Certificate { get; set; } = null!;

    public int EmployeeId { get; set; }

    public virtual Employee Employee { get; set; } = null!;
}
