using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp3
{
    public class Employee : IEmployee, IManager
    {
        void IEmployee.AddEmployee()
        {
            Console.WriteLine("Add Employee method implementation");
        }
        void IManager.AddEmployee()
        {
            Console.WriteLine("Add Employee method implementation from Manager");
        }

        public void DeleteEmployee()
        {
            Console.WriteLine("Delete Employee method implementation");
        }

        //public void AddManager()
        //{
        //    Console.WriteLine("Add Manager method implementation");
        //}

        public void DeleteManager()
        {
            Console.WriteLine("Delete Manager method implementation");
        }

        public void UpdateEmployee()
        {
            Console.WriteLine("Delete Employee method implementation");
        }
    }
}
