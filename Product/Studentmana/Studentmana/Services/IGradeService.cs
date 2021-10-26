using Studentmana.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Studentmana.Services
{
    public interface IGradeService
    {
        Task<List<Grade>> GetListGrade();
        Task<Grade> GetGradeById(int gradeId);
        Task<Grade> Create(Grade createGrade);
        Task<Grade> Remove(int graId);
    }
}
