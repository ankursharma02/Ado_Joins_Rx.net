using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adonet_Demo
{
    class Insertdata_demo
    {
        static void Main(string[] args)
        {
            new Insertdata_demo().CreateTable();
        }
        public void CreateTable()
        {
            SqlConnection con = null;
            try
            {
                // Creating Connection  
                con = new SqlConnection("data source=.; database=My_Database; integrated security=SSPI");
                // writing sql query  
                SqlCommand cm = new SqlCommand("insert into student3(id, name, email, join_date)values('101', 'Ankur sharma', 'a@a.com', '1/12/2017')", con);  
                // Opening Connection  
                con.Open();
                // Executing the SQL query  
                cm.ExecuteNonQuery();
                // Displaying a message  
                Console.WriteLine("Record Inserted Successfully");
            }
            catch (Exception e)
            {
                Console.WriteLine("OOPs, something went wrong." + e);
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
