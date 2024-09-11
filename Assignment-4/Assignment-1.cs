using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace asgn4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string connStr = "Server=USHYDAVAHMED5; Database=ProductDB; Integrated Security=true";
            string cmdText = "SELECT * FROM product";

            SqlDataAdapter adapter = new SqlDataAdapter(cmdText, connStr);
            DataSet ds = new DataSet();

            adapter.Fill(ds);

            foreach (DataRow row in ds.Tables[0].Rows)
            {
                Console.WriteLine("{0},{1},{2},{3},{4}", row["productid"].ToString(), row["name"].ToString(), row["price"].ToString(), row["quantity"].ToString(), row["category"].ToString());
            }
            Console.ReadLine();
        }
    }
}