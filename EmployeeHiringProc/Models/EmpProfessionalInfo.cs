using System;
using System.Collections.Generic;

namespace EmployeeHiringProc.Models;

public partial class EmpProfessionalInfo
{
    public int EmpprofId { get; set; }

    public string FieldOfStudy { get; set; } = null!;

    public string CurrentEmployer { get; set; } = null!;

    public int GradeId { get; set; }

    public int SubjectId { get; set; }

    public int DegreeId { get; set; }

    public int ExperienceId { get; set; }

    public int EmployeeId { get; set; }

    public virtual EmpHighestDegree Degree { get; set; } = null!;

    public virtual Employee Employee { get; set; } = null!;

    public virtual EmpExperience Experience { get; set; } = null!;

    public virtual GradeLevelsTaught Grade { get; set; } = null!;

    public virtual EmpSubjectTaught GradeNavigation { get; set; } = null!;
}
