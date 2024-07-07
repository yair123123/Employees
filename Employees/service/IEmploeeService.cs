using Employees.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Employees.service
{
    internal interface IEmploeeService
    {
        List<EmployeeModel> GetAll();
        EmployeeModel? GetById(int id);
        EmployeeModel GetByTz(int tz);
        void Create(EmployeeModel employee);
        void Delete(int code);
        void Update(EmployeeModel employee);

    }
}
