using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adonet_Demo
{
    class Update_Demo
    {
        static void Main(string[] args)
        {
            new Update_Demo().CreateTable();
        }
        public void CreateTable()
        {
            SqlConnection con = null;
            try
            {
                // Creating Connection  
                con = new SqlConnection("data source=.; database=My_Database; integrated security=SSPI");
                // writing sql query  
                Console.WriteLine("Enter id where u want to update ");
                int id = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Enter name to change ");
                string name = Console.ReadLine();
                SqlCommand cm = new SqlCommand("update student3 set name='"+name+"' where id = '"+id+"'", con);
                // Opening Connection  
                con.Open();
                // Executing the SQL query  
                cm.ExecuteNonQuery();
                Console.WriteLine("Record Updated Successfully");
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

