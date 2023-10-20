using System;
using System.Collections.Generic;
using Emp_BusinessLayer;
using Emp_ModelLibrary;

namespace Emp_PresentationLayer 
{
    public class Program
    {
        public static void Main()
        {
            Emp_BL bl = new Emp_BL();
            Employee emp1 = new Employee {EmployeeId=101,EmployeeName="AAAAAAA",Salary=34000,JoinDate=DateTime.Parse("12-dec-2022")};
            bl.AddEmployee(emp1);
            Employee emp2 = new Employee {EmployeeId=102,EmployeeName="BBBBBAAAAAAA",Salary=34000,JoinDate=DateTime.Parse("12-dec-2022")};
            bl.AddEmployee(emp2);

            List<Employee> empList = bl.GetAllEmployees();
            foreach(Employee e in empList)
            {
                Console.WriteLine("{0},{1},{2},{3}",e.EmployeeId,e.EmployeeName,e.Salary,e.JoinDate);
            }
        }
    }
}