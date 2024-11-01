using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp14_userTask_1november.Models
{
    public class Employee
    {
        static int _id;
        
        public int _salary;

        public Employee(string name, string surnameName, int age, int departmentNo, int salary ,Positionn position)
        {
            Name = name;
            SurnameName = surnameName;
            Age = age;
            DepartmentNo = departmentNo;
            Position = position;
            Salary = salary;
        }
        public Employee(string name, string surnameName, int age, int departmentNo, int salary)
        {
            Name = name;
            SurnameName = surnameName;
            Age = age;
            DepartmentNo = departmentNo;
            Salary = salary;
        }

        public int Id { get;}
        public string Name { get; set; }
        public string SurnameName { get; set; }
        public int Age { get; set; }
        public int DepartmentNo { get; set; }
        public Positionn Position { get; set; }
        public int Salary
        {
            get { return _salary; }
            set 
            {
                if (value < 345) 
                {
                    throw new Exception("\nemekhaqqi cox azdiii\n");
                }
                _salary = value;
            }
        }



        public void ShowInfo() 
        {
            Console.WriteLine($"\nName-{Name}\nSurnameName{SurnameName}\nAge{Age}\nDepartmentNo{DepartmentNo}\nPosition{Position}\nSalary{Salary}\n");
        }


    }
}
