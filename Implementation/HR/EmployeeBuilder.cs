using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Practice.Common;
using Practice.Organization;

namespace Practice.HR
{
    class EmployeeBuilder : IEmployeeBuilder
    {
        Employee EmployeeToBuild;
        public IEmployee Build()
        {
            var EmployeeRef = EmployeeToBuild;
            EmployeeToBuild = null;
            return EmployeeRef;
        }

        public IEmployeeBuilder Department(IDepartment department)
        {
            CheckNewEmployee();
            EmployeeToBuild.Department = department;
            return this;
        }

        public IEmployeeBuilder Department(string department)
        {
            CheckNewEmployee();
            EmployeeToBuild.Department = new Department(department);
            return this;
        }

        public IEmployeeBuilder Name(IName name)
        {
            CheckNewEmployee();
            EmployeeToBuild.Name = new Name(name);
            return this;
        }

        public IEmployeeBuilder Name(string name, string surname, string patronymic)
        {
            CheckNewEmployee();
            EmployeeToBuild.Name = new Name(name, surname, patronymic);
            return this;
        }

        private void CheckNewEmployee()
        {
            if (EmployeeToBuild is null)
            {
                EmployeeToBuild = new Employee();
            }
        }
    }
}
