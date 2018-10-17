using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adonet_Demo
{
    class Delete_record_demo
    {
        static void Main(string[] args)
        {
            new Delete_record_demo().CreateTable();
        }
        public void CreateTable()
        {
            SqlConnection con = null;
            try
            {
                // Creating Connection  
                con = new SqlConnection("data source=.; database=My_Database; integrated security=SSPI");
                // writing sql query  
                SqlCommand cm = new SqlCommand("delete from student3 where id = '101'", con);
                // Opening Connection  
                con.Open();
                // Executing the SQL query  
                cm.ExecuteNonQuery();
                Console.WriteLine("Record Deleted Successfully");
            }
            catch (Exception e)
            {
                Console.WriteLine("OOPs, something went wrong.\n" + e);
            }
            // Closing the connection  
            finally
            {
                Console.ReadLine();
                con.Close();
            }
        }
    }
}

