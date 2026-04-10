using Company.Osama.DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Company.Osama.BLL.Interfaces
{
    public interface IDepartmentRepository
    {
        IEnumerable<Department> getAll();

        Department? get(int id);

        int add(Department department);
        int update(Department department);
        int delete(Department department);
    }
}
