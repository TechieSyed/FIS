using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


using System.Data;
using System.Data.SqlClient;


namespace Demo01_ConnectWithDb
{
    class Program
    {
        static void Main(string[] args)
        {
            var ConnectionString = @"data source=(localdb)\MSSQLLocalDB; database=FISDemo; integrated security=true;";
            using (var Connection = new SqlConnection(ConnectionString))
            {
                try
                {
                    Connection.Open();
                    Console.WriteLine("Connection state after open : " + Connection.State);
                }
                catch (SqlException ex)
                {
                    Console.WriteLine("Error : {0}", ex.Message);
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Error : {0}", ex.Message);
                }
                finally
                {
                    Connection.Close();
                    Console.WriteLine("Connection state after close : " + Connection.State);
                }
            }
            Console.ReadKey();
        }
    }
}
