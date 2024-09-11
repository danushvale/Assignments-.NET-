using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace ConsoleApp2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter Product ID :");
            int pi = int.Parse( Console.ReadLine());

            Console.WriteLine("enter Product Name:");
            string pn = Console.ReadLine();

            Console.WriteLine("enter Unit Price :");
            int up = int.Parse(Console.ReadLine());

            Console.WriteLine("enter Quantity :");
            int q = int.Parse(Console.ReadLine());

            double total = up * q;
            double dis;
            double final;

            if (q >= 10 && q <= 29)
            {
                dis = total * 0.1;
                final = total - (total * 0.1);
                Console.WriteLine("----------Product Details----------");
                Console.WriteLine("ID : " + pi);
                Console.WriteLine("product Name : " + pn);
                Console.WriteLine("Unit Price : " + up);
                Console.WriteLine("Quantity : " + q);
                Console.WriteLine("Total : " + total);
                Console.WriteLine("Discount : "+dis);
                Console.WriteLine("Final Amount : " + final);
            }
            else if (q >= 30 && q <= 49)
            {
                dis = total * 0.2;
                final = total - (total * 0.2);
                Console.WriteLine("----------Product Details----------");
                Console.WriteLine("ID : " + pi);
                Console.WriteLine("product Name : " + pn);
                Console.WriteLine("Unit Price : " + up);
                Console.WriteLine("Quantity : " + q);
                Console.WriteLine("Total : " + total);
                Console.WriteLine("Discount : " + dis);
                Console.WriteLine("Final Amount : " + final);
            }
            else if (q >= 50)
            {
                dis = total * 0.3;
                final = total - (total * 0.3);
                Console.WriteLine("----------Product Details----------");
                Console.WriteLine("ID : " + pi);
                Console.WriteLine("product Name : " + pn);
                Console.WriteLine("Unit Price : " + up);
                Console.WriteLine("Quantity : " + q);
                Console.WriteLine("Total : " + total);
                Console.WriteLine("Discount : " + dis);
                Console.WriteLine("Final Amount : " + final);
            }
            else
            {
                Console.WriteLine("----------Product Details----------");
                Console.WriteLine("ID : " + pi);
                Console.WriteLine("product Name : " + pn);
                Console.WriteLine("Unit Price : " + up);
                Console.WriteLine("Quantity : " + q);
                Console.WriteLine("Total : " + total);
                Console.WriteLine("Discount : Zero");
                Console.WriteLine("Final Amount : " + total);
            }
            Console.ReadLine();
        }
    }
    
}
