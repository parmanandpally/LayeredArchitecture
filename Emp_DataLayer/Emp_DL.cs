using System;
using System.Collections.Generic;
using Emp_ModelLibrary;

namespace Emp_DataLayer
{
    public class Emp_DL
    {
        List<Employee> empList = new List<Employee>();

        public void AddEmployee(Employee emp)
        {
            empList.Add(emp);
        }
        public Employee SearchEmployee(int empid)
        {
            Employee emp=empList.Find(e=>e.EmployeeId==empid);
            if (emp!=null)
                return emp;
            else
                return null;
        }
        public bool DeleteEmployee(int empid)
        {
            Employee emp = empList.Find(e=>e.EmployeeId==empid);
            if (emp!=null)
            {
                empList.Remove(emp);
                return true;
            }
            else
                return false;
        }
        public bool EditEmployee(int empid, Employee newEmp)
        {
            Employee emp = empList.Find(e=>e.EmployeeId==empid);
            if (emp!=null)
            {
                emp.EmployeeName=newEmp.EmployeeName;
                emp.Salary=newEmp.Salary;
                emp.JoinDate=newEmp.JoinDate;
                return true;
            }
            else
                return false;
        }

        public List<Employee> GetAllEmployees()
        {
            return empList;
        }
    }
}