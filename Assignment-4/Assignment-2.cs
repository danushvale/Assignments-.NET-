using System;
using System.Collections.Generic;
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
            SqlConnection conn = new SqlConnection(connStr);
            // conn.ConnectionString = connStr;

            string cmdText = "insert into product VALUES(7, 'JBL Speakers', 3500, 40, 'Electronics')";
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conn;
            cmd.CommandText = cmdText;

            conn.Open();
            Console.WriteLine("Connected to Database successfully");

            int n = cmd.ExecuteNonQuery();  // For DML:  Insert, update, delete

            Console.WriteLine("No. of rows affected :" + n);
            conn.Close();
            Console.ReadLine();
        }
    }
}