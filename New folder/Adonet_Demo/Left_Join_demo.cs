using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adonet_Demo
{
    class Left_Join_demo
    {

        static void Main(string[] args)
        {
            new Left_Join_demo().CreateTable();
        }

        public void CreateTable()
        {
            SqlConnection con = null;
            try
            {
                // Creating Connection  
                con = new SqlConnection("data source=.; database=My_Database; integrated security=SSPI");
                // writing sql query  
                SqlCommand cm = new SqlCommand("SELECT Course_details.Course_ID, Student_details1.Name, Student_details1.AGE,Course_details.Course_Name FROM Student_details1 LEFT JOIN Course_details ON Student_details1.ROLL_NO = Course_details.Student_id; ", con);
                // Opening Connection  
                con.Open();
                // Executing the SQL query  
                SqlDataReader sdr = cm.ExecuteReader();
                // Iterating Data  
                while (sdr.Read())
                {

                    Console.WriteLine(sdr["Course_ID"] + " " + sdr["Name"] + " " + sdr["Age"]+"  "+sdr["Course_Name"]); // Displaying Record  
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

