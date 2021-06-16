using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp3
{
    public class AbstractClassDemo
    {
        public AbstractClassDemo(){
            Console.WriteLine("Parent Class Constructor");
        }
       // public abstract void show();

        public virtual void show1()
        {
            Console.WriteLine("Parent Class method show1");
        }        
        public void show2()
        {
            Console.WriteLine("Parent Class method show2");
        }

    }
}
