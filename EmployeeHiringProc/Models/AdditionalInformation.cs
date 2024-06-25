using System;
using System.Collections.Generic;

namespace EmployeeHiringProc.Models;

public partial class AdditionalInformation
{
    public int EmpAddId { get; set; }

    public string AreasOfExpertise { get; set; } = null!;

    public int ExperienceId { get; set; }

    public int AvailId { get; set; }

    public int TeachingLvlsId { get; set; }

    public int EmployeeId { get; set; }

    public virtual Availibility Avail { get; set; } = null!;

    public virtual Employee Employee { get; set; } = null!;

    public virtual EmpExperience Experience { get; set; } = null!;

    public virtual PreferredTeachinglvl TeachingLvls { get; set; } = null!;
}
