using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace asgn3
{
    class Product
    {
        public int Pid { get; set; }
        public string Pname { get; set; }
        public string UnitPrice { get; set; }
        public string Quantity { get; set; }
        public string Category { get; set; }

        public override string ToString()
        {
            return string.Format("{0},{1},{2},{3},{4}", Pid, Pname, UnitPrice, Quantity, Category);
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            // Object Initializer
            Product p1 = new Product()
            {
                Pid = 101,
                Pname = "Pencil",
                UnitPrice = "6",
                Quantity = "3",
                Category = "Stationery"
            };

            Product p2 = new Product() { Pid = 102, Pname = "Pen", UnitPrice = "20", Quantity = "8", Category = "Stationery" };

            Product p3 = new Product() { Pid = 103, Pname = "Sharpener", UnitPrice = "7", Quantity = "5", Category = "Stationery" };

            Product p4 = new Product() { Pid = 307, Pname = "Potato Chips", UnitPrice = "30", Quantity = "2", Category = "Food" };

            Product p5 = new Product() { Pid = 410, Pname = "Diary Milk Chocolate", UnitPrice = "55", Quantity = "1", Category = "Food" };

            List<Product> pList = new List<Product>();
            pList.Add(p1);
            pList.Add(p2);
            pList.Add(p3);
            pList.Add(p4);
            pList.Add(p5);



            foreach (Product item in pList)
            {
                Console.WriteLine(item);
            }


            Console.ReadLine();
        }
    }
}
