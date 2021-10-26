using Microsoft.EntityFrameworkCore;
using Studentmana.DBContexts;
using Studentmana.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Studentmana.Services
{
    public class GradeService : IGradeService
    {
        private readonly SchoolDBContext context;
        public GradeService(SchoolDBContext context)
        {
            this.context = context;
        }

        public async Task<Grade> Create(Grade createGrade)
        {
            try
            {
                context.Add(createGrade);
                var graid = await context.SaveChangesAsync();
                createGrade.GradeId = graid;
                return createGrade;
            }
            catch (Exception)
            {
                throw;
            }
        }

        public async Task<Grade> GetGradeById(int gradeId)
        {
            return await context.grades.Include(b => b.Students).FirstOrDefaultAsync(c => c.GradeId == gradeId);
        }

        public async Task<List<Grade>> GetListGrade()
        {
            return await context.grades.Include(b => b.Students).Where(c => c.IsDeleted == true).ToListAsync();
        }

        public async Task<Grade> Remove(int graId)
        {
            try
            {
                var gra = await GetGradeById(graId);
                gra.IsDeleted = false;
                context.Attach(gra);
                context.Entry<Grade>(gra).State = EntityState.Modified;
                await context.SaveChangesAsync();
                return gra;
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
