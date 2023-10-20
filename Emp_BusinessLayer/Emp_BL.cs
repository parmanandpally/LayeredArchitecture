using Emp_DataLayer;
using Emp_ModelLibrary;

namespace Emp_BusinessLayer
{
    public class Emp_BL
    {
        Emp_DL dl = new Emp_DL();

        public void AddEmployee(Employee emp)
        {
            dl.AddEmployee(emp);
        }

        public Employee SearchEmployee(int empid)
        {
            Employee e = dl.SearchEmployee(empid);
            return e;

           // return dl.SearchEmployee(empid);
        }
        public bool DeleteEmployee(int empid)
        {
            bool b =  dl.DeleteEmployee(empid);
            return b;
        }
        public bool EditEmployee(int empid, Employee newEmp)
        {
            bool b = dl.EditEmployee(empid,newEmp);
            return b;
        }

        public List<Employee> GetAllEmployees()
        {
            List<Employee> empList = dl.GetAllEmployees();
            return empList;
        }
    }
}