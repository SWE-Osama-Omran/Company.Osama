using Company.Osama.BLL.Interfaces;
using Company.Osama.DAL.Data.Contexts;
using Company.Osama.DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Company.Osama.BLL.Repositories
{
    public class DepartmentRepository : IDepartmentRepository
    {
        private readonly CompanyDbContext _context;

        public DepartmentRepository()
        {
            _context = new CompanyDbContext();
        }
        public int add(Department department)
        {

            _context.Departments.Add(department);
            return _context.SaveChanges();
        }

        public int delete(Department department)
        {   
            _context.Departments.Remove(department);
            return _context.SaveChanges();
        }

        public Department? get(int id)
        { 
            return _context.Departments.Find(id);
        }

        public IEnumerable<Department> getAll()
        {   
            return _context.Departments.ToList();
        }

        public int update(Department department)
        {
            _context.Departments.Update(department);
            return _context.SaveChanges();
        }
    }
}
