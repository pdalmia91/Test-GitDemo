using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp3
{
    class Employee2 : IEmployee
    {
        public void AddEmployee()
        {
            Console.WriteLine("Add Employee2 method implementation");
        }

        public void DeleteEmployee()
        {
            Console.WriteLine("Delete Employee2 method implementation");
        }
    }
}
