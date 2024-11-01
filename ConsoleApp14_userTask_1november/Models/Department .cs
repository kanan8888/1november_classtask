using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp14_userTask_1november.Models
{
    public class Department
    {
        static int _no;
                
        int _employeeLimit;

        List<Employee> employees=new List<Employee>(); 
        
        
        public int No { get; }
        public int EmployeeLimit {
            get { return _employeeLimit; }
            set
            {
                if (value > 0 && value < 20)
                {
                    _employeeLimit = value;
                }
                else 
                {
                    throw new Exception("\nlimit duzgun deyil\n");
                }
            }
        }








        public void AddEmployee(Employee employee) 
        {
            if (employees.Count <= EmployeeLimit) 
            {
                employees.Add(employee);            
            }
            else
            {
                Console.WriteLine("\nlimit limittttt\n");
            }
        }
        public Employee? GetEmployee(int id)
        {
            if (employees.Find(x => x.Id == id)==null)
            {
                Console.WriteLine("\nbele bir employee yoxdur\n");
            }
            return employees.Find(x=>x.Id==id);
        }
        public List<Employee> GetAllEmployees()
        {
            return employees;
        }
        public List<Employee> GetAllEmployeesBySalary(int salary)
        {
            return employees.FindAll(x => x.Salary == salary);
        }
        public List<Employee> GetAllEmployeesByPosition(Positionn positionn)
        {
            return employees.FindAll(x => x.Position == positionn);
        }
        public List<Employee> GetAllEmployeesByDepartmentNo(int departmentNo) 
        {
            return employees.FindAll(x => x.DepartmentNo == departmentNo);
        }


    }
}
