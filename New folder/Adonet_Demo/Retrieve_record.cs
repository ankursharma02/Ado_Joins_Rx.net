using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adonet_Demo
{
    class Retrieve_record
    {

        static void Main(string[] args)
            {
                new Retrieve_record().CreateTable();
            }
            public void CreateTable()
            {
                SqlConnection con = null;
                try
                {
                    // Creating Connection  
                    con = new SqlConnection("data source=.; database=My_Database; integrated security=SSPI");
                    // writing sql query  
                    SqlCommand cm = new SqlCommand("Select * from student3", con);
                    // Opening Connection  
                    con.Open();
                    // Executing the SQL query  
                    SqlDataReader sdr = cm.ExecuteReader();
                    // Iterating Data  
                    while (sdr.Read())
                    {
                        
                        Console.WriteLine(sdr["id"] + " " + sdr["name"] + " " + sdr["email"]); // Displaying Record  
                    }
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

