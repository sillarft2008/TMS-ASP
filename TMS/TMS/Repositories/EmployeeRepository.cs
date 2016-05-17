using System;
using System.Data.Entity;
using System.Linq;
using System.Linq.Expressions;
using TMS.Models;

namespace TMS.Repositories
{
    public interface IEmployeeRepository
    {
        IQueryable<Employee> All { get; }

        IQueryable<Employee> AllIncluding(
            params Expression<Func<Employee, object>>[] includeProperties);

        Employee Find(int? id);
        void InsertOrUpdate(Employee dude);
        void Delete(int id);

    }
    public class EmployeeRepository : IEmployeeRepository
    {
        ApplicationDbContext context = new ApplicationDbContext();

        public IQueryable<Employee> All
        {
            get { return context.Employees; }
        }

        public IQueryable<Employee> AllIncluding(params Expression<Func<Employee, object>>[] includeProperties)
        {
            IQueryable<Employee> query = context.Employees;
            foreach (var includeProperty in includeProperties)
            {
                query = query.Include(includeProperty);
            }
            return query;
        }

        public Employee Find(int? id)
        {
            return context.Employees.Find(id);
        }

        public void InsertOrUpdate(Employee dude)
        {
            if (dude.Id == default(int)) //if it is default int(0) than it is a new movie
            {
                context.Employees.Add(dude);
            }
            else
            {
                context.Entry(dude).State = EntityState.Modified;
            }
            context.SaveChanges();
        }

        public void Delete(int id)
        {
            Employee dude = context.Employees.Find(id);
            context.Employees.Remove(dude);
            context.SaveChanges();
        }
    }
}