using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp3
{
    public class MyTestClass
    {
        public string customername;
        public string customertype;

        private void ValidateCustomer()
        {
            //Code to validate the customer
        }

        private void ConnectDB()
        {
            //Code to connect to DB
        }

        public void AddCustomer()
        {
            ValidateCustomer();
            ConnectDB();
            //Code to add the customer to DB
        }

        //public override void show()
        //{
        //    base.show();
        //    Console.WriteLine("Derived class");
        //}
    }
}
