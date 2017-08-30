using System;
using System.Runtime.Remoting;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace SharingExample
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void Example1()
        {
            Console.WriteLine(String.Format("The value of PI is {0}", Math.PI));
            Console.WriteLine($"The value of PI is {Math.PI.ToString()}");
            Console.WriteLine($"The value of PI is {Math.PI.ToString("F2")}");
        }

        [TestMethod]
        public void Example2()
        {
            Console.WriteLine($"The value of PI is {Math.PI.ToString("F2")}");
            Console.WriteLine($"The value of PI is {Math.PI:F2}");

        }
        [TestMethod]
        public void Example3()
        {
            var round = true;
            //Console.WriteLine($@" The value of PI is {round ? Math.PI.ToString() : Math.PI.ToString("F2")}");
        }

        [TestMethod]
        public void Example4()
        {
            Customer c = new Customer();
            c.Name = "dustin";
            ShowCustomerName(c);
        }

        private static void ShowCustomerName(Customer c)
        {
            Console.WriteLine($@" The customer's Name is {c?.Name ?? "Name is missing"}");
        }

        [Ignore]
        [TestMethod]
        public void Example5()
        {
            ShowCustomerName(null);
        }

        [TestMethod]
        public void Example6()
        {
            Customer c = new Customer();
            Console.WriteLine($@" The customer's Name is {(string.IsNullOrEmpty(c.Name) ? c.Name : $"Name is {c.DefaultName}")}");
        }
    }

    public class Customer
    {
        public string Name = null;
        public string DefaultName = "Dustin";
    }
}
