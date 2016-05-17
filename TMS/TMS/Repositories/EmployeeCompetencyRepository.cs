using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Linq.Expressions;
using System.Web;
using TMS.Models;

namespace TMS.Repositories
{
        public interface IEmployeeCompetencyRepository
        {
            IQueryable<Employee_Competency> All { get; }

            IQueryable<Employee_Competency> AllIncluding(
                params Expression<Func<Employee_Competency, object>>[] includeProperties);

            Employee_Competency Find(int? id);
            void InsertOrUpdate(Employee_Competency movieGenres);
            void Delete(int? id);
            void Save();
        }
        public class EmployeeCompetencyRepository : IEmployeeCompetencyRepository
    {
            ApplicationDbContext context = new ApplicationDbContext();

            public IQueryable<Employee_Competency> All
            {
                get { return context.Employee_Competency; }
            }
            public IQueryable<Employee_Competency> AllIncluding(params Expression<Func<Employee_Competency, object>>[] includeProperties)
            {
                IQueryable<Employee_Competency> query = context.Employee_Competency;
                foreach (var includeProperty in includeProperties)
                {
                    query = query.Include(includeProperty);
                }
                return query;
            }

            public Employee_Competency Find(int? id)
            {
                return context.Employee_Competency.Find(id);
            }

            public void InsertOrUpdate(Employee_Competency movieGenres)
            {
                if (movieGenres.Id == default(int)) //if it is default int(0) than it is a new movie
                {
                    context.Employee_Competency.Add(movieGenres);
                }
                else
                {
                    context.Entry(movieGenres).State = EntityState.Added;
                }
                context.SaveChanges();
            }

            public void Delete(int? id)
            {
                Employee_Competency movieGenres = context.Employee_Competency.Find(id);
                context.Employee_Competency.Remove(movieGenres);
                context.SaveChanges();
            }
            public void Save()
            {
                context.SaveChanges();

            }
        }
}
