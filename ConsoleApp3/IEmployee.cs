using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp3
{
   public interface IEmployee
    {
        void AddEmployee();
        public void DeleteEmployee()
        {
            Console.WriteLine("Interface Implementation");                
        }
    }
}
