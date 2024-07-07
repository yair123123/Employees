using Employees.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.VisualBasic;

namespace Employees.service
{
    internal class EmploeeService : IEmploeeService
    {
        internal EmploeeService()
        {
            Init();
        }
        internal List<EmployeeModel> employees = [];
        public void Create(EmployeeModel employee)
        {
            employees.Add(employee);
        }

        public void Delete(int code)
        {
            for (int i = 0; i < employees.Count; i++) 
            {
                if (employees[i].Id == code) 
                {
                    employees.RemoveAt(i);    
                }
            }
        }

        public List<EmployeeModel> GetAll()
        {
            return employees;
        }

        public EmployeeModel? GetById(int id)
        {
            if (employees.Count == 0)
            {
                return null;
            }
            for (int i = 0; i < employees.Count; i++)
            { 
                if (employees[i].Id == id){
                    return employees[i];
                }                 
            }
                return null;
        }
        public EmployeeModel GetByTz(int tz)
        {
            {
                if (employees.Count == 0)
                {
                    return null;
                }
                for (int i = 0; i < employees.Count; i++)
                {
                    if (employees[i].Id == tz)
                    {
                        return employees[i];
                    }
                }
                return null;
            }
        }

        public void Update(EmployeeModel employee)
        {
            for (int i = 0; i < employees.Count; i++) 
            {
                if(employees[i].Id == employee.Id)
                {
                    employees[i] = employee;
                }
            }

        }

        internal void Init()
        {
            employees = 
                [
                new EmployeeModel(212054969,"yair","achrack",Gender.MALE,DateTime.UtcNow,FamilyStatus.Bachelor,"0508813867","0508138567","haneviveim","23","rosh hahain"),
                new EmployeeModel(212054969,"devora","achrack",Gender.FEMALE,DateTime.UtcNow,FamilyStatus.Bachelor,"05088353867","0508138567","haneviveim","23","rosh hahain"),
                new EmployeeModel(212054969,"moshe","achrack",Gender.MALE,DateTime.UtcNow,FamilyStatus.Bachelor,"0508813657","0508538567","haneviveim","23","rosh hahain")
                ];
        }

    }
}
