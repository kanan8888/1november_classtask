using ConsoleApp14_userTask_1november.Models;

namespace ConsoleApp14_userTask_1november
{
    internal class Program
    {
        static void Main(string[] args)
        {
            File.Create(@"C:\Users\ClassTime\source\repos\ConsoleApp14_userTask_1november\ConsoleApp14_userTask_1november\employees.json");
            
            Department department =new Department();

            Employee emp =new Employee();


        }
    }
}
