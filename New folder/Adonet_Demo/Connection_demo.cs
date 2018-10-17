using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adonet_Demo
{
    class Connection_demo
    {
        static void Main(string[] args)
        {
            new Connection_demo().Connecting();
        }
        public void Connecting()
        {
            using (
                     // Creating Connection  
                     SqlConnection con = new SqlConnection("data source=.; database=My_Database; integrated security=SSPI")
           
                    
                 )
            {
                con.Open();
                Console.WriteLine("Connection Established Successfully");
                Console.ReadLine();
            }
        }
    }
}

