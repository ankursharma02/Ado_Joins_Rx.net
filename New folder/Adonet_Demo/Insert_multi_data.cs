using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adonet_Demo
{
    class Insert_multi_data
    {
        static void Main(string[] args)
        {
            new Insert_multi_data().CreateTable();
        }
        public void CreateTable()
        {
            SqlConnection con = null;
            try
            {
                // Creating Connection  
                con = new SqlConnection("data source=.; database=My_Database; integrated security=SSPI");
                // writing sql query
                con.Open();

                DateTime d = new DateTime();
                char ch = 'y';
                while (ch.Equals('y'))
                {
                    Console.WriteLine("Enter ID");
                    int id = Int32.Parse(Console.ReadLine());
                    Console.WriteLine("Enter Name ");
                    string name = Console.ReadLine();
                    Console.WriteLine("email");
                    string email = Console.ReadLine();
                    Console.WriteLine("Enter join date");
                    d = DateTime.Parse(Console.ReadLine());
                    SqlCommand cm = new SqlCommand("insert into student3(id, name, email, join_date)values('"+id+"', '"+name+"', '"+email+"', '"+d+"')", con);
                    // Opening Connection  

                    // Executing the SQL query  
                    cm.ExecuteNonQuery();
                    Console.WriteLine("Enter more value to y  or not for n  <y/n>");
                    ch = char.Parse( Console.ReadLine());
                }
                // Displaying a message  
                Console.WriteLine("All Record Inserted Successfully");
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
