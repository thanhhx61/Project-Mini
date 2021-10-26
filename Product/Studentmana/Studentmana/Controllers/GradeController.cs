using Microsoft.AspNetCore.Mvc;
using Studentmana.Entities;
using Studentmana.Models;
using Studentmana.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Studentmana.Controllers
{
    public class GradeController : Controller
    {
        private readonly IGradeService gradeService;

        public GradeController(IGradeService gradeService)
        {
            this.gradeService = gradeService;
        }
        public async Task<IActionResult> Index()
        {
            List<Entities.Grade> list = await gradeService.GetListGrade();

            return View(list);
        }

        public async Task<IActionResult> Create(CreateGrade createGrade)
        {
            if (ModelState.IsValid)
            {
                var newGrade = new Grade()
                {
                    GradeName = createGrade.GradeName,
                    IsDeleted = true
                };
                await gradeService.Create(newGrade);
                return RedirectToAction("Index", "Grade");
            }
            return View();
        }
        [HttpGet("/Grade/Remove/{gradeId}")]
        public async Task<IActionResult> Remove(int gradeId)
        {
            await gradeService.Remove(gradeId);
            return RedirectToAction("Index");
        }
    }
}
