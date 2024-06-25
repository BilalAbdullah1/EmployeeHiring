using EmployeeHiringProc.Data;
using EmployeeHiringProc.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;

namespace EmployeeHiringProc.Controllers
{
    public class EmployeeController : Controller
    {
        EmployeeHiringProcessContext _dbcontext;

        public EmployeeController()
        {
            _dbcontext = new EmployeeHiringProcessContext();
        }

        public async Task<IActionResult> Index()
        {
            var data = 
                await _dbcontext.Employees.Include(x => x.Grade)
                .Include(x => x.Avail)
                .Include(x => x.Experience)
                .Include(x => x.ExperienceIdAddNavigation)
                .Include(x => x.Degree)
                .Include(x => x.Subject)
                .Include(x => x.Gender)
                .Include(x => x.TeachingLvls)
                .ToListAsync() ;
            return View(data);
        }

        [HttpGet]
        public IActionResult Create()
        {
            ViewBag.EGender = new SelectList(_dbcontext.EmpGenders, "EmpGid", "Gender");
            ViewBag.EGrade = new SelectList(_dbcontext.GradeLevelsTaughts, "EmpGrdId", "Grade");
            ViewBag.ESubject = new SelectList(_dbcontext.EmpSubjectTaughts, "EmpStid", "Subjects");
            ViewBag.EDegree = new SelectList(_dbcontext.EmpHighestDegrees, "EmpHdid", "Degree");
            ViewBag.EExperiences = new SelectList(_dbcontext.EmpExperiences, "EmpExpId", "Experience");
            ViewBag.EExperiencesAdds = new SelectList(_dbcontext.EmpExperienceAdds, "EmpExpAddId", "ExperienceAdd");
            ViewBag.EAvail = new SelectList(_dbcontext.Availibilities, "EmpAvlId", "AvailTime");
            ViewBag.ETeaching = new SelectList(_dbcontext.PreferredTeachinglvls, "EmpptId", "TeachingLevels");
            return View();
        }

        [HttpPost]
        public IActionResult Create(Employee employee, IFormFile image)
        {
            try
            {
                if (image != null && image.Length > 0)
                {
                    var fileName = Path.GetFileName(image.FileName);
                    string imgfolder = Path.Combine(HttpContext.Request.PathBase.Value, "wwwroot/myfiles");

                    if (!Directory.Exists(imgfolder))
                    {
                        Directory.CreateDirectory(imgfolder);
                    }
                    string filePath = Path.Combine(imgfolder, fileName);
                    using (var stream = new FileStream(filePath, FileMode.Create))
                    {
                        image.CopyTo(stream);
                    }

                    string upload = Path.Combine("myfiles", fileName);
                    employee.ImageFile = upload;

                    _dbcontext.Employees.Add(employee);
                    _dbcontext.SaveChanges();

                    return RedirectToAction("Index");
                }
                else
                {
                    ViewBag.msg = "Kindly select Employee Image";
                }

            }
            catch (Exception ex)
            {
                ViewBag.msg = ex.Message;
            }
            ViewData["EGender"] = new SelectList(_dbcontext.EmpGenders, "EmpGid", "Gender");
            ViewData["EGrade"] = new SelectList(_dbcontext.GradeLevelsTaughts, "EmpGrdId", "Grade");
            ViewData["ESubject"] = new SelectList(_dbcontext.EmpSubjectTaughts, "EmpStid", "Subjects");
            ViewData["EDegree"] = new SelectList(_dbcontext.EmpHighestDegrees, "EmpHdid", "Degree");
            ViewData["EExperiences"] = new SelectList(_dbcontext.EmpExperiences, "EmpExpId", "Experience");
            ViewData["EExperiencesAdds"] = new SelectList(_dbcontext.EmpExperienceAdds, "EmpExpAddId", "ExperienceAdd");
            ViewData["EAvail"] = new SelectList(_dbcontext.Availibilities, "EmpAvlId", "AvailTime");
            ViewData["ETeaching"] = new SelectList(_dbcontext.PreferredTeachinglvls, "EmpptId", "TeachingLevels");
            return View();
        }

    }
}
