using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string uname;
            string id;
            int salary;
            string job;

            Console.WriteLine("enter your Id : ");
            id = Console.ReadLine();

            Console.WriteLine("enter your name: ");
            uname = Console.ReadLine();

            Console.WriteLine("enter your Job : ");
            job = Console.ReadLine();

            Console.WriteLine("enter your Salary : ");
            salary = int.Parse(Console.ReadLine());

            Console.WriteLine("--------user details----------");
            Console.WriteLine("ID : " + id);
            Console.WriteLine("Name : " + uname);
            Console.WriteLine("Job : " + job);
            Console.WriteLine("Salary : " + salary);

            


            Console.ReadLine();
        }
    }
}
