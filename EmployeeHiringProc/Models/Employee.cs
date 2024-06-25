using System;
using System.Collections.Generic;

namespace EmployeeHiringProc.Models;

public partial class Employee
{
    public int EmpId { get; set; }

    public string FirstName { get; set; } = null!;

    public string LastName { get; set; } = null!;

    public string Email { get; set; } = null!;

    public DateTime Dob { get; set; }

    public string Address { get; set; } = null!;

    public string FieldOfStudy { get; set; } = null!;

    public string CurrentEmployer { get; set; } = null!;

    public string AreasOfExpertise { get; set; } = null!;

    public string UploadFile { get; set; } = null!;

    public string Certificate { get; set; } = null!;

    public int TeachingLvlsId { get; set; }

    public byte[]? Image { get; set; }

    public int GenderId { get; set; }

    public int GradeId { get; set; }

    public int SubjectId { get; set; }

    public int DegreeId { get; set; }

    public int ExperienceId { get; set; }

    public int ExperienceIdAdd { get; set; }

    public int AvailId { get; set; }

    public string? ImageFile { get; set; }

    public virtual Availibility Avail { get; set; } = null!;

    public virtual EmpHighestDegree Degree { get; set; } = null!;

    public virtual EmpExperience Experience { get; set; } = null!;

    public virtual EmpExperienceAdd ExperienceIdAddNavigation { get; set; } = null!;

    public virtual EmpGender Gender { get; set; } = null!;

    public virtual GradeLevelsTaught Grade { get; set; } = null!;

    public virtual EmpSubjectTaught Subject { get; set; } = null!;

    public virtual PreferredTeachinglvl TeachingLvls { get; set; } = null!;
}
